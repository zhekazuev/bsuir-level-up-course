using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
//Требуется:  
//Создать метод, который будет выполнять увеличение длины массива переданного в качестве аргумента, на 1 элемент.
//Элементы массива, должны сохранить свое значение и порядок индексов.
//Создайте метод, который принимает два аргумента, первый аргумент -  типа int[] array, второй аргумент - типа int value. 
//В теле метода реализуйте возможность добавления второго аргумента метода в массив по индексу – 0,
//при этом длина нового массива, должна увеличиться на 1 элемент, 
//а элементы получаемого массива в качестве первого аргумента должны скопироваться в новый массив начиная с индекса - 1.


namespace HomeWork_9_3
{
	class Program
	{
		static int[] UpMassive(int [] Array)
		{
			int[] UpArray = new int [6];
			for(int i = 0;i<Array.Length;i++)
			{
				UpArray[i] = Array[i];
				
			}
			Console.WriteLine("How the element you like add in the End?");
			string a = Console.ReadLine();
			UpArray[5] = Convert.ToInt32(a);
			
			return UpArray;
		}



		static int[] SecondElement(int[] Array,int value)
		{
			int[] UpArray = new int[6];
			for (int i = 0; i < Array.Length; i++)
			{
				UpArray[i+1] = Array[i];

			}
			UpArray[0] = value;

			return UpArray;
		}



		static void Main(string[] args)
		{
			int[] Array = new int[5] {1,2,3,4,5};
			Console.Write("Your Massive:");

			for (int i = 0; i < Array.Length; i++)
			{
				Console.Write(Array[i]);
			}
			Console.WriteLine();

			//////////////////////////////////////////////////////////////////
			int[] UpArray = UpMassive(Array);
			for (int i = 0; i < UpArray.Length; i++)
			{
				Console.Write(UpArray[i]);
			}
			Console.WriteLine();

			//////////////////////////////////////////////////////////////////
			Console.WriteLine("How the element you like add in the Begin?");
			string a = Console.ReadLine();
			int value = Convert.ToInt32(a);
			int[] SuperMassive = SecondElement(Array,value);
			for (int i = 0; i < UpArray.Length; i++)
			{
				Console.Write(SuperMassive[i]);
			}
			Console.WriteLine();
			Console.ReadKey();
		}
	}
}
