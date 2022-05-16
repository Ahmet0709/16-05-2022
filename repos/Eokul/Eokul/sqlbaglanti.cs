using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Eokul
{
    class sqlbaglanti
    {
        public MySqlConnection baglan() 
        {
            MySqlConnection baglanti = new MySqlConnection("Server = localhost; Database = eokul; Uid = root; Pwd = 12345;");
            baglanti.Open();
            MySqlConnection.ClearPool(baglanti);
            return (baglanti);
        }
    }
}
