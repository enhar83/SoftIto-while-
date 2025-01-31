Console.Write("Çarpanlarını öğrenmek istediğiniz sayıyı giriniz:");
int sayi = int.Parse(Console.ReadLine());

int i = 1; //i'den başlatılmalı yoksa 0'a bölüm hatası gelir.
while (i <= sayi / 2) //sayı yarısından büyük olan sayılara zaten bölünemez.
{
    if (sayi % i == 0)
    {
        Console.WriteLine(i);
    }
    i++;
}
Console.WriteLine(sayi);//sayı,kendisine de bölündüğüden dolayı ekledim. döngü sayi/2 olduğundan dolayı bu değeri döngünün içinde basmaz
Console.ReadLine();
