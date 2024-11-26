using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

/*Розробити застосування, яке дозволяє користувачу формувати чергу команд та виконувати усі команди у черзі.
Набір команд має бути у кожного свій власний, у наборі повинно бути не менше 10 команд, а виконуватись вони повинні у таймері.*/


namespace Algorytm_queue_6
{
    internal class Program
    {
        static Timer timer1;

        static void Matrix(double[,] d, int a, int b)
        {
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                    d[i, j] = 0;


            }

        }
        //виводимо матрицю на екран
        static void print(double[,] d, int a, int b)
        {
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                    Console.Write(d[i, j] + "\t");
                Console.WriteLine();

                /*    cout << d[i][j] << "\t";
                cout << endl;*/

            }
        }

        //додавання елементів
        static void add_elem(double[,] d, int i, int j, double elem)
        {
            d[i, j] = elem;
        }



        static void Main(string[] args)
        {
            double[,] d = new double[3, 3];


            timer1 = new Timer(2000);

            Queue<int> Q = new Queue<int>();

            Q.Enqueue(1);
            Q.Enqueue(2);
            while (Q.Count > 0)
            {
                switch (Q.Dequeue())
                {
                    case 1:
                        int x, y;
                        double elem;
                        Console.Write("Введіть елемент: ");
                        elem = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введіть координади елемента (x): ");
                        x = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введіть координади елемента (y): ");
                        y = Convert.ToInt32(Console.ReadLine());
                        add_elem(d, x, y, elem);
                        break;
                    case 2:
                        print(d, 3, 3);
                        break;


                }
            }
            Console.ReadKey();
        }
    }
}

/*
 дописати 7 функцій для черги, доробити меню
 */
