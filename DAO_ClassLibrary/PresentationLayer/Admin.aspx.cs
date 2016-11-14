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
        }
        #region Buttons
        protected void _BtnAdd_Click(object sender, EventArgs e)
        {

            
            svc.addDummy(_Tb_Name.Text);
            refresh();
        }
        protected void _BtnSearch_Click(object sender, EventArgs e)   // ERROR IN SEARCH
        {

            //  b.Search_dummy(b.id);
            // b.id = Convert.ToInt32(_Tb_ID.Text);
            // GridView1.DataSource= b.Search_dummy(b.id);
            // GridView1.DataBind();

            
            GridView1.DataSource= svc.SearchDummy(Convert.ToInt32(_Tb_ID.Text));
            GridView1.DataBind();
        }

        protected void _BtnUpdate_Click(object sender, EventArgs e)
        {
            svc.UpdateDummy(Convert.ToInt32(_Tb_ID.Text), _Tb_Name.Text);
            refresh();
        }
        protected void _btnDelete_Click(object sender, EventArgs e)
        {
            svc.deleteDummy(Convert.ToInt32(_Tb_ID.Text));
            refresh();
        }
        #endregion buttons
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}