namespace UI_Forms
{
    partial class PasswordRenewScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordRenewScreen));
            panel1 = new Panel();
            btnClose = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtEmail = new TextBox();
            pictureBox1 = new PictureBox();
            btnCheckInfos = new Button();
            label5 = new Label();
            txtYeniSifre = new TextBox();
            ptbPasswordInfo = new PictureBox();
            pictureBox2 = new PictureBox();
            chbSifreyiGöster = new CheckBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox5 = new PictureBox();
            btnUpdatePassword = new Button();
            txtIpucu = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbPasswordInfo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-4, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1401, 57);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Navy;
            btnClose.BackgroundImage = (Image)resources.GetObject("btnClose.BackgroundImage");
            btnClose.BackgroundImageLayout = ImageLayout.Zoom;
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.Navy;
            btnClose.Location = new Point(1344, 0);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(57, 57);
            btnClose.TabIndex = 8;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(16, 14);
            label1.Name = "label1";
            label1.Size = new Size(215, 23);
            label1.TabIndex = 1;
            label1.Text = "Kalori Takiip Programı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(522, 74);
            label2.Name = "label2";
            label2.Size = new Size(225, 40);
            label2.TabIndex = 3;
            label2.Text = "Şifreyi Yenile";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(601, 145);
            label3.Name = "label3";
            label3.Size = new Size(69, 23);
            label3.TabIndex = 4;
            label3.Text = "E-Mail";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(498, 186);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(274, 45);
            txtEmail.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(439, 186);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // btnCheckInfos
            // 
            btnCheckInfos.BackColor = Color.Transparent;
            btnCheckInfos.FlatAppearance.BorderColor = Color.White;
            btnCheckInfos.FlatAppearance.MouseOverBackColor = Color.Red;
            btnCheckInfos.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnCheckInfos.ForeColor = Color.Black;
            btnCheckInfos.Location = new Point(533, 302);
            btnCheckInfos.Margin = new Padding(3, 4, 3, 4);
            btnCheckInfos.Name = "btnCheckInfos";
            btnCheckInfos.Size = new Size(214, 55);
            btnCheckInfos.TabIndex = 7;
            btnCheckInfos.Text = "Bilgileri Kontrol Et";
            btnCheckInfos.UseVisualStyleBackColor = false;
            btnCheckInfos.Click += btnCheckInfos_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(591, 361);
            label5.Name = "label5";
            label5.Size = new Size(98, 23);
            label5.TabIndex = 13;
            label5.Text = "Yeni Şifre";
            // 
            // txtYeniSifre
            // 
            txtYeniSifre.Location = new Point(511, 399);
            txtYeniSifre.Margin = new Padding(3, 4, 3, 4);
            txtYeniSifre.Multiline = true;
            txtYeniSifre.Name = "txtYeniSifre";
            txtYeniSifre.PlaceholderText = "Yeni Şifrenizi Giriniz";
            txtYeniSifre.Size = new Size(274, 45);
            txtYeniSifre.TabIndex = 14;
            // 
            // ptbPasswordInfo
            // 
            ptbPasswordInfo.Image = (Image)resources.GetObject("ptbPasswordInfo.Image");
            ptbPasswordInfo.Location = new Point(816, 388);
            ptbPasswordInfo.Margin = new Padding(3, 4, 3, 4);
            ptbPasswordInfo.Name = "ptbPasswordInfo";
            ptbPasswordInfo.Size = new Size(37, 47);
            ptbPasswordInfo.SizeMode = PictureBoxSizeMode.Zoom;
            ptbPasswordInfo.TabIndex = 20;
            ptbPasswordInfo.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(439, 399);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 47);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            // 
            // chbSifreyiGöster
            // 
            chbSifreyiGöster.AutoSize = true;
            chbSifreyiGöster.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            chbSifreyiGöster.Location = new Point(554, 461);
            chbSifreyiGöster.Margin = new Padding(3, 4, 3, 4);
            chbSifreyiGöster.Name = "chbSifreyiGöster";
            chbSifreyiGöster.Size = new Size(159, 27);
            chbSifreyiGöster.TabIndex = 22;
            chbSifreyiGöster.Text = "Şifreyi Göster";
            chbSifreyiGöster.UseVisualStyleBackColor = true;
            chbSifreyiGöster.CheckedChanged += chbSifreyiGöster_CheckedChanged;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(498, 452);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(37, 47);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 23;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ActiveBorder;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(12, 59);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(380, 429);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 24;
            pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(888, 59);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(493, 429);
            pictureBox5.TabIndex = 25;
            pictureBox5.TabStop = false;
            // 
            // btnUpdatePassword
            // 
            btnUpdatePassword.BackColor = Color.Transparent;
            btnUpdatePassword.FlatAppearance.BorderColor = Color.White;
            btnUpdatePassword.FlatAppearance.MouseOverBackColor = Color.Red;
            btnUpdatePassword.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnUpdatePassword.ForeColor = Color.Black;
            btnUpdatePassword.Location = new Point(533, 508);
            btnUpdatePassword.Margin = new Padding(3, 4, 3, 4);
            btnUpdatePassword.Name = "btnUpdatePassword";
            btnUpdatePassword.Size = new Size(214, 55);
            btnUpdatePassword.TabIndex = 26;
            btnUpdatePassword.Text = "Şifre Yenile";
            btnUpdatePassword.UseVisualStyleBackColor = false;
            btnUpdatePassword.Click += btnUpdatePassword_Click;
            // 
            // txtIpucu
            // 
            txtIpucu.Location = new Point(498, 249);
            txtIpucu.Margin = new Padding(3, 4, 3, 4);
            txtIpucu.Multiline = true;
            txtIpucu.Name = "txtIpucu";
            txtIpucu.PlaceholderText = "ipucunu yazınız";
            txtIpucu.Size = new Size(274, 45);
            txtIpucu.TabIndex = 27;
            // 
            // PasswordRenewScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1393, 564);
            ControlBox = false;
            Controls.Add(txtIpucu);
            Controls.Add(btnUpdatePassword);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox4);
            Controls.Add(chbSifreyiGöster);
            Controls.Add(pictureBox2);
            Controls.Add(ptbPasswordInfo);
            Controls.Add(txtYeniSifre);
            Controls.Add(label5);
            Controls.Add(btnCheckInfos);
            Controls.Add(pictureBox1);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "PasswordRenewScreen";
            Load += PasswordRenewScreen_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbPasswordInfo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnClose;
        private Label label2;
        private Label label3;
        private TextBox txtEmail;
        private PictureBox pictureBox1;
        private Button btnCheckInfos;
        private Label label5;
        private TextBox txtYeniSifre;
        private PictureBox ptbPasswordInfo;
        private PictureBox pictureBox2;
        private CheckBox chbSifreyiGöster;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox5;
        private Button btnUpdatePassword;
        private TextBox txtIpucu;
    }
}