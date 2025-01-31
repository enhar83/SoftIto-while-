///*
//     *
//    ***
//   *****
//  *******
//   *****
//    ***
//     *
//*/

int i = 0, j = 0, k = 0;

while (i < 4)
{
    while (j < 3 - i)
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
    j = 0;
    k = 0;
    Console.WriteLine();
}
i = 0;
j = 0;
k = 0;

while (i < 3)
{
    while (j < i + 1)
    {
        Console.Write(" ");
        j++;
    }
    while (k < 5 - 2 * i)
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
