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
int? sayi = null; // nullable int
Console.WriteLine(sayi.HasValue); // false
Console.WriteLine(sayi.GetValueOrDefault()); // 0