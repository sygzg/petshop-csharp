using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petshop
{
    internal sealed class Animalcase // animalcase dosyası arşivimize künye ekleyebilmek için açtık
    {
        List<Cats> Kediler = new List<Cats>(); // kediler adlı liste oluşturduk  
        List<Dogs> Kopekler = new List<Dogs>(); //  köpekler adlı liste olşuturduk 
        List<Birds> Kuslar = new List<Birds>(); // kuşlar adlı liste oluşturduk
        public Animalcase(List<Cats> kediler, List<Dogs> kopekler, List<Birds> kuslar) //atama yapıldı
        {
            Kediler = kediler;
            Kopekler = kopekler;
            Kuslar = kuslar;
        }

        public Animalcase()
        {

        }
    
        public void Add(Cats kediler) //cats'e yeni bir ekleme yapabilmek için oluşturduk 
        {
            Kediler.Add(kediler);

        }
        public void Add(Dogs kopekler) //dogs'a yeni bir ekleme yapabilmek için yaptık
        {
            Kopekler.Add(kopekler);


        }
        public void Add(Birds kuslar) // birds'e yeni bir ekleme yapabilmek için yaptık
        {
            Kuslar.Add(kuslar);
       

        }


        public void WriteAllInfo() // tüm bilgileri yazdır diyebilmek için oluşturudğumuz bir kod bloğu 
        {
            foreach (var item in Kediler)
            {
                Console.WriteLine(item.Bilgiler());
            }
            foreach (var item in Kopekler)
            {
                Console.WriteLine(item.Bilgiler());
            }
            foreach (var item in Kuslar)
            {
                Console.WriteLine(item.Bilgiler());
            }
        }
    }
}
