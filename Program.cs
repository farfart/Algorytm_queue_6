using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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
        static void add_elem1(double[,] d, int i, int j, double elem)
        {
            d[i, j] = elem;
        }

        static void add_elem2(double[,] d, int i, int j, double elem)
        {
            d[i, j] = elem;
        }
        //прибрати елемент
        /* static void delet_elem(double[,] d, int i, int j)
         {
             d[i, j] = 0;
         }*/

        //переміщення елемента
        static void change_elem(double[,] d, int i, int j, int a, int b)
        {
            // команда видалення 
            double new_change = d[a, b];
            d[a, b] = d[i, j];
            d[i,j] = new_change;
        }

        // додавання елементів між собою
        static void Sum(double[,] d, int i, int j, int a, int b, int c, int e)
        {
            d[c, e] = d[i, j] + d[a, b];
        }

        static void Main(string[] args)
        {
            double[,] d = new double[3, 3];


            timer1 = new Timer(2000);

            Queue<int> Q = new Queue<int>();

            Console.OutputEncoding = Encoding.UTF8;

            Q.Enqueue(1);
            Q.Enqueue(2);
            Q.Enqueue(3);
            Q.Enqueue(4);
            Q.Enqueue(5);

            bool p = true;
            while(p)
            {
                Console.WriteLine("0: вихід з програми");
                Console.WriteLine("1: Сформувати чергу");
                int menu = Convert.ToInt32( Console.ReadLine());

                switch (menu)
                {
                    case 0:
                        p = false;
                        break;
                    case 1:
                        Console.WriteLine("Введіть чегру:");
                        Console.WriteLine("1. Виводить матрицю на екран(на початку вона буде нульова)");
                        Console.WriteLine("2. Додає один елемент в матрицю");
                        Console.WriteLine("3. Додає другий елемент в матрицю");
                        Console.WriteLine("4. Переміщення елемента на інші координати");
                        Console.WriteLine("5. Виводить суму елементів");
                        Console.WriteLine("6. Виводить добуток елементів");
                        Console.WriteLine("7. Якщо елемент закінчується 2 - ділить на 2 ");
                        Console.WriteLine("8. Від'ємні елементи замінює на 0");
                        Console.WriteLine("9. Пошук мінімального елемента");
                        Console.WriteLine("10.Пошук максимального елемента");


                        break;
                    default:
                        Console.WriteLine("Помилка при введені");
                        break;
                }
            }
            while (Q.Count > 0)
            {
                switch (Q.Dequeue())
                {
                    case 1:
                        print(d, 3, 3);
                        break;
                    case 2:
                            double elem=78;
                            int x=0, y=2;
                            add_elem1(d, x, y, elem);
                            break;

                    case 3:
                        /*string choice2;

                        Console.WriteLine("Хочете прибрати елемент? ");
                        choice2 = Console.ReadLine();
                        if (choice2 == "Yes" || choice2 == "yes" || choice2 == "Так" || choice2 == "так")
                        {
                            Console.Write("Введіть координати елемента (x): ");
                            x = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Введіть координати елемента (y): ");
                            y = Convert.ToInt32(Console.ReadLine());
                            delet_elem(d, x, y);
                            break;
                        }
                        else 
                            break;*/


                    case 4:
                        int x1, y1, x2, y2;
                        Console.WriteLine("Переміщення елемента\t");
                        Console.Write("Введіть координади елемента (x): ");
                        x1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введіть координади елемента (y): ");
                        y1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введіть координати, куди хочете перенести елемент (x): ");
                        x2 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введіть координати, куди хочете перенести елемент (y): ");
                        y2 = Convert.ToInt32(Console.ReadLine());

                        change_elem(d, x1, y1, x2, y2);
                        print(d, 3, 3);
                        break;
                    case 5:
                        int x3,y3;
                        /*Console.WriteLine("Сума елементів");
                        Console.Write("Введіть координади елемента 1 (x): ");
                        x1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введіть координади елемента 1 (y): ");
                        y1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введіть координати елемента 2 (x): ");
                        x2 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введіть координати елемента 2 (y): ");
                        y2 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введіть координати елемента 3 (x): ");
                        x3 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введіть координати елемента 3 (y): ");
                        y3 = Convert.ToInt32(Console.ReadLine());*/

                        Sum(d, x1, y1, x2, y2, x3, y3);
                        print(d, 3, 3);

                        break;
                }
            }
            Console.ReadKey();
        }
    }
}

/*
 дописати 5 функцій для черги, доробити меню
 */

/*
 *створення циклу меню (while)
 *запис черги користувача 
 *запуск черги 
 */
