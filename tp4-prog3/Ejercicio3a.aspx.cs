using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace tp4_prog3
{
    public partial class Ejercicio3a : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string rutaLibreriaSQL = "Data Source=localhost\\sqlexpress;Initial Catalog=Libreria;Integrated Security=True";
                SqlConnection connection = new SqlConnection(rutaLibreriaSQL);

                SqlCommand cmd = new SqlCommand("SELECT * FROM Temas", connection);
                SqlDataReader dr = cmd.ExecuteReader();


                while (dr.Read())
                {
                    string temas = dr["Tema"].ToString();
                    string value = dr["IdTema"].ToString();

                    ddlTemas.Items.Add(new ListItem(temas, value));
                }
            }
        }
    }
}