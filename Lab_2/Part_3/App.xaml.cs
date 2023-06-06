using System.IO;

namespace MyApp2;

public partial class App : Application
{
	//створюємо бд
	private static DB db;
	public static DB Db 
	{
		get
		{
			//знаходимо папку проекту та комбінуємо з назвою файлу
			if (db == null)
				db = new DB(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),"db.sqlite3"));
			return db;
		}
	}
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();


	}
}
