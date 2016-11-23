using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


using System.IO;

using System.Xml.Serialization;


namespace Serialization_Deserialization
{
    public partial class WebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            #region De _ Serialization
            //product Serialization
            try
            {
                product product = new Serialization_Deserialization.product
                {
                    id = "p01",
                    name = "product Name 1",
                    categoryname = "category 1",
                    price = new productPrice { Value = 100, unit = "USD" },
                    description = new productDescription { color = "RED", size = "Size 1", weight = "100gr" }
                };
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(product));
                StreamWriter sw = new StreamWriter("Product.xml");
                xmlSerializer.Serialize(sw, product);
                sw.Close();
                Label1.Text= ("Serialization complete");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //Product Desirialization
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(product));
                StreamReader sr = new StreamReader("Product.xml");
                product product = (product)xmlSerializer.Deserialize(sr);
               TB_Name.Text = product.id;
                Console.WriteLine("NAME: " + product.name);
                Console.WriteLine("Price: " + product.price.Value);
                Console.WriteLine("unit: " + product.price.unit);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            #endregion De _ Serialization
        }
    }
}