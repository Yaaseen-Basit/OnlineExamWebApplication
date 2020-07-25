<%@ Page Title="" Language="C#" MasterPageFile="~/Admin MasterPage.master" AutoEventWireup="true" CodeFile="ADMIN.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h2>
            View ADMIN Profile</h2>
<p>
    &nbsp;</p>
<p>
    <asp:Button ID="Button1" runat="server" BackColor="#3333CC" ForeColor="White" 
        onclick="Button1_Click" Text="View Profile" Width="231px" Height="31px" />
</p>
<p>
    <br />
    <asp:GridView ID="GridView1" runat="server" Width="630px">
    </asp:GridView>
</p>
</asp:Content>

