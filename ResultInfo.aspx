<%@ Page Title="" Language="C#" MasterPageFile="~/Admin MasterPage.master" AutoEventWireup="true" CodeFile="ResultInfo.aspx.cs" Inherits="ResultInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h2>
           View Candidate Result</h2> <p>
    &nbsp;</p>
<p>
    &nbsp;</p>
<p>
    &nbsp;</p>
<p>
    <br />
    <asp:Button ID="Button1" runat="server" BackColor="#3333CC" ForeColor="White" 
        onclick="Button1_Click" Text="Show Info" Width="231px" />
    <asp:GridView ID="GridView1" runat="server" Width="630px">
    </asp:GridView>
</p>
</asp:Content>

