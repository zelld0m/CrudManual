using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI.WebControls;
using System.Xml;
namespace UsingStreamReader
{
    public class productDetails
    {


        public static void showDetails(String inputEdp,
            Label label_store ,
            Label label_productName,
            Label label_productdescription,
            Label label_Price,
            Image imageSourceUrl,
            Label label_Manufacturer ,
            Label label_availabilityDescription)
            // 6 label , 2 string 
        {
            String inputurl = ("http://afs-sl-pservice01.afservice.org:8080/productservice2/getProductInfo/pcmall?edplist="+inputEdp+"&ignoreCatalog=true"); //  + 6926988/*EDP*/ +
            System.Xml.XmlTextReader reader = new XmlTextReader(inputurl);
            // reader.WhitespaceHandling = WhitespaceHandling.Significant;
            while (reader.Read())
            {
                if (reader.Name == "store")
                {
                 label_store.Text = reader.ReadElementString("store");// show Store   
                }
                if (reader.Name == "name")
                {
                 label_productName.Text = reader.ReadElementString("name");  // Show ProductName
                }
                if (reader.Name == "description")
                {
                    label_productdescription.Text = reader.ReadElementString("description");   // Show Description
                }
                if (reader.Name == "finalPrice")
                {
                       label_Price.Text = reader.ReadElementString("finalPrice");   // 
                }
                if (reader.Name == "xlg")  // IMAGE  & SIZE  // String value
                {
                    imageSourceUrl.ImageUrl =  reader.ReadElementString("xlg");// show all EDP      // IMAGE SOURCE
                }
                if (reader.Name == "manufacturer")
                {
                  label_Manufacturer.Text = reader.ReadElementString("manufacturer");
                }
                if (reader.Name == "availabilityDescription")
                {
                    label_availabilityDescription.Text = reader.ReadElementString("availabilityDescription");    
                }
                //reader.Name == "productDetails" ||reader.Name == "manufacturer"
            }
        }
    }
}