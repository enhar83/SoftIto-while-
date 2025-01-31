 Console.Write("Bir sayı giriniz:");
 int sayi = int.Parse(Console.ReadLine());

 int i = 0, cift_toplam = 0, tek_toplam = 0;
 while (i <= sayi)
 {
     //if-else kullanmadan yaptım.
     tek_toplam += i * (i % 2); //i=5 için --> 5*(5%2) --> 5*1 --> 5
     cift_toplam += i * (1 - (i % 2)); // i=4 için --> 4*(1-(4%2)) --> 4*1 -->4
     i++;
 }
 Console.WriteLine($"{sayi} sayısına kadar olan tek sayıların toplamı:{tek_toplam}");
 Console.WriteLine($"{sayi} sayısına kadar olan çift sayıların toplamı:{cift_toplam}");
