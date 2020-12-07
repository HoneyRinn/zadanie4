using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie4
{
    class Program
    {
        static void Main(string[] args)
        {
            autobus b1 = new autobus("Никита", "Беликов", "BMW", "1990", "a192i", 14, 90000);
            autobus b2 = new autobus("Кирилл", "Чухарев", "BMW", "1999", "fg1452i", 14, 50000);
            autobus b3 = new autobus("Андрей", "Галеев", "Камаз", "2005", "6kt192i", 2, 40000);
            autobus b4 = new autobus("Данил", "Харьков", "Chevrolet", "1980", "46g2i", 10, 5000);
            autobus b5 = new autobus("Илья", "Федоров", "Lada", "2010", "a112i", 15, 0);

            Console.WriteLine("Введите номер маршрута:");
            string numberOfRoute = Console.ReadLine();
            Console.WriteLine("\nАвтобусы:\n");
            for (int i = 0; i < autobus.count; i++)
            {
                if (numberOfRoute == autobus.buses[i, 5])
                {
                    for (int j = 0; j < 7; j++)
                    {
                        Console.Write(autobus.buses[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine("Введите срок в годах, чтобы узнать, какие автобусы эксплуатируются дольше :");
            string term = Console.ReadLine();
            Console.WriteLine("\nАвтобусы:\n");
            for (int i = 0; i < autobus.count; i++)
            {
                int expTerm = 2020 - Int32.Parse(autobus.buses[i, 3]);
                if (expTerm > Int32.Parse(term))
                {
                    for (int j = 0; j < 7; j++)
                    {
                        Console.Write(autobus.buses[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine("Введите пробег для информации:");
            string millage = Console.ReadLine();
            Console.WriteLine("\nАвтобусы:\n");
            for (int i = 0; i < autobus.count; i++)
            {
                if (int.Parse(millage) < int.Parse(autobus.buses[i, 6]))
                {
                    for (int j = 0; j < 7; j++)
                    {
                        Console.Write(autobus.buses[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}