using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace Serialization_Deserialization
{
    public class Class1
    {
        static void main(String[] Args)
        {
            #region De _ Serialization
            //product Serialization
            try
            {
                product product = new Serialization_Deserialization.product { id = "p01", name = "product Name 1",
                                    categoryname = "category 1",
                                    price = new productPrice { Value = 100, unit = "USD" },
                                    description = new productDescription { color = "RED", size = "Size 1", weight = "100gr" } };
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(product));
                StreamWriter sw = new StreamWriter("Product.xml");
                xmlSerializer.Serialize(sw, product);
                sw.Close();
                Console.WriteLine("");
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
                Console.WriteLine("Product Information");
                Console.WriteLine("ID: " + product.id);
                Console.WriteLine("NAME: " + product.name);
                Console.WriteLine("Price: " + product.price.Value);
                Console.WriteLine("unit: " + product.price.unit);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            #endregion De _ Serialization
        }
    }
}