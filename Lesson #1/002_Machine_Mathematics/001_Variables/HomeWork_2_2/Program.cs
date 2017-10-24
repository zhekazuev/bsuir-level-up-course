using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Используя Visual Studio, создайте проект по шаблону Console Application.
//Создайте три строковые переменные и присвойте им значения: 
//            "\nмоя строка 1" 
//            "\tмоя строка 2"  
//            "\aмоя строка 3" 
//Выведите значение каждой переменной на экран. Какие отличия вы увидели. Сделайте выводы. 

namespace HomeWork_2_2
{
	class Program
	{
		static void Main(string[] args)
		{
			string a = "Моя строка 1\n\n", b= "Моя строка 2\n\n", c= "Моя строка 3";
			Console.WriteLine(a);
			Console.WriteLine(b);
			Console.WriteLine(c);
			Console.ReadKey();
		}
	}
}
