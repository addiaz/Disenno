using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Pamtec.Negocio;
using Negocio;
using System.Data;

namespace PAMTEC.Aplicacion
{
    public partial class EliminarCurso : System.Web.UI.Page
    {
        private readonly ICursoService service;

        public EliminarCurso()
        {
            this.service = new CursoService();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                cargarInfo();
            }
        }

        public void cargarInfo()
        {
            DataTable tabla = new DataTable();
            tabla = service.ConsultarCurso();
            if (tabla.Rows.Count > 0)
            {
                GridView1.DataSource = tabla;
                GridView1.DataBind();
                GridView1.Visible = true;
            }
        }
        protected void Eliminar(object sender, GridViewDeleteEventArgs e)
        {
            int resultado = -1;
            TableCell celdaCodigo = GridView1.Rows[e.RowIndex].Cells[1];
            string codigo = celdaCodigo.Text;
            resultado = service.EliminarCurso(codigo);
            if (resultado != -1)
            {
                Label3.Text = "Curso Eliminado correctamente";
                Label3.Visible = true;

            }
            else
            {
                Label3.Text = "Error al eliminar curso";
                Label3.Visible = true;
            }
            Response.Redirect("EliminarCurso.aspx");


        }
    }
}