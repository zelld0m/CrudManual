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
        static List<int> ALLEDP = new List<int>();
        static List<String> ListBrand = new List<string>();
        protected void Page_Load(object sender, EventArgs e)
        {

           sample.SaveALLEDP();
            ListBrand = sample.AllBrand();
            #region postback FOR BRAND SELECTION
            if (!IsPostBack)
            {
               // PlaceHolder1.Controls.Clear();
                rdbtnlst_Brand.ClearSelection();
                rdbtnlst_Brand.Controls.Clear();
                for (int i = 0; i < ListBrand.Count; i++)
                {
                    rdbtnlst_Brand.Items.Add(new ListItem(ListBrand[i]));
                }
                rdbtnlst_Brand.AutoPostBack = true;
            }
            #endregion postback
        }
      
        public  void BtnALL_Click(object sender, EventArgs e)
        {
            sample.MultipleDisplay_All_Products( PlaceHolder1);
        }
        protected void rdbtnlst_Brand_SelectedIndexChanged(object sender, EventArgs e)
        {
            PlaceHolder1.Controls.Clear();
            
            String selectedBrand = rdbtnlst_Brand.Text;
            sample.brandmultipleDisplay(selectedBrand, PlaceHolder1);
        }
    }
}
