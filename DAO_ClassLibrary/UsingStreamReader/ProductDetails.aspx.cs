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
        static List<string> EDP_filteredByBrand_2nd = new List<string>();
        static List<String> ListBrand = new List<string>();
        protected void Page_Load(object sender, EventArgs e)
        {           
            sample.SaveALLEDP();
            //if (IsPostBack)
            //{
            //    rdbtnlst_Brand.ClearSelection();
            //    rdbtnlst_Brand.Controls.Clear();
            //}
            #region postback FOR BRAND SELECTION
            //if (!IsPostBack)  // 1st LOAD
            //{   
            //   // rdbtnlst_Brand.ClearSelection();
            //   // rdbtnlst_Brand.Controls.Clear();
            //   // rdbtnlst_Brand.Items.Clear();
            //   // for (int i = 0; i < ListBrand.Count; i++)
            //   // {
            //   //     rdbtnlst_Brand.Items.Add(new ListItem(ListBrand[i]));
            //   // }
            //   // rdbtnlst_Brand.AutoPostBack = true; 
            //}
            rdbtnlst_Brand.AutoPostBack = true;
            PlaceHolder1.Controls.Clear();
            #endregion postback
        }
      
        public  void BtnALL_Click(object sender, EventArgs e)
        {
            sample.Display_All_Products( PlaceHolder1);
        }
        protected void rdbtnlst_Brand_SelectedIndexChanged(object sender, EventArgs e)
        {
            sample.brandmultipleDisplay(rdbtnlst_Brand.Text, PlaceHolder1 );
           // ListBrand = sample.getBrandSearched();
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
                // ListBrand = sample.getBrandSearched();
                rdbtnlst_Brand.Items.Clear();
                for (int i = 0; i < ListBrand.Count; i++)
                {
                    rdbtnlst_Brand.Items.Add(new ListItem(ListBrand[i]));
                }
                rdbtnlst_Brand.AutoPostBack = true;
            }
            ListBrand.Clear();
        }
    }
}
