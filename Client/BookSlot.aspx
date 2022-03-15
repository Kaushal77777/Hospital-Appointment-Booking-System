<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BookSlot.aspx.cs" Inherits="Client.BookSlot" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"/>
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

        <header class="jumbotron" style="background-color:#cc3399;">
            <h1 class="text-center display-3" id="title"> Remarkable medicine Remarkable care </h1>
            <div class="container">
                <p id="description" class="lead text-center">
                    Sigma Hospital </p>
            </div>
        </header>

        <div class="container">

                <h2 class="display-5"> Booking Info </h2>
                <!-- TEXTB0X: CITY -->
                <%--<div class="form-group d-flex">
                    <asp:TextBox ID="city" runat="server" CssClass="form-control" placeholder="City"></asp:TextBox>
                </div>--%>

            <asp:Label ID="errlogin" runat="server" Text="" ForeColor="Red"></asp:Label><br />
            <label for="dropdown_time">City</label>
            <div class="form-group d-flex">
                <asp:DropDownList ID="dropdown_city" CssClass="form-control col-sm-4" runat="server">
                    <asp:ListItem Selected="True">Rajkot</asp:ListItem>
                    <asp:ListItem>Vadodara</asp:ListItem>
                    <asp:ListItem>Surat</asp:ListItem>
                    <asp:ListItem>Ahmedabad</asp:ListItem>
                    <asp:ListItem>Gandhinagar</asp:ListItem>
                </asp:DropDownList>
            </div>



            <!-- TEXTB0X: SLOT TIME -->
            <label for="dropdown_time">Slot Time</label>
            <div class="form-group d-flex">
                <asp:DropDownList ID="dropdown_time" CssClass="form-control col-sm-4" runat="server">
                    <asp:ListItem>09:00AM - 10:00AM</asp:ListItem>
                    <asp:ListItem>10:00AM - 11:00AM</asp:ListItem>
                    <asp:ListItem>11:00AM - 12:00PM</asp:ListItem>
                </asp:DropDownList>
            </div>

            <asp:Button ID="Button1" runat="server" Text="Book" CssClass="btn btn-primary mb-5" OnClick="Button1_Click"/>

       </div>

    </form>
</body>
</html>
