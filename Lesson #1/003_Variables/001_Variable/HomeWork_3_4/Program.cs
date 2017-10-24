using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//	Используя Visual Studio, создайте проект по шаблону Console Application.
//	Напишите программу расчета объема - V и площади поверхности -S цилиндра.  
//	Объем V цилиндра радиусом – R и высотой – h, вычисляется по формуле: V = πR^2*h
//	Площадь S поверхности цилиндра вычисляется по формуле: S = 2πR^2 + 2πR^2 = 2πR(R+h)
//  Результаты расчетов выведите на экран.


namespace HomeWork_3_4
{
	class Program
	{
		static void Main(string[] args)
		{
			double V = 0d, S = 0d,pi= 3.1415926535;
			float R = 3.2f,h=10.1f;
			S = 2 * pi * R * (R + h);
			V = pi * Math.Pow(R, 2) * h;
			Console.WriteLine("S={0}\nV={1}", S, V);
			Console.ReadKey();
		}
	}
}
