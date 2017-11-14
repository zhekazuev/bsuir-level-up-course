using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется: Создать класс с именем Rectangle.
//В теле класса создать два поля, описывающие длины сторон double side1, side2.
//Создать пользовательский конструктор Rectangle(double side1, double side2), в теле которого поля side1 и side2 инициализируются значениями аргументов.  
//Создать два метода, вычисляющие площадь прямоугольника - double AreaCalculator() и периметр прямоугольника - double PerimeterCalculator().  
//Создать два свойства double Area и double Perimeter с одним методом доступа get.
//Написать программу, которая принимает от пользователя длины двух сторон прямоугольника и выводит на экран периметр и площадь.


namespace HomeWork_1_1
{
	class Rectangle
	{
		private double side1, side2;

		public Rectangle(double side1,double side2)
		{
			this.side1 = side1;
			this.side2 = side2;
		}

		private double AreaCalculator()
		{
			double Area = side1 * side2;
			return Area;
		}

		private double PerimeterCalculator()
		{
			double Perimeter = 2 * (side1 + side2);
			return Perimeter;
		}

		public double Area
		{
			get { return AreaCalculator(); }
		}
		public double Perimeter
		{
			get { return PerimeterCalculator(); }
		}

	}

	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Input first side of the Rectangle:");
			string a = Console.ReadLine();
			double side1 = Convert.ToDouble(a);

			Console.WriteLine("Input second side of the Rectangle:");
			string b = Console.ReadLine();
			double side2 = Convert.ToDouble(b);

			Rectangle rectangle = new Rectangle(side1,side2);

			Console.WriteLine("Area = {0}",rectangle.Area);
			Console.WriteLine(new string('-', 30));
			Console.WriteLine("Perimeter = {0}", rectangle.Perimeter);

			 Console.ReadKey();
		}
	}
}
