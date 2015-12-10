<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Member_Login.aspx.cs" Inherits="Member_Login" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width" />
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="css/member.css" rel="stylesheet" />
    <link href="css/style.css" rel="stylesheet" />

    <title>會員登入</title>
</head>

<body>
    <div>
        <form id="form1" runat="server" class="form-horizontal">
            <div class="container">
                                
                <div class="form-group">
                    <label for="email" class="col-md-3 control-label">E-mail</label>
                    <div class="col-md-9">
                        <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
                    </div>
                </div>

                <div class="form-group">
                    <label for="email" class="col-md-3 control-label">Password</label>
                    <div class="col-md-9">
                        <asp:TextBox ID="txtPW" runat="server" TextMode="Password"></asp:TextBox>
                    </div>
                </div>

                <div class="form-group">
                    <div class="col-md-9 col-md-offset-3">
                        <asp:Button ID="btnSubmit" runat="server" Text="登入" OnClick="btnSubmit_Click" class="btn btn-primary" />
                    </div>
                </div>
<%--                <div
                    class="fb-like"
                    data-share="true"
                    data-width="450"
                    data-show-faces="true">
                </div>--%>

            </div>
        </form>
    </div>

    <div class="footer" data-position="fixed">
        <div id="nav">
            <div class="nav_icon">
                <a href="index.html">
                    <img src="images/nav_icon1.png" width="32" height="30" alt="首頁" />
                    <em class="icon_text">首頁</em></a>
            </div>
            <div class="nav_icon">
                <a href="like.html">
                    <img src="images/nav_icon2.png" width="32" height="30" alt="收藏" />
                    <em class="icon_text">收藏</em></a>
            </div>
            <div class="nav_icon">
                <a href="member.html">
                    <img src="images/nav_icon3.png" width="32" height="30" alt="會員" />
                    <em class="icon_text">會員</em></a>
            </div>
            <div class="nav_icon">
                <a href="set.html">
                    <img src="images/nav_icon4.png" width="32" height="30" alt="設定" />
                    <em class="icon_text">設定</em></a>
            </div>
        </div>
    </div>


    <script src="Scripts/bootstrap.js"></script>
    <script src="Scripts/jquery-2.1.4.js"></script>
    <script>
        window.fbAsyncInit = function () {
            FB.init({
                appId: '972867816105073',
                xfbml: true,
                version: 'v2.5'
            });
        };

        (function (d, s, id) {
            var js, fjs = d.getElementsByTagName(s)[0];
            if (d.getElementById(id)) { return; }
            js = d.createElement(s); js.id = id;
            js.src = "//connect.facebook.net/en_US/sdk.js";
            fjs.parentNode.insertBefore(js, fjs);
        }(document, 'script', 'facebook-jssdk'));
</script>

</body>
</html>
