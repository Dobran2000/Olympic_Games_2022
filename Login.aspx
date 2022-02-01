<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="aspmuser.home" %>
<!DOCTYPE HTML>
<html>
<head runat="server">
	<title>Login Page</title>
	<!-- Meta-Tags -->
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<meta charset="utf-8">
	<script>
        addEventListener("load", function () {
            setTimeout(hideURLbar, 0);
        }, false);

        function hideURLbar() {
            window.scrollTo(0, 1);
        }
    </script>
	<!-- //Meta-Tags -->
	<!-- Stylesheets -->
	<link href="css/font-awesome.css" rel="stylesheet">
	<link href="css/style.css" rel='stylesheet' type='text/css' />
	<!--// Stylesheets -->
	<!--fonts-->
	<link href="//fonts.googleapis.com/css?family=Source+Sans+Pro:200,200i,300,300i,400,400i,600,600i,700,700i,900,900i&amp;subset=cyrillic,cyrillic-ext,greek,greek-ext,latin-ext,vietnamese" rel="stylesheet">
	<!--//fonts-->
</head>

<body>
	<h1>Login</h1>
	<div class="clear-loading spinner">
		<span></span>
	</div>
	<div class="w3ls-login box box--big">
		<!-- form starts here -->
		<form action="#" method="post" runat="server">
			<div class="agile-field-txt">
				<label><i class="fa fa-user" aria-hidden="true"></i> Username </label>
				<input type="text" id="txtUser" name="name" placeholder="Enter User Name" required="" runat="server"/>
			</div>
			<div class="agile-field-txt">
				<label><i class="fa fa-unlock-alt" aria-hidden="true"></i> password </label>
				<input type="password" id="txtPass" name="password" placeholder="Enter Password" required="" runat="server" />
				<div class="agile_label">
					<input id="check3" name="check3" type="checkbox" value="show password" onclick="myFunction()">
					<label class="check" for="check3">Show password</label>
				</div>
				<div class="agile-right">
					<a href="Register.aspx"> Don't have an account yet? Sign Up</a>
				</div>
			</div>
			<!-- script for show password -->
			<script>
                function myFunction() {
                    var x = document.getElementById("txtPass");
                    if (x.type === "password") {
                        x.type = "text";
                    } else {
                        x.type = "password";
                    }
                }
            </script>

        <asp:Button ID="Login" runat="server" Text="Login" OnClick="Login_Button" />
		</form>
	
	</div>

	<div class="copy-wthree">
		<p>
			Olympic Games - Project by Dobran Andrei-Claudiu
		</p>
		<p>
		Universitatea Politehnica Bucuresti
		</p>
	</div>

</body>
</html>