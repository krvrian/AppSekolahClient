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
using System.Reflection;
using System.Net.Http.Headers;

namespace AppSekolahClient
{
    public partial class LihatPegawai : MetroForm
    {
        dynamic _owner;
        DataTable dt;
        DataRow dr;
        MetroGrid mg;
        public LihatPegawai(dynamic owner)
        {
            InitializeComponent();
            _owner = owner;
            this.FormClosing += new FormClosingEventHandler(this.LihatPegawai_FormClosing);
            Credentials.Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Credentials.OAuth);
        }

        private void LihatPegawai_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void AddPegawai_Load(object sender, EventArgs e)
        {
            tcPegawai.SelectedIndex = 0;
            dt = new DataTable();
            LoadData(Credentials.editnourut);
        }

        private void btn_Skip_Click(object sender, EventArgs e)
        {
            tcPegawai.SelectedIndex += 1;
        }

        private void tcPegawai_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private bool check()
        {
            int i = 0;
            foreach(Control c in tcPegawai.SelectedTab.Controls)
            {
                if (c.GetType().Equals(typeof(MetroGrid)))
                {
                    mg = ((MetroGrid)c);
                    i++;
                }
            }

            if (i == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btn_Next2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            tcPegawai.SelectedIndex += 1;
        }

        private async void cekdata(string nip)
        {
            var response = await Credentials.Client.GetAsync("api/employees/show/" + nip);
            var content = response.Content;
            var result = await content.ReadAsStringAsync();
            var data = JsonConvert.DeserializeObject<EmployeesMain>(result);
        }

        private void CreateColumn(MetroGrid grid,dynamic dta,string sub)
        {
            dt = new DataTable();
            foreach(var a in dta)
            {
                foreach (var b in a.GetType().GetProperties())
                {
                    if (b.Name == "id" || b.Name == "main_id")
                    {

                    }
                    else
                    {
                        try
                        {
                            dt.Columns.Add(sub + b.Name);
                        }
                        catch
                        {
                            
                        }
                    }
                }
            }
        }

        private void Make_TB(MetroGrid grid, dynamic dta,string sub)
        {
            foreach(var a in dta)
            {
                dr = dt.NewRow();
                foreach (var b in a.GetType().GetProperties())
                {
                    if (b.Name == "id" || b.Name == "main_id")
                    {

                    } else
                    {
                        if(b.GetValue(a) != null)
                        {
                            dr[sub + b.Name] = b.GetValue(a);
                        }
                        
                    }
                }
                dt.Rows.Add(dr);
            }
            grid.AutoGenerateColumns = false;
            foreach (DataGridViewColumn col in grid.Columns)
            {
                col.DataPropertyName = col.Name;
            }
            int i = 1;
            grid.DataSource = dt;
            foreach (DataGridViewRow rw in grid.Rows)
            {
                rw.Cells[0].Value = i;
                i++;
            }
            grid.Refresh();
        }

        private void Texter(dynamic data)
        {
            try
            {
                foreach (var item in data.GetType().GetProperties())
                {
                    foreach (TabPage p in tcPegawai.TabPages)
                    {
                        foreach (Control c in p.Controls)
                        {
                            if (c.GetType().Equals(typeof(MetroTextBox)) || c.GetType().Equals(typeof(MetroComboBox)))
                            {
                                if (c.Name.Substring(c.Name.IndexOf("_") + 1) == item.Name)
                                {
                                    if (item.GetValue(data).Equals(null)) { }
                                    else
                                    {
                                        Console.WriteLine(c.Name);
                                        c.Text = item.GetValue(data).ToString();
                                    }
                                }
                            }
                            else if (c.GetType().Equals(typeof(MetroDateTime)))
                            {
                                if (c.Name.Substring(c.Name.IndexOf("_") + 1) == item.Name)
                                {
                                    if (item.GetValue(data).Equals(null)) { }
                                    else
                                    {
                                        ((MetroDateTime)c).Value = Convert.ToDateTime(item.GetValue(data).ToString());
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch
            {

            }
        }

        private async void LoadData(string nip)
        {
            var response = await Credentials.Client.GetAsync("api/employees/show/" + nip);
            var content = response.Content;
            var result = await content.ReadAsStringAsync();

            if (result != "Tidak Ada Hasil")
            {
                var data = JsonConvert.DeserializeObject<EmployeesMain>(result);
                var hh = data.employees_homehealth;
                var mr = data.employees_marriage;
                var inf = data.employees_information;
                Texter(data);
                Texter(hh);
                Texter(mr);
                Texter(inf);
                CreateColumn(dgFE, data.employees_formal_education, "fe_");
                Make_TB(dgFE, data.employees_formal_education, "fe_");
                CreateColumn(dgIFE, data.employees_informal_education, "ife_");
                Make_TB(dgIFE, data.employees_informal_education, "ife_");
                CreateColumn(dgChild, data.employees_childs, "anak_");
                Make_TB(dgChild, data.employees_childs, "anak_");
                CreateColumn(dgDetail, data.employees_detail, "detail_");
                Make_TB(dgDetail, data.employees_detail, "detail_");
                CreateColumn(dgHobby, data.employees_hobby, "hobby_");
                Make_TB(dgHobby, data.employees_hobby, "hobby_");
                CreateColumn(dgAct, data.employees_activity, "act_");
                Make_TB(dgAct, data.employees_activity, "act_");

                foreach (TabPage p in tcPegawai.TabPages)
                {
                    foreach (Control c in p.Controls)
                    {
                        if (c.GetType().Equals(typeof(MetroTextBox)) || c.GetType().Equals(typeof(MetroComboBox)) || c.GetType().Equals(typeof(MetroDateTime)))
                        {
                            c.Enabled = false;
                        }
                    }
                }
            }
        }
                
    }
}