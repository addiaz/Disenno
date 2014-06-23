using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Pamtec.Negocio;
using System.Data;

namespace PAMTEC.Aplicacion
{
    public partial class ConsultarGrupo : System.Web.UI.Page
    {
        private readonly IGrupoService service;
        public ConsultarGrupo() {
            this.service = new GrupoService();
        
        }


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string curso = DropDownList2.Text;
            string trimestre = DropDownList1.Text;
            string carnet = TextBox1.Text;
            DataTable tabla = new DataTable();

            tabla = service.consultar(curso,carnet,trimestre);

            if (tabla.Rows.Count > 0)
            {
                GridView1.DataSource = tabla;
                GridView1.DataBind();
                GridView1.Visible = true;

            }
            else {
                LabelMensaje.Text = "No existe ningun grupo asociado a los datos ingresados";
                LabelMensaje.Visible =  true;
            
            }


        }
    }
}