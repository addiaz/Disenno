using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Pamtec.Negocio;

namespace PAMTEC.Aplicacion
{
    public partial class AgregarTutor : System.Web.UI.Page
    {
        private readonly ITutorService service;

        public AgregarTutor() {
            this.service = new TutorService();
        
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBoxfchNacimiento.ReadOnly = true;
        }

        protected void TextBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           //TextBoxfchNacimiento.Text = Calendar1.ToString();
            agregarTutor();
            
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

        public void agregarTutor() {

            int resultado = -1;
            string carnet = TextBoxCarnet.Text;
            string nombre = TextBoxNombre.Text;
            string apellidos = TextBoxApellidos.Text;

            string fechaNacimiento = TextBoxfchNacimiento.Text;

            string numeroTelefono = TextBoxNumeroTelefono.Text;
            string correo = TextBoxCorreo.Text;
            string direccion = TextBoxDireccion.Text;
            string categoria = Convert.ToString(DropDownList1.SelectedItem.Text);
            if (carnet != "" && nombre != "" && apellidos != "" && fechaNacimiento != "" && numeroTelefono != "" && direccion != "" && categoria != "" && correo != "")
            {
                resultado = service.IngresarTutor(carnet, nombre, apellidos, fechaNacimiento, numeroTelefono, correo, direccion, categoria);
                if (resultado != -1)
                {
                    LabelMensaje.Text = "Tutor agregado correctamente";
                    LabelMensaje.Visible = true;

                }
                else
                {
                    LabelMensaje.Text = "Error al registrar Tutor";
                    LabelMensaje.Visible = true;
                }

            }
            else
            {
                LabelMensaje.Text = "Debe ingresar todos los campos";
                LabelMensaje.Visible = true;

            }

        
        }

    

    }
}