using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Pamtec.Negocio;
using System.Data;
using Microsoft.Reporting.WebForms;

namespace PAMTEC.Aplicacion
{
    public partial class InformeEstudiante : System.Web.UI.Page
    {
        private readonly IEstudianteService service;

        public InformeEstudiante()
        {
            this.service = new EstudianteService();

        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string cedula = TextBox1.Text;
            DataTable tabla = new DataTable();
            tabla = service.reporteEstudiante(cedula);
            if (tabla.Rows.Count > 0)
            {
                GridView1.DataSource = tabla;
                GridView1.DataBind();
                GridView1.Visible = true;

            }

            else {

                Label1.Text = "NO hay datos de este estudiante";
                Label1.Visible = true;
            }
        }
    }


}