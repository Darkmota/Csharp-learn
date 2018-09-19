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
            for (int i = 2; i <= 100000; ++i)
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
            Console.WriteLine("Simple-1[" + primeCount + "]:" + (DateTime.Now.Ticks - time) / 10000.0 + "ms");
            Console.ReadKey();
        }
        static void countPrime2()
        {
            long time = DateTime.Now.Ticks;
            int[] primeList = new int[10001];
            bool[] primeMap = new bool[100001];
            Array.Clear(primeMap, 0, primeMap.Length);
            int primeCount = 1;
            primeList[0] = 2;
            primeMap[2] = true;
            for (int i = 3; i <= 100000; i += 2)
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
            Console.WriteLine("List&Map-2[" + primeCount + "]:" + (DateTime.Now.Ticks - time) / 10000.0 + "ms");
            Console.ReadKey();
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
        }
    }
}
