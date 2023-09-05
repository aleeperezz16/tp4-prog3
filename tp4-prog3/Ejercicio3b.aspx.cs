using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace tp4_prog3
{
    public partial class Ejercicio3b : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string Nombre;
            string valor;
            Nombre = ((DropDownList)PreviousPage.FindControl("ddlTemas")).SelectedItem.ToString();
            valor = ((DropDownList)PreviousPage.FindControl("ddlTemas")).SelectedValue;

            string rutaLibreriaSQL = "Data Source=localhost\\sqlexpress;Initial Catalog=Libreria;Integrated Security=True";
            SqlConnection connection = new SqlConnection(rutaLibreriaSQL);
            connection.Open();
            string query = "SELECT * FROM Libros where IdTema = " + valor;
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader dr = cmd.ExecuteReader();
            grdLibros.DataSource = dr;
            grdLibros.DataBind();
            connection.Close();
        }
    }
}