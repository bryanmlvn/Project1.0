<%@ Page Title="" Language="C#" MasterPageFile="~/View/Master.Master" AutoEventWireup="true" CodeBehind="History.aspx.cs" Inherits="Project1._0.View.History" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>HISTORY</h1>
    <asp:GridView ID="gvHistory" runat="server" OnSelectedIndexChanged="gvHistory_SelectedIndexChanged">
        <Columns>
            <asp:CommandField ButtonType="Button" HeaderText="Actions" ShowHeader="True" ShowSelectButton="True" />
        </Columns>
    </asp:GridView>
</asp:Content>
