<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="aspmuser.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="styles.css" />
    <style type="text/css">
        .auto-style1 {
            width: 596px;
            background: #f1f1f1;
            height: 579px;
            padding: 80px 40px;
            border-radius: 10px;
            position: absolute;
            left: 51%;
            top: 52%;
            transform: translate(-50%,-50%);
        }

        .auto-style2 {
            width: 248px;
            height: 84px;
            margin-left: 202px;
        }
        .auto-style4 {
            width: 241px;
        }
    </style>
</head>
    <script src="Script/jquery-1.7.1.js"></script>
    <script language="javascript" type="text/javascript">
        function checkPassStrength() {
            var value = $('#<%=txtPassword%>').val();
            var score = 0;
            var status = "";
            var specialChars = "<>@!#$%^&*()_+[]{}?:;|'\"\\,./~`-="
            if (value.toString().length >= 8) {

                if (/[a-z]/.test(value)) {
                    score += 1;
                }
                if (/[A-Z]/.test(value)) {
                    score += 1;
                }
                if (/\d/.test(value)) {
                    score += 1;
                }
                for (i = 0; i < specialChars.length; i++) {
                    if (value.indexOf(specialChars[i]) > -1) {
                        score += 1;
                    }
                }
            }
            else {
                score = 1;
            }

            if (score == 2) {
                status = status = "<span style='color:#CCCC00'>Medium</span>";
            }
            else if (score == 3) {
                status = "<span style='color:#0DFF5B'>Strong</span>";
            }
            else if (score >= 4) {
                status = "<span style='color:#009933'>Very Strong</span>";
            }
            else {

                status = "<span style='color:red'>Weak</span>";
            }
            if (value.toString().length > 0) {
                $('#<%=lblPasswordStrength.ClientID %>').html("Status :<span> " + status + "</span>");
                }
                else {
                    $('#<%=lblPasswordStrength.ClientID %>').html("");
            }
        }

    </script>
<body>
    <form id="form1" class="auto-style1" runat="server">
        <div>
            <h1>
                <center>Register</center>
            </h1>
        </div>
        <table align="center">
            <tr>
                <td>Username</td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtUsername" runat="server" Width="236px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ErrorMessage="Required" ForeColor="Red" ControlToValidate="txtUsername"
                        runat="server" />
                </td>
            </tr>
            <tr>
                <td>Password</td>
                <td class="auto-style4">
                  <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" onKeyUp="checkPassStrength()" />
                    </td>
                      <td><asp:Label ID="lblPasswordStrength" runat="server" /> </td>
                    <asp:RequiredFieldValidator ErrorMessage="Required" ForeColor="Red" ControlToValidate="txtPassword"
                        runat="server" />
            </tr>
            <tr>
                <td>Emai</td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtEmail" runat="server" Width="235px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server"
                        ControlToValidate="txtemail" ErrorMessage="!!" ForeColor="Red"
                        SetFocusOnError="True"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"
                        ControlToValidate="txtemail" ErrorMessage="invalid email" ForeColor="Red"
                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>Phone</td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtPhone" runat="server" Width="233px"></asp:TextBox></td>
                <td>
                    <asp:RequiredFieldValidator ErrorMessage="Required" ForeColor="Red" ControlToValidate="txtPhone"
                        runat="server" />
                </td>
            </tr>
           
            <tr>
                <td>Country</td>
                 <td class="auto-style4">
                        <asp:DropDownList ID="ddlcountry" runat="server" AutoPostBack="true" DataValueField="country_id" DataTextField="country_name"
                             OnSelectedIndexChanged="ddlcountry_SelectedIndexChanged" Width="109px">

                        </asp:DropDownList></td>
                <td>
                    <asp:RequiredFieldValidator ErrorMessage="Required" ForeColor="Red" ControlToValidate="ddlcountry"
                        runat="server" />
                </td>
         </tr>
            <tr>
                  <td>City </td>
                    <td class="auto-style4">
                        <asp:DropDownList ID="ddlcity" runat="server" DataValueField="id" DataTextField="city_name"
                           ></asp:DropDownList></td>
                 <td>
                 <asp:RequiredFieldValidator ErrorMessage="Required" ForeColor="Red" ControlToValidate="ddlcity"
                        runat="server" />
                </td>
            </tr>
            <tr>
                <td>CNP</td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtCNP" runat="server" Width="238px"></asp:TextBox></td>
                <td>
                    <asp:RequiredFieldValidator ErrorMessage="Required" ForeColor="Red" ControlToValidate="txtCNP"
                        runat="server" />
                </td>
            </tr>
            <tr>
                <td>Gender</td>
                <td class="auto-style4">
                    <asp:DropDownList ID="DropDownList1" runat="server" Height="27px" Width="94px">
                        <asp:ListItem>male</asp:ListItem>
                        <asp:ListItem>female</asp:ListItem>
                    </asp:DropDownList></td>
            </tr>
        </table>
        <p class="auto-style2">
            <asp:Button ID="Button1" runat="server" CssClass="registerbtn" Height="63px" Text="Register" Width="149px" OnClick="Register_Click"/>
        </p>
    </form>
</body>
</html>
