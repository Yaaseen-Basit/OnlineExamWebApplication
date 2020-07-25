<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ReviewExam.aspx.cs" Inherits="ReviewExam" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  <h2>Review Exams</h2>
    <p>
        <asp:Button ID="Button1" runat="server" BackColor="Blue" ForeColor="White" 
            Height="22px" onclick="Button1_Click" Text="Show Review" Width="124px" />
    </p>
    <p>
        <asp:GridView ID="GridView1" runat="server" Width="553px">
        </asp:GridView>
    </p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>



</asp:Content>

