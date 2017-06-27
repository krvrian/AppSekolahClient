namespace AppSekolahClient
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tcSettings = new MetroFramework.Controls.MetroTabControl();
            this.tpServer = new System.Windows.Forms.TabPage();
            this.tpUser = new System.Windows.Forms.TabPage();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tbServerAddress = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnSaveSet = new MetroFramework.Controls.MetroButton();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.tbCPass1 = new MetroFramework.Controls.MetroTextBox();
            this.tbCPass2 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.btnSavePass = new MetroFramework.Controls.MetroButton();
            this.tcSettings.SuspendLayout();
            this.tpServer.SuspendLayout();
            this.tpUser.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcSettings
            // 
            this.tcSettings.Controls.Add(this.tpUser);
            this.tcSettings.Controls.Add(this.tpServer);
            this.tcSettings.Location = new System.Drawing.Point(23, 72);
            this.tcSettings.Name = "tcSettings";
            this.tcSettings.SelectedIndex = 1;
            this.tcSettings.Size = new System.Drawing.Size(417, 233);
            this.tcSettings.TabIndex = 0;
            this.tcSettings.UseSelectable = true;
            this.tcSettings.SelectedIndexChanged += new System.EventHandler(this.tcSettings_SelectedIndexChanged);
            // 
            // tpServer
            // 
            this.tpServer.Controls.Add(this.metroPanel1);
            this.tpServer.Location = new System.Drawing.Point(4, 38);
            this.tpServer.Name = "tpServer";
            this.tpServer.Size = new System.Drawing.Size(409, 191);
            this.tpServer.TabIndex = 0;
            this.tpServer.Text = "Server";
            // 
            // tpUser
            // 
            this.tpUser.Controls.Add(this.metroPanel2);
            this.tpUser.Location = new System.Drawing.Point(4, 38);
            this.tpUser.Name = "tpUser";
            this.tpUser.Size = new System.Drawing.Size(409, 191);
            this.tpUser.TabIndex = 1;
            this.tpUser.Text = "User Related";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.btnSaveSet);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.tbServerAddress);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(409, 191);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(26, 54);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(97, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Server Address";
            // 
            // tbServerAddress
            // 
            // 
            // 
            // 
            this.tbServerAddress.CustomButton.Image = null;
            this.tbServerAddress.CustomButton.Location = new System.Drawing.Point(210, 1);
            this.tbServerAddress.CustomButton.Name = "";
            this.tbServerAddress.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbServerAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbServerAddress.CustomButton.TabIndex = 1;
            this.tbServerAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbServerAddress.CustomButton.UseSelectable = true;
            this.tbServerAddress.CustomButton.Visible = false;
            this.tbServerAddress.Lines = new string[0];
            this.tbServerAddress.Location = new System.Drawing.Point(30, 78);
            this.tbServerAddress.MaxLength = 32767;
            this.tbServerAddress.Name = "tbServerAddress";
            this.tbServerAddress.PasswordChar = '\0';
            this.tbServerAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbServerAddress.SelectedText = "";
            this.tbServerAddress.SelectionLength = 0;
            this.tbServerAddress.SelectionStart = 0;
            this.tbServerAddress.ShortcutsEnabled = true;
            this.tbServerAddress.Size = new System.Drawing.Size(232, 23);
            this.tbServerAddress.TabIndex = 3;
            this.tbServerAddress.UseSelectable = true;
            this.tbServerAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbServerAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel2.Location = new System.Drawing.Point(26, 104);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(236, 15);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "*) DO NOT Change without Admin Permission";
            // 
            // btnSaveSet
            // 
            this.btnSaveSet.Location = new System.Drawing.Point(307, 78);
            this.btnSaveSet.Name = "btnSaveSet";
            this.btnSaveSet.Size = new System.Drawing.Size(71, 23);
            this.btnSaveSet.TabIndex = 5;
            this.btnSaveSet.Text = "Save";
            this.btnSaveSet.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnSaveSet.UseSelectable = true;
            this.btnSaveSet.Click += new System.EventHandler(this.btnSaveSet_Click);
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.btnSavePass);
            this.metroPanel2.Controls.Add(this.tbCPass2);
            this.metroPanel2.Controls.Add(this.metroLabel4);
            this.metroPanel2.Controls.Add(this.tbCPass1);
            this.metroPanel2.Controls.Add(this.metroLabel3);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(0, 0);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(409, 191);
            this.metroPanel2.TabIndex = 0;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(22, 24);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(113, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Change Password";
            // 
            // tbCPass1
            // 
            // 
            // 
            // 
            this.tbCPass1.CustomButton.Image = null;
            this.tbCPass1.CustomButton.Location = new System.Drawing.Point(202, 1);
            this.tbCPass1.CustomButton.Name = "";
            this.tbCPass1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbCPass1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbCPass1.CustomButton.TabIndex = 1;
            this.tbCPass1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbCPass1.CustomButton.UseSelectable = true;
            this.tbCPass1.CustomButton.Visible = false;
            this.tbCPass1.Lines = new string[0];
            this.tbCPass1.Location = new System.Drawing.Point(26, 49);
            this.tbCPass1.MaxLength = 32767;
            this.tbCPass1.Name = "tbCPass1";
            this.tbCPass1.PasswordChar = '\0';
            this.tbCPass1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbCPass1.SelectedText = "";
            this.tbCPass1.SelectionLength = 0;
            this.tbCPass1.SelectionStart = 0;
            this.tbCPass1.ShortcutsEnabled = true;
            this.tbCPass1.Size = new System.Drawing.Size(224, 23);
            this.tbCPass1.TabIndex = 3;
            this.tbCPass1.UseSelectable = true;
            this.tbCPass1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbCPass1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbCPass2
            // 
            // 
            // 
            // 
            this.tbCPass2.CustomButton.Image = null;
            this.tbCPass2.CustomButton.Location = new System.Drawing.Point(202, 1);
            this.tbCPass2.CustomButton.Name = "";
            this.tbCPass2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbCPass2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbCPass2.CustomButton.TabIndex = 1;
            this.tbCPass2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbCPass2.CustomButton.UseSelectable = true;
            this.tbCPass2.CustomButton.Visible = false;
            this.tbCPass2.Lines = new string[0];
            this.tbCPass2.Location = new System.Drawing.Point(26, 105);
            this.tbCPass2.MaxLength = 32767;
            this.tbCPass2.Name = "tbCPass2";
            this.tbCPass2.PasswordChar = '\0';
            this.tbCPass2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbCPass2.SelectedText = "";
            this.tbCPass2.SelectionLength = 0;
            this.tbCPass2.SelectionStart = 0;
            this.tbCPass2.ShortcutsEnabled = true;
            this.tbCPass2.Size = new System.Drawing.Size(224, 23);
            this.tbCPass2.TabIndex = 5;
            this.tbCPass2.UseSelectable = true;
            this.tbCPass2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbCPass2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(22, 80);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(117, 19);
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "Re-Type Password";
            // 
            // btnSavePass
            // 
            this.btnSavePass.Location = new System.Drawing.Point(289, 142);
            this.btnSavePass.Name = "btnSavePass";
            this.btnSavePass.Size = new System.Drawing.Size(85, 36);
            this.btnSavePass.TabIndex = 6;
            this.btnSavePass.Text = "Save Change";
            this.btnSavePass.UseSelectable = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 328);
            this.Controls.Add(this.tcSettings);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.tcSettings.ResumeLayout(false);
            this.tpServer.ResumeLayout(false);
            this.tpUser.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tcSettings;
        private System.Windows.Forms.TabPage tpServer;
        private System.Windows.Forms.TabPage tpUser;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox tbServerAddress;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnSaveSet;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton btnSavePass;
        private MetroFramework.Controls.MetroTextBox tbCPass2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox tbCPass1;
    }
}