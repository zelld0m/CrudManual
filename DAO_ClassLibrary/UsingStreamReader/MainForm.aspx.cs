using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace UsingStreamReader
{
    public partial class MainForm : System.Web.UI.Page
    {
        List<int> SAVE = new List<int>(50);
        List<string> Brand = new List<string>(300);
        List<string> testValue = new List<string>(300);
        protected void Page_Load(object sender, EventArgs e)
        {
            String BrandName = "HP Inc.";


            Test();
            
           // // save is an arraylist that contains EDP #
           // int rows = 20;
           // SAVE =sample.SaveALLEDP("http://afs-sl-schmgr03.afservice.org:8080/searchManager/search/afs-sl-schmstr.afservice.org:8080/solr4/Products/select?q=laptop&fl=EDP&store=pcmall&rows="+rows+"&start=0&facet=true&facet.field=Manufacturer&facet.field=InStock&facet.limit=10");
           // Brand = sample.AllBrand(100);
           ////Label1.Text = String.Join("</br> </br>",SAVE);   // to show EDP uncomment this
           //                                                 // plan to use SAve and make it a hyperlink then proceed to next website that shows Details of the product
           //                                                 // List<String> saveBrand;
           //                                                 // List<string> xy = new List<string>(300);
           //                                                 //x = sample.SaveAllBrand_EDP(Brand);
           //                                                 //Brand = sample.AllBrand();


           //  sample.Get_EDP_FromBrand(BrandName, 10290644,SAVE);
           // Label1.Text = string.Join("</br> </br>", Brand);
          //  Label2.Text = string.Join("</br></br>", testValue);

            //Label1.Text = String.Join("</br>", Brand);
       
           // Label1.Text = x;
         //  Response.Write(x);

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < SAVE.Count; i++)
            {
                sample.Get_EDP_FromBrand(Button1.Text, SAVE[i],SAVE);
            }
            

        }
        public void Test()
        {
            ProductDetails prod = new ProductDetails();
            prod.MultipleDisplayAllProducts();
           
        }
    }
}