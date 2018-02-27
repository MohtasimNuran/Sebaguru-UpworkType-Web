<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/JobProviderMasterPage.Master" CodeBehind="ProfileViewSelfJobProviderPersonal.aspx.cs" Inherits="UpWorkWeb.ProfileViewSelfJobProviderPersonal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHead" runat="server">
    <title>Profile</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <br />
    <br />
    <br />
    <br />
    <br />
    <div class="container-fluid" style="background-color: #dcdcdc; min-height: 100vh">

        <div class="container panel">

            <h2 style="color: #1e90ff">Personal Profile</h2>

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
                                            <asp:Label ID="personalNameLabel" runat="server" Text=""></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Gender: </td>
                                        <td>
                                            <asp:Label ID="genderCodeLabel" runat="server" Text=""></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td>Date of birth:</td>
                                        <td>
                                            <asp:Label ID="birthLabel" runat="server" Text=""></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td>Registration Date:</td>
                                        <td>
                                            <asp:Label ID="regLabel" runat="server" Text=""></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td>Email:</td>
                                        <td>
                                            <asp:Label ID="emailLabel" runat="server" Text=""></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td>NID : </td>
                                        <td>
                                            <asp:Label ID="nidLabel" runat="server" Text=""></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td>Passport No.</td>
                                        <td>
                                            <asp:Label ID="passportLabel" runat="server"></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td>JobProvider Code: </td>
                                        <td>
                                            <asp:Label ID="jobProviderCodeLabel" runat="server" Text=""></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td>Nationality:</td>
                                        <td>
                                            <asp:Label ID="nationLabel" runat="server" Text=""></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td>Phone Number</td>
                                        <td>
                                            <asp:Label ID="phnLabel" runat="server" Text=""></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td>Location</td>
                                        <td>
                                            <asp:Label ID="locationLabel" runat="server" Text=""></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td>Type</td>
                                        <td>
                                            <asp:Label ID="typeLabel" runat="server" Text=""></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td>Payment Procedure</td>
                                        <td>
                                            <asp:Label ID="paymentLabel" runat="server" Text=""></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td>Rate</td>
                                        <td>
                                            <asp:Label ID="rateLabel" runat="server" Text=""></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <%--<asp:Button ID="editButton" runat="server" Text="Edit Info" CssClass="btn btn-primary" />--%>
                                            <a href="UpdateProfileJobProviderPersonel.aspx" class="btn btn-primary">Edit Profile</a>
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
