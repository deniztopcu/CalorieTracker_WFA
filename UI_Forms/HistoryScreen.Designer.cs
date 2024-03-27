namespace UI_Forms
{
    partial class HistoryScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryScreen));
            lvMeals = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            btnOgunSil = new Button();
            dgTarihOgun = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgTarihOgun).BeginInit();
            SuspendLayout();
            // 
            // lvMeals
            // 
            lvMeals.BackColor = SystemColors.InactiveCaption;
            lvMeals.BorderStyle = BorderStyle.None;
            lvMeals.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader2, columnHeader9, columnHeader3, columnHeader5, columnHeader8, columnHeader6, columnHeader7 });
            lvMeals.FullRowSelect = true;
            lvMeals.GridLines = true;
            lvMeals.Location = new Point(11, 33);
            lvMeals.Name = "lvMeals";
            lvMeals.Size = new Size(822, 405);
            lvMeals.TabIndex = 7;
            lvMeals.UseCompatibleStateImageBehavior = false;
            lvMeals.View = View.Details;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "ID";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "AD";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 100;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "KATEGORİ";
            columnHeader9.TextAlign = HorizontalAlignment.Center;
            columnHeader9.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "KALORİ/BİRİM";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "ADET";
            columnHeader5.TextAlign = HorizontalAlignment.Center;
            columnHeader5.Width = 80;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "TOPLAM KALORİ";
            columnHeader8.TextAlign = HorizontalAlignment.Center;
            columnHeader8.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "PORSİYON TÜRÜ";
            columnHeader6.TextAlign = HorizontalAlignment.Center;
            columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "ÖĞÜN TİPİ";
            columnHeader7.Width = 100;
            // 
            // btnOgunSil
            // 
            btnOgunSil.BackColor = SystemColors.GradientInactiveCaption;
            btnOgunSil.FlatAppearance.BorderSize = 0;
            btnOgunSil.FlatStyle = FlatStyle.Flat;
            btnOgunSil.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnOgunSil.Image = (Image)resources.GetObject("btnOgunSil.Image");
            btnOgunSil.Location = new Point(258, 462);
            btnOgunSil.Name = "btnOgunSil";
            btnOgunSil.Size = new Size(311, 148);
            btnOgunSil.TabIndex = 9;
            btnOgunSil.Text = "ÖĞÜNÜ SİL";
            btnOgunSil.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOgunSil.UseVisualStyleBackColor = false;
            btnOgunSil.Click += btnOgunSil_Click;
            // 
            // dgTarihOgun
            // 
            dgTarihOgun.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgTarihOgun.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgTarihOgun.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgTarihOgun.Location = new Point(878, 38);
            dgTarihOgun.Name = "dgTarihOgun";
            dgTarihOgun.RowHeadersWidth = 51;
            dgTarihOgun.Size = new Size(293, 400);
            dgTarihOgun.TabIndex = 11;
            // 
            // HistoryScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1206, 644);
            ControlBox = false;
            Controls.Add(dgTarihOgun);
            Controls.Add(btnOgunSil);
            Controls.Add(lvMeals);
            Name = "HistoryScreen";
            Load += HistoryScreen_Load;
            ((System.ComponentModel.ISupportInitialize)dgTarihOgun).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListView lvMeals;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader6;
        private Button btnOgunSil;
        private ColumnHeader columnHeader7;
        private DataGridView dgTarihOgun;
    }
}