using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Класс Point должен содержать два целочисленных поля и одно строковое поле.
//Создать три свойства с одним методом доступа get.  
//Создать пользовательский конструктор, в теле которого проинициализируйте поля значениями аргументов.

namespace HomeWork_1_3
{
	class Point
	{
		private int pointfield_1;		//поля
		private int pointfield_2;		//поля
		private string pointfield_3;	//поля

		public int Point_1       //свойство 1
		{
			get { return pointfield_1; }
		}

		public int Point_2       //свойство 2
		{
			get { return pointfield_2; }
		}

		public string Point_3       //свойство 3
		{
			get { return pointfield_3; }
		}

		public Point(int point_1,int point_2,string point_3) //пользовательский конструктор, в теле которого инициализируются поля значениями аргументов.
		{
			this.pointfield_1 = point_1;
			this.pointfield_2 = point_2;
			this.pointfield_3 = point_3;
		}
	}
}
