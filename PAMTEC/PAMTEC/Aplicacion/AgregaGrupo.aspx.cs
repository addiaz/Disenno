using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace PAMTEC.Aplicacion
{
    public partial class AgregaGrupo : System.Web.UI.Page
    {
        private readonly IGrupoService service;
        public AgregaGrupo()
        {
            this.service = new GrupoService();
        
        }
        protected void Page_Load(object sender, EventArgs e)
        {

          



        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int resultado = -1;
            int codigoGrupo = Convert.ToInt32(TextBox5.Text);
            string codigoCurso = DropDownList2.Text;
            string Tutor = TextBox2.Text;
            string fechaIncio = TextBox4.Text;
            string fechaFinal = TextBox1.Text;
            string aula = DropDownList3.Text;
            string trimestre = DropDownList1.Text;
            resultado = service.insertarGrupo(codigoGrupo,codigoCurso,Tutor,fechaIncio, fechaFinal, aula, trimestre);
            if (resultado != -1)
            {
                LabelMensaje.Text = "Grupo agregado correctamente";
                LabelMensaje.Visible = true;

            }

            else {
                LabelMensaje.Text = "Error al ingresar grupo";
                LabelMensaje.Visible = true;
            
            }

        }
    }
}