using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    BDManager CRUD = new BDManager();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnCrear_Click(object sender, EventArgs e)
    {
        banda b = new banda();

        b.Nombre = txtNombre.Text;
        b.Estilo = txtEstilo.Text;

        CRUD.createBanda(b);
        txtNombre.Text = "";
        txtEstilo.Text = "";
        txtCodigo.Text = "";
    }
    protected void btnActualizar_Click(object sender, EventArgs e)
    {
        banda b = new banda();

        b.Nombre = txtNombre.Text;
        b.Estilo = txtEstilo.Text;

        CRUD.updateBanda(b);
        txtNombre.Text = "";
        txtEstilo.Text = "";
        txtCodigo.Text = "";
    }

    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Seleccionar")
        {

            string argumento = e.CommandArgument.ToString();
            // Convert the row index stored in the CommandArgument
            // property to an Integer.
            int index = Convert.ToInt32(e.CommandArgument.ToString());

            // Retrieve the row that contains the button clicked 
            // by the user from the Rows collection.      
            //GridViewRow row = ProductsGridView.Rows[index];

            //// Calculate the new price.
            //Label listPriceTextBox = (Label)row.FindControl("PriceLabel");
            //listPriceTextBox.Text = (Convert.ToDouble(listPriceTextBox.Text) * 1.05).ToString();

            //// Update the row.
            //ProductsGridView.UpdateRow(index, false);
        }
    }
}