<%@ Page Title="" Language="C#" MasterPageFile="~/Appart.Master" AutoEventWireup="true" CodeBehind="Adminlogin.aspx.cs" Inherits="Apartment_Manager.Adminlogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="admincss.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="login-form">
            <asp:Label ID="lblConfirmLogin" runat="server" Text="Label"></asp:Label>
        <form>
           
            
             
                 <h2 class="text-center">Admin Log in</h2>
            
            <div class="form-group">
                <asp:TextBox ID="txtUsername" runat="server" class="form-control" type="text" placeholder="Username" required="required"></asp:TextBox>
                <br />
            </div>
            <div class="form-group">
                <asp:TextBox ID="txtPassword" runat="server" class="form-control" type="password" placeholder="Password" required="required"></asp:TextBox>
               
            </div>
            <div class="form-group">
                <asp:Button ID="btnAdminlogin" runat="server" Text="Login" class="btn btn-primary btn-block me-3 mr-3 btn1" OnClick="btnAdminlogin_Click" />
            </div>
            <div class="clearfix">
                <a href="#" class="float-left">Forgot Password?</a>
            </div>

        </form>
        </div>
</asp:Content>
