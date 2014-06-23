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
    public partial class ConsultarEstudianteTutor : System.Web.UI.Page
    {
        private readonly IEstudianteService service;
        public ConsultarEstudianteTutor()
        {

            this.service = new EstudianteService();
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string Nombre = TextBoxNombre.Text;
            string Apellidos = TextBoxApellidos.Text;
            if(Nombre == "" && Apellidos == ""){
                LabelMensaje.Text = "Debe completar al menos 1 campo";
                LabelMensaje.Visible = true;
            }

    
            else {
                if (Nombre != "" && Apellidos != "")
                {
                    cargarInfoFiltradaNombre_Apellidos();
                }
                if (Nombre != "" && Apellidos == "")
                {
                    cargarInfoNombre();
                }
                if (Nombre == "" && Apellidos != "")
                {
                    cargarInfoApellido();
                }
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            cargarInfoTotal();

        }

        public void cargarInfoTotal(){      

            DataTable ds = new DataTable();
            ds= service.ObtenerEstudiantes();
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


            ds = service.ObtenerEstudiantes_X_NombreApellido(Nombre, Apellido);
            if (ds.Rows.Count > 0)
            {
                GridView1.DataSource = ds;
                GridView1.DataBind();
                Panel1.Visible = false;
                GridView1.Visible = true;

            }

            else
            {
                LabelMensaje.Text = "No se ha encontrado información de este usuaio";
                LabelMensaje.Visible = true;

            }


        }

        public void cargarInfoNombre() {
            string Nombre = TextBoxNombre.Text;
            DataTable ds = new DataTable();
            ds = service.ObtenerEstudiantes_X_Nombre(Nombre);
            if (ds.Rows.Count > 0)
            {
                GridView1.DataSource = ds;
                GridView1.DataBind();
                Panel1.Visible = false;
                GridView1.Visible = true;

            }

            else
            {
                LabelMensaje.Text = "No se ha encontrado información de este usuaio";
                LabelMensaje.Visible = true;

            }
        
        }


        public void cargarInfoApellido()
        {
            string Apellidos = TextBoxApellidos.Text;
            DataTable ds = new DataTable();
            ds = service.ObtenerEstudiantes_X_Apellido(Apellidos);
            if (ds.Rows.Count > 0)
            {
                GridView1.DataSource = ds;
                GridView1.DataBind();
                Panel1.Visible = false;
                GridView1.Visible = true;

            }

            else
            {
                LabelMensaje.Text = "No se ha encontrado información de este usuaio";
                LabelMensaje.Visible = true;
            }

        }

    }
}