<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Athletes_AddNewAthlete.aspx.cs" Inherits="aspmuser.Athlete.Athletes_AddNewAthlete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link rel="stylesheet" href="Atheletes_AddNewAthlete.css"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 521px;
            margin-bottom: 0px;
        }
    </style>
    <style>

body {
  background-image:url('../Photos/Himalaya.jpg');
  background-size: cover;
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
                  <input id="txtFirstName" runat="server" type="text" class="input-field" placeholder="Firtname" required="required"/>
                  <input id="txtLastName" type="text" runat="server" class="input-field" placeholder="LastName" required="required"/>
                 <asp:DropDownList ID="ddlGender" runat="server"  class="input-field" required="required">
                       <asp:listitem text="Gender" value="0"></asp:listitem>
                        <asp:listitem text="M" value="1"></asp:listitem>
                        <asp:listitem text="F" value="2"></asp:listitem>
                   </asp:DropDownList>
                  <input id="txtHeight" type="text" runat="server" class="input-field" placeholder="Height" required="required"/>
                  <input id="txtWeight" type="text" runat="server" class="input-field" placeholder="Weight" required="required"/>
                  <input id="txtAge" type="text" runat="server" class="input-field" placeholder="Age" required="required"/>
                  <input id="txtTrainer" type="text" runat="server" class="input-field" placeholder="Trainer" required="required"/>
                  <input id="txtCNP" type="text" runat="server" class="input-field" placeholder="CNP" required="required"/>
                    <legend> 
                      <p style="color:grey;">
                           Birthday Date
                      </p>
                    </legend>
                  <input id="txtBirthday" type="date" runat="server" class="input-field" placeholder="Birthday" required="required"/>
                  <input id="txtRecordResultat" type="text" runat="server" class="input-field" placeholder="Record Resultat" required="required"/>
                  <input id="txtPhone" type="text" runat="server" class="input-field" placeholder="Phone" required="required"/>
                  <asp:DropDownList ID="ddlCountry" runat="server" class="input-field" DataValueField="country_id" DataTextField="country_name" required="required"></asp:DropDownList>
                  <input id="txtGame" type="text" runat="server" class="input-field" placeholder="Game" required="required"/>
                  <br />
                  <br />
                 <asp:Button type="submit"  class="submit-btn" ID="Create" runat="server" Text="Create" OnClick="Add_New_Athelete" />
                 </div>
          </div>
      </div>
   </form>
 </body>
</html>

