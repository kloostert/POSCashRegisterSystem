namespace VuurwerkKassa
{
    partial class MainGUI
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "119",
            "Event Starpalm",
            "2",
            "60,00",
            "120,00"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Adobe Fan Heiti Std B", 20F));
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGUI));
            this.btnAfsluiten = new System.Windows.Forms.Button();
            this.lblCredits = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnNieuweKlant = new System.Windows.Forms.Button();
            this.txtBARcode = new System.Windows.Forms.TextBox();
            this.btnVeranderAantal = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnVerwijder = new System.Windows.Forms.Button();
            this.btnVeranderTotaal = new System.Windows.Forms.Button();
            this.btnVeranderPrijs = new System.Windows.Forms.Button();
            this.btnMultiplicity = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPin = new System.Windows.Forms.Button();
            this.btnCash = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnHandBarCode = new System.Windows.Forms.Button();
            this.btnHandArtOm = new System.Windows.Forms.Button();
            this.btnHandArtNr = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTotaal = new System.Windows.Forms.Label();
            this.btnKlantView = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAfsluiten
            // 
            this.btnAfsluiten.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAfsluiten.Location = new System.Drawing.Point(1264, 991);
            this.btnAfsluiten.Name = "btnAfsluiten";
            this.btnAfsluiten.Size = new System.Drawing.Size(644, 50);
            this.btnAfsluiten.TabIndex = 0;
            this.btnAfsluiten.TabStop = false;
            this.btnAfsluiten.Text = "Kassa Afsluiten";
            this.btnAfsluiten.UseVisualStyleBackColor = true;
            this.btnAfsluiten.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblCredits
            // 
            this.lblCredits.AutoSize = true;
            this.lblCredits.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Italic);
            this.lblCredits.Location = new System.Drawing.Point(1616, 1047);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCredits.Size = new System.Drawing.Size(292, 20);
            this.lblCredits.TabIndex = 1;
            this.lblCredits.Text = "© 2017  Thijs Klooster Software Design";
            this.lblCredits.Click += new System.EventHandler(this.lblCredits_Click);
            // 
            // listView1
            // 
            this.listView1.AllowColumnReorder = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 20F);
            this.listView1.FullRowSelect = true;
            listViewGroup1.Header = "";
            listViewGroup1.Name = "listViewGroup1";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            listViewItem1.Group = listViewGroup1;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1246, 1056);
            this.listView1.TabIndex = 3;
            this.listView1.TabStop = false;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nummer";
            this.columnHeader1.Width = 134;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Omschrijving";
            this.columnHeader2.Width = 664;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Aantal";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 119;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Prijs";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 140;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Totaal";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader5.Width = 167;
            // 
            // btnNieuweKlant
            // 
            this.btnNieuweKlant.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNieuweKlant.Location = new System.Drawing.Point(1264, 910);
            this.btnNieuweKlant.Name = "btnNieuweKlant";
            this.btnNieuweKlant.Size = new System.Drawing.Size(644, 75);
            this.btnNieuweKlant.TabIndex = 4;
            this.btnNieuweKlant.TabStop = false;
            this.btnNieuweKlant.Text = "Volgende Klant";
            this.btnNieuweKlant.UseVisualStyleBackColor = true;
            this.btnNieuweKlant.Click += new System.EventHandler(this.btnNieuweKlant_Click);
            // 
            // txtBARcode
            // 
            this.txtBARcode.Location = new System.Drawing.Point(1264, 1047);
            this.txtBARcode.Multiline = true;
            this.txtBARcode.Name = "txtBARcode";
            this.txtBARcode.Size = new System.Drawing.Size(295, 21);
            this.txtBARcode.TabIndex = 0;
            this.txtBARcode.TextChanged += new System.EventHandler(this.txtBARcode_TextChanged);
            // 
            // btnVeranderAantal
            // 
            this.btnVeranderAantal.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVeranderAantal.Location = new System.Drawing.Point(6, 33);
            this.btnVeranderAantal.Name = "btnVeranderAantal";
            this.btnVeranderAantal.Size = new System.Drawing.Size(313, 75);
            this.btnVeranderAantal.TabIndex = 7;
            this.btnVeranderAantal.TabStop = false;
            this.btnVeranderAantal.Text = "Aantal";
            this.btnVeranderAantal.UseVisualStyleBackColor = true;
            this.btnVeranderAantal.Click += new System.EventHandler(this.btnVeranderAantal_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnVerwijder);
            this.groupBox1.Controls.Add(this.btnVeranderTotaal);
            this.groupBox1.Controls.Add(this.btnVeranderPrijs);
            this.groupBox1.Controls.Add(this.btnVeranderAantal);
            this.groupBox1.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 20F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(1264, 586);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(644, 197);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aanpassen";
            // 
            // btnVerwijder
            // 
            this.btnVerwijder.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerwijder.Location = new System.Drawing.Point(325, 33);
            this.btnVerwijder.Name = "btnVerwijder";
            this.btnVerwijder.Size = new System.Drawing.Size(313, 75);
            this.btnVerwijder.TabIndex = 10;
            this.btnVerwijder.TabStop = false;
            this.btnVerwijder.Text = "Verwijder";
            this.btnVerwijder.UseVisualStyleBackColor = true;
            this.btnVerwijder.Click += new System.EventHandler(this.btnVerwijder_Click);
            // 
            // btnVeranderTotaal
            // 
            this.btnVeranderTotaal.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVeranderTotaal.Location = new System.Drawing.Point(325, 114);
            this.btnVeranderTotaal.Name = "btnVeranderTotaal";
            this.btnVeranderTotaal.Size = new System.Drawing.Size(313, 75);
            this.btnVeranderTotaal.TabIndex = 10;
            this.btnVeranderTotaal.TabStop = false;
            this.btnVeranderTotaal.Text = "Totaal";
            this.btnVeranderTotaal.UseVisualStyleBackColor = true;
            this.btnVeranderTotaal.Click += new System.EventHandler(this.btnVeranderTotaal_Click);
            // 
            // btnVeranderPrijs
            // 
            this.btnVeranderPrijs.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVeranderPrijs.Location = new System.Drawing.Point(6, 114);
            this.btnVeranderPrijs.Name = "btnVeranderPrijs";
            this.btnVeranderPrijs.Size = new System.Drawing.Size(313, 75);
            this.btnVeranderPrijs.TabIndex = 8;
            this.btnVeranderPrijs.TabStop = false;
            this.btnVeranderPrijs.Text = "Prijs";
            this.btnVeranderPrijs.UseVisualStyleBackColor = true;
            this.btnVeranderPrijs.Click += new System.EventHandler(this.btnVeranderPrijs_Click);
            // 
            // btnMultiplicity
            // 
            this.btnMultiplicity.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicity.Location = new System.Drawing.Point(1264, 302);
            this.btnMultiplicity.Name = "btnMultiplicity";
            this.btnMultiplicity.Size = new System.Drawing.Size(644, 75);
            this.btnMultiplicity.TabIndex = 8;
            this.btnMultiplicity.TabStop = false;
            this.btnMultiplicity.Text = "Vermenigvuldiging";
            this.btnMultiplicity.UseVisualStyleBackColor = true;
            this.btnMultiplicity.Click += new System.EventHandler(this.btnMultiplicity_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPin);
            this.groupBox2.Controls.Add(this.btnCash);
            this.groupBox2.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 20F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(1264, 789);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(644, 115);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Betalen";
            // 
            // btnPin
            // 
            this.btnPin.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPin.Location = new System.Drawing.Point(325, 33);
            this.btnPin.Name = "btnPin";
            this.btnPin.Size = new System.Drawing.Size(313, 75);
            this.btnPin.TabIndex = 10;
            this.btnPin.TabStop = false;
            this.btnPin.Text = "Cash + PIN";
            this.btnPin.UseVisualStyleBackColor = true;
            this.btnPin.Click += new System.EventHandler(this.btnPin_Click);
            // 
            // btnCash
            // 
            this.btnCash.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCash.Location = new System.Drawing.Point(6, 33);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(313, 75);
            this.btnCash.TabIndex = 7;
            this.btnCash.TabStop = false;
            this.btnCash.Text = "Cash";
            this.btnCash.UseVisualStyleBackColor = true;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnHandBarCode);
            this.groupBox3.Controls.Add(this.btnHandArtOm);
            this.groupBox3.Controls.Add(this.btnHandArtNr);
            this.groupBox3.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 20F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(1264, 383);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(644, 197);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Handmatig Invoeren";
            // 
            // btnHandBarCode
            // 
            this.btnHandBarCode.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHandBarCode.Location = new System.Drawing.Point(325, 33);
            this.btnHandBarCode.Name = "btnHandBarCode";
            this.btnHandBarCode.Size = new System.Drawing.Size(313, 75);
            this.btnHandBarCode.TabIndex = 10;
            this.btnHandBarCode.TabStop = false;
            this.btnHandBarCode.Text = "BAR-code";
            this.btnHandBarCode.UseVisualStyleBackColor = true;
            this.btnHandBarCode.Click += new System.EventHandler(this.btnHandBarCode_Click);
            // 
            // btnHandArtOm
            // 
            this.btnHandArtOm.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHandArtOm.Location = new System.Drawing.Point(6, 114);
            this.btnHandArtOm.Name = "btnHandArtOm";
            this.btnHandArtOm.Size = new System.Drawing.Size(632, 75);
            this.btnHandArtOm.TabIndex = 10;
            this.btnHandArtOm.TabStop = false;
            this.btnHandArtOm.Text = "Artikelomschrijving";
            this.btnHandArtOm.UseVisualStyleBackColor = true;
            this.btnHandArtOm.Click += new System.EventHandler(this.btnHandArtOm_Click);
            // 
            // btnHandArtNr
            // 
            this.btnHandArtNr.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHandArtNr.Location = new System.Drawing.Point(6, 33);
            this.btnHandArtNr.Name = "btnHandArtNr";
            this.btnHandArtNr.Size = new System.Drawing.Size(313, 75);
            this.btnHandArtNr.TabIndex = 7;
            this.btnHandArtNr.TabStop = false;
            this.btnHandArtNr.Text = "ArtikelNr";
            this.btnHandArtNr.UseVisualStyleBackColor = true;
            this.btnHandArtNr.Click += new System.EventHandler(this.btnHandArtNr_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1264, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(638, 284);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblTotaal
            // 
            this.lblTotaal.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 45F, System.Drawing.FontStyle.Bold);
            this.lblTotaal.Location = new System.Drawing.Point(1554, 12);
            this.lblTotaal.Name = "lblTotaal";
            this.lblTotaal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotaal.Size = new System.Drawing.Size(354, 84);
            this.lblTotaal.TabIndex = 13;
            this.lblTotaal.Text = "€ 129,95";
            this.lblTotaal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblTotaal.Click += new System.EventHandler(this.lblTotaal_Click);
            // 
            // btnKlantView
            // 
            this.btnKlantView.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKlantView.Location = new System.Drawing.Point(1565, 1046);
            this.btnKlantView.Name = "btnKlantView";
            this.btnKlantView.Size = new System.Drawing.Size(45, 23);
            this.btnKlantView.TabIndex = 14;
            this.btnKlantView.TabStop = false;
            this.btnKlantView.Text = ">>";
            this.btnKlantView.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKlantView.UseVisualStyleBackColor = true;
            this.btnKlantView.Click += new System.EventHandler(this.btnKlantView_Click);
            // 
            // MainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.btnKlantView);
            this.Controls.Add(this.lblTotaal);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnMultiplicity);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtBARcode);
            this.Controls.Add(this.btnNieuweKlant);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lblCredits);
            this.Controls.Add(this.btnAfsluiten);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kassa";
            this.Load += new System.EventHandler(this.MainGUI_Load);
            this.Click += new System.EventHandler(this.MainGUI_Click);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAfsluiten;
        private System.Windows.Forms.Label lblCredits;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnNieuweKlant;
        private System.Windows.Forms.TextBox txtBARcode;
        private System.Windows.Forms.Button btnVeranderAantal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnVeranderPrijs;
        private System.Windows.Forms.Button btnVeranderTotaal;
        private System.Windows.Forms.Button btnVerwijder;
        private System.Windows.Forms.Button btnMultiplicity;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPin;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnHandBarCode;
        private System.Windows.Forms.Button btnHandArtOm;
        private System.Windows.Forms.Button btnHandArtNr;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTotaal;
        private System.Windows.Forms.Button btnKlantView;
    }
}

