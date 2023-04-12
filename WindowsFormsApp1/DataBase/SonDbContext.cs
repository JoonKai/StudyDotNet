using MySql.Data.EntityFramework;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DataBase
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class SonDbContext :DbContext
    {
        public SonDbContext() : base("server=127.0.0.1;port=3306;uid=root;pwd=1234;database=son;")
        {
            
        }
    }
}
