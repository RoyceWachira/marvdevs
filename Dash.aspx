<%@ Page Title="" Language="C#" MasterPageFile="~/Appart.Master" AutoEventWireup="true" CodeBehind="Dash.aspx.cs" Inherits="Apartment_Manager.Dash" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="dash.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div id="logout" style="float:right;"><asp:Button ID="btnLogout" runat="server" Text="Log Out" class="btn btn-primary btn-block me-3 mr-3 btn1" OnClick="btnLogOut_Click" /></div>
      <div class="flex-container">
        <div class="flex-item" style="background:url(./img/1.jpg);" >
            <asp:Label runat="server" ID="lblNoTenants"/>
            <h6>Hello Tenant</h6>
        </div>
        <div class="flex-item" style="background:url(./img/2.jpg);">
            <asp:Label Text="" runat="server" ID="lblNoLandlords"/>
            <h6>Number of Landlords</h6>
        </div>
        <div class="flex-item"  style="background:url(./img/3.jpg);">
            <asp:Label Text="" runat="server" ID="lblNoHouses"/>
            <h6>Total Houses Occupied</h6>
        </div>
    </div>
    <hr />
    <div class="search-form">
        <asp:TextBox runat="server" Text="Search TenantbyId..."  ID="txtSearch"></asp:TextBox>
        <asp:Button Text="Search" runat="server" ID="btnSearch"/>
        
       
    </div>
     <div class="form-group">
                <asp:Button ID="btnProfile" runat="server" Text="View Profile" class="btn btn-primary btn-block me-3 mr-3 btn1" OnClick="btnProfile_Click" />
                <br />
                <br />
                <br />
            </div>


     <div class="form-group">
                <asp:Button ID="btnpay" runat="server" Text="Make Payment" class="btn btn-primary btn-block me-3 mr-3 btn1" OnClick="btnpay_Click" />
            </div>
    <hr />
 
             
    <br />
   <asp:GridView ID="TenantDetails" runat="server" ShowHeader="true"  DataKeyNames="Id" CellPadding="4" ForeColor="#333333" GridLines="None"  AutoGenerateColumns="false" Width="1348px" >
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />

        <Columns>
            <asp:TemplateField HeaderText="Tenant ID">
                <ItemTemplate>
                    <asp:Label runat="server" Text='<%# Eval("Id") %>' ID="txtID"/>                 
                 </ItemTemplate>
                <EditItemTemplate>
                    <asp:Label runat="server" Text='<%# Eval("Id") %>' ID="txtID"/>
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:Label runat="server"  ID="txtTenantIDFooter"/>
                </FooterTemplate>
             </asp:TemplateField>
            <asp:TemplateField HeaderText="Name">
                <ItemTemplate>
                    <asp:Label Text='<%# Eval("Name") %>' runat="server" />
                 </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox runat="server" Text='<%# Eval("Name") %>' ID="txtName"/>
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:TextBox runat="server"  ID="txtNameFooter"/>
                </FooterTemplate>
             </asp:TemplateField>
            <asp:TemplateField HeaderText="Email">
                 <ItemTemplate>
                    <asp:Label Text='<%# Eval("Email") %>' runat="server" />
                 </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox runat="server" Text='<%# Eval("Email") %>' ID="txtMail"/>
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:TextBox runat="server"  ID="txtMailFooter"/>
                </FooterTemplate>
             </asp:TemplateField>
            <asp:TemplateField HeaderText="MobileNumber">
                 <ItemTemplate>
                    <asp:Label Text='<%# Eval("MobileNumber") %>' runat="server" />
                 </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox runat="server" Text='<%# Eval("MobileNumber") %>' ID="txtNumber"/>
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:TextBox runat="server"  ID="txtNumberFooter"/>
                </FooterTemplate>
             </asp:TemplateField>
            <asp:TemplateField HeaderText="House Number">
                <ItemTemplate>
                    <asp:Label Text='<%# Eval("hnumber") %>' runat="server" />
                 </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox runat="server" Text='<%# Eval("hnumber") %>' ID="txthnumber"/>
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:TextBox runat="server"  ID="txthnumberFooter"/>
                </FooterTemplate>
             </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <br />

</asp:Content>
