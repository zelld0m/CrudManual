using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;

namespace UsingUrlToGetXML
{
    public class MicrosoftLink
    {
        
       
            public static  void microsoftTutorial() 
            {
                String URLString = "http://afs-sl-schmgr03.afservice.org:8080/searchManager/search/afs-sl-schmstr.afservice.org:8080/solr4/Products/select?q=laptop&fl=EDP&store=pcmall&rows=25&start=0";
                XmlTextReader reader = new XmlTextReader(URLString);

                while (reader.Read())
                {
                    switch (reader.NodeType)
                    {
                        case XmlNodeType.Element: // The node is an element.
                            Console.Write("<" + reader.Name);

                            while (reader.MoveToNextAttribute()) // Read the attributes.
                                Console.Write(" " + reader.Name + "='" + reader.Value + "'");
                            Console.Write(">");
                            Console.WriteLine(">");
                            break;
                        case XmlNodeType.Text: //Display the text in each element.
                            Console.WriteLine(reader.Value);
                            break;
                        case XmlNodeType.EndElement: //Display the end of the element.
                            Console.Write("</" + reader.Name);
                            Console.WriteLine(">");
                            break;
                    }
                }

            Console.ReadLine();
             }
    }

}