using System;

namespace _1
{
    class Program
    {

        static void one(double a, double b)
        {
            double c = Math.Pow((a * a + b * b), 0.5);
            double perimetr = a + b + c;
            double ploschad = (a * b) / 2;
            Console.WriteLine("P = " + perimetr + "; S = " + ploschad);
        }

        static void two(double x1, double x2, double x3, double y1, double y2, double y3)
        {
            double a = Math.Sqrt((Math.Pow(x2 - x1, 0.5) + Math.Pow(y2 - y1, 0.5)));
            double b = Math.Sqrt((Math.Pow(x3 - x2, 0.5) + Math.Pow(y3 - y2, 0.5)));
            double c = Math.Sqrt((Math.Pow(x3 - x1, 0.5) + Math.Pow(y3 - y1, 0.5)));
            double p = a + b + c;
            double p2 = p / 2;
            double s = Math.Sqrt(p2 * (p2 - a) * (p2 - b) * (p2 - c));
            Console.WriteLine("P = {0}, S = {1}", x1, s);
        }

        static void three(int n)
        {
            int proiz = 1;
            do proiz *= n % 10;
            while ((n /= 10) > 0);
            Console.WriteLine("proizvedenie = " + proiz);

        }

        static void four(double a, double b)
        {
            double proizCube = (a * a * a + b * b * b) / 2;
            double avgGeom = Math.Pow(Math.Abs(a) * Math.Abs(b), 0.5);
            Console.WriteLine("proizvedenie = " + proizCube + "; avg = " + avgGeom);
        }

        static void five(double x1, double x2, double y1, double y2)
        {
            double rast = Math.Sqrt(Math.Pow(x2 - x1, 0.5) + Math.Pow(y2 - y1, 0.5));
            Console.WriteLine("rastoyanie = " + rast);
        }

        static void six(double y, double x)
        {
            double sum = x + y;
            double razn = x - y;
            double proiz = x * y;
            double chasn = x / y;
            Console.WriteLine("sum = " + sum + ";   raznost = " + razn + ";   proivedenie = " + proiz + ";   chastnoe = " + chasn);
        }

        static void seven(double a)
        {
            double h = Math.Sqrt(3) / 2 * a;
            double s = 0.5 * a * h;
            double r = (2 * s) / (3 * a);
            double R = Math.Pow(a, 3) / (4 * s);
            Console.WriteLine("S = " + s + ";   H = " + h + ";   r = " + r + ";   R = " + R);
        }
        static void eight(int a)
        {
            double p = (a * a) / (4 * Math.PI);
            Console.WriteLine("S = " + p);
        }

        static void nine(double a1, double b1, double c1, double r)
        {
            double a = 2 * r * Math.Sin(a1 * Math.PI / 180);
            double b = 2 * r * Math.Sin(b1 * Math.PI / 180);
            double c = 2 * r * Math.Sin(c1 * Math.PI / 180);
            Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c);
        }

        static void ten(double a, double b, double c)
        {
            double D = Math.Pow(b, 2) - 4 * a * c;
            if (D > 0)
            {
                double x1 = (-b + Math.Sqrt(D)) / 2 * a;
                double x2 = (-b - Math.Sqrt(D)) / 2 * a;
                Console.WriteLine("x1 = {0}, x2 = {1}", x1, x2);
            } else if (D == 0)
            {
                double x = -b / 2 * a;
                Console.WriteLine("x = " + x);
            } else
            {
                Console.WriteLine("Error");
            }
        }

        static void eleven(double a, double b, double y)
        {
            double S = a * b * Math.Cos(Math.PI * y / 180);
            Console.WriteLine("S = " + S);
        }

        static void twelve(int n)
        {
            int n2 = n * n;
            int n3 = n * n * n;
            int n4 = n * n * n * n;
            int n5 = n * n * n * n * n;
            Console.WriteLine("N(" + n + ") = " + n2 + "; " + n3 + ";  " + n4 + ";  " + n5);
        }

        static void thirteen(double a, double b, double c)
        {
            double a1 = Math.Cos((Math.Sqrt(b) + Math.Sqrt(c) - Math.Sqrt(a)) / 2 * b * c);
            double b1 = Math.Cos((Math.Sqrt(a) + Math.Sqrt(c) - Math.Sqrt(b)) / 2 * a * c);
            double c1 = 180 - (a1 + b1);
            Console.WriteLine("a1 = {0}, b1 = {1}, c1 = {2}", a1, b1, c1);
        }

        static void fourteen(double rd)
        {
            double gr = Math.Round((rd * 180 / Math.PI),0);
            double m = Math.Round((gr * 60),0);
            double s = Math.Round((m * 60),0);
            Console.WriteLine("gr = {0}, m = {1}, s = {2}", gr, m, s);
        }

        static void fiveteen(string str, string letter)
        {
            int n = str.IndexOf(letter);
            char next = str[n + 1];
            char prev = str[n - 1];
            Console.WriteLine("pos = {0}, next = {1}, prev = {2}", n, next, prev);
        }
        static void sixteen(double b)
        {
            double KB = b / 1024;
            double MB = KB / 1024;
            double GB = MB / 1024;
            double TB = GB / 1024;
            double EB = TB / 1024;
            double ZB = EB / 1024;
            Console.WriteLine("KB = {0}, MB = {1}, GB = {2}, TB = {3}, EB = {4}, ZB = {5}", KB, MB, GB, TB, EB, ZB);
        }

        static void seventeen(int T)
        {
            int MM = T / 60;
            int HH = MM / 60;
            Console.WriteLine("{0} h {1} m {2} s.", HH, MM, T);
        }
        static void Main(string[] args)
        {
            double a = 12;
            double b = 83;
            double c = 54;
            double d = 91;
            double e = 26;
            double f = 95;
            int g = 12;
            string j = "fjdfdkfnv";
            string h = "k";
            Console.WriteLine("one:");
            one(a,b);
            Console.WriteLine("========================================================================================");
            Console.WriteLine("two:");
            two(a,b,c,d,e,f);
            Console.WriteLine("========================================================================================");
            Console.WriteLine("three:");
            three(g);
            Console.WriteLine("========================================================================================");
            Console.WriteLine("four:");
            four(a,b);
            Console.WriteLine("========================================================================================");
            Console.WriteLine("five:");
            five(a,b,c,d);
            Console.WriteLine("========================================================================================");
            Console.WriteLine("six:");
            six(a,b);
            Console.WriteLine("========================================================================================");
            Console.WriteLine("seven:");
            seven(a);
            Console.WriteLine("========================================================================================");
            Console.WriteLine("eight:");
            eight(g);
            Console.WriteLine("========================================================================================");
            Console.WriteLine("nine:");
            nine(a,b,c,d);
            Console.WriteLine("========================================================================================");
            Console.WriteLine("ten:");
            ten(a,b,c);
            Console.WriteLine("========================================================================================");
            Console.WriteLine("eleven:");
            eleven(a,b,c);
            Console.WriteLine("========================================================================================");
            Console.WriteLine("twelve:");
            twelve(g);
            Console.WriteLine("========================================================================================");
            Console.WriteLine("thirteen:");
            thirteen(a,b,c);
            Console.WriteLine("========================================================================================");
            Console.WriteLine("fourteen:");
            fourteen(a);
            Console.WriteLine("========================================================================================");
            Console.WriteLine("fiveteen:");
            fiveteen(j,h);
            Console.WriteLine("========================================================================================");
            Console.WriteLine("sixteen:");
            sixteen(a);
            Console.WriteLine("========================================================================================");
            Console.WriteLine("seventeen:");
            seventeen(g);
            Console.WriteLine("========================================================================================");
        }
    }
}
