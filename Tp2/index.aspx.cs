using RenderGridAspxDll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;
using tp2.api.Services;
using tp2.models;

namespace Tp2
{
    public partial class index : System.Web.UI.Page
    {
        public string GlobalId = "";
        usuariosService service = new usuariosService();
        protected void Page_Load(object sender, EventArgs e)
        {


            if (!IsPostBack)
            {

                errorAlert.Visible = false;
                GetUsers();
            }
          
        }

        public void GetUsers()
        {
            string jsonResponse = service.GetUsers();
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<Usuario> usuarios = serializer.Deserialize<List<Usuario>>(jsonResponse);
            this.grdDatos.InnerHtml = GenerateHtmlGrid(usuarios);
        }
        private string GenerateHtmlGrid(List<Usuario> usuarios)
        {
            StringBuilder htmlBuilder = new StringBuilder();
            htmlBuilder.Append("<table class='table'>");
            htmlBuilder.Append("<tr>");
            htmlBuilder.Append("<th>ID</th>");
            htmlBuilder.Append("<th>Nombre</th>");
            htmlBuilder.Append("<th>Dni</th>");
            htmlBuilder.Append("<th>Email</th>");
            htmlBuilder.Append("<th></th>");
            htmlBuilder.Append("</tr>");

            foreach (var usuario in usuarios)
            {
                htmlBuilder.Append("<tr>");
                htmlBuilder.Append($"<td>{usuario.Id}</td>");
                htmlBuilder.Append($"<td>{usuario.Nombre}</td>");
                htmlBuilder.Append($"<td>{usuario.Dni}</td>");
                htmlBuilder.Append($"<td>{usuario.Email}</td>");
                htmlBuilder.Append($"<td style='text-align:end'>");
                htmlBuilder.Append($"<a href='update.aspx?id={usuario.Id}' class='btn btn-primary btn-sm'>Actualizar</a>");
                //htmlBuilder.Append($"<a href='eliminar?id={usuario.Id}'    class='btn btn-danger btn-sm'>Eliminar</a>");
                htmlBuilder.Append($"</td>");
                htmlBuilder.Append("</tr>");
            }

            htmlBuilder.Append("</table>");
            return htmlBuilder.ToString();
        }

        public void CmdsendUserToDatabase_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Nombre= txtNombre.Text;
            usuario.Dni = txtDni.Text;
            usuario.Email = txtEmail.Text;
            bool result = service.PostUser(usuario);
            if (result)
            {
                GetUsers();
                errorAlert.Visible = true;
                errorAlert.Attributes.Remove("alert alert-danger");
                errorAlert.Attributes.Add("class","alert alert-success");
                messageText.InnerText = "Datos Guardados con exito.";
            }
            else
            {
                //Error
                errorAlert.Visible = true;
                errorAlert.Attributes.Remove("alert alert-success");
                errorAlert.Attributes.Add("class", "alert alert-danger");
                messageText.InnerText = "Es obligatorio completar los datos.";
            }
        }

        protected void cmdEraseButton_Click(object sender, EventArgs e)
        {
            //hacer funcion para que borre en base al ID escrito en txtErase
            string erase = txtEraseBox.Text;
            if (erase != "")
            {
                service.DeleteUser(erase);
                GetUsers();
                errorAlert.Visible = true;
                errorAlert.Attributes.Remove("alert alert-danger");
                errorAlert.Attributes.Add("class", "alert alert-success");
                messageText.InnerText = "Usuario Eliminado con exito.";
                txtEraseBox.Text = "";
            }
            else
            {
                errorAlert.Visible = true;
                errorAlert.Attributes.Remove("alert alert-success");
                errorAlert.Attributes.Add("class", "alert alert-danger");
                messageText.InnerText = "Envie un ID correcto.";
                txtEraseBox.Text = "";
            }

            /*protected void cmdUpdaeButton_Click(object sender, EventArgs e)
            {
                GlobalId = 
            }*/

        }

    }
}