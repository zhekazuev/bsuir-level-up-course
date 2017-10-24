using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
//Создайте четыре метода для выполнения арифметических операций, с именами: Add – сложение, Sub – вычитание, Mul – умножение, Div – деление.
//Каждый метод должен принимать два целочисленных аргумента и выводить на экран результат выполнения арифметической операции соответствующей имени метода.
//Метод деления Div, должен выполнять проверку попытки деления на ноль.
//Требуется предоставить пользователю возможность вводить с клавиатуры значения операндов и знак арифметической операции, для выполнения вычислений.


namespace HomeWork_7_1
{
	class Program
	{
		static int Add(int a, int b)
		{
			int add = a + b;
			Console.WriteLine("a + b = {0}", add);
			return add;
		}

		static int Sub(int a, int b)
		{
			int sub = a - b;
			Console.WriteLine("a - b = {0}", sub);
			return sub;
		}

		static int Mul(int a, int b)
		{
			int mul = a * b;
			Console.WriteLine("a * b = {0}", mul);
			return mul;
		}

		static int Div(int a, int b)
		{
			if (b != 0)
			{
				int div = a / b;
				Console.WriteLine("a / b = {0}", div);
				return div;


			}
			else
			{
				Console.WriteLine("На ноль делить нельзя(Неопределенность).Введите другое значение для второго операнда.");
				return 0;
			}
			
		}
			

		

		static void Main(string[] args)
		{
			
			K: Console.WriteLine("Введите первое число:");
			string q = Console.ReadLine();
			int r = Convert.ToInt32(q);

			Console.WriteLine("Введите второе число:");
			string w = Console.ReadLine();
			int t = Convert.ToInt32(w);

			Console.WriteLine("Введите операцию, которую хотите выполнить:");
			string operation = Console.ReadLine();

			switch (operation)
			{
				case "+":
					{
						int C = Add(r, t); 
						break;
					}
				case "-":
					{
						int C = Sub(r, t);
						break;
					}
				case "*":
					{
						int C = Mul(r, t);
						break;
					}
				case "/":
					{
						int C = Div(r, t);
						break;
					}
			}

			goto K;
		}
	}
}
