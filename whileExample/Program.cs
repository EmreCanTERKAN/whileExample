Console.WriteLine("BİRİNCİ ÖRNEK!!");
int i = 0; while (i < 10) { i++; Console.WriteLine("Kendime İnanıyorum Biz Bu işi Yapacağız.!"); }
Console.WriteLine("____________________________");
Console.WriteLine("İKİNCİ ÖRNEK!!");
int x = 0; while (x < 20) { x++; Console.WriteLine(x); }
Console.WriteLine("____________________________");
Console.WriteLine("ÜÇÜNCÜ ÖRNEK!!");
int y = 0; while (y < 20) { y += 2; Console.WriteLine(y); }
Console.WriteLine("____________________________");
Console.WriteLine("DÖRDÜNCÜ ÖRNEK!!");
int toplam = 0; int z = 50; while (z <= 150) { toplam += z; z++; }
Console.WriteLine("Toplam =" + toplam);
Console.WriteLine("____________________________");
Console.WriteLine("BEŞİNCİ ÖRNEK!!");
int num = 0; int tekSayi = 0; int ciftSayi = 0;
while (num <= 120)
{
    if (num % 2 == 0)
    {
        ciftSayi += num;
    }
    else
        tekSayi += num;
    num++;

}
Console.WriteLine($"Cift sayı {ciftSayi}");
Console.WriteLine($"Tek sayı {tekSayi}");
