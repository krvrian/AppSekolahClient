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
using Newtonsoft.Json;

namespace AppSekolahClient
{
    public partial class EditMurid : MetroForm
    {
        ListMurid _owner;
        public EditMurid(dynamic owner)
        {
            InitializeComponent();
            _owner = owner;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditMurid_FormClosing);
        }

        private void EditMurid_FormClosing(object sender, FormClosingEventArgs e)
        {
            _owner.MuatUlang();
        }

        private async void SendData(string url, FormUrlEncodedContent content)
        {
            var result = await Credentials.Client.PutAsync(url, content);
            string resultContent = await result.Content.ReadAsStringAsync();
            
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            var values = new List<KeyValuePair<string, string>>();
            foreach(Control c in tcEditMurid.SelectedTab.Controls)
            {
                if (c.GetType().Equals(typeof(MetroTextBox)) || c.GetType().Equals(typeof(MetroComboBox)) || c.GetType().Equals(typeof(MetroDateTime)) && c.Name != "nis")
                {
                    values.Add(new KeyValuePair<string, string>(c.Name, c.Text));
                }
            }
            var content = new FormUrlEncodedContent(values);
            SendData("api/student/book/update/main/"+nis.Text, content);
            tcEditMurid.SelectedIndex += 1;
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

        private void EditMurid_Load(object sender, EventArgs e)
        {
            LoadData(Credentials.editnis);
            tcEditMurid.SelectedIndex = 0;
        }

        private async void LoadData(string nis)
        {
            
            var response = await Credentials.Client.GetAsync("api/student/book/show/"+nis);
            var content = response.Content;
            var result = await content.ReadAsStringAsync();
            
            if (result != "Tidak Ada Hasil")
            {
                var data = JsonConvert.DeserializeObject<DataSiswa>(result);
                foreach(var item in data.GetType().GetProperties())
                {
                    foreach(TabPage p in tcEditMurid.TabPages)
                    {
                        if (p.Name == "tpDataDiri")
                        {
                            foreach (Control c in p.Controls)
                            {
                                if (c.GetType().Equals(typeof(MetroTextBox)) || c.GetType().Equals(typeof(MetroComboBox)))
                                {
                                    if (c.Name == item.Name)
                                    {
                                        if (item.GetValue(data).Equals(null)) { } else
                                        {
                                            c.Text = item.GetValue(data).ToString();
                                        }
                                    }
                                }
                                else if (c.GetType().Equals(typeof(MetroDateTime)))
                                {
                                    if (c.Name == item.Name)
                                    {
                                        if (item.GetValue(data).Equals(null)) { } else
                                        {
                                            ((MetroDateTime)c).Value = Convert.ToDateTime(item.GetValue(data).ToString());
                                        }
                                    }
                                }
                            }
                        }
                        else if (p.Name == "tpDetailLokasi")
                        {
                            if(item.Name == "studenthome_health")
                            {
                                foreach (var hh in item.GetValue(data).GetType().GetProperties())
                                {
                                    foreach (Control c in p.Controls)
                                    {
                                        if (c.GetType().Equals(typeof(MetroTextBox)) || c.GetType().Equals(typeof(MetroComboBox)))
                                        {
                                            if (c.Name == hh.Name)
                                            {
                                                if (hh.GetValue(item.GetValue(data)).Equals(null))
                                                {

                                                }
                                                else
                                                {
                                                    c.Text = hh.GetValue(item.GetValue(data)).ToString();
                                                }
                                            }
                                        }
                                        else if (c.GetType().Equals(typeof(MetroDateTime)))
                                        {
                                            if (c.Name == hh.Name)
                                            {
                                                if (hh.GetValue(item.GetValue(data)).Equals(null))
                                                {

                                                }
                                                else
                                                {
                                                    ((MetroDateTime)c).Value = Convert.ToDateTime(hh.GetValue(item.GetValue(data)).ToString());
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        else if(p.Name == "tpDataOrtuWali")
                        {
                            if(item.Name == "student_parent")
                            {
                                var pr = (List<Parent>)item.GetValue(data);
                                foreach (var par in pr[0].GetType().GetProperties())
                                {
                                    foreach (Control c in p.Controls)
                                    {
                                        if (c.GetType().Equals(typeof(MetroTextBox)) || c.GetType().Equals(typeof(MetroComboBox)))
                                        {
                                            if (c.Name.Substring(c.Name.IndexOf("_") + 1) == par.Name)
                                            {
                                                if (par.GetValue(pr[0]).Equals(null)) { } else
                                                {
                                                    c.Text = par.GetValue(pr[0]).ToString();
                                                }
                                            }
                                            else if(c.Name == "parent_type")
                                            {
                                                if (par.GetValue(pr[0]).Equals(null)) { } else
                                                {
                                                    c.Text = par.GetValue(pr[0]).ToString();
                                                }
                                            }
                                        }
                                        else if (c.GetType().Equals(typeof(MetroDateTime)))
                                        {
                                            if (c.Name.Substring(c.Name.IndexOf("_") + 1) == par.Name)
                                            {
                                                if (par.GetValue(pr[0]).Equals(null)) { } else
                                                {
                                                    ((MetroDateTime)c).Value = Convert.ToDateTime(par.GetValue(pr[0]).ToString());
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        else if (p.Name == "tpAktivitas")
                        {
                            if (item.Name == "student_activity")
                            {
                                if (item.GetValue(data) == null)
                                {

                                }
                                else
                                {
                                    foreach (var act in item.GetValue(data).GetType().GetProperties())
                                    {
                                        foreach (Control c in p.Controls)
                                        {
                                            if (c.GetType().Equals(typeof(MetroTextBox)) || c.GetType().Equals(typeof(MetroComboBox)))
                                            {
                                                if (c.Name == act.Name)
                                                {
                                                    if (act.GetValue(item.GetValue(data)) != null)
                                                    {
                                                        c.Text = act.GetValue(item.GetValue(data)).ToString();
                                                    }
                                                }
                                            }
                                            else if (c.GetType().Equals(typeof(MetroDateTime)))
                                            {
                                                if (c.Name == act.Name)
                                                {
                                                    if (act.GetValue(item.GetValue(data)) != null)
                                                    {
                                                        ((MetroDateTime)c).Value = Convert.ToDateTime(act.GetValue(item.GetValue(data)).ToString());
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }                
            }
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            var values = new List<KeyValuePair<string, string>>();
            foreach (Control c in tcEditMurid.SelectedTab.Controls)
            {
                if (c.GetType().Equals(typeof(MetroTextBox)) || c.GetType().Equals(typeof(MetroComboBox)) || c.GetType().Equals(typeof(MetroDateTime)) && c.Name != "nis")
                {
                    values.Add(new KeyValuePair<string, string>(c.Name, c.Text));
                }
            }
            var content = new FormUrlEncodedContent(values);
            SendData("api/student/book/update/hh/" + nis.Text, content);
            tcEditMurid.SelectedIndex += 1;
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            var values = new List<KeyValuePair<string, string>>();
            foreach (Control c in tcEditMurid.SelectedTab.Controls)
            {
                if (c.GetType().Equals(typeof(MetroTextBox)) || c.GetType().Equals(typeof(MetroComboBox)) || c.GetType().Equals(typeof(MetroDateTime)) && c.Name != "nis")
                {
                    values.Add(new KeyValuePair<string, string>(c.Name, c.Text));
                }
            }
            var content = new FormUrlEncodedContent(values);
            SendData("api/student/book/update/parent/" + nis.Text, content);
            tcEditMurid.SelectedIndex += 1;
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            var values = new List<KeyValuePair<string, string>>();
            foreach (Control c in tcEditMurid.SelectedTab.Controls)
            {
                if (c.GetType().Equals(typeof(MetroTextBox)) || c.GetType().Equals(typeof(MetroComboBox)) || c.GetType().Equals(typeof(MetroDateTime)) && c.Name != "nis")
                {
                    values.Add(new KeyValuePair<string, string>(c.Name, c.Text));
                }
            }
            var content = new FormUrlEncodedContent(values);
            SendData("api/student/book/update/activity/" + nis.Text, content);
            tcEditMurid.SelectedIndex += 1;

            this.Close();
        }
    }
}
