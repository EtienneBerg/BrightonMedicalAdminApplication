<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewApplicationMade.aspx.cs" Inherits="_37443445_Exam_2nd_Opp.NewApplicationMade" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 26px;
        }
        .auto-style2 {
            width: 490px;
        }
        .auto-style3 {
            height: 26px;
            width: 490px;
        }
        .auto-style4 {
            width: 319px;
        }
        .auto-style5 {
            height: 26px;
            width: 319px;
        }
        .auto-style6 {
            width: 490px;
            height: 68px;
        }
        .auto-style7 {
            width: 319px;
            height: 68px;
        }
        .auto-style8 {
            height: 68px;
        }
    </style>
      <style>
        body 
        {
                background: linear-gradient(180deg, #0C003C 0%, #BFFFAF 100%), linear-gradient(165deg, #480045 25%, #E9EAAF 100%), linear-gradient(145deg, #480045 25%, #E9EAAF 100%), linear-gradient(300deg, rgba(233, 223, 255, 0) 0%, #AF89FF 100%), linear-gradient(90deg, #45EBA5 0%, #45EBA5 30%, #21ABA5 30%, #21ABA5 60%, #1D566E 60%, #1D566E 70%, #163A5F 70%, #163A5F 100%);
                background-blend-mode: overlay, overlay, overlay, multiply, normal;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table style="width:100%;">
            <tr>
                <td class="auto-style1" colspan="2">
                    <asp:Label ID="Label1" runat="server" Text="Make a New Appointment" BackColor="White" Font-Size="X-Large"></asp:Label>
                </td>
                <td class="auto-style1"></td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td class="auto-style5"></td>
                <td class="auto-style1"></td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label3" runat="server" Text="Select the Appointment Date" BackColor="White"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:Label ID="Label2" runat="server" Text="Select the Appointment Time" BackColor="White"></asp:Label>
                </td>
                <td class="auto-style1">
                    <asp:Label ID="Label4" runat="server" Text="Select the Procedure" BackColor="White"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="Black" DayNameFormat="Shortest" Font-Names="Times New Roman" Font-Size="10pt" ForeColor="Black" Height="220px" NextPrevFormat="FullMonth" TitleFormat="Month" Width="400px">
                        <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" ForeColor="#333333" Height="10pt" />
                        <DayStyle Width="14%" />
                        <NextPrevStyle Font-Size="8pt" ForeColor="White" />
                        <OtherMonthDayStyle ForeColor="#999999" />
                        <SelectedDayStyle BackColor="#CC3333" ForeColor="White" />
                        <SelectorStyle BackColor="#CCCCCC" Font-Bold="True" Font-Names="Verdana" Font-Size="8pt" ForeColor="#333333" Width="1%" />
                        <TitleStyle BackColor="Black" Font-Bold="True" Font-Size="13pt" ForeColor="White" Height="14pt" />
                        <TodayDayStyle BackColor="#CCCC99" />
                    </asp:Calendar>
                </td>
                <td class="auto-style4">
                    <asp:ListBox ID="lstbx_time" runat="server" Height="212px" Width="179px"></asp:ListBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="lstbx_time" ErrorMessage="Required" BackColor="White"></asp:RequiredFieldValidator>
                </td>
                <td>
                    <asp:ListBox ID="lstbx_procedure" runat="server" Height="206px" Width="248px"></asp:ListBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="lstbx_procedure" ErrorMessage="Required" BackColor="White"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">
                    <asp:Button ID="btn_cancel" runat="server" CausesValidation="False" Height="64px" OnClick="btn_cancel_Click" Text="Cancel" Width="131px" Font-Size="Medium" />
                </td>
                <td class="auto-style7">
                    <asp:Button ID="btn_confirm" runat="server" Height="55px" OnClick="btn_confirm_Click" Text="Confirm" Width="140px" Font-Size="Medium" />
                </td>
                <td class="auto-style8"></td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lbl_error" runat="server" Text="[error]" BackColor="White"></asp:Label>
                </td>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <div>
        </div>
    </form>
</body>
</html>
