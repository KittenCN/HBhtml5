﻿<%@ page language="C#" autoeventwireup="true" inherits="Login, App_Web_b3q5ovkd" %>
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
    <form id="frm_login" runat="server">
        <table id="__01" width="100%" border="0" cellpadding="0" cellspacing="0">
            <tr>
                <td colspan="8">
                    <img src="img/login-m_01.jpg" width="100%" alt="">
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <img src="img/login-m_02.jpg" width="100%" alt="">
                </td>
                <td colspan="4">
                    <div class="am-form am-form-horizontal">
                        <div class="am-form-group app-margin-two">
                            <label for="tf_PhoneNUM" class="am-u-sm-3 am-form-label app-padding-zero app-align-right app-reg-text">手机号</label>
                            <div class="am-u-sm-9">
                                <input type="text" id="tf_PhoneNUM" placeholder="" class="app-input app-padding-zero" name="tf_PhoneNUM">
                            </div>
                        </div>

                        <div class="am-form-group app-margin-two">
                            <label for="tf_Pass" class="am-u-sm-3 am-form-label app-padding-zero app-align-right app-reg-text">密码</label>
                            <div class="am-u-sm-9">
                                <input type="password" id="tf_Pass" placeholder="" class="app-input app-padding-zero" name="tf_Pass">
                            </div>
                        </div>
                    </div>
                </td>
                <td colspan="2">
                    <img src="img/login-m_05.jpg" width="100%" alt="">
                </td>
            </tr>
            <tr>
                <td>
                    <img src="img/login-m_06.jpg" width="100%" alt="">
                </td>
                <td>
                    <img src="img/login-m_07.jpg" width="100%" alt="">
                </td>
                <td>
                    <img src="img/login-m_08.jpg" width="100%" alt="">
                </td>
                <td>
                    <input type="image" name="imageField" id="image1" src="img/login.jpg" style="width:100%" runat="server" onserverclick="btn_Login"/>
                </td>
                <td>
                    <a href="reg.aspx">
                        <img src="img/reg.jpg" alt="" width="100%">
                    </a>
                </td>
                <td>
                    <img src="img/login-m_11.jpg" width="100%" alt="">
                </td>
                <td>
                    <img src="img/login-m_12.jpg" width="100%" alt="">
                </td>
                <td>
                    <img src="img/login-m_13.jpg" width="100%" alt="">
                </td>
            </tr>
            <tr>
                <td colspan="8">
                    <img src="img/login-m_14.jpg" width="100%" alt="">
                </td>
            </tr>
        </table>
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
</body>
</html>