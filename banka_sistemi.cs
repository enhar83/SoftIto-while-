//bu programa bakiye gösterme kısmını eklemedim çünkü her işlemden önce ve sonra bakiyeyi gösteriyor.
//ayrıca bakiye 0 olunca döngüden de atmıyorum,eğer kullanıcı para yatırmayı seçerse bu durumdan kurtulur.

string sifre = "Şifre123";
int x = 0;

while (x < 3)
{
    Console.Write("Lütfen şifrenizi giriniz:");
    string sifre_giris = Console.ReadLine();

    if (sifre == sifre_giris)
    {
        
        double bakiye = 1000, tutar = 0;
        bool devamEt = true;

        while (devamEt)
        {
            Console.WriteLine("\n1. Para Çekme\n2. Para Yatırma\n3. Para Gönderme\n4. Çıkış");
            Console.Write("Lütfen gerçekleştirmek istediğiniz işlemi giriniz:");
            string secim = Console.ReadLine();
            secim=secim.ToLower();

            switch (secim)
            {
                case "1":
                case "para çekme":
                    Console.Write($"\nGüncel bakiyeniz:{bakiye} TL. Ne kadar çekmek istersiniz?:");
                    x:
                    try
                    {
                        
                        tutar = Convert.ToDouble(Console.ReadLine());

                        if (tutar <= 0)
                        {
                            Console.Write("Lütfen pozitif bir miktar giriniz:");
                            goto x;
                        }
                        else if (tutar > bakiye)
                        {
                            Console.Write("Hesabınızda olan tutar kadar para çekebilirsiniz.Lütfen miktarı tekrar giriniz:");
                            goto x;
                        }
                        else
                        {
                            bakiye -= tutar;
                            Console.Clear();
                            Console.WriteLine($"İşlem başarılı. Güncel bakiyeniz:{bakiye} TL");
                        }
                    }
                    catch
                    {
                        Console.Write("Metinsel ifade girilemez.Lütfen bir sayı giriniz:");
                        goto x;
                    }
                    break;

                case "2":
                case "para yatırma":
                    Console.Write($"\nGüncel bakiyeniz:{bakiye} TL. Ne kadar yatırmak istersiniz:");
                    y:
                    try
                    {
                        tutar = Convert.ToDouble(Console.ReadLine());

                        if (tutar <= 0)
                        {
                            Console.Write("Pozitif bir miktar giriniz:");
                            goto y;
                        }
                        else
                        {
                            bakiye += tutar;
                            Console.Clear();
                            Console.WriteLine($"İşlem başarılı. Güncel bakiyeniz:{bakiye} TL");
                            
                        }
                    }
                    catch
                    {
                        Console.Write("Metinsel ifade girilemez.Lütfen bir sayı giriniz:");
                        goto y;
                    }
                    break;

                case "3":
                case "para gönderme":
                    Console.Write("Hangi isme para göndermek istersiniz:");
                    string isim = Console.ReadLine();

                    Console.Write($"\nGüncel bakiyeniz: {bakiye} TL. Ne kadar göndermek istersiniz:");
                    z:
                    try
                    {
                        tutar = Convert.ToDouble(Console.ReadLine());

                        if (tutar <= 0)
                        {
                            Console.Write("Geçerli bir miktar giriniz:");
                            goto z;
                        }
                        else if (tutar > bakiye)
                        {
                            Console.Write("Hesabınızda olan tutar kadar para gönderebilirsiniz.Lütfen geçerli bir miktar giriniz:");
                            goto z;
                        }
                        else
                        {
                            bakiye -= tutar;
                            Console.Clear();
                            Console.WriteLine($"{isim} kişisine {tutar} TL gönderildi. Güncel bakiyeniz:{bakiye} TL");
                            
                        }
                    }
                    catch
                    {
                        Console.Write("Metinsel ifade girilemez.Lütfen bir sayı giriniz:");
                        goto z;
                    }
                    break;

                case "4":
                case "çıkış":
                    Console.WriteLine("Bizi kullandığınız için teşekkür ederiz.");
                    devamEt = false;
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Geçersiz işlem girdiniz. Lütfen geçerli bir işlem seçiniz.");
                    break;
            }
        }
        break;
    }
    else
    {
        x++;
        if (x == 3)
        {
            Console.WriteLine("Deneme hakkınız kalmamıştır. Kartınız bloke olmuştur.");
            break;
        }
        else
        {
            Console.WriteLine($"{3 - x} deneme hakkınız kaldı. Lütfen doğru şifreyi giriniz.\n");
        }
    }
}
Console.ReadLine();
