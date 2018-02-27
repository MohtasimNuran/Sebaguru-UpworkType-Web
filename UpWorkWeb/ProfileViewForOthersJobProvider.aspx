<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/JobProviderMasterPage.Master" CodeBehind="ProfileViewForOthersJobProvider.aspx.cs" Inherits="UpWorkWeb.ProfileViewForOthersJobProvider" %>
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

            <h2 style="color: #1e90ff">Profile View</h2>
            <br />
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
                                            <asp:Label ID="fullNameLabel" runat="server"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Gender:</td>
                                        <td>
                                            <asp:Label ID="genderLabel" runat="server"></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td>Registration Date:</td>
                                        <td>
                                            <asp:Label ID="regDateLabel" runat="server" Text=""></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td>Nationality</td>
                                        <td>
                                            <asp:Label ID="nationalityLabel" runat="server"></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td>Expert In:</td>
                                        <td>
                                            <asp:Label ID="categoryLabel" runat="server"></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td>Email:</td>
                                        <td>
                                            <asp:Label ID="emailLabel" runat="server"></asp:Label></td>
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
