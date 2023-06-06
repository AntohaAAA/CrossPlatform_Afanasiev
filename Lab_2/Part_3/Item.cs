using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace MyApp2
{
    public class Item
    {
        //анотація загалом таблицяSSS
        [PrimaryKey,AutoIncrement]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        public int Price { get; set; }
    }
}
