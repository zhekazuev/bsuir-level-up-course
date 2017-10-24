using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//	Задание 1 
//	Имеется 3 переменные типа int x = 10, y = 12, и z = 3; 
//	Выполните и рассчитайте результат следующих операций для этих переменных: 
 
	//	x += y - x++ * z; 
	//	z = --x – y* 5; 
	//	y /= x + 5 % z; 
	//	z = x++ + y* 5; 
	//	x = y - x++ * z;

namespace HomeWork_3_1
{
	class Program
	{
		static void Main(string[] args)
		{
			int x = 10, y = 12, z = 3;

			Console.Write("x += y - x++ * z = ");
			Console.WriteLine(x += y - x++ * z);

			x = 10;
			y = 12;
			z = 3;
			Console.Write("z = --x - y * 5 = ");
			Console.WriteLine(z = --x - y * 5);

			x = 10;
			y = 12;
			z = 3;
			Console.Write("y /= x + 5 % z = ");
			Console.WriteLine(y /= x + 5 % z);

			x = 10;
			y = 12;
			z = 3;
			Console.Write("z = x++ + y * 5 = ");
			Console.WriteLine(z = x++ + y * 5);

			x = 10;
			y = 12;
			z = 3;
			Console.Write("x = y - x++ * z = ");
			Console.WriteLine(x = y - x++ * z);
			Console.ReadKey();
		}
	}
}
