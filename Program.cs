//
// var kdv_orani = 1.18;
// var urunA = 5000;
// var urunB = 6000;
// var urunC = 7000;
// var urunD = 5500;

// Console.WriteLine(urunA *  kdv_orani); //urunA
// Console.WriteLine(urunB *  kdv_orani); //urunB
// Console.WriteLine(urunC *  kdv_orani); //urunC
// Console.WriteLine(urunD *  kdv_orani); //urunD

// var sayi = 20;
// var urunAdi = "Samsung S23";

// Console.WriteLine(sayi);
// Console.WriteLine(urunAdi);

// //Uygulama 1
// var ogrenciAdi = "Ahmet";
// var ogrenciSoyadi = "Yılmaz";
// var ogrenciAdSoyad = ogrenciAdi + " " + ogrenciSoyadi;
// var ogrenciNo = 123456;
// var ogrenciCinsiyet = 'E';
// var ogrenciTcNo = 12345678901;
// var ögrenciDogumYili = 2000;
// var ogrenciAdres = "İstanbul";
// var ogrenciYas = 2026 - ögrenciDogumYili;

// Console.WriteLine(ogrenciAdSoyad);
// Console.WriteLine(ogrenciYas);
// Console.WriteLine(ogrenciNo);
// Console.WriteLine(ogrenciCinsiyet);
// Console.WriteLine(ogrenciTcNo);
// Console.WriteLine(ogrenciAdres);

// //Uygulama 2
// var sayi1 = 50;
// var sayi2 = 60.5;
// var sayi3 = 356.45;
// var toplam = sayi1 + sayi2 + sayi3;
// Console.WriteLine(toplam);
//

// //veri tipi dönüşümü neden önemli
// Console.Write("1. sayı: ");
// var sayi1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("2. sayı: ");
// var sayi2 = Convert.ToInt32(Console.ReadLine());

// var toplam = sayi1 + sayi2; // int + int = int
// Console.WriteLine("Toplam: " + toplam);

// int a = 10;
// long b = a;

// long d = 20;
// int e = (int)d; // long -> int dönüşümü

// double f = 20.5;
// float g = (float)f; // double -> float dönüşümü

// double h = 10.5;
// int i = (int)h; // double -> int dönüşümü
// Console.WriteLine(i);

// int x = 10;
// string y = x.ToString(); // int -> string dönüşümü
// Console.WriteLine(y);

//nullable types
// int? sayi = null; // nullable int
// Console.WriteLine(sayi.HasValue); // false
// Console.WriteLine(sayi.GetValueOrDefault()); // 0

// Console.Write("Adı: ");
// string? ad = Console.ReadLine();
// Console.Write("Soyad: ");
// string? soyad = Console.ReadLine();
// Console.Write("Yaşı: ");
// string? yas = Console.ReadLine();

// string mesaj = ad + " " + soyad + " isimli kişi " + yas + " yaşındadır.";
// string mesaj2 = $"{ad} {soyad} isimli kişi {yas} yaşındadır."; // string interpolation

// Console.WriteLine(mesaj2);

// string mes = "Ayşenur Öz isimli kişi 22 yaşındadır.";

// var sonuc = mes.ToLower(); // küçük harf
// Console.WriteLine(sonuc);

// string kursAdi = ".NET 7 ile C# Programlama Dili";

// var kac_karakter = kursAdi.Length; // karakter sayısı
// Console.WriteLine(kac_karakter);

// var kucuk_harf = kursAdi.ToLower();
// Console.WriteLine(kucuk_harf);

// var nokta = kursAdi.StartsWith('.');
// Console.WriteLine("String . ile başlıyor mu :" + nokta);

// var c_nerede = kursAdi.IndexOf("C#");
// Console.WriteLine(c_nerede);

// var c_sharp_var_mi = kursAdi.Contains("C#");
// Console.WriteLine("C# bulunuyor mu :" + c_sharp_var_mi);

// var degistir = kursAdi.Replace("Dili","Dersleri");
// Console.WriteLine(degistir);

// var simdi = DateTime.Now;

// Console.WriteLine(simdi);
// Console.WriteLine(simdi.Year);
// Console.WriteLine(simdi.Month);
// Console.WriteLine(simdi.Day);
// Console.WriteLine(simdi.DayOfWeek);
// Console.WriteLine(simdi.Hour);
// Console.WriteLine(simdi.Minute);
// Console.WriteLine(simdi.Second);

// DateTime dt = new DateTime(2018, 6, 10, 14, 35, 45);
// Console.WriteLine(dt);

// DateTime dt2 = dt.AddYears(1);
// Console.WriteLine(dt2.Year);

// var kursAdi = ".net 7 ile c# programlama dersleri".Split();

// string[] isimler = new string[5];
// isimler[0] = "Ahmet";
// isimler[1] = "Ali";
// isimler[2] = "Canan";
// isimler[3] = "Çınar";
// isimler[4] = "Esra";

// string[] isimler = {"Ahmet", "Ali", "Canan", "Çınar", "Esra"};

// int[] numaralar = new int[5];

// numaralar[0] = 100;
// numaralar[1] = 200;
// numaralar[2] = 300;
// numaralar[3] = 400;
// numaralar[4] = 500;

// Console.WriteLine($"{numaralar[0]} numaralı öğrencinin adı {isimler[0]}");
// Console.WriteLine($"{numaralar[1]} numaralı öğrencinin adı {isimler[1]}");
// Console.WriteLine($"{numaralar[2]} numaralı öğrencinin adı {isimler[2]}");

//  string[] sehirler = {"istanbul", "sakarya", "kocaeli"};
//  int[] plakalar = {34, 54, 41};

//  sehirler[0] = "sakarya";
//  sehirler.SetValue("sakarya",1);

//  Array.Sort(sehirler);
//  Array.Sort(plakalar);

//  Console.WriteLine(sehirler[0]);
//  Console.WriteLine(sehirler.GetValue(1));
//  Console.WriteLine(sehirler.Length);
//  Console.WriteLine(Array.IndexOf(sehirler,"rize"));
//  Console.WriteLine(plakalar.GetValue(1));

//  Array.Reverse(plakalar);
//  Console.WriteLine(plakalar[0]);

// string[] sehirler = ["zonguldak","rize","kocaeli","istanbul","ankara"];


// foreach(var i in sehirler[2..]) {
//     Console.WriteLine(i);
// }

// string il = "Kocaeli";

// Console.WriteLine(il[..5]);

// string[] ogrenciler = new string[3];
// int[] notlar = new int[3];

// Console.Write("1. öğrencinin adı:");
// ogrenciler[0] = Console.ReadLine() ?? "";
// Console.Write("1. öğrencinin notu:");
// notlar[0] = Convert.ToInt32(Console.ReadLine());

// Console.Write("2. öğrencinin adı:");
// ogrenciler[1] = Console.ReadLine() ?? "";
// Console.Write("2. öğrencinin notu:");
// notlar[1] = Convert.ToInt32(Console.ReadLine());

// Console.Write("3. öğrencinin adı:");
// ogrenciler[2] = Console.ReadLine() ?? "";
// Console.Write("3. öğrencinin notu:");
// notlar[2] = Convert.ToInt32(Console.ReadLine());

// foreach(var ogrenci in ogrenciler)
// {
//     Console.WriteLine(ogrenci);
// }
// foreach(var not in notlar)
// {
//     Console.WriteLine(not);
// }

// Console.WriteLine("öğrenciler dizisinin eleman sayısı: " + ogrenciler.Length);

// var not1 = notlar[0];
// var not2 = notlar[1];
// var not3 = notlar[2];

// var ortalama = (not1 + not2 + not3)/3;
// Console.WriteLine(ortalama);

// string[] ogrenciler = {"Ali","Ahmet","Canan"};
// int[,] notlar = new int[3,3];

// //ali
// notlar[0,0] = 50;
// notlar[0,1] = 60;
// notlar[0,2] = 70;

// //ahmet
// notlar[1,0] = 60;
// notlar[1,1] = 70;
// notlar[1,2] = 80;

// //canan
// notlar[2,0] = 50;
// notlar[2,1] = 90;
// notlar[2,2] = 20;

// var ortalama_1 = (notlar[0,0] + notlar[0,1] + notlar[0,2]) / 3;
// var ortalama_2 = (notlar[1,0] + notlar[1,1] + notlar[1,2]) / 3;
// var ortalama_3 = (notlar[2,0] + notlar[2,1] + notlar[2,2]) / 3;

// Console.WriteLine($"{ogrenciler[0]} isimli öğrencinin not ortalaması: {ortalama_1}");
// Console.WriteLine($"{ogrenciler[1]} isimli öğrencinin not ortalaması: {ortalama_2}");
// Console.WriteLine($"{ogrenciler[2]} isimli öğrencinin not ortalaması: {ortalama_3}");

// int[] x = {10,20};
// int[] y = x;

// Console.WriteLine(x[0]);
// Console.WriteLine(y[0]);

// x[0] = 20;

// Console.WriteLine(x[0]);
// Console.WriteLine(y[0]);

// var a = 10;
// var b = 5;
// var c = 20;

// var sonuc = (c - a) * b;
// Console.WriteLine(sonuc);

// int? a = null;
// int b = 20;
// var sonuc = (a ?? 0) + b;
// Console.WriteLine(sonuc);

// var a = 10;
// var b = 20;
// a=b--;
// Console.WriteLine(a);
// Console.WriteLine(b);

// Console.Write("çift mi tek mi kontrolü yapabilmek için bir sayı giriniz:");
// int? sayi = int.Parse(Console.ReadLine() ?? "0");
// if(sayi % 2 == 0)
// {
//     Console.WriteLine("sayı çifttir.");
// }
// else
// {
//     Console.WriteLine("sayı tektir.");
// }

// math
// double sonuc;

// sonuc = Math.Pow(2,3);
// Console.WriteLine(sonuc);

// Console.Write("yaşınızı giriniz:");
// int yas = Convert.ToInt32(Console.ReadLine() ?? "0");

// var sonuc = (yas >= 18) ? "Oy kullanabilir":"Oy kullanamaz";
// Console.WriteLine("oy kullanabilme durumu:" + sonuc);

// Console.Write("bir sayı giriniz:");
// int sayi = Convert.ToInt32(Console.ReadLine() ?? "0");

// var isaret = (sayi>= 0) ? "sayı pozitiftir" : "sayı negatiftir";
// Console.WriteLine(isaret);

// Console.Write("bir sayı giriniz:");
// int sayi1 = Convert.ToInt32(Console.ReadLine() ?? "0");

// var tek_cift = (sayi1 % 2 == 0) ? "sayı çifttir" : "sayı tektir";
// Console.WriteLine(tek_cift);


// var yas = 14;
// bool veli_izni = true;


// bool yas_kontrol = (yas >= 18);
// bool veli_kontrol = (veli_izni);
// var calisma_durumu = (yas_kontrol || veli_kontrol);

// Console.WriteLine("bir işte çalışabilir mi :" + calisma_durumu);

// Console.WriteLine("notunuzu giriniz: ");
// var not = Convert.ToInt32(Console.ReadLine() ?? "0");

// var gecti_kaldi = (not > 55 && not <= 100);
// Console.WriteLine("dersten geçip kalma durumu :" + gecti_kaldi);

// int ortalama = 65;
// int zayif = 1;

// var sonuc = (ortalama >= 70) ? ((zayif == 0 ) ? "teşekkür alabilir" : "zayıfınızın olmaması gerekiyor"): "notunuz en az 70 olamlıdır.";
// Console.WriteLine(sonuc);

// var egitim = "lisans";
// bool sigara_icme = true;

// var sonuc = ((egitim == "lisans" || egitim == "onlisans") && (!sigara_icme));
// Console.WriteLine("işe girebilme durumu: " + sonuc);

// string email = "info@aysenuroz.com";
// string username = "aysenuroz";
// string sifre ="12345";

// var sonuc = ((email ==  "info@aysenuroz.com") || (username == "aysenuroz")) && sifre == "12345" ? "başarılı":"başarısız";
// Console.WriteLine(sonuc);

// string[] takimlar = {"galatasaray","beşiktaş","fenerbahçe","trabzon","sakarya"};

// var rnd = new Random();

// int sayi = rnd.Next(0,5);

// Console.WriteLine(sayi);
// Console.WriteLine(takimlar[sayi]);




// Console.WriteLine("1 - toplama");
// Console.WriteLine("2 - çıkarma");
// Console.WriteLine("3 - bölme");
// Console.WriteLine("4- çarpma");
// Console.WriteLine("Yapmak istediğiniz işlemi seçin: ");
// var islem = Convert.ToInt32(Console.ReadLine() ?? "yanlış ifade girildi.");

// Console.Write("ilk sayıyı girin:");
// int ilk_sayi = Convert.ToInt32(Console.ReadLine() ?? "0");

// Console.Write("ikinci sayıyı girin:");
// int ikinci_sayi = Convert.ToInt32(Console.ReadLine() ?? "0");

// int res = 0;

// if (islem == 1)
// {
//     res = ilk_sayi + ikinci_sayi;
//     Console.WriteLine("işlem sonucu :" + res);

// }
// else if ( islem == 2)
// {
//     res = ilk_sayi - ikinci_sayi;    
//     Console.WriteLine("işlem sonucu :" + res);

// }
// else if( islem == 3)
// {
//     res = ilk_sayi / ikinci_sayi;
//     Console.WriteLine("işlem sonucu :" + res);

// }
// else if( islem == 4)
// {
//     res = ilk_sayi * ikinci_sayi;
//     Console.WriteLine("işlem sonucu :" + res);
// }else
// {
//     Console.WriteLine("İşlem için gerekli giriş sağlanmadı. Yeniden deneyiniz.");
// }



// Console.Write("ilk yazılı notunuzu giriniz:");
// var yazili_1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("ikinci yazılı notunuzu giriniz:");
// var yazili_2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("sözlü notunuzu giriniz:");
// var sozlu = Convert.ToInt32(Console.ReadLine());

// var sonuc = (yazili_1 + yazili_2 + sozlu) / 3;

// if (sonuc > 0 && sonuc < 25)
// {
//     Console.WriteLine("0");
// }
// else if(sonuc >= 25 && sonuc < 45)
// {
//     Console.WriteLine("1");
// }
// else if(sonuc >= 45 && sonuc < 55)
// {
//     Console.WriteLine("3");
// }
// else if(sonuc >= 55 && sonuc < 70)
// {
//     Console.WriteLine("4");
// }
// else if(sonuc >= 70 && sonuc < 85)
// {
//     Console.WriteLine("5");
// }
// else if(sonuc >= 85 && sonuc <= 100)
// {
//     Console.WriteLine("6");
// }
// else
// {
//     Console.WriteLine("hatalı bilgi girişi yapıldı");
// }


// Console.Write("ilk sayıyı giriniz:");
// var sayi1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("ikinci sayıyı giriniz:");
// var sayi2 = Convert.ToInt32(Console.ReadLine());

// int en_buyuk = 0;
// if( sayi1 > sayi2)
// {
//     en_buyuk = sayi1;
//     Console.WriteLine("en büyük sayı : " + en_buyuk);
// }
// else if (sayi1 == sayi2)
// {
//     Console.WriteLine("sayılar birbirine eşit");
// }
// else
// {
//     en_buyuk = sayi2;
//     Console.WriteLine("en büyük sayı : " + en_buyuk);
// }

// for(var i = 1; i <= 10; i++)
// {
//     Console.WriteLine(i);
// }

// var toplam = 0;
// for ( var i = 0; i <= 100; i++)
// {
//     toplam += i;
// }

// Console.WriteLine(toplam);

// Console.WriteLine("ilk sayıyı giriniz:");
// var ilkSayi = Convert.ToInt32(Console.ReadLine() ?? "");

// Console.WriteLine("ikinci sayıyı giriniz:");
// var ikinciSayi = Convert.ToInt32(Console.ReadLine() ?? "");

// var res = 0;
// for (var i = ilkSayi; i < ikinciSayi; i++)
// {
//     res += i;
// }
// Console.WriteLine("iki sayı arasındaki sayıların toplamı: " + res);

// string[] isim_dizisi = ["ali","ahmet","can","yelda","seda"];

// for(var i = 0; i < isim_dizisi.Length; i++)
// {
//     Console.WriteLine(isim_dizisi[i]);
// }

// int[] sayi_dizi = [1, 3, 4, 34, 41, 56, 89];

// int[] ucun_kati = [];

// for(var i = 0; i < sayi_dizi.Length; i++)
// {
//     if(sayi_dizi[i] % 3 == 0)
//     {
//         Console.WriteLine(sayi_dizi[i]);
//     }
// }

// var rnd = new Random();
// int tutulan = rnd.Next(1, 100);
// int hak = 3;

// while (hak > 0)
// {
//     Console.WriteLine("sayı: ");
//     int sayi = Convert.ToInt32(Console.ReadLine());

//     hak--;

//     if (sayi == tutulan)
//     {
//         Console.WriteLine("Tebrikler bildiniz.");
//         break;
//     }
//     else
//     {
//         if (hak == 0)
//         {
//             Console.WriteLine("oyun bitti");
//             break;
//         }
//         if (tutulan > sayi)
//         {
//             Console.WriteLine("yukarı");
//         }
//         else
//         {
//             Console.WriteLine("aşağı");
//         }
//     }
// }
// Console.WriteLine(tutulan);

// Console.WriteLine("adet: ");
// int adet = Convert.ToInt32(Console.ReadLine());

// string[] urunler = new string[adet];

// int i = 0;

// do
// {
//     Console.WriteLine("ürün adı: ");
//     urunler[i] = Console.ReadLine() ?? "";

//     i++;
// } while (adet != i);

// Console.WriteLine("ürünler listeleniyor...");

// for (var a = 0; a < urunler.Length; a++)
// {
//     Console.WriteLine(urunler[a]);
// }

string ad = "Ahmet";

foreach(var harf in ad)
{
    Console.WriteLine(harf);
}

int[] sayilar = {10, 20, 30, 40, 50};

foreach(var sayi in sayilar)
{
    if(sayi == 20)
        break;
        Console.WriteLine(sayi);
}