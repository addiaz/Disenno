using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Pamtec.Negocio;
using Negocio;

namespace PAMTEC.Aplicacion
{
    public partial class AgregarEstudianteTutor : System.Web.UI.Page
    {
        private readonly IEstudianteService service;
        public AgregarEstudianteTutor() {
            this.service = new EstudianteService();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
    
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int resultado = -1;
            string cedula = TextBoxCarnet.Text;
            string nombre = TextBoxNombre.Text;
            string apellidos = TextBoxApellidos.Text;
            string fechaNacimiento = TextBoxfchNacimiento.Text;
            string tel = TextBoxNumeroTelefono.Text;
            string direccion = TextArea1.Value;
            resultado = service.IngresarEstudiante(cedula, nombre, apellidos, fechaNacimiento, tel, direccion);
            if (resultado != -1)
            {
                Label9.Text = "El Estudiante se ha registrado correctamente";
                Label9.Visible = true;
            }
            else {
                Label9.Text = "Fallo al registrar estudiante";
                Label9.Visible = false;
            }



        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Calendar1.Visible = true;
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            TextBoxfchNacimiento.Text = Calendar1.SelectedDate.ToLongDateString();
            Calendar1.Visible = false;
        }
    }
}