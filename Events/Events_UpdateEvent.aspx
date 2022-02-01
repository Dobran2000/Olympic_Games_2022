<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Events_UpdateEvent.aspx.cs" Inherits="aspmuser.Events.Events_UpdateEvent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="UpdateEventStyles.css" />
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
                  <asp:RequiredFieldValidator ErrorMessage="Required" ForeColor="Red" ControlToValidate="txtEventName" runat="server" />
                 <input id="txtEventName" runat="server" type="text" class="input-field" placeholder="Event"/>
                  <legend> 
                      <p style="color:grey;">
                           Start Date
                      </p>
                   </legend>
                  <asp:RequiredFieldValidator ErrorMessage="Required" ForeColor="Red" ControlToValidate="txtStartDate" runat="server" />
                  <input id="txtStartDate" type="date" runat="server" class="input-field" placeholder="Start Date"/>
                    <legend> 
                      <p style="color:grey;">
                           End Date
                      </p>
                   </legend>
                  <asp:RequiredFieldValidator ErrorMessage="Required" ForeColor="Red" ControlToValidate="txtEndDate" runat="server" />
                  <input id="txtEndDate" type="date" runat="server" class="input-field" placeholder="End Date"/>
                  <asp:RequiredFieldValidator ErrorMessage="Required" ForeColor="Red" ControlToValidate="txtNumberGames" runat="server" />
                 <input id="txtNumberGames" runat="server" type="text" class="input-field" placeholder="Number of Games" />
                  <br />
                  <br />
                 <asp:Button type="submit"  class="submit-btn" ID="Update" runat="server" Text="Update" OnClick="Update_Click" />
                 </div>
               </div>
            </div>
  
        </form>

   
</body>
 </html>