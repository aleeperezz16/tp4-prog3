using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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

 

        }
    }
}