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
            columnHeader7 = new ColumnHeader();
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
            gbxAddFood.Location = new Point(847, 13);
            gbxAddFood.Margin = new Padding(3, 4, 3, 4);
            gbxAddFood.Name = "gbxAddFood";
            gbxAddFood.Padding = new Padding(3, 4, 3, 4);
            gbxAddFood.Size = new Size(470, 637);
            gbxAddFood.TabIndex = 12;
            gbxAddFood.TabStop = false;
            gbxAddFood.Text = "Add Food";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(90, 320);
            label5.Name = "label5";
            label5.Size = new Size(71, 23);
            label5.TabIndex = 15;
            label5.Text = "Gram:";
            // 
            // txtGram
            // 
            txtGram.Location = new Point(207, 317);
            txtGram.Margin = new Padding(3, 4, 3, 4);
            txtGram.Name = "txtGram";
            txtGram.Size = new Size(194, 32);
            txtGram.TabIndex = 14;
            // 
            // pbFoodImage
            // 
            pbFoodImage.BorderStyle = BorderStyle.FixedSingle;
            pbFoodImage.Image = (Image)resources.GetObject("pbFoodImage.Image");
            pbFoodImage.Location = new Point(130, 42);
            pbFoodImage.Margin = new Padding(3, 4, 3, 4);
            pbFoodImage.Name = "pbFoodImage";
            pbFoodImage.Size = new Size(198, 124);
            pbFoodImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFoodImage.TabIndex = 13;
            pbFoodImage.TabStop = false;
            pbFoodImage.Click += pbFoodImage_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 442);
            label4.Name = "label4";
            label4.Size = new Size(108, 23);
            label4.TabIndex = 12;
            label4.Text = "Category:";
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(207, 439);
            cbCategory.Margin = new Padding(3, 4, 3, 4);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(194, 31);
            cbCategory.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 378);
            label3.Name = "label3";
            label3.Size = new Size(134, 23);
            label3.TabIndex = 10;
            label3.Text = "Portion Type:";
            // 
            // cbPortionType
            // 
            cbPortionType.FormattingEnabled = true;
            cbPortionType.Location = new Point(207, 375);
            cbPortionType.Margin = new Padding(3, 4, 3, 4);
            cbPortionType.Name = "cbPortionType";
            cbPortionType.Size = new Size(194, 31);
            cbPortionType.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 270);
            label2.Name = "label2";
            label2.Size = new Size(87, 23);
            label2.TabIndex = 8;
            label2.Text = "Calorie:";
            // 
            // txtCalorie
            // 
            txtCalorie.Location = new Point(207, 261);
            txtCalorie.Margin = new Padding(3, 4, 3, 4);
            txtCalorie.Name = "txtCalorie";
            txtCalorie.Size = new Size(194, 32);
            txtCalorie.TabIndex = 7;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(42, 542);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(98, 60);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(181, 542);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(98, 60);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(332, 542);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(97, 60);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 207);
            label1.Name = "label1";
            label1.Size = new Size(131, 23);
            label1.TabIndex = 1;
            label1.Text = "Food Name:";
            // 
            // txtFoodName
            // 
            txtFoodName.Location = new Point(207, 207);
            txtFoodName.Margin = new Padding(3, 4, 3, 4);
            txtFoodName.Name = "txtFoodName";
            txtFoodName.Size = new Size(194, 32);
            txtFoodName.TabIndex = 0;
            // 
            // grpMeals
            // 
            grpMeals.Controls.Add(lstFoods);
            grpMeals.Font = new Font("Century Gothic", 12F);
            grpMeals.Location = new Point(39, 36);
            grpMeals.Margin = new Padding(3, 4, 3, 4);
            grpMeals.Name = "grpMeals";
            grpMeals.Padding = new Padding(3, 4, 3, 4);
            grpMeals.Size = new Size(778, 614);
            grpMeals.TabIndex = 14;
            grpMeals.TabStop = false;
            grpMeals.Text = "Foods";
            // 
            // lstFoods
            // 
            lstFoods.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader4, columnHeader5, columnHeader3, columnHeader6, columnHeader7 });
            lstFoods.FullRowSelect = true;
            lstFoods.GridLines = true;
            lstFoods.Location = new Point(12, 33);
            lstFoods.Margin = new Padding(3, 4, 3, 4);
            lstFoods.Name = "lstFoods";
            lstFoods.Size = new Size(764, 573);
            lstFoods.TabIndex = 5;
            lstFoods.UseCompatibleStateImageBehavior = false;
            lstFoods.View = View.Details;
            lstFoods.SelectedIndexChanged += lstFoods_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "FoodID";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "UserID";
            columnHeader2.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Name";
            columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Calorie";
            columnHeader5.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Gram";
            columnHeader3.Width = 120;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Portion Type";
            columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Category";
            columnHeader7.Width = 100;
            // 
            // AddFoodScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1320, 681);
            ControlBox = false;
            Controls.Add(grpMeals);
            Controls.Add(gbxAddFood);
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
        private ColumnHeader columnHeader7;
        private PictureBox pbFoodImage;
    }
}