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
            //Label1.Text =sample.testreader(x);
            //Label1.Text = sample.ShowAllEDP();
            //Label1.Text= sample.ViewALL();
            //Label3.Text = sample.getnumfound();



            // save is an arraylist that contains EDP #
            int rows = 20;
            SAVE =sample.SaveALLEDP("http://afs-sl-schmgr03.afservice.org:8080/searchManager/search/afs-sl-schmstr.afservice.org:8080/solr4/Products/select?q=laptop&fl=EDP&store=pcmall&rows="+rows+"&start=0&facet=true&facet.field=Manufacturer&facet.field=InStock&facet.limit=10");

            Label1.Text = String.Join("</br> </br>",SAVE);   // to show EDP uncomment this
            // plan to use SAve and make it a hyperlink then proceed to next website that shows Details of the product

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // sample.findcode(TextBox1, TextBox2, Label2);
        }
    }
}