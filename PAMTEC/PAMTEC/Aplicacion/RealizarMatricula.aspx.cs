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
    public partial class RealizarMatricula : System.Web.UI.Page
    {
        private readonly IMatriculaService service;
        public RealizarMatricula() {
            this.service = new MatriculaService();
        
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string cedula = TextBoxCedula.Text;
            DataTable tabla = new DataTable();
            tabla = service.Requisito(cedula);
            if (tabla.Rows.Count > 0) {
                GridView1.DataSource = tabla;
                GridView1.DataBind();
                GridView1.Visible = true;
            
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int resultado = -1;
            //string estao = "En Curso";
            GridViewRow row = GridView1.SelectedRow;
            string cedula = TextBoxCedula.Text;
            int grupo = Convert.ToInt32(row.Cells[1].Text);
            int cupo = Convert.ToInt32(row.Cells[6].Text);
            string codigoAula = row.Cells[7].Text;
            if (cupo > 0)
            {
                // string codigo = row.Cells[2].Text;
                resultado = service.Matricular(cedula, grupo);
                if (resultado != -1)
                {
                    LabelMensaje.Text = "Matricula realizada correctamente";
                    LabelMensaje.Visible = true;
                    cupo = cupo - 1;
                    service.dismunuirCupo(codigoAula, cupo);
                    Response.Redirect("RealizarMatricula.aspx");
                    LabelMensaje.Text = "Matricula Realizada correctamente";
                    LabelMensaje.Visible = true;
                }
                else
                {
                    LabelMensaje.Text = "Error al realizar matricula";
                    LabelMensaje.Visible = true;
                }
            }
            else {
                LabelMensaje.Text = "No hay cupo";
            
            }
 
        }


    }
}