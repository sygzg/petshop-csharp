using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petshop
{

    internal class Birds : Animalsinfo, Ianimals //animalsinfo classı ile Ianimals interfaceini kullabilmek için atama yaptık 
    {
        public string _konusan; // yeni bir özellik ekledik

        public Birds(string _kuyruklukuyruksuz, string _name, string _turu, string _rengi, string _konusan) : base( _kuyruklukuyruksuz, _name, _turu, _rengi) //ana özellikleri ve yeni eklediğimiz özelliği tanımladık kullaıma açtık
        {
           this._konusan = _konusan; // this sınıfın geçerli örneğine başvurur ve bir uzantı yönteminin ilk parametresinin değiştiricisi olarak da kullanılır 

        }
        

        public string Bilgiler()//bilgiler methodu oluşturuduk ve inteface'e atadık böylece ekrana yazdırabileceğimiz bir metin oluşturduk
        {
            string Bilgi = Info();
            Bilgi += " -> Konuşuyor mu Yoksa Ötüyor mu: " + _konusan; // ekrana koşuan parametresini de yazdırmak için ekledik
            return Bilgi;
        }

    }
}
