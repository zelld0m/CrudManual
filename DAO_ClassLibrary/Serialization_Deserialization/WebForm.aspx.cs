using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Serialization;
using System.IO;



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
                product product = new product();
                
                product.id= TB_ID.Text;
                product.name = TB_Name.Text;
                product.categoryname = TB_CategoryName.Text;
                product.price.Value = Convert.ToByte( TB_Value.Text);
                product.price.unit = TB_Unit.Text;
                product.description.color = TB_Color.Text;
                product.description.size = TB_Size.Text;
                product.description.weight = TB_Weight.Text;

                  
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
                product product = new product();
               // XmlSerializer xmlSerializer = new XmlSerializer(typeof(product));
               // StreamReader sr = new StreamReader("Product.xml");
               // product product = (product)xmlSerializer.Deserialize(sr);
               //TB_Name.Text = product.id;
               // Console.WriteLine("NAME: " + product.name);
               // Console.WriteLine("Price: " + product.price.Value);
               // Console.WriteLine("unit: " + product.price.unit);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
    
            #endregion De _ Serialization
        }
    }
}