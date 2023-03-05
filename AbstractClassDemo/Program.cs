using System;
using System.Collections.Generic;

namespace AbstractClassDemo
{
    class Program
    {    //asbtract class cannot be instantiate
        //
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            List<DataAccess> dt = new List<DataAccess>()
            {
                new SqlDataAccess(),
                new SqliteDataAccess()

            };

            List<MyClass> da = new List<MyClass>();
            {
                new MyClasstwo();
            
            };


            foreach (var item in dt)
            {
                Console.WriteLine(item.LoadConnectionString("demo"));
                item.LoadData("demo");
                item.SaveData("table");
            }
        }
    }
}
