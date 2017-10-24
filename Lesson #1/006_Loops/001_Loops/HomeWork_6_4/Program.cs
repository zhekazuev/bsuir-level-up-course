using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Имеется N клиентов, которым компания производитель должна доставить товар.
//Сколько существует возможных маршрутов доставки товара, с учетом того, что товар будет доставлять одна машина?  
//Используя Visual Studio, создайте проект по шаблону Console Application.  
//Напишите программу, которая будет рассчитывать, и выводить на экран количество возможных вариантов доставки товара.
//Для решения задачи, используйте факториал N!, рассчитываемый с помощью цикла do-while. 


namespace HomeWork_6_4
{
	class Program
	{
		static void Main(string[] args)
		{
			
			Console.WriteLine("Введите число клиеторв:");
			string K = Console.ReadLine();
			int N = Convert.ToInt32(K);

			int count = N, factorial = 1;

			do
			{
				factorial = factorial * count;
				count--;
			}
			while (count != 0);
			Console.WriteLine("Количество возможных маршрутов равно {0}", factorial);
			Console.ReadKey();

		}
	}
}
