<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Games_AddNewGame.aspx.cs" Inherits="aspmuser.Games_AddNewGame" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link rel="stylesheet" href="Games_AddNewGame.css"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 521px;
            margin-bottom: 0px;
        }
    </style>
</head>
    <body>
    <form id="form4" runat="server">
        <div class="hero" runat="server">
           <div class="form-box" runat="server">
            <h1>
                <center>Create</center>
            </h1>
              <div class="input-group" runat="server">
                 
                  <input id="txtGameName" runat="server" type="text" class="input-field" placeholder="Game" required="required"/>
                  <input id="txtGameYear" type="text" runat="server" class="input-field" placeholder="Year" required="required"/>
                  <input id="txtGameDescription" type="text" runat="server" class="input-field" placeholder="Description" required="required"/>
                   <asp:DropDownList ID="ddlSeason" runat="server"  class="input-field" required="required">
                       <asp:listitem text="--Season--" value="0"></asp:listitem>
                        <asp:listitem text="Summer" value="1"></asp:listitem>
                        <asp:listitem text="Winter" value="2"></asp:listitem>
                   </asp:DropDownList>
                  <legend>
                      <p style="color:grey;">
                      Eveniment
                  </legend>
                   <asp:dropdownlist id="ddlEventName" runat="server"  class="input-field" required="required" >
                   </asp:dropdownlist>
                  <br />
                  <br />
                 <asp:Button type="submit"  class="submit-btn" ID="Create" runat="server" Text="Create" OnClick="Add_New_Game" />
                 </div>
             
          </div>
      </div>
        </form>

   
</body>
</html>
