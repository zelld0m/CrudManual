using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace PCM_SEARCHPAGE_V2
{
    public class Implementation
    {
        Controls_EDP con_EDP = new Controls_EDP();
        Controls_URL_Properties con_URL_prop = new Controls_URL_Properties();
        ControlDisplay con_dis = new ControlDisplay();
        static List<String> listBrand = new List<string>();

        public void radioButton_button(String findBrand, RadioButtonList radiobuttonlist, PlaceHolder PlaceHolder1)
        {
            con_EDP.BrandSelected_Generate_EDP(findBrand);
            con_dis.SelectedMultipleDisplay(con_EDP.BrandFiltered_EDP , PlaceHolder1);

            radiobuttonlist.ClearSelection();
            radiobuttonlist.Controls.Clear();
            radiobuttonlist.Items.Clear();
            listBrand = con_EDP.TempoBrand;
            for (int i = 0; i < listBrand.Count; i++)
            {
                radiobuttonlist.Items.Add(new ListItem(listBrand[i]));
            }
            radiobuttonlist.AutoPostBack = true;
        }

        public void searchButton(string search , RadioButtonList radiobuttonlist,PlaceHolder PlaceHolder1 )   // useThis as Clear Filter
        {

            con_URL_prop.Findproduct =search;  // Success
            con_URL_prop.Currentpage = 0;
            con_URL_prop.ProductLimitView = 10;
            con_URL_prop.BrandLimit = 0;
            con_EDP.All_edp = con_EDP.getEDPfromSearchManager();
                con_dis.SelectedMultipleDisplay(con_EDP.All_edp, PlaceHolder1);
                radiobuttonlist.ClearSelection();
                radiobuttonlist.Controls.Clear();
                radiobuttonlist.Items.Clear();
                listBrand = con_EDP.BrandList;
                for (int i = 0; i<listBrand.Count; i++)
                {
                    radiobuttonlist.Items.Add(new ListItem(listBrand[i]));
                }
                radiobuttonlist.AutoPostBack = true;
        }

        public void dropdownList_NumViews(DropDownList drop)
        {
            int x = Convert.ToInt32(drop.SelectedValue);
            con_URL_prop. ProductLimitView= x;
        }


 
        public void nextPage(Label lbl_PageNumber, DropDownList drpdwnlst_View, Label lbl_Min, Label lbl_MAX)
        {
            ///----------------------------------------


            int pagenumber = Convert.ToInt32(lbl_PageNumber.Text) + 1;

            int min = Convert.ToInt32(drpdwnlst_View.SelectedValue) * pagenumber;
            int max = Convert.ToInt32(drpdwnlst_View.SelectedValue) + min;
            lbl_Min.Text = "" + min;
            lbl_MAX.Text = "" + max;
            con_URL_prop.Currentpage=(Convert.ToInt32(pagenumber));
            lbl_PageNumber.Text = "" + pagenumber;

        }
        public void previousPage(Label lbl_PageNumber, DropDownList drpdwnlst_View, Label lbl_Min, Label lbl_MAX)
        {
            ///----------------------------------------
            int pagenumber = Convert.ToInt32(lbl_PageNumber.Text);
            if (pagenumber > 0)
            {
                pagenumber = Convert.ToInt32(lbl_PageNumber.Text) - 1;
                int min = Convert.ToInt32(drpdwnlst_View.SelectedValue) * pagenumber;
                int max = Convert.ToInt32(drpdwnlst_View.SelectedValue) + min;
                lbl_Min.Text = "" + min;
                lbl_MAX.Text = "" + max;
                con_URL_prop.Currentpage = (Convert.ToInt32(pagenumber));

                lbl_PageNumber.Text = "" + pagenumber;
            }
        }


    }
}