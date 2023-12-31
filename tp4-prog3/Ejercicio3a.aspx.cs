﻿using System;
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
            {  ///SERVER-DAVIDstring rutaLibreriaSQL = "Data Source=DESKTOP-CIET1TI\\SQLEXPRESS01;Initial Catalog=Libreria;Integrated Security=True";
                string rutaLibreriaSQL = "Data Source=localhost\\sqlexpress;Initial Catalog=Libreria;Integrated Security=True";
                SqlConnection connection = new SqlConnection(rutaLibreriaSQL);
                connection.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM Temas", connection);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    string temas = dr["Tema"].ToString();
                    string value = dr["IdTema"].ToString();

                    ddlTemas.Items.Add(new ListItem(temas, value));
                }

                connection.Close();
            }
        }

        protected void lbtnVerLibros_Click(object sender, EventArgs e)
        {
            Server.Transfer("Ejercicio3b.aspx");
        }
    }
}