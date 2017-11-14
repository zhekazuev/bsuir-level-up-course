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
	class Converter
	{
		public double USD;
		public double EUR;
		public double RUB;

		public Converter(double usd,double eur,double rub)
		{
			this.USD = usd;
			this.EUR = eur;
			this.RUB = rub;
		}
		public double ConvUSD(double grivna)
		{
			double convUSD = 3 * grivna;
			return convUSD;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{

		}
	}
}
