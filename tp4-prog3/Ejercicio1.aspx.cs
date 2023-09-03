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
                SqlCommand cmdProvincias= new SqlCommand("SELECT * FROM Provincias;", connection);
                SqlDataReader dr = cmdProvincias.ExecuteReader();

                //Provincia
                while (dr.Read())
                {
                    string provincia = dr["NombreProvincia"].ToString();
                    string value = dr["IdProvincia"].ToString();

                    ddlProvinciaInicio.Items.Add(new ListItem(provincia, value));
                    ddlProvinciaFinal.Items.Add(new ListItem(provincia, value, false));
                }

                dr.Close();

                //Localidad
                SqlCommand cmdLocalidades = new SqlCommand("SELECT * FROM Localidades;", connection);
                dr = cmdLocalidades.ExecuteReader();

                while (dr.Read())
                {
                    string localidad = dr["NombreLocalidad"].ToString();
                    string value = dr["IdLocalidad"].ToString();

                    ddlLocalidadInicio.Items.Add(new ListItem(localidad, value, false));
                    ddlLocalidadFinal.Items.Add(new ListItem(localidad, value, false));   
                }

                connection.Close();
            }
        }

    }
}