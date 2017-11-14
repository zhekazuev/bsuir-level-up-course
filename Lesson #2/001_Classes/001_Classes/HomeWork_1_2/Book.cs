using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_1_2
{
	class Book
	{
		// Класс с названием книги
		public class Title
		{
			private string TitleField;

			public void Show()
			{
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine(TitleField);
				Console.ResetColor();
			}

			public string SetTitle(string Title)
			{
				return this.TitleField = Title; 
			}
			public string GetTitle(string Title)
			{
				return TitleField;
			}

		}
		// Класс с именем автора книги
		public class Author
		{
			private string AuthorField;

			public void Show()
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine(AuthorField);
				Console.ResetColor();
			}

			public string SetAuthor(string Author)
			{
				return this.AuthorField = Author;
			}
			public string GetAuthor(string Author)
			{
				return AuthorField;
			}

		}
		// Класс с тектом книги
		public class Content
		{
			private string ContentField;

			public void Show()
			{
				Console.ForegroundColor = ConsoleColor.Blue;
				Console.WriteLine(ContentField);
				Console.ResetColor();
			}

			public string SetContent(string Content)
			{
				return this.ContentField = Content;
			}
			public string GetContent(string Content)
			{
				return ContentField;
			}

		}

	}
}
