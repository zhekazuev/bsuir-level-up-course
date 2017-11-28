using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Создать класс Converter.
//В теле класса создать пользовательский конструктор, который принимает три вещественных аргумента, 
//и инициализирует поля соответствующие курсу 3-х основных валют, по отношению к гривне – public Converter(double usd, double eur, double rub).  
//Написать программу, которая будет выполнять конвертацию из гривны в одну из указанных валют,
//также программа должна производить конвертацию из указанных валют в гривну.

namespace HomeWork_1_1
{
	class Program
	{
		static void Main(string[] args)
		{
S:			Console.WriteLine("Выберите в какую валюту вы хотите конвертировать гривны...");
			Console.WriteLine("1.USD");
			Console.WriteLine("2.EUR");
			Console.WriteLine("3.RUB");
			Console.WriteLine("?");
			int a = int.Parse(Console.ReadLine());

			Console.WriteLine("Введите сумму...");
			int n = int.Parse(Console.ReadLine());

			double Grivna = 1D;
			double USD = 26.87 * Grivna;
			double EUR = 31.97 * Grivna;
			double RUB = 0.46 * Grivna;

			Converter convert = new Converter(USD,EUR,RUB);
					
			switch(a)
			{
				case 1:
					Console.WriteLine("{1} USD= {0} Grivna", n*convert.ConvUSD(Grivna),n);
					Console.WriteLine("{1} Grivna = {0} USD",n * Grivna / convert.ConvUSD(Grivna), n);
					break;
				case 2:
					Console.WriteLine("{1} EUR = {0} Grivna", n * convert.ConvEUR(Grivna), n);
					Console.WriteLine("{1} Grivna  = {0} EUR", n * Grivna / convert.ConvEUR(Grivna), n);
					break;
				case 3:
					Console.WriteLine("{1} RUB = {0} Grivna", n * convert.ConvRUB(Grivna), n);
					Console.WriteLine("{1} Grivna  = {0} RUB", n * Grivna / convert.ConvRUB(Grivna), n);
					break;
			}
			
			goto S;
			
		}
	}
}
