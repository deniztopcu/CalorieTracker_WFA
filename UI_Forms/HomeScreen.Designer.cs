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
            btnMainDishes = new Button();
            btnMultigrainCereals = new Button();
            btnSoups = new Button();
            btnGrainProducts = new Button();
            btnFastFood = new Button();
            btnMeatProducts = new Button();
            btnSeaProducts = new Button();
            btnMilkProducts = new Button();
            btnLegumes = new Button();
            btnDesserts = new Button();
            btnCookies = new Button();
            btnAlkol = new Button();
            btnSoftDrink = new Button();
            btnFruit = new Button();
            btnVegetables = new Button();
            toolTip1 = new ToolTip(components);
            lvYemekleriListele = new ListView();
            columnHeader5 = new ColumnHeader();
            label1 = new Label();
            cmbOgunler = new ComboBox();
            label2 = new Label();
            cmbPorsiyon = new ComboBox();
            label3 = new Label();
            nudGram = new NumericUpDown();
            btnOgunEkle = new Button();
            lvOgunListesi = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            btnOgunlerimiSil = new Button();
            btnOgunlerimiKaydet = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudGram).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaShell;
            panel1.Controls.Add(btnMainDishes);
            panel1.Controls.Add(btnMultigrainCereals);
            panel1.Controls.Add(btnSoups);
            panel1.Controls.Add(btnGrainProducts);
            panel1.Controls.Add(btnFastFood);
            panel1.Controls.Add(btnMeatProducts);
            panel1.Controls.Add(btnSeaProducts);
            panel1.Controls.Add(btnMilkProducts);
            panel1.Controls.Add(btnLegumes);
            panel1.Controls.Add(btnDesserts);
            panel1.Controls.Add(btnCookies);
            panel1.Controls.Add(btnAlkol);
            panel1.Controls.Add(btnSoftDrink);
            panel1.Controls.Add(btnFruit);
            panel1.Controls.Add(btnVegetables);
            panel1.Location = new Point(4, 4);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(838, 62);
            panel1.TabIndex = 0;
            // 
            // btnMainDishes
            // 
            btnMainDishes.FlatStyle = FlatStyle.Flat;
            btnMainDishes.Image = (Image)resources.GetObject("btnMainDishes.Image");
            btnMainDishes.Location = new Point(773, 14);
            btnMainDishes.Margin = new Padding(3, 2, 3, 2);
            btnMainDishes.Name = "btnMainDishes";
            btnMainDishes.Size = new Size(45, 38);
            btnMainDishes.TabIndex = 14;
            toolTip1.SetToolTip(btnMainDishes, "Ana Yemekler");
            btnMainDishes.UseVisualStyleBackColor = true;
            btnMainDishes.Click += btnMainDishes_Click;
            // 
            // btnMultigrainCereals
            // 
            btnMultigrainCereals.FlatStyle = FlatStyle.Flat;
            btnMultigrainCereals.Image = (Image)resources.GetObject("btnMultigrainCereals.Image");
            btnMultigrainCereals.Location = new Point(705, 14);
            btnMultigrainCereals.Margin = new Padding(3, 2, 3, 2);
            btnMultigrainCereals.Name = "btnMultigrainCereals";
            btnMultigrainCereals.Size = new Size(47, 38);
            btnMultigrainCereals.TabIndex = 13;
            toolTip1.SetToolTip(btnMultigrainCereals, "Tahıllı Gevrekler");
            btnMultigrainCereals.UseVisualStyleBackColor = true;
            btnMultigrainCereals.Click += btnMultigrainCereals_Click;
            // 
            // btnSoups
            // 
            btnSoups.FlatStyle = FlatStyle.Flat;
            btnSoups.Image = (Image)resources.GetObject("btnSoups.Image");
            btnSoups.Location = new Point(644, 14);
            btnSoups.Margin = new Padding(3, 2, 3, 2);
            btnSoups.Name = "btnSoups";
            btnSoups.Size = new Size(47, 38);
            btnSoups.TabIndex = 12;
            toolTip1.SetToolTip(btnSoups, "Çorbalar");
            btnSoups.UseVisualStyleBackColor = true;
            btnSoups.Click += btnSoups_Click;
            // 
            // btnGrainProducts
            // 
            btnGrainProducts.FlatStyle = FlatStyle.Flat;
            btnGrainProducts.Image = (Image)resources.GetObject("btnGrainProducts.Image");
            btnGrainProducts.Location = new Point(586, 14);
            btnGrainProducts.Margin = new Padding(3, 2, 3, 2);
            btnGrainProducts.Name = "btnGrainProducts";
            btnGrainProducts.Size = new Size(41, 38);
            btnGrainProducts.TabIndex = 11;
            toolTip1.SetToolTip(btnGrainProducts, "Ekmek ve Unlu Mamüller");
            btnGrainProducts.UseVisualStyleBackColor = true;
            btnGrainProducts.Click += btnGrainProducts_Click;
            // 
            // btnFastFood
            // 
            btnFastFood.FlatStyle = FlatStyle.Flat;
            btnFastFood.Image = (Image)resources.GetObject("btnFastFood.Image");
            btnFastFood.Location = new Point(474, 14);
            btnFastFood.Margin = new Padding(3, 2, 3, 2);
            btnFastFood.Name = "btnFastFood";
            btnFastFood.Size = new Size(54, 38);
            btnFastFood.TabIndex = 10;
            toolTip1.SetToolTip(btnFastFood, "Fast Food");
            btnFastFood.UseVisualStyleBackColor = true;
            btnFastFood.Click += btnFastFood_Click;
            // 
            // btnMeatProducts
            // 
            btnMeatProducts.FlatStyle = FlatStyle.Flat;
            btnMeatProducts.Image = (Image)resources.GetObject("btnMeatProducts.Image");
            btnMeatProducts.Location = new Point(534, 14);
            btnMeatProducts.Margin = new Padding(3, 2, 3, 2);
            btnMeatProducts.Name = "btnMeatProducts";
            btnMeatProducts.Size = new Size(47, 38);
            btnMeatProducts.TabIndex = 9;
            toolTip1.SetToolTip(btnMeatProducts, "Et Ürünleri");
            btnMeatProducts.UseVisualStyleBackColor = true;
            btnMeatProducts.Click += btnMeatProducts_Click;
            // 
            // btnSeaProducts
            // 
            btnSeaProducts.FlatStyle = FlatStyle.Flat;
            btnSeaProducts.Image = (Image)resources.GetObject("btnSeaProducts.Image");
            btnSeaProducts.Location = new Point(423, 14);
            btnSeaProducts.Margin = new Padding(3, 2, 3, 2);
            btnSeaProducts.Name = "btnSeaProducts";
            btnSeaProducts.Size = new Size(46, 38);
            btnSeaProducts.TabIndex = 8;
            toolTip1.SetToolTip(btnSeaProducts, "Deniz Ürünleri");
            btnSeaProducts.UseVisualStyleBackColor = true;
            btnSeaProducts.Click += btnSeaProducts_Click;
            // 
            // btnMilkProducts
            // 
            btnMilkProducts.FlatStyle = FlatStyle.Flat;
            btnMilkProducts.Image = (Image)resources.GetObject("btnMilkProducts.Image");
            btnMilkProducts.Location = new Point(377, 14);
            btnMilkProducts.Margin = new Padding(3, 2, 3, 2);
            btnMilkProducts.Name = "btnMilkProducts";
            btnMilkProducts.Size = new Size(40, 38);
            btnMilkProducts.TabIndex = 7;
            toolTip1.SetToolTip(btnMilkProducts, "Süt ve Süt Ürünleri");
            btnMilkProducts.UseVisualStyleBackColor = true;
            btnMilkProducts.Click += btnMilkProducts_Click;
            // 
            // btnLegumes
            // 
            btnLegumes.FlatStyle = FlatStyle.Flat;
            btnLegumes.Image = (Image)resources.GetObject("btnLegumes.Image");
            btnLegumes.Location = new Point(326, 14);
            btnLegumes.Margin = new Padding(3, 2, 3, 2);
            btnLegumes.Name = "btnLegumes";
            btnLegumes.Size = new Size(46, 38);
            btnLegumes.TabIndex = 6;
            toolTip1.SetToolTip(btnLegumes, "Baklagiller");
            btnLegumes.UseVisualStyleBackColor = true;
            btnLegumes.Click += btnLegumes_Click;
            // 
            // btnDesserts
            // 
            btnDesserts.FlatStyle = FlatStyle.Flat;
            btnDesserts.Image = (Image)resources.GetObject("btnDesserts.Image");
            btnDesserts.Location = new Point(273, 14);
            btnDesserts.Margin = new Padding(3, 2, 3, 2);
            btnDesserts.Name = "btnDesserts";
            btnDesserts.Size = new Size(47, 38);
            btnDesserts.TabIndex = 5;
            toolTip1.SetToolTip(btnDesserts, "Tatlılar");
            btnDesserts.UseVisualStyleBackColor = true;
            btnDesserts.Click += btnDesserts_Click;
            // 
            // btnCookies
            // 
            btnCookies.FlatStyle = FlatStyle.Flat;
            btnCookies.Image = (Image)resources.GetObject("btnCookies.Image");
            btnCookies.Location = new Point(222, 14);
            btnCookies.Margin = new Padding(3, 2, 3, 2);
            btnCookies.Name = "btnCookies";
            btnCookies.Size = new Size(38, 38);
            btnCookies.TabIndex = 4;
            toolTip1.SetToolTip(btnCookies, "Çerezler");
            btnCookies.UseVisualStyleBackColor = true;
            btnCookies.Click += btnCookies_Click;
            // 
            // btnAlkol
            // 
            btnAlkol.FlatStyle = FlatStyle.Flat;
            btnAlkol.Image = (Image)resources.GetObject("btnAlkol.Image");
            btnAlkol.Location = new Point(171, 14);
            btnAlkol.Margin = new Padding(3, 2, 3, 2);
            btnAlkol.Name = "btnAlkol";
            btnAlkol.Size = new Size(38, 38);
            btnAlkol.TabIndex = 3;
            toolTip1.SetToolTip(btnAlkol, "Alkollü İçecekler");
            btnAlkol.UseVisualStyleBackColor = true;
            btnAlkol.Click += btnAlkol_Click;
            // 
            // btnSoftDrink
            // 
            btnSoftDrink.FlatStyle = FlatStyle.Flat;
            btnSoftDrink.Image = (Image)resources.GetObject("btnSoftDrink.Image");
            btnSoftDrink.Location = new Point(116, 14);
            btnSoftDrink.Margin = new Padding(3, 2, 3, 2);
            btnSoftDrink.Name = "btnSoftDrink";
            btnSoftDrink.Size = new Size(42, 38);
            btnSoftDrink.TabIndex = 2;
            toolTip1.SetToolTip(btnSoftDrink, "Alkolsüz İçecekler");
            btnSoftDrink.UseVisualStyleBackColor = true;
            btnSoftDrink.Click += btnSoftDrink_Click;
            // 
            // btnFruit
            // 
            btnFruit.FlatStyle = FlatStyle.Flat;
            btnFruit.Image = (Image)resources.GetObject("btnFruit.Image");
            btnFruit.Location = new Point(62, 14);
            btnFruit.Margin = new Padding(3, 2, 3, 2);
            btnFruit.Name = "btnFruit";
            btnFruit.Size = new Size(40, 38);
            btnFruit.TabIndex = 1;
            toolTip1.SetToolTip(btnFruit, "Meyve");
            btnFruit.UseVisualStyleBackColor = true;
            btnFruit.Click += btnFruit_Click;
            // 
            // btnVegetables
            // 
            btnVegetables.FlatStyle = FlatStyle.Flat;
            btnVegetables.Image = (Image)resources.GetObject("btnVegetables.Image");
            btnVegetables.Location = new Point(7, 14);
            btnVegetables.Margin = new Padding(3, 2, 3, 2);
            btnVegetables.Name = "btnVegetables";
            btnVegetables.Size = new Size(35, 38);
            btnVegetables.TabIndex = 0;
            toolTip1.SetToolTip(btnVegetables, "Sebze");
            btnVegetables.UseVisualStyleBackColor = true;
            btnVegetables.Click += btnVegetables_Click;
            // 
            // lvYemekleriListele
            // 
            lvYemekleriListele.BackColor = SystemColors.InactiveCaption;
            lvYemekleriListele.Columns.AddRange(new ColumnHeader[] { columnHeader5 });
            lvYemekleriListele.FullRowSelect = true;
            lvYemekleriListele.GridLines = true;
            lvYemekleriListele.Location = new Point(10, 82);
            lvYemekleriListele.Margin = new Padding(3, 2, 3, 2);
            lvYemekleriListele.Name = "lvYemekleriListele";
            lvYemekleriListele.Size = new Size(253, 299);
            lvYemekleriListele.TabIndex = 1;
            lvYemekleriListele.UseCompatibleStateImageBehavior = false;
            lvYemekleriListele.View = View.Details;
            lvYemekleriListele.SelectedIndexChanged += lvYemekleriListele_SelectedIndexChanged;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Yemekler";
            columnHeader5.Width = 300;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(315, 124);
            label1.Name = "label1";
            label1.Size = new Size(84, 19);
            label1.TabIndex = 2;
            label1.Text = "Öğünler : ";
            // 
            // cmbOgunler
            // 
            cmbOgunler.FormattingEnabled = true;
            cmbOgunler.Location = new Point(413, 121);
            cmbOgunler.Margin = new Padding(3, 2, 3, 2);
            cmbOgunler.Name = "cmbOgunler";
            cmbOgunler.Size = new Size(133, 23);
            cmbOgunler.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(315, 178);
            label2.Name = "label2";
            label2.Size = new Size(84, 19);
            label2.TabIndex = 4;
            label2.Text = "Porsiyon : ";
            // 
            // cmbPorsiyon
            // 
            cmbPorsiyon.FormattingEnabled = true;
            cmbPorsiyon.Location = new Point(413, 178);
            cmbPorsiyon.Margin = new Padding(3, 2, 3, 2);
            cmbPorsiyon.Name = "cmbPorsiyon";
            cmbPorsiyon.Size = new Size(133, 23);
            cmbPorsiyon.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(304, 236);
            label3.Name = "label3";
            label3.Size = new Size(94, 19);
            label3.TabIndex = 6;
            label3.Text = "Ölçü-Adet:";
            // 
            // nudGram
            // 
            nudGram.Location = new Point(414, 233);
            nudGram.Margin = new Padding(3, 2, 3, 2);
            nudGram.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudGram.Name = "nudGram";
            nudGram.Size = new Size(131, 23);
            nudGram.TabIndex = 7;
            // 
            // btnOgunEkle
            // 
            btnOgunEkle.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnOgunEkle.Image = (Image)resources.GetObject("btnOgunEkle.Image");
            btnOgunEkle.ImageAlign = ContentAlignment.TopLeft;
            btnOgunEkle.Location = new Point(331, 285);
            btnOgunEkle.Margin = new Padding(3, 2, 3, 2);
            btnOgunEkle.Name = "btnOgunEkle";
            btnOgunEkle.Size = new Size(204, 61);
            btnOgunEkle.TabIndex = 8;
            btnOgunEkle.Text = "Öğünümü Ekle";
            btnOgunEkle.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOgunEkle.UseVisualStyleBackColor = true;
            btnOgunEkle.Click += btnOgunEkle_Click;
            // 
            // lvOgunListesi
            // 
            lvOgunListesi.BackColor = SystemColors.InactiveCaption;
            lvOgunListesi.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lvOgunListesi.FullRowSelect = true;
            lvOgunListesi.GridLines = true;
            lvOgunListesi.Location = new Point(550, 82);
            lvOgunListesi.Margin = new Padding(3, 2, 3, 2);
            lvOgunListesi.Name = "lvOgunListesi";
            lvOgunListesi.Size = new Size(434, 299);
            lvOgunListesi.TabIndex = 9;
            lvOgunListesi.UseCompatibleStateImageBehavior = false;
            lvOgunListesi.View = View.Details;
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
            // btnOgunlerimiSil
            // 
            btnOgunlerimiSil.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnOgunlerimiSil.Location = new Point(703, 392);
            btnOgunlerimiSil.Margin = new Padding(3, 2, 3, 2);
            btnOgunlerimiSil.Name = "btnOgunlerimiSil";
            btnOgunlerimiSil.Size = new Size(139, 30);
            btnOgunlerimiSil.TabIndex = 11;
            btnOgunlerimiSil.Text = "Öğünümü Sil";
            btnOgunlerimiSil.UseVisualStyleBackColor = true;
            btnOgunlerimiSil.Click += btnOgunlerimiSil_Click;
            // 
            // btnOgunlerimiKaydet
            // 
            btnOgunlerimiKaydet.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnOgunlerimiKaydet.Location = new Point(550, 392);
            btnOgunlerimiKaydet.Margin = new Padding(3, 2, 3, 2);
            btnOgunlerimiKaydet.Name = "btnOgunlerimiKaydet";
            btnOgunlerimiKaydet.Size = new Size(140, 30);
            btnOgunlerimiKaydet.TabIndex = 12;
            btnOgunlerimiKaydet.Text = "Öğünlerimi Kaydet";
            btnOgunlerimiKaydet.UseVisualStyleBackColor = true;
            btnOgunlerimiKaydet.Click += btnOgunlerimiKaydet_Click;
            // 
            // HomeScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1034, 491);
            ControlBox = false;
            Controls.Add(btnOgunlerimiKaydet);
            Controls.Add(btnOgunlerimiSil);
            Controls.Add(lvOgunListesi);
            Controls.Add(btnOgunEkle);
            Controls.Add(nudGram);
            Controls.Add(label3);
            Controls.Add(cmbPorsiyon);
            Controls.Add(label2);
            Controls.Add(cmbOgunler);
            Controls.Add(label1);
            Controls.Add(lvYemekleriListele);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "HomeScreen";
            Load += HomeScreen_Load;
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
        private Button btnCookies;
        private Button btnDesserts;
        private Button btnLegumes;
        private Button btnMilkProducts;
        private Button btnSeaProducts;
        private Button btnMeatProducts;
        private Button btnFastFood;
        private Button btnGrainProducts;
        private Button btnSoups;
        private ListView lvYemekleriListele;
        private Label label1;
        private ComboBox cmbOgunler;
        private Label label2;
        private ComboBox cmbPorsiyon;
        private Label label3;
        private NumericUpDown nudGram;
        private Button btnOgunEkle;
        private ListView lvOgunListesi;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Button btnMultigrainCereals;
        private Button btnMainDishes;
        private Button btnOgunlerimiSil;
        private Button btnOgunlerimiKaydet;
    }
}