using System;
namespace OOP2
{

    //Indivisual
    class GercekMusteri:Musteri  // :Musteri demek miras almak inheritance 
    {
        public string TcNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
    }
}
