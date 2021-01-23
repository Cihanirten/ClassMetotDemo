using System;

namespace ClassDemoMethot
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1234;
            musteri1.Adi = "can";
            musteri1.Soyadi = "irten";
            musteri1.Yasi = 22;




            Musteri musteri2 = new Musteri();
            musteri2.Id = 1235;
            musteri2.Adi = "şiir ali";
            musteri2.Soyadi = "irten";
            musteri2.Yasi = 19;


            Musteri musteri3 = new Musteri();
            musteri3.Id = 1236;
            musteri3.Adi = "ferhat";
            musteri3.Soyadi = "irten";
            musteri3.Yasi = 22;

            Musteri musteri4 = new Musteri();
            musteri4.Id = 1237;
            musteri4.Adi = "cemile";
            musteri4.Soyadi = "irten";
            musteri4.Yasi= 21;




            MusteriManager musteriManager = new MusteriManager();

            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriEkle(musteri3);
            musteriManager.MusteriEkle(musteri4);
            musteriManager.MusteriSil(musteri1);






        }
    }
}
