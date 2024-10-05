using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.SetBufferSize(Console.WindowWidth, Console.WindowHeight);
			Random random = new Random();
			int x = random.Next(Console.WindowWidth);
			int y=random.Next(Console.WindowHeight);
			Console.CursorVisible = false;
			ConsoleKey key;

			do
			{
				Console.Clear();
				Console.SetCursorPosition(0,0);
				Console.ResetColor();
				Console.WriteLine($"x={x}\t y={y}");
				Console.SetCursorPosition(x, y);
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.WriteLine((char)2);
				key = Console.ReadKey(true).Key;
				switch (key)
				{
					    case ConsoleKey.UpArrow:
						case ConsoleKey.W: y--; break;
						case ConsoleKey.DownArrow:
						case ConsoleKey.S: y++; break;
						case ConsoleKey.LeftArrow:
						case ConsoleKey.A: x--; break;
						case ConsoleKey.RightArrow:	
						case ConsoleKey.D: x++; break;
					//case ConsoleKey.W : y--; break;
					//case ConsoleKey.S : y++;	break;
					//case ConsoleKey.A : x--;	break;
					//case ConsoleKey.D : x++;	break;
				}
				if (x==0||y==0 || x==Console.WindowWidth || y==Console.WindowHeight) Console.Beep();
				if (x == 0) x = 1;
				if (x == Console.WindowWidth)x = Console.WindowWidth - 1;
				if (y == 0) y = 1;
				if(y== Console.WindowHeight)y = Console.WindowHeight - 1;
			} while (key !=ConsoleKey.Escape);
		}
	}
}
