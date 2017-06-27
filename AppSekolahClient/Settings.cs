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

namespace AppSekolahClient
{
    public partial class Settings : MetroForm
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            tbServerAddress.Text = Credentials.setting.Read("server", "ServerSettings");
        }

        private void tcSettings_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveSet_Click(object sender, EventArgs e)
        {
            Credentials.setting.Write("server",tbServerAddress.Text, "ServerSettings");
        }
    }
}
