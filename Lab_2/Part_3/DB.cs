using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace MyApp2
{
    public class DB
    {
        //підключення до бд
        private readonly SQLiteConnection conn;

        public DB(string path)
        {
            //шлях , бд в проекті
            conn = new SQLiteConnection(path);
            //створення таблиці
            conn.CreateTable<Item>();
        }
        //отримання записів з таблиці
        public List<Item> GetItems() 
        {
            return conn.Table<Item>().ToList();
        }

        //додавання

        public int SaveItem(Item item) 
        {
            return conn.Insert(item);
        }
    }
}
