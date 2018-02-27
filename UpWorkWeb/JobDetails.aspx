<%@ Page Title="" Language="C#" MasterPageFile="~/JobSeekerMasterPage.Master" AutoEventWireup="true" CodeBehind="JobDetails.aspx.cs" Inherits="UpWorkWeb.JobDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHead" runat="server">
    <title>Job Details</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <br />
    <br />
    <br />
    <br />
    <br />
    <div class="container-fluid" style="background-color: #dcdcdc; min-height: 100vh">

        <div class="container panel">

            <h2 style="color: #1e90ff">Job Details</h2>
            <hr />
            <div class="panel panel-primary">
                <div class="panel-heading">
                    <asp:Label ID="nameLabel" runat="server" Text=""></asp:Label>
                </div>
                <div class="panel-body">
                    <div class="row">
                        <div class="col-md-3 col-lg-3 " align="center">
                            <asp:Image ID="coverImage" runat="server" CssClass="img-rounded img-responsive" Height="300" Width="300" />
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
                                            <asp:Label ID="jobCodeLabel" runat="server"></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td>Categoey:</td>
                                        <td>
                                            <asp:Label ID="categoryLabel" runat="server"></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td>Responsibility:</td>
                                        <td>
                                            <asp:Label ID="jobResponsibilityLabel" runat="server"></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td>Type:</td>
                                        <td>
                                            <asp:Label ID="typeLabel" runat="server"></asp:Label><asp:Label ID="locationLabel" runat="server" Text="Label"></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td>Deadline:</td>
                                        <td>
                                            <asp:Label ID="deadLineLabel" runat="server"></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td>Post date:</td>
                                        <td>
                                            <asp:Label ID="regLabel" runat="server" Text=""></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td>Message:</td>
                                        <td>
                                            <asp:Label ID="detailsLabel" runat="server"></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td>Payment: </td>
                                        <td>
                                            <asp:Label ID="paymentLabel" runat="server"></asp:Label><asp:Label ID="perLabel" runat="server" Text=""></asp:Label></td>
                                    </tr>
                                    <tr>
                                        <td>Your opinion: </td>
                                        <td>
                                            <asp:TextBox ID="yourSayTextBox" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox></td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <asp:Button ID="applyButton" runat="server" OnClick="applyButton_Click" Text="Apply" CssClass="btn btn-primary" /></td>
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
