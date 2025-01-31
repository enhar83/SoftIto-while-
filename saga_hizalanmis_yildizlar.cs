/*
       * 
      ** 
     ***
    ****
   *****
*/

int i = 1, j = 5 - i, k = 0; //i'nin başlangıç değeri k'den 1 fazla olmalı.(k olan while'ın çalışması için)

while (i < 6) //5 kere dönecek
{
    while (j > 0)
    {
        Console.Write(" ");
        j--;
    }
    while (k < i)
    {
        Console.Write("*");
        k++;
    }
    Console.WriteLine();
    i++; //ilk bunu kullanmalıyız yoksa j'nin while'ı bozulur.
    j = 5 - i; // i=2 için,artık 3 boşluk bırakacak.
    k = 0; //olmazsa her adımda bir kez * basar.
}
Console.ReadLine();
