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
			int arr_sum = array_sum(arr);
			double arr_avg = array_AVG(arr);
			int arr_max = array_max(arr);
			int arr_min = array_min(arr);





			Console.WriteLine("Arr sum: " + arr_sum);
			Console.WriteLine("Arr avg: " + arr_avg);
			Console.WriteLine("Arr max: " + arr_max);
			Console.WriteLine("Arr min: " + arr_min);
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
			/*foreach (int i in i_arr_2)
			{
				Console.Write(i + "\t");
			}
            Console.WriteLine();*/

			//hw
			int i_arr_2_sum = array_sum(i_arr_2);

			double i_arr_2_avg = array_AVG(i_arr_2);

			int i_arr_2_max = array_max(i_arr_2);

			int i_arr_2_min = array_min(i_arr_2);

			Console.WriteLine("Arr sum: " + i_arr_2_sum);
			Console.WriteLine("Arr avg: " + i_arr_2_avg);
			Console.WriteLine("Arr max: " + i_arr_2_max);
			Console.WriteLine("Arr min: " + i_arr_2_min);
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
			int jagged_arr_sum = array_sum(jagged_arr);

			double jagged_arr_avg = array_AVG(jagged_arr);

			int jagged_arr_max = array_max(jagged_arr);

			int jagged_arr_min = array_min(jagged_arr);
			

			Console.WriteLine("Arr sum: " + jagged_arr_sum);
			Console.WriteLine("Arr avg: " + jagged_arr_avg);
			Console.WriteLine("Arr max: " + jagged_arr_max);
			Console.WriteLine("Arr min: " + jagged_arr_min);
			//hw end

			////////////////////////////////////////////////////////////////////////////////////////

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
			int jagged_arr_2_sum = array_sum(jagged_arr_2);
			

			
			double jagged_arr_2_avg = array_AVG(jagged_arr_2);

			int jagged_arr_2_max = array_max(jagged_arr_2);
			

			int jagged_arr_2_min = array_min(jagged_arr_2);
			

			Console.WriteLine("Arr sum: " + jagged_arr_2_sum);
			Console.WriteLine("Arr avg: " + jagged_arr_2_avg);
			Console.WriteLine("Arr max: " + jagged_arr_2_max);
			Console.WriteLine("Arr min: " + jagged_arr_2_min);
			//hw end
		}

		static int array_sum(int[] arr)
		{
			//int sum = arr.Sum();
			int sum = 0;
			foreach (int i in arr)
			{
				sum += i;
			}
			return sum;
		}

		static int array_sum(int[,] arr)
		{
			int sum = 0;
			foreach (int i in arr)
			{
				sum += i;
			}
			return sum;
		}

		static int array_sum(int[][] arr)
		{
			int sum = 0;
			for (int i = 0; i < arr.GetLength(0); i++)
			{
				sum += array_sum(arr[i]);
			}
			return sum;
		}

		static int array_sum( int[][,] arr)
		{
			int sum = 0;
			for (int i = 0; i < arr.GetLength(0); i++)
			{
				sum += array_sum(arr[i]);
			}
			return sum;
		}

		static double array_AVG(int[] arr)
		{
			//return arr.Average();
			return array_sum(arr) / (double)arr.Length;
		}

		static double array_AVG(int[,] arr)
		{
			return array_sum(arr) / (double)arr.Length;
		}

		static double array_AVG(int[][] arr)
		{
			double count = 0;
			for (int i = 0; i < arr.GetLength(0); i++)
			{
				count += arr[i].Length;
			}
			return array_sum(arr) / count;
		}

		static double array_AVG(int[][,] arr)
		{
			double count = 0;
			for (int i = 0; i < arr.GetLength(0); i++)
			{
				count += arr[i].Length;
			}
			return array_sum(arr) / count;
		}

		static int array_max(int[] arr)
		{
			//int max = arr.Max();
			int max = arr[0];
			foreach (int i in arr)
			{
				if (i > max) max = i;
			}
			return max;
		}

		static int array_max(int[,] arr)
		{
			int max = arr[0, 0];
			foreach (int i in arr)
			{
				if (i > max) max = i;
			}
			return max;
		}

		static int array_max(int[][] arr)
		{
			int max = arr[0][0];
			for (int i = 0; i < arr.GetLength(0); i++)
			{
				foreach (int j in arr[i])
				{
					if (j > max) max = j;
				}
			}
			return max;
		}

		static int array_max(int[][,] arr)
		{
			int max = arr[0][0, 0];
			for (int i = 0; i < arr.GetLength(0); i++)
			{
				foreach (int j in arr[i])
				{
					if (j > max) max = j;
				}
			}
			return max;
		}

		static int array_min(int[] arr)
		{
			//int min = arr.Min();
			int min = arr[0];
			foreach (int i in arr)
			{
				if (i < min) min = i;
			}
			return min;
		}

		static int array_min(int[,] arr)
		{
			int min = arr[0, 0];
			foreach (int i in arr)
			{
				if (i < min) min = i;
			}
			return min;
		}

		static int array_min(int[][] arr)
		{
			int min = arr[0][0];
			for (int i = 0; i < arr.GetLength(0); i++)
			{
				foreach (int j in arr[i])
				{
					if (j < min) min = j;
				}
			}
			return min;
		}

		static int array_min(int[][,] arr)
		{
			int min = arr[0][0, 0];
			for (int i = 0; i < arr.GetLength(0); i++)
			{
				foreach (int j in arr[i])
				{
					if (j < min) min = j;
				}
			}
			return min;
		}
	}
}
