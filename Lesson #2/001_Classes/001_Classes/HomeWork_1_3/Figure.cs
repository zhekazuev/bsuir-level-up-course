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

		Point point = new Point();

		public Point[] Init(int n)
		{
			Point[] points = new Point[n];
			for (int i = 0; i < points.Length; i++)
			{
				points[i] = new Point();
				Console.WriteLine("Введите {0}-ое значение X", i + 1);
				points[i].X = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Введите {0}-ое значение Y", i + 1);
				points[i].Y = Convert.ToInt32(Console.ReadLine());
			}
			return points;
		}

		
		public double Perimeter(Point[] points)
		{
			double perimetr = 0.0;
			for (int i = 0; i < points.Length-1; i++)
			{
				perimetr += Math.Sqrt(Math.Pow((points[i].X - points[i++].X), 2) + Math.Pow((points[i].Y - points[i++].Y), 2));
				// Условие, нужное чтобы сложить периметр.Например для 3-точек:
				// AB+BC+CA   CA - ?
				//CA - это корень квадратный из суммы квадратов первой и последней точек.
			}
			perimetr +=  Math.Sqrt(Math.Pow((points[0].X - points[points.Length-1].X), 2) + Math.Pow((points[0].Y - points[points.Length-1].Y), 2));
			return perimetr;
		}
	}
}