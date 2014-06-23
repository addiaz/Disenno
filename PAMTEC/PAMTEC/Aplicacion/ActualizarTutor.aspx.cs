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
    public partial class ActualizarTutor : System.Web.UI.Page
    {
        private readonly ITutorService service;
        protected bool bandera = false;
        public ActualizarTutor()
        {

            this.service = new TutorService();

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Panel1.Visible = false;
            cargaInfo();
        }

        public void cargaInfo()
        {
            DataTable ds = new DataTable();
            ds = service.ObtenerTutores();
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            editarInformacion();
          
           
        }



        public void editarInformacion()
        {
            int resultado = -1;
            string carnet = TextBoxCarnet.Text;
            string nombre = TextBoxNombre.Text;
            string apellidos = TextBoxApellidos.Text;
            string fechaNacimiento = TextBoxFecha.Text;
            string numeroTelefono = TextBoxTel.Text;
            string correo = TextBoxCorreo.Text;
            string direccion = TextBoxDireccion.Text;
            string categoria = Convert.ToString(DropDownList1.SelectedItem.Text);
            resultado = service.ActualizarTutor(carnet, nombre, apellidos, fechaNacimiento, numeroTelefono, correo, direccion, categoria);
            if (resultado != -1)
            {
                Response.Redirect("ActualizarTutor.aspx");
                LabelMensaje.Text = "Los datos han sido actualizados correctamente";
                LabelMensaje.Visible = true;

               
            }

            else
            {
                LabelMensaje.Text = "Error al editar los datos";
                LabelMensaje.Visible = true;
            }




        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GridView1.SelectedRow;
            TextBoxCarnet.Text = row.Cells[1].Text;
            TextBoxNombre.Text = row.Cells[2].Text;
            TextBoxApellidos.Text = row.Cells[3].Text;
            TextBoxFecha.Text = row.Cells[4].Text;
            TextBoxTel.Text = row.Cells[5].Text;
            TextBoxCorreo.Text = row.Cells[6].Text;
            TextBoxDireccion.Text = row.Cells[7].Text;
            DropDownList1.SelectedItem.Text = row.Cells[8].Text;

            GridView1.Visible = false;
            Panel1.Visible = true;

        }





    }
}