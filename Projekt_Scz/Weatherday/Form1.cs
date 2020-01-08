using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

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
            StreamWriter streamWriter = new StreamWriter("database.json");
            var app2 = new App();
            app2.Cities = cityList;
            var app = JsonConvert.SerializeObject(app2);
                
            streamWriter.Write(app);
            streamWriter.Close();
            streamWriter.Dispose();
            MessageBox.Show("Saved","Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //zapisują się w folderze bin
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory();
            path = path + "/bin/Debug/database.json";
            StreamReader r = new StreamReader("database.json");

            var json = r.ReadToEnd();
            var app = JsonConvert.DeserializeObject<App>(json);
            r.Close();
            r.Dispose();
            var cities = app.Cities;

            foreach(var item in cities)
            {
                lbxCity.Items.Add(item as City);
            }
        }
    }
}
