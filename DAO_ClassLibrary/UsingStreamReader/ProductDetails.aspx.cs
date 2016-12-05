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
        protected void Page_Load(object sender, EventArgs e)
        {
            #region TestMultiplier
          //  TextBox[] textBoxes = new TextBox[5];
          //  Label [] labels = new Label[5];

          //for (int i = 0; i < 5; i++)
          //{
          //  textBoxes[i] = new TextBox();
          //  // Here you can modify the value of the textbox which is at textBoxes[i]

          //  labels[i] = new Label();
          //  // Here you can modify the value of the label which is at labels[i]
          //}

          //// This adds the controls to the form (you will need to specify thier co-ordinates etc. first)
          //for (int i = 0; i < 5; i++)
          //{
          //  this.Controls.Add(textBoxes[i]);
          //  this.Controls.Add(labels[i]);
          //}

          //  int x = 4;
          //  int y = 4;
          //for(int i =0;i<x;i++)
          //  {
          //      x = 4;
          //      y = this.Controls.Count * 30;
          //      RadioButton rb = new RadioButton();
          //      rb.CheckedChanged += new System.EventHandler(rbPhysician_CheckedChanged);
          //      rb.Text = pd.name;
          //      rb.Visible = true;
          //      rb = NewMethod(x, y, rb);
          //      rb.Height = 40;
          //      rb.Width = 200;
          //      rb.BackColor = SystemColors.Control;
          //      rb.ForeColor = Color.Black;
          //      rb.Font = new Font("Microsoft Sans Serif", 10);
          //      rb.Show();
          //      rb.Name = "rb" + this.Controls.Count;
          //      panPhysicians.Controls.Add(rb);
          //  }

          //  StreamReader menu = new StreamReader("menu.prefs");
          //  int repetition = 0;

          //  while (!menu.EndOfStream)
          //  {
          //      Button dynamicbutton = new Button();
          //      dynamicbutton.Click += new System.EventHandler(menuItem_Click);
          //      dynamicbutton.Text = menu.ReadLine();
          //      dynamicbutton.Visible = true;
          //      dynamicbutton.Location = new Point(4 + repetition * 307, 4);
          //      dynamicbutton.Height = 44;
          //      dynamicbutton.Width = 203;
          //      dynamicbutton.BackColor = Color.FromArgb(40, 40, 40);
          //      dynamicbutton.ForeColor = Color.White;
          //      dynamicbutton.Font = new Font("Lucida Console", 16);
          //      dynamicbutton.Show();
          //      menuPanel.Controls.Add(dynamicbutton);
          //      repetition++;
          //      MessageBox.Show(dynamicbutton.Location.ToString());
          //  }
            #endregion TestMultiplier

            #region
            //XmlReader xmlReader = XmlReader.Create("http://afs-sl-schmgr03.afservice.org:8080/searchManager/search/afs-sl-schmstr.afservice.org:8080/solr4/Products/select?q=laptop&fl=EDP&store=pcmall&rows=25&start=0&facet=true&facet.field=Manufacturer&facet.field=InStock&facet.limit=10");
            //while (xmlReader.Read())
            //{
            //    if ((xmlReader.NodeType == XmlNodeType.Element) && (xmlReader.Name == "response"))
            //    {
            //        if (xmlReader.HasAttributes)
            //        {
            //            //Response.Write(xmlReader.GetAttribute("currency") + ": " + xmlReader.GetAttribute("rate"));
            //            string valuetext = xmlReader.ReadElementString("int");
            //            Response.Write("Value:" + valuetext);
            //            Response.Write("</br>");
            //        }
            //    }
            //}

            /* //------------------------------------------------------------------------------------------ NOT WORKING READER
             XmlTextReader reader = new XmlTextReader("http://afs-sl-schmgr03.afservice.org:8080/searchManager/search/afs-sl-schmstr.afservice.org:8080/solr4/Products/select?q=laptop&fl=EDP&store=pcmall&rows=25&start=0&facet=true&facet.field=Manufacturer&facet.field=InStock&facet.limit=10");
             reader.WhitespaceHandling = WhitespaceHandling.Significant;
             reader.ReadStartElement("response");
             reader.Read(); // read next element
             reader.Read(); // read next element
             while (reader.LocalName == "result")
             {
                 String  value;
                 reader.ReadStartElement("result");
                 value = reader.ReadElementString("doc");
                 Response.Write("Value: " + value);
                 Response.Write("</br>");
                 reader.ReadEndElement();
                 reader.Read();
             } */
            #endregion
            //string EDP = "10290644";
            //                                                                                                                                                                     // Rows Changable value        
            //string url = "http://afs-sl-schmgr03.afservice.org:8080/searchManager/search/afs-sl-schmstr.afservice.org:8080/solr4/Products/select?q=laptop&fl=EDP&store=pcmall&rows=3&start=0&facet=true&facet.field=Manufacturer&facet.field=InStock&facet.limit=10";
            //List<int> x=  sample.SaveALLEDP(url);
            //for(int i =0; i < x.Count; i++)
            //{
            //     EDP = Convert.ToString(x[i]);
            //     productDetails.showDetails(EDP, lbl_Store, lbl_Name, lbl_Description, lbl_Price, Image, lbl_Manufacturer, lbl_Availability);
           
            //}
        }
        //   //  _rptrEDP.DataSource = saveEDP;
        //  _rptrEDP.DataBind();




        // use EDP as reference for the details

        //EDP = "8634979";
        //EDP = Convert.ToInt32(Request.QueryString["id"]);

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


        protected void btnCreate_Click(object sender, EventArgs e)          // Create's Textbox  // Inside a placeholder-object
        {
            MuiltipleDisplay();
        }
        //protected void btnRead_Click(object sender, EventArgs e)// 
        //{
        //    int count = this.NumberOfControls;

        //    for (int i = 0; i < count; i++)
        //    {
        //        TextBox tx = (TextBox)PlaceHolder1.FindControl("txtData" + i.ToString());  // finds  VALUE LABEL 
        //        //Add the Controls to the container of your choice
        //        Label1.Text += tx.Text + ",";  //  implement add value to label
        //    }
        //}

        #region Write again
        //private void createControls()   // <====================== you just created new  object But NO VALUE ======================> 
        //{
        //    int count = this.NumberOfControls;
        //    for (int i = 0; i < count; i++)
        //    {
        //        TextBox tx = new TextBox();
        //        tx.ID = "txtData" + i.ToString();
        //        Add the Controls to the container of your choice
        //        PlaceHolder1.Controls.Add(tx);  //   <-- Created textbox and inserted in the placeholder ---> 
        //         < -------ADDED-------- >
        //        Label lb = new Label();
        //        lb.ID = "id." + i.ToString();
        //        PlaceHolder1.Controls.Add(lb);
        //         < ------ADDED END----->
        //    }
        //}
        #endregion WriteAgain
        public static void LabelCssClass(Control root)
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

        // Success MULTIPLE DISPLAY OF PRODUCT 
        private void MuiltipleDisplay()
        {
            Label spacer = new Label();
            spacer.ID = "space";
            spacer.Text = "</br>" ;
            // save is an arraylist that contains EDP #
       
            List<int> SAVE;
            int howmanyProducts = 10;
            SAVE = sample.SaveALLEDP("http://afs-sl-schmgr03.afservice.org:8080/searchManager/search/afs-sl-schmstr.afservice.org:8080/solr4/Products/select?q=laptop&fl=EDP&store=pcmall&rows="+ howmanyProducts+"&start=0&facet=true&facet.field=Manufacturer&facet.field=InStock&facet.limit=0");

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
                sample.showDetails(Convert.ToString( SAVE[i]), label_Store, label_ProductName, label_Description, label_Price, Image_url, label_Manufacturer, label_Availability);

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
                PlaceHolder1.Controls.Add(spacer);
                //<  ADDED
            }
        }
        // <---- textboxCreation --- > ----------------------------------------------------------------------------------

        #endregion CREATION


        #region OLD CODE FOR TEST

        //List<String> productDetailsList = new List<string>(10000);

        //String url = ("http://afs-sl-pservice01.afservice.org:8080/productservice2/getProductInfo/pcmall?edplist=10290644&ignoreCatalog=true"); //  + 6926988/*EDP*/ +
        //System.Xml.XmlTextReader reader = new XmlTextReader(url);
        //// reader.WhitespaceHandling = WhitespaceHandling.Significant;
        //while (reader.Read())
        //{
        //    if ( reader.Name == "status"  )
        //    {

        //        //while (reader.HasAttributes)
        //        //{
        //        //if(reader.GetAttribute(""))
        //        //if(reader.GetAttribute("productDetails")=="manufacturer")
        //        productDetailsList.Add(reader.Name + " " + reader.ReadElementString("status")  + "</br>");// show all EDP     

        //    }
        //    if (reader.Name == "store")
        //    {
        //        productDetailsList.Add(reader.ReadElementString("store") + "</br>");// show all EDP     
        //    }
        //    //============================
        //    if (reader.Name == "name")
        //    {
        //        productDetailsList.Add(reader.ReadElementString("name") + "</br>");// show all EDP     
        //    }
        //    if (reader.Name == "description")
        //    {
        //        productDetailsList.Add(reader.ReadElementString("description")+ "</br>");// show all EDP     
        //    }
        //    if (reader.Name == "finalPrice")
        //    {
        //       productDetailsList.Add(reader.ReadElementString("finalPrice") + "</br>");// show all EDP     
        //    }
        //    if (reader.Name == "xlg")  // IMAGE  & SIZE 
        //    {
        //        productDetailsList.Add(reader.ReadElementString("xlg") + "</br>");// show all EDP     
        //    }
        //    if (reader.Name == "manufacturer")
        //    {
        //        productDetailsList.Add(reader.ReadElementString("manufacturer") + "</br>");// show all EDP     
        //    }
        //    //reader.Name == "productDetails" ||reader.Name == "manufacturer"
        //}
        //Label1.Text = String.Join("", productDetailsList);
        #endregion OLD CODE FOR TEST
    }
}
