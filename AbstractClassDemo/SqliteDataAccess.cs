using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassDemo
{
    class SqliteDataAccess : DataAccess
    {
        public override void LoadData(string sql)
        {
            Console.WriteLine("this is load data from sql lite data access" );
        }

        public override void SaveData(string sql)
        {
            Console.WriteLine("this is save data from sql lite data access");
        }
    }
}
