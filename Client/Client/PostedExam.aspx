<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PostedExam.aspx.cs" Inherits="Client.PostedExam" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Test</title>
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
        
            <asp:Label ID="Label3" runat="server" CssClass="form-group display-4" Text="" Visible="false"></asp:Label>
    
            <div class="form-control">
                <asp:Label ID="Label1" runat="server" Text="Question 1" CssClass="m-2"></asp:Label>
               <br /> 
               <br />
                <asp:Label ID="Label4" runat="server" Text="WCF stands for" CssClass="my-lg-3"></asp:Label>
                <br />

                    <asp:Label ID="Label5" runat="server" Text="1. Windows Connection Framework" CssClass="my-lg-3"></asp:Label>
                <br />
                <asp:Label ID="Label6" runat="server" Text="2. Windows Common Framework" CssClass="my-lg-3"></asp:Label>
                <br />
                <asp:Label ID="Label7" runat="server" Text="3. Windows Communication Foundation" CssClass="my-lg-3"></asp:Label>
                <br />
                <asp:Label ID="Label8" runat="server" Text="4. Windows Communication Framework" CssClass="my-lg-3"></asp:Label>
                <br />
                <asp:TextBox ID="TextBox1" runat="server" CssClass="my-lg-5"></asp:TextBox>
                

            </div>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
            <div class="my-lg-5 form-control">
                <asp:Label ID="Label2" runat="server" Text="Question 2" CssClass="my-lg-5"></asp:Label>
                
                <br /> 
                <asp:Label ID="Label9" runat="server" Text="WCF is developed by"  CssClass="my-lg-5"></asp:Label>
                <br />
                <asp:Label ID="Label10" runat="server" Text="1. Oracle Corporation" CssClass="my-lg-5"></asp:Label>
                
                <br /> 
                <asp:Label ID="Label11" runat="server" Text="2. Microsoft Corporation" CssClass="my-lg-5"></asp:Label>
                <br /> 
                <asp:Label ID="Label12" runat="server" Text="3. Jeev Surakhi" CssClass="my-lg-5"></asp:Label>
                <br />
                <asp:Label ID="Label13" runat="server" Text="4. NET Foundation" CssClass="my-lg-5"></asp:Label>
                <br />
                <asp:TextBox ID="TextBox2" runat="server" CssClass="my-lg-5"></asp:TextBox>


            </div>
         <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Submit" CssClass="btn btn-danger my-lg-5" OnClick="btn1"/>
    </form>
    </div>
</body>
</html>
