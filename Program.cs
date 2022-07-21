/* Задача 47.Задайте двумерный массив размером m×n, заполненный случайными
            вещественными числами.
            m = 3, n = 4.
            0,5 7 - 2 - 0,2
            1 - 3,3 8 - 9,9
            8 7,8 - 7,1 9 */
            double[,] CreatAr(double[,] vs)
            {
                Random vsarr = new Random();
                for(int i=0;i<vs.GetLength(0);i++)
                {
                    for (int j = 0; j < vs.GetLength(1); j++)
                        vs[i, j] = (double)vsarr.Next(-100, 100) / 10;
                }
                return vs;
            }
            void PrintArr(double[,] vs)
            {
                for(int i=0;i<vs.GetLength(0); i++)
                {
                    for (int j = 0; j < vs.GetLength(1); j++)
                        Console.Write(vs[i, j] + "\t");
                    Console.WriteLine();
                }
                
            }
            void AvrgArr(int[,] arr)
            {
                double[] vs = new double[arr.GetLength(0)];
                for(int i=0;i<arr.GetLength(0);i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                        vs[i] = vs[i] + arr[i, j];
                }
                for (int i = 0; i < vs.Length; i++)
                    Console.Write(vs[i] / arr.GetLength(0) + "\t");
                Console.WriteLine();
            }
            
            double[,] array;
            int m, n;
            int[,] newarray = new int[10, 10];
            Console.Write("задать массив размером М х N.\n введите значение М :");
            m = int.Parse(Console.ReadLine());
            Console.Write("введите значение N :");
            n=int.Parse(Console.ReadLine());
            array = new double[m, n];
            CreatAr(array);
            PrintArr(array);
            /*Задача 50. Напишите программу, которая на вход принимает позиции элемента 
            в двумерном массиве, и возвращает значение этого элемента или же указание,
            что такого элемента нет.
            Например, задан массив:
            1 4 7 2
            5 9 2 3
            8 4 2 4
            17 -> такого числа в массиве нет*/
            Console.Write("программа принимает позицию элемента, возвращает значение,\n или что такого элемента нет\n введите значение строки :");
            m = Convert.ToInt32(Console.ReadLine());
            Console.Write("введите значение столбца :");
            n = Convert.ToInt32(Console.ReadLine());
            if (m > array.GetLength(0) | n > array.GetLength(1))
                Console.WriteLine("такого числа нет");
            else
                Console.WriteLine(array[m-1, n-1]);
            /*Задайте двумерный массив из целых чисел. 
             Найдите среднее арифметическое элементов в каждом столбце.
             Например, задан массив:
             1 4 7 2
             5 9 2 3
             8 4 2 4
             Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6;*/
            Console.WriteLine("найти среднее арифметическое каждого столбца массива ");
            Random newint = new Random();
            for (int i=0;i<newarray.GetLength(0);i++)
            {
                for (int j = 0; j < newarray.GetLength(1); j++)
                    newarray[i, j] = newint.Next(0, 100);
            }
            for (int i = 0; i < newarray.GetLength(0); i++)
                {
                for (int j=0; j < newarray.GetLength(1); j++)
                    Console.Write(newarray[i, j]+"\t");
                Console.WriteLine();
                 }

            AvrgArr(newarray);
            Console.ReadKey();