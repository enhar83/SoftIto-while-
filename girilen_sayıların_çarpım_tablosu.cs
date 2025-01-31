            Console.Write("Bir sayı giriniz:");
            int sayi1 = int.Parse(Console.ReadLine());

            Console.Write("Bir sayı giriniz:");
            int sayi2 = int.Parse(Console.ReadLine());

            int i = 1, j = 1; //0dan başlatılsaydı 0 çarpımlarını da gösterirdi gerek yok.1den başlatılmalı.
            while (i <= sayi1) 
            {
                while (j <= sayi2)
                {
                    Console.WriteLine($"{i}*{j}={i*j} ");
                    j++;
                }
                i++;
                j = 1;
                if (i == sayi1+1) //sondaki ----------- kaldırmak için
                {
                    break;
                }
                Console.WriteLine("--------------------------------");
            }
            Console.ReadLine();
