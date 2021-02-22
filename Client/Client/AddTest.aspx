<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddTest.aspx.cs" Inherits="Client.AddTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Create Test</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css"/>
  
</head>
<body>
    <nav class="navbar navbar-expand-sm navbar-toggleable-sm navbar-dark bg-dark border-bottom box-shadow mb-3">
            <div class="container">
                <a class="navbar-brand" href="homepage.aspx">CLASSROOM</a>
                <button class="navbar-toggler" type="button" data-toggle="collapse" data-target=".navbar-collapse" aria-controls="navbarSupportedContent"
                        aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>
                <div class="navbar-collapse collapse d-sm-inline-flex flex-sm-row-reverse">
                    
                    <ul class="navbar-nav flex-grow-1">
                        <li class="nav-item">
                            <a class="nav-link text-white" href="AddTest.aspx">Create Test</a>
                        </li>
                        
                        <li class="nav-item">
                            <a class="nav-link text-white" href="addQue.aspx">Add Questions</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link text-white" href="upload.aspx">Upload Assignments</a>
                        </li>
                    </ul>
                </div>
            </div>
        </nav>
    <div class="container">
        <form id="form1" runat="server">
        <div>
         <div class="p-3 m-lg-5 bg-body rounded">
        <h3>Create Test</h3><br />
        <h5>Due Date <asp:TextBox ID="TextBox1" runat="server" TextMode="DateTimeLocal" CssClass="form-control"></asp:TextBox></h5><br />
        <h5> Number Of Questions <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control"></asp:TextBox> </h5>
        <asp:Button ID="Button1" runat="server" CssClass="btn btn-primary my-3" Text="Create" OnClick="btn_AddQuestion" />
        <br /><br /><br /><br />
        <asp:Label ID="Label1" runat="server" CssClass="alert alert-danger" Text="" Visible="false"></asp:Label>
        </div>
        </div>
    </form>
    </div>
    
</body>
</html>
