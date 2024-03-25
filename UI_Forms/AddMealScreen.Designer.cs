namespace UI_Forms
{
    partial class AddMealScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMealScreen));
            pictureBox1 = new PictureBox();
            gbxAddMeal = new GroupBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            label1 = new Label();
            txtMealName = new TextBox();
            gbxAddMeals = new GroupBox();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            lstMeals = new ListView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            gbxAddMeal.SuspendLayout();
            gbxAddMeals.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(43, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(520, 301);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // gbxAddMeal
            // 
            gbxAddMeal.BackColor = SystemColors.ActiveCaption;
            gbxAddMeal.Controls.Add(btnDelete);
            gbxAddMeal.Controls.Add(btnUpdate);
            gbxAddMeal.Controls.Add(btnAdd);
            gbxAddMeal.Controls.Add(label1);
            gbxAddMeal.Controls.Add(txtMealName);
            gbxAddMeal.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            gbxAddMeal.Location = new Point(659, 31);
            gbxAddMeal.Margin = new Padding(3, 4, 3, 4);
            gbxAddMeal.Name = "gbxAddMeal";
            gbxAddMeal.Padding = new Padding(3, 4, 3, 4);
            gbxAddMeal.Size = new Size(439, 610);
            gbxAddMeal.TabIndex = 14;
            gbxAddMeal.TabStop = false;
            gbxAddMeal.Text = "Add Meal";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(101, 245);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(98, 63);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(270, 245);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(98, 63);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(189, 362);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(103, 63);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 115);
            label1.Name = "label1";
            label1.Size = new Size(131, 23);
            label1.TabIndex = 1;
            label1.Text = "Meal Name:";
            // 
            // txtMealName
            // 
            txtMealName.Location = new Point(173, 102);
            txtMealName.Margin = new Padding(3, 4, 3, 4);
            txtMealName.Multiline = true;
            txtMealName.Name = "txtMealName";
            txtMealName.Size = new Size(241, 52);
            txtMealName.TabIndex = 0;
            // 
            // gbxAddMeals
            // 
            gbxAddMeals.BackColor = SystemColors.ActiveCaption;
            gbxAddMeals.Controls.Add(lstMeals);
            gbxAddMeals.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            gbxAddMeals.Location = new Point(37, 327);
            gbxAddMeals.Name = "gbxAddMeals";
            gbxAddMeals.Size = new Size(526, 338);
            gbxAddMeals.TabIndex = 13;
            gbxAddMeals.TabStop = false;
            gbxAddMeals.Text = "Meals";
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Name";
            columnHeader2.Width = 120;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Is Active";
            columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Created Date";
            columnHeader5.Width = 130;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Deleted Date";
            columnHeader7.Width = 120;
            // 
            // lstMeals
            // 
            lstMeals.BackColor = SystemColors.InactiveCaption;
            lstMeals.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader4, columnHeader5, columnHeader7 });
            lstMeals.FullRowSelect = true;
            lstMeals.GridLines = true;
            lstMeals.Location = new Point(6, 32);
            lstMeals.Margin = new Padding(3, 4, 3, 4);
            lstMeals.Name = "lstMeals";
            lstMeals.Size = new Size(506, 299);
            lstMeals.TabIndex = 12;
            lstMeals.UseCompatibleStateImageBehavior = false;
            lstMeals.View = View.Details;
            // 
            // AddMealScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1110, 677);
            ControlBox = false;
            Controls.Add(gbxAddMeal);
            Controls.Add(gbxAddMeals);
            Controls.Add(pictureBox1);
            Name = "AddMealScreen";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            gbxAddMeal.ResumeLayout(false);
            gbxAddMeal.PerformLayout();
            gbxAddMeals.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private GroupBox gbxAddMeal;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Label label1;
        private TextBox txtMealName;
        private GroupBox gbxAddMeals;
        private ListView lstMeals;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader7;
    }
}