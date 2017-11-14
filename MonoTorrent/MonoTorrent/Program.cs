using System;
using System.Collections.Generic;
using System.Linq;
using MonoTorrent.Client;//Подключили пространство имен для нашей нугет библиотеки
using MonoTorrent.Common;//Подключили пространство имен для нашей нугет библиотеки
using System.Text;
using System.Threading.Tasks;

namespace MonoTorrent
{
	internal static class Program
	{
		private static void Main(string[] args)
		{
			if (args.Length != 2)
			{
				Console.WriteLine("Incorrect arguments given to input!");
			}

			var torrentFilePath = args[0];
			var downloadFolderPath = args[1];

			Downloader(torrentFilePath,downloadFolderPath);
			Console.ReadKey();
		}

		private static void Downloader(string torrentFilePath, string downloadFolderPath)
		{
			Torrent torrent = Torrent.Load(torrentFilePath);//управления одним торрентом 

			ClientEngine engine = new ClientEngine(new EngineSettings());//настройки самого движка нашего клиента, для начала пренебрегая этими настройками. 
			TorrentManager manager = new TorrentManager(torrent, downloadFolderPath, new TorrentSettings());//осуществления контроля и управления за всеми торрентами

			engine.Register(manager);//отслеживание движком нашего менеджера 
			manager.Start();//начала загрузки файлов
		}
	}

}

//Console.WriteLine("Выберите папку из списка ниже, откуда нужно взять торрент.Желательно выбрать путь 1.");
//Console.WriteLine("1 - D:/Torrent/c#.torrent");
//Console.WriteLine("2 - Путь отсутствует");
//string a = Console.ReadLine();

//switch (a)
//{
//	case "1":
//		string torrentFilePath = @"D:\Torrent\c#.torrent";
//		break;
//	case "2":
//		string torrentFilePath = @"пока тут пусто";
//		break;
//	default:
//		Console.WriteLine("Default case");
//		break;
//}

//Console.WriteLine("Выберите папку из списка ниже, куда нужно записать файл.Желательно выбрать путь 1.");
//Console.WriteLine("1 - D:/Torrent");
//Console.WriteLine("2 - Путь отсутствует");
//string b = Console.ReadLine();

//switch (b)
//{
//	case "1":
//		string downloadFolderPath = @"D:\Torrent";
//		break;
//	case "2":
//		string downloadFilePath = @"пока тут пусто";
//		break;
//	default:
//		Console.WriteLine("Default case");

//		break;

//}
