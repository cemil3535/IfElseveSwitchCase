// See https://aka.ms/new-console-template for more information


Console.WriteLine("Ruya Manavina Hos Geldiniz!");
// Meyve adi ve fiyatlarinin degerlerinin degiskenlere atanmasi
string elmaMeyve = "Elma";
string armutMeyve = "Armut";
string cilekMeyve = "Çilek";
string muzMeyve = "Muz";
string digerMeyveler = "Diger butun meyveler";

double elmaFiyat = 2;
double armutFiyat = 3;
double cilekFiyat = 2;
double muzFiyat = 3;
double digerMeyveFiyatlari = 4;

//Meyve fiyatlarinin ekrana yazdirilmasi
Console.WriteLine(elmaMeyve + " = " + elmaFiyat + " TL" );
Console.WriteLine(armutMeyve + " = " + armutFiyat + " TL");
Console.WriteLine(cilekMeyve + " = " + cilekFiyat + " TL");
Console.WriteLine(muzMeyve + " = " + cilekFiyat + " TL");
Console.WriteLine(digerMeyveler + " = " + digerMeyveFiyatlari + " TL");

//Kod arasi bosluk birakilmasi
Console.WriteLine();
Console.WriteLine();



Console.Write("Hangi Meyveyi Satin Almak Istiyorsunuz (Elma\\Armut\\Çilek\\Muz\\Diger: ");
string meyveAdi = Console.ReadLine();
string meyveAdiBuyukHarf = meyveAdi.ToUpper();//Kullanicidan alinan degerin buyuk harfe cevrilmesi

// Kullaicinin girdigi meyve adinin gore fiyatini ekrana yazdirilmasi if else yapisiyla yapildi

//if (meyveAdiBuyukHarf == "ELMA")
//{
//    Console.WriteLine("Sectiginiz meyvenin fiyati: " + elmaFiyat + " TL");
//}
//else if (meyveAdiBuyukHarf == "ARMUT")
//{
//    Console.WriteLine("Sectiginiz meyvenin fiyati: " + armutFiyat + " TL");
//}
//else if (meyveAdiBuyukHarf == "ÇİLEK")
//{
//    Console.WriteLine("Sectiginiz meyvenin fiyati: " + cilekFiyat + " TL");
//}
//else if (meyveAdiBuyukHarf == "MUZ")
//{
//    Console.WriteLine("Sectiginiz meyvenin fiyati: " + muzFiyat + " TL");
//}
//else
//{
//    Console.WriteLine("Sectiginiz meyvenin fiyati: " + digerMeyveFiyatlari + " TL");
//}


//switchCase yapisiyla kullaicinin girdigi meyve adinin gore fiyatini ekrana yazdirilmasi

switch (meyveAdiBuyukHarf)
{
    case "ELMA":
        Console.WriteLine("Sectiginiz meyvenin fiyati: " + elmaFiyat + " TL");
        break;

    case "ARMUT":
        Console.WriteLine("Sectiginiz meyvenin fiyati: " + armutFiyat + " TL");
        break;

    case "ÇİLEK":
        Console.WriteLine("Sectiginiz meyvenin fiyati: " + cilekFiyat + " TL");
        break;

    case "MUZ":
        Console.WriteLine("Sectiginiz meyvenin fiyati: " + muzFiyat + " TL");
        break;

    default:
        Console.WriteLine("Sectiginiz meyvenin fiyati: " + digerMeyveFiyatlari + " TL");
        break;
}
// swichcase yapisiyla cozmek daha dogru. Cunku kullanicidan alinan girdiyi alip konttol ediliyor. Bir degiskenin durumuna gore kontrol edilmesinde switchcase yapisi kullaniliyor.


