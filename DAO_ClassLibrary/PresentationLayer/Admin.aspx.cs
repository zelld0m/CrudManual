using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentationLayer
{
    public partial class Admin : System.Web.UI.Page
    {
        
        ServiceReference1.Service1Client svc = new ServiceReference1.Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            refresh();
        }
        void refresh()
        {
            GridView1.DataSource = svc.viewALLDummy();
            GridView1.DataBind();
            GridView2.DataSource = svc.viewAuthority();
            GridView2.DataBind();
        }
        #region Buttons
        protected void _BtnAdd_Click(object sender, EventArgs e)
        {

            svc.insertAuthority(_Tb_AuthorityName.Text, Convert.ToInt32(_Tb_AccessLevel.Text));
            svc.addDummy(_Tb_Name.Text);
            refresh();
        }
        protected void _BtnSearch_Click(object sender, EventArgs e)   // ERROR IN SEARCH
        {

            //  b.Search_dummy(b.id);
            // b.id = Convert.ToInt32(_Tb_ID.Text);
            // GridView1.DataSource= b.Search_dummy(b.id);
            // GridView1.DataBind();

            GridView2.DataSource = svc.searchAuthority(Convert.ToInt32(_Tb_ID.Text));
            GridView2.DataBind();
            GridView1.DataSource= svc.SearchDummy(Convert.ToInt32(_Tb_ID.Text));
            GridView1.DataBind();
        }
        protected void _BtnUpdate_Click(object sender, EventArgs e)
        {
            //refresh();
            svc.UpdateDummy(Convert.ToInt32(_Tb_ID.Text), _Tb_Name.Text);
            GridView1.DataSource= svc.SearchDummy(Convert.ToInt32(_Tb_ID.Text));
            GridView1.DataBind();
        }
        protected void _btnDelete_Click(object sender, EventArgs e)
        {

         
           // GridView1.DataBind();
            if (String.IsNullOrWhiteSpace(_Tb_ID.Text  ))
            {
     
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "ID BOX IS EMPTY  " + "');", true);    
                refresh();
            }
           
            else 
            {
                GridView1.DataSource = svc.SearchDummy(Convert.ToInt32(_Tb_ID.Text));
                GridView1.DataBind();

                if (GridView1.Rows.Count > 0)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + " Deleted " + "');", true);
                    svc.deleteDummy(Convert.ToInt32(_Tb_ID.Text));
                    refresh();
                }
                else if (GridView1.Rows.Count ==0)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + " NO ID FOUND " + "');", true);
                }
               
                refresh();
            }
           
        }
        #endregion buttons
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Btn_AuthorityName_Click(object sender, EventArgs e)
        {
            refresh();
        }
    }
}