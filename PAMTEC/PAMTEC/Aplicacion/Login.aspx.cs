using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Pamtec.Negocio;
using System.Data;

namespace PAMTEC.Aplicacion
{
    public partial class Login : System.Web.UI.Page
    {
        private readonly ITutorService service;

        public Login() {
            this.service = new TutorService(); 
        
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

   

        protected void Button1_Click1(object sender, EventArgs e)
        {
          
  
            string usuario = TextBoxUsuario.Text;
            string pass = TextBoxPass.Text;
            DataTable tabla = new DataTable();
            DataTable tablaRol = new DataTable();

            tabla = service.VerificarUsuario(usuario, pass);
            tablaRol = service.VerificarRol(usuario);
            //string rol = tablaRol.Rows[0][0].ToString();


            if (tabla.Rows.Count > 0)
            {
                if (tablaRol.Rows.Count == 2)
                {
                    Panel2.Visible = true;


                }
                else {

                    Response.Redirect("Noticia.aspx");
                }

            }
            else {
                LabelMensaje.Text = "Usuario o Contraseña incorrectos";
                LabelMensaje.Visible = true;
            
            }



        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Noticiasaspx.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Noticia.aspx");
        }

    }
}