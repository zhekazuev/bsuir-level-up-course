using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Используя Visual Studio, создайте проект по шаблону Console Application.
//Представьте, что вы реализуете программу для банка, которая помогает определить, погасил ли клиент кредит или нет. 
//Допустим, ежемесячная сумма платежа должна составлять 100 грн.Клиент должен выполнить 7 платежей, но может платить реже большими суммами. 
//Т.е., может двумя платежами по 300 и 400 грн.Закрыть весь долг.
//Создайте метод, который будет в качестве аргумента принимать сумму платежа, введенную экономистом банка.
//Метод выводит на экран информацию о состоянии кредита (сумма задолженности, сумма переплаты, сообщение об отсутствии долга).  


namespace HomeWork_8_2
{
	class Program
	{

		static int Dolg(int a)
		{
			int dolf = 700;
			int d;
			d = dolf - a;
			return d; 
		}

		static void Main(string[] args)
		{
			Console.WriteLine("Введите сумму платежа:");
			string a = Console.ReadLine();
			int b = Convert.ToInt32(a);
			int l = Dolg(b);
			if (l == 0) { Console.WriteLine("Долг погашен."); goto Exit; }
			if (l < 0) { Console.WriteLine("Сумма переплаты составляет {0}.Благодарим за щедрость.", -l); }
			if (l != 0 & l>0) { Console.WriteLine("Ваш долг составляет {0}.Оплатите пожалуйста", l); }
		Exit:Console.ReadKey();


		}
	}
}
