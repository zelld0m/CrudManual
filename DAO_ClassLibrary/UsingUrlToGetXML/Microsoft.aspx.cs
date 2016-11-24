using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UsingUrlToGetXML
{
    public partial class Microsoft : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
         
        }
        protected void Btn_Find_Click(object sender, EventArgs e)
        {
            Lbl_Find.Text= MicrosoftLink.findReaderValue();
        }
        

        protected void Btn_Fill1_Click(object sender, EventArgs e)
        {
            Lbl_Data1.Text = MicrosoftLink.microsoftTutorial(15);
        }

        protected void Btn_Fill2_Click(object sender, EventArgs e)
        {
            Lbl_Data2.Text = MicrosoftLink.microsoftTutorial2(16);
        }
       
    }

}