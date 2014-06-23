using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Threading;
using System.Threading.Tasks;

using Google;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v2;
using Google.Apis.Drive.v2.Data;
using Google.Apis.Services;


namespace PAMTEC
{
    public partial class API : System.Web.UI.Page
    {
        // public static string GetFullPath(string path);
        protected void Page_Load(object sender, EventArgs e)
        {

        }



        public static string ObtenerTipoArchivo(string archivo)
        {
            string mimeType = "application/unknown";
            string ext = System.IO.Path.GetExtension(archivo).ToLower();
            Microsoft.Win32.RegistryKey regKey = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(ext);
            if (regKey != null && regKey.GetValue("Content Type") != null)
                mimeType = regKey.GetValue("Content Type").ToString();
            return mimeType;
        }


        public void subirArchivo()
        {

            string ruta = @"C:\Users\addiaz\Desktop\DocumentosDrive\";
            string nombre = FileUpload1.PostedFile.FileName;
            string sExtension = ObtenerTipoArchivo(FileUpload1.FileName);


            UserCredential credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                   new ClientSecrets
                   {
                       ClientId = "704651064787-6l6ce8uiculoenaqera0fa40kd53t6sn.apps.googleusercontent.com",
                       ClientSecret = "uonquuVkIoLXGWjhLSicKpUL",
                   },
                   new[] { DriveService.Scope.Drive }, "user", CancellationToken.None).Result;

            // Servicio para realizar peticiones al google drive.
            var service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "Drive API Sample",
            });

            File body = new File();
            body.Title = nombre;
            body.Description = "A test document";
            body.MimeType = sExtension;

            // byte[] byteArray = System.IO.File.ReadAllBytes(Server.MapPath(nombre));
            byte[] byteArray = System.IO.File.ReadAllBytes("C:/Users/Adrian/Desktop/DcomuentosDrive/" + nombre);
            System.IO.MemoryStream stream = new System.IO.MemoryStream(byteArray);

            FilesResource.InsertMediaUpload request = service.Files.Insert(body, stream, sExtension);
            request.Upload();
            File file = request.ResponseBody;

        }


        public void prueba()
        {
            FileUpload1.SaveAs(Server.MapPath("DocumentosNube\\" + FileUpload1.FileName));

        }

        protected void Button1_Click(object sender, System.EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                subirArchivo();
            }

            else
            {
                LabelMensaje.Text = "No se selecciono ningu archivo";
                LabelMensaje.Visible = true;
            }



        }

    }
}