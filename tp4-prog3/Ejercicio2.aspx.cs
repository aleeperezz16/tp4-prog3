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
        static string rutaNeptunoSQL = "Data Source=localhost\\sqlexpress;Initial Catalog=Neptuno;Integrated Security=True";
        static string selectQuery = "SELECT IdProducto, NombreProducto, IdCategoría, CantidadPorUnidad, PrecioUnidad FROM Productos";
        static SqlConnection connection = new SqlConnection(rutaNeptunoSQL);
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

            if (!IsPostBack)
            {
                MostrarDatosCompletos();
            }
        }

        void MostrarDatosCompletos()
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand(selectQuery, connection);
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

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            connection.Open();
            string query = selectQuery;

            if (txtFiltroProducto.Text.Length > 0)
                query += " WHERE IdProducto" + ddlFiltroProducto.SelectedValue + txtFiltroProducto.Text;
            
            if (txtFiltroCategoria.Text.Length > 0)
            {
                if (query != selectQuery)
                    query += " AND IdCategoría" + ddlFiltroCategoria.SelectedValue + txtFiltroCategoria.Text;
                else
                    query += " WHERE IdCategoría" + ddlFiltroCategoria.SelectedValue + txtFiltroCategoria.Text;  
            }

            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader dr = cmd.ExecuteReader();
            
            grdProductos.DataSource = dr;
            grdProductos.DataBind();
            connection.Close();
        }
    }
}