<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
    <br />
      <p class="font2">
            &nbsp;&nbsp;&nbsp;
            Welcome Candidate Maria.</p>
    <p class="font2">
            &nbsp;&nbsp;&nbsp;&nbsp; To give exams Read the Following instructions&nbsp; and click the 
            Take Exam button below.</p><table style="width:100%;">
        <tr>
            <td style="height: 52px">
                </td>
                 
            
            <td style="width: 150px; height: 52px;">
            </td>
            <td style="height: 52px">
                <asp:Button ID="Button2" runat="server" BackColor="Blue" ForeColor="White" 
                    Height="44px" Text="Log Out" Width="106px" />
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td style="width: 534px">
                <asp:Button ID="Button1" runat="server" BackColor="#0033CC" ForeColor="White" 
                    onclick="Button1_Click" Text="take exam" Height="53px" />
            </td>
            <td style="width: 150px">
                <asp:LinkButton ID="LinkButton2" runat="server">Forgot Password</asp:LinkButton>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td style="width: 534px">
                &nbsp;</td>
            <td style="width: 150px">
                <asp:LinkButton ID="LinkButton1" runat="server">Change Password</asp:LinkButton>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td style="width: 534px">
                <span lang="EN-US">All the questions will have multiple choices.</span></td>
            <td style="width: 150px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td style="width: 534px">
                &nbsp;</td>
            <td style="width: 150px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td style="width: 534px">
                <span lang="EN-US">Out of the four answers to a question only one will be the 
                correct answer. </span></td>
            <td style="width: 150px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td style="width: 534px">
                <span lang="EN-US">You have to select the most appropriate answer and ‘mouse 
                click’ that alternative which you feel is appropriate/ correct</span></td>
            <td style="width: 150px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td style="width: 534px">
                &nbsp;</td>
            <td style="width: 150px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td style="width: 534px">
                <span lang="EN-US">The alternative/option that you have clicked on will be 
                highlighted and will be treated as your answer to that question</span></td>
            <td style="width: 150px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td style="width: 534px">
                <p class="MsoNormal">
                    <span lang="EN-US">The clock has been set at the server and the countdown timer 
                    at the top right corner of your screen will display the time remaining for you 
                    to complete the exam. When the clock runs out the exam ends by default - you 
                    arenot required to end or submit your exam.<o:p></o:p></span></p>
            </td>
            <td style="width: 150px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td style="width: 534px">
                <p class="MsoNormal">
                    <span lang="EN-US">The question palette at the right of screen shows one of the 
                    following statuses of each of the questions numbered:</span></p>
                <p class="MsoNormal">
                    <span lang="EN-US">You have not visited the question yet displayed with Blue 
                    Color.</span></p>
                <span lang="EN-US">You have answered the question&nbsp; displayed with Orange 
                Color.</span></td>
            <td style="width: 150px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
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

