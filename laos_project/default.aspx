<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="laos_project._default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Laos</title>
    <link href="templatemo_style.css" rel="stylesheet" type="text/css" />
    <script src="js/jquery-1.1.3.1.pack.js" type="text/javascript"></script>
    <script src="js/jquery.history_remote.pack.js" type="text/javascript"></script>
    <script src="js/jquery.tabs.pack.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(function () {

            $('#container-4').tabs({ fxFade: true, fxSpeed: 'slow' });

        });
    </script>
    <link rel="stylesheet" href="jquery.tabs.css" type="text/css" media="print, projection, screen" />
</head>
<body>
    <form id="form1" runat="server">
    <div id="templatemo_body_wrapper">
        <div id="templatemo_wrapper">
            <div id="templatemo_header">
                <div id="site_title"><span>YOUR TAGLINE GOES HERE</span></a>
                </div>
                <!-- end of site_title -->
            </div>
            <!-- end of header -->
            <div id="templatemo_menu">
                <ul>
                    <li><a href="default.aspx">Home</a></li>
                </ul>
            </div>
            <!-- end of menu -->
            <div id="templatemo_main_base">
                <div id="templatemo_main">
                <a href="th.aspx">th</a><a href="default.aspx">sat</a>
                <textarea id="input" runat="server" class="ta" ></textarea>    
                <textarea id="output" runat="server" class="ta" ></textarea>    


                </div>
            </div>
            <!-- end of main_base -->
            <div id="templatemo_main_bottom">
            </div>
            <div id="templatemo_footer">
                Copyright © 2013 <a href="#">CSC43</a> | Designed by Chueawiang
            </div>
            <!-- end of footer -->
            <div class="cleaner">
            </div>
        </div>
        <!-- end of wrapper -->
    </div>
    <!-- end of body_wrapper -->
    <script src='http://ajax.googleapis.com/ajax/libs/jquery/1.3.1/jquery.min.js'></script>
    <script type='text/javascript' src='js/logging.js'></script>
    </form>
</body>
</html>
