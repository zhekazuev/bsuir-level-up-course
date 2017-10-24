using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//	Используя Visual Studio, создайте проект по шаблону Console Application.
//	Вычислите среднее арифметическое трех целочисленных значений и выведите его на экран. 
//	С какой проблемой вы столкнулись? Какой тип переменных лучше использовать для корректного отображения результата? 


namespace HomeWork_3_2
{
	class Program
	{
		static void Main(string[] args)
		{
			float a = 5f, b = 3f, c = 8f,d=0f;

			d = (a + b + c) / 3;

			Console.WriteLine("У нас есть три числа:");
			Console.WriteLine("a={0}\nb={1}\nc={2}", a, b, c);
			Console.WriteLine("Среднее арифметическое этих чисел = {0}",d);
			Console.ReadKey();
			//Вывод:Опреция деления с целочисленными значениями дает целочисленное значение у которого отброшена дробная часть
		}
	}
}
