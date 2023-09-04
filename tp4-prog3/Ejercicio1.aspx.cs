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
                ///Ruta de David- no borrar
                ///string  rutaViajesSQL ="Data Source = DESKTOP-CIET1TI\\SQLEXPRESS01; Initial Catalog=Viajes; Integrated Security = True";
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
                
                SqlCommand cmdLocalidades = new SqlCommand("SELECT * FROM Localidades ;", connection);
                dr = cmdLocalidades.ExecuteReader();

                while (dr.Read())
                {
                    string localidad = dr["NombreLocalidad"].ToString();
                    string value = dr["IdProvincia"].ToString();

                    ddlLocalidadInicio.Items.Add(new ListItem(localidad, value, false));
                    ddlLocalidadFinal.Items.Add(new ListItem(localidad, value, false));
                }
               
                dr.Close();
                connection.Close();
            }
        }

        protected void ddlProvinciaInicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            string prov = ddlProvinciaInicio.SelectedValue;
            HabilitarLocalidadSegunProvincia(ddlLocalidadInicio, prov);

            for (int i = 1; i < ddlProvinciaFinal.Items.Count; i++)
            {
                ListItem item = ddlProvinciaFinal.Items[i];
                item.Enabled = item.Value != prov;
            }
        }

        protected void ddlProvinciaFinal_SelectedIndexChanged(object sender, EventArgs e)
        {
            string prov = ddlProvinciaFinal.SelectedValue;
            HabilitarLocalidadSegunProvincia(ddlLocalidadFinal, prov);
        }

        void HabilitarLocalidadSegunProvincia(DropDownList ddl, String prov)
        {
            for (int i = 1; i < ddl.Items.Count; i++)
            {
                ListItem item = ddl.Items[i];
                item.Enabled = item.Value == prov;
            }
        }
    }
}