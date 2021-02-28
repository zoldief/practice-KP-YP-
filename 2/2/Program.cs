using System;
using System.Linq;

namespace _2
{
    class Program
    {

        static void one(int n)
        {
            string str = Convert.ToString(n);
            int n1 = str[0] + '0';
            int n2 = str[1] + '0';
            int n3 = str[2] + '0';
            int n4 = str[3] + '0';
            if (n1 + n2 == n3 + n4)
            {
                Console.WriteLine(true);
            } else
            {
                Console.WriteLine(false);
            }
        }

        static void two(int n)
        {
            string str = Convert.ToString(n);
            int n1 = str[0] + '0';
            int n2 = str[1] + '0';
            int n3 = str[2] + '0';
            if (n1 + n2 + n3 % 2 == 0)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }

        static void three(int n)
        {
            string str = Convert.ToString(n);
            int n1 = str[0] + '0';
            int n2 = str[1] + '0';
            int n3 = str[2] + '0';
            if (Math.Pow(n, 2) == Math.Pow((n1 + n2 + n3), 3))
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }

        static void four(int n)
        {
            string str = Convert.ToString(n);
            if (str.Length == 2 && n % 2 == 0)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }

        static void five(int a, int b, int c)
        {
            if (a == b && b == c)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }

        static void six(int a, int b, int c)
        {
            if (a == b || a == c || b == c)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }

        static void seven(int a, int b, int c)
        {
            if (a != 0 && b != 0 && a + b == 0 || a != 0 && c != 0 && a + c == 0 || b != 0 && c != 0 && c + b == 0)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }

        static void eight(int a, int b, int c, int d)
        {
            bool f = a / b == c / d;
            Console.WriteLine(f);
        }

        static void nine(int a, int b, int c, int a1, int b1, int c1)
        {
            int p1 = (a + b + c) / 3;
            double s1 = Math.Pow((p1 * (p1 - a) * (p1 - b) * (p1 - c)), 0.5);
            int p2 = (a1 + b1 + c1) / 3;
            double s2 = Math.Pow((p2 * (p2 - a1) * (p2 - b1) * (p2 - c1)), 0.5);
            bool f = s1 == s2;
            Console.WriteLine(f);
        }

        static void ten(double a, double b, double c)
        {
            bool f = Math.Pow(c, 2) == Math.Pow(a, 2) + Math.Pow(b, 2);
            Console.WriteLine(f);
        }

        static void eleven(int n)
        {
            bool allDigitsAreUnique = n.ToString().ToCharArray().Select(x => int.Parse(x.ToString())).Distinct().Count() == 4;
            Console.WriteLine(allDigitsAreUnique);
        }

        static void twelve(int x, int y)
        {
            bool f = (x > 0) && (y > 0);
            Console.WriteLine(f);
        }

        static void threeten(int x, int y, int x1, int y1, int x2, int y2)
        {
            bool f = (x1 < x) && (x < x2) && (y2 < y) && (y < y1);
            Console.WriteLine(f);
        }

        static void fourteen(int a, int b, int c)
        {
            int ab = (a + b) / 2;
            bool f;
            if (c == ab)
            {
                f = true;
            }
            else
            {
                f = false;
            }
            Console.WriteLine(f);
        }

        static void fiveteen(int p)
        {
            if (((p / 100)) < ((p / 100) % 10) && (((p / 100) % 10) < ((p / 10) % 10)))
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }

        static void sixteen(int n)
        {
            string str = Convert.ToString(n);
            int n1 = str[0] + '0';
            int n2 = str[1] + '0';
            int n3 = str[2] + '0';
            if (n3 - n2 == (n2 - n1))
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }

        static void seventeen(double n)
        {
            double n1 = n / 100;
            double n2 = n1 / 10 % 10;
            double n3 = n / 10;
            bool f;
            if ((n2 != 0) && (n3 != 0) && (n1 / n2 == n2 / n3))
            {
                f = true;
            }
            else
            {
                f = false;
            }
            Console.WriteLine(f);
        }
        static void eighteen(int a, int c, int d)
        {
            bool f = (c == Math.Pow(a, 2) && d == Math.Pow(a, 3));
            Console.WriteLine(f);
        }

        static void nineteen(int n, int m)
        {
            string str = Convert.ToString(n);
            int n1 = str[0] + '0';
            int n2 = str[1] + '0';
            int n3 = str[2] + '0';
            int n4 = str[3] + '0';
            if (m == n1 || m == n2 || m == n3 || m == n4)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }

        static void twenty(int n)
        {
            string str = Convert.ToString(n);
            string reverse = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reverse += str[i];
            }
            bool f = (str == reverse);
            Console.WriteLine(f);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("1: ");
            one(1212);

            Console.WriteLine("\n" +
                "\n" +
                "2: ");
            two(1212);

            Console.WriteLine("\n" +
                "\n" +
                "3: ");
            three(1212);

            Console.WriteLine("\n" +
                "\n" +
                "4: ");
            four(1212);

            Console.WriteLine("\n" +
                "\n" +
                "5: ");
            five(5, 5, 5);

            Console.WriteLine("\n" +
                "\n" +
                "6: ");
            six(7, 1, 4);

            Console.WriteLine("\n" +
                "\n" +
                "7: ");
            seven(1, -1, 1);

            Console.WriteLine("\n" +
                "\n" +
                "8: ");
            eight(5,6,7,4);

            Console.WriteLine("\n" +
                "\n" +
                "9: ");
            nine(5,6,6,5,6,6);

            Console.WriteLine("\n" +
                "\n" +
                "10: ");
            ten(4,3,6);

            Console.WriteLine("\n" +
                "\n" +
                "11: ");
            eleven(4344);

            Console.WriteLine("\n" +
                "\n" +
                "12: ");
            twelve(5,8);

            Console.WriteLine("\n" +
                "\n" +
                "13: ");
            threeten(10,14,9,16,11,8);

            Console.WriteLine("\n" +
               "\n" +
               "14: ");
            fourteen(3,3,3);

            Console.WriteLine("\n" +
               "\n" +
               "15: ");
            fiveteen(1234);

            Console.WriteLine("\n" +
               "\n" +
               "16: ");
            sixteen(123);

            Console.WriteLine("\n" +
               "\n" +
               "17: ");
            seventeen(111);

            Console.WriteLine("\n" +
              "\n" +
              "18: ");
            eighteen(2,4,8);

            Console.WriteLine("\n" +
              "\n" +
              "19: ");
            nineteen(1234,5);

            Console.WriteLine("\n" +
              "\n" +
              "20: ");
            twenty(1221);

        }
    }
}
