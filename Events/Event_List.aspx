<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Event_List.aspx.cs" Inherits="aspmuser.Events.Event_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
   <style>
       body {
    background-repeat: no-repeat;
    background-size: cover;
    background-image: url('../Photos/CreateBackground.png');
}
   </style> 
    <form id="form1" runat="server">
        <div>
            <h1><center>Events</center></h1>

        </div>
        <p>
            <center>
            <asp:PlaceHolder ID="PlaceHolder2" runat="server"></asp:PlaceHolder>
            </center>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
    </form>
</body>
</html>
