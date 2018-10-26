using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Coneccion2
{
    public class conectar
    {
        public static DataSet Ejecutar(string cmd)
        {

            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Odonto;Integrated Security=True");
            con.Open();
            DataSet DS = new DataSet();

            SqlDataAdapter dp = new SqlDataAdapter(cmd, con);
            dp.Fill(DS);
            con.Close();
            return DS;



        }
    }
}
