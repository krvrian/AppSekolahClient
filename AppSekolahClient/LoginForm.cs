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

namespace AppSekolahClient
{
    public partial class LoginForm : MetroForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Memasang File Settings.ini
            Credentials.setting = new IniFiles("Settings.ini");
            // Cek apakah Key sudah ada pada Settings.ini
            if (!Credentials.setting.KeyExists("server", "ServerSettings"))
            {
                // Jika belum, akan dibuat settingan Default
                Credentials.setting.Write("server", "http://192.168.43.203/appsekolah-api/", "ServerSettings");
            }
            else
            {
                Credentials.serveradd = Credentials.setting.Read("server", "ServerSettings");
                Credentials.Client = new HttpClient { BaseAddress = new Uri(Credentials.serveradd) };
                Console.WriteLine(Credentials.Client.BaseAddress);
            }
        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LogMeIn(user.Text, pass.Text); //Log In Function
        }

        private void LogMeIn(string uname, string pass)
        {
            bool logged = true; //Setting logged, will be replaced by API Result later

            //Check Username And Password Here

            if (logged) //Check if username and password right
            {
                int tipe = 1;
                //Close Login Form, Move to other Form
                if (tipe == 1)
                {
                    this.Hide();
                    var form2 = new ListMurid();
                    form2.Closed += (s, args) => this.Close();
                    form2.Show();
                }
                else if (tipe == 2)
                {
                    this.Hide();
                    var form2 = new ListPegawai();
                    form2.Closed += (s, args) => this.Close();
                    form2.Show();
                }
                else
                {
                    MetroMessageBox.Show(this, "Disini Harusnya Admin", "ADMIN WEI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                //Set Error
            }
        }
    }
}
