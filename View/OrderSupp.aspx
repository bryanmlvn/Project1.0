<%@ Page Title="" Language="C#" MasterPageFile="~/View/Master.Master" AutoEventWireup="true" CodeBehind="OrderSupp.aspx.cs" Inherits="Project1._0.View.OrderSupp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>ORDER SUPPLEMENT</h1>
    <asp:GridView ID="gvSupplements" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="gvSupplement_SelectedIndexChanged" OnRowCommand="gvSupplement_RowCommand">
        <Columns>
            <asp:BoundField DataField="SupplementID" HeaderText="ID" SortExpression="SupplementID" />
            <asp:BoundField DataField="SupplementName" HeaderText="Name" SortExpression="SupplementName" />
            <asp:BoundField DataField="SupplementExpiryDate" HeaderText="Expiry Date" SortExpression="SupplementExpiryDate" />
            <asp:BoundField DataField="SupplementPrice" HeaderText="Price" SortExpression="SupplementPrice" />
            <asp:BoundField DataField="SupplementTypeID" HeaderText="TypeID" SortExpression="SupplementTypeID" />
            
            <asp:TemplateField HeaderText="Quantity">
                <ItemTemplate>
                    <asp:TextBox ID="txtQuantity" runat="server" Text="0"></asp:TextBox>
                </ItemTemplate>

            </asp:TemplateField>
            
            <asp:ButtonField Text="Order" CommandName="Order" ButtonType="Button" />
        </Columns>
    </asp:GridView>

    <h2>CART</h2>
    <asp:GridView ID="gvCart" runat="server"></asp:GridView>
    <div>
        <asp:Button ID="btnClearCart" runat="server" Text="Clear Cart" OnClick="btnClearCart_Click" />
        <asp:Button ID="btnCheckout" runat="server" Text="Checkout" OnClick="btnCheckout_Click" />
    </div>
</asp:Content>
