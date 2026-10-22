namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Merhaba BTK");

            // Ogrenci ogr1 = new Ogrenci() { OgrenciNo = "100", AdSoyad = "Ayşenur Öz", Sube = "6/A" };
            // Ogrenci ogr2 = new Ogrenci() { OgrenciNo = "200", AdSoyad = "Ahmet Öz", Sube = "5/A" };
            // Ogrenci ogr3 = new Ogrenci() { OgrenciNo = "300", AdSoyad = "Beyza Harbi", Sube = "6/B" };

            // Ogrenci[] ogrenciler = new Ogrenci[3] { ogr1, ogr2, ogr3 };

            // foreach(var ogrenci in ogrenciler)
            // {
            //     ogrenci.BilgileriYazdir();
            // }
            // var soru1 = new Soru(1, "Hangisi programlama dili değildir ?", new string[4] { "Python", "C#", "Java", "HTML" }, "HTML");
            // var soru2 = new Soru(2, "Hangisi en popüler programlama dilidir ?", new string[4] { "Python", "C#", "Java", "HTML" }, "C#");
            // var soru3 = new Soru(3, "Hangisi web programlama platformu değildir ?", new string[4] { "Django", "Asp.net", "Spring", "Python" }, "Python");

            // var soru4 = new Soru(10);
            // var sorular = new Soru[] { soru1, soru2, soru3 };

            // foreach (var soru in sorular)
            // {
            //     Console.WriteLine(soru.SoruMetni);
            //     foreach (var secenek in soru.Secenekler)
            //     {
            //         Console.WriteLine(secenek);
            //     }
            //     Console.Write("cevabınız: ");
            //     var cevap = Console.ReadLine();

            //     if (soru.cevapKontrol(cevap))
            //     {
            //         Console.WriteLine("doğru");
            //     }
            //     else
            //     {
            //         Console.WriteLine("yanlış");
            //     }
            // }
            // Console.WriteLine(soru1.SoruYazdir());
            // Console.WriteLine(soru1.cevapKontrol("html"));

            // Console.WriteLine(soru2.SoruYazdir());
            // Console.WriteLine(soru2.cevapKontrol("c#"));

            // Console.WriteLine(soru3.SoruYazdir());
            // Console.WriteLine(soru3.cevapKontrol("python"));
            var sonuc = HelperMethods.KarakterDuzelt("ölçme ve değerlerdirme");
            Console.WriteLine(sonuc);
        }
    }
    // class Ogrenci
    // {
    //     public string OgrenciNo { get; set; }
    //     public string AdSoyad { get; set; }
    //     public string Sube { get; set; }

    //     public void BilgileriYazdir()
    //     {
    //         Console.WriteLine($"{this.OgrenciNo} numaralı öğrencinin adı {this.AdSoyad} ve şubresi {this.Sube}");

    //     }
    // }
    // class Soru
    // {
    //     // public Soru()
    //     // {
    //     //     Console.WriteLine("constructer 1");
    //     //     this.SoruId = (new Random()).Next(11111, 99999);
    //     // }
    //     // public Soru(int soruId)
    //     // {
    //     //     Console.WriteLine("constructer 2");
    //     //     this.SoruId = soruId;
    //     // }
    //     public Soru(int soruId, string soruMetni, string[] secenekler, string cevap)
    //     {
    //         this.SoruId = soruId;
    //         this.SoruMetni = soruMetni;
    //         this.Secenekler = secenekler;
    //         this.Cevap = cevap;
    //     }
    //     private int SoruId { get; set; }
    //     private string SoruMetni { get; set; }
    //     private string[] Secenekler { get; set; }
    //     private string Cevap { get; set; }
    //     public string SoruYazdir()
    //     {
    //         string soru = "";
    //         soru += this.SoruMetni + "\n";
    //         foreach (var secenek in this.Secenekler)
    //         {
    //             soru += secenek + "\n";
    //         }
    //         return soru;
    //     }
    //     public bool cevapKontrol(string cevap)
    //     {
    //         return this.Cevap.ToLower() == cevap.ToLower();
    //     }
    // }
    class HelperMethods
    {
        public static string KarakterDuzelt(string str)
        {
            return
                str.Replace("ö","o")
                .Replace("ü","u")
                .Replace("ı","i")
                .Replace("ğ","g")
                .Replace("ç","c")
                .Replace(" ","-");
        }
    }
}


