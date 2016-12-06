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
        // Rows Changable value        

        string url = "http://afs-sl-schmgr03.afservice.org:8080/searchManager/search/afs-sl-schmstr.afservice.org:8080/solr4/Products/select?q=laptop&fl=EDP&store=pcmall&rows=20&start=0&facet=true&facet.field=Manufacturer&facet.field=InStock&facet.limit=10";

        protected void Page_Load(object sender, EventArgs e)
        {
            rdbtnlst_Brand.DataSource = sample.AllBrand(20);
            rdbtnlst_Brand.DataBind();
            if (!IsPostBack)
            {
                rdbtnlst_Brand.AutoPostBack = true;
            }

        }
        
        #region CREATION
        // <---- textboxCreation --- > --------------------------------------------------------------------------------------------
        protected int NumberOfControls
        {
            get { return Convert.ToInt32(Session["noCon"]); }
            set { Session["noCon"] = value.ToString(); }
        }
        private void Page_Init(object sender, System.EventArgs e)
        {
            if (!Page.IsPostBack)
                //Initiate the counter of dynamically added controls
                this.NumberOfControls = 0;
                //      else
                //Controls must be repeatedly be created on postback
                // this.createControls();
        }
        protected void brandmultipleDisplay(String brandName)
        {
            List<int> x = sample.SaveALLEDP(url);
            List<int> filtered = new List<int>(300);
            // Scanning 
            for (int i = 0; i < x.Count; i++)
            {
                sample.Get_EDP_FromBrand(brandName, x[i], filtered);
                //  Response.Write(filtered[i]);
            }
            for (int i = 0; i < filtered.Count; i++)
            {
                BrandSelectedMultipleDisplay(filtered);
            }
        }
        public static void LabelCssClass(Control root)          // CSS 
        {
            foreach (Control control in root.Controls)
            {
                if (control is Label)
                {
                    var label = control as Label;
                    label.CssClass = "control-label";
                }
                else
                {
                    LabelCssClass(control);
                }
            }
        }
        public static void ButtonCssClass(Control root)         // CSS 
        {
            foreach (Control control in root.Controls)
            {
                if (control is Button)
                {
                    var Button = control as Button;
                    Button.CssClass = "btn btn-info";
                }
                else
                {
                    ButtonCssClass(control);
                }
            }
        }
        // Success MULTIPLE DISPLAY OF PRODUCT 
        private void MuiltipleDisplayAllProducts()
        {
            Label spacer = new Label();
            spacer.ID = "space";
            spacer.Text = "</br>";
            // save is an arraylist that contains EDP #

            List<int> SAVE;
            int howmanyProducts = 100;
            SAVE = sample.SaveALLEDP("http://afs-sl-schmgr03.afservice.org:8080/searchManager/search/afs-sl-schmstr.afservice.org:8080/solr4/Products/select?q=laptop&fl=EDP&store=pcmall&rows=" + howmanyProducts + "&start=0&facet=true&facet.field=Manufacturer&facet.field=InStock&facet.limit=0");

            for (int i = 0; i < SAVE.Count; i++)
            {
                //TextBox tbi = new TextBox();
                //tbi.ID = "txtData" + i;

                NumberOfControls++;
                //PlaceHolder1.Controls.Add(tbi);
                //<  ADDED
                Label label_ProductName = new Label();
                label_ProductName.ID = "label_ProductName" + i;
                Label label_Store = new Label();
                label_Store.ID = "label_Store" + i;
                Label label_Description = new Label();
                label_Description.ID = "label_Description" + i;
                Label label_Price = new Label();
                label_Price.ID = "label_Price" + i;

                Image Image_url = new Image();
                Image_url.ID = "Image_ID" + i;
                Label label_Manufacturer = new Label();
                label_Manufacturer.ID = "label_Manufacturer" + i;
                Label label_Availability = new Label();
                label_Availability.ID = "label_Availability" + i;
                sample.showDetails(Convert.ToString(SAVE[i]), label_Store, label_ProductName, label_Description, label_Price, Image_url, label_Manufacturer, label_Availability);

                PlaceHolder ph = new PlaceHolder();
                ph.ID = "placeholderx" + i.ToString();
                //tbi.Text = ":" + i.ToString();
                //ph.Controls.Add(tbi);
                Image_url.Height = 500;
                Image_url.Width = 500;
                Image_url.CssClass = "img-responsive ";
                Image_url.AlternateText = "No Image";

                ph.Controls.Add(Image_url);
                ph.Controls.Add(new LiteralControl("</br>"));
                ph.Controls.Add(new LiteralControl("Price: "));
                ph.Controls.Add(label_Price);
                ph.Controls.Add(new LiteralControl("</br>"));
                ph.Controls.Add(new LiteralControl("Name: "));
                ph.Controls.Add(label_ProductName);
                ph.Controls.Add(new LiteralControl("</br>"));
                ph.Controls.Add(new LiteralControl("</br>"));
                ph.Controls.Add(new LiteralControl("Store: "));
                ph.Controls.Add(label_Store);
                ph.Controls.Add(new LiteralControl("</br>"));
                ph.Controls.Add(new LiteralControl("</br>"));
                ph.Controls.Add(new LiteralControl("Description: "));
                ph.Controls.Add(label_Description);
                ph.Controls.Add(new LiteralControl("</br>"));
                ph.Controls.Add(new LiteralControl("</br>"));
                ph.Controls.Add(new LiteralControl("Manufacturer: "));
                ph.Controls.Add(label_Manufacturer);
                ph.Controls.Add(new LiteralControl("</br>"));
                ph.Controls.Add(new LiteralControl("Availability: "));
                ph.Controls.Add(label_Availability);
                ph.Controls.Add(new LiteralControl("</br>"));

                PlaceHolder1.Controls.Add(ph);

                //<  ADDED
            }
        }
        // <---- textboxCreation --- > -----------2-----------------------------------------
        private void BrandSelectedMultipleDisplay(List<int> EDP)
        {
            // save is an arraylist that contains EDP #
            for (int i = 0; i < EDP.Count; i++)
            {
                
                NumberOfControls++;
                Label label_ProductName = new Label();
                label_ProductName.ID = "label_ProductName" + i;
                Label label_Store = new Label();
                label_Store.ID = "label_Store" + i;
                Label label_Description = new Label();
                label_Description.ID = "label_Description" + i;
                Label label_Price = new Label();
                label_Price.ID = "label_Price" + i;
                Image Image_url = new Image();
                Image_url.ID = "Image_ID" + i;
                Label label_Manufacturer = new Label();
                label_Manufacturer.ID = "label_Manufacturer" + i;
                Label label_Availability = new Label();
                label_Availability.ID = "label_Availability" + i;
                sample.showDetails(Convert.ToString(EDP[i]), label_Store, label_ProductName, label_Description, label_Price, Image_url, label_Manufacturer, label_Availability);
                PlaceHolder ph = new PlaceHolder();
                ph.ID = "placeholderx" + i.ToString();
                //tbi.Text = ":" + i.ToString();
                //ph.Controls.Add(tbi);
                Image_url.Height = 500;
                Image_url.Width = 500;
                Image_url.CssClass = "img-responsive ";
                Image_url.AlternateText = "No Image";
                //<----------  IMPLEMENT ----------->
                ph.Controls.Add(Image_url);
                ph.Controls.Add(new LiteralControl("</br>"));
                ph.Controls.Add(new LiteralControl("Price: "));
                ph.Controls.Add(label_Price);
                ph.Controls.Add(new LiteralControl("</br>"));
                ph.Controls.Add(new LiteralControl("Name: "));
                ph.Controls.Add(label_ProductName);
                ph.Controls.Add(new LiteralControl("</br>"));
                ph.Controls.Add(new LiteralControl("</br>"));
                ph.Controls.Add(new LiteralControl("Store: "));
                ph.Controls.Add(label_Store);
                ph.Controls.Add(new LiteralControl("</br>"));
                ph.Controls.Add(new LiteralControl("</br>"));
                ph.Controls.Add(new LiteralControl("Description: "));
                ph.Controls.Add(label_Description);
                ph.Controls.Add(new LiteralControl("</br>"));
                ph.Controls.Add(new LiteralControl("</br>"));
                ph.Controls.Add(new LiteralControl("Manufacturer: "));
                ph.Controls.Add(label_Manufacturer);
                ph.Controls.Add(new LiteralControl("</br>"));
                ph.Controls.Add(new LiteralControl("Availability: "));
                ph.Controls.Add(label_Availability);
                ph.Controls.Add(new LiteralControl("</br>"));

                PlaceHolder1.Controls.Add(ph);

                //<  ADDED
            }
        }
        // <---- textboxCreation --- > ----------------------------------------------------------------------------------

        #endregion CREATION
        #region Buttons

        protected void btnCreate_Click(object sender, EventArgs e)          // Create's Textbox  // Inside a placeholder-object
        {
            brandmultipleDisplay(btnCreate.Text);
            //MuiltipleDisplay();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            brandmultipleDisplay(Btn_Lenovo.Text);
        }

        protected void BtnALL_Click(object sender, EventArgs e)
        {
            radioButtonBrandCreation(10);
           // MuiltipleDisplayAllProducts();
        }

        protected void Btn_Quatech_Click(object sender, EventArgs e)
        {
            brandmultipleDisplay(Btn_Quatech.Text);
        }
        #endregion buttons

        protected void rdbtnlst_Brand_SelectedIndexChanged(object sender, EventArgs e)
        {
           // string RadioText = ;
         //   brandmultipleDisplay(rdbtnlst_Brand.Text);
            radioButtonBrandCreation(10);
        }

        public  void radioButtonBrandCreation(int howManyBrand)
        {
            List<String> brandNames = sample.AllBrand(howManyBrand);

            for (int i = 0; i < brandNames.Count; i++)
            {
                NumberOfControls++;
                RadioButton rd = new RadioButton();
                rd.ID = rd + i.ToString();
                rd.Text = brandNames[i];
                PlaceHolder2.Controls.Add(rd);
            }
        }
    }
}
