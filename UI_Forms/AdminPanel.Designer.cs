namespace UI_Forms
{
    partial class AdminPanel
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
            btnBack = new Button();
            btnGüncelle = new Button();
            btnSil = new Button();
            txtSifre = new TextBox();
            txtEmail = new TextBox();
            label2 = new Label();
            label1 = new Label();
            grpAdminPanel = new GroupBox();
            lvKullanıcılar = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            grpAdminPanel.SuspendLayout();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnBack.Location = new Point(109, 312);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(143, 68);
            btnBack.TabIndex = 16;
            btnBack.Text = "Ana Menüye Dön";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // btnGüncelle
            // 
            btnGüncelle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGüncelle.Location = new Point(185, 219);
            btnGüncelle.Margin = new Padding(3, 4, 3, 4);
            btnGüncelle.Name = "btnGüncelle";
            btnGüncelle.Size = new Size(102, 55);
            btnGüncelle.TabIndex = 15;
            btnGüncelle.Text = "Güncelle";
            btnGüncelle.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            btnSil.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSil.Location = new Point(55, 219);
            btnSil.Margin = new Padding(3, 4, 3, 4);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(102, 55);
            btnSil.TabIndex = 14;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(81, 132);
            txtSifre.Margin = new Padding(3, 4, 3, 4);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(228, 27);
            txtSifre.TabIndex = 13;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(81, 60);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(228, 27);
            txtEmail.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(24, 132);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 11;
            label2.Text = "Şifre :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(24, 60);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 10;
            label1.Text = "Email:";
            // 
            // grpAdminPanel
            // 
            grpAdminPanel.Controls.Add(lvKullanıcılar);
            grpAdminPanel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            grpAdminPanel.Location = new Point(390, 27);
            grpAdminPanel.Margin = new Padding(3, 4, 3, 4);
            grpAdminPanel.Name = "grpAdminPanel";
            grpAdminPanel.Padding = new Padding(3, 4, 3, 4);
            grpAdminPanel.Size = new Size(387, 399);
            grpAdminPanel.TabIndex = 9;
            grpAdminPanel.TabStop = false;
            grpAdminPanel.Text = "Kullanıcı Listesi";
            // 
            // lvKullanıcılar
            // 
            lvKullanıcılar.BackColor = SystemColors.InactiveCaption;
            lvKullanıcılar.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lvKullanıcılar.FullRowSelect = true;
            lvKullanıcılar.GridLines = true;
            lvKullanıcılar.Location = new Point(45, 33);
            lvKullanıcılar.Margin = new Padding(3, 4, 3, 4);
            lvKullanıcılar.Name = "lvKullanıcılar";
            lvKullanıcılar.Size = new Size(305, 354);
            lvKullanıcılar.TabIndex = 0;
            lvKullanıcılar.UseCompatibleStateImageBehavior = false;
            lvKullanıcılar.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "UsersID";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Email";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Password";
            columnHeader3.Width = 90;
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(btnBack);
            Controls.Add(btnGüncelle);
            Controls.Add(btnSil);
            Controls.Add(txtSifre);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(grpAdminPanel);
            Name = "AdminPanel";
            Load += AdminPanel_Load;
            grpAdminPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Button btnGüncelle;
        private Button btnSil;
        private TextBox txtSifre;
        private TextBox txtEmail;
        private Label label2;
        private Label label1;
        private GroupBox grpAdminPanel;
        private ListView lvKullanıcılar;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
    }
}