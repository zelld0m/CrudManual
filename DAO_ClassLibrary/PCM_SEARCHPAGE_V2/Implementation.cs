using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace PCM_SEARCHPAGE_V2
{
    public class Implementation
    {
        #region APPLICATION

        Controls_EDP con_EDP = new Controls_EDP();
        Controls_URLSite con_site = new Controls_URLSite();
        ControlDisplay con_dis = new ControlDisplay();

        #endregion


        List<String> listBrand = new List<string>();
        
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
            #region DisplayProducts

            con_site.Findproduct = search;
            con_EDP.getEDPfromSearchManager2(con_site.SearchManagerURL); //1st  Create an edp using the search textbox this will generate a url for specified search
            con_site.Alldetails_Use_EDP = con_EDP.EdpString;            //2nd  use the generated EdpString
            con_dis.getDetails2(con_site.Alldetails_Use_EDP);           //3rd  get allDetails and store it to the list
            con_dis.SelectedMultipleDisplay2(PlaceHolder1);             //4th  apply Display

            #endregion
            #region DisplayBrand

            radiobuttonlist.ClearSelection();
            radiobuttonlist.Controls.Clear();
            radiobuttonlist.Items.Clear();
            listBrand = con_dis.Manufacturer;
            listBrand = listBrand.Distinct().ToList();
            listBrand = listBrand.OrderBy(i => i).ToList();

            for (int i = 0; i < listBrand.Count; i++)
            {
                radiobuttonlist.Items.Add(new ListItem(listBrand[i]));
            }
            radiobuttonlist.AutoPostBack = true;
            #endregion

            #region RESET

            #endregion
            
        }

        public void dropdownList_NumViews(DropDownList drop)
        {
            int x = Convert.ToInt32(drop.SelectedValue);
            con_site. ProductLimitView= x;
        }


 
        public void nextPage(Label lbl_PageNumber, DropDownList drpdwnlst_View, Label lbl_Min, Label lbl_MAX)
        {
            ///----------------------------------------
            int pagenumber = Convert.ToInt32(lbl_PageNumber.Text) + 1;
            int min = Convert.ToInt32(drpdwnlst_View.SelectedValue) * pagenumber;
            int max = Convert.ToInt32(drpdwnlst_View.SelectedValue) + min;
            lbl_Min.Text = "" + min;
            lbl_MAX.Text = "" + max;
            con_site.Currentpage=(Convert.ToInt32(pagenumber));
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
                con_site.Currentpage = (Convert.ToInt32(pagenumber));

                lbl_PageNumber.Text = "" + pagenumber;
            }
        }

        public void refresh(PlaceHolder placeholder1)
        {
            con_dis.SelectedMultipleDisplay2(placeholder1);
        }
    }
}