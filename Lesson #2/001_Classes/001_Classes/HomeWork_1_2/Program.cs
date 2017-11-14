using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется:  
//Создать класс Book.Создать классы Title, Author и Content, каждый из которых должен содержать одно строковое поле и метод void Show().  
//Реализуйте возможность добавления в книгу названия книги, имени автора и содержания. 
//Выведите на экран разными цветами при помощи метода Show() название книги, имя автора и содержание. 


namespace HomeWork_1_2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите название книги...");
			string Title = Console.ReadLine();
			Console.WriteLine("Введите имя автора данной книги...");
			string Author = Console.ReadLine();
			Console.WriteLine("Введите содержание книги...");
			string Content = Console.ReadLine();

						
			Book.Title title = new Book.Title();
			Book.Author author = new Book.Author();
			Book.Content content = new Book.Content();

			title.SetTitle(Title);
			author.SetAuthor(Author);
			content.SetContent(Content);

			Console.Write("название книги - ");
			title.Show();
			Console.Write("имя автора данной книги - ");
			author.Show();
			Console.Write("содержание книги - ");
			content.Show();
			Console.WriteLine();

			Console.ReadKey();
		}
	}
}
