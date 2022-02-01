<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Results_User_FindResult.aspx.cs" Inherits="aspmuser.Results_User.Results_User_FindResult" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="ResultUserFind.css" />
    <title></title>
</head>
<body>
<form runat="server">
    <h1>
        <center>
            <i>
             FIND
            </i>
        </center>
    </h1>
<asp:TextBox ID="txtSearch" type="text" runat="server" class="input"/>
<asp:Button Text="Search" runat="server" OnClick="Search" class="submit-btn" />
<hr />
<asp:GridView ID="gvCustomers" runat="server" AutoGenerateColumns="false" AllowPaging="true"
    OnPageIndexChanging="OnPaging" Height="251px" Width="500px" CssClass="GridPosition"  >
    <Columns>
        <asp:BoundField DataField="Athlete" HeaderText="Atlet" ItemStyle-Width="100" />
        <asp:BoundField DataField="Joc" HeaderText="Joc" ItemStyle-Width="100" />
        <asp:BoundField DataField="Eveniment" HeaderText="Eveniment" ItemStyle-Width="100" />
        <asp:BoundField DataField="Score" HeaderText="Score" ItemStyle-Width="100" />
    </Columns>
</asp:GridView>
    </form>
</body>
</html>
