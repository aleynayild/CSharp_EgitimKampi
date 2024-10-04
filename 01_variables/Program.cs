using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//her şeyi aynı başlık altında vermeyip böl parçala yönet kuralını uygular.
//using yazdıracağımız kodlara ait kütüphaneleri tutar.
//internal bir erişim belirleyicidir.

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {    //. dan sonra gelen komutta bir mor küp varsa bu onun method oldugunu gösterir.

            #region YazdırmaKomutları
            //Console.Write("merhaba dünya");//yazdırma komutu, bir yazı yazdırdığı zaman imleci o yazının en sağına atar.
            //Console.WriteLine(" selaam");//imleci alt satıra indirir.
            //Console.WriteLine("****Yemek Kategorileri*****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("****Yemek Kategorileri*****");

            #endregion

            #region StringDeğişkenler
            //string
            //Değiken_türü değişken_adi;

            //string name;
            //name = "Aleyna";
            //Console.Write(name);

            //string customerName;
            //string customerSurname;
            //string customerEmail, district, city;
            //string customerPhone;

            //customerName = "Aleyna";
            //customerSurname = "Yıldız";
            //customerPhone = "+90 500 400 30 20";
            //customerEmail = "deneme@gmail.com";
            //district = "Kadıköy";
            //city = "İstanbul";

            //Console.WriteLine("---- Rezervasyon kartı -----");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine("Müşteri: "+ customerName + " " + customerSurname);
            //Console.WriteLine("iletişim: "+ customerPhone );
            //Console.WriteLine("Email adresi: " + customerEmail);
            //Console.WriteLine("Adres: "+ district +"/"+city);
            //Console.WriteLine("-----------------------------------");

            //customerName = "Ayşegül";
            //customerSurname = "Kaya";
            //customerPhone = "+90 400 300 20 20";
            //customerEmail = "test@gmail.com";
            //district = "Sapanca";
            //city = "Sakarya";

            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("iletişim: " + customerPhone);
            //Console.WriteLine("Email adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("-----------------------------------");




            #endregion

            #region IntDeğişkenler

            //int

            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("****Restoran Menü Fiyatı ****");
            Console.WriteLine();
            Console.WriteLine("- Hamburger Fiyatı: " + hamburgerPrice + "TL");
            Console.WriteLine("- Pizza fiyatı: " + pizzaPrice + "TL");
            Console.WriteLine("- Kızartma fiyatı: " + friesPrice + "TL");
            Console.WriteLine("- Kola fiyatı: " + cokePrice + "TL");
            Console.WriteLine("- Limanata fiyatı: " + lemonadePrice + "TL");
            Console.WriteLine("- Su Fiyatı: " + waterPrice + "TL");
            Console.WriteLine();
            Console.WriteLine("*******Restoran Menü Fiyatı *******");
            Console.WriteLine();

            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice = 0;
            int totalCokePrice = 0;
            int totalWaterPrice = 0;
            int totalFriesPrice = 0;
            int totalPizzaPrice = 0;
            int totalLemonadePrice = 0;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            //total price
            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokePrice * cokeCount;
            totalWaterPrice = waterPrice * waterCount;
            totalPizzaPrice = pizzaPrice * pizzaCount;
            totalLemonadePrice = lemonadePrice * lemonadeCount;
            totalFriesPrice = friesPrice * friesCount;


            Console.WriteLine("---------------------------");
            Console.WriteLine("Hamburger tutarı: " + totalHamburgerPrice + "TL");
            Console.WriteLine("Kola tutarı: " + totalCokePrice + "TL");
            Console.WriteLine("Su tutarı:" + totalWaterPrice + "TL");
            Console.WriteLine("Pizza tutarı:" + totalPizzaPrice + "TL");
            Console.WriteLine("Limonata tutarı:" + totalLemonadePrice + "TL");
            Console.WriteLine("Kızartma tutarı:" + totalFriesPrice + "TL");

            int totalPrice = totalCokePrice + totalFriesPrice + totalWaterPrice + totalHamburgerPrice + totalHamburgerPrice + totalPizzaPrice;
            Console.WriteLine("Toplam ödenecek tutar : " + totalPrice + "TL");
            #endregion

            Console.Read();//yazdığımız şeyi ekranda tutar.



        }
    }
}




