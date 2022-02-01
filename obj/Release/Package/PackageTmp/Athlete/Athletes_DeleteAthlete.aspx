﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Athletes_DeleteAthlete.aspx.cs" Inherits="aspmuser.Athlete.Athletes_DeleteAthlete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="DeleteAthlete.css"/>
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
    <form id="form3" runat="server">
        <div class="hero" runat="server">
           <div class="form-box" runat="server">
            <h1>
                <center>Delete</center>
            </h1>
              <div class="input-group" runat="server">
                  <input id="txtFirstname" type="text" runat="server" class="input-field" placeholder="Firstname"/>
                  <asp:RequiredFieldValidator ErrorMessage="Required" ForeColor="Red" ControlToValidate="txtFirstName" runat="server" />
                  <input id="txtLastName" type="text" runat="server" class="input-field" placeholder="Kastname"/>
                  <asp:RequiredFieldValidator ErrorMessage="Required" ForeColor="Red" ControlToValidate="txtLastName" runat="server" />
                  <br />
                  <br />
                  <br />
                  <br />
              <asp:Button type="submit"  class="submit-btn" ID="Delete" runat="server" Text="Delete" OnClick="Delete_Click" />
                 </div>
             
          </div>
      </div>
        </form>
  </body>
</html>

