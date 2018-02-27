<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/JobSeekerMasterPage.Master" CodeBehind="ProfileViewSelfJobSeeker.aspx.cs" Inherits="UpWorkWeb.ProfileViewSelfJobSeeker" EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHead" runat="server">
    <title>Profile</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <div class="container-fluid" style="background-color: #dcdcdc; min-height: 100vh">
        <br />
        <br />
        <br />
        <br />
        <div class="container panel">

            <h2 style="color: #1e90ff">Update Profile</h2>

            <hr />
            <div class="panel panel-primary">
                <div class="panel-heading">
                    <asp:Label ID="nameLabel" runat="server" Text=""></asp:Label>
                </div>
                <div class="panel-body">
                    <div class="row">
                        <div class="col-md-3 col-lg-3 " align="center">
                            <asp:Image ID="profileImage" runat="server" CssClass="img-rounded img-responsive" Height="300" Width="300" />
                            <br />
                            <p>
                                <asp:Label ID="commentLabel" runat="server" Text=""></asp:Label>
                            </p>
                        </div>
                        <div class=" col-md-9 col-lg-9 ">
                            <table class="table table-user-information">
                                <tbody>
                                    <tr>
                                        <td>Full Name:
                                        </td>
                                        <td>
                                            <asp:Label ID="fullNameLabel" runat="server" Text=""></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Date of Birth</td>
                                        <td>
                                            <asp:Label ID="birthLabel" runat="server" Text=""></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td>Gender:</td>
                                        <td>
                                            <asp:Label ID="genderLabel" runat="server" Text=""></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td>Registration Date:</td>
                                        <td>
                                            <asp:Label ID="regDateLabel" runat="server" Text=""></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td>Nationality</td>
                                        <td>
                                            <asp:Label ID="nationalityLabel" runat="server" Text=""></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td>Expert In:</td>
                                        <td>
                                            <asp:Label ID="categoryLabel" runat="server" Text=""></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td>Email:</td>
                                        <td>
                                            <asp:Label ID="emailLabel" runat="server" Text=""></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td>Phone:</td>
                                        <td>
                                            <asp:Label ID="phnLabel" runat="server" Text=""></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td>Location:</td>
                                        <td>
                                            <asp:Label ID="locationLabel" runat="server" Text=""></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td>Type:</td>
                                        <td>
                                            <asp:Label ID="typeLabel" runat="server" Text=""></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td>Payment Procedure:</td>
                                        <td>
                                            <asp:Label ID="paymentLabel" runat="server" Text=""></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td>Rate:</td>
                                        <td>
                                            <asp:Label ID="rateLabel" runat="server" Text=""></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td>Available Time:</td>
                                        <td>
                                            <asp:Label ID="availableTimeLabel" runat="server" Text=""></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
<%--                                            <asp:Button ID="editButton" runat="server" Text="Edit Info" CssClass="btn btn-primary" OnClick="editButton_OnClick"/>--%>
                                            <a href="UpdateProfileJobSeeker.aspx" class="btn btn-primary">Update Info</a>
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-md-3 col-lg-6">
                <div class="panel panel-primary">
                    <div class="panel-heading">Review About You</div>
                    <div class="panel-body">
                        <asp:Repeater ID="Repeater2" runat="server">
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
                                </div>
                                <hr>
                            </ItemTemplate>
                        </asp:Repeater>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
