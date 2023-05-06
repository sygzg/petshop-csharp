using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petshop
{
    internal class Animalsinfo // hayvanların ortak olduğuu özellikleri düzenledik
    {
        public string _kuyruklukuyruksuz;
        public string _name;
        public string _turu;
        public string _rengi;
        public Animalsinfo(string _kuyruklukuyruksuz, string _name, string _turu, string _rengi)
        {
            this._kuyruklukuyruksuz = _kuyruklukuyruksuz;
            this._name = _name;
            this._turu = _turu;
            this._rengi = _rengi;
        }

        protected string Info() //ekrana nasıl yazılacağını, sıralamasını yaptık yani
        {
            string hayvanbilgileri = "-> Hayvanın Adı: " + _name + " -> Hayvanın Türü: " + _turu + " -> Hayvanın Rengi: " + _rengi + " -> Hayvanın Kuyruk Boyu: " + _kuyruklukuyruksuz ;
            return hayvanbilgileri;

        }
    }
}
