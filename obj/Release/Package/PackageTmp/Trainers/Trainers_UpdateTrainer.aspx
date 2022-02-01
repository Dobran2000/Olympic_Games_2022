<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Trainers_UpdateTrainer.aspx.cs" Inherits="aspmuser.Trainers.Trainers_UpdateTrainer" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="UpdateTrainerStyles.css" />
    <title></title>
        <style type="text/css">
        .auto-style3 {
            margin-left: 280px;
            margin-bottom: 0px;
        }
  
        .auto-style1 {
            width: 596px;
            background: #f1f1f1;
            height: 579px;
            padding: 80px 40px;
            border-radius: 10px;
            position: absolute;
            left: 51%;
            top: 52%;
            transform: translate(-50%,-50%);
        }

        .auto-style2 {
            width: 248px;
            height: 84px;
            margin-left: 202px;
        }
        .auto-style4 {
            width: 241px;
        }
    </style>
</head>
<body>
    <form id="form2" runat="server">
        <div class="hero" runat="server">
           <div class="form-box" runat="server">
            <h1>
                <center>Update</center>
            </h1>
             <div class="input-group" runat="server">
                  <input id="txtFirstName" runat="server" type="text" class="input-field" placeholder="Firstname" required="required"/>
                  <input id="txtLastName" type="text" runat="server" class="input-field" placeholder="LastName" required="required"/>
                  <input id="txtAge" type="text" runat="server" class="input-field" placeholder="Age" required="required"/>
                  <input id="txtResultats" type="text" runat="server" class="input-field" placeholder="Record Resultat" required="required"/>
                  <input id="txtPhone" type="text" runat="server" class="input-field" placeholder="Phone" required="required"/>
                  <br />
                  <br />
                 <asp:Button type="submit"  class="submit-btn" ID="Update" runat="server" Text="Update" OnClick="Update_Athelet_Click" />  
             </div>
            </div>
           </div>
        </form>
</body>
 </html>
