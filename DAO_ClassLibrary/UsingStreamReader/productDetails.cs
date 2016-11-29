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
    public class productDetails
    {


        public static List<int> SaveALLEDP(String url)
        {
            List<int> saveEDP = new List<int>();
            System.Xml.XmlTextReader reader = new XmlTextReader("http://afs-sl-schmgr03.afservice.org:8080/searchManager/search/afs-sl-schmstr.afservice.org:8080/solr4/Products/select?q=laptop&fl=EDP&store=pcmall&rows=10&start=0&facet=true&facet.field=Manufacturer&facet.field=InStock&facet.limit=10" /*url*/);
            reader.WhitespaceHandling = WhitespaceHandling.Significant;
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
    }
}