using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using System.Data;

namespace PAMTEC.Aplicacion
{
    public partial class ActualizarEstudianteTutor : System.Web.UI.Page
    {
        private readonly IEstudianteService service;

        public ActualizarEstudianteTutor()
        {
            this.service = new EstudianteService();

        }
        protected void Page_Load(object sender, EventArgs e)
        {
           
                cargaInfo();           

        }
        protected void ButtonBuscar_Click(object sender, EventArgs e)
        {
            string nombre = TextBoxBuscaNombre.Text;
            DataTable tabla = new DataTable();
            tabla = service.ObtenerEstudiantes_X_Nombre(nombre);

            if (tabla.Rows.Count > 0)
            {
               
                GridView1.DataSource = tabla;
                GridView1.DataBind();
               // Response.Redirect("ActualizarEstudiante.aspx");
                
            }
            else
            {
                LabelMensaje.Text = "No se encontró ningún estudiante con este nombre";
                LabelMensaje.Visible = true;
            }

        }



        public void cargaInfo()
        {
            DataTable ds = new DataTable();
            ds = service.ObtenerEstudiantes();
            if (ds.Rows.Count > 0)
            {
                GridView1.DataSource = ds;
                GridView1.DataBind();
                GridView1.Visible = true;

            }
            else
            {
                LabelMensaje.Text = "No hay tutores registrados";
                LabelMensaje.Visible = true;

            }

        }

        protected void Editar(object sender, EventArgs e)
        {
           // Response.Redirect("ActualizarEstudiante.aspx");
            GridViewRow row = GridView1.SelectedRow;
            TextBoxCedula.Text = row.Cells[1].Text;
            TextBoxNombre.Text = row.Cells[2].Text;
            TextBoxApellidos.Text = row.Cells[3].Text;
            TextBoxfchNacimiento.Text = row.Cells[4].Text;
            TextBoxNumeroTelefono.Text = row.Cells[5].Text;
            TextBoxDireccion.Text = row.Cells[6].Text;       

            GridView1.Visible = false;
            Panel1.Visible = true;
        }

        public void editarInformacion()
        {
            int resultado = -1;
            string cedula = TextBoxCedula.Text;
            string nombre = TextBoxNombre.Text;
            string apellidos = TextBoxApellidos.Text;
            string fechaNacimiento = TextBoxfchNacimiento.Text;
            string numeroTelefono = TextBoxNumeroTelefono.Text;     
            string direccion = TextBoxDireccion.Text;
      
            //resultado = service.;
            resultado = service.EditarEstudiante(cedula, nombre, apellidos, fechaNacimiento, numeroTelefono, direccion);
            if (resultado != -1)
            {
                Response.Redirect("ActualizarEstudianteTutor.aspx");
                LabelMensaje.Text = "Los datos han sido actualizados correctamente";
                LabelMensaje.Visible = true;


            }

            else
            {
                LabelMensaje.Text = "Error al editar los datos";
                LabelMensaje.Visible = true;
            }




        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            editarInformacion();
        }




    }
}