﻿#define ARRAYS_1
#define ARRAYS_2
//#define JAGGED_ARRAY
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Arrays
{
	internal class Program
	{
		static void Main(string[] args)
		{
#if ARRAYS_1
			Console.Write("Введите размер массива: ");
			int n = Convert.ToInt32(Console.ReadLine());
			//int[] arr= new int[] { 3, 5, 8, 13, 21 };
			int[] arr = new int[n];
			Random rand = new Random(); // 0-seed value
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = rand.Next(100);

			}
			for (int i = 0; i < arr.Length; i++)
			{
				Console.Write(arr[i] + "\t");
			}
			Console.WriteLine(); 
			foreach (int i in arr)
			{
				Console.Write(i+"\t");
			}
			Console.WriteLine();
#endif

#if ARRAYS_2
			Console.Write("Введите количество строк: ");
			int rows = Convert.ToInt32(Console.ReadLine());

			Console.Write("Введите количество элементов строки :");
			int cols = Convert.ToInt32(Console.ReadLine());

			int[,] i_arr_2 = new int[rows, cols];

			Console.WriteLine(i_arr_2.Rank);
			//Random rand = new Random(0);
			for (int i = 0; i < i_arr_2.GetLength(0); i++)
			{
				for (int j = 0; j < i_arr_2.GetLength(1); j++)
				{
					i_arr_2[i, j] = rand.Next(100);
				}
			}
			for (int i = 0; i < i_arr_2.GetLength(0); i++)
			{
				for (int j = 0; j < i_arr_2.GetLength(1); j++)
				{
					Console.Write(i_arr_2[i, j] + "\t");
				}
				Console.WriteLine();
			} 
			foreach (int i in i_arr_2)
			{
				Console.Write(i+"\t");
			}
			Console.WriteLine();
			// сортировать сквозной сортировкой 
#endif

#if JAGGED_ARRAY
			int[][] arr_jagget = new int[][]
				{
				new int[]{0, 1, 1, 2 },
				new int[]{3, 5, 8, 13, 21 },
				new int[]{34, 55, 89 },
				new int[]{144, 233, 377, 610, 987 }

				};
			for (int i = 0; i < arr_jagget.Length; i++)
			{
				for (int j = 0; j < arr_jagget[i].Length; j++)
				{
					Console.Write(arr_jagget[i][j] + "\t");
				}
				//Console.Write("\n");
				Console.WriteLine();
			} 
#endif


		}
	}
}
