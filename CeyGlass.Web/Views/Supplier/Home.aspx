<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="CeyGlass.Web.Views.Supplier.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Supplier Portal</title>
    <style>
        #main {
            position: fixed;
            top: 50%;
            left: 50%;
            width: 50%;
            height: 50%;
            margin: -15% 0 0 -15%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="main">
            <asp:GridView ID="GridViewPendingPO" runat="server">
                <Columns>
                    <asp:BoundField DataField="ReferenceNumber" HeaderText="System Reference" />
                    <asp:BoundField DataField="ManualNumber" HeaderText="Reference Number" />
                    <asp:BoundField DataField="TxnDate" HeaderText="Date" DataFormatString="{0:d}" />
                    <asp:BoundField DataField="LocationName" HeaderText="Delivery Location" />
                    <asp:BoundField DataField="ItemName" HeaderText="Item" />
                    <asp:BoundField DataField="Quantity" HeaderText="Quantity" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
