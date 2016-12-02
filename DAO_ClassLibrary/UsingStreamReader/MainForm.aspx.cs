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
        protected void Page_Load(object sender, EventArgs e)
        {
           
            List<int> SAVE;
            // save is an arraylist that contains EDP #
            int rows = 20;
            SAVE =sample.SaveALLEDP("http://afs-sl-schmgr03.afservice.org:8080/searchManager/search/afs-sl-schmstr.afservice.org:8080/solr4/Products/select?q=laptop&fl=EDP&store=pcmall&rows="+rows+"&start=0&facet=true&facet.field=Manufacturer&facet.field=InStock&facet.limit=10");

            Label1.Text = String.Join("</br> </br>",SAVE);   // to show EDP uncomment this
            // plan to use SAve and make it a hyperlink then proceed to next website that shows Details of the product

           // List<String> saveBrand;
            String x;
            x = sample.SaveAllBrand();
            Label1.Text = x;
          //  Response.Write(x);

        }

     

       
    }
}