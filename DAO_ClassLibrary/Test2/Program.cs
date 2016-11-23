using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region De _ Serialization


            //product Serialization
            try
            {
                Product product = new Product
                {
                    ID = "p01",
                    Name = "product Name 1",
                    CategoryName = "category 1",
                    price = new Price { Value = 100, Unit = "USD" },
                    description = new Description { Color = "RED", Size = "Size dd1", Weight = "100gr" }
                };
            //--------ERROR 
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Product));
              
                StreamWriter sw = new StreamWriter("Product.xml");

                xmlSerializer.Serialize(sw, product);
                sw.Close();
                //ERROR
                Console.WriteLine("Serialization Success");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //Product Desirialization
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Product));
                StreamReader sr = new StreamReader("Product.xml");
                Product Product = (Product)xmlSerializer.Deserialize(sr);
                Console.WriteLine("Product Information");
                Console.WriteLine("ID: " + Product.ID);
                Console.WriteLine("NAME: " + Product.Name);
                Console.WriteLine("Price: " + Product.price.Value);
                Console.WriteLine("unit: " + Product.price.Unit);
                Console.WriteLine("Color: " + Product.description.Color);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            #endregion De _ Serialization
            Console.ReadLine();
        }
    }
}
