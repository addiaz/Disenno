using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace PAMTEC.Aplicacion
{
    public partial class EliminarEstudiante : System.Web.UI.Page
    {
        private readonly IEstudianteService service;
        public EliminarEstudiante()
        {
            this.service = new EstudianteService();

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            cargaInfo();
        }

        protected void Buscar(object sender, EventArgs e)
        {
            string nombre = TextBoxNombre.Text;
            DataTable ds = new DataTable();

            if (nombre != "")
            {
                ds = service.ObtenerEstudiantes_X_Nombre(nombre);

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
                LabelMensaje.Text = "No existen tutores registrados";
                LabelMensaje.Visible = true;

            }

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Eliminar(object sender, GridViewDeleteEventArgs e)
        {
            int resultado = -1;

            // string carnet = Convert.ToString(GridView1.SelectedRow.Cells[1]);
            TableCell celdaCarnet = GridView1.Rows[e.RowIndex].Cells[1];
            string carnet = celdaCarnet.Text;
         //   resultado = service.E;
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
    }


}
