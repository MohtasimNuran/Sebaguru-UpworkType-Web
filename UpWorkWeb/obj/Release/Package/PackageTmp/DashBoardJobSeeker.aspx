<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/JobSeekerMasterPage.Master" CodeBehind="DashBoardJobSeeker.aspx.cs" Inherits="UpWorkWeb.DashBoardJobSeeker" %>

<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderHead" runat="server">
    <title>Dash Board</title>
</asp:Content>--%>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHead" runat="server">
    <link href="assets/css/font-awesome.css" rel="stylesheet" />
    <link href="assets/css/custom.css" rel="stylesheet" />
    <%--<link href="Content/bootstrap.min.css" rel="stylesheet" />--%>
    <%--<script src="Scripts/jquery-1.9.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>--%>
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
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">


    <br />
    <br />
    <br />
    <br />

    <div class="row">
        <div class="col-sm-4 col-md-3" style="position: fixed; z-index: 1000">
            <div class="mini-submenu">
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
            </div>
            <div class="list-group" style="font-size: 16px;">
                <span href="#" class="list-group-item active">Dashboard
           
                            <span class="pull-right" id="slide-submenu">
                                <i class="fa fa-times"></i>
                            </span>
                </span>
                <a href="JobList.aspx" class="list-group-item">Find Job <span class="badge"><i class="fa fa-search"></i></span></a>
                <a href="AppliedJobListForJobSeeker.aspx" class="list-group-item">
                    <i class="fa fa-bar-chart-o"></i>&nbsp;&nbsp;&nbsp;Applied Job List</a>
                <a href="CompleteJobListForJobSeeker.aspx" class="list-group-item">
                    <i class="fa fa-list"></i>&nbsp;&nbsp;&nbsp;Completed Job List</a>
                <a href="WorkingJobListForJobSeeker.aspx" class="list-group-item">
                    <i class="fa fa-briefcase"></i>&nbsp;&nbsp;&nbsp;Working Job List<span class="badge"><asp:Label ID="workingCountLabel" runat="server" Text=""></asp:Label></span>
                </a>
                <a href="MessageNotification.aspx" class="list-group-item">
                    <i class="fa fa-comments-o"></i>&nbsp;&nbsp;&nbsp;Message Notification<span class="badge"><asp:Label ID="msgCount2Label" runat="server" Text=""></asp:Label></span>
                </a>
                <a href="MessageJobSeeker.aspx" class="list-group-item">
                    <i class="fa fa-envelope"></i>&nbsp;&nbsp;&nbsp;Send Message</a>
                <a href="NotificationJobSeeker.aspx" class="list-group-item">
                    <i class="fa fa-bell"></i>&nbsp;&nbsp;&nbsp;Notification<span class="badge"><asp:Label ID="notiCountLabel" runat="server" Text=""></asp:Label></span></a>

                <a href="ProfileViewSelfJobSeeker.aspx" class="list-group-item">
                    <i class="fa fa-pencil-square-o"></i>&nbsp;&nbsp;&nbsp;Review</a>
                <a href="ProfileViewSelfJobSeeker.aspx" class="list-group-item">
                    <i class="fa fa-user"></i>&nbsp;&nbsp;&nbsp;My Profile</a>
            </div>
        </div>
        <%--side bar end--%>
        <div class="col-md-3">
        </div>
        <div class="col-md-4 panel">

            <div class="">
                <div class="container panel">
                    <div class="row" style="background-color: #257998; -webkit-border-radius: 5px;">
                        <div class="col-md-4">
                            <h2 style="color: white">DashBoard</h2>
                        </div>
                        <div class="col-md-4">&nbsp;</div>
                        <div class="col-md-4" style="text-align: right">
                            <h2>
                                <asp:Label ID="nameLabel" runat="server" Text="" ForeColor="white"></asp:Label></h2>
                            <h5 style="color: white">Welcome, Love to see you back. </h5>
                        </div>
                    </div>
                    <hr />
                    <div class="row">
                        <div class="col-md-3 col-sm-6 col-xs-6 panel panel-primary">
                            <a href="MessageNotification.aspx">
                                <div class="panel panel-back noti-box">
                                    <span class="icon-box bg-color-red set-icon">
                                        <i class="fa fa-envelope-o"></i>
                                    </span>
                                    <div class="text-box">
                                        <p class="main-text">
                                            <asp:Label ID="msgCountLabel" runat="server" Text=""></asp:Label>
                                            New
                                        </p>
                                        <p class="text-muted">Messages</p>
                                    </div>
                                </div>
                            </a>
                        </div>
                        <div class="col-md-3 col-sm-6 col-xs-6 panel panel-success">
                            <a href="NotificationJobSeeker.aspx">
                                <div class="panel panel-back noti-box">
                                    <span class="icon-box bg-color-blue set-icon">
                                        <i class="fa fa-bell-o"></i>
                                    </span>
                                    <div class="text-box">
                                        <p class="main-text">
                                            <asp:Label ID="countLabel" runat="server" Text=""></asp:Label>
                                            New
                                        </p>
                                        <p class="text-muted">Notifications</p>
                                    </div>
                                </div>
                            </a>
                        </div>
                        <div class="col-md-3 col-sm-6 col-xs-6 panel panel-danger">
                            <a href="JobList.aspx">
                                <div class="panel panel-back noti-box">
                                    <span class="icon-box bg-color-green set-icon">
                                        <i class="fa fa-bars"></i>
                                    </span>
                                    <div class="text-box">
                                        <p class="main-text">
                                            <asp:Label ID="jobCountLabel" runat="server" Text=""></asp:Label>
                                            New
                                        </p>
                                        <p class="text-muted">Job</p>
                                    </div>
                                </div>
                            </a>
                        </div>

                        <div class="col-md-3 col-sm-6 col-xs-6 panel panel-warning">
                            <a href="AppliedJobListForJobSeeker.aspx">
                                <div class="panel panel-back noti-box">
                                    <span class="icon-box bg-color-brown set-icon">
                                        <i class="fa fa-rocket"></i>
                                    </span>
                                    <div class="text-box">
                                        <p class="main-text">
                                            <asp:Label ID="appliedLabel" runat="server" Text=""></asp:Label>
                                            Applied
                                        </p>
                                        <p class="text-muted">Pending</p>
                                    </div>
                                </div>
                            </a>
                        </div>
                    </div>
                    <!-- /. ROW  -->
                    <hr />
                    <div class="row">
                        <div class="col-md-12">
                            <div class="panel panel-primary">
                                <div class="panel-heading">Job List</div>
                                <div class="panel-body" style="overflow: scroll; height: 550px;">
                                    <asp:Repeater ID="jobListRepeater" runat="server" OnItemCommand="jobListRepeater_OnItemCommand">
                                        <ItemTemplate>
                                            <div class="">
                                                <table class="table table-hover table-responsive table-striped">
                                                    <tr>
                                                        <td>
                                                            <h4>
                                                                <strong>Job Title : </strong><%#Eval("JobTitle")%><br />
                                                                <strong>Job Code : </strong><%#Eval("JobCode")%>
                                                            </h4>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <asp:Image ID="Image1" runat="server" Height="122px"
                                                                ImageUrl='<%#Eval("CoverPhoto")%>' Width="250px" CssClass="img-rounded" />

                                                        </td>
                                                        <td>
                                                            <p style="text-align: center">
                                                                <strong>Job Type :</strong> <%#Eval("Type")%>
                                                                <%#Eval("Location")%>
                                                                <br />
                                                                <strong>Category :</strong> <%#Eval("Category")%>
                                                            </p>

                                                        </td>
                                                        <td>
                                                            <p>
                                                                <strong>Payment : </strong><%#Eval("Payment")%><%#Eval("Per")%>
                                                                <br />
                                                                <strong>Deadline : </strong><%#Eval("DeadLineDate")%>
                                                            </p>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <asp:LinkButton Text="Apply" CssClass="btn btn-primary" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "JobCode")%>' Style="display: block" runat="server" />
                                                        </td>
                                                        <hr style="border: .15px solid; color: #1e90ff" />
                                                    </tr>

                                                </table>
                                            </div>
                                        </ItemTemplate>
                                    </asp:Repeater>
                                </div>
                            </div>
                        </div>

                        <div class="col-md-6">
                            <div class="panel panel-primary">
                                <div class="panel-heading">Applied Job List</div>
                                <div class="panel-body" style="overflow: scroll; height: 550px;">
                                    <asp:Repeater ID="appliedJobListRepeater" runat="server" OnItemCommand="appliedJobListRepeater_OnItemCommand">
                                        <ItemTemplate>
                                            <div class="rptr">
                                                <table class="table table-hover table-responsive table-striped">
                                                    <tr>
                                                        <td>
                                                            <h5>
                                                                <strong>Job Title : </strong><%#Eval("JobCode")%><br />
                                                                <br />
                                                                <strong>Job Code : </strong><%#Eval("JobCode")%>
                                                            </h5>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <asp:Image ID="Image1" runat="server" Height="122px"
                                                                ImageUrl='<%#Eval("CoverPhoto")%>' Width="250px" CssClass="img-responsive img-rounded" />

                                                        </td>
                                                        <td>
                                                            <p style="text-align: center">
                                                                Category : <%#Eval("Category")%>
                                                                <br />
                                                                Job Type : <%#Eval("Type")%>
                                                                <%#Eval("Location")%>
                                                            </p>

                                                        </td>
                                                        <td>
                                                            <p>
                                                                Payment : <%#Eval("Payment")%>
                                                                <br />
                                                                Deadline : <%#Eval("DeadLineDate")%>
                                                                <br />
                                                                <br />
                                                                <strong style="color: #1e90ff">Applied : <%#Eval("Count")%> People</strong>
                                                                <asp:LinkButton Text="View" CssClass="" CommandName='<%# DataBinder.Eval(Container.DataItem, "JobCode")%>' Style="display: block" runat="server" />

                                                            </p>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <asp:LinkButton Text="Job Details" CssClass="btn btn-primary" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "JobCode")%>' Style="display: block" runat="server" />
                                                            <br />
                                                            <br />
                                                        </td>
                                                        <hr style="border: .15px solid; color: #1e90ff" />
                                                    </tr>

                                                </table>
                                            </div>

                                        </ItemTemplate>

                                    </asp:Repeater>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-6">
                            <div class="panel panel-primary">
                                <div class="panel-heading">Review About You</div>
                                <div class="panel-body" style="overflow: scroll; height: 550px;">
                                    <asp:Repeater ID="reviewListRepeater" runat="server">
                                        <ItemTemplate>
                                            <div class="media">
                                                <div class="media-left">
                                                    <asp:Image ID="Image1" runat="server"
                                                        ImageUrl='<%#Eval("CoverPhoto")%>' Width="60px" CssClass="media-object" />
                                                </div>
                                                <div class="media-body">
                                                    <h4 class="media-heading">
                                                        <%#Eval("CompanyName")%>
                                                        <%#Eval("FullName")%>
                                                    </h4>
                                                    <p><%#Eval("ReviewForComplete")%></p>
                                                    <p><%#Eval("ReviewForIncomplete")%></p>
                                                    <p>Status : <%#Eval("Status")%></p>
                                                </div>
                                                <hr style="border: .15px solid; color: #1e90ff" />
                                            </div>
                                            <hr>
                                        </ItemTemplate>
                                    </asp:Repeater>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-6">
                            <div class="panel panel-primary">
                                <div class="panel-heading">Work on progress</div>
                                <div class="panel-body" style="overflow: scroll; height: 550px;">
                                    <asp:Repeater ID="workingJobListRepeater" runat="server" OnItemCommand="workingJobListRepeater_OnItemCommand">
                                        <ItemTemplate>
                                            <div class="">
                                                <table class="table table-hover table-responsive table-striped">
                                                    <tr>
                                                        <td>
                                                            <h4>
                                                                <strong>Job Title :
                                                            <asp:LinkButton CommandName="JobTitle" Text='<%#Eval("JobTitle")%>' runat="server" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "JobCode")%>' />
                                                                    <br />
                                                                    <strong>Job Code :
                                                                <asp:LinkButton CommandName="JobCode" Text='<%#Eval("JobCode")%>' runat="server" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "JobCode")%>' />
                                                            </h4>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <asp:Image ID="Image1" runat="server" Height="122px"
                                                                ImageUrl='<%#Eval("CoverPhoto")%>' Width="250px" CssClass="img-rounded" />

                                                        </td>
                                                        <td>
                                                            <p style="text-align: center">
                                                                <strong>Review :</strong> <%#Eval("ReviewForIncomplete")%>
                                                            </p>

                                                        </td>
                                                        <td>Status : <%#Eval("Status")%>
                                                        </td>
                                                    </tr>

                                                    <tr>
                                                        <td>Posted By
                                    <asp:LinkButton CommandName="CompanyId" Text='<%#Eval("CompanyName")%>' runat="server" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "CompanyId")%>' />
                                                            <asp:LinkButton CommandName="PersonalId" Text='<%#Eval("FullName")%>' runat="server" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "PersonalId")%>' />
                                                        </td>
                                                        <hr style="border: .15px solid; color: #1e90ff" />
                                                    </tr>

                                                </table>
                                            </div>
                                        </ItemTemplate>
                                    </asp:Repeater>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-6">
                            <div class="panel panel-primary">
                                <div class="panel-heading">Completed Job List</div>
                                <div class="panel-body" style="overflow: scroll; height: 550px;">
                                    <asp:Repeater ID="completedJobListRepeater" runat="server" OnItemCommand="completedJobListRepeater_OnItemCommand">
                                        <ItemTemplate>
                                            <div class="">
                                                <table class="table table-hover table-responsive table-striped">
                                                    <tr>
                                                        <td>
                                                            <h4>
                                                                <strong>Job Title :
                                                            <asp:LinkButton CommandName="JobTitle" Text='<%#Eval("JobTitle")%>' runat="server" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "JobCode")%>' />
                                                                    <br />
                                                                    <strong>Job Code :
                                                                <asp:LinkButton CommandName="JobCode" Text='<%#Eval("JobCode")%>' runat="server" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "JobCode")%>' />
                                                            </h4>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <asp:Image ID="Image1" runat="server" Height="122px"
                                                                ImageUrl='<%#Eval("CoverPhoto")%>' Width="250px" CssClass="img-rounded" />

                                                        </td>
                                                        <td>
                                                            <p style="text-align: center">
                                                                <strong>Review :</strong> <%#Eval("ReviewForComplete")%>
                                                            </p>
                                                        </td>
                                                        <td>Status : <%#Eval("Status")%>
                                                        </td>
                                                    </tr>

                                                    <tr>
                                                        <td>Posted By
                                    <asp:LinkButton CommandName="CompanyId" Text='<%#Eval("CompanyName")%>' runat="server" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "CompanyId")%>' />
                                                            <asp:LinkButton CommandName="PersonalId" Text='<%#Eval("FullName")%>' runat="server" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "PersonalId")%>' />
                                                        </td>
                                                        <hr style="border: .15px solid; color: #1e90ff" />
                                                    </tr>

                                                </table>
                                            </div>
                                        </ItemTemplate>
                                    </asp:Repeater>
                                </div>
                            </div>
                        </div>


                    </div>
                </div>
            </div>
        </div>
        <div class="col-md-4"></div>
    </div>

</asp:Content>
