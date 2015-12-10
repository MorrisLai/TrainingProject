<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MemberCenter.aspx.cs" Inherits="MemberCenter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width" />

    <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="css/member.css" rel="stylesheet" />
    <link href="css/style.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <div id="top">
        <div id="top_l">會員中心</div>
        <div id="search"><a href="#">
            <img src="images/search.png" alt="搜尋" /></a></div>
    </div>

    <div class="content">
        <div class="container">
        <a href="Member_Update.aspx" class="btn btn-primary">更改密碼</a>
        <a href="" class="btn btn-primary">查看紅利點數</a>
        <a href="" class="btn btn-primary">問題反應</a>
        </div>
    </div>
    

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

    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/jquery-2.1.4.min.js"></script>
</body>
</html>
