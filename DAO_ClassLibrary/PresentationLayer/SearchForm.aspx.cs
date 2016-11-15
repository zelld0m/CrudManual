using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentationLayer
{
    public partial class SearchForm : System.Web.UI.Page
    {
        int Id;
        String Name;
        int AccessLevel;
        String AuthorityName;
        ServiceReference1.Service1Client svc = new ServiceReference1.Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            Id = Convert.ToInt32(Request.QueryString["id"]);
            Name = Convert.ToString(Request.QueryString["Name"]);
            AccessLevel = Convert.ToInt32(Request.QueryString["AccessLevel"]);
            AuthorityName = Convert.ToString(Request.QueryString["AuthorityName"]);

            
        }

        protected void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void rb_1_CheckedChanged(object sender, EventArgs e)
        {
            //GridView2.DataSource= svc.sear
   
           // GridView2.DataBind();
            Clear(rb_1);
        }
        
        private void Clear(RadioButton rb)
        {
            if (rb.Checked)
            {
                rb.Checked = false;
            }
        }
        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}