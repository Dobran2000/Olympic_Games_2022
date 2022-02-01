<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Athletes_FindAthelete.aspx.cs" Inherits="aspmuser.Athlete.Athletes_FindAthelete" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="AtheltFind.css"/>
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
        <asp:BoundField DataField="Nume" HeaderText="Nume" ItemStyle-Width="100" />
        <asp:BoundField DataField="Prenume" HeaderText="Prenume" ItemStyle-Width="100" />
        <asp:BoundField DataField="Sex" HeaderText="Sex" ItemStyle-Width="100" />
        <asp:BoundField DataField="Inaltime" HeaderText="Inaltime" ItemStyle-Width="100" />
        <asp:BoundField DataField="Greutate" HeaderText="Greutate" ItemStyle-Width="100" />
        <asp:BoundField DataField="Varsta" HeaderText="Varsta" ItemStyle-Width="100" />
        <asp:BoundField DataField="CNP" HeaderText="CNP" ItemStyle-Width="100" />
        <asp:BoundField DataField="Rezultat record" HeaderText="Rezultat record" ItemStyle-Width="100" />
        <asp:BoundField DataField="Tara" HeaderText="Tara" ItemStyle-Width="100" />
    </Columns>
</asp:GridView>
    </form>
</body>
</html>