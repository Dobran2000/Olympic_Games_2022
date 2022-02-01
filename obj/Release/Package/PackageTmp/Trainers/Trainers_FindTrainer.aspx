<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Trainers_FindTrainer.aspx.cs" Inherits="aspmuser.Trainers.Trainers_FindTrainer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="TrainerFind.css"/>
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
        <asp:BoundField DataField="Varsta" HeaderText="Varsta" ItemStyle-Width="100" />
        <asp:BoundField DataField="Rezultate" HeaderText="Rezultate" ItemStyle-Width="100" />
        <asp:BoundField DataField="Telefon" HeaderText="Telefon" ItemStyle-Width="100" />
        <asp:BoundField DataField="CNP" HeaderText="CNP" ItemStyle-Width="100" />
    </Columns>
</asp:GridView>
    </form>
</body>
</html>