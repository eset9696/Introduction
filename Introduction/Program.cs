//#define CONSOLE_SETTINGS
//#define CONSOLE_INPUT
//#define SHOOTER
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Introduction
{
    internal class Program
    {
        const string delimeter = "\n-------------------------------------------------\n";
        static void Main(string[] args)
        {

#if CONSOLE_SETTINGS
            Console.Title = "Introduction to .NET";

            Console.Beep(1000, 500);
            int start_x = 10;
            int start_y = 10;

            int width = 120;
            int height = 30;

            //Console.SetWindowPosition(start_x, start_y);

            Console.SetWindowSize(width, height);
            Console.SetBufferSize(width, height);

            Console.WriteLine("Buffer width:\t" + Console.BufferWidth);
            Console.WriteLine("Buffer height:\t" + Console.BufferHeight);
            Console.WriteLine(delimeter);
            Console.WriteLine("Window width:\t" + Console.WindowWidth);
            Console.WriteLine("Wingow height:\t" + Console.WindowHeight);

            Console.Write("Hello .NET");
            Console.WriteLine();

            //Console.SetCursorPosition(20, 10);
            Console.CursorLeft = 50;
            Console.CursorTop = 8;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Cursor position check");
            Console.SetCursorPosition(25, 7);
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Cursor position check2");
            Console.BackgroundColor = ConsoleColor.Black; 
#endif

#if CONSOLE_INPUT
            Console.Write("Введите вашу фамилию:\t");
            string last_name = Console.ReadLine();
            Console.Write("Введите ваше имя:\t");
            string first_name = Console.ReadLine();
            Console.Write("Введите ваш возраст:\t");
            int age = Convert.ToInt32(Console.ReadLine());
            //1) Конкатенация строк:
            Console.WriteLine("Имя: " + first_name + " фамилия: " + last_name + " возраст: " + age + (age % 10 < 5 ? (age % 10 > 0 ? " год" : " лет") : " лет"));
            //2) Форматирование строк:
            Console.WriteLine(string.Format("Имя: {0}, фамилия: {1}, возраст: {2} лет", first_name, last_name, age));
            //3) Интерполяция строк:
            Console.WriteLine($"Имя: {{{first_name}}}, фамилия: {last_name}, возраст: {age} лет"); 
#endif

#if SHOOTER
            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.W) { Console.WriteLine("вперед"); }
                else if (key.Key == ConsoleKey.S) { Console.WriteLine("назад"); }
                else if (key.Key == ConsoleKey.A) { Console.WriteLine("влево"); }
                else if (key.Key == ConsoleKey.D) { Console.WriteLine("вправо"); }
                else if (key.Key == ConsoleKey.E) { Console.WriteLine("разминировать / заложить бомбу"); }
                else if (key.Key == ConsoleKey.Spacebar) { Console.WriteLine("прыжок"); }
                else if (key.Key == ConsoleKey.C) { Console.WriteLine("сесть"); }
                else if (key.Key == ConsoleKey.F) { Console.WriteLine("фонарик"); }
            } while (key.Key != ConsoleKey.Escape); 
#endif
            int size = 5;
            /*for (int i = 0; i < size; i++) 
            {
                for(int j = 0; j < size; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
            Console.WriteLine(delimeter);
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
            Console.WriteLine(delimeter);
            for (int i = size; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
            Console.WriteLine(delimeter);
            for (int i = size; i > 0; i--)
            {
                for (int k = 0; k < size - i; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
            Console.WriteLine(delimeter);
            for (int i = 0; i < size; i++)
            {
                for (int k = size - i - 1; k > 0; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
            Console.WriteLine(delimeter);
*/
            /*for (int i = 0; i < 2 * size; i++)
            {
                
                for (int k = size - i - 1; i <= size ? k > 0 : k >= 2 * (size - i); k--)
                {
                    Console.Write(" ");
                }
                Console.Write(i < size ? '/' : '\\');
                for  (int j = 1; i < size ? j <= i : j < (2 * size - i); j++)
                {
                    Console.Write("  ");
                }
                Console.Write(i < size ? '\\' : '/');
                Console.WriteLine();
            }
            Console.WriteLine(delimeter);

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write((i + j) % 2 == 0 ? " +" : " -");
                }
                Console.WriteLine();
            }
            Console.WriteLine(delimeter);*/
            Console.Write("Введите размер доски:\n");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++) 
            {
                for (int j = 0; j < n; j++)
                {
                        Console.Write((i + j) % 2 == 0 ? "██" : "  ");
                }
                Console.WriteLine();
            }

            /*Console.Write("Введите размер доски:\n");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите размер ячеек:\n");
            int n2 = Convert.ToInt32(Console.ReadLine());*/
            
        }
    }
}
