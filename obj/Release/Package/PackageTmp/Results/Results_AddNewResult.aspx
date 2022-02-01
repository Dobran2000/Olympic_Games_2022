<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Results_AddNewResult.aspx.cs" Inherits="aspmuser.Results.Results_AddNewResult" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link rel="stylesheet" href="Results_AddNewResult.css"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 521px;
            margin-bottom: 0px;
        }
    </style>
</head>
    <body>
    <form id="form5" runat="server">
        <div class="hero" runat="server">
           <div class="form-box" runat="server">
            <h1>
                <center>Create</center>
            </h1>
              <div class="input-group" runat="server">
                  <asp:RequiredFieldValidator ErrorMessage="Required" ForeColor="Red" ControlToValidate="txtAthelte" runat="server" />
                  <input id="txtAthelte" runat="server" type="text" class="input-field" placeholder="Athlete"/>
                  <asp:RequiredFieldValidator ErrorMessage="Required" ForeColor="Red" ControlToValidate="txtGames" runat="server" />
                  <input id="txtGames" runat="server" type="text" class="input-field" placeholder="Game" />
                  </br>
                  </br> 
                  <legend> 
                      <p style="color:grey;">
                           Eveniment
                      </p>
                   </legend>
                  <asp:RequiredFieldValidator ErrorMessage="Required" ForeColor="Red" ControlToValidate="ddlEventName" runat="server" />
                  <asp:dropdownlist id="ddlEventName" runat="server"  class="input-field" >
                   </asp:dropdownlist>
                  <asp:RequiredFieldValidator ErrorMessage="Required" ForeColor="Red" ControlToValidate="txtScore" runat="server" />
                   <input id="txtScore" runat="server" type="text" class="input-field" placeholder="Score" />
                  <br />
                  <br />
                  <br />
                  <br />
                 <asp:Button type="submit"  class="submit-btn" ID="Create" runat="server" Text="Create" OnClick="Add_New_Result" />
                 </div>
             
          </div>
      </div>
        </form>

   
</body>
</html>