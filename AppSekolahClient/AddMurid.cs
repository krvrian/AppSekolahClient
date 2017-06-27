using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using MetroFramework.Controls;
using System.Net.Http;

namespace AppSekolahClient
{
    public partial class AddMurid : MetroForm
    {
        ListMurid _owner;
        public AddMurid(dynamic owner)
        {
            InitializeComponent();
            _owner = owner;
            this.FormClosing += new FormClosingEventHandler(this.AddMurid_FormClosing);
        }

        private void AddMurid_FormClosing(object sender, FormClosingEventArgs e)
        {
            _owner.MuatData();
        }

        private async void SendData(string url)
        {
            if(tcAddMurid.SelectedIndex == 0)
            {
                var values = new List<KeyValuePair<string, string>>();
                foreach (Control c in tcAddMurid.SelectedTab.Controls)
                {
                    if (c.GetType().Equals(typeof(MetroTextBox)) || c.GetType().Equals(typeof(MetroComboBox)) || c.GetType().Equals(typeof(MetroDateTime)))
                    {
                        values.Add(new KeyValuePair<string, string>(c.Name, c.Text));
                        
                    }
                }
                var content = new FormUrlEncodedContent(values);
                var result = await Credentials.Client.PostAsync(url, content);
                string resultContent = await result.Content.ReadAsStringAsync();
                
            }
            else if (tcAddMurid.SelectedIndex == 2)
            {
                var values = new List<KeyValuePair<string, string>>();
                foreach (Control c in tcAddMurid.SelectedTab.Controls)
                {
                    if (c.GetType().Equals(typeof(MetroTextBox)) || c.GetType().Equals(typeof(MetroComboBox)) || c.GetType().Equals(typeof(MetroDateTime)))
                    {
                        if(c.Name == "parent_type")
                        {
                            values.Add(new KeyValuePair<string, string>(c.Name, c.Text));
                            
                        }
                        else
                        {
                            values.Add(new KeyValuePair<string, string>(c.Name.Substring(c.Name.IndexOf("_") + 1), c.Text));
                            
                        }
                    }
                }
                var content = new FormUrlEncodedContent(values);
                var result = await Credentials.Client.PostAsync(url, content);
                string resultContent = await result.Content.ReadAsStringAsync();
                
            }
            else
            {
                var values = new List<KeyValuePair<string, string>>();
                foreach (Control c in tcAddMurid.SelectedTab.Controls)
                {
                    if (c.GetType().Equals(typeof(MetroTextBox)) || c.GetType().Equals(typeof(MetroComboBox)) || c.GetType().Equals(typeof(MetroDateTime)))
                    {
                        values.Add(new KeyValuePair<string, string>(c.Name, c.Text));
                        
                    }
                }
                var content = new FormUrlEncodedContent(values);
                var result = await Credentials.Client.PostAsync(url, content);
                string resultContent = await result.Content.ReadAsStringAsync();
                
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            SendData("api/student/book/store/main");
            tcAddMurid.SelectedIndex += 1;
        }

        private void metroComboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel39_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel40_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox28_Click(object sender, EventArgs e)
        {

        }

        private void AddMurid_Load(object sender, EventArgs e)
        {
            tcAddMurid.SelectedIndex = 0;
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            SendData("api/student/book/store/hh/" + nis.Text);
            tcAddMurid.SelectedIndex += 1;
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            SendData("api/student/book/store/parent/" + nis.Text);
            tcAddMurid.SelectedIndex += 1;
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            SendData("api/student/book/store/activity/" + nis.Text);
            tcAddMurid.SelectedIndex += 1;
            this.Close();
        }
    }
}
