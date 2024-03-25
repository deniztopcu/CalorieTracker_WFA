namespace UI_Forms
{
    partial class LoginScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
            panel1 = new Panel();
            label2 = new Label();
            btnKapat = new Button();
            pictureBox3 = new PictureBox();
            pnlGiris = new Panel();
            lblIpucu = new Label();
            lklbl_HesapOlustur = new LinkLabel();
            label1 = new Label();
            label3 = new Label();
            btn_GirisYap = new Button();
            txt_Mail = new TextBox();
            lnkIpucuGoster = new LinkLabel();
            pictureBox5 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            chkSifreGoster = new CheckBox();
            label4 = new Label();
            txt_Password = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            pnlGiris.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnKapat);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";

            panel1.Size = new Size(617, 48);

            panel1.TabIndex = 9;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(14, 12);
            label2.Name = "label2";
            label2.Size = new Size(212, 23);
            label2.TabIndex = 1;
            label2.Text = "Kalori Takip Programı";
            // 
            // btnKapat
            // 
            btnKapat.BackColor = Color.Navy;
            btnKapat.BackgroundImage = (Image)resources.GetObject("btnKapat.BackgroundImage");
            btnKapat.BackgroundImageLayout = ImageLayout.Zoom;
            btnKapat.Dock = DockStyle.Right;
            btnKapat.FlatStyle = FlatStyle.Flat;
            btnKapat.ForeColor = Color.Navy;

            btnKapat.Location = new Point(564, 0);

            btnKapat.Margin = new Padding(3, 4, 3, 4);
            btnKapat.Name = "btnKapat";
            btnKapat.Size = new Size(53, 48);
            btnKapat.TabIndex = 7;
            btnKapat.UseVisualStyleBackColor = false;
            btnKapat.MouseClick += btnKapat_MouseClick;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 55);
            pictureBox3.Name = "pictureBox3";

            pictureBox3.Size = new Size(612, 398);

            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // pnlGiris
            // 
            pnlGiris.Controls.Add(lblIpucu);
            pnlGiris.Controls.Add(lklbl_HesapOlustur);
            pnlGiris.Controls.Add(label1);
            pnlGiris.Controls.Add(label3);
            pnlGiris.Controls.Add(btn_GirisYap);
            pnlGiris.Controls.Add(txt_Mail);
            pnlGiris.Controls.Add(lnkIpucuGoster);
            pnlGiris.Controls.Add(pictureBox5);
            pnlGiris.Controls.Add(pictureBox1);
            pnlGiris.Controls.Add(pictureBox2);
            pnlGiris.Controls.Add(chkSifreGoster);
            pnlGiris.Controls.Add(label4);
            pnlGiris.Controls.Add(txt_Password);

            pnlGiris.Location = new Point(94, 66);
            pnlGiris.Name = "pnlGiris";
            pnlGiris.Size = new Size(424, 378);

            pnlGiris.TabIndex = 12;
            // 
            // lblIpucu
            // 
            lblIpucu.AutoSize = true;
            lblIpucu.Location = new Point(222, 267);
            lblIpucu.Name = "lblIpucu";
            lblIpucu.Size = new Size(0, 20);
            lblIpucu.TabIndex = 43;
            // 
            // lklbl_HesapOlustur
            // 
            lklbl_HesapOlustur.AutoSize = true;
            lklbl_HesapOlustur.Location = new Point(155, 342);
            lklbl_HesapOlustur.Name = "lklbl_HesapOlustur";
            lklbl_HesapOlustur.Size = new Size(133, 20);
            lklbl_HesapOlustur.TabIndex = 42;
            lklbl_HesapOlustur.TabStop = true;
            lklbl_HesapOlustur.Text = "Yeni Hesap Oluştur";
            lklbl_HesapOlustur.LinkClicked += lklbl_HesapOlustur_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(51, 10);
            label1.Name = "label1";
            label1.Size = new Size(284, 46);
            label1.TabIndex = 25;
            label1.Text = "Hesaba Giriş Yap";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(166, 56);
            label3.Name = "label3";
            label3.Size = new Size(69, 23);
            label3.TabIndex = 26;
            label3.Text = "E-Mail";
            // 
            // btn_GirisYap
            // 
            btn_GirisYap.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_GirisYap.Location = new Point(89, 290);
            btn_GirisYap.Name = "btn_GirisYap";
            btn_GirisYap.Size = new Size(264, 49);
            btn_GirisYap.TabIndex = 41;
            btn_GirisYap.Text = "Giriş Yap";
            btn_GirisYap.UseVisualStyleBackColor = true;
            btn_GirisYap.Click += btn_GirisYap_Click;
            // 
            // txt_Mail
            // 
            txt_Mail.Location = new Point(76, 82);
            txt_Mail.Multiline = true;
            txt_Mail.Name = "txt_Mail";
            txt_Mail.PlaceholderText = "E-Mailinizi Giriniz";
            txt_Mail.Size = new Size(301, 36);
            txt_Mail.TabIndex = 27;
            // 
            // lnkIpucuGoster
            // 
            lnkIpucuGoster.AutoSize = true;
            lnkIpucuGoster.Location = new Point(76, 267);
            lnkIpucuGoster.Name = "lnkIpucuGoster";
            lnkIpucuGoster.Size = new Size(113, 20);
            lnkIpucuGoster.TabIndex = 33;
            lnkIpucuGoster.TabStop = true;
            lnkIpucuGoster.Text = "İpucumu Göster";
            lnkIpucuGoster.LinkClicked += lnkIpucuGoster_LinkClicked;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(112, 204);
            pictureBox5.Margin = new Padding(3, 4, 3, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(37, 47);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 34;
            pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(13, 82);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(13, 161);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 47);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 22;
            pictureBox2.TabStop = false;
            // 
            // chkSifreGoster
            // 
            chkSifreGoster.AutoSize = true;
            chkSifreGoster.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            chkSifreGoster.Location = new Point(166, 221);
            chkSifreGoster.Name = "chkSifreGoster";
            chkSifreGoster.Size = new Size(126, 24);
            chkSifreGoster.TabIndex = 30;
            chkSifreGoster.Text = "Şifreyi Göster";
            chkSifreGoster.UseVisualStyleBackColor = true;
            chkSifreGoster.CheckedChanged += chkSifreGoster_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(175, 135);
            label4.Name = "label4";
            label4.Size = new Size(50, 23);
            label4.TabIndex = 28;
            label4.Text = "Şifre";
            // 
            // txt_Password
            // 
            txt_Password.Location = new Point(76, 161);
            txt_Password.Multiline = true;
            txt_Password.Name = "txt_Password";
            txt_Password.PasswordChar = '*';
            txt_Password.PlaceholderText = "Şifrenizi Giriniz";
            txt_Password.Size = new Size(301, 36);
            txt_Password.TabIndex = 29;
            // 
            // LoginScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;

            ClientSize = new Size(617, 465);

            ControlBox = false;
            Controls.Add(pnlGiris);
            Controls.Add(pictureBox3);
            Controls.Add(panel1);
            Name = "LoginScreen";
            Load += UserEntranceScreen_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            pnlGiris.ResumeLayout(false);
            pnlGiris.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label2;
        private Button btnKapat;
        private PictureBox pictureBox3;
        private Panel pnlGiris;
        private LinkLabel lklbl_HesapOlustur;
        private Label label1;
        private Label label3;
        private Button btn_GirisYap;
        private TextBox txt_Mail;
        private LinkLabel lnkIpucuGoster;
        private PictureBox pictureBox5;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private CheckBox chkSifreGoster;
        private Label label4;
        private TextBox txt_Password;
        private Label lblIpucu;
    }
}
