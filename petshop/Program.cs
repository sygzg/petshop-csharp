using petshop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace petshop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animalcase animalcase = new Animalcase(); // animalcase classından aldığımız bağımsız değişkenleri ortak parametresiz oluşturucuya sahip olması gerektiğini belirtir

            Console.WriteLine("Sisteme Hoşgeldiniz"); // sisteme hoşgeldiniz diye yazdırdım
            
            Cats ismi1 = new Cats("Kuyruklu", "Boncuk", "Britsh", "Tüylü", "Miyav", "Gri"); //boncuk adlı kedinin künyesi 
            Cats ismi2 = new Cats("Kuyruksuz", "Love", "Manx", "Tüylü", "Miyav", "Turuncu ve kahverengi"); //love adlı kedinin künyesi 
            Birds adi1 = new Birds("Kuyruklu", "Maviş", "Papağan", "Konuşan", "Kırmızı ve Yeşil"); //maviş adlı kuşun künyesi 
            Birds adi2 = new Birds("Kuyruklu", "Şans", "Muhabbet Kuşu", "Konuşan", "Mavi beyaz"); // şans adlı kuşun künyesi
            Dogs isim1 = new Dogs("Kuyruksuz", "Kömür", "Golden", "Hav hav", "Uzun kulaklı", "Altın rengi"); // kömür adlı köpeğin künyesi
            animalcase.Add(ismi1); // ismi1 yani boncuğu ekledik
            animalcase.Add(ismi2); //ismi2 yani love'ı ekledik
            animalcase.Add(adi1); // adi1 mavişi ekledik
            animalcase.Add(adi2);//adi2 şansı ekledi
            animalcase.Add(isim1);// isim1 kömürü ekledik
            animalcase.WriteAllInfo(); //animalcase classına bağlanarak writeallinfodaki kod bloğunu çalıştırdık
            Console.ReadKey();
        }



    }
}

