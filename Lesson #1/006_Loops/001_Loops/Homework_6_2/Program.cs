using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Дано два числа A и B(A<B) выведите все нечетные значения, расположенные между данными числами.

namespace HomeWork_6_1
{
	class Program
	{
		static void Main(string[] args)
		{
			int A = 2, B = 12, C = 0; //числа расположенные от 2 до 12;
			A++;
			while (A < B)
			{
				
				if( A%2 != 0)	//	Если остаток от деления на два равен нулю то выполнить блок.
					{
					Console.WriteLine("Нечетное число - {0}",A);
					}
				A++;
				
			}
			Console.WriteLine(C);
			Console.ReadKey();
		}
	}
}
