<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/JobSeekerMasterPage.Master" CodeBehind="JobDetailsWithoutApply.aspx.cs" Inherits="UpWorkWeb.JobDetailsWithoutApply" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHead" runat="server">
    <title>Job Details</title>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
            <div class="container-fluid" style="background-color: #dcdcdc; min-height: 100vh">
                <br />
                <br />
                <br />
                <br />
                <br />
                <div class="container panel">

                    <h2 style="color: #1e90ff">Job Details</h2>
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
                                        Posted By: 
                            <asp:LinkButton ID="postedIdLinkButton" runat="server" OnClick="postedIdLinkButton_Click"></asp:LinkButton>
                                        <asp:LinkButton ID="postedIdPersonalLinkButton" runat="server" OnClick="postedIdPersonalLinkButton_OnClick"></asp:LinkButton>
                                    </p>
                                </div>
                                <div class=" col-md-9 col-lg-9 ">
                                    <table class="table table-user-information">
                                        <tbody>
                                            <tr>
                                                <td>Job Title:
                                                </td>
                                                <td>
                                                    <asp:Label ID="jobTitleLabel" runat="server" Text=""></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>Job Code:</td>
                                                <td>
                                                    <asp:Label ID="jobCodeLabel" runat="server" Text=""></asp:Label></td>
                                            </tr>
                                            <tr>
                                                <td>Categoey:</td>
                                                <td>
                                                    <asp:Label ID="catLabel" runat="server" Text=""></asp:Label></td>
                                            </tr>
                                            <tr>
                                                <td>Responsibility:</td>
                                                <td>
                                                    <asp:Label ID="responseLabel" runat="server" Text=""></asp:Label></td>
                                            </tr>
                                            <tr>
                                                <td>Type:</td>
                                                <td>
                                                    <asp:Label ID="typeLabel" runat="server" Text=""></asp:Label><asp:Label ID="loactionLabel" runat="server" Text=""></asp:Label></td>
                                            </tr>
                                            <tr>
                                                <td>Deadline:</td>
                                                <td>
                                                    <asp:Label ID="deadLineLabel" runat="server" Text=""></asp:Label></td>
                                            </tr>
                                            <tr>
                                                <td>Post date:</td>
                                                <td>
                                                    <asp:Label ID="regLabel" runat="server" Text=""></asp:Label></td>
                                            </tr>
                                            <tr>
                                                <td>Message:</td>
                                                <td>
                                                    <asp:Label ID="msgLabel" runat="server" Text=""></asp:Label></td>
                                            </tr>
                                            <tr>
                                                <td>Payment: </td>
                                                <td>
                                                    <asp:Label ID="paymentLabel" runat="server" Text=""></asp:Label><asp:Label ID="perLabel" runat="server" Text=""></asp:Label></td>
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
