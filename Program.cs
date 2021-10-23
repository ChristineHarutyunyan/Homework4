using System;
using System.Linq;

namespace ConsoleApp8
{
    class Program
    {
        static void Main()
        {
            #region Задание 1

            Console.WriteLine($"Месяц      Доход,тыс.руб.   Расход,тыс. руб.     Прибыль,тыс. руб.");

            int[,] array = new int[12, 3];
            Random r = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)

                {
                    int k, l;
                    if (j == 0 || j == 1)
                        array[i, j] = r.Next(70000, 200000) / 10;
                    else
                    {
                        k = j - 2; l = j - 1;
                        array[i, j] = (array[i, k] - array[i, l]) * 10;
                    }

                    Console.Write($"{i + 1}   {array[i, j],15}");

                }
                Console.WriteLine();
            }


            Console.WriteLine();

            int[] array1 = new int[12];
            //Console.WriteLine("New Array");

            Console.WriteLine();
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = array[i, 2];

                //Console.WriteLine($"{ array1[i],4}");

            }
            
            Array.Sort(array1);
            Console.Write(" Худшая прибыль в месяцах:  ");
            for (int i = 0; i < array.GetLength(0); i++)
            { 
            for (int j=0; j<array.GetLength(1); j++)
                {
                    if (array[i,j] == array1[0] || array[i,j] == array1[1] || array[i,j] == array1[2])
                    { Console.Write($"{i+1},"); }
                        }
            }
            Console.WriteLine();

            Array.Reverse(array1);
            Console.Write(" Месяцев с положительной прибылью:  ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] == array1[0])
                    { Console.Write($"{i + 1},"); }
                }
            }

            #endregion

            #region Задание 2

            //Console.Write("Введите количество строк : ");
            //int n = int.Parse(Console.ReadLine());

            //int[][] m = new int[8][];
            //m[0] = new int[1] { 1 };

            //for (int i = 1; i < m.Length; i++)
            //{
            //    m[i] = new int[i + 1];
            //    for (int j = 0; j <= i; j++)
            //    {
            //        if (j == 0 || j == i)
            //            m[i][j] = 1;
            //        else
            //        {
            //            m[i][j] = m[i - 1][j - 1] + m[i - 1][j];
            //        }
            //    }
            //}

            //for (int i = 0; i < m.Length; i++)
            //{
            //    for (int j = 0; j < m[i].Length; j++)
            //    {
            //        Console.Write("{0,5}", m[i][j]);
            //    }
            //    Console.WriteLine();
            //}

            //Console.ReadKey();






            #endregion

            #region Задание 3.1 


            //Console.WriteLine("количество строк:");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("количество столцов:");
            //int m = Convert.ToInt32(Console.ReadLine());



            //int[,] array = new int[n, m];
            //Console.WriteLine("");
            //Random r = new Random();

            //for (int i = 0; i <= n; i++)

            //{
            //    for (int j = 0; i <=m ; j++)
            //    {

            //        array[i, j] = r.Next(1, 10);
            //        Console.Write(array[i,j]);



            //    }
            //    Console.WriteLine();
            //}



            //Console.WriteLine("число:");

            //int x = Convert.ToInt32(Console.ReadLine());


            //for (int i = 0; i <= array.GetLength(0); i++)

            //{
            //    for (int j = 0; i <= array.GetLength(1); j++)
            //    {

            //        Console.WriteLine($"{x} * {array[i, j]}={x * array[i, j]}");


            //    }
            //}


            #endregion




        }
    }

}
