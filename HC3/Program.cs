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
            int[,] list = new int[10, 4];
            string[] titles = { "学号", "高数", "C语言", "英语" };
            Random seed = new Random();
            for (int i = 0; i < 10; ++i)
            {
                for (int j = 0; j < 4; ++j)
                {
                    list[i, j] = seed.Next(0, 100);
                }
            }
            foreach (string t in titles)
            {
                Console.Write("{0,-8}", t);
            }
            for (int i = 0; i < 10; ++i)
            {
                Console.WriteLine();
                for (int j = 0; j < 4; ++j)
                {
                    Console.Write("{0,-10}", list[i,j]);
                }
            }
        }
        static void Expression()
        {
            string expression;
            int s = 0, m = 0, b = 0;
            Console.WriteLine("Input expression");
            expression = Console.ReadLine();
            foreach (char c in expression)
            {
                switch (c)
                {
                    case '(':
                        ++s;
                        break;
                    case ')':
                        if (--s < 0)
                        {
                            goto exit;
                        }
                        break;
                    case '[':
                        ++m;
                        break;
                    case ']':
                        if (--m < 0)
                        {
                            goto exit;
                        }
                        break;
                    case '{':
                        ++b;
                        break;
                    case '}':
                        if (--b < 0)
                        {
                            goto exit;
                        }
                        break;
                }
            }
            if (s!=0 || m!=0|| b!=0)
            {
                goto exit;
            }
            Console.WriteLine("Expression is fine");
            return;
            exit:
            {
                Console.WriteLine("Iligal expression");
            }
        }
        static void GuessGame()
        {
            Random seed = new Random();
            int ans = seed.Next(0, 1000);
            int input = 0;
            while(true)
            {
                Console.Write("Input what you guess(0~1000): ");
                input = Convert.ToInt32(Console.ReadLine());
                if (input > ans)
                {
                    Console.WriteLine("Too big");
                }
                else if (input < ans)
                {
                    Console.WriteLine("Too small");
                }
                else
                {
                    Console.WriteLine("Right!");
                    break;
                }
            }
        }
        static void Main(string[] args)
        {
            StudentName();
            Console.ReadKey();

            Dic();
            Console.ReadKey();

            Random();
            Console.ReadKey();

            Expression();
            Console.ReadKey();

            GuessGame();
            Console.ReadKey();
        }
    }
}
