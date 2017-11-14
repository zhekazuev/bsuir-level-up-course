using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//	Класс Figure должен содержать конструкторы, которые принимают от 3-х до 5-ти аргументов типа Point. 
//Создать два метода: double LengthSide(Point A, Point B), который рассчитывает длину стороны многоугольника;
//void PerimeterCalculator(), который рассчитывает периметр многоугольника.

namespace HomeWork_1_3_primer
{
	class Figure
	{
		int number;
		Point[] points;
		string name;
		public string Name
		{
			get
			{
				return name;
			}
			set
			{
				name = value;
			}
		}
		public void InitializeFigure()
		{
			Console.WriteLine("enter number of verticles of your figure");
			number = int.Parse(Console.ReadLine());
			points = new Point[number];
			for (int i = 0; i < points.Length; i++)
			{
				points[i] = new Point();
			}

		}
		public double LengthSide(Point a, Point b)
		{
			return Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
		}
		public double CalculatePerimeter()
		{
			double perimeter = 0;
			for (int i = 1; i < points.Length; i++)
			{
				perimeter += this.LengthSide(points[i - 1], points[i]);
			}
			perimeter += this.LengthSide(points[0], points[points.Length - 1]);
			return perimeter;
		}
		public Figure(string name)
		{
			InitializeFigure();
		}
	}
}
