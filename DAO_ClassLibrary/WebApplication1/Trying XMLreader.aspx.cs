using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Linq;

namespace WebApplication1
{
    public partial class Trying_XMLreader : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            usingload();
            usingReader();


        }

        static void usingReader()
        {
            using (XmlReader reader = XmlReader.Create("http://afs-sl-schmgr03.afservice.org:8080/searchManager/search/afs-sl-schmstr.afservice.org:8080/solr4/Products/select?q=laptop&fl=EDP&store=pcmall&rows=25&start=0&facet=true&facet.field=Manufacturer&facet.field=InStock&facet.limit=10"))
            {
                reader.ReadStartElement("theRootElement");

                while (reader.Name == "TheNodeIWant")
                {
                    XElement el = (XElement)XNode.ReadFrom(reader);
                }

                reader.ReadEndElement();
            }
        }

        static IEnumerable<XElement> SimpleStreamAxis(string inputUrl,
                                              string elementName)
        {
            using (XmlReader reader = XmlReader.Create(inputUrl))
            {
                reader.MoveToContent();
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element)
                    {
                        if (reader.Name == elementName)
                        {
                            XElement el = XNode.ReadFrom(reader) as XElement;
                            if (el != null)
                            {
                                yield return el;
                            }
                        }
                    }
                }
            }


        }


        void inputURL(String url)
        {
            String urlx = @"" + url + "";
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(urlx);
        }
        //--


        static void usingload(){
        
        var document = XDocument.Load("http://afs-sl-schmgr03.afservice.org:8080/searchManager/search/afs-sl-schmstr.afservice.org:8080/solr4/Products/select?q=laptop&fl=EDP&store=pcmall&rows=25&start=0&facet=true&facet.field=Manufacturer&facet.field=InStock&facet.limit=10");
            }
        //==
    }
}