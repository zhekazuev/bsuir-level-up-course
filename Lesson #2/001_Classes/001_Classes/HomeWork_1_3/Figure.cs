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
			for (int i = 0; i < n; i++)
			{
				points[i] = new Point();
				Console.WriteLine("Введите {0}-ое значение X", i);
				points[i].X = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Введите {0}-ое значение Y", i);
				points[i].Y = Convert.ToInt32(Console.ReadLine());
			}
			return points;
		}
				
		public double Perimeter(int n,Point[] points)
		{
			double perimeter = 0.0;
			for (int i = 0; i < n; i++)
			{
				// Условие, нужное чтобы сложить периметр.Например для 3-точек:
				// AB+BC+CA   CA - ?
				//CA - это корень квадратный из суммы квадратов первой и последней точек.
				if (i == n)
				{
					perimeter += Math.Sqrt(Math.Pow((points[0].X - points[0].X),2) + Math.Pow((points[n].Y - points[n].Y),2));
				}
				else
				{
					perimeter += Math.Sqrt(Math.Pow((points[i].X - points[i++].X), 2) + Math.Pow((points[i].Y - points[i++].Y), 2));
				}
			}
			return perimeter;
		}
	}
}
