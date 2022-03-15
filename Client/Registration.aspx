<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="Client.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css">
</head>
<body>
    <form id="form1" runat="server">
        
        <nav class="navbar navbar-expand-lg navbar-dark bg-dark sticky-top">
        <!-- Navbar content -->
              <a class="navbar-brand text-warning">∫𝒾ɠ𝓂σ</a>
              <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
              </button>
              <div class="collapse navbar-collapse" id="navbarNav">
                <ul class="navbar-nav">   
                  <li class="nav-item">
                    <asp:HyperLink ID="loginlink" runat="server" CssClass="nav-link" NavigateUrl="~/Login.aspx">Login</asp:HyperLink>
                  </li>
                  <li class="nav-item">
                    <asp:HyperLink ID="registrationlink" runat="server" CssClass="nav-link" NavigateUrl="~/Registration.aspx">Registration</asp:HyperLink>
                  </li>
                  <li class="nav-item">
                    <asp:HyperLink ID="bookinglink" runat="server" CssClass="nav-link" NavigateUrl="~/BookSlot.aspx">Book Your Slot</asp:HyperLink>
                  </li>
                  <li class="nav-item">
                    <asp:HyperLink ID="checkstatuslink" runat="server" CssClass="nav-link" NavigateUrl="~/Status.aspx">Check Status</asp:HyperLink>
                  </li>
                </ul>
              </div>
            <asp:Label ID="navuser" runat="server" Text="" CssClass="text-warning mr-5"></asp:Label>
            <asp:Button ID="logoutbutton" CausesValidation="False" runat="server" Text="LogOut" CssClass="btn btn-outline-success my-2 my-sm-0" OnClick="logoutbutton_Click"/>
        </nav>

        <header class="jumbotron" style="background-color:dodgerblue;">
            <h1 class="text-center display-3" id="title"> Because Your Life Matters </h1>
            <div class="container">
                <p id="description" class="lead text-center">
                    Sigma Hospital </p>
            </div>
        </header>

        <div class="container">

            <h2 class="display-5"> Registration Info </h2>
            <br />
            <asp:Label ID="errmsg" runat="server" Text="" ForeColor="Red"></asp:Label>
            <br />
            <!-- TEXTB0X: FIRST NAME -->
            <div class="form-group d-flex">
                <asp:TextBox ID="name" runat="server" CssClass="form-control" placeholder="Full name"></asp:TextBox>
            </div>

            
            <!-- TEXTB0X: EMAIL -->
            <div class="form-group d-flex">
                <asp:TextBox ID="email" runat="server" CssClass="form-control" placeholder="Email"></asp:TextBox>
            </div>

            <!-- TEXTB0X: Phone Number -->
            <div class="form-group d-flex">
                <%--<input class="form-control" type="text" id="adhar" placeholder="Adhar Number">--%>
                <asp:TextBox ID="contact" runat="server" CssClass="form-control" placeholder="Phone Number"></asp:TextBox>
            </div>

            <!-- TEXTB0X: Password -->
            <div class="form-group d-flex">
                <asp:TextBox ID="password" type="password" runat="server" CssClass="form-control" placeholder="Password"></asp:TextBox>
            </div>
            </br>
            <!-- BUTTON: SUBMIT -->
            <asp:Button ID="Button1" runat="server" Text="Register" CssClass="btn btn-primary mb-5" OnClick="Button1_Click"/>


        </div>

    </form>
</body>
</html>
