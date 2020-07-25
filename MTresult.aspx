<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="MTresult.aspx.cs" Inherits="MTresult" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
                  <h2>Mock Test Results</h2>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
   
        <table style="width:100%;">
            <tr>
                <td style="width: 94px">
                    &nbsp;</td>
                <td colspan="2">
                    <asp:TextBox ID="TextBox2" runat="server" Width="263px" ForeColor="Red">RESULT OF Mock Test for Aptitude</asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 94px">
                    &nbsp;</td>
                <td style="width: 307px">
                    <asp:Label ID="Label2" runat="server" Text="Exam Name"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 94px">
                    &nbsp;</td>
                <td colspan="2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 94px">
                    &nbsp;</td>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Total Marks"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 94px">
                    &nbsp;</td>
                <td colspan="2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 94px">
                    &nbsp;</td>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Your Score is"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 94px">
                    &nbsp;</td>
                <td colspan="2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 94px">
                    &nbsp;</td>
                <td colspan="2">
                    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Button" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
   
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>

