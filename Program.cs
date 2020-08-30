


//Создать класс Вектор, который содержит массив int, число
//элементов и переменную состояния. Определить
//индексатор. В переменную состояния устанавливать код
//ошибки, при определенной ситуации. Определить методы:
//сложения и умножения, которые производят эти операции
//с данными класса вектор и числом int.

using System;
using System.Resources;

namespace _3_1_fiirst_try
{
    class Vector
    {
        public int quantity; //колличество элементов массива
        public int[] array;  // массив
        public bool status;  // переменная состояния

        public Vector(int qqq)//конструктор
        {
            array = new int[qqq];
            quantity = qqq;
            status = true;
        }

        public void RandomFill() //рандомизация
        {
            Random rnd = new Random();
            for (int i = 0; i < quantity; i++)
            {
                array[i] = rnd.Next(0, 10);
            }
        }

        public int Add() //сложение
        {
            Console.WriteLine("\nEnter the indices of the elements you want to add:");
            try
            {
                int a = Convert.ToInt32(Console.ReadLine()); int b = Convert.ToInt32(Console.ReadLine());
                return array[a] + array[b];
            }
            catch
            {
                status = false;
                Console.WriteLine("\nAn input exception was founded. Try again...");
                return -1;
            }
            
        }

        public int Multiply() //умножение
        {
            Console.WriteLine("\nEnter the indices of the elements you want to multiply:");
           try
           {
                int a = Convert.ToInt32(Console.ReadLine()); int b = Convert.ToInt32(Console.ReadLine());
                return array[a] * array[b];
           }
           catch
           {
               status = false;
               Console.WriteLine("\nAn input exception was founded. Try again...");
               return -1;
           }

        }

        public void Output() //вывод
        {
            for(int i = 0; i < quantity; i++) {
                Console.WriteLine(array[i] + " ");
            }
            Console.WriteLine($"The status is {status}\n");
        }

        class Program
        {
            static void Main(string[] args)
            {

                Console.WriteLine("Quantity of elements in your array:");
                int quantity = Convert.ToInt32(Console.ReadLine());

                Vector v = new Vector(quantity);

                for (int i = 0; i < v.quantity; i++)
                {
                    v.array[i] = 0;
                }

                v.RandomFill();
                v.status = true;

                Console.WriteLine("Your original array: ");
                v.Output();

                Console.WriteLine("MENU:\n1)Add\n2)Multiply\n3)Output\n ");

                for (; ; )
                {
                    int choice;
                    Console.WriteLine($"Enter menu number: ");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1: Console.WriteLine(v.Add()); break;
                        case 2: Console.WriteLine(v.Multiply()); break;
                        case 3: v.Output(); break;
                        default: return;
                    }
                }              
            }
        }
    }
}