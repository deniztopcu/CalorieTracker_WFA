namespace UI_Forms
{
    partial class AnalizScreen
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
            lwHaftalikAylikDurum = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            lwOgunlereGoreKarsilastir = new ListView();
            columnHeader6 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            columnHeader13 = new ColumnHeader();
            rbAylik = new RadioButton();
            rbHaftalik = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lwYenilenOgunler = new ListView();
            ID = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            SuspendLayout();
            // 
            // lwHaftalikAylikDurum
            // 
            lwHaftalikAylikDurum.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            lwHaftalikAylikDurum.FullRowSelect = true;
            lwHaftalikAylikDurum.GridLines = true;
            lwHaftalikAylikDurum.Location = new Point(66, 125);
            lwHaftalikAylikDurum.Name = "lwHaftalikAylikDurum";
            lwHaftalikAylikDurum.Size = new Size(547, 239);
            lwHaftalikAylikDurum.TabIndex = 0;
            lwHaftalikAylikDurum.UseCompatibleStateImageBehavior = false;
            lwHaftalikAylikDurum.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "İsim";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Toplam Tüketim";
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Kullanıcı Tüketimi";
            columnHeader3.Width = 130;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Toplam Kalori";
            columnHeader4.Width = 110;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Kullanıcı Kalorisi";
            columnHeader5.Width = 120;
            // 
            // lwOgunlereGoreKarsilastir
            // 
            lwOgunlereGoreKarsilastir.Columns.AddRange(new ColumnHeader[] { columnHeader6, columnHeader10, columnHeader11, columnHeader12, columnHeader13 });
            lwOgunlereGoreKarsilastir.FullRowSelect = true;
            lwOgunlereGoreKarsilastir.GridLines = true;
            lwOgunlereGoreKarsilastir.Location = new Point(66, 437);
            lwOgunlereGoreKarsilastir.Name = "lwOgunlereGoreKarsilastir";
            lwOgunlereGoreKarsilastir.Size = new Size(547, 210);
            lwOgunlereGoreKarsilastir.TabIndex = 1;
            lwOgunlereGoreKarsilastir.UseCompatibleStateImageBehavior = false;
            lwOgunlereGoreKarsilastir.View = View.Details;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "ÖĞÜN";
            columnHeader6.Width = 100;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "TOPLAM TÜKETİM";
            columnHeader10.TextAlign = HorizontalAlignment.Center;
            columnHeader10.Width = 100;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "KULLANICI TÜKETİM";
            columnHeader11.TextAlign = HorizontalAlignment.Center;
            columnHeader11.Width = 100;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "TOPLAM KALORİ";
            columnHeader12.TextAlign = HorizontalAlignment.Center;
            columnHeader12.Width = 100;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "KULLANICI KALORİ";
            columnHeader13.TextAlign = HorizontalAlignment.Center;
            columnHeader13.Width = 100;
            // 
            // rbAylik
            // 
            rbAylik.AutoSize = true;
            rbAylik.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            rbAylik.Location = new Point(165, 83);
            rbAylik.Name = "rbAylik";
            rbAylik.Size = new Size(65, 24);
            rbAylik.TabIndex = 2;
            rbAylik.Text = "Aylık";
            rbAylik.UseVisualStyleBackColor = true;
            rbAylik.CheckedChanged += rbAylik_CheckedChanged;
            // 
            // rbHaftalik
            // 
            rbHaftalik.AutoSize = true;
            rbHaftalik.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            rbHaftalik.Location = new Point(67, 83);
            rbHaftalik.Name = "rbHaftalik";
            rbHaftalik.Size = new Size(85, 24);
            rbHaftalik.TabIndex = 3;
            rbHaftalik.Text = "Haftalık";
            rbHaftalik.UseVisualStyleBackColor = true;
            rbHaftalik.CheckedChanged += rbHaftalik_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(66, 27);
            label1.Name = "label1";
            label1.Size = new Size(184, 46);
            label1.TabIndex = 4;
            label1.Text = "Durumum";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(66, 394);
            label2.Name = "label2";
            label2.Size = new Size(185, 20);
            label2.TabIndex = 5;
            label2.Text = "Öğünlere Göre Karşılaştır";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(683, 60);
            label3.Name = "label3";
            label3.Size = new Size(199, 20);
            label3.TabIndex = 6;
            label3.Text = "Yediğiniz Öğünler Nelerdir?";
            // 
            // lwYenilenOgunler
            // 
            lwYenilenOgunler.Columns.AddRange(new ColumnHeader[] { ID, columnHeader7, columnHeader8, columnHeader9 });
            lwYenilenOgunler.FullRowSelect = true;
            lwYenilenOgunler.GridLines = true;
            lwYenilenOgunler.Location = new Point(683, 83);
            lwYenilenOgunler.Name = "lwYenilenOgunler";
            lwYenilenOgunler.Size = new Size(450, 564);
            lwYenilenOgunler.TabIndex = 7;
            lwYenilenOgunler.UseCompatibleStateImageBehavior = false;
            lwYenilenOgunler.View = View.Details;
            // 
            // ID
            // 
            ID.Text = "ID";
            ID.Width = 100;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "İSİM";
            columnHeader7.TextAlign = HorizontalAlignment.Center;
            columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "ADET";
            columnHeader8.TextAlign = HorizontalAlignment.Center;
            columnHeader8.Width = 100;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "KALORİ";
            columnHeader9.TextAlign = HorizontalAlignment.Center;
            columnHeader9.Width = 100;
            // 
            // AnalizScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 717);
            ControlBox = false;
            Controls.Add(lwYenilenOgunler);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rbHaftalik);
            Controls.Add(rbAylik);
            Controls.Add(lwOgunlereGoreKarsilastir);
            Controls.Add(lwHaftalikAylikDurum);
            Font = new Font("Segoe UI", 9F);
            ForeColor = SystemColors.ControlText;
            Name = "AnalizScreen";
            Load += AnalizScreen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lwHaftalikAylikDurum;
        private ListView lwOgunlereGoreKarsilastir;
        private RadioButton rbAylik;
        private RadioButton rbHaftalik;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListView lwYenilenOgunler;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader ID;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
    }
}