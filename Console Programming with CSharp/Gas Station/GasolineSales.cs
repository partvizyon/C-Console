using System;
using System.ComponentModel.Design;




namespace Gas_Station
{
   class GasolineSales
   {
      static void Main(string[] args)
      {
         // Değişken Tanımları
         double dizel = 6.15, benzin = 7.15, lpg = 3.15;
         double dizeltank = 1000, benzintank = 1000, lpgtank = 1000;
         double satismiktari = 0;
         char anamenusecim = '0', altmenusecim = '0', akaryakitfiyatguncelle = '0', akaryakitsatistipi = '0';

      // Ana Menü Görüntüle
      MENU:
         Console.WriteLine("Akaryakıt Satış Takip Programı");
         Console.WriteLine(">>>>>>>>>>>>> * <<<<<<<<<<<<<<\n");
         Console.WriteLine("1 - Birim Fiyat Göster");
         Console.WriteLine("2 - Birim Fiyat Güncelle");
         Console.WriteLine("3 - Akaryakıt Satışı Yap");
         Console.WriteLine("4 - Stok Durumunu Göster");
         Console.WriteLine("5 - Toplam Satışları Göster");
         Console.WriteLine("6 - Programdan Çık");

         Console.Write("\nSeçiminizi Yapınız [1,2,3,4,5,6]:");
         anamenusecim = Convert.ToChar(Console.ReadLine());
         if (anamenusecim == '1')
         {
            Console.Clear();
            Console.WriteLine(">> Seçiminiz: 1");
            Console.WriteLine("\n---Birim Fiyat Listesi---\n");
            Console.WriteLine("[D] - Dizel   :\t{0} TL/Litre", dizel);
            Console.WriteLine("[B] - Benzin  :\t{0} TL/Litre", benzin);
            Console.WriteLine("[L] - LPG     :\t{0} TL/Litre\n", lpg);
         ALTMENU:
            Console.Write("Seçiminizi Yapınız:\n[1] Ana Menüye Dön\n[2] Programı Kapat\n:");
            altmenusecim = Convert.ToChar(Console.ReadLine());
            if (altmenusecim == '1')
            {
               Console.Clear();
               goto MENU;
            }
            else if (altmenusecim == '2')
            {
               Environment.Exit(0);
            }
            else
            {
               Console.WriteLine("Yanlış Seçim Yaptınız!\nLütfen [1] veya [2] seçeneklerinden birini seçiniz!");
               goto ALTMENU;
            }
         }
         // Ana Menü 2 Görüntüle
         else if (anamenusecim == '2')
         {
            Console.Clear();
            Console.WriteLine(">> Seçiminiz: 2\n");
            Console.WriteLine("---Birim Fiyatları Güncelle---");
         AKARYAKITTIPI:
            Console.WriteLine("\nAkaryakıt Tipi Seçiniz\n[D] - Dizel\n[B] - Benzin\n[L] - Lpg");
            akaryakitfiyatguncelle = Convert.ToChar(Console.ReadLine());
            if (akaryakitfiyatguncelle == 'D' || akaryakitfiyatguncelle == 'd')
            {
               Console.WriteLine("Dizel [Güncel Fiyat]: {0} TL/Litre\n", dizel);
               Console.WriteLine("Yeni Fiyat Giriniz : ");
               dizel = Convert.ToDouble(Console.ReadLine());
               Console.WriteLine("\nDeğişiklik Yapıldı.");
               Console.WriteLine("Dizel [Yeni Fiyat]: {0} TL/Litre\n", dizel);
            }
            else if (akaryakitfiyatguncelle == 'B' || akaryakitfiyatguncelle == 'b')
            {
               Console.WriteLine("Benzin [Güncel Fiyat]: {0} TL/Litre\n", benzin);
               Console.WriteLine("Yeni Fiyat Giriniz : ");
               benzin = Convert.ToDouble(Console.ReadLine());
               Console.WriteLine("\nDeğişiklik Yapıldı.");
               Console.WriteLine("Benzin [Yeni Fiyat]: {0} TL/Litre\n", benzin);
            }
            else if (akaryakitfiyatguncelle == 'L' || akaryakitfiyatguncelle == 'l')
            {
               Console.WriteLine("LPG [Güncel Fiyat]: {0} TL/Litre\n", lpg);
               Console.WriteLine("LPG için Yeni Fiyat Giriniz : ");
               lpg = Convert.ToDouble(Console.ReadLine());
               Console.WriteLine("\nDeğişiklik Yapıldı.");
               Console.WriteLine("LPG [Yeni Fiyat]: {0} TL/Litre\n", lpg);
            }
            else
            {
               Console.WriteLine("Tanımlanmamış bir tuşa bastınız!\n Lütfen [D][B][L] seçeneklerinden birini seçiniz.");
               goto AKARYAKITTIPI;
            }
         // ALT MENU
         ALTMENU:
            Console.Write("Seçiminizi Yapınız [1: Ana Menüye Dön 2:Programı Kapat]:");
            altmenusecim = Convert.ToChar(Console.ReadLine());
            if (altmenusecim == '1')
            {
               Console.Clear();
               goto MENU;
            }
            else if (altmenusecim == '2')
            {
               Environment.Exit(0);
            }
            else
            {
               Console.WriteLine("Yanlış Seçim Yaptınız!\nLütfen [1] veya [2] seçeneklerinden birini seçiniz!");
               goto ALTMENU;
            }
         }
         else if (anamenusecim == '3')
         {
            Console.Clear();
            Console.WriteLine(">> Seçiminiz: 3\n");
            Console.WriteLine("---Akaryakıt Satış İşlemleri---");
         AKARYAKITSATISI:
            Console.WriteLine("\nAkaryakıt Tipini Seçiniz [D - B - L]");
            akaryakitsatistipi = Convert.ToChar(Console.ReadLine());
            // Dizel İşlemleri Döngü
            if (akaryakitsatistipi == 'D' || akaryakitsatistipi == 'd')
            {
               if (dizeltank == 0)
               {
                  Console.WriteLine("Yakıt tankında dizel yakıt kalmamıştır!\nLütfen STOK Kontrolü Yapınız!");
                  goto MENU;
               }
               else
               {
                  Console.Write("\nKaç LT Dizel Yakıt Alacaksınız? :");
                  satismiktari = Convert.ToDouble(Console.ReadLine());
                  if (dizeltank < satismiktari)
                  {
                     Console.WriteLine("\nYakıt tankında {0} litre dizel yakıt var.\nİşlem Yapılamadı!", dizeltank);
                     goto MENU;
                  }
                  else if (satismiktari <= dizeltank)
                  {
                     dizeltank = dizeltank - satismiktari;
                     Console.WriteLine("\nDizel Yakıt dolumu tamamlanmıştır.\nSatış işlemi başarılı!");
                     Console.WriteLine("\nDizel Yakıt tankında {0} litre yakıt kaldı.\n", dizeltank);
                  }
               }
            }
            // Benzin İşlemleri Döngü
            else if (akaryakitsatistipi == 'B' || akaryakitsatistipi == 'b')
            {
               if (benzintank == 0)
               {
                  Console.WriteLine("Yakıt tankında benzin yakıtı kalmamıştır!\nLütfen STOK Kontrolü Yapınız!");
                  goto MENU;
               }
               else
               {
                  Console.Write("Kaç LT Benzin Alacaksınız? :");
                  satismiktari = Convert.ToDouble(Console.ReadLine());
                  if (benzintank < satismiktari)
                  {
                     Console.WriteLine("\nYakıt tankında {0} litre Benzin yakıtı var.\nİşlem Yapılamadı!", benzintank);
                     goto MENU;
                  }
                  else if (satismiktari <= benzintank)
                  {
                     benzintank = benzintank - satismiktari;
                     Console.WriteLine("\nBenzin Yakıt dolumu tamamlanmıştır.\nSatış işlemi başarılı!");
                     Console.WriteLine("\nBenzin Yakıt tankında {0} litre yakıt kaldı.\n", benzintank);
                  }
               }
            }
            // LPG İşlemleri Döngü
            else if (akaryakitsatistipi == 'L' || akaryakitsatistipi == 'l')
            {
               if (lpgtank == 0)
               {
                  Console.WriteLine("\nYakıt tankında LPG yakıtı kalmamıştır!\nLütfen STOK Kontrolü Yapınız!");
                  goto MENU;
               }
               else
               {
                  Console.Write("\nKaç LT LPG Yakıtı Alacaksınız? :");
                  satismiktari = Convert.ToDouble(Console.ReadLine());
                  if (lpgtank < satismiktari)
                  {
                     Console.WriteLine("\nYakıt tankında {0} litre LPG yakıtı var.\nİşlem Yapılamadı!", lpgtank);
                     goto MENU;
                  }
                  else if (satismiktari <= lpgtank)
                  {
                     lpgtank = lpgtank - satismiktari;
                     Console.WriteLine("\nLPG Yakıt dolumu tamamlanmıştır.\nSatış işlemi başarılı!");
                     Console.WriteLine("\nYakıt tankında {0} litre LPG yakıtı kaldı.\n", lpgtank);
                  }
               }
            }
            // Hata Denetimi
            else
            {
               Console.WriteLine("Hatalı seçim yaptınız!\nLütfen [D] [B] [L] seçeneklerinden birini seçiniz!");
               goto AKARYAKITSATISI;
            }
         ALTMENU:
            Console.Write("Seçiminizi Yapınız\n[1] Ana Menüye Dön\n[2] Programı Kapat");
            altmenusecim = Convert.ToChar(Console.ReadLine());
            if (altmenusecim == '1')
            {
               Console.Clear();
               goto MENU;
            }
            else if (altmenusecim == '2')
            {
               Environment.Exit(0);
            }
            else
            {
               Console.WriteLine("Yanlış Seçim Yaptınız!\nLütfen [1] veya [2] seçeneklerinden birini seçiniz!");
               goto ALTMENU;
            }
         }
         else if (anamenusecim == '4')
         {
            Console.Clear();
            Console.WriteLine(">> Seçiminiz: 4");
            Console.WriteLine("\n---STOK DURUMU---\n");
            Console.WriteLine("[D] - Dizel Yakıt Tankı   %{0} doludur.\n", (dizeltank / 10));
            Console.WriteLine("[B] - Benzin Yakıt Tankı  %{0} doludur.\n", (benzintank / 10));
            Console.WriteLine("[L] - LPG Yakıt Tankı     %{0} doludur.\n", (lpgtank / 10));
         ALTMENU:
            Console.Write("Seçiminizi Yapınız:\n[1] Ana Menüye Dön\n[2] Programı Kapat\n");
            altmenusecim = Convert.ToChar(Console.ReadLine());
            if (altmenusecim == '1')
            {
               Console.Clear();
               goto MENU;
            }
            else if (altmenusecim == '2')
            {
               Environment.Exit(0);
            }
            else
            {
               Console.WriteLine("Yanlış Seçim Yaptınız!\nLütfen [1] veya [2] seçeneklerinden birini seçiniz!");
               goto ALTMENU;
            }
         }
         else if (anamenusecim == '5')
         {
            Console.Clear();
            Console.WriteLine(">> Seçiminiz: 5");
            Console.WriteLine("\n---TOPLAM SATIŞ DURUMU---\n");
            Console.WriteLine("Dizel Yakıt Satış Toplam  :{0}", 1000 - dizeltank);
            Console.WriteLine("Dizel Yakıt Satış Tutar   :{0}", (1000 - dizeltank) * dizel);
            Console.WriteLine("Benzin Yakıt Satış Toplam :{0}", 1000 - benzintank);
            Console.WriteLine("Benzin Yakıt Satış Tutar  :{0}", (1000 - benzintank) * benzin);
            Console.WriteLine("LPG Yakıt Satış Toplam    :{0}", 1000 - lpgtank);
            Console.WriteLine("LPG Yakıt Satış Tutar     :{0}\n", (1000 - lpgtank) * lpg);
            Console.WriteLine("___________________________");
            Console.WriteLine("Satış Tutarı TOPLAM       :{0}\n", ((1000 - dizeltank) * dizel) + ((1000 - benzintank) * benzin) + ((1000 - lpgtank) * lpg));
         ALTMENU:
            Console.Write("Seçiminizi Yapınız:\n[1] Ana Menüye Dön\n[2] Programı Kapat\n");
            altmenusecim = Convert.ToChar(Console.ReadLine());
            if (altmenusecim == '1')
            {
               Console.Clear();
               goto MENU;
            }
            else if (altmenusecim == '2')
            {
               Environment.Exit(0);
            }
            else
            {
               Console.WriteLine("Yanlış Seçim Yaptınız!\nLütfen [1] veya [2] seçeneklerinden birini seçiniz!");
               goto ALTMENU;
            }
         }
         else if (anamenusecim == '6')
         {
            Environment.Exit(0);
         }
      }
   }
}
