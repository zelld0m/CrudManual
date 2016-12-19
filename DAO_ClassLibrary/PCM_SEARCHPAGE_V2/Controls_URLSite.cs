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
        private String findproduct;
        private int currentpage;
        private int productLimitView = 10;
        private int brandLimit;




        #region GETTER SETTER
        public string Findproduct
        {
            get
            {
                return findproduct;
            }

            set
            {
                findproduct = value;
            }
        }
        public int Currentpage
        {
            get
            {
                return currentpage;
            }

            set
            {
                currentpage = value;
            }
        }
        public int ProductLimitView
        {
            get
            {
                return productLimitView;
            }

            set
            {
                productLimitView = value;
            }
        }
        public int BrandLimit
        {
            get
            {
                return brandLimit;
            }

            set
            {
                brandLimit = value;
            }
        }
        #endregion

        Controls_EDP con_EDP = new Controls_EDP();
        public string SearchManagerURL
        {
            get
            {
                return searchManagerURL = "http://afs-sl-schmgr03.afservice.org:8080/searchManager/search/afs-sl-schmstr.afservice.org:8080/solr4/Products/select?q=" + Findproduct + "&fl=EDP&store=pcmall&rows=" + ProductLimitView + "&start=" + Currentpage + "&facet=true&facet.field=Manufacturer&facet.field=InStock&facet.limit=" + BrandLimit; 
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
                return alldetails_Use_EDP ;
            }
            set
            {
                alldetails_Use_EDP = "http://afs-sl-pservice01.afservice.org:8080/productservice2/getProductInfo/pcmall?edplist="+value+ "&ignoreCatalog=true";
            }
        }
 
    }
}