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
            if (!IsPostBack)
            {
                string rutaLibreriaSQL = "Data Source=localhost\\sqlexpress;Initial Catalog=Libreria;Integrated Security=True";
                SqlConnection connection = new SqlConnection(rutaLibreriaSQL);

                string valor = ((DropDownList)PreviousPage.FindControl("ddlTemas")).SelectedValue;
                connection.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM Libros WHERE IdTema = " + valor, connection);
                SqlDataReader dr = cmd.ExecuteReader();

                grdLibros.DataSource = dr;
                grdLibros.DataBind();
                connection.Close();
            }
        }

        protected void lbtnElegirTema_Click(object sender, EventArgs e)
        {
            Response.Redirect("Ejercicio3a.aspx");
        }
    }
}