using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace tp4_prog3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                EstablecerConexion(); 


            }
        }


        void EstablecerConexion()
        {
            string rutaNeptunoSQL = "Data Source=localhost\\sqlexpress;Initial Catalog=Neptuno;Integrated Security=True";
            SqlConnection connection = new SqlConnection(rutaNeptunoSQL);
            connection.Open();
            SqlCommand cmd = new SqlCommand("Select * from Productos", connection);
            SqlDataReader dr = cmd.ExecuteReader();
            grdProductos.DataSource = dr;
            grdProductos.DataBind();
            connection.Close();

        }

        protected void btnQuitarFiltro_Click(object sender, EventArgs e)
        {
            txtFiltroCategoria.Text = "";
            txtFiltroProducto.Text = "";
        }
    }
}