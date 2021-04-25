
namespace Weather_xml
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bölge = new System.Windows.Forms.ComboBox();
            this.iller = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.az_bulut = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.kar = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.yağmur = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.bulutlu = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.güneş = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtaçıklama = new System.Windows.Forms.Label();
            this.txtrüzgar = new System.Windows.Forms.Label();
            this.txtbasınç = new System.Windows.Forms.Label();
            this.txtnem = new System.Windows.Forms.Label();
            this.txtgbatış = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtgdoğuş = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtsystemsaat = new System.Windows.Forms.Label();
            this.txttarih = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.txtbaşlık = new System.Windows.Forms.Label();
            this.txtsıcaklık = new System.Windows.Forms.Label();
            this.txtfeeltemp = new System.Windows.Forms.Label();
            this.txtcloud = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.az_bulut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yağmur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulutlu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.güneş)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // bölge
            // 
            this.bölge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bölge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bölge.FormattingEnabled = true;
            this.bölge.Location = new System.Drawing.Point(11, 40);
            this.bölge.Name = "bölge";
            this.bölge.Size = new System.Drawing.Size(121, 24);
            this.bölge.TabIndex = 0;
            this.bölge.SelectedIndexChanged += new System.EventHandler(this.bölge_SelectedIndexChanged);
            // 
            // iller
            // 
            this.iller.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.iller.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.iller.FormattingEnabled = true;
            this.iller.Location = new System.Drawing.Point(177, 40);
            this.iller.Name = "iller";
            this.iller.Size = new System.Drawing.Size(121, 24);
            this.iller.TabIndex = 0;
            this.iller.SelectedIndexChanged += new System.EventHandler(this.iller_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.az_bulut);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.kar);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.yağmur);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.bulutlu);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.güneş);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtaçıklama);
            this.panel1.Controls.Add(this.txtrüzgar);
            this.panel1.Controls.Add(this.txtbasınç);
            this.panel1.Controls.Add(this.txtnem);
            this.panel1.Controls.Add(this.txtgbatış);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtgdoğuş);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 473);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1254, 149);
            this.panel1.TabIndex = 1;
            // 
            // az_bulut
            // 
            this.az_bulut.BackColor = System.Drawing.Color.Transparent;
            this.az_bulut.Image = ((System.Drawing.Image)(resources.GetObject("az_bulut.Image")));
            this.az_bulut.Location = new System.Drawing.Point(1097, 15);
            this.az_bulut.Name = "az_bulut";
            this.az_bulut.Size = new System.Drawing.Size(95, 75);
            this.az_bulut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.az_bulut.TabIndex = 10;
            this.az_bulut.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::Weather_xml.Properties.Resources.anemometer;
            this.pictureBox5.Location = new System.Drawing.Point(908, 15);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(95, 75);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            // 
            // kar
            // 
            this.kar.BackColor = System.Drawing.Color.Transparent;
            this.kar.Image = global::Weather_xml.Properties.Resources._008_snow_1;
            this.kar.Location = new System.Drawing.Point(1097, 13);
            this.kar.Name = "kar";
            this.kar.Size = new System.Drawing.Size(95, 75);
            this.kar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kar.TabIndex = 9;
            this.kar.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::Weather_xml.Properties.Resources.barometer;
            this.pictureBox4.Location = new System.Drawing.Point(687, 15);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(77, 77);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // yağmur
            // 
            this.yağmur.BackColor = System.Drawing.Color.Transparent;
            this.yağmur.Image = global::Weather_xml.Properties.Resources._012_rain_2;
            this.yağmur.Location = new System.Drawing.Point(1097, 15);
            this.yağmur.Name = "yağmur";
            this.yağmur.Size = new System.Drawing.Size(95, 75);
            this.yağmur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.yağmur.TabIndex = 8;
            this.yağmur.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Weather_xml.Properties.Resources._022_humidity;
            this.pictureBox3.Location = new System.Drawing.Point(466, 15);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(77, 77);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // bulutlu
            // 
            this.bulutlu.BackColor = System.Drawing.Color.Transparent;
            this.bulutlu.Image = global::Weather_xml.Properties.Resources._049_clouds;
            this.bulutlu.Location = new System.Drawing.Point(1097, 15);
            this.bulutlu.Name = "bulutlu";
            this.bulutlu.Size = new System.Drawing.Size(95, 75);
            this.bulutlu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bulutlu.TabIndex = 7;
            this.bulutlu.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Weather_xml.Properties.Resources._017_sunset;
            this.pictureBox2.Location = new System.Drawing.Point(245, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(77, 77);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // güneş
            // 
            this.güneş.BackColor = System.Drawing.Color.Transparent;
            this.güneş.Image = global::Weather_xml.Properties.Resources._050_sun;
            this.güneş.Location = new System.Drawing.Point(1097, 13);
            this.güneş.Name = "güneş";
            this.güneş.Size = new System.Drawing.Size(95, 75);
            this.güneş.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.güneş.TabIndex = 6;
            this.güneş.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Weather_xml.Properties.Resources._016_sunrise;
            this.pictureBox1.Location = new System.Drawing.Point(24, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txtaçıklama
            // 
            this.txtaçıklama.AutoSize = true;
            this.txtaçıklama.BackColor = System.Drawing.Color.Transparent;
            this.txtaçıklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtaçıklama.ForeColor = System.Drawing.Color.White;
            this.txtaçıklama.Location = new System.Drawing.Point(1102, 122);
            this.txtaçıklama.Name = "txtaçıklama";
            this.txtaçıklama.Size = new System.Drawing.Size(54, 16);
            this.txtaçıklama.TabIndex = 0;
            this.txtaçıklama.Text = "Bulutlu";
            // 
            // txtrüzgar
            // 
            this.txtrüzgar.AutoSize = true;
            this.txtrüzgar.BackColor = System.Drawing.Color.Transparent;
            this.txtrüzgar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtrüzgar.ForeColor = System.Drawing.Color.White;
            this.txtrüzgar.Location = new System.Drawing.Point(893, 122);
            this.txtrüzgar.Name = "txtrüzgar";
            this.txtrüzgar.Size = new System.Drawing.Size(61, 16);
            this.txtrüzgar.TabIndex = 0;
            this.txtrüzgar.Text = "Rüzgar ";
            // 
            // txtbasınç
            // 
            this.txtbasınç.AutoSize = true;
            this.txtbasınç.BackColor = System.Drawing.Color.Transparent;
            this.txtbasınç.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbasınç.ForeColor = System.Drawing.Color.White;
            this.txtbasınç.Location = new System.Drawing.Point(663, 122);
            this.txtbasınç.Name = "txtbasınç";
            this.txtbasınç.Size = new System.Drawing.Size(83, 16);
            this.txtbasınç.TabIndex = 0;
            this.txtbasınç.Text = "Basınç 110";
            // 
            // txtnem
            // 
            this.txtnem.AutoSize = true;
            this.txtnem.BackColor = System.Drawing.Color.Transparent;
            this.txtnem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtnem.ForeColor = System.Drawing.Color.White;
            this.txtnem.Location = new System.Drawing.Point(465, 122);
            this.txtnem.Name = "txtnem";
            this.txtnem.Size = new System.Drawing.Size(73, 16);
            this.txtnem.TabIndex = 0;
            this.txtnem.Text = "Nem %90";
            // 
            // txtgbatış
            // 
            this.txtgbatış.AutoSize = true;
            this.txtgbatış.BackColor = System.Drawing.Color.Transparent;
            this.txtgbatış.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtgbatış.ForeColor = System.Drawing.Color.White;
            this.txtgbatış.Location = new System.Drawing.Point(249, 99);
            this.txtgbatış.Name = "txtgbatış";
            this.txtgbatış.Size = new System.Drawing.Size(64, 16);
            this.txtgbatış.TabIndex = 0;
            this.txtgbatış.Text = "17.15.14";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(254, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "G.Batış";
            // 
            // txtgdoğuş
            // 
            this.txtgdoğuş.AutoSize = true;
            this.txtgdoğuş.BackColor = System.Drawing.Color.Transparent;
            this.txtgdoğuş.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtgdoğuş.ForeColor = System.Drawing.Color.White;
            this.txtgdoğuş.Location = new System.Drawing.Point(33, 99);
            this.txtgdoğuş.Name = "txtgdoğuş";
            this.txtgdoğuş.Size = new System.Drawing.Size(64, 16);
            this.txtgdoğuş.TabIndex = 0;
            this.txtgdoğuş.Text = "03.15.14";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "G.Doğus";
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "003-cloudy-4.png");
            this.ımageList1.Images.SetKeyName(1, "008-snow-1.png");
            this.ımageList1.Images.SetKeyName(2, "010-rain-3.png");
            this.ımageList1.Images.SetKeyName(3, "049-clouds.png");
            this.ımageList1.Images.SetKeyName(4, "050-sun.png");
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txttarih);
            this.panel2.Controls.Add(this.txtsystemsaat);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.pictureBox8);
            this.panel2.Controls.Add(this.pictureBox7);
            this.panel2.Controls.Add(this.txtbaşlık);
            this.panel2.Controls.Add(this.bölge);
            this.panel2.Controls.Add(this.iller);
            this.panel2.Controls.Add(this.txtsıcaklık);
            this.panel2.Controls.Add(this.txtfeeltemp);
            this.panel2.Controls.Add(this.txtcloud);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(939, -4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(315, 486);
            this.panel2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Location = new System.Drawing.Point(0, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(316, 5);
            this.panel3.TabIndex = 14;
            // 
            // txtsystemsaat
            // 
            this.txtsystemsaat.AutoSize = true;
            this.txtsystemsaat.BackColor = System.Drawing.Color.Transparent;
            this.txtsystemsaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsystemsaat.ForeColor = System.Drawing.Color.Gold;
            this.txtsystemsaat.Location = new System.Drawing.Point(7, 124);
            this.txtsystemsaat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtsystemsaat.Name = "txtsystemsaat";
            this.txtsystemsaat.Size = new System.Drawing.Size(57, 20);
            this.txtsystemsaat.TabIndex = 9;
            this.txtsystemsaat.Text = "label6";
            // 
            // txttarih
            // 
            this.txttarih.AutoSize = true;
            this.txttarih.BackColor = System.Drawing.Color.Transparent;
            this.txttarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txttarih.ForeColor = System.Drawing.Color.Gold;
            this.txttarih.Location = new System.Drawing.Point(126, 124);
            this.txttarih.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txttarih.Name = "txttarih";
            this.txttarih.Size = new System.Drawing.Size(79, 20);
            this.txttarih.TabIndex = 8;
            this.txttarih.Text = "20 Nisan";
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Image = global::Weather_xml.Properties.Resources._044_temperature_2;
            this.pictureBox8.Location = new System.Drawing.Point(247, 369);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(61, 57);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 1;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = global::Weather_xml.Properties.Resources.google_maps;
            this.pictureBox7.Location = new System.Drawing.Point(221, 102);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(77, 77);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 2;
            this.pictureBox7.TabStop = false;
            // 
            // txtbaşlık
            // 
            this.txtbaşlık.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbaşlık.AutoSize = true;
            this.txtbaşlık.BackColor = System.Drawing.Color.Transparent;
            this.txtbaşlık.Font = new System.Drawing.Font("Painter PERSONAL USE ONLY", 50.25F);
            this.txtbaşlık.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtbaşlık.Location = new System.Drawing.Point(3, 167);
            this.txtbaşlık.Name = "txtbaşlık";
            this.txtbaşlık.Size = new System.Drawing.Size(291, 95);
            this.txtbaşlık.TabIndex = 11;
            this.txtbaşlık.Text = "İstanbul";
            // 
            // txtsıcaklık
            // 
            this.txtsıcaklık.AutoSize = true;
            this.txtsıcaklık.BackColor = System.Drawing.Color.Transparent;
            this.txtsıcaklık.Font = new System.Drawing.Font("Arial Black", 65F, System.Drawing.FontStyle.Bold);
            this.txtsıcaklık.ForeColor = System.Drawing.Color.White;
            this.txtsıcaklık.Location = new System.Drawing.Point(3, 243);
            this.txtsıcaklık.Name = "txtsıcaklık";
            this.txtsıcaklık.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtsıcaklık.Size = new System.Drawing.Size(271, 123);
            this.txtsıcaklık.TabIndex = 0;
            this.txtsıcaklık.Text = "19°C";
            this.txtsıcaklık.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtfeeltemp
            // 
            this.txtfeeltemp.AutoSize = true;
            this.txtfeeltemp.BackColor = System.Drawing.Color.Transparent;
            this.txtfeeltemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtfeeltemp.ForeColor = System.Drawing.Color.White;
            this.txtfeeltemp.Location = new System.Drawing.Point(3, 379);
            this.txtfeeltemp.Name = "txtfeeltemp";
            this.txtfeeltemp.Size = new System.Drawing.Size(184, 24);
            this.txtfeeltemp.TabIndex = 1;
            this.txtfeeltemp.Text = "Hissedilen Sıcaklık";
            // 
            // txtcloud
            // 
            this.txtcloud.AutoSize = true;
            this.txtcloud.BackColor = System.Drawing.Color.Transparent;
            this.txtcloud.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtcloud.ForeColor = System.Drawing.Color.White;
            this.txtcloud.Location = new System.Drawing.Point(3, 419);
            this.txtcloud.Name = "txtcloud";
            this.txtcloud.Size = new System.Drawing.Size(114, 24);
            this.txtcloud.TabIndex = 3;
            this.txtcloud.Text = "Bulut Oranı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(174, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "İl";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(8, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Bölge";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::Weather_xml.Properties.Resources._031_weather_forecast;
            this.pictureBox6.Location = new System.Drawing.Point(6, 9);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(41, 41);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 1;
            this.pictureBox6.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Painter PERSONAL USE ONLY", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(53, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 35);
            this.label5.TabIndex = 0;
            this.label5.Text = "WeatherMap";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Weather_xml.Properties.Resources.İstanbul;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1254, 622);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.az_bulut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yağmur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulutlu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.güneş)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox bölge;
        private System.Windows.Forms.ComboBox iller;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txtrüzgar;
        private System.Windows.Forms.Label txtbasınç;
        private System.Windows.Forms.Label txtnem;
        private System.Windows.Forms.Label txtgbatış;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtgdoğuş;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtaçıklama;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label txtbaşlık;
        private System.Windows.Forms.Label txtsıcaklık;
        private System.Windows.Forms.Label txttarih;
        private System.Windows.Forms.Label txtfeeltemp;
        private System.Windows.Forms.Label txtsystemsaat;
        private System.Windows.Forms.Label txtcloud;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox yağmur;
        private System.Windows.Forms.PictureBox kar;
        private System.Windows.Forms.PictureBox az_bulut;
        private System.Windows.Forms.PictureBox güneş;
        private System.Windows.Forms.PictureBox bulutlu;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox8;
    }
}

