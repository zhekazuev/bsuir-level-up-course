using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
//Требуется:  
//Создать массив размера N элементов, заполнить его произвольными целыми значениями(размер массива задает пользователь).  
//Вывести на экран: наибольшее значение массива, наименьшее значение массива, общую сумму всех элементов,
//среднее арифметическое всех элементов, вывести все нечетные значения.


namespace HomeWork_9_1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите размер массива:");
			string k = Console.ReadLine();
			int n = Convert.ToInt32(k);
			int[] array = new int [n];
			Console.WriteLine("Заполните массив размером {0} значениями:",n);

			for(int i = 0; i <= array.Length - 1; i++)//заполнение массива
			{
				string l = Console.ReadLine();
				int p = Convert.ToInt32(l);
				array[i] = p;
			}

			Console.Write("Ваш массив:");//вывод массива
			for (int i = 0; i <= array.Length - 1; i++)
			{
				Console.Write(array[i]);
			}

			Console.WriteLine();
			Console.Write("Максимальное значение массива:");
			Console.WriteLine(array.Max());//определение максимального значения массива

			Console.Write("Минимальное значение массива:");
			Console.WriteLine(array.Min());//определение минимального значения массива

			double sredn = 0;
			double sum = 0.0;
			for (int i = 0; i < array.Length; i++)//сумма всех элементов
			{
				
				sum = sum + array[i];
			}
			Console.WriteLine("Сумма элементов массива равна = {0}",sum);//вывод суммы массива

			sredn = sum / array.Length;//Среднее арифметическое
			Console.WriteLine("Среднее арифметическое массива равно = {0}", sredn);//вывод Среднее арифметическое массива равно


			Console.Write("Нечетные эелементы массива:");
			for (int i = 0; i < array.Length; i++)//определение нечетности элемента
			{
				if (array[i] % 2 != 0)
				{
					Console.Write(array[i]);
					Console.Write(",");
				}
			}
			



			Console.ReadKey();
		}
	}
}
