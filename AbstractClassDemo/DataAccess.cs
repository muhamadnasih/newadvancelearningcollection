using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassDemo
{
    abstract class DataAccess
    {
        //to allow the child class to override but its no necessary
        public virtual string LoadConnectionString(string name)
        {
            Console.WriteLine("Load Connection string from DATA ACCESS");
            return "testconnectionstring";
        }

        public abstract void LoadData(string sql);

        public abstract void SaveData(string sql);
       
        


    }
}
