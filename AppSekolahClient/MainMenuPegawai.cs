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
using FontAwesome.Sharp;

namespace AppSekolahClient
{
    public partial class MainMenuPegawai : MetroForm
    {
        public MainMenuPegawai()
        {
            InitializeComponent();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            ListMurid murid = new ListMurid();
            murid.Show();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            ListPegawai pegawai = new ListPegawai();
            pegawai.Show();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            Settings setting = new Settings();
            setting.Show();
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            DataKelas kelas = new DataKelas();
            kelas.Show();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            DataMapel mapel = new DataMapel();
            mapel.Show();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            ListKeuangan keuangan = new ListKeuangan();
            keuangan.Show();
        }
    }
}
