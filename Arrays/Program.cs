using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
	internal class Program
	{
		static readonly string delimeter =  "\n---------------------------------\n";
		static void Main(string[] args)
		{
            Console.Write("Введите размер массива: ");
			int n = Convert.ToInt32(Console.ReadLine());
			int[] arr = new int[n];
			Random rnd = new Random(0);
			for(int i = 0; i < n; i++)
			{
				arr[i] = rnd.Next(100);
			}
			for(int i = 0;i < n; i++)
			{
				Console.Write(arr[i] + " ");
			}
            Console.WriteLine();
            foreach (int i in arr)
            {
				Console.Write(i + " ");
			}
			Console.WriteLine();
			Console.WriteLine(delimeter);

			//////////////////////////////////////////////////////////////////////////////

			Console.Write("Введите количество строк массива: ");
			int rows = Convert.ToInt32(Console.ReadLine());
			Console.Write("Введите количество столбцов массива: ");
			int cols = Convert.ToInt32(Console.ReadLine());

			int[,] i_arr_2 = new int[rows, cols];
			for(int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					i_arr_2[i, j] = rnd.Next(100);
				}
			}
			for (int i = 0; i < i_arr_2.GetLength(0); i++)
			{
				for (int j = 0; j < i_arr_2.GetLength(1); j++)
				{
					Console.Write(i_arr_2[i,j] + "\t");
				}
                Console.WriteLine();
            }
            Console.WriteLine(i_arr_2.Rank);
            Console.WriteLine(i_arr_2.GetLength(0));
            Console.WriteLine(i_arr_2.GetLength(1));
			foreach (int i in i_arr_2)
			{
				Console.Write(i + "\t");
			}
            Console.WriteLine();
			Console.WriteLine(delimeter);
			///////////////////////////////////////////////////////////////////////////////////
			
			int[][] jagged_arr = new int[][] 
			{ 
				new int[]{3, 5, 8, 13, 21 },
				new int[]{34, 55, 89},
				new int[]{144, 233, 377}
			};
			for (int i = 0; i < jagged_arr.Length; i++) 
			{
				for(int j = 0; j < jagged_arr[i].Length; j++)
				{
					Console.Write(jagged_arr[i][j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine(delimeter);
            int[][,] jagged_arr_2 = new int[][,]
			{
				i_arr_2,
				new int[,]
				{
					{256, 384, 512, 768 },
					{1024, 2048, 3072, 4096 }
				}
			};
			for(int i = 0; i < jagged_arr_2.Length; i++)
			{
				for (int j = 0; j < jagged_arr_2[i].GetLength(0); j++)
				{
					for (int k = 0; k < jagged_arr_2[i].GetLength(1); k++)
					{
						Console.Write(jagged_arr_2[i][j,k] + "\t");
                    }
					Console.WriteLine();
                }
				Console.WriteLine();
			}
		}
	}
}
