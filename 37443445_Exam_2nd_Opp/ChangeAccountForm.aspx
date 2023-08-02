<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChangeAccountForm.aspx.cs" Inherits="_37443445_Exam_2nd_Opp.ChangeAccountForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 266px;
        }
        .auto-style2 {
            width: 100%;
        }
        .auto-style3 {
            width: 261px;
        }
        .auto-style4 {
            width: 327px;
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
        <div>
            <table class="auto-style2">
                <tr>
                    <td colspan="3">
                        <asp:Label ID="Label1" runat="server" Text="Change Account Details" BackColor="White" Font-Size="X-Large"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label2" runat="server" Text="Name:" BackColor="White"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtbx_name" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtbx_name" ErrorMessage="Required" BackColor="White"></asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style4">
                        &nbsp;</td>
                    <td>&nbsp;</td>
                </tr
                      <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style4">
                        <asp:CheckBox ID="ckbx_password" runat="server" Text="Do you want to change your Password" AutoPostBack="True" OnCheckedChanged="ckbx_password_CheckedChanged" BackColor="White" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                  <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label3" runat="server" Text="Surname:" BackColor="White"></asp:Label>
                      </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtbx_surname" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtbx_surname" ErrorMessage="Required" BackColor="White"></asp:RequiredFieldValidator>
                      </td>
                    <td class="auto-style4">
                        <asp:Label ID="lbl_newPassword" runat="server" Text="New Password:" BackColor="White"></asp:Label>
                      </td>
                    <td>
                        <asp:TextBox ID="txtbx_password" runat="server"></asp:TextBox>
                      </td>
                </tr>
                  <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                  <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label4" runat="server" Text="Number:" BackColor="White"></asp:Label>
                      </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtbx_number" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtbx_number" ErrorMessage="Required" BackColor="White"></asp:RequiredFieldValidator>
                      </td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>
                        <asp:Button ID="btn_password" runat="server" CausesValidation="False" Height="55px" OnClick="btn_password_Click" Text="Change Password" Width="188px" Font-Size="Medium" />
                      </td>
                </tr>>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label5" runat="server" Text="Email Address:" BackColor="White"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtbx_email" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtbx_email" ErrorMessage="Required" BackColor="White"></asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label6" runat="server" Text="List all allergies:" BackColor="White"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtbx_allergies" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtbx_allergies" ErrorMessage="Required" BackColor="White"></asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label7" runat="server" Text="Emergency Contact:" BackColor="White"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtbx_emergencyContact" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtbx_emergencyContact" ErrorMessage="Required" BackColor="White"></asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Button ID="btn_cancel" runat="server" Height="69px" Text="Cancel" Width="158px" CausesValidation="False" OnClick="btn_cancel_Click" Font-Size="Medium" />
                    </td>
                    <td class="auto-style3">
                        <asp:Button ID="btn_change" runat="server" Height="69px" Text="Confirm Changes" Width="187px" OnClick="btn_change_Click" Font-Size="Medium" />
                    </td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="lbl_error" runat="server" Text="[error]" BackColor="White"></asp:Label>
                    </td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
