//#define LOGICAL_TYPES
//#define CHARACTER_TYPES
//#define INTEGRAL_TYPES
//#define FLOATING_TYPES
#define VARIABLES_TASK
//#define CALCULATOR
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
	internal class Program
	{
		static readonly string delimeter = "\n----------------------------------\n";

		static void Main(string[] args)
		{
			//Object
#if LOGICAL_TYPES
			Console.WriteLine("BOOL:");
			Console.WriteLine(sizeof(bool)); // Boolean
			Console.WriteLine(true.GetType());

			Console.WriteLine(delimeter);
#endif

#if CHARACTER_TYPES
			Console.WriteLine("CHAR:"); // Хранит 1 символ в кодировке Юникод
			Console.WriteLine(sizeof(char));
			Console.WriteLine((int)char.MinValue);
			Console.WriteLine((int)char.MaxValue);

			Console.WriteLine(delimeter);
#endif

#if INTEGRAL_TYPES
			Console.WriteLine("short:");
			Console.WriteLine(sizeof(short));
			Console.WriteLine("USHORT:\t" + ushort.MinValue + "..." + ushort.MaxValue);
			Console.WriteLine("SHORT:\t" + short.MinValue + "..." + short.MaxValue);

			Console.WriteLine(delimeter);

			Console.WriteLine("INT:");
			Console.WriteLine(sizeof(int));
			Console.WriteLine("UINT:\t" + uint.MinValue + "..." + uint.MaxValue);
			Console.WriteLine("INT:\t" + int.MinValue + "..." + int.MaxValue);

			Console.WriteLine(delimeter);

			Console.WriteLine("LONG:");
			Console.WriteLine(sizeof(long));
			Console.WriteLine("ULONG:\t" + ulong.MinValue + "..." + ulong.MaxValue);
			Console.WriteLine("LONG:\t" + long.MinValue + "..." + long.MaxValue);
#endif

#if FLOATING_TYPES
			Console.WriteLine("FLOAT:\t" + sizeof(float) + " bytes");
			Console.WriteLine(float.MinValue + "..." + float.MaxValue);
			Console.WriteLine(delimeter);
			Console.WriteLine("DOUBLE:\t" + sizeof(double) + " bytes");
			Console.WriteLine(double.MinValue + "..." + double.MaxValue);
			Console.WriteLine(delimeter);
			Console.WriteLine("DECIMAL:\t" + sizeof(decimal) + " bytes");
			Console.WriteLine(decimal.MinValue + "..." + decimal.MaxValue); 
#endif

#if VARIABLES_TASK
			//#1
			Console.WriteLine("Преобразование числа в денежный формат.");
			Console.WriteLine("Введите дробное число:");
			double num = Convert.ToDouble(Console.ReadLine().Replace('.', ','));
			int integ = (int)num;
			int fraction = (int)((num - integ) * 100 + 0.00000001);
			Console.WriteLine($"{num} руб. это {integ} руб. {fraction} коп.");

			//#2
			/*Console.WriteLine("Вычисление стоимости покупки.");
			Console.WriteLine("Введите исходные данные:");
			double result = 0;
			Console.WriteLine("Цена тетради:");
			double note_price = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Количество тетрадей:");
			int note_quantity = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Цена караднаша:");
			double pencil_price = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Количество карандашей:");
			int pencil_quantity = Convert.ToInt32(Console.ReadLine());
			result = note_price * note_quantity + pencil_price * pencil_quantity;
			Console.WriteLine($"Стоимость покупки: {result} руб.");*/

			//#3
			/*Console.WriteLine("Вычисление стоимости покупки.");
			Console.WriteLine("Введите исходные данные:");
			double result = 0;
			Console.WriteLine("Цена тетради:");
			double note_price = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Цена обложки:");
			double cover_price = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Количество комплектов:");
			int quantity = Convert.ToInt32(Console.ReadLine());
			result = (note_price + cover_price) * quantity;
			Console.WriteLine($"Стоимость покупки: {result} руб.");*/

			//#4
			/*Console.WriteLine("Вычисление стоимости поездки на дачу туда и обратно.");
			double result = 0;
			Console.WriteLine("Расстояние до дачи:");
			double distance = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Расход бензина (литров на 100 км.):");
			double consumption = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Цена бензина (руб.):");
			double petrol_price = Convert.ToDouble(Console.ReadLine());
			result = (2 * distance / 100) * consumption * petrol_price;
			Console.WriteLine($"Поездка на дачу и обратно обойдется в {result} руб.");*/
#endif

#if CALCULATOR
            Console.WriteLine("Введите левый операнд:\t");
			double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите правый операнд:\t");
			double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Выберите действе (+ - * / ^ %):\t");
			char op = Convert.ToChar(Console.ReadLine());
			double result;
			switch (op)
			{
				case '+':
					result = num1 + num2;
					break;
				case '-':
					result = num1 - num2;
					break;
				case '*':
					result = num1 * num2;
					break;
				case '/':
					result = num1 / num2;
					break;
				case '^':
					result = Math.Pow(num1, num2);
					break;
				case '%':
					int inum1 = (int)num1;
					int inum2 = (int)num2;
					result = inum1 % inum2;
					break;
				default:
					result = 0;
					Console.WriteLine("Выбрано неверное действие!");
					break;
			}
			Console.WriteLine($"{num1} {op} {num2} = {result}");
#endif
		}
	}
}
