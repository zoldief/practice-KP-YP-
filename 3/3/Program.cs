using System;
using System.Collections.Generic;

namespace _3
{
    class Program
    {

        static void one (int a, int b, int c)
        {
            string str1 = Convert.ToString(a);
            string str2 = Convert.ToString(b);
            string str3 = Convert.ToString(c);
            int n1 = str1[0] - '0';
            int n2 = str1[1] - '0';
            int n3 = str2[1] - '0';
            int n4 = str2[0] - '0';
            int n5 = str3[1] - '0';
            int n6 = str3[0] - '0';

            int sum1 = n1 + n2;
            int sum2 = n3 + n4;
            int sum3 = n5 + n6;

            Console.WriteLine("sum for a = {0}, b = {1} c = {2}", sum1, sum2, sum3);
        }

        static void two()
        {
            Random rnd = new Random();
            int a = rnd.Next(250, 500);
            int b = rnd.Next(250, 500);
            int c = rnd.Next(250, 500);
            string str1 = Convert.ToString(a);
            string str2 = Convert.ToString(b);
            string str3 = Convert.ToString(c);
            int n1 = str1[0] - '0';
            int n2 = str1[1] - '0';
            int n3 = str1[2] - '0';
            int n4 = str2[0] - '0';
            int n5 = str2[1] - '0';
            int n6 = str2[2] - '0';
            int n7 = str3[0] - '0';
            int n8 = str3[1] - '0';
            int n9 = str3[2] - '0';

            int sum1 = n1 + n2 + n3;
            int sum2 = n4 + n5 + n6;
            int sum3 = n7 + n8 + n9;

            Console.WriteLine("sum for {3} = {0}, {4} = {1} {5} = {2}", sum1, sum2, sum3, a, b, c);
        }

        static void three(int a, int b)
        {
            int c = 0;
            int d = 0;
            if (a > b)
            {
                c = b;
                d = a;
            } else
            {
                c = a;
                d = b;
            }
            while (c != d)
            {
                if (c > d)
                    c = c - d;
                else
                    d = d - c;
            }
            int nod = c;
            int nok = 0;
            for (int i = 0; i < (a * b + 1); i++)
            {
                if (i % b == 0 && i % a == 0)
                {
                    nok = i;
                }
            }
            Console.WriteLine("NOD = {0} NOK = {1}", c, nok);
        }

        static int three2(int a, int b)
        {
            int c = 0;
            int d = 0;
            if (a > b)
            {
                c = b;
                d = a;
            }
            else
            {
                c = a;
                d = b;
            }
            while (c != d)
            {
                if (c > d)
                    c = c - d;
                else
                    d = d - c;
            }
            return c;
        }

        static int three3(int a, int b)
        {
            if (a == 0 || b == 0)
                return 0;
            if (a < 0) a = -a;
            if (b < 0) b = -b;
            return (a * b) / three2(a, b);
        }

        static void four(int a, int b, int c, int d)
        {
            var n2 = three2(three2(a, b), three2(c, d));
            Console.WriteLine("NOD = {0}", n2);
        }

        static void five (int a, int b, int c)
        {
            var res =  three3(three3(a, b), c);
            Console.WriteLine("NOK = " + res);
        }

        public static bool IsPrimeNumber(uint n)
        {
            var result = true;

            if (n > 1)
            {
                for (var i = 2u; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        result = false;
                        break;
                    }
                }
            }
            else
            {
                result = false;
            }

            return result;
        }
        static void six (int a)
        {
            var c = Convert.ToUInt32(a);
            var result = 2u;
            
            if (IsPrimeNumber(c))
            {
                for (var i = c + 1; i < c * 10; i++)
                {
                    if (IsPrimeNumber(i))
                    {
                        result = i;
                        break;
                    }
                }
                Console.WriteLine("next prime number = " + result);
            } else
            {
                Console.WriteLine("number is not prime");
            }
        }

        static void seven(int a)
        {
            int min = a;
            for (int i = 2; i < a; i++)
            {
                if ((a % i == 0) && i % 2 != 0)
                {
                    min = i;
                }
            }
            Console.WriteLine("min = " + min);
        }

        static void eight(int a)
        {
            int sum = 0;
            int[] array = new int[a];
            for (int j = 1; j < a; j++)
            {
                for (int i = 1; i < a; i++)
                {
                    if (j % i == 0)
                    {
                        sum += i;
                    }
                }
                array[j] = sum;
                sum = 0;
            }
            for (int i = 1; i < array.Length; i++)
            {
                for (int j = a - 1; j > 0; j--)
                {
                    if (array[j] == array[i] && i != j && array[i] != 0)
                    {
                        Console.WriteLine("friendly numbers: " + j + " & " + i);
                    }
                }
            }
        }

        static void nine(int n)
        {
            int n2 = n * 2;
            for (int i = n; i < n2; i++)
            {
                Console.WriteLine("siblings: " + i + " ~ " + (i + 2));
            }
        }

        static void ten(int n)
        {
            int t, p;
            for (int i = 1; i < n; i++)
            {
                t = i;
                p = t % 10;
                t = t / 10;
                if ((p != 0) && (i % p == 0))
                    Console.WriteLine(i);
            }
        }

        static void eleven(int x, int x1)
        {
            for (int i = x; i < x1; i++)
            {
                int s = i / 100000;
                int r = i / 10000 % 10;
                int y = i / 1000 % 10;
                int c = i / 100 % 10;
                int a = i % 100 / 10;
                int b = i % 10;
                int z = y + r + s;
                int p = a + b + c;
                if (z == p)
                {
                    Console.WriteLine("ticket " + i + " happy");
                    Console.WriteLine(z + " ~ " + p);
                }

            }

        }
        static void twelve(int a, int b)
        {
            int sumN = 0;
            int k = 0;
            for (int i = a; i <= b; i++)
            {
                if (i % 2 != 0)
                {
                    sumN += i;
                    k++;
                }


            }
            Console.WriteLine("sum of odd numbers from " + a + " to " + b + " = " + sumN + "\n" +
                "count of even numbers = " + k);
        }

        static void thirteen(int n)
        {
            string str = Convert.ToString(n);
            int sum = 0;
            for (int i = 0; i < str.Length; i++)
            {
                sum = sum + Convert.ToInt32(str[i]);
            }
            int counter1 = 0;
            while (n > 0)
            {
                n = n - sum;
                counter1++;
            }
            Console.WriteLine(counter1);
        }

        static List<uint> TrialDivision(uint n)
        {
            var divides = new List<uint>();
            var div = 2u;
            while (n > 1)
            {
                if (n % div == 0)
                {
                    divides.Add(div);
                    n /= div;
                }
                else
                {
                    div++;
                }
            }

            return divides;
        }
        static void fourteen(uint n)
        {
            Console.WriteLine("{0} = {1}", string.Join(" * ", TrialDivision(n)), n);
        }
        static void fiveteen(double a, double b, double c)
        {
            if (a > 0)
            {
                a *= a;
            }
            else
            {
                a *= a * a * a;
            }
            if (b > 0)
            {
                b *= b;
            }
            else
            {
                b *= b * b * b;
            }
            if (c > 0)
            {
                c *= c;
            }
            else
            {
                c *= c * c * c;
            }

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("1: ");
            one(45,23,54);
            Console.WriteLine("\n" + "\n");
            Console.WriteLine("2: ");
            two();
            Console.WriteLine("\n" + "\n");
            Console.WriteLine("3: ");
            three(45, 5402235);
            Console.WriteLine("\n" + "\n");
            Console.WriteLine("4: ");
            four(544,861,1225,14434);
            Console.WriteLine("\n" + "\n");
            Console.WriteLine("5: ");
            five(5400,270,65);
            Console.WriteLine("\n" + "\n");
            Console.WriteLine("6: ");
            six(6);
            Console.WriteLine("\n" + "\n");
            Console.WriteLine("7: ");
            seven(54);
            Console.WriteLine("\n" + "\n");
            Console.WriteLine("8: ");
            eight(20);
            Console.WriteLine("\n" + "\n");
            Console.WriteLine("9: ");
            nine(8);
            Console.WriteLine("\n" + "\n");
            Console.WriteLine("10: ");
            ten(30);
            Console.WriteLine("\n" + "\n");
            Console.WriteLine("11: ");
            eleven(378563, 378582);
            Console.WriteLine("\n" + "\n");
            Console.WriteLine("12: ");
            twelve(1,10);
            Console.WriteLine("\n" + "\n");
            Console.WriteLine("13: ");
            thirteen(54035);
            Console.WriteLine("\n" + "\n");
            Console.WriteLine("14: ");
            fourteen(74);
            Console.WriteLine("\n" + "\n");
            Console.WriteLine("15: ");
            fiveteen(85, 6, -5);
        }
    }
}
