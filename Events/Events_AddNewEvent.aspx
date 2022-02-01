<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Events_AddNewEvent.aspx.cs" Inherits="aspmuser.Events.Events_AddNewEvent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link rel="stylesheet" href="Events_AddNewEvent.css"/>
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
                  <input id="txtEventName" runat="server" type="text" class="input-field" placeholder="Event" required="required" />
                  <legend> 
                      <p style="color:grey;">
                           Start Date
                      </p>
                   </legend>
                  <input id="txtStartDate" type="date" runat="server" class="input-field" placeholder="Start Date" required="required"/>
                  <legend> 
                      <p style="color:grey;">
                           End Date
                      </p>
                   </legend>
                  <input id="txtEndDate" type="date" runat="server" class="input-field" placeholder="End Date" required="required"/>
                  <input id="txtNumberGames" runat="server" type="text" class="input-field" placeholder="Number of Games" required="required"/>
                  <asp:DropDownList ID="ddlCountryEvent" runat="server" AutoPostBack="true" DataValueField="country_id" DataTextField="country_name"
                             OnSelectedIndexChanged="ddlcountry_SelectedIndexChanged" class="input-field" required="required"/>
                  <asp:DropDownList ID="ddlCityEvent" runat="server" DataValueField="id" DataTextField="city_name" CssClass="input-field" required="required"
                           ></asp:DropDownList>
                  <br />
                  <br />
                 <asp:Button type="submit"  class="submit-btn" ID="Create" runat="server" Text="Create" OnClick="Add_New_Event" />
                 </div>
             
          </div>
      </div>
        </form>

   
</body>
</html>
