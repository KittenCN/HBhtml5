<%@ Page Language="C#" AutoEventWireup="true" CodeFile="point.aspx.cs" Inherits="point" %>
<!doctype html>
<html class="no-js">
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="description" content="">
    <meta name="keywords" content="">
    <meta name="viewport"
          content="width=device-width, initial-scale=1">
    <title>霓虹儿童世界欢迎您</title>

    <!-- Set render engine for 360 browser -->
    <meta name="renderer" content="webkit">

    <!-- No Baidu Siteapp-->
    <meta http-equiv="Cache-Control" content="no-siteapp" />

    <link rel="icon" type="image/png" href="assets/i/favicon.png">

    <!-- Add to homescreen for Chrome on Android -->
    <meta name="mobile-web-app-capable" content="yes">
    <link rel="icon" sizes="192x192" href="assets/i/app-icon72x72@2x.png">

    <!-- Add to homescreen for Safari on iOS -->
    <meta name="apple-mobile-web-app-capable" content="yes">
    <meta name="apple-mobile-web-app-status-bar-style" content="black">
    <meta name="apple-mobile-web-app-title" content="Amaze UI" />
    <link rel="apple-touch-icon-precomposed" href="assets/i/app-icon72x72@2x.png">

    <!-- Tile icon for Win8 (144x144 + tile color) -->
    <meta name="msapplication-TileImage" content="assets/i/app-icon72x72@2x.png">
    <meta name="msapplication-TileColor" content="#0e90d2">

    <link rel="stylesheet" href="assets/css/amazeui.min.css">
    <link rel="stylesheet" href="assets/css/app.css">
</head>
<body>
<div id="app-main">
    <table style="display: inline-table;" width="100%" border="0" cellpadding="0" cellspacing="0">
        <tr>
            <td colspan="16">
                <img src="img/money_01.jpg" width="100%" alt="">
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <img src="img/money_02.jpg" width="100%" alt="">
            </td>
            <td colspan="2">
                <img src="img/money_03.jpg" width="100%" alt="">
            </td>
            <td colspan="2">
                <img src="img/money_04.jpg" width="100%" alt="">
            </td>
            <td colspan="2">
                <a href="welcome.aspx">
                    <img src="img/money_05.jpg" width="100%" alt="">
                </a>
            </td>
            <td colspan="2">
                <a href="point.aspx">
                    <img src="img/money_06_grey.jpg" width="100%" alt="">
                </a>
            </td>
            <td colspan="2">
                <a href="money.aspx">
                    <img src="img/money_07.jpg" width="100%" alt="">
                </a>
            </td>
            <td colspan="2">
                <a href="pay.aspx">
                    <img src="img/money_08.jpg" width="100%" alt="">
                </a>
            </td>
            <td colspan="2">
                <img src="img/money_09.jpg" width="100%" alt="">
            </td>
        </tr>
    </table>

    <form id="form1" runat="server">
    <table style="display: inline-table;" width="100%" height="100%" border="0" cellpadding="0" cellspacing="0" id="app-bar">
        <tr>
            <td>
                <img src="img/money_10.jpg" id="app-content-left" alt="">
            </td>
            <td id="app-content">
                <ul class="am-list">
                    <li class="app-align-right">
                        <div>
                            <asp:Label ID="lab_PhoneNUM" runat="server" Text="PhoneNUM"></asp:Label><a href="login.aspx">【退出】</a>
                        </div>
                    </li>
                </ul>
                <div class="app-align-center">
                    <strong>会员哈宝币明细查询</strong>
                </div>
                
                <div id="tb">
                    <asp:GridView ID="gv_hbb" runat="server"></asp:GridView>
                </div>
            </td>
            <td>
                <img src="img/money_12.jpg" id="app-content-right" alt="">
            </td>
        </tr>
        </table>
        </form>
    <table style="display: inline-table;" width="100%" border="0" cellpadding="0" cellspacing="0">
        <tr>
            <td>
                <img src="img/money_13.jpg" width="100%" alt="">
            </td>
        </tr>
    </table>
</div>
    <footer data-am-widget="footer" class="am-footer am-footer-default" data-am-footer="{  }">
        <div class="am-footer-switch">
            <a href="http://www.neon-kids.com/N/Puan.asp">普安店</a> | <a href="http://www.neon-kids.com/N/Dahua.asp">大华店</a> | <a href="http://www.neon-kids.com/N/Jinhui.asp">金汇店</a> | <a href="http://www.neon-kids.com/N/Shangnan.asp">上南店</a> | <a href="http://www.neon-kids.com/N/Baoshan.asp">宝山店</a> | <a href="http://www.neon-kids.com/N/Minhang.asp">闵行店</a>
        </div>
        <div class="am-footer-miscs ">
            <p>总部地址：上海市黄浦区中山南路969号谷泰滨江大厦19F 邮编：200011</p>
        </div>
    </footer>

    <!--[if (gte IE 9)|!(IE)]><!-->
    <script src="assets/js/jquery.min.js"></script>
    <!--<![endif]-->
    <!--[if lte IE 8 ]>
    <script src="http://libs.baidu.com/jquery/1.11.3/jquery.min.js"></script>
    <script src="http://cdn.staticfile.org/modernizr/2.8.3/modernizr.js"></script>
    <script src="assets/js/amazeui.ie8polyfill.min.js"></script>
    <![endif]-->
    <script src="assets/js/amazeui.min.js"></script>
    <script src="js/welcome.js"></script>
</body>
</html>