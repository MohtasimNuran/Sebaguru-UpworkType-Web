<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/JobProviderMasterPage.Master" CodeBehind="JobListJobProvider.aspx.cs" Inherits="UpWorkWeb.JobListJobProvider" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHead" runat="server">
    <title>Job List</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <link href="Content/sidebar.css" rel="stylesheet" />
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
    <br />
    <br />
    <br />
    <br />
    <br />

    <div class="container-fluid" style="background-color: #dcdcdc; min-height: 100vh">

        <div class="container panel" style="padding-left: 50px;">

            <h1 style="color: #1e90ff;"><strong>Job List</strong></h1>
            <hr style="border: 1px solid; color: #1e90ff" />
            <div class="">
                <div class="row">
                    <div class="col-md-2" style="background-color: #6495ed; color: white; position: inherit; -webkit-border-radius: 3px;">
                        <div>
                            <br />
                            <strong>Customize Job List</strong>
                            <hr style="border: 1px solid" />
                            <asp:DropDownList ID="categoryDropDownList" runat="server" AutoPostBack="True" CssClass="form-control" OnSelectedIndexChanged="categoryDropDownList_SelectedIndexChanged">
                                <asp:ListItem>Category</asp:ListItem>
                                <asp:ListItem>web</asp:ListItem>
                                <asp:ListItem>design</asp:ListItem>
                                <asp:ListItem>nothing</asp:ListItem>
                            </asp:DropDownList>
                            <br />
                            <asp:DropDownList ID="typeDropDownList" runat="server" AutoPostBack="True" CssClass="form-control" OnSelectedIndexChanged="typeDropDownList_SelectedIndexChanged">
                                <asp:ListItem>Type</asp:ListItem>
                                <asp:ListItem>Online</asp:ListItem>
                                <asp:ListItem>Offline</asp:ListItem>
                            </asp:DropDownList>
                            <br />
                            <asp:DropDownList ID="timeDropDownList" runat="server" AutoPostBack="True" CssClass="form-control" OnSelectedIndexChanged="timeDropDownList_SelectedIndexChanged">
                                <asp:ListItem>Time</asp:ListItem>
                                <asp:ListItem>/hour</asp:ListItem>
                                <asp:ListItem>/day</asp:ListItem>
                                <asp:ListItem>/week</asp:ListItem>
                                <asp:ListItem>/month</asp:ListItem>
                            </asp:DropDownList>
                            <br />
                            <br />
                        </div>
                    </div>
                    <div class="col-md-10" style="position: inherit">
                        <asp:Repeater ID="Repeater2" runat="server" OnItemCommand="Repeater2_OnItemCommand">
                            <ItemTemplate>
                                <div class="">
                                    <table class="table table-hover table-responsive table-striped" style="border: 5px; background-color: #dcdcdc; -webkit-border-radius: 5px;">
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
                                                    <br />
                                                    <asp:LinkButton Text="Details" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "JobCode")%>' runat="server" />

                                                </p>
                                            </td>
                                        </tr>
                                        <%--<tr>
                                    <td>Minimum Bid : <%#Eval("Type")%>
                                         <%#Eval("Location")%>
                                    </td>
                                </tr>--%>
                                        <tr>
                                            <td>
                                                <asp:LinkButton Text="Details" CssClass="btn btn-primary" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "JobCode")%>' Style="display: block" runat="server" />
                                            </td>
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

</asp:Content>
