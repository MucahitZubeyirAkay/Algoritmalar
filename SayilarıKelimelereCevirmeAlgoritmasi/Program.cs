using System.Security.Cryptography.X509Certificates;

namespace SayilarıKelimelereCevirmeAlgoritmasi
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayi giriniz.");
            string sayiStr = Console.ReadLine()!;
            int sayiInt;
            int elemanSayisi=sayiStr.Length;



            List<string> rakamHarf = ["sıfır", "bir", "iki", "üç", "dört", "beş", "altı", "yedi", "sekiz", "dokuz"];

            List<string> rakamHarfOnlukBasamak = ["","on", "yirmi", "otuz", "kırk", "elli", "altmış", "yetmiş", "seksen", "doksan"];


          //  List<string> yazdirilacakMetin = new List<string>();


            for(int i = 0; i < sayiStr.Length; i++)
            {
               sayiInt=Convert.ToInt32(sayiStr[i].ToString());

                if(elemanSayisi <= 3)
                {
                    switch (elemanSayisi)
                    {
                        case 3:
                            if (sayiStr[i] != '1' && sayiStr[i] != '0')
                            {
                                Console.Write(rakamHarf[sayiInt] + "yüz");
                            }
                            else
                            {
                                if (sayiStr[i] == '1')
                                    Console.Write("yüz");
                            }
                            break;
                        case 2:
                            if (sayiStr[i] != '0')
                            {
                                Console.Write(rakamHarfOnlukBasamak[sayiInt]);
                            }

                            break;
                        case 1:
                            if (sayiStr[i] != '0')
                            {
                                Console.Write(rakamHarf[sayiInt]);
                            }
                            else
                            { 
                                if(sayiStr[i] == '0' && sayiStr.Length==1)
                                {
                                    Console.Write(rakamHarf[sayiInt]);
                                }
                            }
                            break;

                    }

                }
                else if(elemanSayisi <= 6 && elemanSayisi > 3)
                {
                    switch (elemanSayisi)
                    {
                        case 6:
                            if (sayiStr[i] != '1' && sayiStr[i] != '0')
                            {
                                Console.Write(rakamHarf[sayiInt] + "yüz");
                            }
                            else
                            {
                                if (sayiStr[i] == '1')
                                    Console.WriteLine("yüz");
                            }
                            break;
                        case 5:
                            if (sayiStr[i] != '0')
                            {
                                Console.Write(rakamHarfOnlukBasamak[sayiInt]);
                            }

                            break;
                        case 4:

                            if (sayiStr[i] != '0')
                            {
                                Console.Write(rakamHarf[sayiInt]);
                            }

                            if (sayiStr[i - 2] != '0' || sayiStr[i - 1] != '0' || sayiStr[i] != '0')
                            {
                                Console.Write("bin ");
                            }
                            break;

                    }
                }
                else if (elemanSayisi <= 9 && elemanSayisi > 6)
                {
                    switch (elemanSayisi)
                    {
                        case 9:
                            if (sayiStr[i] != '1' && sayiStr[i] != '0')
                            {
                                Console.Write(rakamHarf[sayiInt] + "yüz");
                            }
                            else
                            {
                                if (sayiStr[i] == '1')
                                    Console.Write("yüz");
                            }
                            break;
                        case 8:
                            if (sayiStr[i] != '0')
                            {
                                Console.Write(rakamHarfOnlukBasamak[sayiInt]);
                            }

                            break;
                        case 7:
                            if (sayiStr[i] != '0')
                            {
                                Console.Write(rakamHarf[sayiInt]);
                            }
                            if (sayiStr[i-2]!='0' || sayiStr[i-1]!='0' || sayiStr[i]!='0')
                            {
                                Console.Write("milyon ");
                            }
                            break;

                    }
                }
                else if(elemanSayisi <= 12 && elemanSayisi > 9)
                {
                    switch(elemanSayisi)
                    {
                        case 12:
                           
                            if (sayiStr[i] != '1' && sayiStr[i] != '0')
                            {
                                Console.Write(rakamHarf[sayiInt]+"yüz"); 
                            }
                            else
                            {
                                if (sayiStr[i] == '1')
                                Console.Write("yüz");
                            }
                            break;
                        case 11:
                            if (sayiStr[i] != '0')
                            {
                                Console.Write(rakamHarfOnlukBasamak[sayiInt]);
                            }
                            
                            break;
                        case 10:

                            if (sayiStr[i] != '0')
                            {
                                Console.Write(rakamHarf[sayiInt]);
                            }
                            if (sayiStr[i - 2] != '0' || sayiStr[i - 1] != '0' || sayiStr[i] != '0')
                            {
                                Console.Write("milyar ");
                            }
                            break;

                    }
                }

                elemanSayisi -= 1;
            }

            Console.ReadLine();
        }  
    }
}

