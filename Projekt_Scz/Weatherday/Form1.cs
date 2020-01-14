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
                string chkString = fileName.Substring(fileName.Length - 4);
                if (chkString != "json")
                {
                    MessageBox.Show("Valid File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                using (fileStream)
                {
                    StreamReader r = new StreamReader(fileName);

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
           }
          
        }

        private void btnChk_Click(object sender, EventArgs e)
        {
            try
            {
                WebRequest request = HttpWebRequest.Create("http://api.openweathermap.org/data/2.5/weather?q=" + tbxCity.Text + "&units=metric&appid=7a85ac809de323dd5c38e422ebce39df");
                WebResponse response = request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());

                string weather_JSON = reader.ReadToEnd();
                RootObject myWeather = Newtonsoft.Json.JsonConvert.DeserializeObject<RootObject>(weather_JSON);

                MessageBox.Show(myWeather.ToString(),"Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(WebException)
            {
                MessageBox.Show($"{tbxCity.Text} it's not a city!","Error" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
