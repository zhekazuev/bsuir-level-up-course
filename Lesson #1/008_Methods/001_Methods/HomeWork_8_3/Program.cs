using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Имеется N клиентов, которым компания производитель должна доставить товар.
//Сколько существует возможных маршрутов доставки товара, с учетом того, что товар будет доставлять одна машина?  
//Используя Visual Studio, создайте проект по шаблону Console Application.  
//Напишите программу, которая будет рассчитывать и выводить на экран количество возможных вариантов доставки товара. 
//Для решения задачи, используйте факториал N!, рассчитываемый с помощью рекурсии. 
//Объясните, почему не рекомендуется использовать рекурсию для расчета факториала. Укажите слабые места данного подхода.


namespace HomeWork_8_3
{
	class Program
	{
		static long March (int N)
		{
			long Nfact = 1 ;
			if(N!=0)
			{
				Nfact = N * March(N - 1);
			}
			return Nfact;
		}


		static void Main(string[] args)
		{

			
			Console.WriteLine(March(3));
		}
	}
}
