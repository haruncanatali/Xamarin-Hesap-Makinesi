using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App5_HesapMakinesi
{
    public partial class MainPage : ContentPage
    {

        string islem=null;
        double sayi, sonuc;
        List<double> sayilar = new List<double>();
        List<string> islemler = new List<string>();

        public MainPage()
        {
            InitializeComponent();
        }

        private void Btn_Click(object sender,EventArgs e)
        {
            Button buton = (Button)sender;
            //DisplayAlert("Tuşa basıldı.", "Tuşa basıldı.", "Tuşa basıldı.");

            switch (buton.Text)
            {
                case "AC":
                    islemLbl.Text = "";
                    sayilar.Clear();
                    sayi = 0;
                    islem = "";
                    sonuc = 0;
                    islemler.Clear();
                    sonucLBL.Text = "";
                    break;
                case "/":
                    islem += "/";
                    islemler.Add("/");
                    break;

                case "7":
                    islem += "7";
                    sayilar.Add(7);
                    break;
                case "8":
                    islem += "8";
                    sayilar.Add(8);
                    break;
                case "9":
                    islem += "9";
                    sayilar.Add(9);
                    break;
                case "X":
                    islemler.Add("X");
                    islem += "x";
                    break;

                case "4":
                    islem += "4";
                    sayilar.Add(4);
                    break;
                case "5":
                    islem += "5";
                    sayilar.Add(5);
                    break;
                case "6":
                    islem += "6";
                    sayilar.Add(6);
                    break;
                case "-":
                    islemler.Add("-");
                    islem += "-";
                    break;

                case "1":
                    sayilar.Add(1);
                    islem += "1";
                    break;
                case "2":
                    sayilar.Add(2);
                    islem += "2";
                    break;
                case "3":
                    sayilar.Add(3);
                    islem += "3";
                    break;
                case "+":
                    islemler.Add("+");
                    islem += "+";
                    break;

                case "0":
                    sayilar.Add(0);
                    islem += "0";
                    break;

            }

            islemLbl.Text = islem;
        }

        private void Btn_Click_Sonuc(object sender,EventArgs e)
        {
            try
            {
                for (int i = 0; i < islemler.Count(); i++)
                {
                    switch (islemler[i])
                    {
                        case "+":
                            if (i == 0)
                            {
                                sonuc = (sayilar[i] + sayilar[i + 1]);
                            }
                            else
                            {
                                sonuc += (sayilar[i + 1]);
                            }
                            break;
                        case "-":
                            if (i == 0)
                            {
                                sonuc = (sayilar[i] - sayilar[i + 1]);
                            }
                            else
                            {
                                sonuc -= (sayilar[i - 1]);
                            }
                            break;
                        case "/":
                            if (i == 0)
                            {
                                sonuc = (sayilar[i] / sayilar[i + 1]);
                            }
                            else
                            {
                                sonuc /= (sayilar[i + 1]);
                            }
                            break;
                        case "X":
                            if (i == 0)
                            {
                                sonuc = (sayilar[i] * sayilar[i + 1]);
                            }
                            else
                            {
                                sonuc *= (sayilar[i + 1]);
                            }
                            break;
                    }
                }
            }
            catch (Exception)
            {
                DisplayAlert("Hata", "Aritmetik işlemleri doğru yapın.", "Tamam");
            }

            sonucLBL.Text = sonuc.ToString();
        }
    }
}
