using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PCM_SEARCHPAGE_V2
{
    public class Controls_URLSite
    {
        private string searchManagerURL;
        private string alldetails_Use_EDP;
       
        Controls_EDP con_EDP = new Controls_EDP();
        Controls_URL_Properties con_URL_prop = new Controls_URL_Properties();

        public string SearchManagerURL
        {
            get
            {
                return searchManagerURL = "http://afs-sl-schmgr03.afservice.org:8080/searchManager/search/afs-sl-schmstr.afservice.org:8080/solr4/Products/select?q=" + con_URL_prop.Findproduct + "&fl=EDP&store=pcmall&rows=" + con_URL_prop.ProductLimitView + "&start=" + con_URL_prop.Currentpage + "&facet=true&facet.field=Manufacturer&facet.field=InStock&facet.limit=" + con_URL_prop.BrandLimit; 
            }

            set
            {
                searchManagerURL = value;
            }
        }

        public string Alldetails_Use_EDP
        {
            get
            {
                return alldetails_Use_EDP = "http://afs-sl-pservice01.afservice.org:8080/productservice2/getProductInfo/pcmall?edplist=" + con_EDP.All_edp + "&ignoreCatalog=true";
            }

            set
            {
                alldetails_Use_EDP = value;
            }
        }
 
    }
}