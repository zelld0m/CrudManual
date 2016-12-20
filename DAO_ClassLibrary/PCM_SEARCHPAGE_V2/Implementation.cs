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
        Controls_URLSite con_site2 = new Controls_URLSite();

        #endregion
        List<String> listBrand = new List<string>();
        #region Functions
        public void radioButton_button(String findBrand, RadioButtonList radiobuttonlist, PlaceHolder PlaceHolder1)
        {
            // con_EDP.BrandSelected_Generate_EDP(findBrand);
            con_dis.SelectedMultipleDisplay2(PlaceHolder1);

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
        public void searchButton(string search, RadioButtonList radiobuttonlist, PlaceHolder PlaceHolder1, Label numfound, Label pageNumber, Label lbl_Min, Label lbl_MAX, DropDownList drop)   // useThis as Clear Filter
        {
            #region DisplayProducts

            con_site.Findproduct = search;
            con_EDP.getEDPfromSearchManager2(con_site.SearchManagerURL); //1st  Create an edp using the search textbox this will generate a url for specified search
            con_site.Alldetails_Use_EDP = con_EDP.EdpString;            //2nd  use the generated EdpString
            con_dis.getDetails2(con_site.Alldetails_Use_EDP);           //3rd  get allDetails and store it to the list
            con_dis.SelectedMultipleDisplay2(PlaceHolder1);             //4th  apply Display
            numfound.Text = con_EDP.NumfoundFromSearch.ToString();
            #endregion
            #region DisplayBrand

            radiobuttonlist.ClearSelection();
            radiobuttonlist.Controls.Clear();
            radiobuttonlist.Items.Clear();
            listBrand = con_dis.Manufacturer;
            listBrand = listBrand.Distinct().ToList();
            listBrand = listBrand.OrderBy(i => i).ToList();             // MAKE brand alphabetical

            for (int i = 0; i < listBrand.Count; i++)
            {
                radiobuttonlist.Items.Add(new ListItem(listBrand[i]));
            }
            radiobuttonlist.AutoPostBack = true;
            #endregion
            #region RESET

            int min = 0; // numbering  start 
            int max = 10;      // numbering to end 
            lbl_Min.Text = "" + min;
            lbl_MAX.Text = "" + max;
            numfound.Text = con_EDP.NumfoundFromSearch.ToString();
            con_site.StartRead = 0;
            con_site.ProductLimitView = 10;
            drop.Text = con_site.ProductLimitView.ToString();
            pageNumber.Text = "" + 0;
            #endregion
        }
        public void dropdownList_NumViews(DropDownList drop)  // Perfect
        {
            con_site.ProductLimitView = Convert.ToInt32(drop.SelectedValue);           // increase view

        }
        public void nextPage(Label lbl_PageNumber, DropDownList drpdwnlst_View, Label lbl_Min, Label lbl_MAX)
        {
            ///----------------------------------------
            int pagenumber = Convert.ToInt32(lbl_PageNumber.Text) + 1;   // getting old page # 
            int min = Convert.ToInt32(drpdwnlst_View.SelectedValue) * pagenumber;   // numbering  start 
            int max = Convert.ToInt32(drpdwnlst_View.SelectedValue) + min;          // numbering to end 
            lbl_Min.Text = "" + min;
            lbl_MAX.Text = "" + max;
            con_site.StartRead = (Convert.ToInt32(pagenumber) * Convert.ToInt32(drpdwnlst_View.SelectedValue));
            lbl_PageNumber.Text = "" + pagenumber;
        }
        public void previousPage(Label lbl_PageNumber, DropDownList drpdwnlst_View, Label lbl_Min, Label lbl_MAX)
        {


            int pagenumber = Convert.ToInt32(lbl_PageNumber.Text) - 1;   // getting old page # 
            int min = Convert.ToInt32(drpdwnlst_View.SelectedValue) * pagenumber;   // numbering  start 
            int max = Convert.ToInt32(drpdwnlst_View.SelectedValue) + min;          // numbering to end 
            lbl_Min.Text = "" + min;
            lbl_MAX.Text = "" + max;
            con_site.StartRead = (Convert.ToInt32(pagenumber) * Convert.ToInt32(drpdwnlst_View.SelectedValue));
            lbl_PageNumber.Text = "" + pagenumber;

        }
        public void refresh(PlaceHolder placeholder1, RadioButtonList radiobuttonlist, TextBox currentTextboxSearch)
        {
            #region Display
            con_site.Findproduct = currentTextboxSearch.Text;  // TEST 
            con_EDP.getEDPfromSearchManager2(con_site.SearchManagerURL); //1st  Create an edp using the search textbox this will generate a url for specified search
            con_site.Alldetails_Use_EDP = con_EDP.EdpString;
            con_dis.getDetails2(con_site.Alldetails_Use_EDP);
            con_dis.SelectedMultipleDisplay2(placeholder1);

            #endregion
            #region DisplayBrand

            radiobuttonlist.ClearSelection();
            radiobuttonlist.Controls.Clear();
            radiobuttonlist.Items.Clear();
            listBrand = con_dis.Manufacturer;
            listBrand = listBrand.Distinct().ToList();
            listBrand = listBrand.OrderBy(i => i).ToList();             // MAKE brand alphabetical

            for (int i = 0; i < listBrand.Count; i++)
            {
                radiobuttonlist.Items.Add(new ListItem(listBrand[i]));
            }
            radiobuttonlist.AutoPostBack = true;
            #endregion
        }

        #endregion
     }
}