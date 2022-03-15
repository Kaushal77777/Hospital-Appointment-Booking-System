<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Client.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"/>
    <title></title>
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


        <header class="jumbotron" style="background-color:#33cc33;">
            <h1 class="text-center display-3" id="title"> Nothing is more important than your health </h1>
            <div class="container">
                <p id="description" class="lead text-center">
                    Sigma Hospital </p>
            </div>
        </header>

        <div class="container">
            <h2 class="display-5"> Login Info </h2>
            <asp:Label ID="errmsg" runat="server" CssClass="fw-bold text-danger form-group d-flex"></asp:Label>

            <!-- TEXTB0X: Phone Number -->
            <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator1" Display="Dynamic" runat="server" ErrorMessage="Contact can not be empty" ControlToValidate="contact" ForeColor="Red">Phone no. is required</asp:RequiredFieldValidator>--%>
            <div class="form-group d-flex">
                <asp:TextBox ID="phone" runat="server" CssClass="form-control" placeholder="Phone Number"></asp:TextBox>
            </div>

            <!-- TEXTB0X: Password -->
            <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator2" Display="Dynamic" runat="server" ErrorMessage="Password can not be empty" ControlToValidate="password" ForeColor="Red">Password is required</asp:RequiredFieldValidator>--%>
            <div class="form-group d-flex">
                <asp:TextBox ID="password" type="password" runat="server" CssClass="form-control" placeholder="Password"></asp:TextBox>
            </div>


            <!-- BUTTON: SUBMIT -->
            <%--<asp:Button ID="loginbtn" runat="server" Text="Login" CssClass="btn btn-primary mb-5" OnClick="loginbtn_Click"/>--%>
            <asp:Button ID="Button1" runat="server" Text="Login" CssClass="btn btn-primary mb-5" OnClick="Button1_Click" />
        </div>


    </form>
</body>
</html>
