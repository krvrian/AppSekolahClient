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
using System.Net.Http.Headers;

namespace AppSekolahClient
{
    public partial class DataKelas : MetroForm
    {
        DataTable dt;
        DataRow dr;
        string tname;
        public DataKelas()
        {
            InitializeComponent();
            Credentials.Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Credentials.OAuth);
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            //tambah btton
        }

        private void DataKelas_Load(object sender, EventArgs e)
        {
            MuatData();
            LoadData();
        }
        private async void LoadData()
        {
            var response = await Credentials.Client.GetAsync("api/school/class/index");
            var content = response.Content;
            var result = await content.ReadAsStringAsync();

            if (result != "Tidak Ada Hasil")
            {
                var data = JsonConvert.DeserializeObject<List<Kelas>>(result);
                CreateColumn(metroGrid1, data, "class_");
                Make_TB(metroGrid1, data, "class_");
            }
        }

        private void CreateColumn(MetroGrid grid, dynamic dta, string sub)
        {
            dt = new DataTable();
            foreach (var a in dta)
            {
                foreach (var b in a.GetType().GetProperties())
                {
                    if(b.Name == "teacher_id")
                    {
                        dt.Columns.Add(sub + "teacher_name");
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

        private void Make_TB(MetroGrid grid, dynamic dta, string sub)
        {
            foreach (var a in dta)
            {
                dr = dt.NewRow();
                foreach (var b in a.GetType().GetProperties())
                {
                    if (b.Name == "teacher_id")
                    {
                        getteacher(b.GetValue(a));
                        dr[sub + b.Name] = tname;
                    }
                    else
                    {
                        if (b.GetValue(a) != null)
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

        private async void getteacher(string nourut)
        {
            var response = await Credentials.Client.GetAsync("api/employees/show/" + nourut);
            var content = response.Content;
            var result = await content.ReadAsStringAsync();
            var data = JsonConvert.DeserializeObject<EmployeesMain>(result);
            tname = data.full_name;
        }

        private async void MuatData()
        {
            try
            {
                var response = await Credentials.Client.GetAsync("api/employees/index");
                var content = response.Content;
                var result = await content.ReadAsStringAsync();

                if (result != "Tidak Ada Hasil")
                {
                    var data = JsonConvert.DeserializeObject<DataTable>(result);
                    cbb_teacher.DataSource = data;
                    cbb_teacher.DisplayMember = "full_name";
                    cbb_teacher.ValueMember = "noUrut";
                }
            }
            catch
            {
                DialogResult result = MetroMessageBox.Show(this, "Tidak Dapat Menyambung ke Server!", "Koneksi Gagal", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Retry)
                {
                    MuatData();
                }
                else
                {

                }
            }
        }
        private async void SendData(string url)
        {
            var values = new List<KeyValuePair<string, string>>();
            values.Add(new KeyValuePair<string, string>("class_name", txt_class_name.Text));
            values.Add(new KeyValuePair<string, string>("teacher_id", cbb_teacher.SelectedValue.ToString()));
            values.Add(new KeyValuePair<string, string>("school_level", cbb_level.SelectedText));

            var content = new FormUrlEncodedContent(values);
            var result = await Credentials.Client.PostAsync(url, content);
            string resultContent = await result.Content.ReadAsStringAsync();
        }
    }
}
