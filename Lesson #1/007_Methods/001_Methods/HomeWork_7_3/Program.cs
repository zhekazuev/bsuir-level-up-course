using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
//Напишите метод, который будет определять:  
//1) является ли введенное число положительным или отрицательным.
//2) Является ли оно простым(используйте технику перебора значений).  
//(Простое число — это натуральное число, которое делится на 1 и само на себя.Чтобы определить простое число или нет, следует найти все его целые делители. 
//Если делителей больше 2-х, значит оно не простое.)
//3) Делится ли на 2, 5, 3, 6, 9 без остатка.


namespace HomeWork_7_3
{
	class Program
	{
			static string Znak(string a)
			{
				int k = Convert.ToInt32(a);
				if(k<0)		{return "Введенное число меньше нуля";}
				else		{ return "Введенное число больше нуля"; }
			}

			static string Prosto(string a)
			{

				int t = Convert.ToInt32(a);
				int L = 0;
				int k = 0;
				for (int i=1;i <= t;i++)
					{
						
						k = t % i;

						if (k == 0)		{L++;}//если к равно 0 то считать
					}
						if (L == 2)		{return "Число простое";}
						else			{return "Число не простое"; }
			}

			static string Div(string a)
			{

				int t = Convert.ToInt32(a);
				int k = 0;
				int q = 0;
					
					
					k = t % 2; if (k == 0)	{ q++;}
					
					////////////////////////////////
					
					k = t % 3; if (k == 0) { q++;}
					
					
					////////////////////////////////
					
					k = t % 5; if (k == 0) { q++;}
					
					////////////////////////////////
					
					k = t % 6; if (k == 0) { q++;}
					
					////////////////////////////////
					
					k = t % 9; if (k == 0) { q++;}


			////////////////////////////////



			if (q == 5) { return "Число делится на 2,3,5,6,9"; }
			else { return "Число не делится на 2,3,5,6,9"; }
		}

			static void Main()
			{
				Console.WriteLine("Введите число которое хотите проверить");
				string a = Console.ReadLine();
			
				string znak = Znak(a);
				string prosto = Prosto(a);
				string div = Div(a);

				Console.WriteLine(znak);
				Console.WriteLine(prosto);
				Console.WriteLine(div);

			}
	}
}
