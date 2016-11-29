using System;
using System.Collections.Generic;
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
            // use EDP as reference for the details
            int EDP;
            EDP = Convert.ToInt32(Request.QueryString["id"]);

            String url = ("http://afs-sl-pservice01.afservice.org:8080/productservice2/getProductInfo/pcmall?edplist=" + 6926988/*EDP*/ + "&ignoreCatalog=true");


            List<String > productDetailsList = new List<string>();
            System.Xml.XmlTextReader reader = new XmlTextReader(url);
            reader.WhitespaceHandling = WhitespaceHandling.Significant;
          
        
            while (reader.Read()){

                //while (reader.HasAttributes)
                //{

                    //if(reader.GetAttribute(""))
                    //   if(reader.GetAttribute("productDetails")=="manufacturer")
                    productDetailsList.Add(reader.Value + "</br>" );// show all EDP
                //}
            }
            
            Label1.Text = String.Join("", productDetailsList);
        }



        /*
         *
           while (reader.ReadToFollowing("result"))
            {
                while (reader.ReadToFollowing("int"))
                {
                    while (reader.GetAttribute("name") == "EDP")
                    {
                        saveEDP.Add(Convert.ToInt32(reader.ReadElementString("int")));// show all EDP
                    }
                }
            }
         *
         * 
         */
    }
}