﻿using System;

//Старый немного исправленный под мою систему код:

//namespace l1_1
//{
//    class MyThread
//    {
//        public int Count;
//        public void Run()
//        {
//            Console.WriteLine("Новий потiк запущено.");
//            Console.Write("Пiдрахунок: ");
//            do
//            {
//                Thread.Sleep(500);
//                Console.Write(Count + " ");
//                Count++;
//            } while (Count <= 10);

//        }
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            MyThread mt = new MyThread();
//            Thread newThrd = new Thread(mt.Run); // створюється потiк
//            Console.WriteLine("Головний потiк пiдрахунок = " + mt.Count);

//            newThrd.Start(); // запуск нового потоку
//            for (int i = 20; i <= 30; i++)
//            {
//                Thread.Sleep(500);
//                Console.WriteLine("\t Головний потiк = " + i);
//            }
//            newThrd.Join(); // очiкування завершення нового потоку
//            Console.WriteLine("\nНовий потiк закiнчено.");
//            Console.WriteLine("\t Головний потiк пiдрахунок = " + mt.Count);

//            Console.ReadKey();
//        }
//    }
//}

//Новый код:

namespace l1_1
{
    class Program
    {


        public static int Run(int a, int b)
        {


            Thread.Sleep(699);
            Console.Write("\t Головний потiк = " + b + "\n" + (b - 20));

            a++;

            return a;
        }

        static void Main(string[] args)
        {
            int mt = 0;
            Console.WriteLine("Головний потiк пiдрахунок = " + mt);
            Console.WriteLine("Новий потiк запущено.");
            Console.Write("Пiдрахунок:");

            for (int i = 20; i <= 30; i++)
            {
                mt = Run(mt, i);
            }

            Console.WriteLine("\nНовий потiк закiнчено.");
            Console.WriteLine("\t Головний потiк пiдрахунок = " + mt);
            Console.ReadKey();
        }
    }
}