<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignIn.aspx.cs" Inherits="CeyGlass.Web.Views.Supplier.SignIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Supplier Portal</title>
    <link href="../../Content/bootstrap.css" rel="stylesheet" type="text/css" />
    <link href="../../Content/signin.css" rel="stylesheet" type="text/css" />
    <%--<style>
        #main {
            position: fixed;
            top: 50%;
            left: 50%;
            width: 50%;
            height: 50%;
            margin: -15% 0 0 -15%;
        }
    </style>--%>
</head>
<body>
    <form id="form1" runat="server" class="form-signin">
        <div id="main" class="container">
            <h2 class="form-signin-heading">Please sign in</h2>
            <asp:TextBox ID="txtUsername" runat="server" CssClass="form-control" />
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="form-control" />
            <asp:Button ID="btnSignIn" Text="Sign In" runat="server" OnClick="btnSignIn_Click"
                CssClass="btn btn-lg btn-primary btn-block" />
            <div id="errorDiv" class="alert alert-danger" runat="server">
                <asp:Label ID="lblError" Text="Invalid Username or Password" runat="server" />
            </div>
        </div>
    </form>
</body>
</html>
