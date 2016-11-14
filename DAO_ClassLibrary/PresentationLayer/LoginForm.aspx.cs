using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace PresentationLayer
{
    public partial class LoginForm : System.Web.UI.Page
    {

        ServiceReference1.Service1Client svc = new ServiceReference1.Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_Login_Click(object sender, EventArgs e)
        {

        }

        protected void Btn_Out_Click(object sender, EventArgs e)
        {
            GridView1.DataSource= svc.Validation(Tb_Name.Text, Tb_AuthorityName.Text);
            GridView1.DataBind();
        }
    }
}