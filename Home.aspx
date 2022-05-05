<%@ Page Title="" Language="C#" MasterPageFile="~/Appart.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Apartment_Manager.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="csshome.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="bod">
     <ul class="navbar-nav">
     <li class="nav-item active">
         <asp:LinkButton class="bod-link" ID="register" runat="server" OnClick="LinkButton1_Click">Register</asp:LinkButton>

     </li>
   </ul>
        <p>
            &nbsp;</p>
        <ul class="navbar-nav">
     <li class="nav-item active">
     <asp:LinkButton class="bod-link" ID="login" runat="server" OnClick="LinkButton5_Click">Sign In</asp:LinkButton>

     </li>
   </ul>
        </div>
</asp:Content>
