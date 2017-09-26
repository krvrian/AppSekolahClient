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
    public partial class ListKeuangan : MetroForm
    {
        DataTable dt;
        DataRow dr;

        public ListKeuangan()
        {
            InitializeComponent();
            Credentials.Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Credentials.OAuth);
        }

        private void metroTabPage3_Click(object sender, EventArgs e)
        {

        }

        private void ListKeuangan_Load(object sender, EventArgs e)
        {
            metroTabControl1.SelectedIndex = 0;
            sum();   
        }
        private void sum()
        {
            int sumdeb = 0;
            int sumkre = 0;
            for (int i = 0; i < dgKeuangan.Rows.Count; ++i)
            {
                sumdeb += Convert.ToInt32(dgKeuangan.Rows[i].Cells[2].Value);
                sumkre += Convert.ToInt32(dgKeuangan.Rows[i].Cells[3].Value);
            }
            dgKeuangan.Rows.Add();
            dgKeuangan.Rows[dgKeuangan.Rows.Count - 1].Cells[1].Value = "Total";
            dgKeuangan.Rows[dgKeuangan.Rows.Count-1].Cells[2].Value = sumdeb.ToString();
            dgKeuangan.Rows[dgKeuangan.Rows.Count - 1].Cells[3].Value = sumkre.ToString();
            dgKeuangan.Rows[dgKeuangan.Rows.Count - 1].Cells[4].Value = sumdeb - sumkre;
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

        private async void LoadData()
        {
            var response = await Credentials.Client.GetAsync("api/school/keuangan/index");
            var content = response.Content;
            var result = await content.ReadAsStringAsync();

            if (result != "Tidak Ada Hasil")
            {
                var data = JsonConvert.DeserializeObject<List<Subjects>>(result);
                CreateColumn(dgKeuangan, data, "keuangan_");
                Make_TB(dgKeuangan, data, "keuangan_");
            }
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            var values = new List<KeyValuePair<string, string>>();
            values.Add(new KeyValuePair<string, string>("tanggal",tanggal.Text));
            if (tipe.Text == "Pemasukan Dana")
            {
                values.Add(new KeyValuePair<string, string>("debit", jumlah.Text));
            }
            else if(tipe.Text == "Pengeluaran Dana")
            {
                values.Add(new KeyValuePair<string, string>("kredit", jumlah.Text));
            }
            string ket = tipe.Text + " Untuk " + untuk.Text + " " + keterangan.Text;
            values.Add(new KeyValuePair<string, string>("keterangan",ket));
            SendData(values, "api/school/keuangan/store");
        }
        private async void SendData(dynamic dta,string url)
        {
            var content = new FormUrlEncodedContent(dta);
            var result = await Credentials.Client.PostAsync(url, content);
            string resultContent = await result.Content.ReadAsStringAsync();
            Console.WriteLine(resultContent);
        }
    }
}
