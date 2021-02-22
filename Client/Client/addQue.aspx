<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addQue.aspx.cs" Inherits="Client.addQue" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Create Test</title>
     <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css"/>
  
</head>
<body >
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
    <form id="form1" runat="server" method="post">
    <div class="p-3 mb-5 bg-body rounded">
        <h2>New Exam</h2>        
       
        <div class="container-fluid">
            <div class="row">
                <div class="col-8">
                    <div id="quesContainer" runat="server"></div>
                </div>
            </div>
        </div>
        <div>                       
             <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click"  CssClass="btn btn-primary"/>
   <br/><br/><br/>
        </div>
           
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    </div>
    </form>
    </div>
</body>
</html>

 