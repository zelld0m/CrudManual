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
    /// 

    public class sample
    {
        
        /// <summary>
        /// READER
        /// </summary>
        public static String testreader(String x) {

            //=======================================  1st ============================================
            //var xmlDoc = new XmlDocument();
            //xmlDoc.Load("http://afs-sl-schmgr03.afservice.org:8080/searchManager/search/afs-sl-schmstr.afservice.org:8080/solr4/Products/select?q=laptop&fl=EDP&store=pcmall&rows=25&start=0");
            //var address = xmlDoc.GetElementsByTagName("responseHeader");// ERROR System.Xml.XmlElementList
            //x = Convert.ToString(address);
            //return x;



            //=======================================  2nd ============================================
            //var xmlDoc = new XmlDocument();
            //xmlDoc.Load("http://afs-sl-schmgr03.afservice.org:8080/searchManager/search/afs-sl-schmstr.afservice.org:8080/solr4/Products/select?q=laptop&fl=EDP&store=pcmall&rows=25&start=0");
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


        public static String carlsoncode()
        {
            String text = "";
            System.Xml.XmlTextReader reader = new XmlTextReader("http://afs-sl-schmgr03.afservice.org:8080/searchManager/search/afs-sl-schmstr.afservice.org:8080/solr4/Products/select?q=laptop&fl=EDP&store=pcmall&rows=25&start=0&facet=true&facet.field=Manufacturer&facet.field=InStock&facet.limit=10");
            reader.WhitespaceHandling = WhitespaceHandling.Significant;
            while (reader.ReadToFollowing("int"))
            {
               string attr = reader.GetAttribute("name");
               string valuetext = reader.ReadElementString("int");
                text += "</br>";
                text = text +("Attribute Name: " + attr);
                text = text + ("</br>");
                text = text + ("Value:" + valuetext);
                text = text + ("</br>");
                text = text + ("</br>");
            }
            return text;
        }
        public static void findcode(TextBox tb1, TextBox tb2, Label lbl1)
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
        public static string getnumfound() // FINDING VALUE
        {
            string lblNumfound = "";
            System.Xml.XmlTextReader reader2 = new XmlTextReader("http://afs-sl-schmgr03.afservice.org:8080/searchManager/search/afs-sl-schmstr.afservice.org:8080/solr4/Products/select?q=laptop&fl=EDP&store=pcmall&rows=25&start=0&facet=true&facet.field=Manufacturer&facet.field=InStock&facet.limit=10");
            reader2.WhitespaceHandling = WhitespaceHandling.Significant;
            while (reader2.Read())
            {
                if(reader2.GetAttribute("numFound") == "94358")
                {
                    lblNumfound +="  GET ATTRIBUTE " +reader2.GetAttribute("numFound");   // FOUND
                }
            }
            return lblNumfound;
        }
    }
}