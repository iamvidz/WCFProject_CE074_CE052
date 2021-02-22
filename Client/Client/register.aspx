﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="Client.register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8"/>
  <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
  <meta http-equiv="X-UA-Compatible" content="ie=edge"/>
  <title>Register</title>
  <link href="https://fonts.googleapis.com/css?family=Karla:400,700&display=swap" rel="stylesheet"/>
  <link rel="stylesheet" href="https://cdn.materialdesignicons.com/4.8.95/css/materialdesignicons.min.css"/>
  <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css"/>
  <link rel="stylesheet" href="assets/css/login.css"/>
</head>
<body>
    
    <main class="d-flex align-items-center min-vh-100 py-3 py-md-0">
    <div class="container">
      <div class="card login-card">
        <div class="row no-gutters">
          <div class="col-md-5">
            <img src="assets/images/login.jpg" alt="login" class="login-card-img"/>
          </div>
          <div class="col-md-7">
            <div class="card-body">
              <div class="brand-wrapper">
                <img src="assets/images/logo.svg" alt="logo" class="logo"/>
              </div>
              <p class="login-card-description">Create a new account</p>
              <form action="#!" runat="server" id="form1">
                  <div class="form-group">
                      <label for="firstname" class="sr-only">FirstName</label>
            <input type="text" name="fname" id="fname" required runat="server" class="form-control" placeholder="First Name" >
            
                  </div>
                  <div class="form-group">
                      <label for="lastname" class="sr-only">LastName</label>
            <input type="text" name="lname" id="lname" required runat="server" class="form-control" placeholder="Last Name" >
            
                  </div>
                  <div class="form-group">
                    <label for="email" class="sr-only">Email</label>
                    <input type="email" name="email" required id="email" class="form-control" runat="server" placeholder="Email address"/>
                  </div>
                  <div class="form-group mb-4">
                    <label for="password" class="sr-only">Password</label>
                    <input type="password" name="password" required id="password" runat="server" class="form-control" placeholder="Password">
                  </div>
                  <div class="form-group mb-4">
                    <label for="password" class="sr-only">Confirm password</label>
                    <input type="password" name="repassword" required id="repassword" runat="server" class="form-control" placeholder="Confirm password">
                  </div>
                  <asp:Button ID="btn1" OnClick="btn1_Click" CssClass="btn btn-block login-btn mb-4" runat="server" Text="Register"/>
                  </form>
                <p class="login-card-footer-text">Already have an account? <a href="#!" class="text-reset">Log in</a></p>
                <nav class="login-card-footer-nav">
                  <a href="#!">Terms of use.</a>
                  <a href="#!">Privacy policy</a>
                </nav>
            </div>
          </div>
        </div>
      </div>
      
    </div>
  </main>
  <script src="https://code.jquery.com/jquery-3.4.1.min.js"></script>
  <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js"></script>
  <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"></script>

</body>
</html>
