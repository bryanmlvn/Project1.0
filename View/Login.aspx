<%@ Page Title="" Language="C#" MasterPageFile="~/View/Master.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Project1._0.View.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>LOGIN</h1>
    <div>
        <asp:TextBox ID="tbUsername" runat="server" placeholder="Username"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="ISI UNAME" ControlToValidate="tbUsername"></asp:RequiredFieldValidator>
    </div>

    <div>
        <asp:TextBox ID="tbPassword" runat="server" placeholder="Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="ISI Password" ControlToValidate="tbPassword"></asp:RequiredFieldValidator>
    </div>
    
    <div>
        <asp:CheckBox ID="cbRemember" runat="server" Text="Remember me" />
    </div>

    <div>
        <asp:Button ID="btnLogin" runat="server" Text="Log in" OnClick="btnLogin_Click" />
    </div>

    <div>
        <asp:Label ID="lblIncorrect" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
