using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Class2
{
    public class Conec
    {


        public static DataSet Ejecutar(string cmd)
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-NRNVFA2\\SQLEXPRESS;Initial Catalog=Odonto;Integrated Security=True");
            con.Open();
            DataSet DS = new DataSet();

            SqlDataAdapter dp = new SqlDataAdapter(cmd, con);
            dp.Fill(DS);
            con.Close();
            return DS;



        }
    }
}
