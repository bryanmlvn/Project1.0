<%@ Page Title="" Language="C#" MasterPageFile="~/View/Master.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Project1._0.View.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>HOME</h1>
    <div>
        <asp:Label ID="lblRole" runat="server" Text=""></asp:Label>
    </div>
    <asp:GridView ID="gvUser" runat="server"></asp:GridView>

</asp:Content>
