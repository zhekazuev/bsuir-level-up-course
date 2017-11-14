using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Класс Point должен содержать два целочисленных поля и одно строковое поле.
// Создать три свойства с одним методом доступа get.  
// Создать пользовательский конструктор, в теле которого проинициализируйте поля значениями аргументов.

namespace HomeWork_1_3
{
	class Point
	{
		private int X;
		private int Y;

		public Point(int X,int Y)
		{
			this.X = X;
			this.Y = Y;
		}

		public int GetX
		{
			get { return this.X; }
		}
		public int GetY
		{
			get { return this.Y; }
		}
	}
}