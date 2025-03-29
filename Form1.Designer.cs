namespace Personel_Kayit
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpbKayit = new System.Windows.Forms.GroupBox();
            this.mskMaas = new System.Windows.Forms.MaskedTextBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.rdbBekar = new System.Windows.Forms.RadioButton();
            this.comboSehir = new System.Windows.Forms.ComboBox();
            this.rdbEvli = new System.Windows.Forms.RadioButton();
            this.txtMeslek = new System.Windows.Forms.TextBox();
            this.lblMeslek = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.lblSehir = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblMaas = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblData6 = new System.Windows.Forms.Label();
            this.lblData5 = new System.Windows.Forms.Label();
            this.lblData4 = new System.Windows.Forms.Label();
            this.lblData3 = new System.Windows.Forms.Label();
            this.lblData2 = new System.Windows.Forms.Label();
            this.lblData1 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblKontrol = new System.Windows.Forms.Label();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.grpbIslem = new System.Windows.Forms.GroupBox();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.btnGrafik = new System.Windows.Forms.Button();
            this.btnİstatistik = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnListe = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.perIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perMaasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perDurumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.perMeslekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Per_Maas_Ay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personel_Veri_TabaniDataSet = new Personel_Kayit.Personel_Veri_TabaniDataSet();
            this.tbl_PersonelTableAdapter = new Personel_Kayit.Personel_Veri_TabaniDataSetTableAdapters.Tbl_PersonelTableAdapter();
            this.grpbKayit.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grpbIslem.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personel_Veri_TabaniDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbKayit
            // 
            this.grpbKayit.Controls.Add(this.mskMaas);
            this.grpbKayit.Controls.Add(this.btnTemizle);
            this.grpbKayit.Controls.Add(this.rdbBekar);
            this.grpbKayit.Controls.Add(this.comboSehir);
            this.grpbKayit.Controls.Add(this.rdbEvli);
            this.grpbKayit.Controls.Add(this.txtMeslek);
            this.grpbKayit.Controls.Add(this.lblMeslek);
            this.grpbKayit.Controls.Add(this.lblDurum);
            this.grpbKayit.Controls.Add(this.lblSehir);
            this.grpbKayit.Controls.Add(this.txtSoyad);
            this.grpbKayit.Controls.Add(this.txtAd);
            this.grpbKayit.Controls.Add(this.lblMaas);
            this.grpbKayit.Controls.Add(this.lblSoyad);
            this.grpbKayit.Controls.Add(this.lblAd);
            this.grpbKayit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(235)))));
            this.grpbKayit.Location = new System.Drawing.Point(45, 168);
            this.grpbKayit.Name = "grpbKayit";
            this.grpbKayit.Size = new System.Drawing.Size(691, 352);
            this.grpbKayit.TabIndex = 0;
            this.grpbKayit.TabStop = false;
            this.grpbKayit.Text = "Personel Kayıt";
            // 
            // mskMaas
            // 
            this.mskMaas.Location = new System.Drawing.Point(138, 207);
            this.mskMaas.Mask = "0000";
            this.mskMaas.Name = "mskMaas";
            this.mskMaas.Size = new System.Drawing.Size(173, 36);
            this.mskMaas.TabIndex = 3;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemizle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTemizle.Location = new System.Drawing.Point(205, 274);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(283, 59);
            this.btnTemizle.TabIndex = 8;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // rdbBekar
            // 
            this.rdbBekar.AutoSize = true;
            this.rdbBekar.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbBekar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(235)))));
            this.rdbBekar.Location = new System.Drawing.Point(556, 150);
            this.rdbBekar.Name = "rdbBekar";
            this.rdbBekar.Size = new System.Drawing.Size(104, 39);
            this.rdbBekar.TabIndex = 7;
            this.rdbBekar.TabStop = true;
            this.rdbBekar.Text = "Bekar";
            this.rdbBekar.UseVisualStyleBackColor = true;
            this.rdbBekar.CheckedChanged += new System.EventHandler(this.rdbBekar_CheckedChanged);
            // 
            // comboSehir
            // 
            this.comboSehir.FormattingEnabled = true;
            this.comboSehir.Items.AddRange(new object[] {
            "Ankara",
            "Bursa",
            "İstanbul",
            "İzmir"});
            this.comboSehir.Location = new System.Drawing.Point(472, 92);
            this.comboSehir.Name = "comboSehir";
            this.comboSehir.Size = new System.Drawing.Size(176, 36);
            this.comboSehir.TabIndex = 4;
            // 
            // rdbEvli
            // 
            this.rdbEvli.AutoSize = true;
            this.rdbEvli.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEvli.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(235)))));
            this.rdbEvli.Location = new System.Drawing.Point(472, 150);
            this.rdbEvli.Name = "rdbEvli";
            this.rdbEvli.Size = new System.Drawing.Size(78, 39);
            this.rdbEvli.TabIndex = 6;
            this.rdbEvli.TabStop = true;
            this.rdbEvli.Text = "Evli";
            this.rdbEvli.UseVisualStyleBackColor = true;
            this.rdbEvli.CheckedChanged += new System.EventHandler(this.rdbEvli_CheckedChanged);
            // 
            // txtMeslek
            // 
            this.txtMeslek.Location = new System.Drawing.Point(472, 207);
            this.txtMeslek.Name = "txtMeslek";
            this.txtMeslek.Size = new System.Drawing.Size(176, 36);
            this.txtMeslek.TabIndex = 5;
            // 
            // lblMeslek
            // 
            this.lblMeslek.AutoSize = true;
            this.lblMeslek.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeslek.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(235)))));
            this.lblMeslek.Location = new System.Drawing.Point(340, 205);
            this.lblMeslek.Name = "lblMeslek";
            this.lblMeslek.Size = new System.Drawing.Size(122, 40);
            this.lblMeslek.TabIndex = 8;
            this.lblMeslek.Text = "Meslek:";
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDurum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(235)))));
            this.lblDurum.Location = new System.Drawing.Point(343, 148);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(120, 40);
            this.lblDurum.TabIndex = 7;
            this.lblDurum.Text = "Durum:";
            // 
            // lblSehir
            // 
            this.lblSehir.AutoSize = true;
            this.lblSehir.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSehir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(235)))));
            this.lblSehir.Location = new System.Drawing.Point(368, 90);
            this.lblSehir.Name = "lblSehir";
            this.lblSehir.Size = new System.Drawing.Size(97, 40);
            this.lblSehir.TabIndex = 6;
            this.lblSehir.Text = "Şehir:";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(138, 154);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(173, 36);
            this.txtSoyad.TabIndex = 2;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(138, 102);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(173, 36);
            this.txtAd.TabIndex = 1;
            // 
            // lblMaas
            // 
            this.lblMaas.AutoSize = true;
            this.lblMaas.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(235)))));
            this.lblMaas.Location = new System.Drawing.Point(31, 207);
            this.lblMaas.Name = "lblMaas";
            this.lblMaas.Size = new System.Drawing.Size(98, 40);
            this.lblMaas.TabIndex = 2;
            this.lblMaas.Text = "Maaş:";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoyad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(235)))));
            this.lblSoyad.Location = new System.Drawing.Point(17, 154);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(112, 40);
            this.lblSoyad.TabIndex = 1;
            this.lblSoyad.Text = "Soyad:";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(235)))));
            this.lblAd.Location = new System.Drawing.Point(65, 96);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(65, 40);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "Ad:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(196)))), ((int)(((byte)(201)))));
            this.panel1.Controls.Add(this.lblData6);
            this.panel1.Controls.Add(this.lblData5);
            this.panel1.Controls.Add(this.lblData4);
            this.panel1.Controls.Add(this.lblData3);
            this.panel1.Controls.Add(this.lblData2);
            this.panel1.Controls.Add(this.lblData1);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Controls.Add(this.lblKontrol);
            this.panel1.Controls.Add(this.lblBaslik);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1042, 145);
            this.panel1.TabIndex = 1;
            // 
            // lblData6
            // 
            this.lblData6.AutoSize = true;
            this.lblData6.Location = new System.Drawing.Point(952, 6);
            this.lblData6.Name = "lblData6";
            this.lblData6.Size = new System.Drawing.Size(91, 28);
            this.lblData6.TabIndex = 8;
            this.lblData6.Text = "lblData6";
            // 
            // lblData5
            // 
            this.lblData5.AutoSize = true;
            this.lblData5.Location = new System.Drawing.Point(854, 117);
            this.lblData5.Name = "lblData5";
            this.lblData5.Size = new System.Drawing.Size(90, 28);
            this.lblData5.TabIndex = 7;
            this.lblData5.Text = "lblData5";
            // 
            // lblData4
            // 
            this.lblData4.AutoSize = true;
            this.lblData4.Location = new System.Drawing.Point(854, 90);
            this.lblData4.Name = "lblData4";
            this.lblData4.Size = new System.Drawing.Size(91, 28);
            this.lblData4.TabIndex = 6;
            this.lblData4.Text = "lblData4";
            // 
            // lblData3
            // 
            this.lblData3.AutoSize = true;
            this.lblData3.Location = new System.Drawing.Point(854, 62);
            this.lblData3.Name = "lblData3";
            this.lblData3.Size = new System.Drawing.Size(89, 28);
            this.lblData3.TabIndex = 5;
            this.lblData3.Text = "lblData3";
            // 
            // lblData2
            // 
            this.lblData2.AutoSize = true;
            this.lblData2.Location = new System.Drawing.Point(852, 34);
            this.lblData2.Name = "lblData2";
            this.lblData2.Size = new System.Drawing.Size(91, 28);
            this.lblData2.TabIndex = 4;
            this.lblData2.Text = "lblData2";
            // 
            // lblData1
            // 
            this.lblData1.AutoSize = true;
            this.lblData1.Location = new System.Drawing.Point(852, 6);
            this.lblData1.Name = "lblData1";
            this.lblData1.Size = new System.Drawing.Size(89, 28);
            this.lblData1.TabIndex = 3;
            this.lblData1.Text = "lblData1";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(71, 94);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(68, 28);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "label2";
            // 
            // lblKontrol
            // 
            this.lblKontrol.AutoSize = true;
            this.lblKontrol.Location = new System.Drawing.Point(71, 57);
            this.lblKontrol.Name = "lblKontrol";
            this.lblKontrol.Size = new System.Drawing.Size(66, 28);
            this.lblKontrol.TabIndex = 1;
            this.lblKontrol.Text = "label1";
            this.lblKontrol.Visible = false;
            this.lblKontrol.TextChanged += new System.EventHandler(this.lblKontrol_TextChanged);
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(196)))), ((int)(((byte)(201)))));
            this.lblBaslik.Font = new System.Drawing.Font("Corbel", 37.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblBaslik.Location = new System.Drawing.Point(284, 34);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(564, 77);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "Personel Giriş Ekranı";
            // 
            // grpbIslem
            // 
            this.grpbIslem.Controls.Add(this.btnGüncelle);
            this.grpbIslem.Controls.Add(this.btnGrafik);
            this.grpbIslem.Controls.Add(this.btnİstatistik);
            this.grpbIslem.Controls.Add(this.btnSil);
            this.grpbIslem.Controls.Add(this.btnKaydet);
            this.grpbIslem.Controls.Add(this.btnListe);
            this.grpbIslem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(235)))));
            this.grpbIslem.Location = new System.Drawing.Point(742, 168);
            this.grpbIslem.Name = "grpbIslem";
            this.grpbIslem.Size = new System.Drawing.Size(288, 352);
            this.grpbIslem.TabIndex = 1;
            this.grpbIslem.TabStop = false;
            this.grpbIslem.Text = "Kayıt İşlemleri";
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.ForeColor = System.Drawing.Color.Black;
            this.btnGüncelle.Location = new System.Drawing.Point(37, 142);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(200, 43);
            this.btnGüncelle.TabIndex = 5;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btnGrafik
            // 
            this.btnGrafik.ForeColor = System.Drawing.Color.Black;
            this.btnGrafik.Location = new System.Drawing.Point(37, 248);
            this.btnGrafik.Name = "btnGrafik";
            this.btnGrafik.Size = new System.Drawing.Size(200, 43);
            this.btnGrafik.TabIndex = 4;
            this.btnGrafik.Text = "Grafikler";
            this.btnGrafik.UseVisualStyleBackColor = true;
            this.btnGrafik.Click += new System.EventHandler(this.btnGrafik_Click);
            // 
            // btnİstatistik
            // 
            this.btnİstatistik.ForeColor = System.Drawing.Color.Black;
            this.btnİstatistik.Location = new System.Drawing.Point(37, 196);
            this.btnİstatistik.Name = "btnİstatistik";
            this.btnİstatistik.Size = new System.Drawing.Size(200, 43);
            this.btnİstatistik.TabIndex = 3;
            this.btnİstatistik.Text = "İstatistik";
            this.btnİstatistik.UseVisualStyleBackColor = true;
            this.btnİstatistik.Click += new System.EventHandler(this.btnİstatistik_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.DarkGray;
            this.btnSil.ForeColor = System.Drawing.Color.Black;
            this.btnSil.Location = new System.Drawing.Point(37, 297);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(200, 43);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Kayıt Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.ForeColor = System.Drawing.Color.Black;
            this.btnKaydet.Location = new System.Drawing.Point(37, 93);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(200, 43);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnListe
            // 
            this.btnListe.ForeColor = System.Drawing.Color.Black;
            this.btnListe.Location = new System.Drawing.Point(37, 44);
            this.btnListe.Name = "btnListe";
            this.btnListe.Size = new System.Drawing.Size(200, 43);
            this.btnListe.TabIndex = 0;
            this.btnListe.Text = "Listele";
            this.btnListe.UseVisualStyleBackColor = true;
            this.btnListe.Click += new System.EventHandler(this.btnListe_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(235)))));
            this.groupBox2.Location = new System.Drawing.Point(45, 530);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(985, 271);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kayıtlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.perIdDataGridViewTextBoxColumn,
            this.perAdDataGridViewTextBoxColumn,
            this.perSoyadDataGridViewTextBoxColumn,
            this.perSehirDataGridViewTextBoxColumn,
            this.perMaasDataGridViewTextBoxColumn,
            this.perDurumDataGridViewCheckBoxColumn,
            this.perMeslekDataGridViewTextBoxColumn,
            this.Per_Maas_Ay});
            this.dataGridView1.DataSource = this.tblPersonelBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.Location = new System.Drawing.Point(3, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(979, 236);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // perIdDataGridViewTextBoxColumn
            // 
            this.perIdDataGridViewTextBoxColumn.DataPropertyName = "Per_Id";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.perIdDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.perIdDataGridViewTextBoxColumn.HeaderText = "Per_Id";
            this.perIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perIdDataGridViewTextBoxColumn.Name = "perIdDataGridViewTextBoxColumn";
            this.perIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.perIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // perAdDataGridViewTextBoxColumn
            // 
            this.perAdDataGridViewTextBoxColumn.DataPropertyName = "Per_Ad";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.perAdDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.perAdDataGridViewTextBoxColumn.HeaderText = "Per_Ad";
            this.perAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perAdDataGridViewTextBoxColumn.Name = "perAdDataGridViewTextBoxColumn";
            this.perAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // perSoyadDataGridViewTextBoxColumn
            // 
            this.perSoyadDataGridViewTextBoxColumn.DataPropertyName = "Per_Soyad";
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.perSoyadDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.perSoyadDataGridViewTextBoxColumn.HeaderText = "Per_Soyad";
            this.perSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perSoyadDataGridViewTextBoxColumn.Name = "perSoyadDataGridViewTextBoxColumn";
            this.perSoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // perSehirDataGridViewTextBoxColumn
            // 
            this.perSehirDataGridViewTextBoxColumn.DataPropertyName = "Per_Sehir";
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.perSehirDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.perSehirDataGridViewTextBoxColumn.HeaderText = "Per_Sehir";
            this.perSehirDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perSehirDataGridViewTextBoxColumn.Name = "perSehirDataGridViewTextBoxColumn";
            this.perSehirDataGridViewTextBoxColumn.Width = 125;
            // 
            // perMaasDataGridViewTextBoxColumn
            // 
            this.perMaasDataGridViewTextBoxColumn.DataPropertyName = "Per_Maas";
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.perMaasDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.perMaasDataGridViewTextBoxColumn.HeaderText = "Per_Maas";
            this.perMaasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perMaasDataGridViewTextBoxColumn.Name = "perMaasDataGridViewTextBoxColumn";
            this.perMaasDataGridViewTextBoxColumn.Width = 125;
            // 
            // perDurumDataGridViewCheckBoxColumn
            // 
            this.perDurumDataGridViewCheckBoxColumn.DataPropertyName = "Per_Durum";
            this.perDurumDataGridViewCheckBoxColumn.HeaderText = "Per_Durum";
            this.perDurumDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.perDurumDataGridViewCheckBoxColumn.Name = "perDurumDataGridViewCheckBoxColumn";
            this.perDurumDataGridViewCheckBoxColumn.Width = 125;
            // 
            // perMeslekDataGridViewTextBoxColumn
            // 
            this.perMeslekDataGridViewTextBoxColumn.DataPropertyName = "Per_Meslek";
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.perMeslekDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.perMeslekDataGridViewTextBoxColumn.HeaderText = "Per_Meslek";
            this.perMeslekDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perMeslekDataGridViewTextBoxColumn.Name = "perMeslekDataGridViewTextBoxColumn";
            this.perMeslekDataGridViewTextBoxColumn.Width = 125;
            // 
            // Per_Maas_Ay
            // 
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.Per_Maas_Ay.DefaultCellStyle = dataGridViewCellStyle7;
            this.Per_Maas_Ay.HeaderText = "Per_Maas_ay";
            this.Per_Maas_Ay.MinimumWidth = 6;
            this.Per_Maas_Ay.Name = "Per_Maas_Ay";
            this.Per_Maas_Ay.ReadOnly = true;
            this.Per_Maas_Ay.Width = 125;
            // 
            // tblPersonelBindingSource
            // 
            this.tblPersonelBindingSource.DataMember = "Tbl_Personel";
            this.tblPersonelBindingSource.DataSource = this.personel_Veri_TabaniDataSet;
            // 
            // personel_Veri_TabaniDataSet
            // 
            this.personel_Veri_TabaniDataSet.DataSetName = "Personel_Veri_TabaniDataSet";
            this.personel_Veri_TabaniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_PersonelTableAdapter
            // 
            this.tbl_PersonelTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(86)))), ((int)(((byte)(109)))));
            this.ClientSize = new System.Drawing.Size(1066, 813);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpbIslem);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpbKayit);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Text = "Personel Giriş";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpbKayit.ResumeLayout(false);
            this.grpbKayit.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpbIslem.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personel_Veri_TabaniDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbKayit;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.RadioButton rdbBekar;
        private System.Windows.Forms.ComboBox comboSehir;
        private System.Windows.Forms.RadioButton rdbEvli;
        private System.Windows.Forms.TextBox txtMeslek;
        private System.Windows.Forms.Label lblMeslek;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Label lblSehir;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label lblMaas;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.GroupBox grpbIslem;
        private System.Windows.Forms.Button btnGrafik;
        private System.Windows.Forms.Button btnİstatistik;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnListe;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Personel_Veri_TabaniDataSet personel_Veri_TabaniDataSet;
        private System.Windows.Forms.BindingSource tblPersonelBindingSource;
        private Personel_Veri_TabaniDataSetTableAdapters.Tbl_PersonelTableAdapter tbl_PersonelTableAdapter;
        private System.Windows.Forms.MaskedTextBox mskMaas;
        private System.Windows.Forms.Label lblKontrol;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.DataGridViewTextBoxColumn perIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMaasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn perDurumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMeslekDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Per_Maas_Ay;
        private System.Windows.Forms.Label lblData1;
        private System.Windows.Forms.Label lblData2;
        private System.Windows.Forms.Label lblData4;
        private System.Windows.Forms.Label lblData3;
        private System.Windows.Forms.Label lblData5;
        private System.Windows.Forms.Label lblData6;
    }
}

