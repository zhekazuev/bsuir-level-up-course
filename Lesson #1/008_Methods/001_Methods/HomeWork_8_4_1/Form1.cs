using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Используя Visual Studio, создайте проект по шаблону WindowsForms.
//Напишите программу, в который пользователь в textBox1 и textBox2  вводит данные 
//и выбирает при помощи нескольких radioButton тип операции которую требуется выполнить:  остаток от деления, 
//возведение в степень, конкатенация, деление.Результат выводится в textBox3 при нажатии на кнопку «Вычислить» 


namespace HomeWork_8_4_1
{
	public partial class Form1 : Form
	{
		public static double Ostatok(double a, double b)
		{
			
			return a % b;
		}

		public static double Stepen(double a, double b)
		{
			return Math.Pow(a,b);
		}

		public static string Konkatsenacia(string a, string b)
		{
			return a + b;
		}

		public static double Del(double a, double b)
		{
			return a / b;
		}

		public Form1()
		{
			InitializeComponent();
		}


		private void Form1_Load(object sender, EventArgs e)
		{
			
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)//Остаток от деления
		{
			textBox3.Text = Convert.ToString(Ostatok(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
		}

		private void button2_Click(object sender, EventArgs e)//Степень 
		{
			textBox3.Text = Convert.ToString(Stepen(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
		}

		private void button3_Click(object sender, EventArgs e)//Конкастенация
		{
			textBox3.Text = Convert.ToString(Konkatsenacia(Convert.ToString(textBox1.Text), Convert.ToString(textBox2.Text)));
		}

		private void button4_Click(object sender, EventArgs e)//Деление
		{
			textBox3.Text = Convert.ToString(Del(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
		}
	}
}
