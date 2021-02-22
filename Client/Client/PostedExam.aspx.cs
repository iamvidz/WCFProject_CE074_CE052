using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Client
{
    public partial class PostedExam : System.Web.UI.Page
    {
        int i;
        protected void Page_Load(object sender, EventArgs e)
        {
            i = 0;
            Label3.Visible = false;
        }

        protected void btn1(object sender, EventArgs e)
        {
            if(TextBox1.Text== "Windows Communication Foundation")
            {
                i++;
            }
            if(TextBox2.Text == "Microsoft Corporation") { i++; }

            Label3.Text = "Your score is " + i;
            Label3.Visible = true;
        }
    }
}