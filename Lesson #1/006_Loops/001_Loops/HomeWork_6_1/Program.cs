using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Дано два числа A и B(A<B) выведите суму всех чисел расположенных между данными числами на экран.

namespace HomeWork_6_1
{
	class Program
	{
		static void Main(string[] args)
		{
			int A = 2, B = 12,C = 0; //числа расположенные от 2 до 12;
			A++;
			while(A<B)
				{
				C = A + C++;
				A++;
				
			}
			Console.WriteLine(C);
		}
	}
}
