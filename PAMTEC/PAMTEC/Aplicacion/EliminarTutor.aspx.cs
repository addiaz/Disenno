using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using Pamtec.Negocio;
using System.Web.UI.WebControls;
using System.Data;

namespace PAMTEC.Aplicacion
{
    public partial class EliminarTutor : System.Web.UI.Page
    {
        private readonly ITutorService service;

        public EliminarTutor()
        {
            this.service = new TutorService();

        }
        protected void Page_Load(object sender, EventArgs e)
        {

            cargaInfo();
        }

        //Metodo para vaciar Textbox del form
        public void vaciarTextBox()
        {
            TextBoxNombre.Text = string.Empty;


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string Nombre = TextBoxNombre.Text;

            DataTable ds = new DataTable();

            if (Nombre != "")
            {
                ds = service.ObtenerTutores_X_Nombre(Nombre);

                if (ds.Rows.Count > 0)
                {
                    GridView1.DataSource = ds;
                    GridView1.DataBind();
                    GridView1.Visible = true;
                }

                else
                {
                    LabelMensaje.Text = "No se encuentran tutores registrados este nombre";
                    LabelMensaje.Visible = true;

                }

            }
            else
            {
                LabelMensaje.Text = "Debe de ingresar el nombre que desea buscar";
                LabelMensaje.Visible = true;
            }

        }

        //Metodo para cargar informacion de la base de datos.
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
                LabelMensaje.Text = "No existen tutores registrados";
                LabelMensaje.Visible = true;

            }

        }

        protected void Eliminar(object sender, GridViewDeleteEventArgs e)
        {
            int resultado = -1;

            // string carnet = Convert.ToString(GridView1.SelectedRow.Cells[1]);
            TableCell celdaCarnet = GridView1.Rows[e.RowIndex].Cells[1];
            string carnet = celdaCarnet.Text;
            resultado = service.EliminarTutor(carnet);
            if (resultado != -1)
            {
                LabelMensaje.Text = "Tutor eliminado correctamente";
                LabelMensaje.Visible = true;


            }
            else
            {
                LabelMensaje.Text = "Error al eliminar Tutor";
                LabelMensaje.Visible = true;

            }

        }


        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }





    }
}