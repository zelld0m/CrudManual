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


        public static void showDetails(String inputurl ,Label label_store , Label label_productName,
            Label label_productdescription,Label label_Price, String str_image ,
            Label label_Manufacturer ,Label label_availabilityDescription)
        {



            inputurl = ("http://afs-sl-pservice01.afservice.org:8080/productservice2/getProductInfo/pcmall?edplist=10290644&ignoreCatalog=true"); //  + 6926988/*EDP*/ +
            System.Xml.XmlTextReader reader = new XmlTextReader(inputurl);
            // reader.WhitespaceHandling = WhitespaceHandling.Significant;
            while (reader.Read())
            {
                if (reader.Name == "store")
                {

                 label_store.Text = reader.ReadElementString("store");// show all EDP     

                }
                //============================
                if (reader.Name == "name")
                {
                 label_productName.Text = reader.ReadElementString("name");// show all EDP     
                }
                if (reader.Name == "description")
                {
                    label_productdescription.Text = reader.ReadElementString("description");// show all EDP     

                }
                if (reader.Name == "finalPrice")
                {
                       label_Price .Text = reader.ReadElementString("finalPrice");// show all EDP     
                }
                if (reader.Name == "xlg")  // IMAGE  & SIZE  // String value
                {
                    str_image = reader.ReadElementString("xlg");// show all EDP     
                }
                if (reader.Name == "manufacturer")
                {
                    label_Manufacturer.Text = reader.ReadElementString("manufacturer");// show all EDP     
                }
                if (reader.Name == "availabilityDescription")
                {
                    label_availabilityDescription.Text = reader.ReadElementString("availabilityDescription");// show all EDP     
                }

                //reader.Name == "productDetails" ||reader.Name == "manufacturer"
            }
       

        }
    }
}