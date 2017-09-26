namespace AppSekolahClient
{
    partial class ListKeuangan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.dgKeuangan = new MetroFramework.Controls.MetroGrid();
            this.keuangan_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keuangan_tanggal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keuangan_debit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keuangan_kredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keuangan_keterangan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.tanggal = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tipe = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.untuk = new MetroFramework.Controls.MetroTextBox();
            this.keterangan = new MetroFramework.Controls.MetroTextBox();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.jumlah = new MetroFramework.Controls.MetroTextBox();
            this.Senilai = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgKeuangan)).BeginInit();
            this.metroPanel2.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.dgKeuangan);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(38, 84);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(888, 254);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // dgKeuangan
            // 
            this.dgKeuangan.AllowUserToAddRows = false;
            this.dgKeuangan.AllowUserToDeleteRows = false;
            this.dgKeuangan.AllowUserToResizeRows = false;
            this.dgKeuangan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgKeuangan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgKeuangan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgKeuangan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgKeuangan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgKeuangan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKeuangan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.keuangan_no,
            this.keuangan_tanggal,
            this.keuangan_debit,
            this.keuangan_kredit,
            this.keuangan_keterangan});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgKeuangan.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgKeuangan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgKeuangan.EnableHeadersVisualStyles = false;
            this.dgKeuangan.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgKeuangan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgKeuangan.Location = new System.Drawing.Point(0, 0);
            this.dgKeuangan.Name = "dgKeuangan";
            this.dgKeuangan.ReadOnly = true;
            this.dgKeuangan.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgKeuangan.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgKeuangan.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgKeuangan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgKeuangan.Size = new System.Drawing.Size(888, 254);
            this.dgKeuangan.Style = MetroFramework.MetroColorStyle.Red;
            this.dgKeuangan.TabIndex = 2;
            // 
            // keuangan_no
            // 
            this.keuangan_no.HeaderText = "No";
            this.keuangan_no.Name = "keuangan_no";
            this.keuangan_no.ReadOnly = true;
            this.keuangan_no.Width = 40;
            // 
            // keuangan_tanggal
            // 
            this.keuangan_tanggal.HeaderText = "Tanggal";
            this.keuangan_tanggal.Name = "keuangan_tanggal";
            this.keuangan_tanggal.ReadOnly = true;
            this.keuangan_tanggal.Width = 120;
            // 
            // keuangan_debit
            // 
            this.keuangan_debit.HeaderText = "Debit";
            this.keuangan_debit.Name = "keuangan_debit";
            this.keuangan_debit.ReadOnly = true;
            this.keuangan_debit.Width = 120;
            // 
            // keuangan_kredit
            // 
            this.keuangan_kredit.HeaderText = "Kredit";
            this.keuangan_kredit.Name = "keuangan_kredit";
            this.keuangan_kredit.ReadOnly = true;
            this.keuangan_kredit.Width = 120;
            // 
            // keuangan_keterangan
            // 
            this.keuangan_keterangan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.keuangan_keterangan.HeaderText = "Keterangan";
            this.keuangan_keterangan.Name = "keuangan_keterangan";
            this.keuangan_keterangan.ReadOnly = true;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.metroTabControl1);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(38, 363);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(888, 181);
            this.metroPanel2.TabIndex = 1;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(888, 181);
            this.metroTabControl1.TabIndex = 2;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.jumlah);
            this.metroTabPage1.Controls.Add(this.Senilai);
            this.metroTabPage1.Controls.Add(this.metroTile1);
            this.metroTabPage1.Controls.Add(this.keterangan);
            this.metroTabPage1.Controls.Add(this.untuk);
            this.metroTabPage1.Controls.Add(this.metroLabel4);
            this.metroTabPage1.Controls.Add(this.metroLabel3);
            this.metroTabPage1.Controls.Add(this.tipe);
            this.metroTabPage1.Controls.Add(this.metroLabel2);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.Controls.Add(this.tanggal);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(880, 139);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Input";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroTile2);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(746, 139);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Print Laporan";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // tanggal
            // 
            this.tanggal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tanggal.Location = new System.Drawing.Point(32, 50);
            this.tanggal.MinimumSize = new System.Drawing.Size(0, 29);
            this.tanggal.Name = "tanggal";
            this.tanggal.Size = new System.Drawing.Size(106, 29);
            this.tanggal.TabIndex = 2;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(32, 25);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(56, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Tanggal";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(307, 25);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(34, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Tipe";
            // 
            // tipe
            // 
            this.tipe.FormattingEnabled = true;
            this.tipe.ItemHeight = 23;
            this.tipe.Items.AddRange(new object[] {
            "Pemasukan Dana",
            "Pengeluaran Dana"});
            this.tipe.Location = new System.Drawing.Point(309, 50);
            this.tipe.Name = "tipe";
            this.tipe.Size = new System.Drawing.Size(173, 29);
            this.tipe.TabIndex = 5;
            this.tipe.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(672, 25);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(75, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Keterangan";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(491, 28);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(42, 19);
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "Untuk";
            // 
            // untuk
            // 
            // 
            // 
            // 
            this.untuk.CustomButton.Image = null;
            this.untuk.CustomButton.Location = new System.Drawing.Point(151, 1);
            this.untuk.CustomButton.Name = "";
            this.untuk.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.untuk.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.untuk.CustomButton.TabIndex = 1;
            this.untuk.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.untuk.CustomButton.UseSelectable = true;
            this.untuk.CustomButton.Visible = false;
            this.untuk.Lines = new string[0];
            this.untuk.Location = new System.Drawing.Point(491, 54);
            this.untuk.MaxLength = 32767;
            this.untuk.Name = "untuk";
            this.untuk.PasswordChar = '\0';
            this.untuk.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.untuk.SelectedText = "";
            this.untuk.SelectionLength = 0;
            this.untuk.SelectionStart = 0;
            this.untuk.ShortcutsEnabled = true;
            this.untuk.Size = new System.Drawing.Size(173, 23);
            this.untuk.TabIndex = 9;
            this.untuk.UseSelectable = true;
            this.untuk.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.untuk.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // keterangan
            // 
            // 
            // 
            // 
            this.keterangan.CustomButton.Image = null;
            this.keterangan.CustomButton.Location = new System.Drawing.Point(151, 1);
            this.keterangan.CustomButton.Name = "";
            this.keterangan.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.keterangan.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.keterangan.CustomButton.TabIndex = 1;
            this.keterangan.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.keterangan.CustomButton.UseSelectable = true;
            this.keterangan.CustomButton.Visible = false;
            this.keterangan.Lines = new string[0];
            this.keterangan.Location = new System.Drawing.Point(672, 54);
            this.keterangan.MaxLength = 32767;
            this.keterangan.Name = "keterangan";
            this.keterangan.PasswordChar = '\0';
            this.keterangan.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.keterangan.SelectedText = "";
            this.keterangan.SelectionLength = 0;
            this.keterangan.SelectionStart = 0;
            this.keterangan.ShortcutsEnabled = true;
            this.keterangan.Size = new System.Drawing.Size(173, 23);
            this.keterangan.TabIndex = 10;
            this.keterangan.UseSelectable = true;
            this.keterangan.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.keterangan.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(775, 101);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(84, 35);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroTile1.TabIndex = 11;
            this.metroTile1.Text = "Kirim";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(181, 34);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(350, 91);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile2.TabIndex = 2;
            this.metroTile2.Text = "Print Laporan";
            this.metroTile2.UseSelectable = true;
            // 
            // jumlah
            // 
            // 
            // 
            // 
            this.jumlah.CustomButton.Image = null;
            this.jumlah.CustomButton.Location = new System.Drawing.Point(135, 1);
            this.jumlah.CustomButton.Name = "";
            this.jumlah.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.jumlah.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.jumlah.CustomButton.TabIndex = 1;
            this.jumlah.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.jumlah.CustomButton.UseSelectable = true;
            this.jumlah.CustomButton.Visible = false;
            this.jumlah.Lines = new string[0];
            this.jumlah.Location = new System.Drawing.Point(146, 51);
            this.jumlah.MaxLength = 32767;
            this.jumlah.Name = "jumlah";
            this.jumlah.PasswordChar = '\0';
            this.jumlah.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.jumlah.SelectedText = "";
            this.jumlah.SelectionLength = 0;
            this.jumlah.SelectionStart = 0;
            this.jumlah.ShortcutsEnabled = true;
            this.jumlah.Size = new System.Drawing.Size(157, 23);
            this.jumlah.TabIndex = 13;
            this.jumlah.UseSelectable = true;
            this.jumlah.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.jumlah.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Senilai
            // 
            this.Senilai.AutoSize = true;
            this.Senilai.Location = new System.Drawing.Point(146, 25);
            this.Senilai.Name = "Senilai";
            this.Senilai.Size = new System.Drawing.Size(46, 19);
            this.Senilai.TabIndex = 12;
            this.Senilai.Text = "Senilai";
            // 
            // ListKeuangan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 567);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Name = "ListKeuangan";
            this.Text = "Data Keuangan";
            this.Load += new System.EventHandler(this.ListKeuangan_Load);
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgKeuangan)).EndInit();
            this.metroPanel2.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroGrid dgKeuangan;
        private System.Windows.Forms.DataGridViewTextBoxColumn keuangan_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn keuangan_tanggal;
        private System.Windows.Forms.DataGridViewTextBoxColumn keuangan_debit;
        private System.Windows.Forms.DataGridViewTextBoxColumn keuangan_kredit;
        private System.Windows.Forms.DataGridViewTextBoxColumn keuangan_keterangan;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime tanggal;
        private MetroFramework.Controls.MetroTextBox keterangan;
        private MetroFramework.Controls.MetroTextBox untuk;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox tipe;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTextBox jumlah;
        private MetroFramework.Controls.MetroLabel Senilai;
    }
}