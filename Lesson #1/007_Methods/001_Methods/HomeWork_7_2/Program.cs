using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
//Напишите программу, которая будет выполнять конвертирование валют.
//Пользователь вводит: 
//сумму денег в определенной валюте.
//курс для конвертации в другую валюту. 
//Организуйте вывод результата операции конвертирования валюты на экран. 


namespace HomeWork_7_2
{
	class Program
	{
		static float Cource(int l, float w)
		{
			float kurs = l * w;
			return kurs;		
		}


		static void Main(string[] args)
		{
			Console.WriteLine("Добро пожаловать в конвертер валют");

			Console.WriteLine("Введите сумму денег для перевода:");
			string k = Console.ReadLine();
			int l = Convert.ToInt32(k);
			Console.WriteLine("Введите курс для конвертации:");
			string q = Console.ReadLine();
			float w = Convert.ToInt32(q);

			float p = Cource(l, w);


			Console.WriteLine("Курс составляет : {0} Доллар(-ов) ------- {1} Рублей",l,p);
		}
	}
}
