namespace MarvelHotel
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxKullanici = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxSifre = new Guna.UI2.WinForms.Guna2TextBox();
            this.ButtonGirisYap = new Guna.UI2.WinForms.Guna2Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.guna2HtmlLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 0;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(316, 25);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(172, 34);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Marvel HOTEL";
            this.guna2HtmlLabel1.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 350);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 100);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(128, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanici Adi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(161, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sifre";
            // 
            // TextBoxKullanici
            // 
            this.TextBoxKullanici.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TextBoxKullanici.BorderRadius = 5;
            this.TextBoxKullanici.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxKullanici.DefaultText = "";
            this.TextBoxKullanici.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxKullanici.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxKullanici.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxKullanici.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxKullanici.FillColor = System.Drawing.Color.OldLace;
            this.TextBoxKullanici.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxKullanici.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxKullanici.ForeColor = System.Drawing.Color.Black;
            this.TextBoxKullanici.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxKullanici.Location = new System.Drawing.Point(364, 154);
            this.TextBoxKullanici.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxKullanici.Name = "TextBoxKullanici";
            this.TextBoxKullanici.PasswordChar = '\0';
            this.TextBoxKullanici.PlaceholderForeColor = System.Drawing.Color.Transparent;
            this.TextBoxKullanici.PlaceholderText = "";
            this.TextBoxKullanici.SelectedText = "";
            this.TextBoxKullanici.Size = new System.Drawing.Size(217, 34);
            this.TextBoxKullanici.TabIndex = 4;
            // 
            // TextBoxSifre
            // 
            this.TextBoxSifre.BorderRadius = 5;
            this.TextBoxSifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxSifre.DefaultText = "";
            this.TextBoxSifre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxSifre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxSifre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxSifre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxSifre.FillColor = System.Drawing.Color.OldLace;
            this.TextBoxSifre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxSifre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxSifre.ForeColor = System.Drawing.Color.Black;
            this.TextBoxSifre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxSifre.Location = new System.Drawing.Point(364, 212);
            this.TextBoxSifre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxSifre.Name = "TextBoxSifre";
            this.TextBoxSifre.PasswordChar = '*';
            this.TextBoxSifre.PlaceholderForeColor = System.Drawing.Color.Transparent;
            this.TextBoxSifre.PlaceholderText = "";
            this.TextBoxSifre.SelectedText = "";
            this.TextBoxSifre.Size = new System.Drawing.Size(217, 34);
            this.TextBoxSifre.TabIndex = 5;
            this.TextBoxSifre.TextChanged += new System.EventHandler(this.TextBoxSifre_TextChanged);
            // 
            // ButtonGirisYap
            // 
            this.ButtonGirisYap.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonGirisYap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonGirisYap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonGirisYap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonGirisYap.FillColor = System.Drawing.Color.OldLace;
            this.ButtonGirisYap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonGirisYap.ForeColor = System.Drawing.Color.Black;
            this.ButtonGirisYap.Location = new System.Drawing.Point(647, 106);
            this.ButtonGirisYap.Name = "ButtonGirisYap";
            this.ButtonGirisYap.Size = new System.Drawing.Size(153, 238);
            this.ButtonGirisYap.TabIndex = 6;
            this.ButtonGirisYap.Text = "Giriş Yap";
            this.ButtonGirisYap.Click += new System.EventHandler(this.ButtonGirisYap_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(402, 253);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(143, 20);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Şifreyi Göster-Gizle";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.ButtonGirisYap);
            this.Controls.Add(this.TextBoxSifre);
            this.Controls.Add(this.TextBoxKullanici);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxSifre;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxKullanici;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button ButtonGirisYap;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

