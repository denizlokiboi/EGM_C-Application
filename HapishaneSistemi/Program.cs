using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HapishaneSistemi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList suçlular = new ArrayList();
            //Deniz TUĞRUL
            string secenek = " ";

            while (secenek != "4")
            {
                Console.WriteLine("-*-*-*-Morpheus Emniyet Müdürlüğü-*-*-*-");
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz.");
                Console.WriteLine("1. Arananlar Listesine Suçlu Ekle");
                Console.WriteLine("2. Aranan Suçluları Göster");
                Console.WriteLine("3. Bulunan Suçluyu Listeden Çıkar");
                Console.WriteLine("4. Çıkış");

                secenek = Console.ReadLine();

                switch (secenek)
                {
                    case "1":
                        Console.Clear();
                        string seçenek = "e"; while (seçenek == "e")
                        {
                            Suçlu suçlu = new Suçlu();
                            Console.WriteLine("Lütfen suçlunun ismini giriniz.");
                            suçlu.isim = Console.ReadLine();

                            Console.WriteLine("Lütfen suçlunun soyadını giriniz");
                            suçlu.soyisim = Console.ReadLine();

                            Console.WriteLine("Lütfen suçlunun yaşını giriniz");
                            suçlu.yaş = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Lütfen suçlunun aranmaya başlandığı zamanı giriniz -Gün.Ay.Yıl / Saat-");
                            suçlu.girişsaati = Convert.ToDateTime(Console.ReadLine());

                            suçlular.Add(suçlu);

                            Console.WriteLine("Devam etmek ister misiniz? e/h");
                            seçenek = Console.ReadLine();
                            Console.Clear();
                        }
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("-*-*-*-Aranan Suçlular-*-*-*");
                        for (int i = 0; i < suçlular.Count; i++)
                        {
                            Suçlu veri = (Suçlu)suçlular[i];
                            Console.WriteLine((i + 1) + ": " + veri.isim + " " + veri.soyisim + " adlı suçlu " + veri.girişsaati + " tarihinden itibaren aranmaktadır. ");
                        }
                        break;
                    case "3":
                        Console.Clear();
                        string choise = "e";
                        for (int i = 0; i < suçlular.Count; i++)
                        {
                            Suçlu veri = (Suçlu)suçlular[i];
                            Console.WriteLine((i + 1) + ": " + veri.isim + " " + veri.soyisim);  
                        }
                        while (choise == "e")
                        {
                            Console.WriteLine("Lütfen arananlar listesinden çıkarmak istediğiniz suçlunun numarasını seçiniz");
                            int numara = Convert.ToInt32(Console.ReadLine());
                            
                            Suçlu veri = (Suçlu)suçlular[numara - 1];
                            suçlular.RemoveAt(numara - 1);
                            veri.çıkışsaati = DateTime.Now;
                            Console.WriteLine("Tebrikler, suçlu; " + veri.çıkışsaati + " tarihinde yakalanmıştır.");
                            Console.WriteLine("Bu işleme devam etmek ister misiniz? e/h");
                            choise = Console.ReadLine(); 
                        } 
                        break;
                    case "4": Console.Clear();
                              Console.WriteLine("Sistemden çıkış yapılıyor.");
                              Console.WriteLine("Herkesin polisi kendi vicdanıdır, fakat polis vicdanı olmayanların karşısındadır.");
                              Console.WriteLine("                                                              -Mustafa Kemal Atatürk");
                              Console.ReadKey();
                        break;
                }



            }
        }
        class Suçlu
        {
            public string isim { get; set; }
            public string soyisim { get; set; }
            public int yaş {  get; set; }
            public DateTime girişsaati { get; set; }
            public DateTime çıkışsaati { get; set; }

        }

    }
}
