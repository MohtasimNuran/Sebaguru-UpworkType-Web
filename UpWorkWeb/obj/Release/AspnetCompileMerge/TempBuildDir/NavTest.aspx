<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NavTest.aspx.cs" Inherits="UpWorkWeb.NavTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-1.9.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <link href="//netdna.bootstrapcdn.com/font-awesome/4.0.3/css/font-awesome.css" rel="stylesheet" />
    <link href="Content/SideMenu.css" rel="stylesheet" />
    <script>
        $(function () {

            $('#slide-submenu').on('click', function () {
                $(this).closest('.list-group').fadeOut('slide', function () {
                    $('.mini-submenu').fadeIn();
                });

            });

            $('.mini-submenu').on('click', function () {
                $(this).next('.list-group').toggle('slide');
                $('.mini-submenu').hide();
            });
        })

    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container-fluid" style="background-color: #dcdcdc; min-height: 100vh">
            <nav class="navbar navbar-default navbar-fixed-top" role="navigation">
                <div class="container-fluid">
                    <!-- Brand and toggle get grouped for better mobile display -->
                    <div class="navbar-header">
                        <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1">
                            <span class="sr-only">Toggle navigation</span>
                            <span class="icon-bar"></span>
                            <span class="icon-bar"></span>
                            <span class="icon-bar"></span>
                        </button>
                        <a class="navbar-brand" href="#">Brand</a>
                    </div>

                    <!-- Collect the nav links, forms, and other content for toggling -->
                    <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
                        <ul class="nav navbar-nav">
                            <li><a href="#">Link</a></li>
                            <li><a href="#">Link</a></li>
                            <li class="dropdown">
                                <a href="#" class="dropdown-toggle" data-toggle="dropdown">Dropdown <b class="caret"></b></a>
                                <ul class="dropdown-menu">
                                    <li><a href="#">Action</a></li>
                                    <li><a href="#">Another action</a></li>
                                    <li><a href="#">Something else here</a></li>
                                    <li class="divider"></li>
                                    <li><a href="#">Separated link</a></li>
                                    <li class="divider"></li>
                                    <li><a href="#">One more separated link</a></li>
                                </ul>
                            </li>
                        </ul>
                        <div class="navbar-form navbar-left" role="search">
                            <div class="form-group">
                                <input type="text" class="form-control" placeholder="Search">
                            </div>
                            <button type="submit" class="btn btn-default">Submit</button>
                        </div>
                        <ul class="nav navbar-nav navbar-right">
                            <li><a href="#">Link</a></li>
                            <li class="dropdown">
                                <a href="#" class="dropdown-toggle" data-toggle="dropdown">Dropdown <b class="caret"></b></a>
                                <ul class="dropdown-menu">
                                    <li><a href="#">Action</a></li>
                                    <li><a href="#">Another action</a></li>
                                    <li><a href="#">Something else here</a></li>
                                    <li class="divider"></li>
                                    <li><a href="#">Separated link</a></li>
                                </ul>
                            </li>
                        </ul>
                    </div>
                    <!-- /.navbar-collapse -->
                </div>
                <!-- /.container-fluid -->
            </nav>
            <br />
            <br />
            <br />
            <br/>

            <div class="row">
                <div class="col-sm-4 col-md-3"  style="position: fixed; z-index: 1000">
                    <div class="mini-submenu">
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </div>
                    <div class="list-group" style="font-size: 20px;">
                        <span href="#" class="list-group-item active">Dashboard
           
                            <span class="pull-right" id="slide-submenu">
                                <i class="fa fa-times"></i>
                            </span>
                        </span>
                        <a href="#" class="list-group-item">
                            <i class="fa fa-comment-o"></i>Lorem ipsum</a>
                        <a href="#" class="list-group-item">
                            <i class="fa fa-search"></i>Lorem ipsum</a>
                        <a href="#" class="list-group-item">
                            <i class="fa fa-user"></i>Lorem ipsum</a>
                        <a href="#" class="list-group-item">
                            <i class="fa fa-folder-open-o"></i>Lorem ipsum <span class="badge">14</span>
                        </a>
                        <a href="#" class="list-group-item">
                            <i class="fa fa-bar-chart-o"></i>Lorem ipsumr <span class="badge">14</span>
                        </a>
                        <a href="#" class="list-group-item">
                            <i class="fa fa-envelope"></i>Lorem ipsum</a>
                    </div>
                </div>
                <%--side bar end--%>
                <div class="col-md-3">
                </div>
                <div class="col-md-4 panel">

                    <h1 style="color: #1e90ff;"><strong>Log In</strong></h1>
                    <hr />
                    <div class="">
                        <br />
                        <asp:Label ID="Label1" runat="server" Text="Email"></asp:Label>
                        <asp:TextBox ID="emailTextBox" runat="server" CssClass="form-control" placeholder="Email..."></asp:TextBox>
                        <br />
                        <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
                        <asp:TextBox ID="passwordTextBox" runat="server" CssClass="form-control" placeholder="Password..."></asp:TextBox>
                        <asp:LinkButton ID="LinkButton1" runat="server">Forgot Password</asp:LinkButton>
                        <br />
                        <br />

                        <asp:Button ID="loginButton" runat="server" Text="Login" CssClass="btn btn-info" />

                        <br />
                        <br />
                        <asp:Button ID="facebookLoginButton" runat="server" Text="Facebook Login" CssClass="btn btn-primary" />

                        <asp:Button ID="gmailLoginButton" runat="server" Text="Gmail Login" CssClass="btn btn-danger" />
                        <br />
                        <br />
                    </div>

                </div>
                <div class="col-md-4"></div>
            </div>
        </div>
    </form>
</body>
</html>
