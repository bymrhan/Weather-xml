
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
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
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.txtbaşlık = new System.Windows.Forms.Label();
            this.txtsıcaklık = new System.Windows.Forms.Label();
            this.txttarih = new System.Windows.Forms.Label();
            this.txtfeeltemp = new System.Windows.Forms.Label();
            this.txtsystemsaat = new System.Windows.Forms.Label();
            this.txtcloud = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(169, 13);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
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
            this.panel1.Size = new System.Drawing.Size(1246, 149);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(1129, 15);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(77, 77);
            this.pictureBox6.TabIndex = 2;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Weather_xml.Properties.Resources.anemometer;
            this.pictureBox5.Location = new System.Drawing.Point(908, 15);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(77, 77);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Weather_xml.Properties.Resources.barometer;
            this.pictureBox4.Location = new System.Drawing.Point(687, 15);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(77, 77);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Weather_xml.Properties.Resources._022_humidity;
            this.pictureBox3.Location = new System.Drawing.Point(466, 15);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(77, 77);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Weather_xml.Properties.Resources._017_sunset;
            this.pictureBox2.Location = new System.Drawing.Point(245, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(77, 77);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
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
            this.txtaçıklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtaçıklama.ForeColor = System.Drawing.Color.White;
            this.txtaçıklama.Location = new System.Drawing.Point(1141, 124);
            this.txtaçıklama.Name = "txtaçıklama";
            this.txtaçıklama.Size = new System.Drawing.Size(54, 16);
            this.txtaçıklama.TabIndex = 0;
            this.txtaçıklama.Text = "Bulutlu";
            // 
            // txtrüzgar
            // 
            this.txtrüzgar.AutoSize = true;
            this.txtrüzgar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtrüzgar.ForeColor = System.Drawing.Color.White;
            this.txtrüzgar.Location = new System.Drawing.Point(927, 122);
            this.txtrüzgar.Name = "txtrüzgar";
            this.txtrüzgar.Size = new System.Drawing.Size(61, 16);
            this.txtrüzgar.TabIndex = 0;
            this.txtrüzgar.Text = "Rüzgar ";
            // 
            // txtbasınç
            // 
            this.txtbasınç.AutoSize = true;
            this.txtbasınç.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbasınç.ForeColor = System.Drawing.Color.White;
            this.txtbasınç.Location = new System.Drawing.Point(691, 122);
            this.txtbasınç.Name = "txtbasınç";
            this.txtbasınç.Size = new System.Drawing.Size(83, 16);
            this.txtbasınç.TabIndex = 0;
            this.txtbasınç.Text = "Basınç 110";
            // 
            // txtnem
            // 
            this.txtnem.AutoSize = true;
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
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox7);
            this.panel2.Controls.Add(this.txtbaşlık);
            this.panel2.Controls.Add(this.txtsıcaklık);
            this.panel2.Controls.Add(this.txttarih);
            this.panel2.Controls.Add(this.txtfeeltemp);
            this.panel2.Controls.Add(this.txtsystemsaat);
            this.panel2.Controls.Add(this.txtcloud);
            this.panel2.Location = new System.Drawing.Point(939, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(307, 422);
            this.panel2.TabIndex = 13;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Weather_xml.Properties.Resources.google_maps;
            this.pictureBox7.Location = new System.Drawing.Point(221, 0);
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
            this.txtbaşlık.Location = new System.Drawing.Point(7, 61);
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
            this.txtsıcaklık.Location = new System.Drawing.Point(3, 141);
            this.txtsıcaklık.Name = "txtsıcaklık";
            this.txtsıcaklık.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtsıcaklık.Size = new System.Drawing.Size(271, 123);
            this.txtsıcaklık.TabIndex = 0;
            this.txtsıcaklık.Text = "19°C";
            this.txtsıcaklık.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txttarih
            // 
            this.txttarih.AutoSize = true;
            this.txttarih.BackColor = System.Drawing.Color.Transparent;
            this.txttarih.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttarih.ForeColor = System.Drawing.Color.Gold;
            this.txttarih.Location = new System.Drawing.Point(122, 19);
            this.txttarih.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txttarih.Name = "txttarih";
            this.txttarih.Size = new System.Drawing.Size(95, 25);
            this.txttarih.TabIndex = 8;
            this.txttarih.Text = "20 Nisan";
            // 
            // txtfeeltemp
            // 
            this.txtfeeltemp.AutoSize = true;
            this.txtfeeltemp.BackColor = System.Drawing.Color.Transparent;
            this.txtfeeltemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtfeeltemp.ForeColor = System.Drawing.Color.White;
            this.txtfeeltemp.Location = new System.Drawing.Point(3, 277);
            this.txtfeeltemp.Name = "txtfeeltemp";
            this.txtfeeltemp.Size = new System.Drawing.Size(184, 24);
            this.txtfeeltemp.TabIndex = 1;
            this.txtfeeltemp.Text = "Hissedilen Sıcaklık";
            // 
            // txtsystemsaat
            // 
            this.txtsystemsaat.AutoSize = true;
            this.txtsystemsaat.BackColor = System.Drawing.Color.Transparent;
            this.txtsystemsaat.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsystemsaat.ForeColor = System.Drawing.Color.Gold;
            this.txtsystemsaat.Location = new System.Drawing.Point(19, 19);
            this.txtsystemsaat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtsystemsaat.Name = "txtsystemsaat";
            this.txtsystemsaat.Size = new System.Drawing.Size(62, 24);
            this.txtsystemsaat.TabIndex = 9;
            this.txtsystemsaat.Text = "label6";
            // 
            // txtcloud
            // 
            this.txtcloud.AutoSize = true;
            this.txtcloud.BackColor = System.Drawing.Color.Transparent;
            this.txtcloud.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtcloud.ForeColor = System.Drawing.Color.White;
            this.txtcloud.Location = new System.Drawing.Point(3, 317);
            this.txtcloud.Name = "txtcloud";
            this.txtcloud.Size = new System.Drawing.Size(114, 24);
            this.txtcloud.TabIndex = 3;
            this.txtcloud.Text = "Bulut Oranı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Weather_xml.Properties.Resources.İstanbul;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1246, 622);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
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
        private System.Windows.Forms.PictureBox pictureBox6;
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
    }
}

