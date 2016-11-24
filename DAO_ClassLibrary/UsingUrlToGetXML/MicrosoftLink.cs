using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;

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
            String URLString = "http://afs-sl-schmgr03.afservice.org:8080/searchManager/search/afs-sl-schmstr.afservice.org:8080/solr4/Products/select?q=laptop&fl=EDP&store=pcmall&rows=25&start=0";
            String put = "";
            String str = "";
            XmlTextReader reader = new XmlTextReader(URLString);
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element: // The node is an element.
                        //Console.Write("<" + reader.Name);
                        str = str + "<" + reader.Name + " ";
                                                                       //CHECK
                        while (reader.MoveToElement()) // Read the attributes.
                          if (reader.Value == "QTime")  //working on findreadervalue1
                            { // The node is an element.
                                put = put + " " + reader.Name + "" + reader.Value + " HELLOWORLD";
                            }     //      Console.Write(" " + reader.Name + "='" + reader.Value + "'");
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
                
            }return put;

        }
    }
}



     