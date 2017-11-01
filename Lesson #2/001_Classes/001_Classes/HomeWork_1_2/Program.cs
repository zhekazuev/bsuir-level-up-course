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

	class Book
	{
		
	}

	class Title
	{
		private string TitleField;

		public Title(string Title)
		{
			this.TitleField = Title;
		}

		public void Show()
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine(TitleField);
			Console.ResetColor(); 
		}

	}

	class Author
	{
		private string AuthorField;

		public Author(string Author)
		{
			this.AuthorField = Author;
		}

		public void Show()
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine(AuthorField);
			Console.ResetColor(); 
		}

	}

	class Content
	{
		private string ContentField;


		public Content(string Content)
		{
			this.ContentField = Content;
		}

		public void Show()
		{
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine(ContentField);
			Console.ResetColor();
		}

	}

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

			Title title = new Title(Title);
			Author author = new Author(Author);
			Content content = new Content(Content);

			title.Show();
			author.Show();
			content.Show();

		}
	}
}
