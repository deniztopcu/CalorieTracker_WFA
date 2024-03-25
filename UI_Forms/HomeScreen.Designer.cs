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
            btnOgunKaydet = new Button();
            btnOgunlerimiSil = new Button();
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
            panel1.Location = new Point(4, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(958, 83);
            panel1.TabIndex = 0;
            // 
            // btnMainDishes
            // 
            btnMainDishes.FlatStyle = FlatStyle.Flat;
            btnMainDishes.Image = (Image)resources.GetObject("btnMainDishes.Image");
            btnMainDishes.Location = new Point(883, 18);
            btnMainDishes.Name = "btnMainDishes";
            btnMainDishes.Size = new Size(51, 50);
            btnMainDishes.TabIndex = 14;
            toolTip1.SetToolTip(btnMainDishes, "Ana Yemekler");
            btnMainDishes.UseVisualStyleBackColor = true;
            btnMainDishes.Click += btnMainDishes_Click;
            // 
            // btnMultigrainCereals
            // 
            btnMultigrainCereals.FlatStyle = FlatStyle.Flat;
            btnMultigrainCereals.Image = (Image)resources.GetObject("btnMultigrainCereals.Image");
            btnMultigrainCereals.Location = new Point(806, 18);
            btnMultigrainCereals.Name = "btnMultigrainCereals";
            btnMultigrainCereals.Size = new Size(54, 50);
            btnMultigrainCereals.TabIndex = 13;
            toolTip1.SetToolTip(btnMultigrainCereals, "Tahıllı Gevrekler");
            btnMultigrainCereals.UseVisualStyleBackColor = true;
            btnMultigrainCereals.Click += btnMultigrainCereals_Click;
            // 
            // btnSoups
            // 
            btnSoups.FlatStyle = FlatStyle.Flat;
            btnSoups.Image = (Image)resources.GetObject("btnSoups.Image");
            btnSoups.Location = new Point(736, 18);
            btnSoups.Name = "btnSoups";
            btnSoups.Size = new Size(54, 50);
            btnSoups.TabIndex = 12;
            toolTip1.SetToolTip(btnSoups, "Çorbalar");
            btnSoups.UseVisualStyleBackColor = true;
            btnSoups.Click += btnSoups_Click;
            // 
            // btnGrainProducts
            // 
            btnGrainProducts.FlatStyle = FlatStyle.Flat;
            btnGrainProducts.Image = (Image)resources.GetObject("btnGrainProducts.Image");
            btnGrainProducts.Location = new Point(670, 18);
            btnGrainProducts.Name = "btnGrainProducts";
            btnGrainProducts.Size = new Size(47, 50);
            btnGrainProducts.TabIndex = 11;
            toolTip1.SetToolTip(btnGrainProducts, "Ekmek ve Unlu Mamüller");
            btnGrainProducts.UseVisualStyleBackColor = true;
            btnGrainProducts.Click += btnGrainProducts_Click;
            // 
            // btnFastFood
            // 
            btnFastFood.FlatStyle = FlatStyle.Flat;
            btnFastFood.Image = (Image)resources.GetObject("btnFastFood.Image");
            btnFastFood.Location = new Point(542, 18);
            btnFastFood.Name = "btnFastFood";
            btnFastFood.Size = new Size(62, 50);
            btnFastFood.TabIndex = 10;
            toolTip1.SetToolTip(btnFastFood, "Fast Food");
            btnFastFood.UseVisualStyleBackColor = true;
            btnFastFood.Click += btnFastFood_Click;
            // 
            // btnMeatProducts
            // 
            btnMeatProducts.FlatStyle = FlatStyle.Flat;
            btnMeatProducts.Image = (Image)resources.GetObject("btnMeatProducts.Image");
            btnMeatProducts.Location = new Point(610, 18);
            btnMeatProducts.Name = "btnMeatProducts";
            btnMeatProducts.Size = new Size(54, 50);
            btnMeatProducts.TabIndex = 9;
            toolTip1.SetToolTip(btnMeatProducts, "Et Ürünleri");
            btnMeatProducts.UseVisualStyleBackColor = true;
            btnMeatProducts.Click += btnMeatProducts_Click;
            // 
            // btnSeaProducts
            // 
            btnSeaProducts.FlatStyle = FlatStyle.Flat;
            btnSeaProducts.Image = (Image)resources.GetObject("btnSeaProducts.Image");
            btnSeaProducts.Location = new Point(483, 18);
            btnSeaProducts.Name = "btnSeaProducts";
            btnSeaProducts.Size = new Size(53, 50);
            btnSeaProducts.TabIndex = 8;
            toolTip1.SetToolTip(btnSeaProducts, "Deniz Ürünleri");
            btnSeaProducts.UseVisualStyleBackColor = true;
            btnSeaProducts.Click += btnSeaProducts_Click;
            // 
            // btnMilkProducts
            // 
            btnMilkProducts.FlatStyle = FlatStyle.Flat;
            btnMilkProducts.Image = (Image)resources.GetObject("btnMilkProducts.Image");
            btnMilkProducts.Location = new Point(431, 18);
            btnMilkProducts.Name = "btnMilkProducts";
            btnMilkProducts.Size = new Size(46, 50);
            btnMilkProducts.TabIndex = 7;
            toolTip1.SetToolTip(btnMilkProducts, "Süt ve Süt Ürünleri");
            btnMilkProducts.UseVisualStyleBackColor = true;
            btnMilkProducts.Click += btnMilkProducts_Click;
            // 
            // btnLegumes
            // 
            btnLegumes.FlatStyle = FlatStyle.Flat;
            btnLegumes.Image = (Image)resources.GetObject("btnLegumes.Image");
            btnLegumes.Location = new Point(372, 18);
            btnLegumes.Name = "btnLegumes";
            btnLegumes.Size = new Size(53, 50);
            btnLegumes.TabIndex = 6;
            toolTip1.SetToolTip(btnLegumes, "Baklagiller");
            btnLegumes.UseVisualStyleBackColor = true;
            btnLegumes.Click += btnLegumes_Click;
            // 
            // btnDesserts
            // 
            btnDesserts.FlatStyle = FlatStyle.Flat;
            btnDesserts.Image = (Image)resources.GetObject("btnDesserts.Image");
            btnDesserts.Location = new Point(312, 18);
            btnDesserts.Name = "btnDesserts";
            btnDesserts.Size = new Size(54, 50);
            btnDesserts.TabIndex = 5;
            toolTip1.SetToolTip(btnDesserts, "Tatlılar");
            btnDesserts.UseVisualStyleBackColor = true;
            btnDesserts.Click += btnDesserts_Click;
            // 
            // btnCookies
            // 
            btnCookies.FlatStyle = FlatStyle.Flat;
            btnCookies.Image = (Image)resources.GetObject("btnCookies.Image");
            btnCookies.Location = new Point(254, 18);
            btnCookies.Name = "btnCookies";
            btnCookies.Size = new Size(43, 50);
            btnCookies.TabIndex = 4;
            toolTip1.SetToolTip(btnCookies, "Çerezler");
            btnCookies.UseVisualStyleBackColor = true;
            btnCookies.Click += btnCookies_Click;
            // 
            // btnAlkol
            // 
            btnAlkol.FlatStyle = FlatStyle.Flat;
            btnAlkol.Image = (Image)resources.GetObject("btnAlkol.Image");
            btnAlkol.Location = new Point(195, 18);
            btnAlkol.Name = "btnAlkol";
            btnAlkol.Size = new Size(43, 50);
            btnAlkol.TabIndex = 3;
            toolTip1.SetToolTip(btnAlkol, "Alkollü İçecekler");
            btnAlkol.UseVisualStyleBackColor = true;
            btnAlkol.Click += btnAlkol_Click;
            // 
            // btnSoftDrink
            // 
            btnSoftDrink.FlatStyle = FlatStyle.Flat;
            btnSoftDrink.Image = (Image)resources.GetObject("btnSoftDrink.Image");
            btnSoftDrink.Location = new Point(132, 18);
            btnSoftDrink.Name = "btnSoftDrink";
            btnSoftDrink.Size = new Size(48, 50);
            btnSoftDrink.TabIndex = 2;
            toolTip1.SetToolTip(btnSoftDrink, "Alkolsüz İçecekler");
            btnSoftDrink.UseVisualStyleBackColor = true;
            btnSoftDrink.Click += btnSoftDrink_Click;
            // 
            // btnFruit
            // 
            btnFruit.FlatStyle = FlatStyle.Flat;
            btnFruit.Image = (Image)resources.GetObject("btnFruit.Image");
            btnFruit.Location = new Point(71, 18);
            btnFruit.Name = "btnFruit";
            btnFruit.Size = new Size(46, 50);
            btnFruit.TabIndex = 1;
            toolTip1.SetToolTip(btnFruit, "Meyve");
            btnFruit.UseVisualStyleBackColor = true;
            btnFruit.Click += btnFruit_Click;
            // 
            // btnVegetables
            // 
            btnVegetables.FlatStyle = FlatStyle.Flat;
            btnVegetables.Image = (Image)resources.GetObject("btnVegetables.Image");
            btnVegetables.Location = new Point(8, 18);
            btnVegetables.Name = "btnVegetables";
            btnVegetables.Size = new Size(40, 50);
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
            lvYemekleriListele.Location = new Point(12, 109);
            lvYemekleriListele.Name = "lvYemekleriListele";
            lvYemekleriListele.Size = new Size(289, 397);
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
            label3.Location = new Point(348, 315);
            label3.Name = "label3";
            label3.Size = new Size(118, 23);
            label3.TabIndex = 6;
            label3.Text = "Ölçü-Adet:";
            // 
            // nudGram
            // 
            nudGram.Location = new Point(473, 311);
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
            btnOgunEkle.Click += btnOgunEkle_Click;
            // 
            // lvOgunListesi
            // 
            lvOgunListesi.BackColor = SystemColors.InactiveCaption;
            lvOgunListesi.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lvOgunListesi.FullRowSelect = true;
            lvOgunListesi.GridLines = true;
            lvOgunListesi.Location = new Point(629, 109);
            lvOgunListesi.Name = "lvOgunListesi";
            lvOgunListesi.Size = new Size(496, 397);
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
            // btnOgunKaydet
            // 
            btnOgunKaydet.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnOgunKaydet.Location = new Point(629, 522);
            btnOgunKaydet.Name = "btnOgunKaydet";
            btnOgunKaydet.Size = new Size(159, 40);
            btnOgunKaydet.TabIndex = 10;
            btnOgunKaydet.Text = "Öğünlerimi Kaydet";
            btnOgunKaydet.UseVisualStyleBackColor = true;
            // 
            // btnOgunlerimiSil
            // 
            btnOgunlerimiSil.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnOgunlerimiSil.Location = new Point(803, 522);
            btnOgunlerimiSil.Name = "btnOgunlerimiSil";
            btnOgunlerimiSil.Size = new Size(159, 40);
            btnOgunlerimiSil.TabIndex = 11;
            btnOgunlerimiSil.Text = "Öğünlerimi Sil";
            btnOgunlerimiSil.UseVisualStyleBackColor = true;
            // 
            // HomeScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1182, 655);
            ControlBox = false;
            Controls.Add(btnOgunlerimiSil);
            Controls.Add(btnOgunKaydet);
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
        private Button btnOgunKaydet;
        private ColumnHeader columnHeader5;
        private Button btnMultigrainCereals;
        private Button btnMainDishes;
        private Button btnOgunlerimiSil;
    }
}