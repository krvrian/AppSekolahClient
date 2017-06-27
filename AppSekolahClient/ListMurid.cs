using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using System.Net.Http;
using Newtonsoft.Json;

namespace AppSekolahClient
{
    public partial class ListMurid : MetroForm
    {
        DataTable tab;
        string result;
        public ListMurid()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddMurid tbh = new AddMurid(this);
            tbh.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MetroMessageBox.Show(this, "Hapus Data?","Konfirmasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (result == DialogResult.OK)
            {
                Credentials.Client.DeleteAsync("api/student/book/delete/"+Credentials.editnis);
                MuatData();
            }
            else if (result == DialogResult.Cancel)
            {

            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Settings set = new Settings();

            set.Show();
        }

        public async void MuatData()
        {
            var response = await Credentials.Client.GetAsync("api/student/book/index");
            var content = response.Content;
            result = await content.ReadAsStringAsync();
            
            if (result != "Tidak Ada Hasil")
            {
                tab = JsonConvert.DeserializeObject<DataTable>(result);
                MuatUlang();
            }
        }

        public void MuatUlang()
        {
            if (tbSearch.Text != "")
            {
                tab.DefaultView.RowFilter = string.Format("nis LIKE '%{0}%' OR full_name LIKE '%{0}%'", tbSearch.Text);
            }
            else
            {
                tab.DefaultView.RowFilter = string.Empty;
            }
            dgSiswa.AutoGenerateColumns = false;
            dgSiswa.DataSource = tab;
            foreach (DataGridViewColumn col in dgSiswa.Columns)
            {
                col.DataPropertyName = col.Name;
            }
            int i = 1;
            foreach (DataGridViewRow rw in dgSiswa.Rows)
            {
                rw.Cells[0].Value = i;
                i++;
            }
            dgSiswa.Refresh();
        }

        private void ListMurid_Load(object sender, EventArgs e)
        {
            MuatData();
            dgSiswa.SelectionChanged += dgSiswa_SelectionChanged;
        }


        private void dgSiswa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgSiswa_SelectionChanged(object sender, EventArgs e)
        {
            if (dgSiswa.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgSiswa.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgSiswa.Rows[selectedrowindex];

                Credentials.editnis = Convert.ToString(selectedRow.Cells["nis"].Value);
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            MuatUlang();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(Credentials.editnis == null || Credentials.editnis == "" || Credentials.editnis == " ")
            {
                DialogResult result = MetroMessageBox.Show(this, "Silahkan Pilih Data", "Edit Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                EditMurid edit = new EditMurid(this);
                edit.Show();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            MuatData();
        }

        private void dgSiswa_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            LihatMurid lihat = new LihatMurid(this);
            lihat.Show();
        }
    }
}
