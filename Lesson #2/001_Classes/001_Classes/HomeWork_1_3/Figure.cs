using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Класс Figure должен содержать конструкторы, которые принимают от 3-х до 5-ти аргументов типа Point. 
// Создать два метода: double LengthSide(Point A, Point B), который рассчитывает длину стороны многоугольника;
// void PerimeterCalculator(), который рассчитывает периметр многоугольника.

namespace HomeWork_1_3
{
	class Figure
	{
		public Point[] Init(int n)
		{
			Point[] points = new Point[n];
			for (int i = 0; i < points.Length; i++)
			{
				Console.WriteLine("Введите {0}-ое значение X", i + 1);
				int X = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Введите {0}-ое значение Y", i + 1);
				int Y = Convert.ToInt32(Console.ReadLine());
				points[i] = new Point(X, Y);
			}
			return points;
		}

		public double Perimeter(Point[] points)
		{
			double perimetr = 0.0;
			for (int i = 0; i < points.Length-1; i++)
			{
				perimetr += Math.Sqrt(Math.Pow((points[i].GetX - points[i++].GetX), 2) + Math.Pow((points[i].GetY - points[i++].GetY), 2));
				// Условие, нужное чтобы сложить периметр.Например для 3-точек:
				// AB+BC+CA   CA - ?
				//CA - это корень квадратный из суммы квадратов первой и последней точек.
			}
			perimetr +=  Math.Sqrt(Math.Pow((points[0].GetX - points[points.Length-1].GetX), 2) + Math.Pow((points[0].GetY - points[points.Length-1].GetY), 2));
			return perimetr;
		}
	}
}