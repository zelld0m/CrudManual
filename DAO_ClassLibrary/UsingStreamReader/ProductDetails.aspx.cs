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
            List<String> productDetailsList = new List<string>(10000);

            String url = ("http://afs-sl-pservice01.afservice.org:8080/productservice2/getProductInfo/pcmall?edplist=10290644&ignoreCatalog=true"); //  + 6926988/*EDP*/ +
            System.Xml.XmlTextReader reader = new XmlTextReader(url);
            // reader.WhitespaceHandling = WhitespaceHandling.Significant;
            while (reader.Read())
            {
                if ( reader.Name == "status"  )
                {

                    //while (reader.HasAttributes)
                    //{
                    //if(reader.GetAttribute(""))
                    //if(reader.GetAttribute("productDetails")=="manufacturer")
                    productDetailsList.Add(reader.Name + " " + reader.ReadElementString("status")  + "</br>");// show all EDP     

                }


                if (reader.Name == "store")
                {

                    productDetailsList.Add(reader.ReadElementString("store") + "</br>");// show all EDP     

                }
                //============================
                if (reader.Name == "name")
                {
                    productDetailsList.Add(reader.ReadElementString("name") + "</br>");// show all EDP     
                }
                if (reader.Name == "description")
                {
                    productDetailsList.Add(reader.ReadElementString("description")+ "</br>");// show all EDP     

                }
                if (reader.Name == "finalPrice")
                {
                   productDetailsList.Add(reader.ReadElementString("finalPrice") + "</br>");// show all EDP     
                }
                if (reader.Name == "xlg")  // IMAGE  & SIZE 
                {
                    productDetailsList.Add(reader.ReadElementString("xlg") + "</br>");// show all EDP     
                }
                if (reader.Name == "manufacturer")
                {
                    productDetailsList.Add(reader.ReadElementString("manufacturer") + "</br>");// show all EDP     
                }

                //reader.Name == "productDetails" ||reader.Name == "manufacturer"
            }
            Label1.Text = String.Join("", productDetailsList);
        }
    }
}