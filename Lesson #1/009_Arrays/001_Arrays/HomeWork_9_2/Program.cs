using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
//Требуется:  
//1) Создать метод MyReverse(int[] array), который принимает в качестве аргумента массив целочисленных элементов 
//и возвращает инвертированный массив(элементы массива в обратном порядке).  
//2) Создайте метод int[] SubArray(int[] array, int index, int count). Метод возвращает часть полученного в качестве аргумента массива,
//начиная с позиции указанной в аргументе index, размерностью, которая соответствует значению аргумента count.

//Если аргумент count содержит значение больше чем количество элементов,
//которые входят в выбираемую часть исходного массива (от указанного индекса index, до индекса последнего элемента), 
//то при формировании нового массива размерностью в count, заполните единицами те элементы, которые не были скопированы из исходного массива.


namespace HomeWork_9_2
{
	class Program
	{
		static int[] MyReverse (int [] array)//метод по инвертированию массива
		{
			int n = 0;
			int[] ReArray = new int[5];
			for(int i = array.Length-1; i>=0 ;i--)
			{
				ReArray[n] = array[i];
				n++;
			}
			return ReArray;
		}

		static int [] SubArray(int[] array, int index, int count)
		{
			int n = 0;
			int[] SuubArray = new int[count];
			for (int i = 0; i <array.Length; i++)
			{
				if (i > index-2)
				{
					SuubArray[n] = array[i];
					n++;
				}
			}
			if (n < count)
			{
				for (int i = n; i < count; i++)
				{
					SuubArray[i] = 1;
				}
			}

				return SuubArray;
		}

		static void Main(string[] args)
		{
			int[] array = new int[5] {1,2,3,4,5};
			//////////////////////////////////////////////////вывод оригинального массива
			Console.Write("Original array:");
			for (int i = 0; i < array.Length; i++)
			{
				Console.Write(array[i]);
			}
			Console.WriteLine();
			int [] ReArray = MyReverse(array);
			///////////////////////////////////////////////////вывод обратного массива
			Console.Write("Reverse array:");
			for (int i = 0; i < array.Length; i++)
			{
				Console.Write(ReArray[i]);
			}
			Console.WriteLine();


			Console.Write("Введите индекс массива, с которого надо начать возвращать значения:");
			string k = Console.ReadLine();
			int index = Convert.ToInt32(k);
			Console.Write("Введите размерность возвращаемого массива:");
			string p = Console.ReadLine();
			int count = Convert.ToInt32(p);

			int [] SuubArray = SubArray(array, index, count);

			for (int i = 0; i< SuubArray.Length; i++)
			{
				Console.Write(SuubArray[i]);
			}
			Console.WriteLine();
			Console.ReadKey();
		}
	}
}
