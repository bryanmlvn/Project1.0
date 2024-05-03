<%@ Page Title="" Language="C#" MasterPageFile="~/View/Master.Master" AutoEventWireup="true" CodeBehind="TransactionDetails.aspx.cs" Inherits="Project1._0.View.TransactionDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Transaction Detail</h1>
    <div>
        <asp:Label ID="lblSupplementID" runat="server" Text=""></asp:Label>
    </div>
    <div>
        <asp:Label ID="lblSupplementName" runat="server" Text=""></asp:Label>
    </div>
    <div>
        <asp:Label ID="lblQuantity" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
