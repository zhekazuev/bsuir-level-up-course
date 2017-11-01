using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//	Класс Figure должен содержать конструкторы, которые принимают от 3-х до 5-ти аргументов типа Point. 
//Создать два метода: double LengthSide(Point A, Point B), который рассчитывает длину стороны многоугольника;
//void PerimeterCalculator(), который рассчитывает периметр многоугольника.

namespace HomeWork_1_3
{
	class Figure
	{
		public Figure(Point point_1, Point point_2, Point point_3,Point point_4,Point point_5)
		{
			
		}

		public double LengthSide(Point A, Point B)	//метод расчета длины стороны 
		{
			double Adouble = Convert.ToDouble(A);
			double Bdouble = Convert.ToDouble(B);
			double lengthside = Bdouble-Adouble;
			return lengthside;
		}

		public void PerimeterCalculator()			//расчет периметра
		{
			double Perimeter = 0 ;
		}
	}
}
