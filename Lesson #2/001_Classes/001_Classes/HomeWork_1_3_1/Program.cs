using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется:  
//Создать классы Point и Figure.
//Класс Point должен содержать два целочисленных поля и одно строковое поле.
//Создать три свойства с одним методом доступа get.  
//Создать пользовательский конструктор, в теле которого проинициализируйте поля значениями аргументов.
//Написать программу, которая выводит на экран название и периметр многоугольника. 

namespace HomeWork_1_3_1
{
	class Point
	{
		private int X;
		private int Y;
		private string Name; 

		public int GetX
		{
			get { return X; }
		}

		public int GetY
		{
			get { return Y; }
		}

		public string GetName
		{
			get { return Name; }
		}

		public void Initialization(int X,int Y, string Name)
		{
			this.X = X;
			this.Y = Y;
			this.Name = Name;
		}
	}
	//Класс Figure должен содержать конструкторы, которые принимают от 3-х до 5-ти аргументов типа Point. 
	//Создать два метода: double LengthSide(Point A, Point B), который рассчитывает длину стороны многоугольника;
	//void PerimeterCalculator(), который рассчитывает периметр многоугольника.
	class Figure
	{

		private double LengthSide(Point A,Point B)
		{
			 
			return Math.Sqrt(Math.Pow(A.X-B.X)+Math.Pow(A.Y - B.Y));
		}
		
		private double Perimeter()
		{
			double perimeter = 0;
			for (int i = 1; i < points.Length; i++)
			{
				perimeter += this.LengthSide(points[i - 1], points[i]);
			}
			perimeter += this.LengthSide(points[0], points[points.Length - 1]);
			return perimeter;
			perimeter +=lengside;
			return perimeter;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{

		}
	}
}

