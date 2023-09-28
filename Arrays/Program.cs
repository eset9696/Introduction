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
			//hw
			int arr_sum = arr.Sum();
			int arr_sum1 = 0;
			foreach (int i in arr)
            {
				arr_sum1 += i;
			}
			
			double arr_avg = arr.Average();
			double arr_avg1 = arr_sum1 / (double)arr.Length;

			int arr_max = arr.Max();
			int arr_max1 = arr[0];
			foreach (int i in arr)
			{
				if (i > arr_max1) arr_max1 = i;
			}

			int arr_min = arr.Min();
			int arr_min1 = arr[0];
			foreach (int i in arr)
			{
				if (i < arr_min1) arr_min1 = i;
			}
			
			Console.WriteLine("Arr sum: " + arr_sum + " " + arr_sum1);
			Console.WriteLine("Arr avg: " + arr_avg + " " + arr_avg1);
			Console.WriteLine("Arr max: " + arr_max + " " + arr_max1);
			Console.WriteLine("Arr min: " + arr_min + " " + arr_min1);
			//hw end
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

			//hw
			int i_arr_2_sum1 = 0;
			foreach (int i in i_arr_2)
			{
				i_arr_2_sum1 += i;
			}

			double i_arr_2_avg1 = i_arr_2_sum1 / (double)i_arr_2.Length;

			int i_arr_2_max1 = i_arr_2[0, 0];
			foreach (int i in i_arr_2)
			{
				if (i > i_arr_2_max1) i_arr_2_max1 = i;
			}

			int i_arr_2_min1 = i_arr_2[0, 0];
			foreach (int i in i_arr_2)
			{
				if (i < i_arr_2_min1) i_arr_2_min1 = i;
			}

			Console.WriteLine("Arr sum: " + i_arr_2_sum1);
			Console.WriteLine("Arr avg: " + i_arr_2_avg1);
			Console.WriteLine("Arr max: " + i_arr_2_max1);
			Console.WriteLine("Arr min: " + i_arr_2_min1);
			//hw end

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
			//hw
			int jagged_arr_sum1 = 0;
			for (int i = 0; i < jagged_arr.GetLength(0); i++)
			{
				foreach (int j in jagged_arr[i])
				{
					jagged_arr_sum1 += j;
				} 
			}

			double count = 0;
			for(int i = 0; i < jagged_arr.GetLength(0); i++)
			{
				count += jagged_arr[i].Length;
			}
			double jagged_arr_avg1 = jagged_arr_sum1 / count;

			int jagged_arr_max1 = jagged_arr[0][0];
			for (int i = 0; i < jagged_arr.GetLength(0); i++)
			{
				foreach (int j in jagged_arr[i])
				{
					if (j > jagged_arr_max1) jagged_arr_max1 = j;
				} 
			}

			int jagged_arr_min1 = jagged_arr[0][0];
			for (int i = 0; i < jagged_arr.GetLength(0); i++)
			{
				foreach (int j in jagged_arr[i])
				{
					if (j < jagged_arr_min1) jagged_arr_min1 = j;
				}
			}

			Console.WriteLine("Arr sum: " + jagged_arr_sum1);
			Console.WriteLine("Arr avg: " + jagged_arr_avg1);
			Console.WriteLine("Arr max: " + jagged_arr_max1);
			Console.WriteLine("Arr min: " + jagged_arr_min1);
			//hw end



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


			//hw
			int jagged_arr_2_sum1 = 0;
			for (int i = 0; i < jagged_arr_2.GetLength(0); i++)
			{
				foreach (int j in jagged_arr_2[i])
				{
					jagged_arr_2_sum1 += j;
				}
			}

			double count_2 = 0;
			for (int i = 0; i < jagged_arr_2.GetLength(0); i++)
			{
				count_2 += jagged_arr_2[i].Length;
			}
			double jagged_arr_2_avg1 = jagged_arr_2_sum1 / count_2;

			int jagged_arr_2_max1 = jagged_arr_2[0][0 , 0];
			for (int i = 0; i < jagged_arr_2.GetLength(0); i++)
			{
				foreach (int j in jagged_arr_2[i])
				{
					if (j > jagged_arr_2_max1) jagged_arr_2_max1 = j;
				}
			}

			int jagged_arr_2_min1 = jagged_arr_2[0][0, 0];
			for (int i = 0; i < jagged_arr_2.GetLength(0); i++)
			{
				foreach (int j in jagged_arr_2[i])
				{
					if (j < jagged_arr_2_min1) jagged_arr_2_min1 = j;
				}
			}

			Console.WriteLine("Arr sum: " + jagged_arr_2_sum1);
			Console.WriteLine("Arr avg: " + jagged_arr_2_avg1);
			Console.WriteLine("Arr max: " + jagged_arr_2_max1);
			Console.WriteLine("Arr min: " + jagged_arr_2_min1);
			//hw end
		}
	}
}
