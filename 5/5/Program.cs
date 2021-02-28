using System;
using System.Collections.Generic;
using System.Linq;

namespace _5
{
    class Program
    {

        static void one(int x1, int x2, int y1, int y2)
        {
            if (x1 < 0)
                x1 = x1 / -1;
            if (y1 < 0)
                y1 = y1 / -1;
            if (x2 < 0)
                x2 = x2 / -1;
            if (y2 < 0)
                y2 = y2 / -1;
            int a = x1 + y1;
            int b = x2 + y2;
            if (a > b)
                Console.WriteLine("B is closer");
            if (b > a)
                Console.WriteLine("A is closer");
            if (a == b)
                Console.WriteLine("points are at equal distance");
        }

        static void two(double x, double y)
        {
            double t;
            if (x > y)
            {
                t = y;
                y = (x + y) / 2;
                x = x * t * 2;
            }
            else
            {
                t = x;
                x = (x + y) / 2;
                y = x * t * 2;
            }
            Console.WriteLine("X = " + x);
            Console.WriteLine("Y = " + y);
        }

        static void three(int t, int n)
        {
            if (t > n)
            {
                n = t;
            }
            else if (n > t)
            {
                t = n;
            }
            else if (n == 0 && t == 0)
            {
                t = 0;
                n = 0;
            }
            Console.WriteLine("t = " + t + ";   n = " + n);
        }

        static void four(int n)
        {
            var arr = n.ToString().Select(digit => int.Parse(digit.ToString())).ToArray();
            int temp;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] > arr[i])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine("greatest number of n: " + n);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }
        }

        static void five(int n)
        {
            var arr = n.ToString().Select(digit => int.Parse(digit.ToString())).ToArray();
            int temp;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine("smallest number of n: " + n);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }
        }

        static void six(int input)
        {
            int[] rim = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string[] arab = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

            int i;
            i = 0;
            string output = "";
            while (input > 0)
            {
                if (rim[i] <= input)
                {
                    input = input - rim[i];
                    output = output + arab[i];
                }
                else i++;

            }

            Console.Write(output);
        }

        static void seven(string str)
        {
            str = string.Join(" ", str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
            Console.WriteLine(str);
        }

        static void eight(int n)
        {
            Console.WriteLine(n);
            var nArray = n.ToString().ToArray().Select(t => Int32.Parse(t.ToString())).ToArray();
            if (nArray.Distinct().Count() <= 2)
                Console.WriteLine("true");
            else
                Console.WriteLine("false");
        }

        static void nine(int n)
        {
            int defaultSum = 0;
            foreach (char k in n.ToString())
            {
                defaultSum += (int)Char.GetNumericValue(k);
            }
            for (int i = 10; i < n; i++)
            {
                int currentSum = 0;
                foreach (var k in i.ToString())
                {
                    currentSum += (int)Char.GetNumericValue(k);
                }
                if (currentSum == defaultSum)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void ten(int n)
        {
            int defaultSum = 0;
            foreach (char k in n.ToString())
            {
                defaultSum += (int)Char.GetNumericValue(k);
            }
            for (int i = 10; i < n - 2; i++)
            {
                int currentProiz = 1;
                foreach (var k in i.ToString())
                {
                    currentProiz *= (int)Char.GetNumericValue(k);
                }
                if (currentProiz == defaultSum)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void eleven(int n)
        {
            int[] n_arr = n.ToString().ToCharArray().Select(x => x - '0').ToArray();
            int sum = n_arr.Sum();
            bool flag = false;

            for (int i = sum - 1; i > 1; i--)
            {
                if (sum % i == 0)
                {
                    Console.WriteLine("M for {0} = {1}", n, i);
                    flag = true;
                    break;
                }
            }
            if (!flag) Console.WriteLine("M for {0} Нет", n);
        }

        static void twelve(int n)
        {
            int defaultSum = 0;
            int res = 0;
            foreach (char k in n.ToString())
            {
                defaultSum += (int)Char.GetNumericValue(k);
            }
            for (int i = n * 2; i > n; i--)
            {
                if (i % defaultSum == 0)
                {
                    res = i;
                }
            }
            Console.WriteLine(defaultSum);
            Console.WriteLine(res);
        }

        static List<int> IntToDigits(int n)
        {
            n = Math.Abs(n);
            var digits = new List<int>();
            while (n > 0)
            {
                var digit = n % 10;
                n /= 10;
                digits.Add(digit);
            }

            digits.Reverse();
            return digits;
        }
        static void threeteen(int n)
        {
            var ds = IntToDigits(n);

            var sum = 0;
            for (var i = 0; i < ds.Count() / 2; i++)
            {
                sum += ds[i];
            }

            Console.WriteLine(sum);
        }

        static void fourteen(int n)
        {
            string str = Convert.ToString(n);
            if (str.Length == 5)
            {
                Console.WriteLine("{0}{1}{2}{3}", str[0], str[1], str[3], str[4]);
            } else
            {
                Console.WriteLine(n);
            }
        }

        static void fiveteen(int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (i == (i % 10) * (i % 10)) Console.WriteLine(i);
            }
        }

        static void sixteen(int n)
        {
            int counter = 0;
            for (int i = 0; i < n; i++)
            {
                if ((i % 2 != 0) && (i % 3 != 0) && (i % 5 != 0))
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }

        static void seventeen(int n)
        {
            int max = 1;
            int counter = 0;
            foreach (char k in n.ToString())
            {
                if ((int)Char.GetNumericValue(k) > max)
                {
                    max = (int)Char.GetNumericValue(k);
                }
            }
            foreach (char k in n.ToString())
            {
                if ((int)Char.GetNumericValue(k) == max)
                {
                    counter++;
                }
            }
            Console.WriteLine("max = {0}, count = {1}", max, counter);

        }
        static void eighteen(int n)
        {
            var arr = n.ToString().Select(digit => int.Parse(digit.ToString())).ToArray();
            int temp;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] > arr[i])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine("samllest number of n: " + n);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("1:  ");
            one(5,8,4,6);
            Console.WriteLine("\n" + "\n");
            Console.WriteLine("2:  ");
            two(54,27);
            Console.WriteLine("\n" + "\n");
            Console.WriteLine("3:  ");
            three(54,27);
            Console.WriteLine("\n" + "\n");
            Console.WriteLine("4:  ");
            four(5486);
            Console.WriteLine("\n" + "\n");
            Console.WriteLine("5:  ");
            five(5486);
            Console.WriteLine("\n" + "\n");
            Console.WriteLine("6:  ");
            six(15);
            Console.WriteLine("\n" + "\n");
            Console.WriteLine("7:  ");
            seven(" Hellow world ");
            Console.WriteLine("\n" + "\n");
            Console.WriteLine("8:  ");
            eight(2282);
            Console.WriteLine("\n" + "\n");
            Console.WriteLine("9:  ");
            nine(44);
            Console.WriteLine("\n" + "\n");
            Console.WriteLine("10:  ");
            ten(44);
            Console.WriteLine("\n" + "\n");
            Console.WriteLine("11:  ");
            eleven(12345);
            Console.WriteLine("\n" + "\n");
            Console.WriteLine("12:  ");
            twelve(12345);
            Console.WriteLine("\n" + "\n");
            Console.WriteLine("13:  ");
            threeteen(12345678);
            Console.WriteLine("\n" + "\n");
            Console.WriteLine("14:  ");
            fourteen(12345);
            Console.WriteLine("\n" + "\n");
            Console.WriteLine("15:  ");
            fiveteen(652);
            Console.WriteLine("\n" + "\n");
            Console.WriteLine("16:  ");
            sixteen(44);
            Console.WriteLine("\n" + "\n");
            Console.WriteLine("17:  ");
            seventeen(1808);
            Console.WriteLine("\n" + "\n");
            Console.WriteLine("18:  ");
            eighteen(5486);
            Console.WriteLine("\n" + "\n");
            Console.WriteLine("\n" + "\n");
        }
    }
}
