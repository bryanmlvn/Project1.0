<%@ Page Title="" Language="C#" MasterPageFile="~/View/Master.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="Project1._0.View.Profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Profile</h1>
    <h2>Information</h2>
    <div>
        <asp:TextBox ID="tbUsername" placeholder="Username" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="tbUsername" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
        <asp:Label ID="lblErrorUsername" runat="server" Text=""></asp:Label>
    </div>
    <div>
        <asp:TextBox ID="tbEmail" placeholder="Email" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="tbEmail" runat="server" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
        <asp:Label ID="lblErrorEmail" runat="server" Text=""></asp:Label>
    </div>
    <div>
        <asp:RadioButton ID="rbMale" Text="Male" GroupName="genderGroup" runat="server" />
        <asp:RadioButton ID="rbFemale" Text="Female" GroupName="genderGroup" runat="server" />
        <asp:Label ID="lblErrorGender" runat="server" Text=""></asp:Label>
    </div>
    <div>
        <asp:TextBox ID="tbDOB" placeholder="Date of Birth" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="tbDOB" runat="server" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
    </div>
    <div>
        <asp:Button ID="btnUpdate" runat="server" Text="Update Profile" OnClick="btnUpdate_Click" />
        <asp:Label ID="lblUpdateStatus" runat="server" Text=""></asp:Label>
    </div>
    <h2>Password</h2>
    <div>
        <asp:TextBox ID="tbOldPassword" placeholder="Old Password" runat="server"></asp:TextBox>
        
        <asp:Label ID="lblErrorOldPassword" runat="server" Text=""></asp:Label>
    </div>
    <div>
        <asp:TextBox ID="tbNewPassword" placeholder="New Password" runat="server"></asp:TextBox>
       
        <asp:Label ID="lblErrorNewPassword" runat="server" Text=""></asp:Label>
    </div>
    <div>
        <asp:Button ID="btnUpdatePassword" runat="server" Text="Update Password" OnClick="btnUpdatePassword_Click" />
        <asp:Label ID="lblUpdatePassword" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
