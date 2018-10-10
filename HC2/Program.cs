using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC
{
    class Program
    {
        static void countPrime1()
        {
            long time = DateTime.Now.Ticks;
            int primeCount = 0;
            for (int i = 2; i <= 1000000; ++i)
            {
                bool isp = true;
                for (int j = 2; j * j <= i; ++j)
                {
                    if (i % j == 0)
                    {
                        isp = false;
                        break;
                    }
                }
                if (isp)
                {
                    primeCount++;
                }
            }
            Console.WriteLine("Simple-1[" + primeCount + "][1~1000000]:" + (DateTime.Now.Ticks - time) / 10000.0 + "ms");
        }
        static void countPrime2()
        {
            long time = DateTime.Now.Ticks;
            int[] primeList = new int[1000001];
            bool[] primeMap = new bool[1000001];
            Array.Clear(primeMap, 0, primeMap.Length);
            int primeCount = 1;
            primeList[0] = 2;
            primeMap[2] = true;
            for (int i = 3; i <= 1000000; i += 2)
            {
                bool isp = true;
                for (int j = 0; j < primeCount && primeList[j] * primeList[j] <= i; ++j)
                {
                    if (i % primeList[j] == 0)
                    {
                        isp = false;
                        break;
                    }
                }
                if (isp)
                {
                    primeMap[i] = true;
                    primeList[primeCount++] = i;
                }
            }
            Console.WriteLine("List&Map-2[" + primeCount + "][1~1000000]:" + (DateTime.Now.Ticks - time) / 10000.0 + "ms");
        }
        static void formatIt(string poem)
        {
            for (int i = 0; i < 4; ++i)
            {
                for (int j = 0; j < 8; ++j)
                {
                    Console.Write(poem[i * 8 + j] + "     ");
                }
                Console.WriteLine();
            }
        }
        static void time()
        {
            Console.WriteLine(DateTime.Now.ToString());
            Console.WriteLine(DateTime.Now.ToString("d"));
            Console.WriteLine(DateTime.Now.ToString("D"));
            Console.WriteLine(DateTime.Now.ToString("f"));
            Console.WriteLine(DateTime.Now.ToString("F"));
            Console.WriteLine(DateTime.Now.ToString("g"));
            Console.WriteLine(DateTime.Now.ToString("G"));
            Console.WriteLine(DateTime.Now.ToString("t"));
            Console.WriteLine(DateTime.Now.ToString("T"));
            Console.WriteLine(DateTime.Now.ToString("u"));
            Console.WriteLine(DateTime.Now.ToString("U"));
            Console.WriteLine(DateTime.Now.ToString("m"));
            Console.WriteLine(DateTime.Now.ToString("M"));
            Console.WriteLine(DateTime.Now.ToString("r"));
            Console.WriteLine(DateTime.Now.ToString("R"));
            Console.WriteLine(DateTime.Now.ToString("y"));
            Console.WriteLine(DateTime.Now.ToString("Y"));
            Console.WriteLine(DateTime.Now.ToString("o"));
            Console.WriteLine(DateTime.Now.ToString("O"));
            Console.WriteLine(DateTime.Now.ToString("s"));
        }
        static void IP()
        {
            Console.WriteLine("Input IP:");
            string s = Console.ReadLine();
            string[] ss = s.Split('.');
            if (ss.Length != 4)
            {
                Console.WriteLine("Invalid IP!");
                return;
            }
            else
            {
                for (int i = 0; i < 4; ++i)
                {
                    if (Convert.ToInt32(ss[i]) < 0 || Convert.ToInt32(ss[i]) > 255)
                    {
                        Console.WriteLine("Invalid IP!");
                        return;
                    }
                }
                Console.WriteLine("Fine.");
            }
        }
        static void Main(string[] args)
        {
            // Char type
            string s = Convert.ToString(Console.ReadLine());
            for (int i = 0; i < s.Length; ++i)
            {
                char c = s[i];
                string type = "";
                if (c >= 'A' && c <= 'Z')
                {
                    type = "Upcase character";
                }
                else if (c >= 'a' && c <= 'z')
                {
                    type = "Lowcase character";
                }
                else if (c >= '0' && c <= '9')
                {
                    type = "Number";
                }
                else
                {
                    type = "Others";
                }
                Console.WriteLine(c + ": " + type);
            }
            Console.ReadKey();

            // Prime
            countPrime1();
            countPrime2();
            Console.ReadKey();

            formatIt("日照香炉生紫烟，遥望瀑布挂前川。飞流直下三千尺，疑是银河落九天。");
            Console.ReadKey();

            time();
            Console.ReadKey();

            IP();
            Console.ReadKey();
        }
    }
}
