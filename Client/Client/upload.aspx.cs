using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Client
{
    public partial class upload : System.Web.UI.Page
    {
        ServiceReference3.Service1Client client= new ServiceReference3.Service1Client();
        string fileId = string.Empty;
        //string path = "D:\c#codes\Client\Client\assets\files";
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnUpload_Click(object sender, EventArgs e)
        {
            string imagefile = Path.GetFileName(FileUpload1.PostedFile.FileName);
            FileUpload1.SaveAs(@"D:\c#codes\Client\Client\assets\files" + imagefile);
            //fileId = client.Upload(new MemoryStream(FileUpload1.FileBytes));
            //Session["fileID"] = fileId;

        }
        protected void btnDownload_Click(object sender, EventArgs e)
        {
            Stream stream = client.Download((String)Session["fileID"]);
            StreamReader reader = new StreamReader(stream);
            TextBox1.Text = reader.ReadToEnd();
        }

    }
}