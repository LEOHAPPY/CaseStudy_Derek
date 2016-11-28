<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FirstPage.aspx.cs" Inherits="_Default" %>


<!DOCTYPE HTML>
<html>
<head runat="server">
 <title>FirstPage</title>
 <meta name="viewport" content="width=device-width, initial-scale=1" />
 <link rel="stylesheet" href=
   "http://code.jquery.com/mobile/1.4.5/jquery.mobile-1.4.5.min.css" />
 <script src="http://code.jquery.com/jquery-1.11.1.min.js"> </script>
 <script src=
   "http://code.jquery.com/mobile/1.4.5/jquery.mobile-1.4.5.min.js">
 </script>
</head>

<body>
    <form id="form1" runat="server">
        <div data-role="page" id="p1">
            <div data-role="header">
                <h1>MasionExpert</h1>
            </div>

            <div data-role="navbar">
	            <ul>
		            <li><a href="Login.aspx" class="ui-btn-active ui-state-persist">Login</a></li>
		            <li><a href="Signup.aspx">Signup</a></li>
	            </ul>
            </div><!-- /navbar -->

            <div data-role="content">
                <article>

                </article>

            </div>
            <div data-role="footer" data-position="fixed"><h2>&copy;SA43Team9 ISS NUS</h2></div>
        </div>

        
     <%--   <div data-role="page" id="p2">
            <div data-role="header"><h1>This is my header2</h1></div>
            <div data-role="content">
                <p>This is page2.
                <p>
                    Another line
                </p>
                <a href="#p1" data-role="button">Go back</a>
            </div>
            <div data-role="footer" data-position="fixed"><h2>This is my footer2</h2></div>
        </div>
        <div data-role="page" id="p3">
            <div data-role="header">
                <a href="options.aspx">Options</a>
                <h1>This is my header2</h1>
                <a href="page2.aspx">Next</a>
            </div>
            <div data-role="content">
                <p>This is page3.
                <p>
                    Another line
                </p>
                <a href="#p1" data-role="button">Go back</a>
            </div>
            <div data-role="footer" data-position="fixed">
                <a href="#p1">p1</a>
                <a href="#p2">p2</a>
                <a href="#p3">p3</a>
            </div>
        </div>--%>
    </form>
</body>
</html>
