namespace HecelemeAlgoritmasi
{
    public class Program
    {

            static void Main(string[] args)
            {
                List<char> sesliHarfler = ['a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü'];
                List<string> heceler = new List<string>();
                Console.WriteLine("Bir kelime giriniz!");
                string kelime = Console.ReadLine().ToLower(), hece = "";

                for (int i = kelime.Length - 1; i >= 0; i--)
                {
                    if (sesliHarfler.Contains(kelime[i]))
                    {
                        if (i > 0)
                        {
                            if (sesliHarfler.Contains(kelime[i - 1]))
                            {
                                hece = kelime[i].ToString() + hece;
                                heceler.Add(hece); hece = "";
                            }
                            else
                            {
                                hece = kelime[i - 1].ToString() + kelime[i].ToString() + hece;
                                heceler.Add(hece); hece = ""; i--;
                            }
                        }
                        else
                        {
                            hece = kelime[i].ToString() + hece;
                            heceler.Add(hece); hece = "";
                        }
                    }
                    else
                    {
                        if (i == 0)
                        {
                            hece = kelime[i].ToString() + heceler[(heceler.Count - 1)];
                            heceler[(heceler.Count - 1)] = hece;
                        }
                        else
                        {
                            hece = kelime[i].ToString() + hece;
                        }
                    }
                }
                heceler.Reverse();

                foreach (string i in heceler)
                {
                    Console.WriteLine("-" + i);
                }
                Console.ReadLine();
            }
    }
}
