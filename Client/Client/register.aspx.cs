using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Client
{
    public partial class register : System.Web.UI.Page
    {
        ServiceReference1.Service1Client client;
        protected void Page_Load(object sender, EventArgs e)
        {
            client = new ServiceReference1.Service1Client();
        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            if (client.addUser(email.Value, fname.Value, lname.Value, password.Value,"student"))
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                
                email.Value = "error";
            }
        }
    }
}