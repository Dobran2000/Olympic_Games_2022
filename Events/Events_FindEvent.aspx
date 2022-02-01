<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Events_FindEvent.aspx.cs" Inherits="aspmuser.Events.Events_FindEvent" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="EventFind.css" />
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
        <asp:BoundField DataField="event_name" HeaderText="Eveniment" ItemStyle-Width="100" />
        <asp:BoundField DataField="start_date" HeaderText="Data Start" ItemStyle-Width="100" />
        <asp:BoundField DataField="end_date" HeaderText="Data Sfarsit" ItemStyle-Width="100" />
        <asp:BoundField DataField="numberGames" HeaderText="Numar jocuri" ItemStyle-Width="100" />
        <asp:BoundField DataField="city_name" HeaderText="Oras" ItemStyle-Width="100" />
        <asp:BoundField DataField="country_name" HeaderText="Tara" ItemStyle-Width="100" />
    </Columns>
</asp:GridView>
    </form>
</body>
</html>