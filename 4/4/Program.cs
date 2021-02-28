using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

namespace ConsoleApplication1

{ //объявление структуры

    public struct Clients

    {

        //поля структуры
        public int id;
        public string FIO;
        public int cost;
        public string place;
        public string status;

        public Clients(int id, string FIO, int cost, string place, string status)
        {
            this.id = id;
            this.FIO = FIO;
            this.cost = cost;
            this.place = place;
            this.status = status;
        }
        // метод структуры - вывод

        public void show()

        {

            Console.WriteLine("id {0}; FIO {1}; cost {2}; place {3}; status {4}", id, FIO, cost, place, status);

        }//конец метода

    }; //конец описания структуры student

    public class Vouchers
    {
        public string place;
        public int cost;

        public void getInfo()
        {
            Console.WriteLine("Voucher: {0}; cost: {1}", place, cost);
        }

        public Vouchers(string place, int cost)
        {
            this.place = place;
            this.cost = cost;
        }
    }

    class Program

    {

        static void Main(string[] args)
        {
            Console.WriteLine("1: Regular clients" + "\n" + "2: Voucher for cost" + "\n" + "3: Search by place");

            Vouchers[] v = new Vouchers[3];

            v[0] = new Vouchers("Baranovichi", 540);
            v[1] = new Vouchers("Hell", 666);
            v[2] = new Vouchers("Mars", 999);

            Clients[] s = new Clients[3];

            s[0].id = 1;
            s[0].FIO = "Shaikevich Vladislav Dmitrievich";
            s[0].cost = v[0].cost;
            s[0].place = v[0].place;
            s[0].status = "regular";


            s[1].id = 2;
            s[1].FIO = "Oreh Kirill Alexandrovich";
            s[1].cost = v[1].cost;
            s[1].place = v[1].place;
            s[1].status = "new";

            s[2].id = 3;
            s[2].FIO = "Falkovskiy Vladimir Anatolievich";
            s[2].cost = v[2].cost;
            s[2].place = v[2].place;
            s[2].status = "regular";


            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    for (int i = 0; i < s.Length; i++)
                    {
                        if (s[i].status == "regular")
                        {
                            Console.WriteLine("");
                            s[i].show();
                        }
                    }
                    break;
                case "2":
                    Console.WriteLine("Enter voucher cost: ");
                    int cost = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < v.Length; i++)
                    {
                        if (v[i].cost == cost)
                        {
                            Console.WriteLine("");
                            v[i].getInfo();
                        }
                    }
                    break;
                case "3":
                    Console.WriteLine("Enter resting-place: ");
                    string place = Console.ReadLine();
                    Console.WriteLine("");
                    for (int i = 0; i < v.Length; i++)
                    {
                        if (v[i].place == place)
                        {
                            Console.WriteLine("");
                            v[i].getInfo();
                        }
                    }
                    Console.WriteLine("Client: ");
                    for (int i = 0; i < s.Length; i++)
                    {
                        if (s[i].place == place)
                        {
                            Console.WriteLine("");
                            s[i].show();
                        }
                    }
                    break;
            }

        }

    }

}