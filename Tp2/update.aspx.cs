using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Documents;
using tp2.api.Services;
using tp2.models;

namespace Tp2
{
    public partial class update : System.Web.UI.Page
    {
        usuariosService service = new usuariosService();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            string Id = Request.QueryString["id"];
            string json = service.GetUsersById(Id);

            var data = JsonConvert.DeserializeObject<List<Usuario>>(json);

                if(data.Count > 0)
            {
                var item = data[0];

                    try
                    {
                        txtId.Text = item.Id.ToString();
                        txtNombre.Text = item.Nombre.ToString();
                        txtDni.Text = item.Dni.ToString();
                        txtEmail.Text = item.Email.ToString();
                    }
                    catch (Exception ex)
                    {

                        string mensaje = ex.Message;
                        Console.WriteLine("Error : " + mensaje);
                    }
              
            }

            }

        }

        protected void CmdupdateUserToDatabase_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            user.Id = Convert.ToInt32(txtId.Text);
            user.Nombre = txtNombre.Text;
            user.Dni = txtDni.Text;
            user.Email = txtEmail.Text;

            bool rta = service.UpdateUser(user);
            if (rta)
            {
                Response.Redirect("index.aspx");
            }
        }
    }
}