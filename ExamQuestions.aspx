<%@ Page Title="" Language="C#" MasterPageFile="~/Admin MasterPage.master" AutoEventWireup="true" CodeFile="ExamQuestions.aspx.cs" Inherits="ExamQuestions" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
    <br />
</p>
    <p>
    <br />
</p>
<p>
    <br />
</p> <h2>
            Welcome Admin</h2>

    <table>
        <tr>
            <td style="width: 134px">
                &nbsp;</td>
            <td style="width: 18px" colspan="2">
                &nbsp;</td>
            <td style="width: 9px" colspan="2">
                <asp:Button ID="Button6" runat="server" BackColor="Blue" ForeColor="White" 
                    onclick="Button6_Click" Text="Add Questions" Height="31px" />
            </td>
            <td>
                &nbsp;</td>
            <td style="width: 158px">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 134px">
                &nbsp;</td>
            <td style="width: 18px" colspan="2">
                &nbsp;</td>
            <td style="width: 9px" colspan="2">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td style="width: 158px">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 134px">
                &nbsp;</td>
            <td style="width: 18px">
                &nbsp;</td>
            <td style="width: 18px">
                <asp:Label ID="Label2" runat="server" Text="QNo"></asp:Label>
            </td>
            <td style="width: 9px" colspan="2">
                <asp:TextBox ID="Qno" runat="server" Height="31px" style="margin-left: 6px" 
                    Width="149px" BorderColor="#3399FF" BorderStyle="Solid"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
            <td style="width: 158px">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 134px">
                &nbsp;</td>
            <td style="width: 18px" colspan="2">
                &nbsp;</td>
            <td style="width: 9px" colspan="2">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td style="width: 158px">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 134px">
                &nbsp;</td>
            <td style="width: 18px">
                &nbsp;</td>
            <td style="width: 18px">
                <asp:Label ID="Label3" runat="server" Text="Question"></asp:Label>
            </td>
            <td style="width: 9px" colspan="2">
                <asp:TextBox ID="Qs" runat="server" Height="79px" style="margin-left: 6px" 
                    Width="421px" BorderColor="#6699FF" BorderStyle="Solid"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
            <td style="width: 158px">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 134px">
                &nbsp;</td>
            <td style="width: 18px" colspan="2">
                &nbsp;</td>
            <td style="width: 9px" colspan="2">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td style="width: 158px">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 134px">
                &nbsp;</td>
            <td style="width: 18px">
                &nbsp;</td>
            <td style="width: 18px">
                <asp:Label ID="Label4" runat="server" Text="Choice1"></asp:Label>
            </td>
            <td style="width: 9px" colspan="2">
                <asp:TextBox ID="C1" runat="server" style="margin-left: 0px" Width="442px" 
                    BorderColor="#6699FF" BorderStyle="Solid"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
            <td style="width: 158px">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 134px">
                &nbsp;</td>
            <td style="width: 18px" colspan="2">
                &nbsp;</td>
            <td style="width: 9px" colspan="2">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td style="width: 158px">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 134px">
                &nbsp;</td>
            <td style="width: 18px">
                &nbsp;</td>
            <td style="width: 18px">
                <asp:Label ID="Label5" runat="server" Text="Choice2"></asp:Label>
            </td>
            <td style="width: 9px" colspan="2">
                <asp:TextBox ID="C2" runat="server" style="margin-left: 0px" Width="438px" 
                    BorderColor="#6699FF" BorderStyle="Solid"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
            <td style="width: 158px">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 134px">
                &nbsp;</td>
            <td style="width: 18px" colspan="2">
                &nbsp;</td>
            <td style="width: 9px" colspan="2">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td style="width: 158px">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 134px">
                &nbsp;</td>
            <td style="width: 18px">
                &nbsp;</td>
            <td style="width: 18px">
                <asp:Label ID="Label6" runat="server" Text="Choice3"></asp:Label>
            </td>
            <td style="width: 9px" colspan="2">
                <asp:TextBox ID="C3" runat="server" style="margin-left: 0px" Width="440px" 
                    BorderColor="#6699FF" BorderStyle="Solid"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
            <td style="width: 158px">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 134px">
                &nbsp;</td>
            <td style="width: 18px" colspan="2">
                &nbsp;</td>
            <td style="width: 9px" colspan="2">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td style="width: 158px">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 134px">
                &nbsp;</td>
            <td style="width: 18px">
                &nbsp;</td>
            <td style="width: 18px">
                <asp:Label ID="Label7" runat="server" Text="  Choice4"></asp:Label>
            </td>
            <td style="width: 9px" colspan="2">
                <asp:TextBox ID="C4" runat="server" style="margin-left: 3px" Width="438px" 
                    BorderColor="#6699FF" BorderStyle="Solid"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
            <td style="width: 158px">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 134px">
                &nbsp;</td>
            <td style="width: 18px" colspan="2">
                &nbsp;</td>
            <td style="width: 9px" colspan="2">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td style="width: 158px">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 134px">
                &nbsp;</td>
            <td style="width: 18px" colspan="2">
                &nbsp;</td>
            <td style="width: 9px" colspan="2">
                &nbsp;</td>
            <td>
                <asp:Button ID="Button2" runat="server" BackColor="Blue" ForeColor="White" 
                    Height="39px" onclick="Button2_Click" style="margin-left: 0px" 
                    Text="Change MCQs" Width="96px" />
                </td>
            <td style="width: 158px">
                <asp:TextBox ID="Questno" runat="server" BorderColor="#009900" 
                    BorderStyle="Outset" Height="34px" style="margin-left: 2px" Width="47px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 134px">
                &nbsp;</td>
            <td style="width: 18px">
                &nbsp;</td>
            <td style="width: 18px">
                <asp:Label ID="Label8" runat="server" Text="  Answer"></asp:Label>
            </td>
            <td style="width: 9px" colspan="2">
                <asp:DropDownList ID="Ans" runat="server">
                    <asp:ListItem>a</asp:ListItem>
                    <asp:ListItem>b</asp:ListItem>
                    <asp:ListItem>c</asp:ListItem>
                    <asp:ListItem>d</asp:ListItem>
                    <asp:ListItem>a,b</asp:ListItem>
                    <asp:ListItem>c,d</asp:ListItem>
                    <asp:ListItem>a,c</asp:ListItem>
                    <asp:ListItem>b,d</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                &nbsp;</td>
            <td style="width: 158px">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 134px">
                &nbsp;</td>
            <td style="width: 18px" colspan="2">
                &nbsp;</td>
            <td style="width: 9px" colspan="2">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td style="width: 158px">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 134px">
                &nbsp;</td>
            <td style="width: 18px" colspan="2">
                <asp:Button ID="Button1" runat="server" BackColor="Blue" ForeColor="White" 
                    Height="40px" onclick="Button1_Click" style="margin-left: 98px" 
                    Text="Save MCQs" />
            </td>
            <td style="width: 9px">
                &nbsp;</td>
            <td style="width: 9px">
                <asp:Button ID="Button4" runat="server" BackColor="Blue" ForeColor="White" 
                    Height="41px" onclick="Button4_Click" Text="Clear All" Width="78px" />
            </td>
            <td>
                <asp:Button ID="Button3" runat="server" BackColor="Blue" ForeColor="White" 
                    Height="33px" onclick="Button3_Click" Text=" Delete MCQ" Width="86px" />
            </td>
            <td style="width: 158px">
                <asp:TextBox ID="QnoD" runat="server" BorderColor="#009900" 
                    BorderStyle="Outset" style="margin-left: 4px" Width="51px" Height="32px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 134px">
                &nbsp;</td>
            <td style="width: 18px" colspan="2">
                &nbsp;</td>
            <td style="width: 9px" colspan="2">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td style="width: 158px">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 134px">
                &nbsp;</td>
            <td style="width: 18px">
                &nbsp;</td>
            <td style="width: 18px">
                MessageBox</td>
            <td style="width: 9px" colspan="2">
                <asp:TextBox ID="MSG" runat="server" BorderColor="Blue" BorderStyle="Outset" 
                    style="margin-left: 0px" Width="418px"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
            <td style="width: 158px">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 134px">
                &nbsp;</td>
            <td style="width: 18px" colspan="2">
                &nbsp;</td>
            <td style="width: 9px" colspan="2">
                &nbsp;</td>
            <td>
                <asp:Button ID="Button5" runat="server" BackColor="Blue" ForeColor="White" 
                    Height="33px" onclick="Button3_Click" Text="Show All MCQ" Width="86px" />
            </td>
            <td>
                &nbsp;</td>
            <td style="width: 158px">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 134px">
                &nbsp;</td>
            <td style="width: 18px" colspan="2">
                &nbsp;</td>
            <td style="width: 9px" colspan="2">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
            <td style="width: 158px">
                &nbsp;</td>
        </tr>
    </table>

<p>
    &nbsp;</p>
<p>
    <asp:GridView ID="GridView1" runat="server" Height="654px" Width="891px">
    </asp:GridView>
</p>
<p>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
    &nbsp;</p>
<p>
</p>
<p>
</p>
<p>
</p>
<p>
</p>
<p>
</p>
<p>
</p>
</asp:Content>

