using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singletone
{
     class DataBase
    {
        private static DataBase instanse;

        public DataBase()
        {

        }

        public static DataBase GetInstance()
        {
            if (DataBase.instanse == null)
            {
                DataBase.instanse = new DataBase();
            }
            return DataBase.instanse;
        }
        public void Query(string sql)
        {
            Console.WriteLine(sql);
        }
    }
}
