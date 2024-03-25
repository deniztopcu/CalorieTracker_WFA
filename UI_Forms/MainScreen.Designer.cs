namespace UI_Forms
{
    partial class MainScreen
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            panel1 = new Panel();
            pbLogo = new PictureBox();
            btnApplicationExit = new Button();
            btnUserInfo = new Button();
            lblTime = new Label();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel2 = new Panel();
            btnAddFood = new Button();
            btnAddMeal = new Button();
            btnAnalize = new Button();
            btnHistory = new Button();
            btnHealthStatus = new Button();
            btnHome = new Button();
            pnlMain = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Pink;
            panel1.Controls.Add(pbLogo);
            panel1.Controls.Add(btnApplicationExit);
            panel1.Controls.Add(btnUserInfo);
            panel1.Controls.Add(lblTime);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(3, 4);
            panel1.Name = "panel1";

            panel1.Size = new Size(1486, 79);

            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // pbLogo
            // 
            pbLogo.BackColor = Color.Pink;
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(0, 0);
            pbLogo.Margin = new Padding(3, 4, 3, 4);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(166, 72);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 9;
            pbLogo.TabStop = false;
            // 
            // btnApplicationExit
            // 
            btnApplicationExit.FlatAppearance.BorderSize = 0;
            btnApplicationExit.FlatStyle = FlatStyle.Flat;
            btnApplicationExit.ForeColor = SystemColors.ControlText;
            btnApplicationExit.Image = (Image)resources.GetObject("btnApplicationExit.Image");

            btnApplicationExit.Location = new Point(1394, 12);

            btnApplicationExit.Location = new Point(1105, 18);

            btnApplicationExit.Margin = new Padding(3, 4, 3, 4);
            btnApplicationExit.Name = "btnApplicationExit";
            btnApplicationExit.Size = new Size(75, 36);
            btnApplicationExit.TabIndex = 8;
            btnApplicationExit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnApplicationExit.UseVisualStyleBackColor = true;
            btnApplicationExit.Click += btnApplicationExit_Click;
            // 
            // btnUserInfo
            // 
            btnUserInfo.FlatAppearance.BorderSize = 0;
            btnUserInfo.FlatStyle = FlatStyle.Flat;
            btnUserInfo.ForeColor = SystemColors.ControlText;
            btnUserInfo.Image = (Image)resources.GetObject("btnUserInfo.Image");

            btnUserInfo.Location = new Point(1239, 8);

            btnUserInfo.Margin = new Padding(3, 4, 3, 4);
            btnUserInfo.Name = "btnUserInfo";
            btnUserInfo.Size = new Size(72, 64);
            btnUserInfo.TabIndex = 5;
            btnUserInfo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUserInfo.UseVisualStyleBackColor = true;
            btnUserInfo.Click += btnUserInfo_Click;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTime.Location = new Point(550, 23);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(55, 23);
            lblTime.TabIndex = 6;
            lblTime.Text = "Time";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(187, 23);
            label2.Name = "label2";
            label2.Size = new Size(253, 23);
            label2.TabIndex = 7;
            label2.Text = "KALORİ TAKİP PROGRAMI";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Pink;
            panel2.Controls.Add(btnAddFood);
            panel2.Controls.Add(btnAddMeal);
            panel2.Controls.Add(btnAnalize);
            panel2.Controls.Add(btnHistory);
            panel2.Controls.Add(btnHealthStatus);
            panel2.Controls.Add(btnHome);
            panel2.Location = new Point(3, 75);
            panel2.Name = "panel2";

            panel2.Size = new Size(166, 689);

            panel2.TabIndex = 1;
            // 
            // btnAddFood
            // 
            btnAddFood.FlatAppearance.BorderSize = 0;
            btnAddFood.FlatStyle = FlatStyle.Flat;
            btnAddFood.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnAddFood.ForeColor = SystemColors.ControlText;
            btnAddFood.Image = (Image)resources.GetObject("btnAddFood.Image");
            btnAddFood.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddFood.Location = new Point(6, 443);
            btnAddFood.Margin = new Padding(3, 4, 3, 4);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(140, 97);
            btnAddFood.TabIndex = 8;
            btnAddFood.Text = "       YEMEK EKLE";
            btnAddFood.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddFood.UseVisualStyleBackColor = true;
            btnAddFood.Click += btnAddNutrition_Click;
            // 
            // btnAddMeal
            // 
            btnAddMeal.FlatAppearance.BorderSize = 0;
            btnAddMeal.FlatStyle = FlatStyle.Flat;
            btnAddMeal.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnAddMeal.ForeColor = SystemColors.ControlText;
            btnAddMeal.Image = (Image)resources.GetObject("btnAddMeal.Image");
            btnAddMeal.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddMeal.Location = new Point(0, 357);
            btnAddMeal.Margin = new Padding(3, 4, 3, 4);
            btnAddMeal.Name = "btnAddMeal";
            btnAddMeal.Size = new Size(158, 83);
            btnAddMeal.TabIndex = 7;
            btnAddMeal.Text = "       ÖĞÜN EKLE";
            btnAddMeal.TextAlign = ContentAlignment.TopCenter;
            btnAddMeal.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddMeal.UseVisualStyleBackColor = true;
            btnAddMeal.Click += btnAddMeal_Click;
            // 
            // btnAnalize
            // 
            btnAnalize.FlatAppearance.BorderSize = 0;
            btnAnalize.FlatStyle = FlatStyle.Flat;
            btnAnalize.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnAnalize.ForeColor = SystemColors.ControlText;
            btnAnalize.Image = (Image)resources.GetObject("btnAnalize.Image");
            btnAnalize.ImageAlign = ContentAlignment.MiddleLeft;
            btnAnalize.Location = new Point(2, 283);
            btnAnalize.Margin = new Padding(3, 4, 3, 4);
            btnAnalize.Name = "btnAnalize";
            btnAnalize.Size = new Size(161, 83);
            btnAnalize.TabIndex = 6;
            btnAnalize.Text = "       ANALİZ";
            btnAnalize.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAnalize.UseVisualStyleBackColor = true;
            btnAnalize.Click += btnAnalize_Click;
            // 
            // btnHistory
            // 
            btnHistory.FlatAppearance.BorderSize = 0;
            btnHistory.FlatStyle = FlatStyle.Flat;
            btnHistory.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnHistory.ForeColor = SystemColors.ControlText;
            btnHistory.Image = (Image)resources.GetObject("btnHistory.Image");
            btnHistory.ImageAlign = ContentAlignment.MiddleLeft;
            btnHistory.Location = new Point(5, 206);
            btnHistory.Margin = new Padding(3, 4, 3, 4);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(161, 88);
            btnHistory.TabIndex = 5;
            btnHistory.Text = "       GEÇMİŞ";
            btnHistory.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHistory.UseVisualStyleBackColor = true;
            btnHistory.Click += btnHistory_Click;
            // 
            // btnHealthStatus
            // 
            btnHealthStatus.FlatAppearance.BorderSize = 0;
            btnHealthStatus.FlatStyle = FlatStyle.Flat;
            btnHealthStatus.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnHealthStatus.ForeColor = SystemColors.ControlText;
            btnHealthStatus.Image = (Image)resources.GetObject("btnHealthStatus.Image");
            btnHealthStatus.ImageAlign = ContentAlignment.MiddleLeft;
            btnHealthStatus.Location = new Point(6, 116);
            btnHealthStatus.Margin = new Padding(3, 4, 3, 4);
            btnHealthStatus.Name = "btnHealthStatus";
            btnHealthStatus.Size = new Size(155, 96);
            btnHealthStatus.TabIndex = 4;
            btnHealthStatus.Text = "     SAĞLIK BİLGİSİ";
            btnHealthStatus.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHealthStatus.UseVisualStyleBackColor = true;
            btnHealthStatus.Click += btnHealthStatus_Click;
            // 
            // btnHome
            // 
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnHome.ForeColor = Color.Black;
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(0, 22);
            btnHome.Margin = new Padding(3, 4, 3, 4);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(158, 101);
            btnHome.TabIndex = 3;
            btnHome.Text = "       ANA SAYFA";
            btnHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // pnlMain
            // 
            pnlMain.Location = new Point(167, 79);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1322, 682);
            pnlMain.TabIndex = 3;
            pnlMain.Paint += pnlMain_Paint;
            // 
            // MainScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;

            ClientSize = new Size(1491, 776);

            ControlBox = false;
            Controls.Add(pnlMain);
            Controls.Add(panel2);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Name = "MainScreen";
            Load += MainScreen_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnApplicationExit;
        private Button btnUserInfo;
        private Label lblTime;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
        private Panel panel2;
        private Button btnAddMeal;
        private Button btnAnalize;
        private Button btnHistory;
        private Button btnHealthStatus;
        private Button btnHome;
        private Button btnAddFood;
        private PictureBox pbLogo;
        private Panel pnlMain;
    }
}