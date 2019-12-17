using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace ProyNavidad
{
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection cn = new SqlConnection("Data Source=SEGUNDO150;Initial Catalog=AVAN_iban;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            cn.Open();
            string consulta = "select count(*) from navi.Login where Usuario= @usuario and Password = @password";
            SqlCommand cm = new SqlCommand(consulta, cn);
            cm.Parameters.AddWithValue("@usuario", txtUsuario.Text);
            cm.Parameters.AddWithValue("@password", txtPass.Text);

            //Si existe un usuario con los datos retorna true, caso contrario false
            bool correcto = Convert.ToInt32(cm.ExecuteScalar()) > 0;

            if (correcto)
            {
                //Si existe, Bienvenido...
                Response.Redirect("");

            }
            else
            {
                lblError.Text = "Usuario o contraseña incorrecta";
                lblError.Visible = true;
                txtUsuario.Text = "";
                txtPass.Text = "";
                txtUsuario.Focus();

            }
            cn.Close();

        }
    }
}