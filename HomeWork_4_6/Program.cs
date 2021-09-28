using System;

namespace HomeWork_4_6
{
    class Program
    {

        static void Main(string[] args)
        {
            int[,] stateAccaunting = new int[12, 4];
            CreateBase(ref stateAccaunting);
        }
        
       
        static void CreateBase(ref int[,] stateAccaunting)
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

    }

 }
