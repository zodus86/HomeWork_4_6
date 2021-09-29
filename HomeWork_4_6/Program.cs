using System;

namespace HomeWork_4_6
{
    class Program
    {

        static void Main(string[] args)
        {
            int[,] stateAccaunting = new int[12, 4];
            CreateBase(stateAccaunting);


            Console.WriteLine("\n Pascal");
            PritPascal(10);

            
            Console.WriteLine("Исходные две матрицы");
            int[,] matrix1 = { { 3, 4, 5 }, { 7, 6, 10 } , { 3, 2, 7 } };
            int[,] matrix2 = { { 2, 9, 8}, { 3, 2, 7 } , { 7, 6, 10 } };
            
            Calc.PrintMatrix(matrix1);
            Console.WriteLine();
            Calc.PrintMatrix(matrix2);

            Console.WriteLine("\nдействия Умножить на число 5.");
            Calc.PrintMatrix(Calc.MatrixMultiplication(matrix1, 5));
 
            Console.WriteLine("\nдействия Сумма матрицы");
            Calc.PrintMatrix(Calc.SummMatrix(matrix1, matrix2));

            Console.WriteLine("\nдействия Разница матрицы");
            Calc.PrintMatrix(Calc.Minus(matrix1, matrix2));

            Console.WriteLine("\nдействия Произведение матрицы");
            Calc.PrintMatrix(Calc.MultiMatrix(matrix1, matrix2));
        }
        
       
        static void CreateBase(int[,] stateAccaunting)
        {
            Random random = new Random();
            int temp = 0;
            Console.WriteLine($"{"Номер месяца",15} {"Доход",15} {"Расход",15} {"Прибыль",15}");
            int[] array = new int[12];

            for (int i = 0; i < 12; i++)
            {
                stateAccaunting[i, 0] = i + 1;
                stateAccaunting[i, 1] = random.Next(1, 1000);
                stateAccaunting[i, 2] = random.Next(1, 1000);
                stateAccaunting[i, 3] = stateAccaunting[i, 1] - stateAccaunting[i, 2];
                array[i] = stateAccaunting[i, 3];
                
                Console.WriteLine($"{stateAccaunting[i, 0],15} {stateAccaunting[i, 1],15} " +
                    $"{stateAccaunting[i, 2],15} {stateAccaunting[i, 3],15}");
                
                if (array[i] > 0)
                    temp++;
                
            }
            //количество месяцев с положительной прибылью. 
            Console.WriteLine($"\nКоличество месяцев с положительно прибулью = {temp}");

            Array.Sort(array);
           
            //Важно определить три месяца с наименьшей прибылью
            temp = array[0];
            Console.Write($"Три месяца с наименьшей прибылью = {temp} ");
            int count = 1;
            for (int i = 1; i< 12 && count < 3 ; i++)
            { 
                if (temp != array[i])
                {
                    count++;
                    Console.Write( $" {array[i]} ");

                }
                temp = array[i];
                
            }
            Console.WriteLine();

        } 


        /// <summary>
        /// Создание и печать паскаля
        /// </summary>
        /// <param name="size"></param>
        static void PritPascal(int size)
        {
            int[,] a = new int[size, size];

            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    a[i, j] = 1 + j + i;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j <= i; j++)
                    Console.Write("{0}{1}", a[i, j], "\t");
                Console.WriteLine();

            }

        }



    }
 }
