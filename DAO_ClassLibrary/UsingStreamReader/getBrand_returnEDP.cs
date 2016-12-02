using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;

namespace UsingStreamReader
{
    public class getBrand_returnEDP
    {
        public static List<int> SaveBrandEDP(String url, String Brand)
        {
            List<int> saveEDP = new List<int>();
            // show all EDP on all brands
            System.Xml.XmlTextReader readerALLBrand = new XmlTextReader("http://afs-sl-schmgr03.afservice.org:8080/searchManager/search/afs-sl-schmstr.afservice.org:8080/solr4/Products/select?q=laptop&fl=EDP&store=pcmall&rows=94970&start=0");


            // show details
            System.Xml.XmlTextReader reader = new XmlTextReader("http://afs-sl-schmgr03.afservice.org:8080/searchManager/search/afs-sl-schmstr.afservice.org:8080/solr4/Products/select?q=laptop&fl=EDP&store=pcmall&rows=10&start=0&facet=true&facet.field=Manufacturer&facet.field=InStock&facet.limit=10" /*url*/);

            while (readerALLBrand.Read())
            {
                if (readerALLBrand.Name == "Manufacturer" && readerALLBrand.ReadElementString("manufacturer") == Brand)
                {
                    if (reader.Name == "availabilityDescription")
                    {
                        saveEDP.Add(Convert.ToInt32(reader.ReadElementString("edp")));// show all EDP
                    }
                }
            }
            return saveEDP;
        }

    }
}