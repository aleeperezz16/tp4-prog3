using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace tp4_prog3
{
    public partial class Ejercicio1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                ///LO DEJO COMO ESTÁ, LA RUTA, Porque en mi caso, tendria que cambiar la ruta para que me funcioen -David
                string rutaViajesSQL = "Data Source=localhost\\sqlexpress;Initial Catalog=Viajes;Integrated Security=True";
                SqlConnection connection = new SqlConnection(rutaViajesSQL);
                connection.Open();
                SqlCommand cmd= new SqlCommand("Select * from Provincias", connection);
                SqlDataReader dr = cmd.ExecuteReader();
            }
        }

    }
}