namespace UI_Forms
{
    partial class AddFoodScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFoodScreen));
            gbxAddFood = new GroupBox();
            label5 = new Label();
            txtGram = new TextBox();
            pbFoodImage = new PictureBox();
            label4 = new Label();
            cbCategory = new ComboBox();
            label3 = new Label();
            cbPortionType = new ComboBox();
            label2 = new Label();
            txtCalorie = new TextBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            label1 = new Label();
            txtFoodName = new TextBox();
            grpMeals = new GroupBox();
            lstFoods = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            gbxAddFood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbFoodImage).BeginInit();
            grpMeals.SuspendLayout();
            SuspendLayout();
            // 
            // gbxAddFood
            // 
            gbxAddFood.Controls.Add(label5);
            gbxAddFood.Controls.Add(txtGram);
            gbxAddFood.Controls.Add(pbFoodImage);
            gbxAddFood.Controls.Add(label4);
            gbxAddFood.Controls.Add(cbCategory);
            gbxAddFood.Controls.Add(label3);
            gbxAddFood.Controls.Add(cbPortionType);
            gbxAddFood.Controls.Add(label2);
            gbxAddFood.Controls.Add(txtCalorie);
            gbxAddFood.Controls.Add(btnDelete);
            gbxAddFood.Controls.Add(btnUpdate);
            gbxAddFood.Controls.Add(btnAdd);
            gbxAddFood.Controls.Add(label1);
            gbxAddFood.Controls.Add(txtFoodName);
            gbxAddFood.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            gbxAddFood.Location = new Point(741, 10);
            gbxAddFood.Name = "gbxAddFood";
            gbxAddFood.Size = new Size(411, 478);
            gbxAddFood.TabIndex = 12;
            gbxAddFood.TabStop = false;
            gbxAddFood.Text = "Yemek Ekle";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(48, 241);
            label5.Name = "label5";
            label5.Size = new Size(58, 19);
            label5.TabIndex = 15;
            label5.Text = "Gram:";
            // 
            // txtGram
            // 
            txtGram.Location = new Point(181, 238);
            txtGram.Name = "txtGram";
            txtGram.Size = new Size(170, 27);
            txtGram.TabIndex = 14;
            // 
            // pbFoodImage
            // 
            pbFoodImage.BorderStyle = BorderStyle.FixedSingle;
            pbFoodImage.Image = (Image)resources.GetObject("pbFoodImage.Image");
            pbFoodImage.Location = new Point(114, 32);
            pbFoodImage.Name = "pbFoodImage";
            pbFoodImage.Size = new Size(174, 94);
            pbFoodImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFoodImage.TabIndex = 13;
            pbFoodImage.TabStop = false;
            pbFoodImage.Click += pbFoodImage_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 332);
            label4.Name = "label4";
            label4.Size = new Size(74, 19);
            label4.TabIndex = 12;
            label4.Text = "Kategori";
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(181, 329);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(170, 27);
            cbCategory.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 289);
            label3.Name = "label3";
            label3.Size = new Size(102, 19);
            label3.TabIndex = 10;
            label3.Text = "Porsiyon Tipi";
            // 
            // cbPortionType
            // 
            cbPortionType.FormattingEnabled = true;
            cbPortionType.Location = new Point(181, 281);
            cbPortionType.Name = "cbPortionType";
            cbPortionType.Size = new Size(170, 27);
            cbPortionType.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 199);
            label2.Name = "label2";
            label2.Size = new Size(57, 19);
            label2.TabIndex = 8;
            label2.Text = "Kalori:";
            // 
            // txtCalorie
            // 
            txtCalorie.Location = new Point(181, 196);
            txtCalorie.Name = "txtCalorie";
            txtCalorie.Size = new Size(170, 27);
            txtCalorie.TabIndex = 7;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(37, 406);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 45);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(158, 406);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(103, 45);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(290, 406);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(85, 45);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 163);
            label1.Name = "label1";
            label1.Size = new Size(99, 19);
            label1.TabIndex = 1;
            label1.Text = "Yemek Adı:";
            // 
            // txtFoodName
            // 
            txtFoodName.Location = new Point(181, 155);
            txtFoodName.Name = "txtFoodName";
            txtFoodName.Size = new Size(170, 27);
            txtFoodName.TabIndex = 0;
            // 
            // grpMeals
            // 
            grpMeals.Controls.Add(lstFoods);
            grpMeals.Font = new Font("Century Gothic", 12F);
            grpMeals.Location = new Point(34, 27);
            grpMeals.Name = "grpMeals";
            grpMeals.Size = new Size(681, 460);
            grpMeals.TabIndex = 14;
            grpMeals.TabStop = false;
            grpMeals.Text = "Yemekler";
            // 
            // lstFoods
            // 
            lstFoods.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader4, columnHeader5, columnHeader3, columnHeader6 });
            lstFoods.FullRowSelect = true;
            lstFoods.GridLines = true;
            lstFoods.Location = new Point(10, 25);
            lstFoods.Name = "lstFoods";
            lstFoods.Size = new Size(669, 431);
            lstFoods.TabIndex = 5;
            lstFoods.UseCompatibleStateImageBehavior = false;
            lstFoods.View = View.Details;
            lstFoods.SelectedIndexChanged += lstFoods_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "YemekID";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "KullanıcıID";
            columnHeader2.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "YemekAdı";
            columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Kalori";
            columnHeader5.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Gram";
            columnHeader3.Width = 120;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Porsiyon Tipi";
            columnHeader6.Width = 120;
            // 
            // AddFoodScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1155, 511);
            ControlBox = false;
            Controls.Add(grpMeals);
            Controls.Add(gbxAddFood);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddFoodScreen";
            Load += AddFoodScreen_Load;
            gbxAddFood.ResumeLayout(false);
            gbxAddFood.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbFoodImage).EndInit();
            grpMeals.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxAddFood;
        private Label label5;
        private TextBox txtGram;
        private Label label4;
        private ComboBox cbCategory;
        private Label label3;
        private ComboBox cbPortionType;
        private Label label2;
        private TextBox txtCalorie;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Label label1;
        private TextBox txtFoodName;
        private GroupBox grpMeals;
        private ListView lstFoods;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader6;
        private PictureBox pbFoodImage;
    }
}