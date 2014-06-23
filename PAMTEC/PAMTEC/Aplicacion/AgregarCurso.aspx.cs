using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Pamtec.Negocio;
using Negocio;

namespace PAMTEC.Aplicacion
{
    public partial class AgregarCurso : System.Web.UI.Page
    {
        private readonly ICursoService service;
        public AgregarCurso() { 
        this.service = new CursoService();
        
        }
        protected void Page_Load(object sender, EventArgs e)
        {
         
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            int resultado = -1;
            string codigo = TextBoxCodigo.Text;
            string nombre = TextBoxNombre.Text;
            string descripcion = TextArea1.Value;
            resultado = service.crearCurso(codigo, nombre, descripcion);
            if (resultado != -1)
            {
                Label4.Text = "Curso agregado correctamente";
                Label4.Visible = true;
            }
            else {
                Label4.Text = "Error al registrar curso";
                Label4.Visible = false;
            }
            TextArea1.Value = string.Empty;
            TextBoxCodigo.Text = string.Empty;
            TextBoxNombre.Text = string.Empty;
            

        }

    }
}