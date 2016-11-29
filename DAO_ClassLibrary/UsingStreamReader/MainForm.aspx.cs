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
            String x = "";
            List<int> SAVE;
            //Label1.Text =sample.testreader(x);
            //Label1.Text = sample.ShowAllEDP();
            //Label1.Text= sample.ViewALL();
            //Label3.Text = sample.getnumfound();



            // save is an arraylist that contains EDP #
            SAVE =sample.SaveALLEDP("Change this to real Url then of sa project and go to sample class and fix the code on SaveALLEDP ");

            Label1.Text = String.Join(Environment.NewLine, SAVE);   // to show EDP uncomment this
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