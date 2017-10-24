using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//	Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
//	Напишите программу русско-английский переводчик.Программа знает 10 слов о погоде.
//	Требуется, чтобы пользователь вводил слово на русском языке, а программа давала ему перевод этого слова на английском языке. 
//	Если пользователь ввел слово, для которого отсутствует перевод, то следует вывести сообщение, что такого слова нет. 


namespace HomeWork_4_Dop
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Добро пожалость в ZuiTranslate ...");
		M: Console.WriteLine("Введите слово, которое хотите перевести:");
			string weatherword = Console.ReadLine();

			switch (weatherword)
			{
				case "Буря":
					Console.WriteLine("Буря  ---------------- Storm");
					break;
				case "Ветер":
					Console.WriteLine("Ветер  ---------------- Wind");
					break;
				case "Град":
					Console.WriteLine("Град  ---------------- Hail");
					break;
				case "Гром":
					Console.WriteLine("Гром  ---------------- Thunder");
					break;
				case "Дождь":
					Console.WriteLine("Дождь  ---------------- Rain");
					break;
				case "Метель":
					Console.WriteLine("Метель ---------------- Blizzard");
					break;
				case "Туча":
					Console.WriteLine("Туча  ---------------- Cloud");
					break;
				case "Снег":
					Console.WriteLine("Снег  ---------------- Snow");
					break;
				case "Солнце":
					Console.WriteLine("Солнце  ---------------- Sun");
					break;
				case "Туман":
					Console.WriteLine("Туман  ---------------- Fog");
					break;
				default:
					Console.WriteLine("Такого слова нет в словаре. Попробуйте другое слово..");
					goto M;
			}
		N: Console.WriteLine("Если хотите продолжить пользоваться словарем нажмите R(Reset),если же желаете закончить нажмите Е(Exit)....");

			string b = Console.ReadLine();

				if (b == "R")
				{
					goto M;

				}
				else if (b == "E")
					{
						Console.ReadKey();
					}
					else
						{
							Console.WriteLine("Введен недопустимый символ ....Попробуйте снова");
							goto N;
						}

		}
	}
}
