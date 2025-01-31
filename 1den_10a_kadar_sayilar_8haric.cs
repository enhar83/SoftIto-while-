int i = 1;
while (i <= 10)
{
    if (i == 8)
    {
        i++; //eğer bunu eklemeseydim,9 ve 10 değerlerini göremezdim.
        continue;
    }
    Console.WriteLine(i);
    i++;
}
Console.ReadLine();
