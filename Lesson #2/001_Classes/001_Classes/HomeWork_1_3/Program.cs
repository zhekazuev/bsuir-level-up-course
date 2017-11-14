using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Используя Visual Studio, создайте проект по шаблону Console Application.
// Требуется:  
// Создать классы Point и Figure.
// Написать программу, которая выводит на экран название и периметр многоугольника. 


namespace HomeWork_1_3
{
	class Program
	{
		static void Main(string[] args)
		{
			Figure figure = new Figure();

			Console.WriteLine("Введите количество точек в фигуре");
			int k = int.Parse(Console.ReadLine());
			Console.WriteLine("Количество точек в фигуре = {0}", k);

			// Вывод значения перимтра из поля из класса Figure
			Console.WriteLine("Периметр = {0}", figure.Perimeter(figure.Init(k)));
		}
	}
}
