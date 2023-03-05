using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassDemo
{
    class SqlDataAccess : DataAccess
    {

        public override string LoadConnectionString(string name)
        {
            string output = base.LoadConnectionString(name);
            output = "this is from SQL DATA access" + output;
            return output;
        }

        public override void LoadData(string sql)
        {
            Console.WriteLine("this load data is from sql data");
        }


        public override void SaveData(string sql)
        {
            Console.WriteLine("this is sava data from sql data access");
        }
    }


    class MyClass
    {

    }

    class MyClasstwo : MyClass
    {

    }

     
}
