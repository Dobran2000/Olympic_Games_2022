<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Games_Update.aspx.cs" Inherits="aspmuser.Games.Games_Update" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="UpdateGameStyles.css" />
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
                  <asp:RequiredFieldValidator ErrorMessage="Required" ForeColor="Red" ControlToValidate="txtGameName" runat="server" />
                  <input type="text" class="input-field" id="txtGameName" placeholder="Game" runat="server"/>
                  <asp:RequiredFieldValidator ErrorMessage="Required" ForeColor="Red" ControlToValidate="txtGameYear" runat="server" />
                  <input type="text" class="input-field" id="txtGameYear" placeholder="Year" runat="server" />
                  <asp:RequiredFieldValidator ErrorMessage="Required" ForeColor="Red" ControlToValidate="ddlSeason" runat="server" />
                  <asp:DropDownList ID="ddlSeason" runat="server" class="input-field">
                       <asp:listitem text="--Season--" value="0"></asp:listitem>
                        <asp:listitem text="Summer" value="1"></asp:listitem>
                        <asp:listitem text="Winter" value="2"></asp:listitem>
	            </asp:DropDownList>
                  <asp:RequiredFieldValidator ErrorMessage="Required" ForeColor="Red" ControlToValidate="txtGameDescription" runat="server" />
                  <input type="text" class="input-field" id="txtGameDescription" placeholder="Description" runat="server">
                  <br />
                  <br />
                  <br />
                   <asp:Button type="submit"  class="submit-btn" ID="Update" runat="server" Text="Update" OnClick="Update_Click" />
                 </div>
             
          </div>
      </div>
        </form>

   
</body>
    </html>