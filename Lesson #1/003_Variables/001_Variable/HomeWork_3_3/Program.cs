using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//	Используя Visual Studio, создайте проект по шаблону Console Application.
//	Создайте константу с именем -pi (число π «пи»), создайте переменную радиус с именем – r.
//	Используя формулу πR^2 , вычислите площадь круга и выведите результат на экран.


namespace HomeWork_3_3
{
	class Program
	{
		static void Main(string[] args)
		{
			double pi = 3.1415926535d,S = 0d;
			float r = 3.2f;

			S = Math.Pow(r, 2) * pi;
			Console.WriteLine("Площадь круга = {0}",S);
		}
	}
}
