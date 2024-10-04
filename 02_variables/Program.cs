using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region doubleDeğişkenler
            ////double number//double, ondalıklı sayıları (küsuratlı sayıları) saklamak için kullanılan bir veri türüdür.

            ////number = 4.85;

            ////console ekranında nokta ile yazılan sayı çıktı ekranında virgül olarak algılanır.

            ////Console.WriteLine(number);
            ////Ctrl+boşluk otomatik tamamlar.

            //Console.WriteLine("**** Fiyat listesi ****");
            //Console.WriteLine();


            //// Fiyat tanımlamaları
            //double applePrice = 14.85;
            //double orangePrice = 20.95;
            //double strawberryPrice = 45;
            //double potatoPrice = 9.74;
            //double tomatoPrice = 6.88;

            //Console.WriteLine("-----Elma birim fiyatı: " + applePrice + " TL");
            //Console.WriteLine("-----Portakal birim fiyatı: " + orangePrice + " TL");
            //Console.WriteLine("-----Çilek birim fiyatı: " + strawberryPrice + " TL");
            //Console.WriteLine("-----Patates birim fiyatı: " + potatoPrice + " TL");
            //Console.WriteLine("-----Domates birim fiyatı: " + tomatoPrice + " TL");

            //Console.WriteLine();
            //Console.WriteLine();

            //// Gramaj tanımlamaları
            //double appleGram = 1.245;
            //double orangeGram = 2.650;
            //double strawberryGram = 0.750;
            //double potatoGram = 4.859;
            //double tomatoGram = 3.745;

            //// Her ürün için ayrı ayrı toplam fiyatı hesaplayıp ekrana yazdırıyoruz
            //double appleTotalPrice = appleGram * applePrice;
            //Console.WriteLine("Alınan ürün: Elma - Birim fiyat: " + applePrice + " TL - Gramaj: " + appleGram + " kg - Toplam Tutar: " + appleTotalPrice + " TL");

            //double orangeTotalPrice = orangeGram * orangePrice;

            //Console.WriteLine("Alınan ürün: Portakal - Birim fiyat: " + orangePrice + " TL - Gramaj: " + orangeGram + " kg - Toplam Tutar: " + orangeTotalPrice + " TL");

            //double strawberryTotalPrice = strawberryGram * strawberryPrice;

            //Console.WriteLine("Alınan ürün: Çilek - Birim fiyat: " + strawberryPrice + " TL - Gramaj: " + strawberryGram + " kg - Toplam Tutar: " + strawberryTotalPrice + " TL");

            //double potatoTotalPrice = potatoGram * potatoPrice;

            //Console.WriteLine("Alınan ürün: Patates - Birim fiyat: " + potatoPrice + " TL - Gramaj: " + potatoGram + " kg - Toplam Tutar: " + potatoTotalPrice + " TL");

            //double tomatoTotalPrice = tomatoGram * tomatoPrice;

            //Console.WriteLine("Alınan ürün: Domates - Birim fiyat: " + tomatoPrice + " TL - Gramaj: " + tomatoGram + " kg - Toplam Tutar: " + tomatoTotalPrice + " TL");

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;


            //Console.WriteLine();
            //Console.WriteLine("Alışveriş toplam tutar :" + shoppingTotalPrice);


            #endregion

            #region charDeğişkenler

            //ABCDEFGH gibi sezar şifrelemelri için kullanılır.
            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);


            #endregion

            #region Klavyeden veri girişleri string değişkenleri

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi **** ");
            //Console.WriteLine();
            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı:");
            //passengerName = Console.ReadLine();

            //Console.Write("yolcu soyadı:");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe bilgisi: "); passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("yolcu yaş: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("yolcu tc kimlik no: ");
            //passengerIdentityNumber = Console.ReadLine();   




            //Console.WriteLine();
            //Console.WriteLine("************************");
            //Console.WriteLine("Yolcu: "+ passengerName + " " + passengerSurname + " " + passengerDistrict + " / " + passengerCity + " " + passengerAge + " " );



            //ctrl+f ye tıkladıktan sonra değiştirmek istediğimiz kelimeyi başka bir kelimeyle değiştirebilirz.

            #endregion

            #region tam sayı girişleri ve dönüşümler

            //int shoesPrice, computerPrice, chairPrice, tvPrice;

            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.WriteLine("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());//Kullanıcının girdiği değeri tam sayıya çevirerek shoesCount değişkenine atar.

            //Console.WriteLine("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen aldığınız televizyon sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount * shoesPrice + computerPrice * computerCount + chairPrice * chairCount + tvPrice * tvCount;

            //Console.WriteLine();
            //Console.WriteLine("Toplam ödemeniz gereken tutar :" + totalPrice + "TL");







            #endregion


            #region klavyeden ondalıklı sayı işlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("lütfen 1.sınav notunu giriniz:");
            //exam1=double.Parse(Console.ReadLine());

            //Console.Write("lütfen 2.sınav notunu giriniz:");
            //exam2=double.Parse(Console.ReadLine());

            //Console.Write("lütfen 3.sınav notunu giriniz:");
            //exam3=double.Parse(Console.ReadLine());

            //result = (exam1+ exam2+exam3)/3;

            //Console.WriteLine();
            //Console.WriteLine("sınav ortalamanız:" + result);

            #endregion


            #region klavyeden karakter girişleri

            //char gender;
            //Console.Write("lütfen cinsiyet seçiniz: ");
            //gender = char.Parse(Console.ReadLine());
            //Console.WriteLine("seçtiğiniz cinsiyet: " + gender);



            #endregion

            Console.ReadLine();
        }
    }
}
