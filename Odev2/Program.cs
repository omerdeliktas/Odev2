using System;

class BankaHesabi //Sınıf Oluşturdum. Banka durumu olduğu içi erişim private
{
    private string hesapSahibi;
    private double bakiye;

    public BankaHesabi(string sahipAdi, double baslangicBakiye) //Parametreli Constructor
    {
        hesapSahibi = sahipAdi;
        bakiye = baslangicBakiye;
    }

    public double BakiyeSorgula() //methotlar tanımladım
    {
        return bakiye;
    }

    public void ParaYatir(double miktar)
    {
        if (miktar > 0)
        {
            bakiye += miktar;
            Console.WriteLine($"{hesapSahibi} adlı hesaba {miktar} TL yatırıldı. Yeni bakiye: {bakiye} TL");
        }
        else
        {
            Console.WriteLine("Geçersiz işlem: Yatırılacak miktar 0'dan büyük olmalıdır.");
        }
    }

    public void ParaCek(double miktar)
    {
        if (miktar > 0 && miktar <= bakiye)
        {
            bakiye -= miktar;
            Console.WriteLine($"{hesapSahibi} adlı hesaptan {miktar} TL çekildi. Yeni bakiye: {bakiye} TL");
        }
        else if (miktar <= 0)
        {
            Console.WriteLine("Geçersiz işlem: Çekilecek miktar 0'dan büyük olmalıdır.");
        }
        else
        {
            Console.WriteLine("Yetersiz bakiye. İşlem gerçekleştirilemedi.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        BankaHesabi hesap = new BankaHesabi("Omer De", 2000);

        
        Console.WriteLine($"Mevcut Bakiye: {hesap.BakiyeSorgula()}");

        hesap.ParaYatir(1500);
        hesap.ParaCek(1200);
        hesap.ParaCek(1500);

        Console.ReadLine();
    }
}
