using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Client
{
    public partial class login : System.Web.UI.Page
    {
        ServiceReference1.Service1Client client;
        protected void Page_Load(object sender, EventArgs e)
        {
            client = new ServiceReference1.Service1Client();
        }

        protected void btn1_click(object sender, EventArgs e)
        {
            if(client.checkUser(email.Value, password.Value))
            {
                Session["current_user"] = email.Value;
                Response.Redirect("homepage.aspx");
            }
            else
            {
                Response.Write("Error");
            }
        }
    }
}