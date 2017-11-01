using System;
using System.Collections.Generic;
using System.Linq;
using MonoTorrent.Client;//Подключили пространство имен для нашей нугет библиотеки
using MonoTorrent.Common;//Подключили пространство имен для нашей нугет библиотеки
using System.Text;
using System.Threading.Tasks;

namespace MonoTorrent
{
	class Program
	{
		
		static void Main(string[] args)
		{
			
			Torrent torrent = Torrent.Load(torrentFilePath);//Для получения информации о torrent-файле и последующей его загрузки
			TorrentManager manager = new TorrentManager(torrent, downloadFolderPath, new TorrentSettings());//для управления одним торрентом 
			ClientEngine engine = new ClientEngine(new EngineSettings());//необходимый для осуществления контроля и управления за всеми торрентами и клиента в общем
			engine.Register(manager);//отслеживание движком нашего менеджера
			manager.Start();//для начала загрузки файлов
		}
	}
}
