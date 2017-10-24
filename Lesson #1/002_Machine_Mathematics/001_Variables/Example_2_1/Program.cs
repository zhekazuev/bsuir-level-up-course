using System;

//Используя Visual Studio, создайте проект по шаблону Console Application.  
//Дано значение числа pi, которое равно 3,141592653 и значение числа Эйлера е, которое  равно 2,7182818284 590452. 
//Создайте две переменные, присвойте им значения числа pi и числа е и выведите их на экран без потери точности. 

namespace EilerPi
{
	class program
	{
		static void Main()
		{
			double pi = 3.141592653d, e = 2.7182818284d;
			Console.WriteLine("Число Pi={0}", pi);
			Console.WriteLine("Число Эйлера e={0}", e);
			Console.ReadKey();
		}

	}
}