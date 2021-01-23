using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemoMethot
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Yen müşteri sisteme eklendi" +"\n"+"Id : "+ musteri.Id + "\n" +"Ad : "+ musteri.Adi + "\n" + "Soyad : " + musteri.Soyadi + "\n" + "Yaş : " + musteri.Yasi);
        }



        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("Müşteri sistemden silindi"+ "\n" + "Id : " + musteri.Id+"\n"+ "Ad : " + musteri.Adi+"\n"+ "Soyad : " + musteri.Soyadi+"\n"+ "Yaş : " + musteri.Yasi);
        }
    }
}
