using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace UsingUrlToGetXML
{
    public class MicrosoftLink
    {
       
        public static String microsoftTutorial(int start)
        {
            String URLString = "http://afs-sl-schmgr03.afservice.org:8080/searchManager/search/afs-sl-schmstr.afservice.org:8080/solr4/Products/select?q=laptop&fl=EDP&store=pcmall&rows=25&start=" + start;
            XmlTextReader reader = new XmlTextReader(URLString);
            String str = "";
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element: // The node is an element.
                        //    Console.Write("<" + reader.Name);
                        str = str + "<";
                        str = str + " " + reader.Name + " " + reader.Value + " ";
                        while (reader.MoveToNextAttribute()) // Read the attributes.  // name = start
                            //         Console.Write(" " + reader.Name + "='" + reader.Value + "'");
                            str = str + " " + reader.Name + " = " + reader.Value + " ";
                        while (reader.MoveToElement()) // The node is an element.
                            str = str + " " + reader.Name + "" + reader.Value + "";
                            str = str + "<br/> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;";
                        break;
                    case XmlNodeType.Text: //Display the text in each element.
                        str = str + "</" + reader.Name + "=" + reader.ValueType + "" + reader.Value + "'";
                        break;
                    case XmlNodeType.EndElement: //Display the end of the element.
                        str = str + "</" + reader.Name + "=" + reader.ValueType + "'";
                        // Console.WriteLine(">");
                        str = str + "----yy------>";
                        break;
                }
            } return str;
        }
        public static String microsoftTutorial2(int start)  // shows value 
        {
            String URLString = "http://afs-sl-schmgr03.afservice.org:8080/searchManager/search/afs-sl-schmstr.afservice.org:8080/solr4/Products/select?q=laptop&fl=EDP&store=pcmall&rows=25&start=" + start;
            XmlTextReader reader = new XmlTextReader(URLString);
            String str = "";
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element: // The node is an element.
                        //Console.Write("<" + reader.Name);
                        str = str + "<" + reader.Name + " ";                                                              //CHECK
                        while (reader.MoveToNextAttribute()) // Read the attributes.
                                                             //      Console.Write(" " + reader.Name + "='" + reader.Value + "'");
                            str = str + " " + reader.Name + "='" + reader.Value + "'";

                        //  Console.Write(">");
                        str = str + ">";
                        //  Console.WriteLine(">");
                        str = str + ">";
                        break;
                    case XmlNodeType.Text: //Display the text in each element.
                        //Console.WriteLine(reader.Value);
                        str = str + reader.Value + "";
                        break;
                    case XmlNodeType.EndElement: //Display the end of the element.
                                                 // Console.Write("</" + reader.Name);
                        str = str + "</";
                        //Console.WriteLine(">");
                        str = str + "><br/";
                        break;
                }
                
            }
            return str;
        }
        public static String findReaderValue()
        {
            String URLString = "http://afs-sl-schmgr03.afservice.org:8080/searchManager/search/afs-sl-schmstr.afservice.org:8080/solr4/Products/select?q=laptop&fl=EDP&store=pcmall&rows=25&start=0";
            String returnthis = "";
            XmlTextReader reader = new XmlTextReader(URLString);
            while (reader.Read())
            {
                // if (reader.HasAttributes)
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element: // The node is an element.

                        while (reader.MoveToNextAttribute()) // Read the attributes.  // name = start
                            if (reader.Value == "QTime")              //Change this to find value
                            { // The node is an element.
                                returnthis = returnthis + " " + reader.Name + "" + reader.Value + " HELLOWORLD";
                            }
                        while (reader.MoveToElement()) // The node is an element.
                            if (reader.Value == "QTime")
                            {
                                returnthis = returnthis + " " + reader.Name + "" + reader.Value+"ELEMENTS";
                            }
                        // The node is an element.

                        break;

                    case XmlNodeType.Text: //Display the text in each element.
                        if (reader.Value == "QTime")
                        {
                            returnthis = returnthis + " " + reader.Name + "" + reader.Value;
                        }
                        break;
                    case XmlNodeType.EndElement: //Display the end of the element.
                        if (reader.Value == "QTime")
                        {
                            returnthis = returnthis + " " + reader.Name + "" + reader.Value;
                        }
                        break;
                }

            } return returnthis;



        }
        public static String findReaderValue2()
        {
            creatingXMLUsingString();  //xml Created named "data.xml"
            String put = "";
            String str = "";
            XmlReader reader = XmlReader.Create("data.xml");  // success on saving 
            
            #region
            reader.Read();
            reader.ReadStartElement("response");  // if response has been changed 
                                                  //reader.ReadStartElement("params");
                                                  // str = "THE CONTENTES OF THE TITLE ELEMENT: "+reader.ReadString();
            while (reader.Read())
            {
                str = str + " " + reader.Value;      // value 
                                                     //  str = str + " " + reader.Name;  // int str  
               while (reader.MoveToNextAttribute())
                    {
                        if (reader.Value == "QTime")              //Change this to find value
                        { // The node is an element.
                            put = put + " " + reader.Value + " HELLOWORLD:  "+ reader.ReadOuterXml();
                        }
                            str = str +  "</br>" + reader.Value  ;    // QTime Params echoParams
                        // str = str + " " + reader.Name;      Name only not important
                        //str = str + " " + reader.ValueType; 
                    }
                   //while (reader.MoveToNextAttribute()) ;
                //str = str  + reader.Value + "</br>";
            }
            //   reader.ReadStartElement("");
            // str = str + " The content of the element : " + reader.ReadContentAsString();
            #endregion
            //put = str;
            
            return put;
        }
        public static string downloadStringFromUrl(string url)  // extracting xml and converting to string
        {
            string str;
            using (WebClient client = new WebClient())
            {
                str = client.DownloadString(url);
            }
            return str;

        }
        public static void creatingXMLUsingString()   //Creating xml datafile
        {
            //Create Xmldocument
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(downloadStringFromUrl("http://afs-sl-schmgr03.afservice.org:8080/searchManager/search/afs-sl-schmstr.afservice.org:8080/solr4/Products/select?q=laptop&fl=EDP&store=pcmall&rows=25&start=0"));
            // save the document to a file. white space is preserved (no White space)
            doc.PreserveWhitespace = true;
            doc.Save("data.xml");   //FAiLED     
        }
        public static void PullXMLFileAndMakingString()
        {  // LINK http://stackoverflow.com/questions/3175790/how-can-i-download-an-xml-file-using-c
            //1st Approach
           
            string url = "http://www.dreamincode.net/forums/xml.php?showuser=1253";
            string xml;
            using (var webClient = new WebClient())
            {
                xml = webClient.DownloadString(url);
            }

            XDocument doc = XDocument.Parse(xml);

            // in the result profile with id name is 'Nate'
            string name = doc.XPathSelectElement("/ipb/profile[id='1253']/name").Value;
         //   Assert.That(name, Is.EqualTo("Nate"));

            //2nd Appoach------------------------------------------------------------ 
            var xml2 = XDocument.Load("http://www.dreamincode.net/forums/xml.php?showuser=1253");

            // Use this link to apply LINQ and XML for easier way
            //https://www.youtube.com/watch?v=sfDPdflXbiM
        }
        public static string implement(TextBox tb1, TextBox tb2)
        {
            var xdoc = XDocument.Load("http://afs-sl-schmgr03.afservice.org:8080/searchManager/search/afs-sl-schmstr.afservice.org:8080/solr4/Products/select?q=laptop&fl=EDP&store=pcmall&rows=25&start=0");
            String inputString = "mmm";
            //xdoc.Descendants("responseHeader").Select(p => new
            //{
            //    status = p.Element("status").Value,
            //    QTime = p.Element("QTime").Value

            //}).ToList().ForEach(p =>
            //{
            //    tb1.Text = "Status = " + p.status;
            //    tb2.Text = "QTime = " + p.QTime;
            //    inputString = "----------";
            //});

            var selectedpage = from r in xdoc.Descendants("responseHeader")
                               select new
                               {
                                   status = r.Element("status").Value,
                                   QTime = r.Element("QTime").Value,
                                   
        };
            foreach(var r in selectedpage)
            {
                tb1.Text = "Status = " + r.status;
                tb2.Text = "QTime" + r.status;
                inputString = "----------";
            }
 


            return inputString;
        }

    }

   
}



     