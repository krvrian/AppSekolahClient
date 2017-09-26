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
    public partial class LoginForm : MetroForm
    {
        bool logged;
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
                Credentials.setting.Write("server", "http://localhost/appsekolah-api/", "ServerSettings");
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

        private async void LogMeIn(string uname, string pass)
        {
            var values = new List<KeyValuePair<string, string>>();
            values.Add(new KeyValuePair<string, string>("username", uname));
            values.Add(new KeyValuePair<string, string>("password", pass));
            var content = new FormUrlEncodedContent(values);
            var result = await Credentials.Client.PostAsync("api/auth/login", content);
            string resultContent = await result.Content.ReadAsStringAsync();
            if(resultContent =="[\"invalid_email_or_password\"]")
            {
                logged = false; //Setting logged, will be replaced by API Result later
            }
            else
            {
                logged = true;
            }

            //Check Username And Password Here

            if (logged) //Check if username and password right
            {
                var data = JsonConvert.DeserializeObject<login>(resultContent);
                var tipe = data.dataUser[0].role;
                Credentials.OAuth = data.token;
                //Close Login Form, Move to other Form
                if (tipe == 1)
                {
                    this.Hide();
                    var form2 = new MainMenuPegawai();
                    form2.Closed += (s, args) => this.Close();
                    form2.Show();
                }
            }
            else
            {
                //Set Error
            }
        }
    }
}