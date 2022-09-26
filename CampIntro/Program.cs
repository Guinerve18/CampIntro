// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System.Net.Mail;

Console.WriteLine("Hello There!");
Console.WriteLine("General Kenobi");

//type safety - tip güvenliği
string kategoriEtiketi = "Kategori";
Console.WriteLine(kategoriEtiketi);

int jediSayısı = 10000;
double numberPi = 3.14; //double ondalıklı sayıları yazar. Python'daki float tipi.

Console.WriteLine(jediSayısı);
Console.WriteLine(numberPi);

string RotsObiWan = "You are my brother Anakin. I loved you.";
string RotsAnakin = "I HATE YOU!!!";

Console.WriteLine(RotsObiWan);
Console.WriteLine(RotsAnakin);

int evrimAgaciUyeSayisi = 2000000;
double ondalıkdegeri = 26.6465;

Console.WriteLine(evrimAgaciUyeSayisi);
Console.WriteLine(ondalıkdegeri);

bool sistemeGirisYapmisMi = true; //ya da false

if (sistemeGirisYapmisMi == true)
{
    Console.WriteLine("Kullancı Profil Butonu");
}
else
{
    Console.WriteLine("Kullanıcı Giriş butonu");
}

int sayiDegeri = 50819;

if (sayiDegeri > 50819)
{
    Console.WriteLine("Girdiğiniz Sayı Fazla Büyük!");
}
else if (sayiDegeri == 50819)
{
    Console.WriteLine("Doğru Sayıyı Girdiniz! Tebrikler!!!");
}
else
{
    Console.WriteLine("Girdiğiniz Sayı Çok Küçük!");
}

