using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petshop
{
    internal class Cats : Animalsinfo, Ianimals
    {
        private string _miyavlayan;//yeni bir özellike ekledik
        public string _tuylutuysuz;//yeni bir özellik ekledik

        public Cats(string _kuyruklukuyruksuz, string _name, string _turu, string _rengi, string _miyavlayan, string _tuylutuysuz) : base(_kuyruklukuyruksuz, _name, _turu, _rengi) //ana özellikleri ve yeni eklediğimiz özelliği tanımladık kullaıma açtık
        {
            this._miyavlayan = _miyavlayan; // this sınıfın geçerli örneğine başvurur ve bir uzantı yönteminin ilk parametresinin değiştiricisi olarak da kullanılır
            this._tuylutuysuz = _tuylutuysuz; // this sınıfın geçerli örneğine başvurur ve bir uzantı yönteminin ilk parametresinin değiştiricisi olarak da kullanılır


        }
  
        public string Bilgiler() //bilgiler methodu oluşturuduk ve inteface'e atadık böylece ekrana yazdırabileceğimiz bir metin oluşturduk
        {
            string Bilgi = Info();
            Bilgi += " -> Tüy: " + _tuylutuysuz + " -> Sesi:" + _miyavlayan; // ekrana sesi ve tüy parametresini de yazdırmak için ekledik
            return Bilgi;
        }
    }
}
