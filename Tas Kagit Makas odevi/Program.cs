using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tas_Kagit_Makas_odevi
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
                string tekrarcevap;
                bool oyundevam = true;
                int kullanıcıscore = 0;
                int pcscore = 0;
                Random rnd = new Random();

                do
                {

                    int pcsecimi = rnd.Next(1, 4);
                    Console.WriteLine("Taş Makas Kağıt oyununa hoşgeldiniz. Lütfen hangi hamleyi yapacağınızı seçin");
                yanlıscevap:
                    Console.WriteLine("1.Taş");
                    Console.WriteLine("2.Kağıt");
                    Console.WriteLine("3.Makas");
                    int kullanıcısecimi = Convert.ToInt32(Console.ReadLine());
                    if (kullanıcısecimi == 1)
                    {
                        if (pcsecimi == 1)
                        {
                            Console.WriteLine("Pc'nin secimi: Taş");
                            Console.WriteLine("Berabere !! ");
                        }
                        else if (pcsecimi == 2)
                        {
                            Console.WriteLine("Pc'nin secimi: Kağıt");
                            Console.WriteLine("Kaybettiniz !! ");
                            pcscore++;

                        }
                        else if (pcsecimi == 3)
                        {
                            Console.WriteLine("Pc'nin secimi: Makas");
                            Console.WriteLine("Siz kazandınız !! ");
                            kullanıcıscore++;
                        }


                    }

                    else if (kullanıcısecimi == 2)
                    {
                        if (pcsecimi == 1)
                        {
                            Console.WriteLine("Pc'nin secimi: Taş");
                            Console.WriteLine("Siz Kazandınız !! ");
                            kullanıcıscore++;
                        }
                        else if (pcsecimi == 2)
                        {
                            Console.WriteLine("Pc'nin secimi: Kağıt");
                            Console.WriteLine("Berabere !! ");

                        }
                        else if (pcsecimi == 3)
                        {
                            Console.WriteLine("Pc'nin secimi: Makas");
                            Console.WriteLine("Kaybettiniz !! ");
                            pcscore++;
                        }


                    }
                    else if (kullanıcısecimi == 3)
                    {
                        if (pcsecimi == 1)
                        {
                            Console.WriteLine("Pc'nin secimi: Taş");
                            Console.WriteLine("Kaybettiniz !! ");
                            pcscore++;
                        }
                        else if (pcsecimi == 2)
                        {
                            Console.WriteLine("Pc'nin secimi: Kağıt");
                            Console.WriteLine("Kazandınız !! ");
                            kullanıcıscore++;

                        }
                        else if (pcsecimi == 3)
                        {
                            Console.WriteLine("Pc'nin secimi: Makas");
                            Console.WriteLine("Berabere !! ");
                        }

                    }
                    else
                    {
                        Console.WriteLine("yanlış seçim yaptınız lütfen 1,2,3 sayılarından birini seçiniz");
                        goto yanlıscevap;
                    }

                    Console.WriteLine("pc: {0}, siz: {1}", pcscore, kullanıcıscore);
                yanlıscevap2:
                    Console.WriteLine("Devam Etmek İstermisin ? e/h");
                    tekrarcevap = Console.ReadLine();
                    if (tekrarcevap == "e" || tekrarcevap == "E")
                    {
                        oyundevam = true;
                    }
                    else if (tekrarcevap == "h" || tekrarcevap == "H")
                    {
                        oyundevam = false;
                    }
                    else
                    {
                        Console.WriteLine("Lütfen e veya h cevabını veriniz");
                        goto yanlıscevap2;
                    }
                    Console.Clear();
                } while (oyundevam);


                Console.WriteLine("Oynadığınız için teşekkür ederiz!");
                // Environment.Exit(0);
                Console.ReadKey();
            }
        }
    }

