<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="MainExam.aspx.cs" Inherits="Default3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   
   <h2>
            Main Aptitude Exam </h2>
            <p class="font2">
            Click on Start button to give Online Test  .  BEST OF LUCK!! 
          
        </p>
        <table style="width:100%;">
            <tr>
                <td style="width: 504px">
                    <asp:Label ID="Label15" runat="server" Text="CandidateID"></asp:Label>
                </td>
                <td style="width: 695px">
                    <asp:TextBox ID="cid" runat="server" ontextchanged="TextBox1_TextChanged" 
                        Width="283px" ForeColor="#009933"></asp:TextBox>
                </td>
                <td style="width: 467px">
                    &nbsp;</td>
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
                    <asp:HiddenField ID="HiddenField3" runat="server" 
                        onvaluechanged="HiddenField2_ValueChanged" Value="0" />
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 504px">
                    <asp:Label ID="Label1" runat="server" Text="Candidate Full Name"></asp:Label>
                </td>
                <td style="width: 695px">
                    <asp:TextBox ID="TextBox1" runat="server" ontextchanged="TextBox1_TextChanged" 
                        Width="283px" ForeColor="#009933"></asp:TextBox>
                </td>
                <td style="width: 467px">
                    <asp:Button ID="Score" runat="server" Text="Button" Width="155px" 
                        Visible="False" />
                    Total Marks:<asp:Label ID="Label8" runat="server" Text="50"></asp:Label>
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
                    <asp:Label ID="Label14" runat="server" Text="Start Time:"></asp:Label>
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
                    <asp:TextBox ID="TextBox2" runat="server" Width="145px"></asp:TextBox>
                </td>
                <td style="width: 467px">
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
                            <asp:ScriptManager ID="ScriptManager1" runat="server">
                            </asp:ScriptManager>
                            <asp:Timer ID="Timer1" runat="server" Enabled="False" Interval="1000" 
                                ontick="Timer1_Tick">
                            </asp:Timer>
                            <asp:Label ID="Label11" runat="server" Text="Current Time in Seconds:"></asp:Label>
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
                    &nbsp;</td>
                <td style="width: 695px">
                    &nbsp;</td>
                <td style="width: 467px">
                    <asp:Label ID="Label13" runat="server" Text="Total Time in Seconds: "></asp:Label>
                    <asp:Label ID="Label6" runat="server" Text="1800"></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 504px">
&nbsp;&nbsp;&nbsp; No of Questions</td>
                <td style="width: 695px">
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
                <td style="width: 467px">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 504px">
                    &nbsp;</td>
                <td style="width: 695px">
                    <asp:Button ID="start" runat="server" BackColor="Blue" ForeColor="White" 
                        onclick="Button1_Click1" Text="Start Exam" Height="39px" />
                    <asp:HiddenField ID="HiddenField2" runat="server" 
                        onvaluechanged="HiddenField2_ValueChanged" Value="0" />
                </td>
                <td style="width: 467px">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
   
   
        <table style="width: 100%;">
            <tr>
                <td style="width: 73px">
                    &nbsp;</td>
                <td style="width: 121px" colspan="2">
                    &nbsp;</td>
                <td style="width: 74px">
                    &nbsp;</td>
                <td rowspan="21">
                    <table style="width: 100%;" frame="box">
                        <tr>
                            <td style="width: 51px">
                                &nbsp;</td>
                            <td colspan="4">
                                <asp:Label ID="Label7" runat="server" Text="Question Palette"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 51px">
                                <asp:Button ID="Q1" runat="server" onclick="Button3_Click" Text="1" 
                                    Width="34px" BackColor="Blue" ForeColor="White" />
                            </td>
                            <td style="width: 19px">
                                <asp:Button ID="Q2" runat="server" onclick="Button5_Click" Text="2" 
                                    Width="37px" BackColor="Blue" ForeColor="White" />
                            </td>
                            <td style="width: 8px">
                                <asp:Button ID="Q3" runat="server" Text="3" Width="34px" BackColor="Blue" 
                                    ForeColor="White" Height="23px" onclick="Button7_Click" />
                            </td>
                            <td style="width: 5px">
                                <asp:Button ID="Q4" runat="server" BackColor="Blue" ForeColor="White" 
                                    Text="4" Width="36px" Height="24px" onclick="Q4_Click" />
                            </td>
                            <td style="width: 37px">
                                <asp:Button ID="Q5" runat="server" Text="5" Width="34px" BackColor="Blue" 
                                    ForeColor="White" onclick="Q5_Click" />
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 51px; height: 9px;">
                            </td>
                            <td style="width: 19px; height: 9px;">
                            </td>
                            <td style="width: 8px; height: 9px;">
                                &nbsp;</td>
                            <td style="width: 5px; height: 9px;">
                            </td>
                            <td style="width: 37px; height: 9px;">
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 51px">
                                <asp:Button ID="Q6" runat="server" Text="6" Width="34px" BackColor="Blue" 
                                    ForeColor="White" onclick="Q6_Click" />
                            </td>
                            <td style="width: 19px">
                                <asp:Button ID="Q7" runat="server" Text="7" Width="34px" BackColor="Blue" 
                                    ForeColor="White" onclick="Q7_Click" />
                            </td>
                            <td style="width: 8px">
                                <asp:Button ID="Qe" runat="server" BackColor="Blue" ForeColor="White" 
                                    Text="8" Width="34px" onclick="Qe_Click" />
                            </td>
                            <td style="width: 5px">
                                <asp:Button ID="Q8" runat="server" Text="9" Width="34px" BackColor="Blue" 
                                    ForeColor="White" onclick="Q8_Click" />
                            </td>
                            <td style="width: 37px">
                                <asp:Button ID="Q9" runat="server" Text="10" Width="34px" BackColor="Blue" 
                                    ForeColor="White" onclick="Q9_Click" />
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 51px">
                                &nbsp;</td>
                            <td style="width: 19px">
                                &nbsp;</td>
                            <td style="width: 8px">
                                &nbsp;</td>
                            <td style="width: 5px">
                                &nbsp;</td>
                            <td style="width: 37px">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width: 51px">
                                <asp:Button ID="Q12" runat="server" Text="11" Width="34px" BackColor="Blue" 
                                    ForeColor="White" Height="20px" onclick="Q12_Click" />
                            </td>
                            <td style="width: 19px">
                                <asp:Button ID="Q10" runat="server" Text="12" Width="34px" BackColor="Blue" 
                                    ForeColor="White" onclick="Q10_Click" />
                            </td>
                            <td style="width: 8px">
                                <asp:Button ID="Q11" runat="server" Text="13" Width="34px" BackColor="Blue" 
                                    ForeColor="White" onclick="Q11_Click" />
                            </td>
                            <td style="width: 5px">
                                <asp:Button ID="Q13" runat="server" Text="14" Width="34px" BackColor="Blue" 
                                    ForeColor="White" onclick="Q13_Click" />
                            </td>
                            <td style="width: 37px">
                                <asp:Button ID="Q14" runat="server" Text="15" Width="34px" BackColor="Blue" 
                                    ForeColor="White" onclick="Q14_Click" />
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 51px">
                                &nbsp;</td>
                            <td style="width: 19px">
                                &nbsp;</td>
                            <td style="width: 8px">
                                &nbsp;</td>
                            <td style="width: 5px">
                                &nbsp;</td>
                            <td style="width: 37px">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width: 51px">
                                <asp:Button ID="Q15" runat="server" Text="16" Width="34px" BackColor="Blue" 
                                    ForeColor="White" onclick="Q15_Click" />
                            </td>
                            <td style="width: 19px">
                                <asp:Button ID="Q16" runat="server" Text="17" Width="34px" BackColor="Blue" 
                                    ForeColor="White" onclick="Q16_Click" />
                            </td>
                            <td style="width: 8px">
                                <asp:Button ID="Q17" runat="server" Text="18" Width="34px" BackColor="Blue" 
                                    ForeColor="White" onclick="Q17_Click" />
                            </td>
                            <td style="width: 5px">
                                <asp:Button ID="Q18" runat="server" Text="19" Width="34px" BackColor="Blue" 
                                    ForeColor="White" onclick="Q18_Click" />
                            </td>
                            <td style="width: 37px">
                                <asp:Button ID="Q19" runat="server" Text="20" Width="34px" BackColor="Blue" 
                                    ForeColor="White" onclick="Q19_Click" />
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 51px">
                                &nbsp;</td>
                            <td style="width: 19px">
                                &nbsp;</td>
                            <td style="width: 8px">
                                &nbsp;</td>
                            <td style="width: 5px">
                                &nbsp;</td>
                            <td style="width: 37px">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width: 51px">
                                <asp:Button ID="Q20" runat="server" Text="21" Width="34px" BackColor="Blue" 
                                    ForeColor="White" onclick="Q20_Click" />
                            </td>
                            <td style="width: 19px">
                                <asp:Button ID="Q21" runat="server" Text="22" Width="34px" BackColor="Blue" 
                                    ForeColor="White" onclick="Q21_Click" />
                            </td>
                            <td style="width: 8px">
                                <asp:Button ID="Q22" runat="server" Text="23" Width="34px" BackColor="Blue" 
                                    ForeColor="White" onclick="Q22_Click" />
                            </td>
                            <td style="width: 5px">
                                <asp:Button ID="Q23" runat="server" Text="24" Width="34px" BackColor="Blue" 
                                    ForeColor="White" onclick="Q23_Click" />
                            </td>
                            <td style="width: 37px">
                                <asp:Button ID="Q24" runat="server" Text="25" Width="34px" BackColor="Blue" 
                                    ForeColor="White" onclick="Q24_Click" />
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 51px">
                                &nbsp;</td>
                            <td style="width: 19px">
                                &nbsp;</td>
                            <td style="width: 8px">
                                &nbsp;</td>
                            <td style="width: 5px">
                                &nbsp;</td>
                            <td style="width: 37px">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width: 51px">
                                <asp:Button ID="Q25" runat="server" Text="26" Width="34px" BackColor="Blue" 
                                    ForeColor="White" onclick="Q25_Click" />
                            </td>
                            <td style="width: 19px">
                                <asp:Button ID="Q26" runat="server" Text="27" Width="34px" BackColor="Blue" 
                                    ForeColor="White" onclick="Q26_Click" />
                            </td>
                            <td style="width: 8px">
                                <asp:Button ID="Q27" runat="server" Text="28" Width="34px" BackColor="Blue" 
                                    ForeColor="White" onclick="Q27_Click" />
                            </td>
                            <td style="width: 5px">
                                <asp:Button ID="Q28" runat="server" Text="29" Width="34px" BackColor="Blue" 
                                    ForeColor="White" onclick="Q28_Click" />
                            </td>
                            <td style="width: 37px">
                                <asp:Button ID="Q29" runat="server" Text="30" Width="34px" BackColor="Blue" 
                                    ForeColor="White" onclick="Q29_Click" />
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 51px">
                                &nbsp;</td>
                            <td style="width: 19px">
                                &nbsp;</td>
                            <td style="width: 8px">
                                &nbsp;</td>
                            <td style="width: 5px">
                                &nbsp;</td>
                            <td style="width: 37px">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width: 51px">
                                <asp:Button ID="Q30" runat="server" Text="31" Width="34px" BackColor="Blue" 
                                    ForeColor="White" onclick="Q30_Click" />
                            </td>
                            <td style="width: 19px">
                                <asp:Button ID="Q31" runat="server" Text="32" Width="34px" BackColor="Blue" 
                                    ForeColor="White" onclick="Q31_Click" />
                            </td>
                            <td style="width: 8px">
                                <asp:Button ID="Q32" runat="server" Text="33" Width="34px" BackColor="Blue" 
                                    ForeColor="White" onclick="Q32_Click" />
                            </td>
                            <td style="width: 5px">
                                <asp:Button ID="Q33" runat="server" Text="34" Width="34px" BackColor="Blue" 
                                    ForeColor="White" onclick="Q33_Click" />
                            </td>
                            <td style="width: 37px">
                                <asp:Button ID="Q34" runat="server" Text="35" Width="34px" BackColor="Blue" 
                                    ForeColor="White" onclick="Q34_Click" />
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 51px">
                                &nbsp;</td>
                            <td style="width: 19px">
                                &nbsp;</td>
                            <td style="width: 8px">
                                &nbsp;</td>
                            <td style="width: 5px">
                                &nbsp;</td>
                            <td style="width: 37px">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width: 51px">
                                <asp:Button ID="Q36" runat="server" Text="36" Width="34px" BackColor="Blue" 
                                    ForeColor="White" onclick="Q36_Click" />
                            </td>
                            <td style="width: 19px">
                                <asp:Button ID="Q37" runat="server" Text="37" Width="34px" BackColor="Blue" 
                                    ForeColor="White" onclick="Q37_Click" />
                            </td>
                            <td style="width: 8px">
                                <asp:Button ID="Q38" runat="server" Text="38" Width="34px" BackColor="Blue" 
                                    ForeColor="White" onclick="Q38_Click" />
                            </td>
                            <td style="width: 5px">
                                <asp:Button ID="Q35" runat="server" Text="39" Width="34px" BackColor="Blue" 
                                    ForeColor="White" onclick="Q35_Click" />
                            </td>
                            <td style="width: 37px">
                                <asp:Button ID="Q40" runat="server" Text="40" Width="34px" BackColor="Blue" 
                                    ForeColor="White" onclick="Q40_Click" />
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 51px">
                                &nbsp;</td>
                            <td style="width: 19px">
                                &nbsp;</td>
                            <td style="width: 8px">
                                &nbsp;</td>
                            <td style="width: 5px">
                                &nbsp;</td>
                            <td style="width: 37px">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width: 51px">
                                <asp:Button ID="Q44" runat="server" Text="41" Width="34px" BackColor="Blue" 
                                    ForeColor="White" Height="20px" onclick="Q44_Click" />
                            </td>
                            <td style="width: 19px">
                                <asp:Button ID="Q41" runat="server" Text="42" Width="34px" BackColor="Blue" 
                                    ForeColor="White" onclick="Q41_Click" />
                            </td>
                            <td style="width: 8px">
                                <asp:Button ID="Q42" runat="server" Text="43" Width="34px" BackColor="Blue" 
                                    ForeColor="White" onclick="Q42_Click" />
                            </td>
                            <td style="width: 5px">
                                <asp:Button ID="Q39" runat="server" Text="44" Width="34px" BackColor="Blue" 
                                    ForeColor="White" onclick="Q39_Click" />
                            </td>
                            <td style="width: 37px">
                                <asp:Button ID="Q43" runat="server" Text="45" Width="34px" BackColor="Blue" 
                                    ForeColor="White" onclick="Q43_Click" />
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 51px">
                                &nbsp;</td>
                            <td style="width: 19px">
                                &nbsp;</td>
                            <td style="width: 8px">
                                &nbsp;</td>
                            <td style="width: 5px">
                                &nbsp;</td>
                            <td style="width: 37px">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width: 51px">
                                <asp:Button ID="Q45" runat="server" Text="46" Width="34px" BackColor="Blue" 
                                    ForeColor="White" onclick="Q45_Click" />
                            </td>
                            <td style="width: 19px">
                                <asp:Button ID="Q46" runat="server" Text="47" Width="34px" BackColor="Blue" 
                                    ForeColor="White" onclick="Q46_Click" />
                            </td>
                            <td style="width: 8px">
                                <asp:Button ID="Q47" runat="server" Text="48" Width="34px" BackColor="Blue" 
                                    ForeColor="White" onclick="Q47_Click" />
                            </td>
                            <td style="width: 5px">
                                <asp:Button ID="Q49" runat="server" Text="49" Width="34px" BackColor="Blue" 
                                    ForeColor="White" onclick="Q49_Click" />
                            </td>
                            <td style="width: 37px">
                                <asp:Button ID="Q48" runat="server" Text="50" Width="34px" BackColor="Blue" 
                                    ForeColor="White" onclick="Q48_Click" />
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td style="width: 73px">
                    &nbsp;</td>
                <td style="width: 121px" colspan="2">
                    &nbsp;</td>
                <td style="width: 74px">
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 73px">
                    &nbsp;</td>
                <td style="width: 121px" colspan="2">
                    &nbsp;</td>
                <td style="width: 74px">
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 73px; height: 29px;">
                    <asp:Label ID="Label2" runat="server" Text="Qno"></asp:Label>
                </td>
                <td style="height: 29px; width: 121px" colspan="2">
                    <asp:TextBox ID="Qno" runat="server" Height="21px" Width="117px"></asp:TextBox>
                </td>
                <td style="height: 29px; width: 74px">
                    </td>
            </tr>
            <tr>
                <td style="width: 73px">
                    &nbsp;</td>
                <td style="width: 121px" colspan="2">
                    &nbsp;</td>
                <td style="width: 74px">
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 73px">
                    <asp:Label ID="Label3" runat="server" Text="Question:"></asp:Label>
                </td>
                <td style="width: 121px" colspan="2">
                    <asp:TextBox ID="Qs" runat="server" Height="56px" Width="423px"></asp:TextBox>
                </td>
                <td style="width: 74px">
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 73px">
                    &nbsp;</td>
                <td style="width: 121px" colspan="2">
                    &nbsp;</td>
                <td style="width: 74px">
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 73px">
                    &nbsp;</td>
                <td style="width: 121px" colspan="2">
                    <asp:CheckBox ID="C1" runat="server" oncheckedchanged="C1_CheckedChanged" />
                </td>
                <td style="width: 74px">
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 73px">
                    &nbsp;</td>
                <td style="width: 121px" colspan="2">
                    &nbsp;</td>
                <td style="width: 74px">
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 73px">
                    &nbsp;</td>
                <td style="width: 121px" colspan="2">
                    <asp:CheckBox ID="C2" runat="server" oncheckedchanged="C2_CheckedChanged" />
                </td>
                <td style="width: 74px">
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 73px">
                    &nbsp;</td>
                <td style="width: 121px" colspan="2">
                    &nbsp;</td>
                <td style="width: 74px">
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 73px">
                    &nbsp;</td>
                <td style="width: 121px" colspan="2">
                    <asp:CheckBox ID="C3" runat="server" oncheckedchanged="C3_CheckedChanged" />
                </td>
                <td style="width: 74px">
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 73px">
                    &nbsp;</td>
                <td style="width: 121px" colspan="2">
                    &nbsp;</td>
                <td style="width: 74px">
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 73px">
                    &nbsp;</td>
                <td style="width: 121px" colspan="2">
                    <asp:CheckBox ID="C4" runat="server" oncheckedchanged="C4_CheckedChanged" />
                </td>
                <td style="width: 74px">
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 73px">
                    &nbsp;</td>
                <td style="width: 121px" colspan="2">
                    &nbsp;</td>
                <td style="width: 74px">
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 73px">
                    &nbsp;</td>
                <td style="width: 121px" colspan="2">
                    <asp:Label ID="Cans" runat="server" Text="Label" Visible="False"></asp:Label>
                </td>
                <td style="width: 74px">
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 73px">
                    &nbsp;</td>
                <td style="width: 121px" colspan="2">
                    &nbsp;</td>
                <td style="width: 74px">
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 73px">
                    &nbsp;</td>
                <td style="width: 121px" colspan="2">
                    &nbsp;</td>
                <td style="width: 74px">
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 73px">
                    &nbsp;</td>
                <td style="width: 121px" colspan="2">
                    &nbsp;</td>
                <td style="width: 74px">
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 73px">
                    &nbsp;</td>
                <td style="width: 121px" colspan="2">
                    &nbsp;</td>
                <td style="width: 74px">
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 73px">
                    &nbsp;</td>
                <td style="width: 121px">
                    <asp:Button ID="save" runat="server" BackColor="Blue" ForeColor="White" 
                        Height="33px" Text="Save" Width="111px" 
                        onclick="Button1_Click" CausesValidation="False" />
                </td>
                <td style="width: 121px">
        <asp:Button ID="Next" runat="server" onclick="Button3_Click1" 
            Text="Next" BackColor="Blue" ForeColor="White" Height="30px" Width="81px" />
                </td>
                <td style="width: 74px">
                    <asp:Button ID="Button2" runat="server" BackColor="Blue" ForeColor="White" 
                        Height="30px" Text="End Exam" Width="78px" onclick="Button2_Click" />
                </td>
            </tr>
        </table>
    
    <p>
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

