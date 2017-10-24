using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Используя циклы и метод: 
//Console.Write("*"), Console.Write(" "), Console.Write("\n") (для перехода на новую строку).  
 
//Выведите на экран: 
//· прямоугольник 
//· прямоугольный треугольник
//· равносторонний треугольник
//· ромб


namespace HomeWork_6_3
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите количество строк:");
			string k1 = Console.ReadLine();
			int k = Convert.ToInt32(k1);
			Console.WriteLine("Введите количество столбцов:");
			string n1 = Console.ReadLine();
			int n = Convert.ToInt32(n1);
			//Прямоугольник
			for (int i = 0 ; i < k  ; i++) 
			{
				for(int j = 0;j<n;j++)
				{
					Console.Write("*");
				}
				Console.Write("\n");
			}
			Console.Write("\n\n\n\n\n");

			//Прямоугольный треугольник
			for (int i = 0; i < k; i++)
			{
				for (int j = 0 ; j < n + 1 - k; j++)
				{
					Console.Write("*");
					
				}
				Console.Write("\n");
				n++;
			}
			Console.Write("\n\n\n\n\n\n");
		}
	}
}
