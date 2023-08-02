<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUpForm.aspx.cs" Inherits="_37443445_Exam_2nd_Opp.SignUpForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 365px;
        }
        .auto-style2 {
            width: 217px;
        }
        .auto-style3 {
            width: 365px;
            height: 25px;
        }
        .auto-style4 {
            width: 217px;
            height: 25px;
        }
        .auto-style5 {
            height: 25px;
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
            <table style="width:100%;">
                <tr>
                    <td colspan="3">
                        <asp:Label ID="Label1" runat="server" Text="Sign Up for a new Brighton Medical Account" BackColor="White" Font-Size="X-Large"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                  <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label2" runat="server" Text="Enter a User Name:" BackColor="White"></asp:Label>
                      </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtbx_userName" runat="server"></asp:TextBox>
                      </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtbx_userName" ErrorMessage="RequiredFieldValidator" BackColor="White"></asp:RequiredFieldValidator>
                      </td>
                </tr>
                  <tr>
                    <td class="auto-style3"></td>
                    <td class="auto-style4"></td>
                    <td class="auto-style5"></td>
                </tr>
                  <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label3" runat="server" Text="Enter a Password:" BackColor="White"></asp:Label>
                      </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtbx_password" runat="server"></asp:TextBox>
                      </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtbx_password" ErrorMessage="RequiredFieldValidator" BackColor="White"></asp:RequiredFieldValidator>
                      </td>
                </tr>
                  <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Button ID="btn_cancel" runat="server" CausesValidation="False" Height="49px" OnClick="btn_cancel_Click" Text="Cancel" Width="137px" Font-Size="Medium" />
                    </td>
                    <td class="auto-style2">
                        <asp:Button ID="btn_signUp" runat="server" Height="62px" Text="Sign Up" Width="160px" OnClick="btn_signUp_Click" Font-Size="Medium" />
                    </td>
                    <td>
                        <asp:Label ID="lbl_message" runat="server" Text="Please note to add all relevant Personal Information at Change Account Details after Signing Up" BackColor="White"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="lbl_error" runat="server" Text="[error]" BackColor="White"></asp:Label>
                    </td>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
