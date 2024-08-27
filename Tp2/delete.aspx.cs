using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using tp2.api.Services;

namespace Tp2
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        usuariosService service = new usuariosService();
        public string Id = string.Empty;
        protected void Page_Load(object sender, EventArgs e)
        {
            Id = Request.QueryString["id"];
            this.msn.InnerText = $"Está seguro de eliminar el registro : {Id}";
        }

        protected void cmdConfirm_Click(object sender, EventArgs e)
        {
            bool result = service.DeleteUser(Id);
            if (result)
                Response.Redirect("index.aspx");
        }

        protected void cmdCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
        }
    }
}