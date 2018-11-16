﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;

namespace Coneccion
{
    public class Conec
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        
        public Conexion()
        {
            try
            {
                con = new SqlConnection("Data Source=.;Initial Catalog=Odonto;Integrated Security=True");
                con.Open();
            }
            catch(Exception ex)
            {
                MesasageBox.Show("No se conecto correctamente con la base de datos: "+ ex.ToString());
            }
        }

        public  String insertarAlumno(int IdAlumnon, string Nombre, string ApPat, string ApMat, int IdPersmiso, int IdCarrera)        
        {
            string salida = "Alumno registrado correctamente";
            try
            {
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
                cmd = new SqlCommand("insert into Doctor values (" + IdDoctor + ",'" + Nombre + "','" + ApPat + "','" + ApMat + "'," + IdPersmiso + "," + IdCarrera + " )", con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
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
