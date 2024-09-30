//#define CONSOLE_CLASS
//#define FIGURE0
//#define FIGURE1
//#define FIGURE2
//#define FIGURE3
//#define FIGURE4
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introductionToDOTNET
{
    internal class Program
    {
        static readonly string delimiter = "\n----------------------------\n";
        static void Main(string[] args)
        {
#if CONSOLE_CLASS
            Console.Title = "Introduction to .NET";
            Console.WriteLine("\t\t\tHello .NET");
            //Console.CursorLeft = 25;
            //Console.CursorTop = 8;
            Console.SetCursorPosition(21, 5);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Привет .NET");
            Console.ResetColor();

			Console.WriteLine(delimiter);
            Console.WriteLine("Позиция окна консоли: " + Console.WindowLeft + " знакопозиций");
            Console.WriteLine("Позиция окна консоли: " + Console.WindowTop + " знакопозиций");

            Console.SetWindowSize(91, 22);
            Console.WriteLine("Ширина окна консоли: " + Console.WindowWidth + " знакопозиций");
            Console.WriteLine("Высота окна консоли: " + Console.WindowHeight + " знакопозиций");


            Console.SetBufferSize(91, 22);
            Console.WriteLine("Ширина буфера консоли: " + Console.BufferWidth + " знакопозиций");
            Console.WriteLine("Высота буфера консоли: " + Console.BufferHeight + " знакопозиций");  
#endif
#if STRING_OPERATIONS
			Console.Write("Введите ваше имя: ");
            string first_name = Console.ReadLine();

            Console.Write("Введите вашу фамилию: ");
            string last_name = Console.ReadLine();

            Console.Write("Введите ваш возраст: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(first_name + " " + last_name + " " + age);//Конкатенация строк
            Console.WriteLine(String.Format("{0} {1} {2}", first_name, last_name, age));//форматирование строк
            Console.WriteLine($"{first_name}{last_name}{age}");//интерполяция строк  
#endif
#if FIGURE0
			for (int i = 0; i < 5; i++)
                Console.WriteLine("*****"); 
#endif
#if FIGURE1
            //int n = 1 ;
            int row = 5;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.ReadLine(); 
#endif
#if FIGURE2
            int row = 5;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < row - i; j++)
                    Console.Write("*");
                {
                    Console.WriteLine(" ");
                }
                for (int k = 0; k <= i; k++)
                {
                    Console.Write("");
                }
            }

            Console.ReadLine(); 
#endif
#if FIGURE3
            int row = 5;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < row - i; j++)
                    Console.Write("*");
                {
                    Console.WriteLine(" ");
                }
                for (int k = 0; k <= i; k++)
                {
                    Console.Write(" ");
                } 
            }
#endif
#if FIGURE4
            int row = 6;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < i; j++)
                    Console.Write("*");
                {
                    Console.WriteLine("");
                }
                for (int k = 0; k < row - i; k++)
                {
                    Console.Write(" ");
                }
            } 
#endif
			
		}
	}
}
