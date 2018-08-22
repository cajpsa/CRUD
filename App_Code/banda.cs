using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de banda
/// </summary>
public class banda
{
	
		//
		// TODO: Agregar aquí la lógica del constructor
		//

        private int codigo;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
       

        private String nombre;
        public String Nombre
        {
          get { return nombre; }
          set { nombre = value; }
        }


        private string estilo;

        public string Estilo
        {
            get { return estilo; }
            set { estilo = value; }
        }
       

	
}