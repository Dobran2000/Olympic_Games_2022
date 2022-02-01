<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Results_UpdateResult.aspx.cs" Inherits="aspmuser.Results.Results_UpdateResult" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="UpdateResultsStyles.css" />
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
                       <asp:RequiredFieldValidator ErrorMessage="Required" ForeColor="Red" ControlToValidate="txtAthlete" runat="server" class="input-field"/>
                       <input id="txtAthlete" runat="server" type="text" class="input-field" placeholder="Atlet"/>
                       <asp:RequiredFieldValidator ErrorMessage="Required" ForeColor="Red" ControlToValidate="txtGame" runat="server" class="input-field"/>
                       <input id="txtGame" type="text" runat="server" class="input-field" placeholder="Joc"/>
                       <asp:RequiredFieldValidator ErrorMessage="Required" ForeColor="Red" ControlToValidate="ddlEventName" runat="server" class="input-field"/>
                       <asp:dropdownlist id="ddlEventName" runat="server"  class="input-field" >
                       </asp:dropdownlist>
                       <asp:RequiredFieldValidator ErrorMessage="Required" ForeColor="Red" ControlToValidate="txtScore" runat="server" class="input-field"/>
                       <input id="txtScore" runat="server" type="text" class="input-field" placeholder="Score" />
                    <br />
                    <br />
                       <asp:Button type="submit"  class="submit-btn" ID="Update" runat="server" Text="Update" OnClick="Update_Click" />
                  </div>
                </div>
             </div>
        </form>
     </body>
</html>