using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Используя Visual Studio, создайте проект по шаблону Console Application.
//Создайте метод с именем Calculate, который принимает в качестве параметров три целочисленных значения
//и возвращает значение каждого аргумента деленного на 5.  


namespace HomeWork_8_1
{
	class Program
	{
		static float Calculate(int a, int b, int c)
		{
			
			float d = a / 5f;


			float f = b / 5f;


			float g = c / 5f;

			Console.WriteLine("a / 5 = {0}  b / 5 = {1} c / 5 = {2}" , d, f, g);
			return 0f;
			
		}

		static void Main(string[] args)
		{
			
			
			Console.WriteLine(Calculate(5,6,7));
			Console.ReadKey();
		}
	}
}
