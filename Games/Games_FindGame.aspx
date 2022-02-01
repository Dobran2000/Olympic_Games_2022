<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Games_FindGame.aspx.cs" Inherits="aspmuser.Games_FindGame"%>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="GamesFind.css" />
    <title></title>
</head>
   <body>
         <form runat="server">
             <h1>
                 <center>
                     FIND
                 </center>
             </h1>
                   <asp:TextBox ID="txtSearch" type="text" runat="server" class="input"/>
                   <asp:Button Text="Search" runat="server" OnClick="Search" class="submit-btn" />
                   <hr />
                   <asp:GridView ID="gvCustomers" runat="server" AutoGenerateColumns="false" AllowPaging="true"
                   OnPageIndexChanging="OnPaging" Height="251px" Width="500px" CssClass="GridPosition" >
                        <Columns>
                            <asp:BoundField DataField="game_name" HeaderText="Game" ItemStyle-Width="100" />
                            <asp:BoundField DataField="season" HeaderText="Season" ItemStyle-Width="100" />
                            <asp:BoundField DataField="Eveniment" HeaderText="Event" ItemStyle-Width="100" />
                            <asp:BoundField DataField="game_description" HeaderText="Description" ItemStyle-Width="100" />
                        </Columns>
                   </asp:GridView>
           </form>
   </body>
 </html>
