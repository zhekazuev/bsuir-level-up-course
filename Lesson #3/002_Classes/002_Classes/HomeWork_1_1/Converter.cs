using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_1_1
{
	class Converter
	{
		private readonly double USD;
		private readonly double EUR;
		private readonly double RUB;

		public Converter(double usd, double eur, double rub)
		{
			this.USD = usd;
			this.EUR = eur;
			this.RUB = rub;
		}

		public double ConvUSD(double Grivna)
		{
			Grivna = USD/Grivna ;
			return Grivna;
		}

		public double ConvEUR(double Grivna)
		{
			Grivna = EUR / Grivna;
			return Grivna;
		}

		public double ConvRUB(double Grivna)
		{
			Grivna = RUB / Grivna;
			return Grivna;
		}
	}
}
