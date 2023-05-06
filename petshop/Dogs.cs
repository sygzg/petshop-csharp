using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petshop
{
    internal class Dogs : Animalsinfo, Ianimals
    {

        private string _havlayan;  // yeni bir özellik ekledik 
        public string _kisakulakuzunkulak;  // yeni bir özellik ekledik

        public Dogs(string _kuyruklukuyruksuz, string _name, string _turu, string _rengi, string _havlayan, string _kisakulakuzunkulak) : base(_kuyruklukuyruksuz, _name, _turu, _rengi)//ana özellikleri ve yeni eklediğimiz özelliği tanımladık ve kullanıma açtık
        {
            this._havlayan = _havlayan;  // this sınıfın geçerli örneğine başvurur ve bir uzantı yönteminin ilk parametresinin değiştiricisi olarak da kullanılır 
            this._kisakulakuzunkulak = _kisakulakuzunkulak;

        }
        
        public string Bilgiler()//bilgiler methodu oluşturuduk ve inteface'e atadık böylece ekrana yazdırabileceğimiz bir metin oluşturduk
        {
            string Bilgi = Info();
            Bilgi += " -> Kulak Cinsi: " + _kisakulakuzunkulak + "-> Sesi:" + _havlayan; // ekrana kulak cinsi ve iletişim yönetmini yazdık
            return Bilgi;
        }
    }
}
