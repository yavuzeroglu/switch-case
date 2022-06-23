using System;

namespace switch_case 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Notunuzu giriniz");
            int not = Convert.ToInt32(Console.ReadLine());

            switch (not)
            {
                case <30 :
                    Console.WriteLine("Zayıf");
                    break;
                case <45:
                    Console.WriteLine("İdare Eder");
                    break;
                case <60:
                    Console.WriteLine("Orta");
                    break;
                case<80:
                    Console.WriteLine("Iyi");
                    break;
                case<100:
                    Console.WriteLine("Pekiyi");
                    break;        
                default:
                Console.WriteLine("0-100 arası not girmelisiniz");
                break;
            }
           
        }
        }
    }
