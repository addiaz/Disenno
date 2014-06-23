using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Pamtec.Negocio;
using System.Data;

namespace PAMTEC.Aplicacion
{
    public partial class ConsultarTutor : System.Web.UI.Page
    {
        private readonly ITutorService service;

        public ConsultarTutor() {
            this.service = new TutorService();
        
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            LabelMensaje.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string Nombre = TextBoxNombre.Text;
            string Apellido = TextBoxApellidos.Text;
            if (Nombre == "" && Apellido == "") {
                LabelMensaje.Text = "Debe ingresar algun dato";
                LabelMensaje.Visible = true;
            }

            else {
                if (Nombre != "" && Apellido != "")
                {
                    cargarInfoFiltradaNombre_Apellidos();
                }

                if (Nombre != "" && Apellido == "")
                {

                    cargarInfoNombre();
                }

                if (Nombre == "" && Apellido != "")
                {
                    cargarInfoApellido();
                }
          
            }
        


            
        }
        protected void eventoLabelBotton(object sender, EventArgs e)
        {
            cargarInfoTotal();
        }

        public void cargarInfoTotal()
        {

            DataTable ds = new DataTable();
            ds = service.ObtenerTutores();
            GridView1.DataSource = ds;
            GridView1.DataBind();
            GridView1.Visible = true;
            Panel1.Visible = false;

        }


        public void cargarInfoFiltradaNombre_Apellidos()
        {

            string Nombre = TextBoxNombre.Text;
            string Apellido = TextBoxApellidos.Text;
            DataTable ds = new DataTable();


            ds = service.ObtenerTutores_X_NombreApellido(Nombre, Apellido);
            if (ds.Rows.Count > 0)
            {
                GridView1.DataSource = ds;
                GridView1.DataBind();
                Panel1.Visible = false;
                GridView1.Visible = true;

            }

            else
            {
                LabelMensaje.Text = "No se ha encontrado información de este tutor";
                LabelMensaje.Visible = true;

            }


        }

        public void cargarInfoNombre()
        {
            string Nombre = TextBoxNombre.Text;
            DataTable ds = new DataTable();
            ds = service.ObtenerTutores_X_Nombre(Nombre);
            if (ds.Rows.Count > 0)
            {
                GridView1.DataSource = ds;
                GridView1.DataBind();
                Panel1.Visible = false;
                GridView1.Visible = true;

            }

            else
            {
                LabelMensaje.Text = "No se ha encontrado información de este tutor";
                LabelMensaje.Visible = true;

            }

        }


        public void cargarInfoApellido()
        {
            string Apellidos = TextBoxApellidos.Text;
            DataTable ds = new DataTable();
            ds = service.ObetenerTutores_X_Apellidos(Apellidos);
            if (ds.Rows.Count > 0)
            {
                GridView1.DataSource = ds;
                GridView1.DataBind();
                Panel1.Visible = false;
                GridView1.Visible = true;

            }

            else
            {
                LabelMensaje.Text = "No se ha encontrado información de este tutor";
                LabelMensaje.Visible = true;
            }

        }

    
    }

}