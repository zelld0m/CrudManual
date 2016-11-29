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
            //String x = "";
            //Label1.Text =sample.testreader(x);
        
           Label1.Text= sample.carlsoncode();
            //Label3.Text = sample.getnumfound();
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