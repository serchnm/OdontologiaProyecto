using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;
using System.Windows.Forms;

namespace Coneccion
{
    public class Conec
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        

        public  String insertarAlumno(int IdAlumnon, string Nombre, string ApPat, string ApMat, int IdPersmiso, int IdCarrera)        
        {
            string salida = "Alumno registrado correctamente";
            try
            {
                con = new SqlConnection("Data Source=.;Initial Catalog=Odonto;Integrated Security=True");
                        con.Open();
                cmd = new SqlCommand("insert into Alumno values ("+IdAlumnon+",'"+Nombre+"','"+ApPat+"','"+ApMat+"',"+IdPersmiso+","+IdCarrera+" )", con);
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }

        public String InsertarProfesor(int IdDoctor, string Nombre, string ApPat, string ApMat, int IdPersmiso, int IdCarrera)
        {
            string salida = "Doctor registrado correctamente";
            try
            {
                cmd = new SqlCommand("insert into Doctor (IdDoctor, Nombre, ApPat, ApMat, IdPermiso,IdCarrera) values (" + IdDoctor + ",'" + Nombre + "','" + ApPat + "','" + ApMat + "'," + IdPersmiso + "," + IdCarrera + " )", con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }

            return salida;
        }

        public String Configuracion( string NContrasena, int Usuario )
        {
            string salida = "Contraseña actualizada";
            try
            {
                cmd = new SqlCommand("update InicioSecion set Contrasena= '"+ NContrasena+"' where Usuario= "+Usuario+" ",con);
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }

        public  String NuevoLoginAlumno(int Nacceso, string contra,int permiso)
        {
            string salida = "Login creado";
            
            try
            {
                con = new SqlConnection("Data Source=.;Initial Catalog=Odonto;Integrated Security=True");
                con.Open();
                cmd = new SqlCommand("insert into InicioSecion values (" + Nacceso+", '"+contra+"',"+permiso+")",con);
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                salida = "No se pudo crear contraseña para este usuario " + ex.ToString();
            }
            return salida;
        }

        public String  NuevoLoginDoc(int Nacceso, string contra, int permiso)
        {
            string salida = "Login creado";

            try
            {
                con = new SqlConnection("Data Source=.;Initial Catalog=Odonto;Integrated Security=True");
                con.Open();
                cmd = new SqlCommand("insert into InicioSecion values (" + Nacceso + ", '" + contra + "'," + permiso + ")", con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se pudo crear contraseña para este usuario " + ex.ToString();
            }
            return salida;
        }
       
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
