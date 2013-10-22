<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Supplier/AuthenticatedSupplier.Master" AutoEventWireup="true" CodeBehind="PendingPO.aspx.cs" Inherits="CeyGlass.Web.Views.Supplier.PendingPO" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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
</asp:Content>
