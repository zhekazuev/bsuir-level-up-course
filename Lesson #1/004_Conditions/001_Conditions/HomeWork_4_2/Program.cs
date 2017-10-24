using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//	Используя Visual Studio, создайте проект по шаблону Console Application.
//	Напишите программу определения, попадает ли указанное пользователем число от 0 до 100 в числовой промежуток[0 - 14][15 - 35][36 - 50][50 - 100]. 
//	Если да, то укажите, в какой именно промежуток. 
//	Если пользователь указывает число не входящее ни в один из имеющихся числовых промежутков, то выводится соответствующее сообщение. 


namespace HomeWork_4_2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Добро пожаловать в программу по определения того, в какой промежуток попадает число...");
			M: Console.WriteLine("Доступные промежутки [0 - 14][15 - 35][36 - 50][51 - 100] ...");
			Console.WriteLine("Введите необходимое число число:");
			string number = Console.ReadLine();
			int numberr = Convert.ToInt32(number);
			if ((numberr < 15) && (numberr > -1))
			{
				Console.WriteLine("{0} входит в промежуток[0 - 14]", numberr);
			}
				else if ((numberr < 36 ) && (numberr > 14))
				{
				Console.WriteLine("{0} входит в промежуток[15 - 35]", numberr);
				}
					else if ((numberr < 51) && (numberr > 35))
					{
						Console.WriteLine("{0} входит в промежуток[36 - 50]", numberr);
					}
						else if ((numberr < 101) && (numberr > 50))
						{
							Console.WriteLine("{0} входит в промежуток[51 - 100]", numberr);
						}
							else
							{
								Console.WriteLine("Введенное вами число это {0} -  оно не входит в диапозон от 0 до 100...",numberr);
								goto M;
							}
			Console.ReadKey();
		}
	}
}
