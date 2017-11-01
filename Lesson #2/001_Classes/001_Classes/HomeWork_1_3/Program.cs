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
//	Класс Figure должен содержать конструкторы, которые принимают от 3-х до 5-ти аргументов типа Point. 
//Создать два метода: double LengthSide(Point A, Point B), который рассчитывает длину стороны многоугольника;
//void PerimeterCalculator(), который рассчитывает периметр многоугольника.
//Написать программу, которая выводит на экран название и периметр многоугольника. 

namespace HomeWork_1_3
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("");
			string a = Console.ReadLine();
			int point_1 = Convert.ToInt32(a);

			Console.WriteLine("");
			string b = Console.ReadLine();
			int point_2 = Convert.ToInt32(b);

			Console.WriteLine("");
			string point_3 = Console.ReadLine();

			Point point = new Point(point_1,point_2,point_3);		//
		}
	}
}
