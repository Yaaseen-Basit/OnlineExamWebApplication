<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Mocktest.aspx.cs" Inherits="Default4" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <br />
    </p>
    <p>
        &nbsp;</p>
    
        <table style="width:100%;">
            <tr>
                <td style="width: 504px">
                    &nbsp;</td>
                <td style="width: 695px">
                    &nbsp;</td>
                <td style="width: 467px">
                    <asp:Button ID="Score" runat="server" Text="Button" Width="155px" 
                        Visible="False" />
                    Total Marks:<asp:Label ID="Label8" runat="server" Text="25"></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 504px">
                    &nbsp;</td>
                <td style="width: 695px">
                    &nbsp;</td>
                <td style="width: 467px">
                    <asp:Label ID="Label11" runat="server" Text="Start Time:"></asp:Label>
                    <asp:Label ID="Label12" runat="server"></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 504px">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    Exam Name</td>
                <td style="width: 695px">
                    <asp:TextBox ID="TextBox2" runat="server" Width="263px" ForeColor="Red">Mock Test for Aptitude</asp:TextBox>
                </td>
                <td style="width: 467px">
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
                            <asp:ScriptManager ID="ScriptManager1" runat="server">
                            </asp:ScriptManager>
                            <asp:Timer ID="Timer1" runat="server" Enabled="False" Interval="1000" 
                                ontick="Timer1_Tick">
                            </asp:Timer>
                            <asp:Label ID="Label4" runat="server" Text="Current Time in Seconds:"></asp:Label>
                            <asp:HiddenField ID="HiddenField1" runat="server" 
                                onvaluechanged="HiddenField1_ValueChanged" Value="0" />
                            <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
                            <br />
                            <asp:Label ID="Label9" runat="server" Text="Current Time:"></asp:Label>
                            <asp:Label ID="Label10" runat="server" Text="Label"></asp:Label>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </td>
                <td>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 504px">
                    </td>
                <td style="width: 695px">
                    </td>
                <td style="width: 467px">
                    <asp:Label ID="Label7" runat="server" Text="Total Time in Seconds: "></asp:Label>
                    <asp:Label ID="Label6" runat="server" Text="1800"></asp:Label>
                </td>
                <td>
                    </td>
                <td>
                    </td>
            </tr>
            <tr>
                <td style="width: 504px">
&nbsp;&nbsp;&nbsp; No of Questions</td>
                <td style="width: 695px">
                    <asp:TextBox ID="TextBox3" runat="server">25</asp:TextBox>
                </td>
                <td style="width: 467px">
                    <asp:HiddenField ID="HiddenField3" runat="server" Value="0" />
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 504px">
                    &nbsp;</td>
                <td style="width: 695px">
                    &nbsp;</td>
                <td style="width: 467px">
                    <asp:Button ID="Button3" runat="server" BackColor="Blue" ForeColor="White" 
                        onclick="Button1_Click1" Text="Start Exam" />
                    <asp:HiddenField ID="HiddenField2" runat="server" 
                        onvaluechanged="HiddenField2_ValueChanged" Value="0" />
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    
    
        <table style="width: 70%;">
            <tr>
                <td style="width: 146px">
                    &nbsp;</td>
                <td style="width: 370px" colspan="3">
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 146px">
                    &nbsp;</td>
                <td style="width: 370px" colspan="3">
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 146px">
                    &nbsp;</td>
                <td style="width: 370px" colspan="3">
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 146px">
                    <asp:Label ID="Label2" runat="server" Text="Qno"></asp:Label>
                </td>
                <td style="width: 370px" colspan="3">
                    <asp:TextBox ID="Qno" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 146px">
                    &nbsp;</td>
                <td style="width: 370px" colspan="3">
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 146px">
                    <asp:Label ID="Label3" runat="server" Text="Question:"></asp:Label>
                </td>
                <td style="width: 370px" colspan="3">
                    <asp:TextBox ID="Qs" runat="server" Height="56px" Width="534px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 146px">
                    &nbsp;</td>
                <td style="width: 370px" colspan="3">
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 146px">
                    &nbsp;</td>
                <td style="width: 370px" colspan="3">
                    <asp:CheckBox ID="C1" runat="server" />
                </td>
            </tr>
            <tr>
                <td style="width: 146px">
                    &nbsp;</td>
                <td style="width: 370px" colspan="3">
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 146px">
                    &nbsp;</td>
                <td style="width: 370px" colspan="3">
                    <asp:CheckBox ID="C2" runat="server" />
                </td>
            </tr>
            <tr>
                <td style="width: 146px">
                    &nbsp;</td>
                <td style="width: 370px" colspan="3">
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 146px">
                    &nbsp;</td>
                <td style="width: 370px" colspan="3">
                    <asp:CheckBox ID="C3" runat="server" />
                </td>
            </tr>
            <tr>
                <td style="width: 146px">
                    &nbsp;</td>
                <td style="width: 370px" colspan="3">
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 146px">
                    &nbsp;</td>
                <td style="width: 370px" colspan="3">
                    <asp:CheckBox ID="C4" runat="server" />
                </td>
            </tr>
            <tr>
                <td style="width: 146px">
                    &nbsp;</td>
                <td style="width: 370px" colspan="3">
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 146px">
                    &nbsp;</td>
                <td style="width: 370px" colspan="3">
                    <asp:Label ID="Cans" runat="server" Text="Label" Visible="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="width: 146px">
                    &nbsp;</td>
                <td style="width: 370px" colspan="3">
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 146px">
                    &nbsp;</td>
                <td style="width: 370px">
                    &nbsp;</td>
                <td style="width: 370px">
                    <asp:Button ID="Button1" runat="server" BackColor="Blue" ForeColor="White" 
                        Height="33px" Text=" Next" Width="111px" 
                        onclick="Button1_Click" />
                    </td>
                <td style="width: 370px">
                    <asp:Button ID="Button2" runat="server" BackColor="Blue" ForeColor="White" 
                        Height="30px" Text="End Exam" Width="78px" onclick="Button2_Click" />
                    </td>
            </tr>
        </table>
    
    <p>
        &nbsp;</p>
    
        <table style="width:100%;">
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
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

