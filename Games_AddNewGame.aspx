<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Games_AddNewGame.aspx.cs" Inherits="aspmuser.Games_AddNewGame" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 521px;
            margin-bottom: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
     <div>
            <h1>
                <center>ADD</center>
            </h1>
        </div>
        <table align="center">
            <tr>
                <td>Game</td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtGameName" runat="server" Width="236px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ErrorMessage="Required" ForeColor="Red" ControlToValidate="txtGameName"
                        runat="server" />
                </td>
            </tr>
            <tr>
                <td>Year</td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtGameYear"  runat="server" Width="235px" ></asp:TextBox></td>
                <td>
                    <asp:RequiredFieldValidator ErrorMessage="Required" ForeColor="Red" ControlToValidate="txtGameYear"
                        runat="server" />
                </td>
            </tr>
            <tr>
                <td>Season</td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtSeason" runat="server" Width="235px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ErrorMessage="Required" ForeColor="Red" ControlToValidate="txtGameYear"
                        runat="server" />
                </td>
            </tr>
            <tr>
                <td>Event ID</td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtEventID" runat="server" Width="233px"></asp:TextBox></td>
                <td>
                    <asp:RequiredFieldValidator ErrorMessage="Required" ForeColor="Red" ControlToValidate="txtEventID"
                        runat="server" />
                </td>
            </tr>
            </table>
        <p class="auto-style2">
            <asp:Button ID="Button1" runat="server" CssClass="auto-style1" Height="60px" OnClick="Add_New_Game" Text="Button" Width="178px" />
        </p>
    </form>
</body>
</html>
