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
            lvDays = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            btnOgunSil = new Button();
            btnGunSil = new Button();
            SuspendLayout();
            // 
            // lvMeals
            // 
            lvMeals.BackColor = SystemColors.InactiveCaption;
            lvMeals.BorderStyle = BorderStyle.None;
            lvMeals.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader2, columnHeader9, columnHeader3, columnHeader5, columnHeader8, columnHeader6 });
            lvMeals.FullRowSelect = true;
            lvMeals.GridLines = true;
            lvMeals.Location = new Point(12, 33);
            lvMeals.Name = "lvMeals";
            lvMeals.Size = new Size(644, 406);
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
            // lvDays
            // 
            lvDays.BackColor = SystemColors.InactiveCaption;
            lvDays.BorderStyle = BorderStyle.None;
            lvDays.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader10 });
            lvDays.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lvDays.FullRowSelect = true;
            lvDays.GridLines = true;
            lvDays.Location = new Point(705, 33);
            lvDays.MultiSelect = false;
            lvDays.Name = "lvDays";
            lvDays.Size = new Size(322, 406);
            lvDays.TabIndex = 8;
            lvDays.UseCompatibleStateImageBehavior = false;
            lvDays.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "TARİHLER";
            columnHeader1.Width = 200;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "TOPLAM KALORİ";
            columnHeader10.TextAlign = HorizontalAlignment.Center;
            columnHeader10.Width = 120;
            // 
            // btnOgunSil
            // 
            btnOgunSil.BackColor = SystemColors.GradientInactiveCaption;
            btnOgunSil.FlatAppearance.BorderSize = 0;
            btnOgunSil.FlatStyle = FlatStyle.Flat;
            btnOgunSil.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnOgunSil.Image = (Image)resources.GetObject("btnOgunSil.Image");
            btnOgunSil.Location = new Point(226, 478);
            btnOgunSil.Name = "btnOgunSil";
            btnOgunSil.Size = new Size(311, 148);
            btnOgunSil.TabIndex = 9;
            btnOgunSil.Text = "ÖĞÜNÜ SİL";
            btnOgunSil.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOgunSil.UseVisualStyleBackColor = false;
            // 
            // btnGunSil
            // 
            btnGunSil.BackColor = SystemColors.GradientInactiveCaption;
            btnGunSil.FlatAppearance.BorderSize = 0;
            btnGunSil.FlatStyle = FlatStyle.Flat;
            btnGunSil.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGunSil.Image = (Image)resources.GetObject("btnGunSil.Image");
            btnGunSil.Location = new Point(651, 478);
            btnGunSil.Name = "btnGunSil";
            btnGunSil.Size = new Size(311, 148);
            btnGunSil.TabIndex = 10;
            btnGunSil.Text = "GÜNÜ SİL";
            btnGunSil.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGunSil.UseVisualStyleBackColor = false;
            // 
            // HistoryScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1129, 638);
            ControlBox = false;
            Controls.Add(btnGunSil);
            Controls.Add(btnOgunSil);
            Controls.Add(lvDays);
            Controls.Add(lvMeals);
            Name = "HistoryScreen";
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
        private ListView lvDays;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader10;
        private Button btnOgunSil;
        private Button btnGunSil;
    }
}