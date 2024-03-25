namespace UI_Forms
{
    partial class UserInfoScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInfoScreen));
            pictureBox1 = new PictureBox();
            lblAd = new Label();
            lblSoyad = new Label();
            lblDogumTarihi = new Label();
            lblCinsiyet = new Label();
            lblBoy = new Label();
            lblKilo = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtGuncelBoy = new TextBox();
            txtGuncelKilo = new TextBox();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtDogumTarihi = new TextBox();
            txtCinsiyet = new TextBox();
            txtBoy = new TextBox();
            txtKilo = new TextBox();
            label4 = new Label();
            lblUserType = new Label();
            btnUpdateHeightWeight = new Button();
            btnAdminPanel = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(115, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(171, 130);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAd.ForeColor = SystemColors.Highlight;
            lblAd.Location = new Point(33, 175);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(29, 20);
            lblAd.TabIndex = 1;
            lblAd.Text = "Ad";
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSoyad.ForeColor = SystemColors.Highlight;
            lblSoyad.Location = new Point(28, 209);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(51, 20);
            lblSoyad.TabIndex = 2;
            lblSoyad.Text = "Soyad";
            // 
            // lblDogumTarihi
            // 
            lblDogumTarihi.AutoSize = true;
            lblDogumTarihi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDogumTarihi.ForeColor = SystemColors.Highlight;
            lblDogumTarihi.Location = new Point(28, 274);
            lblDogumTarihi.Name = "lblDogumTarihi";
            lblDogumTarihi.Size = new Size(104, 20);
            lblDogumTarihi.TabIndex = 3;
            lblDogumTarihi.Text = "Doğum Tarihi";
            // 
            // lblCinsiyet
            // 
            lblCinsiyet.AutoSize = true;
            lblCinsiyet.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCinsiyet.ForeColor = SystemColors.Highlight;
            lblCinsiyet.Location = new Point(28, 323);
            lblCinsiyet.Name = "lblCinsiyet";
            lblCinsiyet.Size = new Size(64, 20);
            lblCinsiyet.TabIndex = 4;
            lblCinsiyet.Text = "Cinsiyet";
            // 
            // lblBoy
            // 
            lblBoy.AutoSize = true;
            lblBoy.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBoy.ForeColor = SystemColors.Highlight;
            lblBoy.Location = new Point(33, 376);
            lblBoy.Name = "lblBoy";
            lblBoy.Size = new Size(36, 20);
            lblBoy.TabIndex = 5;
            lblBoy.Text = "Boy";
            // 
            // lblKilo
            // 
            lblKilo.AutoSize = true;
            lblKilo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblKilo.ForeColor = SystemColors.Highlight;
            lblKilo.Location = new Point(33, 414);
            lblKilo.Name = "lblKilo";
            lblKilo.Size = new Size(36, 20);
            lblKilo.TabIndex = 6;
            lblKilo.Text = "Kilo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(462, 175);
            label1.Name = "label1";
            label1.Size = new Size(151, 20);
            label1.TabIndex = 7;
            label1.Text = "Boy ve Kilo Güncelle";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(413, 267);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 9;
            label2.Text = "Kilo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(413, 216);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 8;
            label3.Text = "Boy :";
            // 
            // txtGuncelBoy
            // 
            txtGuncelBoy.Location = new Point(466, 213);
            txtGuncelBoy.Name = "txtGuncelBoy";
            txtGuncelBoy.Size = new Size(149, 27);
            txtGuncelBoy.TabIndex = 10;
            // 
            // txtGuncelKilo
            // 
            txtGuncelKilo.Location = new Point(464, 267);
            txtGuncelKilo.Name = "txtGuncelKilo";
            txtGuncelKilo.Size = new Size(149, 27);
            txtGuncelKilo.TabIndex = 11;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(137, 176);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(149, 27);
            txtAd.TabIndex = 12;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(137, 209);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(149, 27);
            txtSoyad.TabIndex = 13;
            // 
            // txtDogumTarihi
            // 
            txtDogumTarihi.Location = new Point(138, 267);
            txtDogumTarihi.Name = "txtDogumTarihi";
            txtDogumTarihi.Size = new Size(149, 27);
            txtDogumTarihi.TabIndex = 14;
            // 
            // txtCinsiyet
            // 
            txtCinsiyet.Location = new Point(138, 320);
            txtCinsiyet.Name = "txtCinsiyet";
            txtCinsiyet.Size = new Size(149, 27);
            txtCinsiyet.TabIndex = 15;
            // 
            // txtBoy
            // 
            txtBoy.Location = new Point(138, 369);
            txtBoy.Name = "txtBoy";
            txtBoy.Size = new Size(149, 27);
            txtBoy.TabIndex = 16;
            // 
            // txtKilo
            // 
            txtKilo.Location = new Point(137, 414);
            txtKilo.Name = "txtKilo";
            txtKilo.Size = new Size(149, 27);
            txtKilo.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(346, 12);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 18;
            label4.Text = "User Type :";
            // 
            // lblUserType
            // 
            lblUserType.AutoSize = true;
            lblUserType.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUserType.Location = new Point(438, 12);
            lblUserType.Name = "lblUserType";
            lblUserType.Size = new Size(15, 20);
            lblUserType.TabIndex = 19;
            lblUserType.Text = "-";
            // 
            // btnUpdateHeightWeight
            // 
            btnUpdateHeightWeight.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnUpdateHeightWeight.ForeColor = SystemColors.ActiveCaptionText;
            btnUpdateHeightWeight.Image = (Image)resources.GetObject("btnUpdateHeightWeight.Image");
            btnUpdateHeightWeight.Location = new Point(462, 320);
            btnUpdateHeightWeight.Name = "btnUpdateHeightWeight";
            btnUpdateHeightWeight.Size = new Size(146, 61);
            btnUpdateHeightWeight.TabIndex = 20;
            btnUpdateHeightWeight.Text = "Güncelle";
            btnUpdateHeightWeight.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUpdateHeightWeight.UseVisualStyleBackColor = true;
            btnUpdateHeightWeight.Click += btnUpdateHeightWeight_Click;
            // 
            // btnAdminPanel
            // 
            btnAdminPanel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAdminPanel.ForeColor = SystemColors.ActiveCaptionText;
            btnAdminPanel.Location = new Point(512, 9);
            btnAdminPanel.Name = "btnAdminPanel";
            btnAdminPanel.Size = new Size(163, 27);
            btnAdminPanel.TabIndex = 21;
            btnAdminPanel.Text = "Admin Panel";
            btnAdminPanel.UseVisualStyleBackColor = true;
            btnAdminPanel.Click += btnAdminPanel_Click;
            // 
            // UserInfoScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(741, 464);
            ControlBox = false;
            Controls.Add(btnAdminPanel);
            Controls.Add(btnUpdateHeightWeight);
            Controls.Add(lblUserType);
            Controls.Add(label4);
            Controls.Add(txtKilo);
            Controls.Add(txtBoy);
            Controls.Add(txtCinsiyet);
            Controls.Add(txtDogumTarihi);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(txtGuncelKilo);
            Controls.Add(txtGuncelBoy);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(lblKilo);
            Controls.Add(lblBoy);
            Controls.Add(lblCinsiyet);
            Controls.Add(lblDogumTarihi);
            Controls.Add(lblSoyad);
            Controls.Add(lblAd);
            Controls.Add(pictureBox1);
            Name = "UserInfoScreen";
            Load += UserInfoScreen_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblAd;
        private Label lblSoyad;
        private Label lblDogumTarihi;
        private Label lblCinsiyet;
        private Label lblBoy;
        private Label lblKilo;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtGuncelBoy;
        private TextBox txtGuncelKilo;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtDogumTarihi;
        private TextBox txtCinsiyet;
        private TextBox txtBoy;
        private TextBox txtKilo;
        private Label label4;
        private Label lblUserType;
        private Button btnUpdateHeightWeight;
        private Button btnAdminPanel;
    }
}