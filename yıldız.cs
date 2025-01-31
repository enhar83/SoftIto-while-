/*
  *** 
  ***
  ***
  ***
*/

int i = 0, j = 0, satir_sayisi = 4, sutun_sayisi = 3; //satır ve sütun sayısını kullanıcıdan da alabilirdik.
while (i < satir_sayisi)
{
    while (j < sutun_sayisi)
    {
        Console.Write("*");
        j++;
    }
    i++;
    j = 0; //bu önemli bir kısım,eğer koymazsak ilk satırda *** olurdu ve program biterdi.
    Console.WriteLine();
}
Console.ReadLine();
