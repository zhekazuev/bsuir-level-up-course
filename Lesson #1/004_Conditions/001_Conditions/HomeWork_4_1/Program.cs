using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//	Используя Visual Studio, создайте проект по шаблону Console Application.
//	Напишите программу - консольный калькулятор.  
//	Создайте две переменные с именами operand1 и operand2. Задайте переменным некоторые произвольные значения.
//	Предложите пользователю ввести знак арифметической операции. Примите значение введенное пользователем и поместите его в строковую переменную sign.
//	Для организации выбора алгоритма вычислительного процесса, используйте переключатель switch.
//	Выведите на экран результат выполнения арифметической операции.
//	В случае использования операции деления, организуйте проверку попытки деления на ноль. 
//	И если таковая имеется, то отмените выполнение арифметической операции и уведомите об ошибке пользователя. 


namespace HomeWork_4_1
{
	class Program
	{
		static void Main(string[] args)
		{
			float operand11, operand22;
			Console.WriteLine("Добро пожаловать в Консольный калькулятор 3000...");
		M:  Console.WriteLine("Введите значение первой переменной...");
			String operand1 = Console.ReadLine();
			Console.WriteLine("Введите значение второй переменной...");
			String operand2 = Console.ReadLine();
			operand11 = Convert.ToInt32(operand1);
			operand22 = Convert.ToInt32(operand2);
			N: Console.WriteLine("Введите знак арифметической операции между двумя значениями {0} и {1}: + - * /",operand11,operand22);
			string sign = Console.ReadLine();

			switch (sign)
			{
				case "+":
					Console.WriteLine(operand1 + operand2);
					break;
				case "-":
					Console.WriteLine(operand11 - operand22);
					break;
				case "*":
					Console.WriteLine(operand11 * operand22);
					break;
				case "/":
					if (operand22 == 0)
					{
						Console.WriteLine("Попытка деления на ноль.Отмена операции...");
						goto M;
					}
					else 
					Console.WriteLine(operand11 / operand22);
					break;
				default:
					Console.WriteLine("Вы ввели знак которого нет в списке возможных операций.Повторите ввод:");
					goto N;
			}
		}
	}
}
