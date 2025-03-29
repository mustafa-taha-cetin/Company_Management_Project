namespace Personel_Kayit
{
    partial class FrmIstatistik2
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelBaslik = new System.Windows.Forms.Label();
            this.lblOrtalamaMaas = new System.Windows.Forms.Label();
            this.lblToplamMaas = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBekarPersonelSayısı = new System.Windows.Forms.Label();
            this.lblBekar = new System.Windows.Forms.Label();
            this.lblEvliPersonelSayısı = new System.Windows.Forms.Label();
            this.lblEvli = new System.Windows.Forms.Label();
            this.lblToplamPersonelSayısı = new System.Windows.Forms.Label();
            this.lblToplamPersonel = new System.Windows.Forms.Label();
            this.tbl_PersonelTableAdapter = new Personel_Kayit.Personel_Veri_TabaniDataSetTableAdapters.Tbl_PersonelTableAdapter();
            this.personel_Veri_TabaniDataSet = new Personel_Kayit.Personel_Veri_TabaniDataSet();
            this.tblPersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnistatistik = new System.Windows.Forms.Button();
            this.lblSehirSayi = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personel_Veri_TabaniDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.labelBaslik);
            this.panel1.Location = new System.Drawing.Point(13, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 126);
            this.panel1.TabIndex = 2;
            // 
            // labelBaslik
            // 
            this.labelBaslik.AutoSize = true;
            this.labelBaslik.Font = new System.Drawing.Font("Corbel", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBaslik.ForeColor = System.Drawing.Color.Black;
            this.labelBaslik.Location = new System.Drawing.Point(234, 35);
            this.labelBaslik.Name = "labelBaslik";
            this.labelBaslik.Size = new System.Drawing.Size(532, 58);
            this.labelBaslik.TabIndex = 0;
            this.labelBaslik.Text = "Genel Verilerin İstatistikler";
            // 
            // lblOrtalamaMaas
            // 
            this.lblOrtalamaMaas.AutoSize = true;
            this.lblOrtalamaMaas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblOrtalamaMaas.Location = new System.Drawing.Point(452, 454);
            this.lblOrtalamaMaas.Name = "lblOrtalamaMaas";
            this.lblOrtalamaMaas.Size = new System.Drawing.Size(39, 45);
            this.lblOrtalamaMaas.TabIndex = 20;
            this.lblOrtalamaMaas.Text = "0";
            // 
            // lblToplamMaas
            // 
            this.lblToplamMaas.AutoSize = true;
            this.lblToplamMaas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblToplamMaas.Location = new System.Drawing.Point(452, 398);
            this.lblToplamMaas.Name = "lblToplamMaas";
            this.lblToplamMaas.Size = new System.Drawing.Size(39, 45);
            this.lblToplamMaas.TabIndex = 19;
            this.lblToplamMaas.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label3.Location = new System.Drawing.Point(180, 454);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 45);
            this.label3.TabIndex = 18;
            this.label3.Text = "Ortalama Maaş:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label1.Location = new System.Drawing.Point(209, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 45);
            this.label1.TabIndex = 17;
            this.label1.Text = "Toplam Maaş:";
            // 
            // lblBekarPersonelSayısı
            // 
            this.lblBekarPersonelSayısı.AutoSize = true;
            this.lblBekarPersonelSayısı.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblBekarPersonelSayısı.Location = new System.Drawing.Point(452, 301);
            this.lblBekarPersonelSayısı.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBekarPersonelSayısı.Name = "lblBekarPersonelSayısı";
            this.lblBekarPersonelSayısı.Size = new System.Drawing.Size(39, 45);
            this.lblBekarPersonelSayısı.TabIndex = 16;
            this.lblBekarPersonelSayısı.Text = "0";
            // 
            // lblBekar
            // 
            this.lblBekar.AutoSize = true;
            this.lblBekar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblBekar.Location = new System.Drawing.Point(93, 301);
            this.lblBekar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBekar.Name = "lblBekar";
            this.lblBekar.Size = new System.Drawing.Size(351, 45);
            this.lblBekar.TabIndex = 15;
            this.lblBekar.Text = "Bekar Personel Sayısı:";
            // 
            // lblEvliPersonelSayısı
            // 
            this.lblEvliPersonelSayısı.AutoSize = true;
            this.lblEvliPersonelSayısı.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblEvliPersonelSayısı.Location = new System.Drawing.Point(452, 246);
            this.lblEvliPersonelSayısı.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEvliPersonelSayısı.Name = "lblEvliPersonelSayısı";
            this.lblEvliPersonelSayısı.Size = new System.Drawing.Size(39, 45);
            this.lblEvliPersonelSayısı.TabIndex = 14;
            this.lblEvliPersonelSayısı.Text = "0";
            // 
            // lblEvli
            // 
            this.lblEvli.AutoSize = true;
            this.lblEvli.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblEvli.Location = new System.Drawing.Point(126, 246);
            this.lblEvli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEvli.Name = "lblEvli";
            this.lblEvli.Size = new System.Drawing.Size(318, 45);
            this.lblEvli.TabIndex = 13;
            this.lblEvli.Text = "Evli Personel Sayısı:";
            // 
            // lblToplamPersonelSayısı
            // 
            this.lblToplamPersonelSayısı.AutoSize = true;
            this.lblToplamPersonelSayısı.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblToplamPersonelSayısı.Location = new System.Drawing.Point(452, 192);
            this.lblToplamPersonelSayısı.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToplamPersonelSayısı.Name = "lblToplamPersonelSayısı";
            this.lblToplamPersonelSayısı.Size = new System.Drawing.Size(39, 45);
            this.lblToplamPersonelSayısı.TabIndex = 12;
            this.lblToplamPersonelSayısı.Text = "0";
            // 
            // lblToplamPersonel
            // 
            this.lblToplamPersonel.AutoSize = true;
            this.lblToplamPersonel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblToplamPersonel.Location = new System.Drawing.Point(64, 192);
            this.lblToplamPersonel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToplamPersonel.Name = "lblToplamPersonel";
            this.lblToplamPersonel.Size = new System.Drawing.Size(380, 45);
            this.lblToplamPersonel.TabIndex = 11;
            this.lblToplamPersonel.Text = "Toplam Personel Sayısı:";
            // 
            // tbl_PersonelTableAdapter
            // 
            this.tbl_PersonelTableAdapter.ClearBeforeFill = true;
            // 
            // personel_Veri_TabaniDataSet
            // 
            this.personel_Veri_TabaniDataSet.DataSetName = "Personel_Veri_TabaniDataSet";
            this.personel_Veri_TabaniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblPersonelBindingSource
            // 
            this.tblPersonelBindingSource.DataMember = "Tbl_Personel";
            this.tblPersonelBindingSource.DataSource = this.personel_Veri_TabaniDataSet;
            // 
            // btnistatistik
            // 
            this.btnistatistik.Location = new System.Drawing.Point(213, 512);
            this.btnistatistik.Name = "btnistatistik";
            this.btnistatistik.Size = new System.Drawing.Size(256, 51);
            this.btnistatistik.TabIndex = 21;
            this.btnistatistik.Text = "İstatistik";
            this.btnistatistik.UseVisualStyleBackColor = true;
            this.btnistatistik.Click += new System.EventHandler(this.btnistatistik_Click);
            // 
            // lblSehirSayi
            // 
            this.lblSehirSayi.AutoSize = true;
            this.lblSehirSayi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblSehirSayi.Location = new System.Drawing.Point(452, 351);
            this.lblSehirSayi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSehirSayi.Name = "lblSehirSayi";
            this.lblSehirSayi.Size = new System.Drawing.Size(39, 45);
            this.lblSehirSayi.TabIndex = 23;
            this.lblSehirSayi.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label4.Location = new System.Drawing.Point(240, 348);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 45);
            this.label4.TabIndex = 22;
            this.label4.Text = "Şehir Sayısı:";
            // 
            // chart1
            // 
            this.chart1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(568, 192);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Meslek-Maas";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(389, 371);
            this.chart1.TabIndex = 24;
            this.chart1.Text = "chart1";
            // 
            // FrmIstatistik2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(196)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(985, 591);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.lblSehirSayi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnistatistik);
            this.Controls.Add(this.lblOrtalamaMaas);
            this.Controls.Add(this.lblToplamMaas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBekarPersonelSayısı);
            this.Controls.Add(this.lblBekar);
            this.Controls.Add(this.lblEvliPersonelSayısı);
            this.Controls.Add(this.lblEvli);
            this.Controls.Add(this.lblToplamPersonelSayısı);
            this.Controls.Add(this.lblToplamPersonel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Corbel", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "FrmIstatistik2";
            this.Text = "FrmIstatistik2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personel_Veri_TabaniDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelBaslik;
        private System.Windows.Forms.Label lblOrtalamaMaas;
        private System.Windows.Forms.Label lblToplamMaas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBekarPersonelSayısı;
        private System.Windows.Forms.Label lblBekar;
        private System.Windows.Forms.Label lblEvliPersonelSayısı;
        private System.Windows.Forms.Label lblEvli;
        private System.Windows.Forms.Label lblToplamPersonelSayısı;
        private System.Windows.Forms.Label lblToplamPersonel;
        private Personel_Veri_TabaniDataSetTableAdapters.Tbl_PersonelTableAdapter tbl_PersonelTableAdapter;
        private Personel_Veri_TabaniDataSet personel_Veri_TabaniDataSet;
        private System.Windows.Forms.BindingSource tblPersonelBindingSource;
        private System.Windows.Forms.Button btnistatistik;
        private System.Windows.Forms.Label lblSehirSayi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}