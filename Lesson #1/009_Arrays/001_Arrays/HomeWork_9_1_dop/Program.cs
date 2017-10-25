using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
//Создайте массив размерностью в 10 элементов, выведите на экран все элементы массива в обратном порядке.


namespace HomeWork_9_1_dop
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] Massive = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

			for(int i = Massive.Length - 1 ; i >= 0 ; i--)
			{
				Console.Write(Massive[i]);
			}

			Console.ReadKey();
		}
	}
}
