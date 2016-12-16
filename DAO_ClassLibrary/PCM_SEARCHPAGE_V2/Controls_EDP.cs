using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;

namespace PCM_SEARCHPAGE_V2
{
    public class Controls_EDP
    {
        private List<int> all_edp;
        private List<int> search_EDP;
        private List<int> brandFiltered_EDP;
        private List<string> brandList;
        private List<string> tempoBrand;
        private int numfoundFromSearch;

        public List<int> All_edp
        {
            get
            {
                return all_edp;
            }

            set
            {
                all_edp = value;
            }
        }
        public List<int> Search_EDP
        {
            get
            {
                return search_EDP;
            }

            set
            {
                search_EDP = value;
            }
        }
        public List<int> BrandFiltered_EDP
        {
            get
            {
                return brandFiltered_EDP;
            }

            set
            {
                brandFiltered_EDP = value;
            }
        }
        public List<string> BrandList
        {
            get
            {
                return brandList;
            }

            set
            {
                brandList = value;
            }
        }
        public List<string> TempoBrand
        {
            get
            {
                return tempoBrand;
            }

            set
            {
                tempoBrand = value;
            }
        }
        public int NumfoundFromSearch
        {
            get
            {
                return numfoundFromSearch;
            }

            set
            {
                numfoundFromSearch = value;
            }
        }
    


        #region SETTER
        public  List<int> getEDPfromSearchManager() {
            Controls_URLSite con_site = new Controls_URLSite();   
         //   All_edp.Clear();

            
            string url =   con_site.SearchManagerURL;   // SERVICE MANAGER WAS USED 
            System.Xml.XmlTextReader reader = new XmlTextReader(url);
            reader.ReadToFollowing("result");
            NumfoundFromSearch = Convert.ToInt32(reader.GetAttribute("numFound"));
            reader.ReadToFollowing("int");
            while (reader.GetAttribute("name") == "EDP")
            {
                All_edp.Add(Convert.ToInt32(reader.ReadElementString("int")));
                reader.ReadToFollowing("int");
            }
            return All_edp;
        }

        public  void generateBrandList()    
        {
            if (brandList != null)
            {
                BrandList.Clear();
            }
            for (int i = 0; i < All_edp.Count; i++)
            {
                String inputurl = ("http://afs-sl-pservice01.afservice.org:8080/productservice2/getProductInfo/pcmall?edplist=" + All_edp[i] + "&ignoreCatalog=true"); //  + 6926988/*EDP*/ +
                System.Xml.XmlTextReader reader = new XmlTextReader(inputurl);
                string brandx = "";
                int edp_tempo = 0;
                //   StringComparison comp = StringComparison.OrdinalIgnoreCase;
                while (reader.Read())
                {
                    while (reader.ReadToFollowing("edp"))
                    {
                        if (reader.Name == "edp")
                        {
                            edp_tempo = Convert.ToInt32(reader.ReadElementString("edp"));
                        }
                        if (reader.ReadToFollowing("manufacturer"))
                        {
                            brandx = reader.ReadElementString("manufacturer");
                        }                        
                        if (BrandList.Contains(brandx))
                        {
                        }
                        else BrandList.Add(brandx);
                        
                    }
                }
            }
        }
      
        public  void BrandSelected_Generate_EDP(string findBrand)
        {
            TempoBrand.Clear();
            BrandFiltered_EDP.Clear();
            if (Search_EDP.Count == 0)
            {
                Search_EDP = All_edp;
            }
            
            for (int i = 0; i < Search_EDP.Count; i++)
            {
                String inputurl = ("http://afs-sl-pservice01.afservice.org:8080/productservice2/getProductInfo/pcmall?edplist=" + Search_EDP[i] + "&ignoreCatalog=true"); //  + 6926988/*EDP*/ +
                System.Xml.XmlTextReader reader = new XmlTextReader(inputurl);
                string brandx = "";
                int edp_tempo = 0;
                //   StringComparison comp = StringComparison.OrdinalIgnoreCase;
                while (reader.Read())
                {
                    while (reader.ReadToFollowing("edp"))
                    {
                        if (reader.Name == "edp")
                        {
                            edp_tempo = Convert.ToInt32(reader.ReadElementString("edp"));
                        }
                        if (reader.ReadToFollowing("manufacturer"))
                        {
                            brandx = reader.ReadElementString("manufacturer");
                        }
                    }
                    if (brandx.ToLower().Contains(findBrand.ToLower()))
                    {
                        BrandFiltered_EDP.Add(edp_tempo);
                        if (TempoBrand.Contains(brandx))
                        {
                        }
                        else TempoBrand.Add(brandx);
                    }
                }
            }
        }


        #region  Unused GetALL Brand
        //public static List<String> AllBrand()  // GET ALL BRAND   Use This to show all brand  
        //{
           
        //    System.Xml.XmlTextReader reader = new XmlTextReader(Controls_URL.SearchManagerPage_URL());
        //    reader.ReadToFollowing("lst");
        //    reader.ReadToFollowing("lst");
        //    reader.ReadToFollowing("lst");
        //    reader.ReadToFollowing("lst");
        //    reader.ReadToFollowing("lst");
        //    while (reader.Read())
        //    {
        //        if ((reader.GetAttribute("name") == "Manufacturer"))
        //        {
        //            while (reader.ReadToFollowing("int") && (reader.GetAttribute("name") != "true") && (reader.GetAttribute("name") != "false"))
        //            {
        //                BrandList.Add(Convert.ToString(reader.GetAttribute("name")));// show all EDP
        //            }
        //        }
        //    }
        //    return BrandList;
        //}
        #endregion
        #endregion




   
    }
}