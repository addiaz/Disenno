using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using System.Data;

namespace PAMTEC
{
    public partial class ActualizarCurso : System.Web.UI.Page
    {
        private readonly ICursoService service;

        public ActualizarCurso() {
            this.service = new CursoService();
        
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            cargaInfo();
        }

        public void cargaInfo()
        {
            DataTable ds = new DataTable();
            ds = service.ConsultarCurso();
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
        public void editarInformacionCurso()
        {
            int resultado = -1;
            string codigo = TextBoxCodigo.Text;
            string nombre = TextBoxNombre.Text;
            string descripcion = TextArea1.Value;

            resultado = service.EditarCurso(codigo, nombre, descripcion);
            if (resultado != -1)
            {
                Response.Redirect("ActualizarCurso.aspx");
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
            TextBoxCodigo.Text = row.Cells[1].Text;
            TextBoxNombre.Text = row.Cells[2].Text;
            TextArea1.Value = row.Cells[3].Text;
   
            GridView1.Visible = false;
            Panel1.Visible = true;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            editarInformacionCurso();
        }
    }
}