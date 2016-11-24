using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;

namespace UsingUrlToGetXML
{
    public class MicrosoftLink
    {
        
       
            public static  String microsoftTutorial() 
            {
                String URLString = "http://afs-sl-schmgr03.afservice.org:8080/searchManager/search/afs-sl-schmstr.afservice.org:8080/solr4/Products/select?q=laptop&fl=EDP&store=pcmall&rows=25&start=0";
                XmlTextReader reader = new XmlTextReader(URLString);
            String str = "";
                while (reader.Read())
                {
                    switch (reader.NodeType)
                    {
                        case XmlNodeType.Element: // The node is an element.
                        //    Console.Write("<" + reader.Name);
                        str = str + "<";
                            while (reader.MoveToNextAttribute()) // Read the attributes.
                          //         Console.Write(" " + reader.Name + "='" + reader.Value + "'");
                                 str = str + " "+reader.Name+"="+reader.Value+"'";     
                        
                                str = str + ">";
                         while (reader.MoveToElement()) // The node is an element.
                                str = str + " " + reader.Name + "=" + reader.Value + "'";
                     
                        str = str + "<";
                        str = str + "  <br/>";
                        break;
                        case XmlNodeType.Text: //Display the text in each element.
                        //    Console.WriteLine(reader.Value);
                        str = str + "</" + reader.Name + "=" + reader.ValueType + "'" + reader.Value + "'";
                    
                        break;
                        case XmlNodeType.EndElement: //Display the end of the element.
                       //     Console.Write("</" + reader.Name);
                        str = str + "</"+reader.Name +"=" + reader.ValueType + "'";
                       // Console.WriteLine(">");
                        str = str + "----yy------>";
                        break;
                    }
                }
            return str;
          
             }
    }

}