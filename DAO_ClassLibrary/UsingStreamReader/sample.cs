using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace UsingStreamReader
{

    public class sample
    {

        static int howmanyProducts = 2 ;
        static int numberofBrand = 500;
        static List<int> ALL_EDP = new List<int>(howmanyProducts);
        static List<string> BrandList = new List<string>(numberofBrand);
        static List<int> Filtered_EDP_Brand = new List<int>(howmanyProducts);

        static String url = ("http://afs-sl-schmgr03.afservice.org:8080/searchManager/search/afs-sl-schmstr.afservice.org:8080/solr4/Products/select?q=laptop&fl=EDP&store=pcmall&rows=" + howmanyProducts + "&start=0&facet=true&facet.field=Manufacturer&facet.field=InStock&facet.limit=0");

    

        #region IMPORTANT WORKING

        //Speedup Version 2
        public static void SaveALLEDP()     // Getting All EDP  // Version 3
        {
            ALL_EDP.Clear();
            // List<int> saveEDP = new List<int>(10000);
            System.Xml.XmlTextReader reader = new XmlTextReader(url);
            reader.ReadToFollowing("result");
            reader.ReadToFollowing("int");
            while (reader.GetAttribute("name") == "EDP")
            {
                ALL_EDP.Add(Convert.ToInt32(reader.ReadElementString("int")));
               
                reader.ReadToFollowing("int");
            }
            
        }
        public static List<String> AllBrand()  // GET ALL BRAND   Use This to show all brand  
        {
            List<String> ListBrand = new List<String>(100); ;
            System.Xml.XmlTextReader reader = new XmlTextReader("http://afs-sl-schmgr03.afservice.org:8080/searchManager/search/afs-sl-schmstr.afservice.org:8080/solr4/Products/select?q=laptop&fl=EDP&store=pcmall&rows=1&start=0&facet=true&facet.field=Manufacturer&facet.field=InStock&facet.limit=" + numberofBrand);
            reader.ReadToFollowing("lst");
            reader.ReadToFollowing("lst");
            reader.ReadToFollowing("lst");
            reader.ReadToFollowing("lst");
            reader.ReadToFollowing("lst");
            while (reader.Read())
            {
                if ((reader.GetAttribute("name") == "Manufacturer"))
                {
                    while (reader.ReadToFollowing("int") && (reader.GetAttribute("name") != "true") && (reader.GetAttribute("name") != "false"))
                    {
                        ListBrand.Add(Convert.ToString(reader.GetAttribute("name")));// show all EDP
                    }
                }
            }
            return ListBrand;
        }

        // Working Getting ALL Details of ALL Products
        #region ProductDetailsGOOD 
        public static void showDetails(String inputEdp, Label label_store, Label label_productName, Label label_productdescription,  
            Label label_Price, Image imageSourceUrl, Label label_Manufacturer, Label label_availabilityDescription) // VERSION 3
        { // 6 label , 2 string 
            String inputurl = ("http://afs-sl-pservice01.afservice.org:8080/productservice2/getProductInfo/pcmall?edplist=" + inputEdp + "&ignoreCatalog=true"); //  + 6926988/*EDP*/ +
            System.Xml.XmlTextReader reader = new XmlTextReader(inputurl);
            while (reader.Read())
            {
                reader.ReadToFollowing("productDetails");
                ///<--------------------------------------------------------------MAKE THIS FASTER------------------------------------------------------------------------------->//
                 while (reader.ReadToFollowing("manufacturer"))
                 {
                    label_Manufacturer.Text = reader.ReadElementString("manufacturer");
                    reader.ReadToFollowing("storeSpecific");
                    reader.ReadToFollowing("store");
                    label_store.Text = reader.ReadElementString("store");// show Store   
                    label_productName.Text = reader.ReadElementString("name");  // Show ProductName
                    label_productdescription.Text = reader.ReadElementString("description");
                    while (reader.ReadToFollowing("finalPrice"))
                    {
                        label_Price.Text = reader.ReadElementString("finalPrice");break;
                    }
                    //reader.ReadToFollowing("availability");
                    reader.ReadToFollowing("availabilityDescription");
                    if (reader.Name =="availabilityDescription") //
                    {
                        label_availabilityDescription.Text = reader.ReadElementString("availabilityDescription");break;
                    }
                    reader.ReadToFollowing("image");
                    reader.ReadToFollowing("xlg");
                    
                    if (reader.Name == "xlg") //
                    {
                        imageSourceUrl.ImageUrl = reader.ReadElementString("xlg"); break;

                    }
                        
                    
                }
            }

            reader.Dispose();
        }
        #endregion ProductDetailsGOOD


        #endregion end importantWORKING


        #region DIPLAY   // PERFECT 
        public static void MultipleDisplay_All_Products(PlaceHolder PlaceHolder1)
        {
            PlaceHolder1.Controls.Clear();
            for (int i = 0; i < ALL_EDP.Count; i++)
            {
                //   NumberOfControls++;
                // PlaceHolder1.Controls.Clear();
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
                sample.showDetails(Convert.ToString(ALL_EDP[i]), label_Store, label_ProductName, label_Description, label_Price, Image_url, label_Manufacturer, label_Availability);

                PlaceHolder ph = new PlaceHolder();
                ph.ID = "placeholderxe" + i.ToString();
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

        public static  void BrandSelectedMultipleDisplay(List<int> Filtered_Brand_EDP, PlaceHolder placeholder1)
        {
            // save is an arraylist that contains EDP #
            placeholder1.Controls.Clear();
            for (int i = 0; i < Filtered_Brand_EDP.Count; i++)
            {
                #region Naming , Creation of LAbel
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
                PlaceHolder ph = new PlaceHolder();
                ph.ID = "placeHold" + i;
                #endregion Naming , Creation of LAbel
                sample.showDetails(Convert.ToString(Filtered_Brand_EDP[i]), label_Store, label_ProductName, label_Description, label_Price, Image_url, label_Manufacturer, label_Availability);

                #region  IMPLEMENTATION
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
                #endregion IMPLEMENTATION
                placeholder1.Controls.Add(ph);
            }
          
        }
        #endregion DIPLAY SHOW ALL PRODUCT

        public static void Filtering_EDP_Brand(string BrandName)  // GET EDP USING Manufacturer   Version 3
        { // scan all product with the same Brand name then return  eDP if same Brand 
            Filtered_EDP_Brand.Clear();                 /// ALWATS CLEAR EDP SAVE LIST 
            for (int i = 0; i < ALL_EDP.Count; i++)
            {
                String inputurl = ("http://afs-sl-pservice01.afservice.org:8080/productservice2/getProductInfo/pcmall?edplist=" + ALL_EDP[i] + "&ignoreCatalog=true"); //  + 6926988/*EDP*/ +
                System.Xml.XmlTextReader reader = new XmlTextReader(inputurl);
                string brandx;
                int edp_tempo = 0;
                while (reader.Read())
                {
                    while (reader.ReadToFollowing("edp"))
                    {
                        if (reader.Name == "edp")
                        {
                            edp_tempo = Convert.ToInt32(reader.ReadElementString("edp"));
                        }
                        while (reader.ReadToFollowing("manufacturer"))
                        {
                            brandx = reader.ReadElementString("manufacturer");
                            if (brandx == BrandName)
                            {
                                Filtered_EDP_Brand.Add(edp_tempo); 
                            }
                        }
                    }
                }
            }
            
        }

        public static void brandmultipleDisplay(String brandName ,PlaceHolder PlaceHolder1)  // ERROR   ID REPEATING
        {
            Filtering_EDP_Brand(brandName);
            BrandSelectedMultipleDisplay(Filtered_EDP_Brand,PlaceHolder1);
        }

        
        



    
    }
}