Console.Write("Hangi sayıya kadar olan asal sayıları görmek istersiniz?:");
int sayi = int.Parse(Console.ReadLine());

int i = 2, j = 2;//0 olarak tanımlama.0'a bölüm kısmında hata almamak için
string yazi = "";

while (i <= sayi)
{
    bool is_prime = true;
    while (j < i)
    {
        if (i % j == 0)
        {
            is_prime = false;
            break;
        }
        j++;
    }
    if (is_prime)
    {
        yazi = yazi + i + " ";
    }
    i++;
    j = 2;
}
Console.Write($"{sayi} sayısına kadar olan asal sayılar:\n{yazi}");
Console.ReadLine();
