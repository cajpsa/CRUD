using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


/// <summary>
/// Descripción breve de BDManager
/// </summary>
public class BDManager
{
	public BDManager()
	{
		//
		// TODO: Agregar aquí la lógica del constructor
		//
	}


    //CRUD  ejemplo de Crud 
    // Create
    public void createBanda(banda b)
    {
        string Insert = " INSERT INTO banda VALUES('"+b.Nombre+"','"+b.Estilo+"')";
        ejecutar(Insert);
    }
 
    // Delete
    public void deleteBanda(string codigo)
    {
        string delete = " DELETE FROM banda WHERE codigo = '" + codigo + "'";
        ejecutar(delete);
       
    }

    // Update
    public void updateBanda(banda b)
    {
        string update = " UPDATE  banda SET  nombre = '"+ b.Nombre +"', estilo ='"+ b.Estilo +"' WHERE codigo = '"+ b.Codigo +"'";
        ejecutar(update);
    }

    private int ejecutar(string SQL)
    {
        int retornar = 1;
        Conexion cone = new Conexion();
        try
        {
            cone.conectar();
            cone.sen = new SqlCommand(SQL, cone.con);
            //cone.sen.BeginExecuteNonQuery();
            string rowCount = cone.sen.BeginExecuteNonQuery().ToString();       
            cone.desconectar();
            if (rowCount == "" || rowCount == null)
            {

                retornar = 0;
            }            
        }
        catch (Exception ex)
        {
            retornar = 0;
            cone.desconectar();
            ex.ToString();  
           
        }
        return  retornar;
    }

    // Read
    public banda buscarBanda(string codigo)
    {
        banda b = null;

        string select = "SELECT * FROM WHERE codigo = '" + codigo + "' ";
        Conexion cone = new Conexion();
        cone.conectar();
        cone.sen = new SqlCommand(select, cone.con);
        cone.rs = cone.sen.ExecuteReader();

        while (cone.rs.Read())
        {
            b = new banda();
            b.Codigo = (int)cone.rs["codigo"];
            b.Nombre = cone.rs["nombre"].ToString();
            b.Estilo = cone.rs.GetString(3);
        }

        cone.desconectar();

        return b;
    }

}