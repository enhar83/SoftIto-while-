/*
     *
    ***
   *****
  *******
 *********
    ***
    ***
    ***
*/

int i = 0, j = 0, k = 0; //bunları i'li türden yazmak yerine 0'dan başlat hep daha kolay olur.

while (i < 5)
{
    while (j < 4 - i) //burdaki koşulları i'li türden yaz. j=0 olduğu için hep < olur.
    {
        Console.Write(" ");
        j++;
    }
    while (k < 2 * i + 1)
    {
        Console.Write("*");
        k++;
    }
    i++;
    k = 0;
    j = 0;
    Console.WriteLine();
}
i = 0; // i ve j değerlerini sıfırlamamız lazım yoksa ağacın kök kısmı olmaz
j = 0; //k'yi yapmıyorum çünkü k'yı bi önceki döngüde sıfırlıyordum.
while (i < 3)
{
    while (j < 3)
    {
        Console.Write(" ");
        j++;
    }
    while (k < 3)
    {
        Console.Write("*");
        k++;
    }
    i++;
    j = 0;
    k = 0;
    Console.WriteLine();
}
Console.ReadLine();
