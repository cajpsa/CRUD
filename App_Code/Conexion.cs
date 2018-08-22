using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Descripción breve de Conexion
/// </summary>
public class Conexion
{
    	
		//
		// TODO: Agregar aquí la lógica del constructor
		//
        public SqlConnection con = new SqlConnection("data source = MILDRED\\SQLEXPRESS; initial catalog = bandas_bd; user id = sa; password = Admin2015*+;");
        public SqlCommand sen;
        public SqlDataReader rs;

        //mi conexion:
       

       //procedimiento que abre la conexion sqlsever
       public void conectar()
       {
           try
           {
               con.Open();             
           }
           catch (Exception ex)
           {
              
           }
       }

       //procedimiento que cierra la conexion sqlserver
       public void desconectar()
       {
           try
           {
               con.Close();
           }
           catch (Exception ex)
           {

           }
          
       }

     
              
                           
	
}