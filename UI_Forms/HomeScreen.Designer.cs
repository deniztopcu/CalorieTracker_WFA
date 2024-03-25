namespace UI_Forms
{
    partial class HomeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeScreen));
            panel1 = new Panel();
            btnDiger = new Button();
            btnTahilUrunleri = new Button();
            btnFastFood = new Button();
            btnEtUrunleri = new Button();
            btnDenizUrunleri = new Button();
            btnSutUrunleri = new Button();
            btnSalata = new Button();
            btnTatli = new Button();
            btnAtistirmalik = new Button();
            btnAlkol = new Button();
            btnSoftDrink = new Button();
            btnFruit = new Button();
            btnVegetables = new Button();
            toolTip1 = new ToolTip(components);
            lvOgunleriListele = new ListView();
            label1 = new Label();
            cmbOgunler = new ComboBox();
            label2 = new Label();
            cmbPorsiyon = new ComboBox();
            label3 = new Label();
            nudGram = new NumericUpDown();
            btnOgunEkle = new Button();
            listView2 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            btnOgunKaydet = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudGram).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaShell;
            panel1.Controls.Add(btnDiger);
            panel1.Controls.Add(btnTahilUrunleri);
            panel1.Controls.Add(btnFastFood);
            panel1.Controls.Add(btnEtUrunleri);
            panel1.Controls.Add(btnDenizUrunleri);
            panel1.Controls.Add(btnSutUrunleri);
            panel1.Controls.Add(btnSalata);
            panel1.Controls.Add(btnTatli);
            panel1.Controls.Add(btnAtistirmalik);
            panel1.Controls.Add(btnAlkol);
            panel1.Controls.Add(btnSoftDrink);
            panel1.Controls.Add(btnFruit);
            panel1.Controls.Add(btnVegetables);
            panel1.Location = new Point(4, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(958, 83);
            panel1.TabIndex = 0;
            // 
            // btnDiger
            // 
            btnDiger.FlatStyle = FlatStyle.Flat;
            btnDiger.Image = (Image)resources.GetObject("btnDiger.Image");
            btnDiger.Location = new Point(838, 18);
            btnDiger.Name = "btnDiger";
            btnDiger.Size = new Size(94, 50);
            btnDiger.TabIndex = 12;
            toolTip1.SetToolTip(btnDiger, "Diğer");
            btnDiger.UseVisualStyleBackColor = true;
            // 
            // btnTahilUrunleri
            // 
            btnTahilUrunleri.FlatStyle = FlatStyle.Flat;
            btnTahilUrunleri.Image = (Image)resources.GetObject("btnTahilUrunleri.Image");
            btnTahilUrunleri.Location = new Point(764, 18);
            btnTahilUrunleri.Name = "btnTahilUrunleri";
            btnTahilUrunleri.Size = new Size(68, 50);
            btnTahilUrunleri.TabIndex = 11;
            toolTip1.SetToolTip(btnTahilUrunleri, "Tahıl Ürünleri");
            btnTahilUrunleri.UseVisualStyleBackColor = true;
            // 
            // btnFastFood
            // 
            btnFastFood.FlatStyle = FlatStyle.Flat;
            btnFastFood.Image = (Image)resources.GetObject("btnFastFood.Image");
            btnFastFood.Location = new Point(611, 18);
            btnFastFood.Name = "btnFastFood";
            btnFastFood.Size = new Size(71, 50);
            btnFastFood.TabIndex = 10;
            toolTip1.SetToolTip(btnFastFood, "Fast Food");
            btnFastFood.UseVisualStyleBackColor = true;
            // 
            // btnEtUrunleri
            // 
            btnEtUrunleri.FlatStyle = FlatStyle.Flat;
            btnEtUrunleri.Image = (Image)resources.GetObject("btnEtUrunleri.Image");
            btnEtUrunleri.Location = new Point(688, 18);
            btnEtUrunleri.Name = "btnEtUrunleri";
            btnEtUrunleri.Size = new Size(60, 50);
            btnEtUrunleri.TabIndex = 9;
            toolTip1.SetToolTip(btnEtUrunleri, "Et Ürünleri");
            btnEtUrunleri.UseVisualStyleBackColor = true;
            // 
            // btnDenizUrunleri
            // 
            btnDenizUrunleri.FlatStyle = FlatStyle.Flat;
            btnDenizUrunleri.Image = (Image)resources.GetObject("btnDenizUrunleri.Image");
            btnDenizUrunleri.Location = new Point(535, 18);
            btnDenizUrunleri.Name = "btnDenizUrunleri";
            btnDenizUrunleri.Size = new Size(58, 50);
            btnDenizUrunleri.TabIndex = 8;
            toolTip1.SetToolTip(btnDenizUrunleri, "Deniz Ürünleri");
            btnDenizUrunleri.UseVisualStyleBackColor = true;
            // 
            // btnSutUrunleri
            // 
            btnSutUrunleri.FlatStyle = FlatStyle.Flat;
            btnSutUrunleri.Image = (Image)resources.GetObject("btnSutUrunleri.Image");
            btnSutUrunleri.Location = new Point(457, 18);
            btnSutUrunleri.Name = "btnSutUrunleri";
            btnSutUrunleri.Size = new Size(72, 50);
            btnSutUrunleri.TabIndex = 7;
            toolTip1.SetToolTip(btnSutUrunleri, "Süt ve Süt Ürünleri");
            btnSutUrunleri.UseVisualStyleBackColor = true;
            // 
            // btnSalata
            // 
            btnSalata.FlatStyle = FlatStyle.Flat;
            btnSalata.Image = (Image)resources.GetObject("btnSalata.Image");
            btnSalata.Location = new Point(374, 18);
            btnSalata.Name = "btnSalata";
            btnSalata.Size = new Size(65, 50);
            btnSalata.TabIndex = 6;
            toolTip1.SetToolTip(btnSalata, "Salata");
            btnSalata.UseVisualStyleBackColor = true;
            // 
            // btnTatli
            // 
            btnTatli.FlatStyle = FlatStyle.Flat;
            btnTatli.Image = (Image)resources.GetObject("btnTatli.Image");
            btnTatli.Location = new Point(305, 18);
            btnTatli.Name = "btnTatli";
            btnTatli.Size = new Size(63, 50);
            btnTatli.TabIndex = 5;
            toolTip1.SetToolTip(btnTatli, "Tatlı");
            btnTatli.UseVisualStyleBackColor = true;
            // 
            // btnAtistirmalik
            // 
            btnAtistirmalik.FlatStyle = FlatStyle.Flat;
            btnAtistirmalik.Image = (Image)resources.GetObject("btnAtistirmalik.Image");
            btnAtistirmalik.Location = new Point(249, 18);
            btnAtistirmalik.Name = "btnAtistirmalik";
            btnAtistirmalik.Size = new Size(48, 50);
            btnAtistirmalik.TabIndex = 4;
            toolTip1.SetToolTip(btnAtistirmalik, "Atıştırmalık");
            btnAtistirmalik.UseVisualStyleBackColor = true;
            // 
            // btnAlkol
            // 
            btnAlkol.FlatStyle = FlatStyle.Flat;
            btnAlkol.Image = (Image)resources.GetObject("btnAlkol.Image");
            btnAlkol.Location = new Point(195, 18);
            btnAlkol.Name = "btnAlkol";
            btnAlkol.Size = new Size(48, 50);
            btnAlkol.TabIndex = 3;
            toolTip1.SetToolTip(btnAlkol, "Alkol");
            btnAlkol.UseVisualStyleBackColor = true;
            // 
            // btnSoftDrink
            // 
            btnSoftDrink.FlatStyle = FlatStyle.Flat;
            btnSoftDrink.Image = (Image)resources.GetObject("btnSoftDrink.Image");
            btnSoftDrink.Location = new Point(131, 18);
            btnSoftDrink.Name = "btnSoftDrink";
            btnSoftDrink.Size = new Size(58, 50);
            btnSoftDrink.TabIndex = 2;
            toolTip1.SetToolTip(btnSoftDrink, "Meşrubat");
            btnSoftDrink.UseVisualStyleBackColor = true;
            // 
            // btnFruit
            // 
            btnFruit.FlatStyle = FlatStyle.Flat;
            btnFruit.Image = (Image)resources.GetObject("btnFruit.Image");
            btnFruit.Location = new Point(69, 18);
            btnFruit.Name = "btnFruit";
            btnFruit.Size = new Size(56, 50);
            btnFruit.TabIndex = 1;
            toolTip1.SetToolTip(btnFruit, "Meyve");
            btnFruit.UseVisualStyleBackColor = true;
            // 
            // btnVegetables
            // 
            btnVegetables.FlatStyle = FlatStyle.Flat;
            btnVegetables.Image = (Image)resources.GetObject("btnVegetables.Image");
            btnVegetables.Location = new Point(8, 18);
            btnVegetables.Name = "btnVegetables";
            btnVegetables.Size = new Size(55, 50);
            btnVegetables.TabIndex = 0;
            toolTip1.SetToolTip(btnVegetables, "Sebze");
            btnVegetables.UseVisualStyleBackColor = true;
          //  btnVegetables.MouseClick += btnVegetables_MouseClick;
            // 
            // lvOgunleriListele
            // 
            lvOgunleriListele.BackColor = SystemColors.InactiveCaption;
            lvOgunleriListele.FullRowSelect = true;
            lvOgunleriListele.GridLines = true;
            lvOgunleriListele.Location = new Point(12, 109);
            lvOgunleriListele.Name = "lvOgunleriListele";
            lvOgunleriListele.Size = new Size(342, 397);
            lvOgunleriListele.TabIndex = 1;
            lvOgunleriListele.UseCompatibleStateImageBehavior = false;
            lvOgunleriListele.View = View.Details;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(360, 166);
            label1.Name = "label1";
            label1.Size = new Size(106, 23);
            label1.TabIndex = 2;
            label1.Text = "Öğünler : ";
            // 
            // cmbOgunler
            // 
            cmbOgunler.FormattingEnabled = true;
            cmbOgunler.Location = new Point(472, 161);
            cmbOgunler.Name = "cmbOgunler";
            cmbOgunler.Size = new Size(151, 28);
            cmbOgunler.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(360, 238);
            label2.Name = "label2";
            label2.Size = new Size(109, 23);
            label2.TabIndex = 4;
            label2.Text = "Porsiyon : ";
            // 
            // cmbPorsiyon
            // 
            cmbPorsiyon.FormattingEnabled = true;
            cmbPorsiyon.Location = new Point(472, 238);
            cmbPorsiyon.Name = "cmbPorsiyon";
            cmbPorsiyon.Size = new Size(151, 28);
            cmbPorsiyon.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(360, 296);
            label3.Name = "label3";
            label3.Size = new Size(83, 23);
            label3.TabIndex = 6;
            label3.Text = "Gram : ";
            // 
            // nudGram
            // 
            nudGram.Location = new Point(472, 297);
            nudGram.Name = "nudGram";
            nudGram.Size = new Size(150, 27);
            nudGram.TabIndex = 7;
            // 
            // btnOgunEkle
            // 
            btnOgunEkle.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnOgunEkle.Image = (Image)resources.GetObject("btnOgunEkle.Image");
            btnOgunEkle.ImageAlign = ContentAlignment.TopLeft;
            btnOgunEkle.Location = new Point(378, 377);
            btnOgunEkle.Name = "btnOgunEkle";
            btnOgunEkle.Size = new Size(233, 57);
            btnOgunEkle.TabIndex = 8;
            btnOgunEkle.Text = "Öğünümü Ekle";
            btnOgunEkle.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOgunEkle.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            listView2.BackColor = SystemColors.InactiveCaption;
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listView2.FullRowSelect = true;
            listView2.GridLines = true;
            listView2.Location = new Point(629, 109);
            listView2.Name = "listView2";
            listView2.Size = new Size(333, 397);
            listView2.TabIndex = 9;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Yemek Adı";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Porsiyon";
            columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Kalori";
            columnHeader3.Width = 70;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Öğün";
            columnHeader4.Width = 70;
            // 
            // btnOgunKaydet
            // 
            btnOgunKaydet.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnOgunKaydet.Location = new Point(705, 530);
            btnOgunKaydet.Name = "btnOgunKaydet";
            btnOgunKaydet.Size = new Size(201, 40);
            btnOgunKaydet.TabIndex = 10;
            btnOgunKaydet.Text = "Öğünlerimi Kaydet";
            btnOgunKaydet.UseVisualStyleBackColor = true;
            // 
            // HomeScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(974, 604);
            ControlBox = false;
            Controls.Add(btnOgunKaydet);
            Controls.Add(listView2);
            Controls.Add(btnOgunEkle);
            Controls.Add(nudGram);
            Controls.Add(label3);
            Controls.Add(cmbPorsiyon);
            Controls.Add(label2);
            Controls.Add(cmbOgunler);
            Controls.Add(label1);
            Controls.Add(lvOgunleriListele);
            Controls.Add(panel1);
            Name = "HomeScreen";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudGram).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnVegetables;
        private ToolTip toolTip1;
        private Button btnFruit;
        private Button btnSoftDrink;
        private Button btnAlkol;
        private Button btnAtistirmalik;
        private Button btnTatli;
        private Button btnSalata;
        private Button btnSutUrunleri;
        private Button btnDenizUrunleri;
        private Button btnEtUrunleri;
        private Button btnFastFood;
        private Button btnTahilUrunleri;
        private Button btnDiger;
        private ListView lvOgunleriListele;
        private Label label1;
        private ComboBox cmbOgunler;
        private Label label2;
        private ComboBox cmbPorsiyon;
        private Label label3;
        private NumericUpDown nudGram;
        private Button btnOgunEkle;
        private ListView listView2;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button btnOgunKaydet;
    }
}