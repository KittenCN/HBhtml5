﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="pass.aspx.cs" Inherits="pass" %>
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
    <form runat="server">
    <div class="am-g">
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
                    <img src="img/money_05_grey.jpg" width="100%" alt="">
                </a>
            </td>
            <td colspan="2">
                <a href="point.aspx">
                    <img src="img/money_06.jpg" width="100%" alt="">
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
    </div>


    <div class="am-g">
    <table style="display: inline-table;" width="100%" border="0" cellpadding="0" cellspacing="0">
        <tr>
            <td>
                <img src="img/money_10.jpg" id="app-content-left" alt="">
            </td>
            <td id="app-content">
                   <div id="app-first">
                        <ul class="am-list">
                            <li>
                                &nbsp;
                            </li>
                              <li class="app-align-right">
                                  <div>
                                    <asp:Label ID="lab_PhoneNUM" runat="server" Text="PhoneNUM"></asp:Label>
                                    <a href="login.aspx">【退出】</a>
                                  </div>
                              </li>
                        </ul>
                    </div>
                    <div id="app-second" class="am-form am-form-horizontal">
                        <fieldset>
                        <legend>修改密码</legend>

                      <div class="am-form-group">
                        <label for="tb_oldpass" class="am-u-sm-4 am-form-label app-padding-zero app-align-right">请输入旧密码</label>
                        <div class="am-u-sm-8">
                            <asp:TextBox ID="tb_oldpass" CssClass="app-padding-zero" runat="server"  TextMode="Password"></asp:TextBox>
                        </div>
                      </div>
                      <div class="am-form-group">
                        <label for="tb_newpass" class="am-u-sm-4 am-form-label app-padding-zero app-align-right">请输入新密码</label>
                        <div class="am-u-sm-8">
                            <asp:TextBox ID="tb_newpass" CssClass="app-padding-zero" runat="server"  TextMode="Password"></asp:TextBox>
                        </div>
                      </div>
                      <div class="am-form-group">
                        <label for="tb_renewpass" class="am-u-sm-4 am-form-label app-padding-zero app-align-right">请重复密码</label>
                        <div class="am-u-sm-8">
                            <asp:TextBox ID="tb_renewpass" CssClass="app-padding-zero" runat="server"  TextMode="Password"></asp:TextBox>
                        </div>
                      </div>
                      <div class="am-form-group">
                        <div class="am-u-sm-8 am-u-sm-offset-4">
                            <asp:Button ID="btn_ok" runat="server" Text="确认" OnClick="btn_ok_Click" />
                            <asp:Button ID="btn_cancel" runat="server" CssClass="auto-style1" Text="取消" OnClick="btn_cancel_Click" />
                        </div>
                      </div>
                    </fieldset>
                </div>
            </td>
            <td>
                <img src="img/money_12.jpg" id="app-content-right" alt="">
            </td>
        </tr>
        </table>
    </div>
    <div class="am-g">
    <table style="display: inline-table;" width="100%" border="0" cellpadding="0" cellspacing="0">
        <tr>
            <td>
                <img src="img/money_13.jpg" width="100%" alt="">
            </td>
        </tr>
    </table>
    </div>
</form>
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
