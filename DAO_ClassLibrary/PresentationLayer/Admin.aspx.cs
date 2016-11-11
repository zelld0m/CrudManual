using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;// we must use Service layer not BusinessLayer

namespace PresentationLayer
{
    public partial class Admin : System.Web.UI.Page
    {
        Business b = new Business();      // Using BusinessLayer is working  
        ServiceReference1.Service1Client svc = new ServiceReference1.Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            

            //GridView1.DataSource=  svc.viewALLDummy();
            //GridView1.DataBind();
        }

        void refresh()
        {
            GridView1.DataSource = b.view_dummy();
            GridView1.DataBind();
        }
        #region Buttons
        protected void _BtnAdd_Click(object sender, EventArgs e)
        {
           // b.name = _Tb_Name.Text;
           // b.insert_Dummy();
            svc.addDummy(_Tb_Name.Text);
            refresh();
        }

        protected void _BtnSearch_Click(object sender, EventArgs e)   // ERROR IN SEARCH
        {
            b.id = Convert.ToInt32( _Tb_ID.Text);
           // b.Search_dummy(b.id);
            //refresh();
            b.Search22_dummy(b.id);

        }

        protected void _BtnUpdate_Click(object sender, EventArgs e)
        {
            //  svc.UpdateDummy(Convert.ToInt32(_Tb_ID.Text), _Tb_Name.Text);

            b.id = Convert.ToInt32(_Tb_ID.Text);
            b.name = _Tb_Name.Text;
            b.update_Dummy(b.id);
            refresh();
        }

        protected void _btnDelete_Click(object sender, EventArgs e)
        {
          //  b.id = Convert.ToInt32(_Tb_ID.Text);
          //  b.delete_Dummy(b.id);
            svc.deleteDummy(Convert.ToInt32(_Tb_ID.Text));
            refresh();
        }
        #endregion buttons
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}