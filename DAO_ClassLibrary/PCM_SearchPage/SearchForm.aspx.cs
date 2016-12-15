using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PCM_SearchPage
{
    public partial class SearchForm : System.Web.UI.Page
    {
        Implementation imp = new Implementation();
        //static int foundProduct = 0;
        static string previewsSearch = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            lnkbtn_ClearFilter.Visible = false;
        }

        protected void lnbtn_Search_Click(object sender, EventArgs e)
        {
            previewsSearch = txt_Search.Text;
            if (IsPostBack)
            {
                imp.searchButton(txt_Search.Text, rdbtnlst_Brand, PlaceHolder1);
                  lbl_NumFound.Text =  ""+ imp.getNumfound();
                lbl_KeyWordSearch.Text = txt_Search.Text;
            }
        }

        protected void lnkbtn_ClearFilter_Click(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                rdbtnlst_Brand.ClearSelection();
                refresh();
                rdbtnlst_Brand.ClearSelection();
                lnkbtn_ClearFilter.Visible = false;
            }
        }

        protected void rdbtnlst_Brand_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                imp.radioButton_button(rdbtnlst_Brand.Text, rdbtnlst_Brand, PlaceHolder1);
                lnkbtn_ClearFilter.Visible = true;
            }
        }

        protected void drpdwnlst_View_SelectedIndexChanged(object sender, EventArgs e)
        {
            imp.dropdownList_NumViews(drpdwnlst_View);
            refresh();
        }

        protected void btn_PageNext_Click(object sender, EventArgs e)
        {
            int pagenumber = Convert.ToInt32(tb_PageNumber.Text);
            if (IsPostBack)
            {
                pagenumber = Convert.ToInt32(tb_PageNumber.Text)  + 1;
                imp.PagingControl(Convert.ToInt32(pagenumber));
                refresh();
                tb_PageNumber.Text = "" + pagenumber;
            }
           
        }

        protected void Btn_PagePrevious_Click(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                int pagenumber = Convert.ToInt32(tb_PageNumber.Text);

                if (pagenumber>0)
                {
                    pagenumber = Convert.ToInt32(tb_PageNumber.Text) -1;
                    imp.PagingControl(Convert.ToInt32(pagenumber));
                    refresh();
                    tb_PageNumber.Text = "" + pagenumber;
                }
             
            }
        }
        protected void refresh()
        {
            if (IsPostBack)
            {
                imp.searchButton(previewsSearch, rdbtnlst_Brand, PlaceHolder1);
                lbl_NumFound.Text = "" + imp.getNumfound();
                lbl_KeyWordSearch.Text = txt_Search.Text;
            }
        }
    }
}