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


    /// <summary>
    /// https://www.dotnetperls.com/streamreader
    /// </summary>
    /// http://afs-sl-schmgr03.afservice.org:8080/searchManager/search/afs-sl-schmstr.afservice.org:8080/solr4/Products/select?q=laptop&fl=EDP&store=pcmall&rows=25&start=0&facet=true&facet.field=Manufacturer&facet.field=InStock&facet.limit=10

    public class sample
    {

        /// <summary>
        /// READER
        /// </summary>


        #region NO USE Test only
        public static String Testreader(String x)
        {

            //=======================================  1st ============================================
            //var xmlDoc = new XmlDocument();
            //xmlDoc.Load("http://afs-sl-schmgr03.afservice.org:8080/searchManager/search/afs-sl-schmstr.afservice.org:8080/solr4/Products/select?q=laptop&fl=EDP&store=pcmall&rows=25&start=0&facet=true&facet.field=Manufacturer&facet.field=InStock&facet.limit=10");
            //var address = xmlDoc.GetElementsByTagName("responseHeader");// ERROR System.Xml.XmlElementList
            //x = Convert.ToString(address);
            //return x;



            //=======================================  2nd ============================================
            //var xmlDoc = new XmlDocument();
            //xmlDoc.Load("http://afs-sl-schmgr03.afservice.org:8080/searchManager/search/afs-sl-schmstr.afservice.org:8080/solr4/Products/select?q=laptop&fl=EDP&store=pcmall&rows=25&start=0&facet=true&facet.field=Manufacturer&facet.field=InStock&facet.limit=10");
            //StreamReader stream = new StreamReader(xmlDoc);

            //x = Convert.ToString(address);


            // ---------------------------------------- 3rd -----------------------------------------
            //var xmlDoc = new XmlDocument();
            //Stream str = null;
            //StreamReader responseReader = new StreamReader(str);
            //StreamReader sr=new StreamReader(str);

            //string responseString = responseReader.ReadToEnd();
            ////xmlDoc.LoadXml(sr.ReadToEnd());
            //xmlDoc.LoadXml(responseString);
            //responseReader.Close();
            ////sr.Close();
            //str.Close();


            //xmlDoc.Load("<hello></hello>");
            //using (StreamReader responseReaderz = new StreamReader(str))
            //{
            //    xmlDoc.LoadXml(reasponseReader);
            //} 
            //----------------------------------------- 4th ---------------------------------------

            // XMLTEXTREADER  From carlson

            //XmlTextReader reader = new XmlTextReader("http://afs-sl-schmgr03.afservice.org:8080/searchManager/search/afs-sl-schmstr.afservice.org:8080/solr4/Products/select?q=laptop&fl=EDP&store=pcmall&rows=25&start=0&facet=true&facet.field=Manufacturer&facet.field=InStock&facet.limit=10");
            //    reader.WhitespaceHandling = WhitespaceHandling.Significant;
            //    while (reader.ReadToFollowing("int"))
            //    {
            //        string attr = reader.GetAttribute("name");
            //        string valuetext = reader.ReadElementString("int");

            //        Response.Write("Attribute Name: " + attr);
            //        Response.Write("</br>");
            //        Response.Write("Value:" + valuetext);
            //        Response.Write("</br>");
            //        Response.Write("</br>");
            //    }
            return x;

        }
        public static String ViewALL()
        {
            String text = "";
            System.Xml.XmlTextReader reader = new XmlTextReader("http://afs-sl-schmgr03.afservice.org:8080/searchManager/search/afs-sl-schmstr.afservice.org:8080/solr4/Products/select?q=laptop&fl=EDP&store=pcmall&rows=25&start=0&facet=true&facet.field=Manufacturer&facet.field=InStock&facet.limit=10");
            reader.WhitespaceHandling = WhitespaceHandling.Significant;
            while (reader.ReadToFollowing("int"))
            {
                string attr = reader.GetAttribute("name");
                string valuetext = reader.ReadElementString("int");
                text += "</br>";
                text = text + ("Attribute Name: " + attr);
                text = text + ("</br>");
                text = text + ("Value:" + valuetext);
                text = text + ("</br>");
                text = text + ("</br>");
            }
            return text;
        }
        public static void Findcode(TextBox tb1, TextBox tb2, Label lbl1)
        {
            System.Xml.XmlTextReader reader2 = new XmlTextReader("http://afs-sl-schmgr03.afservice.org:8080/searchManager/search/afs-sl-schmstr.afservice.org:8080/solr4/Products/select?q=laptop&fl=EDP&store=pcmall&rows=25&start=0&facet=true&facet.field=Manufacturer&facet.field=InStock&facet.limit=10");
            reader2.WhitespaceHandling = WhitespaceHandling.Significant;
            while (reader2.ReadToFollowing("result"))  // If clicked   get the EDP and send it to next page and show details
            {
                string attr = reader2.GetAttribute("name");
                string valuetext = reader2.ReadElementString("int");
                if (tb1.Text == attr && tb2.Text == valuetext)   // finding value
                {
                    lbl1.Text = "GOTCHA  " + attr + "    " + valuetext;  // Found
                }
                // use this method to return value and pass it on the next page for Details on laptops
            }
        }
        public static string Getnumfound() // FINDING VALUE
        {
            string lblNumfound = "";
            System.Xml.XmlTextReader reader2 = new XmlTextReader("http://afs-sl-schmgr03.afservice.org:8080/searchManager/search/afs-sl-schmstr.afservice.org:8080/solr4/Products/select?q=laptop&fl=EDP&store=pcmall&rows=25&start=0&facet=true&facet.field=Manufacturer&facet.field=InStock&facet.limit=10");
            reader2.WhitespaceHandling = WhitespaceHandling.Significant;
            while (reader2.Read())
            {
                if (reader2.GetAttribute("numFound") == "94358")
                {
                    lblNumfound += "  GET ATTRIBUTE " + reader2.GetAttribute("numFound");   // FOUND
                }
            }
            return lblNumfound;
        }
        public static string ShowAllEDP()
        {
            string allEDP = "";
            System.Xml.XmlTextReader reader = new XmlTextReader("http://afs-sl-schmgr03.afservice.org:8080/searchManager/search/afs-sl-schmstr.afservice.org:8080/solr4/Products/select?q=laptop&fl=EDP&store=pcmall&rows=10&start=0&facet=true&facet.field=Manufacturer&facet.field=InStock&facet.limit=10");
            while (reader.ReadToFollowing("result"))
            {
                while (reader.ReadToFollowing("int"))
                {
                    //if (reader.GetAttribute("name") == "EDP")     // posible
                    while (reader.GetAttribute("name") == "EDP")    //    possible
                    {
                        allEDP += "</br>" + reader.GetAttribute("name") + reader.Value + " " + reader.ReadElementString("int");// show all EDP
                    }
                    //  allEDP += "</br>" + reader.GetAttribute("name")+ reader.Value + " " + reader.ReadElementString("int");
                }
            }
            return allEDP;
        }
        #endregion NO USE Test only


        #region IMPORTANT WORKING
        public static List<int> SaveALLEDP(String url)
        {
            List<int> saveEDP = new List<int>(500);
            System.Xml.XmlTextReader reader = new XmlTextReader(url);
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
            return saveEDP;
        }
        //TEST 
        public static string SaveAllBrand_EDP(List<string> Brandname)  // GET ALL BRAND  ----------------------- RIOT    TRY Using reader.skip() for faster movements
        {
           // Brandname = new List<string>(300);
            string allEDP = "";
            int howManyBrand = 10;
            System.Xml.XmlTextReader reader = new XmlTextReader("http://afs-sl-schmgr03.afservice.org:8080/searchManager/search/afs-sl-schmstr.afservice.org:8080/solr4/Products/select?q=laptop&fl=EDP&store=pcmall&rows=1&start=0&facet=true&facet.field=Manufacturer&facet.field=InStock&facet.limit=" + howManyBrand);
            while (reader.ReadToFollowing("lst"))
            {
                reader.Skip();
                reader.Skip();
                while (reader.ReadToFollowing("lst"))
                {
                    if((reader.GetAttribute("name") == "Manufacturer"))
                    {
                        while (reader.ReadToFollowing("int")&&(reader.GetAttribute("name") !="true") && (reader.GetAttribute("name")!="false"))
                        {
                            allEDP += "</br>" + reader.GetAttribute("name")  + reader.Value + reader.XmlLang;// show all EDP
                            Brandname.Add(reader.GetAttribute("name"));
                        }
                    }
                }  
            }
            return allEDP;
        }
 
        // Working Getting ALL brand Change howmanyBrand to howmuch brand u want to show
        public static List<String> AllBrand()  // GET ALL BRAND  ----------------------------------------- RIOT    TRY Using reader.skip() for faster movements
        {
            List<String> allEDP = new List<String>(100); ;
            int howManyBrand = 10;
            System.Xml.XmlTextReader reader = new XmlTextReader("http://afs-sl-schmgr03.afservice.org:8080/searchManager/search/afs-sl-schmstr.afservice.org:8080/solr4/Products/select?q=laptop&fl=EDP&store=pcmall&rows=1&start=0&facet=true&facet.field=Manufacturer&facet.field=InStock&facet.limit=" + howManyBrand);
            while (reader.ReadToFollowing("lst"))
            {
                reader.Skip();
           //     reader.Skip();
                while (reader.ReadToFollowing("lst"))
                {
                    while ((reader.GetAttribute("name") == "Manufacturer"))
                    {
                        while (reader.ReadToFollowing("int") && (reader.GetAttribute("name") != "true") && (reader.GetAttribute("name") != "false"))
                        {
                            allEDP.Add(Convert.ToString( reader.GetAttribute("name")));// show all EDP
                        }
                    }
                }
            }
            return allEDP;
        }

        
        // Working Getting ALL Details of ALL Products
        public static void showDetails(String inputEdp,Label label_store,Label label_productName,Label label_productdescription,
            Label label_Price,Image imageSourceUrl,Label label_Manufacturer,Label label_availabilityDescription){ // 6 label , 2 string 
            String inputurl = ("http://afs-sl-pservice01.afservice.org:8080/productservice2/getProductInfo/pcmall?edplist=" + inputEdp + "&ignoreCatalog=true"); //  + 6926988/*EDP*/ +
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
                    imageSourceUrl.ImageUrl = reader.ReadElementString("xlg");// show all EDP      // IMAGE SOURCE
                }
                if (reader.Name == "manufacturer")
                {
                    label_Manufacturer.Text = reader.ReadElementString("manufacturer");
                }
                if (reader.Name == "availabilityDescription")
                {
                    label_availabilityDescription.Text = reader.ReadElementString("availabilityDescription");
                }
            }
        }
        #endregion end importantWORKING






        public static int Get_EDP_FromBrand(String BrandName,int EdpTestNumber)  // GET EDP USING Manufacturer
        { // scan all product with the same Brand name then return  eDP if same Brand 
            String inputurl = ("http://afs-sl-pservice01.afservice.org:8080/productservice2/getProductInfo/pcmall?edplist=" + EdpTestNumber + "&ignoreCatalog=true"); //  + 6926988/*EDP*/ +
            System.Xml.XmlTextReader reader = new XmlTextReader(inputurl);
            int Edp = 0;
            string brandx;
            int edp_tempo=0;
            while (reader.Read())
            {

                if(reader.Name == "edp")
                {
                    edp_tempo = Convert.ToInt32( reader.ReadElementString("edp"));
                }
                if (reader.Name == "manufacturer")
                {
                    brandx = reader.ReadElementString("manufacturer");
                    if(brandx == BrandName)
                    {
                        Edp = edp_tempo;break;
                    }
                }
            }
            // Brandname.Add(reader.GetAttribute("name"));
            return Edp;
        }
    
    }
}