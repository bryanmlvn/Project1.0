<%@ Page Title="" Language="C#" MasterPageFile="~/View/Master.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Project1._0.View.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>REGISTER</h1>
    <div>
        <asp:TextBox ID="tbUsername" runat="server" placeholder="Username"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="uname Can't Empty" ControlToValidate="tbUsername"></asp:RequiredFieldValidator>
        <asp:Label ID="lblErrorUsername" runat="server" Text=""></asp:Label>
    </div>
    <div>
        <asp:TextBox ID="tbEmail" placeholder="Email" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="email can't empty" ControlToValidate="tbEmail"></asp:RequiredFieldValidator>
        <asp:Label ID="lblErrorEmail" runat="server" Text=""></asp:Label>
    </div>
    <div>
        <asp:RadioButton ID="rbMale" runat="server" Text="Male" GroupName="genderGroup" />
        <asp:RadioButton ID="rbFemale" runat="server" Text="Female" GroupName="genderGroup" />
        <asp:Label ID="lblErrorGender" runat="server" Text=""></asp:Label>
    </div>
    <div>
        <asp:TextBox ID="tbPassword" placeholder="Password" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="tbPassword"></asp:RequiredFieldValidator>
        <asp:Label ID="lblErrorPassword" runat="server" Text=""></asp:Label>
    </div>
    <div>
        <asp:TextBox ID="tbConfirmPassword" placeholder="Confirm Password" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="tbConfirmPassword"></asp:RequiredFieldValidator>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="CompareValidator" ControlToValidate="tbConfirmPassword" ControlToCompare="tbPassword"></asp:CompareValidator>
    </div>
    <div>
        <asp:TextBox ID="tbDOB" placeholder="Date of Birth" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="tbDOB" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
    </div>
    <div>
        <asp:Button ID="btnRegister" OnClick="btnRegister_Click" runat="server" Text="Button" />
    </div>
</asp:Content>
