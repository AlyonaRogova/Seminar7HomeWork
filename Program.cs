using System;

namespace Seminar6HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задайте двумерный массив размером m * n , заполненый случайными вещественными числами

            double [,] Create2dArray (int m, int n){
                double [,] array = new double [m,n];
                Random rnd = new Random();
                    for (int i=0; i<m; i++)
                        for (int j=0; j<n; j++)
                            array [i,j] =  Convert.ToDouble (rnd.Next (-100,100)/10.0);
                    return array;
            }

            void Show2dArray (double [,] array){
                for (int i = 0; i<array.GetLength(0); i++){
                    Console.WriteLine();
                    for (int j = 0; j <array.GetLength(1); j++){
                        Console.Write (array[i,j] + "   ");
                    }
                }
            }

            Console.WriteLine ( "Enter the number of rows: ");
            int m = Convert.ToInt32 (Console.ReadLine());
            
            Console.WriteLine ( "Enter the number of cols: ");
            int n = Convert.ToInt32 (Console.ReadLine());
            
            double [,] array = Create2dArray (m,n);
            Show2dArray (array);

        }
    }
}
