using System;

namespace Seminar6HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задайте двумерный массив размером m * n , заполненый случайными вещественными числами

            // double [,] Create2dArray (int m, int n){
            //     double [,] array = new double [m,n];
            //     Random rnd = new Random();
            //         for (int i=0; i<m; i++)
            //             for (int j=0; j<n; j++)
            //                 array [i,j] =  Convert.ToDouble (rnd.Next (-100,100)/10.0);
            //         return array;
            // }

            // void Show2dArray (double [,] array){
            //     for (int i = 0; i<array.GetLength(0); i++){
            //         Console.WriteLine();
            //         for (int j = 0; j <array.GetLength(1); j++){
            //             Console.Write (array[i,j] + "   ");
            //         }
            //     }
            // }

            // Console.WriteLine ( "Enter the number of rows: ");
            // int m = Convert.ToInt32 (Console.ReadLine());
            
            // Console.WriteLine ( "Enter the number of cols: ");
            // int n = Convert.ToInt32 (Console.ReadLine());
            
            // double [,] array = Create2dArray (m,n);
            // Show2dArray (array);

            
            // Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
            // и возвращает значение этого элемента или же указывает, что такого элемента нет
            
            int [,] Create2dArray (int rows, int cols){
                int [,] array = new int [rows, cols];
                    for (int i=0; i<rows; i++)
                        for (int j=0; j<cols; j++)
                            array [i,j] =  new Random().Next(1,100);
                    return array;
            }

            void Show2dArray (int [,] array){
                for (int i = 0; i<array.GetLength(0); i++){
                    Console.WriteLine();
                    for (int j = 0; j <array.GetLength(1); j++){
                        Console.Write (array[i,j] + "   ");
                    }
                }
            }

            int SearchEl (int [,] array, int a, int b){
            int element = 0;
                for (int i = 0; i<array.GetLength(0); i++){
                    Console.WriteLine();
                    for (int j = 0; j <array.GetLength(1); j++){
                        if (i==a-1 && j==b-1) element += array [i,j];
                    }
                }
                return element;
            }

            Console.WriteLine ( "Enter the element's position in row: ");
            int a = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine ( "Enter the element's position in col: ");
            int b = Convert.ToInt32 (Console.ReadLine());
            
            int rows = 15;
            int cols = 10;
            int [,] array = Create2dArray (rows,cols);
            Show2dArray (array);
            int result = SearchEl (array, a, b);
            Console.WriteLine ("Искомый элемент:" +result );


        }
    }
}
