using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.IO;

namespace Weather_xml
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Interval = 60000; //1 dakika = 1*60*1000
            timer2.Enabled = true;
            
            panel1.BackColor = Color.FromArgb(150, Color.Black);
            panel2.BackColor = Color.FromArgb(100, Color.White);
            
            bölge.Items.Add("Marmara");
            bölge.Items.Add("İç Anadolu");
            bölge.Items.Add("Ege");
            bölge.Items.Add("Akdeniz");
            bölge.Items.Add("Güneydoğu Anadolu");
            bölge.Items.Add("Karadeniz");
            bölge.Items.Add("Doğu Anadolu");
            bölge.SelectedIndex = 0;
        }
        private void bölge_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bölge.Text == "Marmara")
            {
                iller.Items.Clear();
                iller.Items.Add("İstanbul");
                iller.Items.Add("Edirne");
                iller.Items.Add("Kırklareli");
                iller.Items.Add("Tekirdağ");
                iller.Items.Add("Çanakkale");
                iller.Items.Add("Kocaeli");
                iller.Items.Add("Yalova");
                iller.Items.Add("Sakarya");
                iller.Items.Add("Bilecik");
                iller.Items.Add("Bursa");
                iller.Items.Add("Balıkesir");
                iller.SelectedIndex = 0;
            }

            if (bölge.Text == "İç Anadolu")
            {
                iller.Items.Clear();

                iller.Text = "Lütfen İl Seçin";
                iller.Items.Add("Ankara");
                iller.Items.Add("Konya");
                iller.Items.Add("Kayseri");
                iller.Items.Add("Eskişehir");
                iller.Items.Add("Sivas");
                iller.Items.Add("Kırıkkale");
                iller.Items.Add("Aksaray");
                iller.Items.Add("Karaman");
                iller.Items.Add("Kırşehir");
                iller.Items.Add("Niğde");
                iller.Items.Add("Nevşehir");
                iller.Items.Add("Yozgat");
                iller.Items.Add("Çankırı");
            }
            if (bölge.Text == "Ege")
            {
                iller.Items.Clear();

                iller.Text = "Lütfen İl Seçin";
                iller.Items.Add("İzmir");
                iller.Items.Add("Manisa");
                iller.Items.Add("Aydın");
                iller.Items.Add("Denizli");
                iller.Items.Add("Muğla");
                iller.Items.Add("Afyonkarahisar");
                iller.Items.Add("Kütahya");
                iller.Items.Add("Uşak");
            }
            if (bölge.Text == "Akdeniz")
            {
                iller.Items.Clear();
                iller.ResetText();
                iller.Text = "Lütfen İl Seçin";
                iller.Items.Add("Adana");
                iller.Items.Add("Antalya");
                iller.Items.Add("Burdur");
                iller.Items.Add("Hatay");
                iller.Items.Add("Isparta");
                iller.Items.Add("Mersin");
                iller.Items.Add("Osmaniye");
                iller.Items.Add("Kahramanmaraş");

            }
            if (bölge.Text == "Güneydoğu Anadolu")
            {
                iller.Items.Clear();
                iller.ResetText();
                iller.Text = "Lütfen İl Seçin";
                iller.Items.Add("Adıyaman");
                iller.Items.Add("Batman");
                iller.Items.Add("Diyarbakır");
                iller.Items.Add("Gaziantep");
                iller.Items.Add("Kilis");
                iller.Items.Add("Mardin");
                iller.Items.Add("Şanlıurfa");
                iller.Items.Add("Siirt");
                iller.Items.Add("Şırnak");
            }
            if (bölge.Text == "Karadeniz")
            {
                iller.Items.Clear();
                iller.ResetText();
                iller.Text = "Lütfen İl Seçin";
                iller.Items.Add("Artvin");
                iller.Items.Add("Rize");
                iller.Items.Add("Bayburt");
                iller.Items.Add("Trabzon");
                iller.Items.Add("Gümüşhane");
                iller.Items.Add("Giresun");
                iller.Items.Add("Ordu");
                iller.Items.Add("Tokat");
                iller.Items.Add("Amasya");
                iller.Items.Add("Samsun");
                iller.Items.Add("Sinop");
                iller.Items.Add("Çorum");
                iller.Items.Add("Kastamonu");
                iller.Items.Add("Bartın");
                iller.Items.Add("Karabük");
                iller.Items.Add("Zonguldak");
                iller.Items.Add("Düzce");
                iller.Items.Add("Bolu");
            }
            if (bölge.Text == "Doğu Anadolu")
            {
                iller.Items.Clear();
                iller.ResetText();
                iller.Text = "Lütfen İl Seçin";
                iller.Items.Add("Ağrı");
                iller.Items.Add("Ardahan");
                iller.Items.Add("Bingöl");
                iller.Items.Add("Bitlis");
                iller.Items.Add("Elazığ");
                iller.Items.Add("Erzincan");
                iller.Items.Add("Erzurum");
                iller.Items.Add("Hakkari");
                iller.Items.Add("Iğdır");
                iller.Items.Add("Kars");
                iller.Items.Add("Malatya");
                iller.Items.Add("Muş");
                iller.Items.Add("Tunceli ");
                iller.Items.Add("Van");
            }
        }

        private void iller_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtbaşlık.Text = iller.Text;
            havadurumu();
        }

        
        public void havadurumu()
        {
            string api = "http://api.openweathermap.org/data/2.5/weather?q=" + iller.Text + "&mode=xml&units=metric&lang=tr&appid=57551962a5d04e41c9cf727bf37bb0a8";
            XDocument hava_durumu = XDocument.Load(api);

            var sicaklik = hava_durumu.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            txtsıcaklık.Text = sicaklik + "°";

            var his_sicaklik = hava_durumu.Descendants("feels_like").ElementAt(0).Attribute("value").Value;
            txtfeeltemp.Text = "Hissedilen Sıcaklık " + his_sicaklik + "°";

            var nem = hava_durumu.Descendants("humidity").ElementAt(0).Attribute("value").Value;
            txtnem.Text = "Nem %" + nem;

            var basınç = hava_durumu.Descendants("pressure").ElementAt(0).Attribute("value").Value;
            txtbasınç.Text = "Basınç " + basınç + "hPa";

            var rüzgar = hava_durumu.Descendants("speed").ElementAt(0).Attribute("value").Value;
            txtrüzgar.Text = "Rüzgar " + rüzgar + " m/s";

            var bulut = hava_durumu.Descendants("clouds").ElementAt(0).Attribute("value").Value;
            txtcloud.Text = "Bulut Oranı % " + bulut;

            var hava_acıklama = hava_durumu.Descendants("weather").ElementAt(0).Attribute("value").Value;
            txtaçıklama.Text = hava_acıklama;
            hava_durumu_açıklama();
           
            //sun rise formatı "2021-04-25T03:10:00" başındaki tarihe ihtiyacım olmadığı için removo ile string silme işlemi yaptım 
            // api kaynağında saat utc global (0.00)
            //Tr utc (+3.00) olduğu için saat verisi 3 saat geri 
            //saat eklemesi yapabilmem için doğru şekilde stringi bölüp saat tarafına +3 saat eklemem gerekiyordu
            //remove işlemi sonrasi gün_doğuş"03:10:00" ":" burlardan "boşluk" ile bölüp dizi içine atıyorum
            //parcalar[0] dizisinin karşılığı "03" "+3" ekleyerek saat farkını kaldırıyorum
            string gün_dogus = hava_durumu.Descendants("sun").ElementAt(0).Attribute("rise").Value.Remove(0, 11);
            char[] ayrac = { ':', ' ', ' ' };
            string[] parcalar = gün_dogus.Split(ayrac); 
            int number = Convert.ToInt32(parcalar[0]) + 3;
            txtgdoğuş.Text = ("0" + (number) + ":" + (parcalar[1]) + " :" + (parcalar[2]));


            //aynı işlemleri güneş batış saati için yapıyorum
            string gün_batış = hava_durumu.Descendants("sun").ElementAt(0).Attribute("set").Value.Remove(0, 11);          
            string[] parcalar2 = gün_batış.Split(ayrac);
            int number2 = Convert.ToInt32(parcalar2[0]) + 3;
            txtgbatış.Text = (number2 + ":" + (parcalar2[1]) + " :" + (parcalar2[2]));

            kayıt();
        }

        public void hava_durumu_açıklama()
        {
            az_bulut.Visible = false;
            yağmur.Visible = false;
            bulutlu.Visible = false;
            güneş.Visible = false;
            kar.Visible = false;

            if (txtaçıklama.Text == "az bulutlu" || txtaçıklama.Text == "parçalı bulutlu" ||txtaçıklama.Text == "parçalı az bulutlu")
            {
                az_bulut.Visible = true;
               
            }        
            else if (txtaçıklama.Text == "kar yağışlı")
            {
                kar.Visible = true;
            }
            else if (txtaçıklama.Text == "açık")
            {
                güneş.Visible = true;
            }
            else if (txtaçıklama.Text == "kapalı")
            {
                bulutlu.Visible = true;
            }
            else if (txtaçıklama.Text == "hafif yağmur" || txtaçıklama.Text == "orta şiddetli yağmur" || txtaçıklama.Text == "yağmurlu")
            {
                yağmur.Visible = true;
            }

        }

        string yedek = "0";
         public void kayıt()
        {
            //xml verisindeki update verisi kontrollerim sonucu doğru olmadığı için kontrol yapımı lastupdate göre değil sıcaklık verime göre yapacağım
                    
            while (txtsıcaklık.Text != yedek)
            {
                yedek = txtsıcaklık.Text;
                FileStream fs = new FileStream(@"C:\Users\emreh\Desktop\Derslerim\2.sınıf 2.dönem\Projeler\Weather_xml\havadurumu.txt", FileMode.Append, FileAccess.Write, FileShare.Write);
                StreamWriter sw = new StreamWriter(fs);

                sw.WriteLine("*****" + txttarih.Text + "*****" + DateTime.Now.ToLongTimeString() + "*****");
                sw.WriteLine("Bölge :"+ bölge.Text);
                sw.WriteLine(txtbaşlık.Text + " Sıcaklık " + txtsıcaklık.Text);
                sw.WriteLine(txtaçıklama.Text);
                sw.WriteLine(txtcloud.Text);
                sw.WriteLine(txtfeeltemp.Text);
                sw.WriteLine("Güneş Doğuş " + txtgdoğuş.Text);
                sw.WriteLine("Güneş Batış " + txtgbatış.Text);
                sw.WriteLine(txtnem.Text);
                sw.WriteLine(txtbasınç.Text);
                sw.WriteLine(txtrüzgar.Text);
                sw.Close();

                // notify ile kullanıcıya bildirim sağlandı
                notifyIcon1.ShowBalloonTip(5000, "WeatherMap", "Yeni veriler geldi :)", ToolTipIcon.Warning);
            }
         
        }
   
        private void timer1_Tick(object sender, EventArgs e)
        {
            txttarih.Text = String.Format("{0:M}", DateTime.Now);

            txtsystemsaat.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            havadurumu();
            notifyIcon1.ShowBalloonTip(5000,"WeatherMap","Veriler api'den güncelleniyor...", ToolTipIcon.Info);
        }
    }
}
