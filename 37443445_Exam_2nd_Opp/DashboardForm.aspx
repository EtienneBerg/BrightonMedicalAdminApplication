<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DashboardForm.aspx.cs" Inherits="_37443445_Exam_2nd_Opp.DashboardForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 532px;
        }
        .auto-style2 {
            width: 366px;
        }
        .auto-style3 {
            width: 532px;
            height: 25px;
        }
        .auto-style4 {
            width: 366px;
            height: 25px;
        }
        .auto-style5 {
            height: 25px;
            width: 417px;
        }
        .auto-style6 {
            width: 532px;
            height: 35px;
        }
        .auto-style7 {
            width: 366px;
            height: 81px;
        }
        .auto-style8 {
            height: 81px;
            width: 417px;
        }
        .auto-style9 {
            margin-left: 0px;
        }
        .auto-style10 {
            width: 248px;
        }
        .auto-style12 {
            width: 226px;
        }
        .auto-style16 {
            width: 417px;
        }
        .auto-style17 {
            height: 26px;
        }
        .auto-style23 {
            width: 532px;
            height: 17px;
        }
        .auto-style25 {
            width: 366px;
            height: 16px;
        }
        .auto-style26 {
            height: 16px;
            width: 417px;
        }
        .auto-style27 {
            width: 532px;
            height: 16px;
        }
    </style>
      <style>
        body 
        {
                background: linear-gradient(180deg, #0C003C 0%, #BFFFAF 100%), linear-gradient(165deg, #480045 25%, #E9EAAF 100%), linear-gradient(145deg, #480045 25%, #E9EAAF 100%), linear-gradient(300deg, rgba(233, 223, 255, 0) 0%, #AF89FF 100%), linear-gradient(90deg, #45EBA5 0%, #45EBA5 30%, #21ABA5 30%, #21ABA5 60%, #1D566E 60%, #1D566E 70%, #163A5F 70%, #163A5F 100%);
                background-blend-mode: overlay, overlay, overlay, multiply, normal;
        }
          .auto-style28 {
              width: 261px;
          }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style17" colspan="5">
                        <asp:Label ID="lbl_welcomeUser" runat="server" Text="Welcome to Brighton Medical centre, how may we help you  " BackColor="White" Font-Size="X-Large"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style27" colspan="3"></td>
                    <td class="auto-style25"></td>
                    <td class="auto-style26"></td>
                </tr>
                <tr>
                    <td class="auto-style23" colspan="3">
                    </td>
                    <td class="auto-style7" rowspan="2">
                        <asp:Label ID="lbl_appointment0" runat="server" Text="Do you require Ambulance Service for your Appointments" BackColor="White"></asp:Label>
                    </td>
                    <td class="auto-style8" rowspan="2">
                        <asp:Label ID="lbl_appointment1" runat="server" Text="Do you want to recieve SMS reminders for Appointments" BackColor="White"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6" colspan="3">
                        <asp:Label ID="lbl_appointment" runat="server" Text="Your Appointments " BackColor="White"></asp:Label>
                    </td>
                </tr>
                 <tr>
                    <td class="auto-style1" colspan="3" rowspan="2">
                        <asp:ListBox ID="lstbx_appointments" runat="server" Height="158px" Width="554px"></asp:ListBox>
                     </td>
                    <td>
                        <asp:CheckBox ID="ckbx_ambulance" runat="server" AutoPostBack="True" OnCheckedChanged="ckbx_ambulance_CheckedChanged" Text="I do Require" BackColor="White" />
                     </td>
                    <td class="auto-style16">
                        <asp:CheckBox ID="ckbx_SMS" runat="server" AutoPostBack="True" OnCheckedChanged="ckbx_SMS_CheckedChanged" Text="I do Require" BackColor="White" />
                     </td>
                </tr>
                 <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lbl_updateAmbulance" runat="server" Text="Change Saved" BackColor="White"></asp:Label>
                     </td>
                    <td class="auto-style16">
                        <asp:Label ID="lbl_updateSMS" runat="server" Text="Change Saved" BackColor="White"></asp:Label>
                     </td>
                </tr>
                 <tr>
                    <td class="auto-style1" colspan="3">&nbsp;</td>
                    <td class="auto-style2">
                        &nbsp;</td>
                    <td class="auto-style16">
                        &nbsp;</td>
                </tr>
                 <tr>
                    <td class="auto-style1" colspan="3">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style16">&nbsp;</td>
                </tr>
                 <tr>
                    <td class="auto-style12">
                        <asp:Button ID="btn_newAppointment" runat="server" Height="58px" Text="New Appointment" Width="184px" OnClick="btn_newAppointment_Click" Font-Size="Medium" />
                     </td>
                    <td class="auto-style28">
                        <asp:Button ID="btn_changeAppointment" runat="server" CssClass="auto-style9" Height="58px" Text="Change an Apointment" Width="209px" OnClick="btn_changeAppointment_Click" Font-Size="Medium" />
                     </td>
                    <td class="auto-style10">
                        <asp:Button ID="btn_deleteAppointment" runat="server" Height="58px" Text="Delete Appointment" Width="202px" OnClick="btn_deleteAppointment_Click" Font-Size="Medium" />
                     </td>
                    <td class="auto-style2">
                        <asp:Button ID="btn_financialReportForm" runat="server" Height="58px" Text="View Financial Report" Width="237px" OnClick="btn_financialReportForm_Click" Font-Size="Medium" />
                     </td>
                    <td class="auto-style16">&nbsp;</td>
                </tr>
                 <tr>
                    <td class="auto-style1" colspan="3">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style16">&nbsp;</td>
                </tr>
                 <tr>
                    <td class="auto-style1" colspan="3">
                        <asp:Button ID="btn_changeAccount" runat="server" Height="51px" OnClick="btn_changeAccount_Click" Text="Change Account Details" Width="225px" Font-Size="Medium" />
                     </td>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style16">&nbsp;</td>
                </tr>
                 <tr>
                    <td class="auto-style1" colspan="3">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style16">&nbsp;</td>
                </tr>
                 <tr>
                    <td class="auto-style3" colspan="3"></td>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                </tr>
                 <tr>
                    <td class="auto-style3" colspan="3">
                        <asp:Button ID="btn_logOut" runat="server" Height="58px" Text="Log Out" Width="153px" OnClick="btn_logOut_Click" Font-Size="Medium" />
                     </td>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1" colspan="3">
                        <asp:Label ID="lbl_error" runat="server" Text="[error]" BackColor="White"></asp:Label>
                    </td>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style16">&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
