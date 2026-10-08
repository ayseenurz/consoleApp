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

int[] x = {10,20};
int[] y = x;

Console.WriteLine(x[0]);
Console.WriteLine(y[0]);

x[0] = 20;

Console.WriteLine(x[0]);
Console.WriteLine(y[0]);
