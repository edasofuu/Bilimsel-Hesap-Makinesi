/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2018-2019 .YAZ DÖNEMİ
**	
**				ÖDEV NUMARASI..........: 3
**				ÖĞRENCİ ADI............: Eda SOFU
**				ÖĞRENCİ NUMARASI.......: s181210214
**                       
****************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        bool operatorDurum = false;  // herhangi bi işleme tıklandığında yeni sayı girilmesi için textbox'ı boşaltacağız. O yüzden tanımladık.
        double sonuc;  //textbox'daki sonuc degeri
        string eskiOperator = " "; //labeldaki önceki işlemler için bir stringüü
        

        public Form1()
        {
            InitializeComponent();

        }

        private void RakamOlay(object sender, EventArgs e)
        {

            if (operatorDurum)
            {
                textBox.Clear();
            }
            operatorDurum = false;
            Button btn = (Button)sender;
            // Tüm sayılar için ortak bir olay tanımladık. 
            textBox.Text += btn.Text;                  // Sayılara tıklandıgında ardı ardına bir bütün olarak yazıyor. 
        }

        private void OperatorIslem(object sender, EventArgs e)
        {
            operatorDurum = true;
            Button btn = (Button)sender;
            string yeniOperator = btn.Text;


            GecmisLabel.Text = GecmisLabel.Text + " " + textBox.Text + " " + yeniOperator;
            if (textBox.Text != "")
            {
                switch (eskiOperator)
                {
                    case "+": textBox.Text = (sonuc + Double.Parse(textBox.Text)).ToString(); break;
                    case "-": textBox.Text = (sonuc - Double.Parse(textBox.Text)).ToString(); break;
                    case "/": textBox.Text = (sonuc / Double.Parse(textBox.Text)).ToString(); break;
                    case "x": textBox.Text = (sonuc * Double.Parse(textBox.Text)).ToString(); break;
                    case "Mod": textBox.Text = (sonuc % Double.Parse(textBox.Text)).ToString(); break;
                    case "^": textBox.Text = Math.Pow(sonuc, Double.Parse(textBox.Text)).ToString(); break;
                    case "log": textBox.Text = Math.Log10(Double.Parse(textBox.Text)).ToString(); break;
                    case "=": textBox.Text = (Double.Parse(textBox.Text)).ToString(); break;
                }

                sonuc = Double.Parse(textBox.Text);
                textBox.Text = sonuc.ToString();
                eskiOperator = yeniOperator;
            }
            else textBox.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void eSayisi_Click(object sender, EventArgs e)
        {
            double eSayisi = 2.71828 ;
            double sayi;
            if (textBox.Text != "")
            {

                sayi = Double.Parse(textBox.Text);
                sonuc = sayi * eSayisi;

                textBox.Text = sonuc.ToString();

            }
            else
                textBox.Text = eSayisi.ToString();
            GecmisLabel.Text = "e";


        }

        private void Button2_Click(object sender, EventArgs e)
        {
            GecmisLabel.Text = " ";
            if (textBox.Text != "")
            {
                sonuc = Convert.ToDouble(textBox.Text);
                textBox.Text = Convert.ToString(sonuc);
                GecmisLabel.Text = textBox.Text;
            }
            else
                textBox.Text = "";

           
        }
        

        

        private void VirgulButonu_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
            {
                textBox.Text = (Double.Parse(textBox.Text) + ",").ToString();
            }
            else
                textBox.Text = "";
                
        }

       

        private void SinButonu_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
            {
                double sinDegerimiz;
                sinDegerimiz = Convert.ToDouble(textBox.Text);
                double radyanSin = (sinDegerimiz * (Math.PI)) / 180;
                radyanSin = Math.Sin(radyanSin);
                textBox.Text = Convert.ToString(radyanSin);
            }
            else
                textBox.Text = "";

            
        }

        private void TanButonu_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
            {
                double tanDegerimiz;
                tanDegerimiz = Convert.ToDouble(textBox.Text);
                double radyanTan = (tanDegerimiz * (Math.PI)) / 180;
                radyanTan = Math.Tan(radyanTan);
                textBox.Text = Convert.ToString(radyanTan);
            }
            else
                textBox.Text = "";
        }

        private void CEButonu_Click(object sender, EventArgs e)
        {
            textBox.Text = "";

        }

        private void C_Butonu_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            GecmisLabel.Text = "";
            eskiOperator = "";
            sonuc = 0;
            operatorDurum = false;

        }

        

        private void FaktoriyelButonu_Click(object sender, EventArgs e)
        {
            sonuc = 1;
            int Fdegerimiz;
            if (textBox.Text != "")
            {
                Fdegerimiz = Convert.ToInt32(textBox.Text);

                for (int i = 1; i <= Fdegerimiz; i++)
                {
                    sonuc *= i;
                }
                GecmisLabel.Text = Fdegerimiz + "!" + "=" + sonuc.ToString();
                textBox.Text = sonuc.ToString();
            }
            else
                textBox.Text = "";
        }

        private void PiSayisiButon_Click(object sender, EventArgs e)
        {
            double Pi = 3.14159;
            double sayi;
            if(textBox.Text != "")
            {
                
                sayi = Double.Parse(textBox.Text);
                sonuc = sayi * Pi;
             
                textBox.Text = sonuc.ToString();
                
            } else
            textBox.Text = Pi.ToString();
            GecmisLabel.Text = "π";
        }

        private void CosButonu_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
            {
                double cosDegerimiz;
                cosDegerimiz = Convert.ToDouble(textBox.Text);
                double radyanCos = (cosDegerimiz * (Math.PI)) / 180;
                radyanCos = Math.Cos(radyanCos);
                textBox.Text = Convert.ToString(radyanCos);
            }
            else
                textBox.Text = "";              // Textbox'ın içi boşken program hata vermesin diye atama yaptık.
        }

        private void XKareButon_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
            {
                double sayi;
                sayi = Convert.ToDouble(textBox.Text);
                sonuc = sayi * sayi;
                textBox.Text = Convert.ToString(sonuc);
            }
            else
                textBox.Text = "";
        }

     

        private void KarekokButonu_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
            {
                GecmisLabel.Text = "√" + textBox.Text;
                double sayi;
                sayi = Convert.ToDouble(textBox.Text);
                sayi = Math.Sqrt(sayi);
                textBox.Text = Convert.ToString(sayi);
            }
            else
                textBox.Text = "";
            }

        private void Label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
