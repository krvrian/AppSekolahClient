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
    public partial class DataMapel : MetroForm
    {
        DataTable dt;
        DataRow dr;

        public DataMapel()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void LoadData()
        {
            var response = await Credentials.Client.GetAsync("api/school/subjects/index");
            var content = response.Content;
            var result = await content.ReadAsStringAsync();

            if (result != "Tidak Ada Hasil")
            {
                var data = JsonConvert.DeserializeObject<List<Subjects>>(result);
                CreateColumn(dgSub,data,"subjects_");
                Make_TB(dgSub, data, "subjects_");
            }
        }

        private void CreateColumn(MetroGrid grid, dynamic dta, string sub)
        {
            dt = new DataTable();
            foreach (var a in dta)
            {
                foreach (var b in a.GetType().GetProperties())
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

        private void Make_TB(MetroGrid grid, dynamic dta, string sub)
        {
            foreach (var a in dta)
            {
                dr = dt.NewRow();
                foreach (var b in a.GetType().GetProperties())
                {
                    if (b.GetValue(a) != null)
                    {
                        dr[sub + b.Name] = b.GetValue(a);
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

        private void DataMapel_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData();
            }
            catch
            {

            }
        }

        private void dgSub_SelectionChanged(object sender, EventArgs e)
        {
            if (dgSub.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgSub.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgSub.Rows[selectedrowindex];

                Credentials.delmapel = Convert.ToString(selectedRow.Cells["subjects_id"].Value);
                Console.WriteLine(Credentials.delmapel);
            }
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            DialogResult result = MetroMessageBox.Show(this, "Hapus Data?", "Konfirmasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (result == DialogResult.OK)
            {
                Credentials.Client.DeleteAsync("api/school/subjects/delete/" + Credentials.delmapel);
                LoadData();
            }
            else if (result == DialogResult.Cancel)
            {

            }
        }

        private void dgSub_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgSub.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgSub.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgSub.Rows[selectedrowindex];

                Credentials.delmapel = Convert.ToString(selectedRow.Cells["subjects_id"].Value);
                Console.WriteLine(Credentials.delmapel);
            }
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            var values = new List<KeyValuePair<string, string>>();
            values.Add(new KeyValuePair<string, string>("name", mapel_nama.Text));
            SendData(values, "api/school/subjects/store");
        }
        private async void SendData(dynamic dta, string url)
        {
            var content = new FormUrlEncodedContent(dta);
            var result = await Credentials.Client.PostAsync(url, content);
            string resultContent = await result.Content.ReadAsStringAsync();
            Console.WriteLine(resultContent);
            LoadData();
        }
    }
}
