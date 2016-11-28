﻿using System;
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

            System.Xml.XmlTextReader reader = new XmlTextReader("http://afs-sl-schmgr03.afservice.org:8080/searchManager/search/afs-sl-schmstr.afservice.org:8080/solr4/Products/select?q=laptop&fl=EDP&store=pcmall&rows=25&start=0&facet=true&facet.field=Manufacturer&facet.field=InStock&facet.limit=10");
            reader.WhitespaceHandling = WhitespaceHandling.Significant;
            while (reader.ReadToFollowing("int"))
            {
                string attr = reader.GetAttribute("name");
                string valuetext = reader.ReadElementString("int");

                Response.Write("Attribute Name: " + attr);
                Response.Write("</br>");
                Response.Write("Value:" + valuetext);
                Response.Write("</br>");
                Response.Write("</br>");
            }
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            sample.carlsoncode(TextBox1, TextBox2, Label1);


        }
    }
}