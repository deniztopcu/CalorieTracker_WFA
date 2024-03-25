namespace UI_Forms
{
    partial class HealthStatusScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HealthStatusScreen));
            groupBox1 = new GroupBox();
            label1 = new Label();
            lblCalorieNeed = new Label();
            label10 = new Label();
            rbActive = new RadioButton();
            rbModerate = new RadioButton();
            rbLight = new RadioButton();
            rbSedentary = new RadioButton();
            lblUserGender = new Label();
            label9 = new Label();
            lblUserWeight = new Label();
            label7 = new Label();
            lblUserHeight = new Label();
            label5 = new Label();
            lblUserAge = new Label();
            label2 = new Label();
            btnCalculate = new Button();
            groupBox2 = new GroupBox();
            flpUsersMealsCalories = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            pbCalorieStatus = new ProgressBar();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCalculate);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lblCalorieNeed);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(rbActive);
            groupBox1.Controls.Add(rbModerate);
            groupBox1.Controls.Add(rbLight);
            groupBox1.Controls.Add(rbSedentary);
            groupBox1.Controls.Add(lblUserGender);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(lblUserWeight);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(lblUserHeight);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(lblUserAge);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            groupBox1.Location = new Point(40, 39);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(552, 380);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Günlük Kalori Tüketimi Hesaplayıcı";
            // 

            // btnCalculate
            // 
            btnCalculate.Location = new Point(411, 113);
            btnCalculate.Margin = new Padding(3, 4, 3, 4);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(123, 64);
            btnCalculate.TabIndex = 24;
            btnCalculate.Text = "Hesapla";
            btnCalculate.UseVisualStyleBackColor = true;
            // 

            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(226, 42);
            label1.Name = "label1";
            label1.Size = new Size(233, 23);
            label1.TabIndex = 23;
            label1.Text = "Günlük Fiziksel Aktivite";
            // 
            // lblCalorieNeed
            // 
            lblCalorieNeed.AutoSize = true;
            lblCalorieNeed.Location = new Point(337, 321);
            lblCalorieNeed.Name = "lblCalorieNeed";
            lblCalorieNeed.Size = new Size(81, 23);
            lblCalorieNeed.TabIndex = 22;
            lblCalorieNeed.Text = "Calorie";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(79, 321);
            label10.Name = "label10";
            label10.Size = new Size(250, 23);
            label10.TabIndex = 21;
            label10.Text = "Günlük Kalori İhtiyacınız:";
            // 
            // rbActive
            // 
            rbActive.AutoSize = true;
            rbActive.Location = new Point(226, 234);
            rbActive.Margin = new Padding(3, 4, 3, 4);
            rbActive.Name = "rbActive";
            rbActive.Size = new Size(165, 27);
            rbActive.TabIndex = 20;
            rbActive.TabStop = true;
            rbActive.Text = "Çok Hareketli";
            rbActive.UseVisualStyleBackColor = true;
            // 
            // rbModerate
            // 
            rbModerate.AutoSize = true;
            rbModerate.Location = new Point(226, 180);
            rbModerate.Margin = new Padding(3, 4, 3, 4);
            rbModerate.Name = "rbModerate";
            rbModerate.Size = new Size(118, 27);
            rbModerate.TabIndex = 19;
            rbModerate.TabStop = true;
            rbModerate.Text = "Hareketli";
            rbModerate.UseVisualStyleBackColor = true;
            // 
            // rbLight
            // 
            rbLight.AutoSize = true;
            rbLight.Location = new Point(226, 125);
            rbLight.Margin = new Padding(3, 4, 3, 4);
            rbLight.Name = "rbLight";
            rbLight.Size = new Size(148, 27);
            rbLight.TabIndex = 18;
            rbLight.TabStop = true;
            rbLight.Text = "Az Hareketli";
            rbLight.UseVisualStyleBackColor = true;
            // 
            // rbSedentary
            // 
            rbSedentary.AutoSize = true;
            rbSedentary.Location = new Point(226, 78);
            rbSedentary.Margin = new Padding(3, 4, 3, 4);
            rbSedentary.Name = "rbSedentary";
            rbSedentary.Size = new Size(131, 27);
            rbSedentary.TabIndex = 17;
            rbSedentary.TabStop = true;
            rbSedentary.Text = "Hareketsiz";
            rbSedentary.UseVisualStyleBackColor = true;
            // 
            // lblUserGender
            // 
            lblUserGender.AutoSize = true;
            lblUserGender.Location = new Point(117, 220);
            lblUserGender.Name = "lblUserGender";
            lblUserGender.Size = new Size(84, 23);
            lblUserGender.TabIndex = 16;
            lblUserGender.Text = "Gender";
            lblUserGender.Click += lblUserGender_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(21, 220);
            label9.Name = "label9";
            label9.Size = new Size(94, 23);
            label9.TabIndex = 15;
            label9.Text = "Cinsiyet:";
            // 
            // lblUserWeight
            // 
            lblUserWeight.AutoSize = true;
            lblUserWeight.Location = new Point(117, 166);
            lblUserWeight.Name = "lblUserWeight";
            lblUserWeight.Size = new Size(77, 23);
            lblUserWeight.TabIndex = 14;
            lblUserWeight.Text = "Weight";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 165);
            label7.Name = "label7";
            label7.Size = new Size(51, 23);
            label7.TabIndex = 13;
            label7.Text = "Kilo:";
            // 
            // lblUserHeight
            // 
            lblUserHeight.AutoSize = true;
            lblUserHeight.Location = new Point(117, 113);
            lblUserHeight.Name = "lblUserHeight";
            lblUserHeight.Size = new Size(73, 23);
            lblUserHeight.TabIndex = 12;
            lblUserHeight.Text = "Height";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 113);
            label5.Name = "label5";
            label5.Size = new Size(53, 23);
            label5.TabIndex = 11;
            label5.Text = "Boy:";
            // 
            // lblUserAge
            // 
            lblUserAge.AutoSize = true;
            lblUserAge.Location = new Point(117, 64);
            lblUserAge.Name = "lblUserAge";
            lblUserAge.Size = new Size(51, 23);
            lblUserAge.TabIndex = 10;
            lblUserAge.Text = "Age";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 64);
            label2.Name = "label2";
            label2.Size = new Size(50, 23);
            label2.TabIndex = 9;
            label2.Text = "Yaş:";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(984, 219);
            btnCalculate.Margin = new Padding(3, 4, 3, 4);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(123, 64);
            btnCalculate.TabIndex = 24;
            btnCalculate.Text = "Hesapla";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(flpUsersMealsCalories);
            groupBox2.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            groupBox2.Location = new Point(40, 427);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(552, 228);
            groupBox2.TabIndex = 32;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kullanıcını Günlük Yemek Kalorisi";
            // 
            // flpUsersMealsCalories
            // 
            flpUsersMealsCalories.Location = new Point(7, 33);
            flpUsersMealsCalories.Margin = new Padding(3, 4, 3, 4);
            flpUsersMealsCalories.Name = "flpUsersMealsCalories";
            flpUsersMealsCalories.Size = new Size(527, 172);
            flpUsersMealsCalories.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(840, 150);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 252);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            // 
            // pbCalorieStatus
            // 
            pbCalorieStatus.BackColor = SystemColors.ActiveCaption;
            pbCalorieStatus.Location = new Point(690, 438);
            pbCalorieStatus.Margin = new Padding(3, 4, 3, 4);
            pbCalorieStatus.Name = "pbCalorieStatus";
            pbCalorieStatus.Size = new Size(518, 64);
            pbCalorieStatus.TabIndex = 34;
            // 
            // HealthStatusScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1242, 668);
            ControlBox = false;
            Controls.Add(pbCalorieStatus);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "HealthStatusScreen";
            Load += HealthStatusScreen_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnCalculate;
        private Label label1;
        private Label lblCalorieNeed;
        private Label label10;
        private RadioButton rbActive;
        private RadioButton rbModerate;
        private RadioButton rbLight;
        private RadioButton rbSedentary;
        private Label lblUserGender;
        private Label label9;
        private Label lblUserWeight;
        private Label label7;
        private Label lblUserHeight;
        private Label label5;
        private Label lblUserAge;
        private Label label2;
        private GroupBox groupBox2;
        private FlowLayoutPanel flpUsersMealsCalories;
        private PictureBox pictureBox1;
        private ProgressBar pbCalorieStatus;
    }
}