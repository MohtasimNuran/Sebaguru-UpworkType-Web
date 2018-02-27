<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/JobProviderMasterPage.Master" CodeBehind="DashBoardJobProvider.aspx.cs" Inherits="UpWorkWeb.DashBoardJobProvider" %>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderHead" runat="server">
    <title>Dash Board</title>
</asp:Content>--%>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHead" runat="server">
    <link href="assets/css/font-awesome.css" rel="stylesheet" />
    <link href="assets/css/custom.css" rel="stylesheet" />
    <%--<link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-1.9.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>--%>
    <link href="Repeater.css" rel="stylesheet" />
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
        <div class="col-sm-4 col-md-3 sidebar" style="position: fixed; z-index: 1000">
            <div class="mini-submenu">
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
            </div>
            <div class="list-group" style="font-size: 16px;">
                <span class="list-group-item active">Menu
           
                            <span class="pull-right" id="slide-submenu">
                                <i class="fa fa-times"></i>
                            </span>
                </span>
                <a href="PostJobByJobProvider.aspx" class="list-group-item">Post Job <span class="badge"><i class="fa fa-clipboard"></i></span></a>
                <a href="JobListJobProvider.aspx" class="list-group-item">Job List <span class="badge"><i class="fa fa-search"></i></span></a>
                <a href="PostedJobListForJobProvider.aspx" class="list-group-item">
                    <i class="fa fa-bar-chart-o"></i>&nbsp;&nbsp;&nbsp;My Posted Job
                            <span class="badge">
                                <asp:Label ID="postedCountLabel" runat="server" Text=""></asp:Label></span>
                </a>
                <a href="SelectedJobSeekerListForJobProvider.aspx" class="list-group-item">
                    <i class="fa fa-check-square-o"></i>&nbsp;&nbsp;&nbsp;Selected Job Seeker</a>
                <a href="SelectedJobSeekerListForJobProvider.aspx" class="list-group-item">
                    <i class="fa fa-pencil-square-o"></i>&nbsp;&nbsp;&nbsp;Write Review on Selected Job Seeker
                </a>
                <a href="CompleteJobListForJobProvider.aspx" class="list-group-item">
                    <i class="fa fa-list-ol"></i>&nbsp;&nbsp;&nbsp;Completed Job List<span class="badge"><asp:Label ID="completeCountLabel" runat="server" Text=""></asp:Label></span>
                </a>
                <a href="MessageJobProvider.aspx" class="list-group-item">
                    <i class="fa fa-envelope"></i>&nbsp;&nbsp;&nbsp;Send Message</a>
                <a href="MessageNotificationJobProvider.aspx" class="list-group-item">
                    <i class="fa fa-comments-o"></i>&nbsp;&nbsp;&nbsp;Message Notification<span class="badge"><asp:Label ID="msgNotiLabel" runat="server" Text=""></asp:Label></span>
                </a>
                <a href="" class="list-group-item">
                    <i class="fa fa-bell"></i>&nbsp;&nbsp;&nbsp;Notification</a>


                <a href="ProfileViewSelfJobProviderCompany.aspx" class="list-group-item">
                    <i class="fa fa-user"></i>&nbsp;&nbsp;&nbsp;My Profile</a>
            </div>
        </div>
        <%--side bar end--%>
        <div class="col-md-3">
        </div>
        <div class="col-md-4 panel">
            <div class="">
                <div class="container panel">
                
                    <div class="row" style="background-color: #257998; -webkit-border-radius: 5px">
                        <div class="col-md-4">
                        <h1 style="color: white;">Dashboard</h1>
                        </div>
                        <div class="col-md-4">
                            &nbsp;
                        </div>
                        <div class="col-md-4">
                            <h2>
                                <asp:Label ID="nameLabel" runat="server" Text="" ForeColor="white"></asp:Label></h2>
                            <h5 style="color: white">Welcome, Love to see you back. </h5>
                        </div>
                    </div>

                   <%-- <hr />--%>

                    <div class="row">
                        <br/>
                        <div class="col-md-3 col-sm-6 col-xs-6 panel panel-danger">
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
                        <div class="col-md-3 col-sm-6 col-xs-6 panel panel-primary">
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
                        <div class="col-md-3 col-sm-6 col-xs-6 panel panel-success">
                            <a href="JobList.aspx">
                                <div class="panel panel-back noti-box">
                                    <span class="icon-box bg-color-green set-icon">
                                        <i class="fa fa-bars"></i>
                                    </span>
                                    <div class="text-box">
                                        <p class="main-text">
                                            <asp:Label ID="jobCountLabel" runat="server" Text=""></asp:Label>
                                            new
                                        </p>
                                        <p class="text-muted">Job</p>
                                    </div>
                                </div>
                            </a>
                        </div>

                        <div class="col-md-3 col-sm-6 col-xs-6 panel panel-warning">
                            <a href="PostedJobListForJobProvider.aspx">
                                <div class="panel panel-back noti-box">
                                    <span class="icon-box bg-color-brown set-icon">
                                        <i class="fa fa-list"></i>
                                    </span>
                                    <div class="text-box">
                                        <p class="main-text">
                                            <asp:Label ID="postedLabel" runat="server" Text=""></asp:Label>
                                            Posted
                                        </p>
                                        <p class="text-muted">Posted by you</p>
                                    </div>
                                </div>
                            </a>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-5">
                            <div class="panel panel-primary">
                                <div class="panel-heading">POST JOB</div>
                                <div class="panel-body" style="overflow: scroll; height: 550px;">
                                    <asp:Label ID="Label7" runat="server" Text="Title"></asp:Label>
                                    <asp:TextBox ID="jobTitleTextBox" runat="server" CssClass="form-control"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorfullname" ValidationGroup="Group1" runat="server" ErrorMessage="*" ControlToValidate="jobTitleTextBox" ForeColor="red"></asp:RequiredFieldValidator>
                                    <br />
                                    <asp:RadioButton ID="onlineRadioButton" runat="server" GroupName="onOrOff" Text="Online" AutoPostBack="True" OnCheckedChanged="onlineRadioButton_CheckedChanged" />
                                    <asp:RadioButton ID="offlineRadioButton" runat="server" GroupName="onOrOff" Text="Offline" AutoPostBack="True" Checked="True" OnCheckedChanged="offlineRadioButton_CheckedChanged" />
                                    <br />
                                    <asp:Label ID="locationLabel" runat="server" Text="Location"></asp:Label>
                                    <asp:TextBox ID="locationTextBox" runat="server" CssClass="form-control" placeholder="location..."></asp:TextBox>
                                    <br />

                                    <asp:Label ID="Label6" runat="server" Text="Category"></asp:Label>
                                    <asp:DropDownList ID="categoryDropDownList" runat="server" CssClass="form-control">
                                        <asp:ListItem>...select one...</asp:ListItem>
                                        <asp:ListItem>web</asp:ListItem>
                                        <asp:ListItem>design</asp:ListItem>
                                        <asp:ListItem>nothing</asp:ListItem>
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ValidationGroup="Group1" runat="server" ErrorMessage="*" ControlToValidate="categoryDropDownList" ForeColor="red" InitialValue="...select one..."></asp:RequiredFieldValidator>
                                    <br />
                                    <asp:Label ID="Label" runat="server" Text="Job Responsibility"></asp:Label>
                                    <asp:TextBox ID="jobResponseTextBox" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ValidationGroup="Group1" runat="server" ErrorMessage="*" ControlToValidate="jobResponseTextBox" ForeColor="red"></asp:RequiredFieldValidator>
                                    <br />
                                    <asp:Label ID="Label2" runat="server" Text="Message"></asp:Label>
                                    <asp:TextBox ID="msgTextBox" runat="server" CssClass="form-control" placeholder="message(not necessary)"></asp:TextBox>
                                    <br />
                                    <asp:Label ID="Label3" runat="server" Text="Deadline"></asp:Label>
                                    <%--<asp:TextBox ID="deadLineTextBox" runat="server"></asp:TextBox>--%>
                                    <input type="date" id="deadLineTextBox" runat="server" class="form-control" />

                                    <br />
                                    <asp:Label ID="Label4" runat="server" Text="Cover Photo"></asp:Label>
                                    <asp:FileUpload ID="FileUpload1" runat="server" />
                                    <br />
                                    <asp:Label ID="Label5" runat="server" Text="Payment"></asp:Label>
                                    <asp:TextBox ID="paymentTextBox" runat="server" CssClass="form-control"></asp:TextBox><br />
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ValidationGroup="Group1" runat="server" ErrorMessage="*" ControlToValidate="paymentTextBox" ForeColor="red"></asp:RequiredFieldValidator>
                                    <asp:DropDownList ID="perDropDownList" runat="server" CssClass="form-control">
                                        <asp:ListItem>...select one...</asp:ListItem>
                                        <asp:ListItem>/hour</asp:ListItem>
                                        <asp:ListItem>/day</asp:ListItem>
                                        <asp:ListItem>/week</asp:ListItem>
                                        <asp:ListItem>/month</asp:ListItem>
                                        <asp:ListItem>/year</asp:ListItem>
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ValidationGroup="Group1" runat="server" ErrorMessage="*" ControlToValidate="perDropDownList" ForeColor="red" InitialValue="...select one..."></asp:RequiredFieldValidator>
                                    <br />
                                    <br />
                                    <asp:Button ID="postButton" CssClass="btn btn-primary" runat="server" ValidationGroup="Group1" OnClick="postButton_Click" Text="Post" />
                                    <br />
                                </div>

                            </div>

                        </div>

                        <div class="col-md-7">
                            <div class="panel panel-primary">
                                <div class="panel panel-heading">JOB LIST</div>
                                <div class="panel panel-body" style="overflow: scroll; height: 500px;">
                                    <div>
                                        <asp:Repeater ID="jobListRepeater" runat="server" OnItemCommand="jobListRepeater_OnItemCommand">
                                            <ItemTemplate>
                                                <div class="">
                                                    <table class="table table-hover table-responsive table-striped">
                                                        <tr>
                                                            <td>
                                                                <h4>
                                                                    <strong>Job Title : </strong><%#Eval("JobCode")%><br />
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
                        </div>


                        <div class="col-md-8">
                            <div class="panel panel-primary">
                                <div class="panel-heading">My Posted Job</div>
                                <div class="panel-body" style="overflow: scroll; height: 500px;">
                                    <asp:Repeater ID="postedJobListRepeater" runat="server" OnItemCommand="postedJobListRepeater_OnItemCommand">
                                        <ItemTemplate>
                                            <div class="">
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
                                                                <strong style="color: #1e90ff">Applied : <%#Eval("Count")%> People</strong>
                                                                <br />
                                                                <br />
                                                                Category : <%#Eval("Category")%>
                                                                <br />
                                                                Job Type : <%#Eval("Type")%>
                                                                <%#Eval("Location")%>
                                                            </p>

                                                        </td>
                                                        <td>
                                                            <p>
                                                                Payment : <%#Eval("Payment")%> <%#Eval("Per")%>
                                                                <br />
                                                                Deadline : <%#Eval("DeadLineDate")%>
                                                                <br />
                                                                Posted : <%#Eval("RegDate")%>
                                                                <br />
                                                                <br />
                                                                <asp:LinkButton Text="Edit" CssClass="" CommandName='<%# DataBinder.Eval(Container.DataItem, "JobCode")%>' Style="display: block" runat="server" />
                                                            </p>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <asp:LinkButton Text="Applied Candidate Details" CssClass="btn btn-primary" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "JobCode")%>' Style="display: block" runat="server" />
                                                            <br />
                                                            <br />
                                                        </td>

                                                    </tr>

                                                </table>
                                            </div>

                                        </ItemTemplate>

                                    </asp:Repeater>
                                </div>
                            </div>

                        </div>
                        <div class="col-md-4">
                            <div class="panel panel-primary">
                                <div class="panel-heading">Selected Job Seeker</div>
                                <div class="panel-body" style="overflow: scroll; height: 500px;">
                                    <asp:Repeater ID="selectedJobSeekerListRepeater" runat="server" OnItemCommand="selectedJobSeekerListRepeater_OnItemCommand">
                                        <ItemTemplate>
                                            <div class="rptr">
                                                <table>
                                                    <tr>
                                                        <th><%#Eval("JobCode")%></th>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <asp:Image ID="Image1" runat="server" Height="122px"
                                                                ImageUrl='<%#Eval("Picture")%>' Width="250px" CssClass="img-rounded" />

                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>Name : <%#Eval("Full_Name")%></td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <asp:Label runat="server" ID="emaillbl" Text='<%# Eval("Email") %>' />
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <asp:LinkButton Text="Review/Complete" CssClass="btn btn-success" CommandName='<%# DataBinder.Eval(Container.DataItem, "Email")%>' Style="display: block" runat="server" ForeColor="White" />
                                                        </td>
                                                    </tr>
                                                    <%--<tr>
                                    <td>
                                        <a style="color: white" data-toggle="tooltip" data-placement="top" title='<%#Eval("Details")%>'>View Details</a>
                                    </td>
                                </tr>--%>
                                                    <tr>
                                                        <td>
                                                            <asp:LinkButton Text="Profile" CssClass="btn btn-warning" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "Email")%>' Style="display: block" runat="server" ForeColor="White" />
                                                        </td>
                                                    </tr>

                                                </table>
                                            </div>

                                        </ItemTemplate>

                                    </asp:Repeater>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-12">
                            <div class="panel panel-primary">
                                <div class="panel-heading">Completed Job List</div>
                                <div class="panel-body" style="overflow: scroll; height: 500px;">
                                    <asp:Repeater ID="completedJobListRepeater" runat="server" OnItemCommand="completedJobListRepeater_OnItemCommand">
                                        <ItemTemplate>
                                            <div class="">
                                                <table class="table table-hover table-responsive table-striped">
                                                    <tr>
                                                        <td>
                                                            <h4>
                                                                <strong>Job Title : </strong><%#Eval("JobCode")%><br />
                                                                <strong>Job Code : </strong><%#Eval("JobCode")%>
                                                            </h4>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <asp:Image ID="Image1" runat="server" Height="122px"
                                                                ImageUrl='<%#Eval("Picture")%>' Width="250px" CssClass="img-rounded" />

                                                        </td>
                                                        <td>
                                                            <p style="text-align: center">
                                                                <strong>Name :</strong> <%#Eval("FullName")%>
                                                                <br />
                                                                <strong>Category :</strong> <%#Eval("Category")%>
                                                            </p>

                                                        </td>
                                                        <td>
                                                            <p>
                                                                <strong>Email : </strong><%#Eval("Email")%>
                                                                <br />
                                                                <strong>Phone : </strong><%#Eval("Phone")%>
                                                            </p>
                                                        </td>
                                                    </tr>
                                                    <%--<tr>
                                <td>
                                    <asp:LinkButton Text="Apply" CssClass="btn btn-primary" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "JobCode")%>' Style="display: block" runat="server" />
                                    <br />
                                </td>
                            </tr>--%>
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
