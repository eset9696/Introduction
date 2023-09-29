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
			Random rnd = new Random();
			FillRand(arr);
			Print(arr);
			Console.WriteLine("sum: " + arr.Sum());
			Console.WriteLine("AVG: " + arr.Average());
			Console.WriteLine("Max: " + arr.Max());
			Console.WriteLine("Min: " + arr.Min());
			Console.WriteLine(delimeter);

			double[] d_arr = new double[n];
			FillRand(d_arr);
			Print(d_arr);
			//////////////////////////////////////////////////////////////////////////////

			Console.Write("Введите количество строк массива: ");
			int rows = Convert.ToInt32(Console.ReadLine());
			Console.Write("Введите количество столбцов массива: ");
			int cols = Convert.ToInt32(Console.ReadLine());

			int[,] i_arr_2 = new int[rows, cols];
			FillRand(i_arr_2);
			Print(i_arr_2);
			Console.WriteLine("sum: " + i_arr_2.Cast<int>().Sum());
			Console.WriteLine("AVG: " + i_arr_2.Cast<int>().Average());
			Console.WriteLine("Max: " + i_arr_2.Cast<int>().Max());
			Console.WriteLine("Min: " + i_arr_2.Cast<int>().Min());
			Console.WriteLine(i_arr_2.Rank);
            Console.WriteLine(i_arr_2.GetLength(0));
            Console.WriteLine(i_arr_2.GetLength(1));
			Console.WriteLine(delimeter);
			///////////////////////////////////////////////////////////////////////////////////
			
			int[][] jagged_arr = new int[][] 
			{ 
				new int[]{3, 5, 8, 13, 21 },
				new int[]{34, 55, 89},
				new int[]{144, 233, 377},
				arr
			};
			Print(jagged_arr);
			Console.WriteLine("sum: " + Sum(jagged_arr));
			Console.WriteLine("AVG: " + (double)Sum(jagged_arr) / Count(jagged_arr));
			/*Console.WriteLine("Max: " + jagged_arr.Cast<int>().Max());
			Console.WriteLine("Min: " + jagged_arr.Cast<int>().Min());*/
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
		public static void FillRand(int[] arr)
		{
			Random rand = new Random(0);
			for(int i = 0;i < arr.Length;i++)
			{
				arr[i] = rand.Next(100);
			}
		}

		public static void FillRand(double[] arr)
		{
			Random rand = new Random(0);
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = (double) rand.Next(100) / 10;
			}
		}

		public static void FillRand(int[,] arr)
		{
			Random rand = new Random(0);
			for (int i = 0; i < arr.GetLength(0); i++)
			{
				for (int j = 0; j < arr.GetLength(1); j++)
				{
					arr[i, j] = rand.Next(100); 
				}
			}
		}

		public static void Print<T>(T[] arr)
		{
			for (int i = 0; i < arr.Length; i++)
			{
				Console.Write(arr[i] + "\t");
			}
            Console.WriteLine();
        }

		public static void Print<T>(T[,] arr)
		{
			for (int i = 0; i < arr.GetLength(0); i++)
			{
				for (int j = 0; j < arr.GetLength(1); j++)
				{
					Console.Write(arr[i, j] + "\t"); 
				}
				Console.WriteLine();
			}
		}

		public static void Print<T>(T[][] arr)
		{
			for (int i = 0; i < arr.GetLength(0); i++)
			{
				for (int j = 0; j < arr[i].Length; j++)
				{
					Console.Write(arr[i][j] + "\t");
				}
				Console.WriteLine();
			}
		}

		public static int Sum(int[][] arr)
		{
			int sum = 0;
			foreach (int[] i in arr) 
			{
				sum += i.Sum();
			}
			return sum;
		}

		public static int Count(int[][] arr)
		{
			int count = 0;
			foreach (int[] i in arr)
			{
				count += i.Length;
			}
			return count;
		}
	}
}
