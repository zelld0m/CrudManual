using System;
using System.Collections.Generic;
//using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace UsingStreamReader
{
    public partial class ProductDetails : System.Web.UI.Page
    {
        
        static List<String> ListBrand = new List<string>();
        protected void Page_Load(object sender, EventArgs e)
        {

            sample.SaveALLEDP();
            #region test to show all
            if (!IsPostBack)
            {  sample.SearchmultipleDisplay("a", PlaceHolder1, ListBrand);
          
                rdbtnlst_Brand.ClearSelection();
                rdbtnlst_Brand.Controls.Clear();
                rdbtnlst_Brand.Items.Clear();
                NumberFound.Text = "Items Found : " + Convert.ToString(sample.getCount());
                for (int i = 0; i < ListBrand.Count; i++)
                {
                    rdbtnlst_Brand.Items.Add(new ListItem(ListBrand[i]));
                }
                rdbtnlst_Brand.AutoPostBack = true;
            }
            //---------------------------- enter on  SEARCH ---------------------------
          
            //----------------------------------------------------------------------------------------
            //ListBrand.Clear();
            #endregion
            //if (IsPostBack)
            //{
            //    rdbtnlst_Brand.ClearSelection();
            //    rdbtnlst_Brand.Controls.Clear();
            //}
            #region postback FOR BRAND SELECTION
            //if (!IsPostBack)  // 1st LOAD
            //{ 
            //    rdbtnlst_Brand.ClearSelection();
            //    rdbtnlst_Brand.Controls.Clear();
            //    rdbtnlst_Brand.Items.Clear();
            //    sample.startup(PlaceHolder1);
            //    for (int i = 0; i < ListBrand.Count; i++)
            //    {
            //        rdbtnlst_Brand.Items.Add(new ListItem(ListBrand[i]));
            //    }
            //    rdbtnlst_Brand.AutoPostBack = true;
            //}
            //else
            //{

            //    rdbtnlst_Brand.ClearSelection();
            //    rdbtnlst_Brand.Controls.Clear();
            //    rdbtnlst_Brand.Items.Clear();
            //    sample.startup(PlaceHolder1);
            //    for (int i = 0; i < ListBrand.Count; i++)
            //    {
            //        rdbtnlst_Brand.Items.Add(new ListItem(ListBrand[i]));
            //    }
            //    rdbtnlst_Brand.AutoPostBack = true;

            //}
            //rdbtnlst_Brand.AutoPostBack = true;
            //PlaceHolder1.Controls.Clear();
            #endregion postback
        }

        public  void BtnALL_Click(object sender, EventArgs e)
        {
            sample.SearchmultipleDisplay("a", PlaceHolder1, ListBrand);
            NumberFound.Text = "Items Found : " + Convert.ToString(sample.getCountALL());
            if (IsPostBack)
            {
                rdbtnlst_Brand.ClearSelection();
                rdbtnlst_Brand.Controls.Clear();
                rdbtnlst_Brand.Items.Clear();
                for (int i = 0; i < ListBrand.Count; i++)
                {
                    rdbtnlst_Brand.Items.Add(new ListItem(ListBrand[i]));
                }
                rdbtnlst_Brand.AutoPostBack = true;
            }
            ListBrand.Clear();
            TB_Search.Text = string.Empty;
            rdbtnlst_Brand.ClearSelection();
          
        }
        protected void rdbtnlst_Brand_SelectedIndexChanged(object sender, EventArgs e)
        {
            sample.brandmultipleDisplay(rdbtnlst_Brand.Text, PlaceHolder1 );

            NumberFound.Text = "Items Found : " + Convert.ToString(sample.getCount_Brand());
        }

      

        protected void TB_Search_TextChanged(object sender, EventArgs e)
        {
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            sample.SearchmultipleDisplay(TB_Search.Text, PlaceHolder1, ListBrand);
            if (IsPostBack)
            {
                rdbtnlst_Brand.ClearSelection();
                rdbtnlst_Brand.Controls.Clear();
                rdbtnlst_Brand.Items.Clear();
                for (int i = 0; i < ListBrand.Count; i++)
                {
                    rdbtnlst_Brand.Items.Add(new ListItem(ListBrand[i]));
                }
                rdbtnlst_Brand.AutoPostBack = true;
            }
            ListBrand.Clear();
            rdbtnlst_Brand.ClearSelection();
            NumberFound.Text = "Items Found : " + Convert.ToString(sample.getCount_Search());
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            sample.ProductSize_dropdownList_control(DropDownList1);
            #region postback
            sample.SearchmultipleDisplay("a", PlaceHolder1, ListBrand);
            NumberFound.Text = "Items Found : " + Convert.ToString(sample.getCountALL());
            if (IsPostBack)
            {
                rdbtnlst_Brand.ClearSelection();
                rdbtnlst_Brand.Controls.Clear();
                rdbtnlst_Brand.Items.Clear();
                for (int i = 0; i < ListBrand.Count; i++)
                {
                    rdbtnlst_Brand.Items.Add(new ListItem(ListBrand[i]));
                }
                rdbtnlst_Brand.AutoPostBack = true;
            }
            ListBrand.Clear();
            TB_Search.Text = string.Empty;
            rdbtnlst_Brand.ClearSelection();
      
            #endregion
        }
    }
}
