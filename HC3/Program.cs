using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC3
{
    class Program
    {
        static void StudentName()
        {
            string[] names = new string[] { "A", "B", "C", "D" };
            for (int i = 0; i < names.Length; ++i)
            {
                Console.WriteLine(names[i] + "  ");
            }
            Console.WriteLine("Change B to E");
            names[1] = "E";
            for (int i = 0; i < names.Length; ++i)
            {
                Console.WriteLine(names[i] + "  ");
            }

        }
        static void Dic()
        {
            Dictionary<string, string[]> d = new Dictionary<string, string[]>();
            d.Add("A", new string[] { "A0, A1" });
            d.Add("B", new string[] { "B0, B1" });
            d.Add("C", new string[] { "C0, C1" });
            string s;
            Console.WriteLine("Input(A/B/C): ");
            s = Console.ReadLine();
            try {
                for (int i = 0; i < d[s].Length; ++i)
                {
                    Console.WriteLine("  Output: " + d[s][i]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        static void Random()
        {
            int[,] list = new int[4, 10];
            Random seed = new Random();
            for (int i = 0; i < 10; ++i)
            {
                for (int j = 0; j < 4; ++j)
                {
                    list[i, j] = seed.Next(0, 100);
                }
            }
        }
        static void Main(string[] args)
        {
            StudentName();
            Console.ReadKey();

            Dic();
            Console.ReadKey();
        }
    }
}
