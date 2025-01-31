//1 1 2 3 5 8 13 21 34 ...

Console.Write("Kaçıncı adıma kadar olan fibonacci serisini görmek istersiniz:");
int adim = int.Parse(Console.ReadLine());

int num1 = 1, num2 = 1, toplam = 0, i = 1;
while (i <= adim + 2) // adim+2 olarak koşul belirmek gerekli
{
    Console.Write(num1 + " "); //1 1 2 3 5 8.. diye istenen adımın 2 fazlasına kadar gidicek.
    toplam = num1 + num2; //swap işlemleri
    num1 = num2;
    num2 = toplam;
    i++;
}
Console.ReadLine();
