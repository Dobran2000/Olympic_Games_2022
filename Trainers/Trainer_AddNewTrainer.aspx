<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Trainer_AddNewTrainer.aspx.cs" Inherits="aspmuser.Trainers.Trainer_AddNewTrainer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link rel="stylesheet" href="Trainers_AddNewTrainer.css"/>
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
                  <input id="txtFirstName" runat="server" type="text" class="input-field" placeholder="Firtname" required="required"/>
                  <input id="txtLastName" type="text" runat="server" class="input-field" placeholder="LastName" required="required"/>
                  <input id="txtAge" type="text" runat="server" class="input-field" placeholder="Age" required="required"/>
                  <input id="txtCNP" type="text" runat="server" class="input-field" placeholder="CNP" required="required"/>
                  <input id="txtRecordResultat" type="text" runat="server" class="input-field" placeholder="Record Resultat" required="required"/>
                  <input id="txtPhone" type="text" runat="server" class="input-field" placeholder="Phone" required="required"/>
                  <br />
                  <br />
                 <asp:Button type="submit"  class="submit-btn" ID="Create" runat="server" Text="Create" OnClick="Add_New_Trainer" />
                 </div>
          </div>
      </div>
   </form>
 </body>
</html>
