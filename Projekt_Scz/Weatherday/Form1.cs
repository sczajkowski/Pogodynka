using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using RestEase;
using Weatherday.Models;
namespace Weatherday
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var cityList = new List<City>();

            string name = tbxCity.Text;
            string country = tbxCountry.Text;
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(country))
            {
                MessageBox.Show("Fill data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            lbxCity.Items.Add(new City(country,name));
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (lbxCity.SelectedIndex == -1)
            {
                MessageBox.Show("Select data first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            lbxCity.Items.RemoveAt(lbxCity.SelectedIndex);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lbxCity.SelectedIndex == -1)
            {
                MessageBox.Show("Select data first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var data = lbxCity.SelectedItem as City;
            data.Name = tbxCity.Text;
            data.Country = tbxCountry.Text;
            lbxCity.Items[lbxCity.SelectedIndex] = data as City;
        }

        private void lbxCity_Click(object sender, EventArgs e)
        {
            if (lbxCity.SelectedIndex == -1)
            {
                return;
            }
            var item = lbxCity.SelectedItem as City;
            tbxCity.Text = item.Name;
            tbxCountry.Text = item.Country;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var cityList = new List<City>();

            foreach (var item in lbxCity.Items)
            {
                cityList.Add(item as City);
            }
            if (!cityList.Any()) {
                MessageBox.Show("No data to save!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SaveFileDialog savefileDialog1 = new SaveFileDialog();
            if (savefileDialog1.ShowDialog() == DialogResult.OK)
            {
                savefileDialog1.FileName = savefileDialog1.FileName + ".json";
                using (Stream fileName = File.Open(savefileDialog1.FileName, FileMode.CreateNew))
                using (StreamWriter streamWriter = new StreamWriter(fileName))
                {
                    var app2 = new App();
                    app2.Cities = cityList;
                    var app = JsonConvert.SerializeObject(app2);

                    streamWriter.Write(app);
                    streamWriter.Close();
                    streamWriter.Dispose();
                    MessageBox.Show("Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            Stream fileStream = null;

            if (openFileDialog1.ShowDialog() == DialogResult.OK && (fileStream = openFileDialog1.OpenFile()) != null)
            {
                string fileName = openFileDialog1.FileName;
                string chkString = fileName.Substring(fileName.Length - 5);
                if (chkString != ".json")
                {
                    MessageBox.Show("Valid File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                using (fileStream)
                {
                    StreamReader r = new StreamReader(fileName);
                    try
                    {
                        var json = r.ReadToEnd();
                        var app = JsonConvert.DeserializeObject<App>(json);
                        r.Close();
                        r.Dispose();
                        var cities = app.Cities;

                        foreach (var item in cities)
                        {
                            lbxCity.Items.Add(item as City);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("This file is not database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
               }
           }
          
        }

        private void btnChk_Click(object sender, EventArgs e)
        {
            if (lbxCity.SelectedIndex == -1)
            {
                MessageBox.Show("Select data first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                string unitType = "metric";
                if(btnMetric.Checked == false)
                {
                    unitType = "imperial";
                }
                WebRequest request = HttpWebRequest.Create("http://api.openweathermap.org/data/2.5/weather?q=" + tbxCity.Text + "&units="+unitType+"&appid=7a85ac809de323dd5c38e422ebce39df");
                WebResponse response = request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());

                string weather_JSON = reader.ReadToEnd();
                RootObject myWeather = Newtonsoft.Json.JsonConvert.DeserializeObject<RootObject>(weather_JSON);
                var data = new StringBuilder();
                var desc = myWeather.weather.First();

                data.Append($"{desc.description}");
                if (checkBoxTemp.Checked == true)
                {
                    data.Append($", {myWeather.main.temp.ToString()} degrees ");
                    {
                        if (unitType == "metric") { data.Append("Celsius "); }
                        else { data.Append("Fahrenheit "); }
                    }
                }
                if (checkBoxWind.Checked == true)
                {
                    data.Append($", with wind up to {myWeather.wind.speed.ToString()} ");
                    if (unitType == "metric") { data.Append("m/s "); }
                    else { data.Append("mph "); }
                }
                if (checkBoxClouds.Checked == true)
                {
                    data.Append($", cloudyness : {myWeather.clouds.all.ToString()}% ");
                }
                if(checkBoxPressure.Checked == true)
                {
                    data.Append($", Pressure : {myWeather.main.pressure.ToString()} hPa ");
                }
                if (checkBoxSrise.Checked == true)
                {
                    var ts = UnixTimeStampToDateTime(myWeather.sys.sunrise);
                    data.Append($", Sunrise at {ts.ToString("hh:mm")} AM ");
                }
                if (checkBoxSset.Checked == true)
                {
                    var ts = UnixTimeStampToDateTime(myWeather.sys.sunset);
                    data.Append($", Sunset at {ts.ToString("hh:mm")} PM ");
                }
                reader.Close();
                
                MessageBox.Show(data.ToString(), "Status", MessageBoxButtons.OK, MessageBoxIcon.Information) ;
            }
            catch(WebException)
            {
                MessageBox.Show($"{tbxCity.Text} It's not a city!","Error" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dtDateTime;
        }

        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAll.Checked == true)
            {
                checkBoxClouds.Checked = true;
                checkBoxPressure.Checked = true;
                checkBoxSrise.Checked = true;
                checkBoxSset.Checked = true;
                checkBoxTemp.Checked = true;
                checkBoxWind.Checked = true;
            }
            else
            {
                checkBoxClouds.Checked = false;
                checkBoxPressure.Checked = false;
                checkBoxSrise.Checked = false;
                checkBoxSset.Checked = false;
                checkBoxWind.Checked = false;
            }
        }
    }
}
