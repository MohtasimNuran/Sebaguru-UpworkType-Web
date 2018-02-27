<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/JobSeekerMasterPage.Master" CodeBehind="JobDetailsWithAppliedCandidate.aspx.cs" Inherits="UpWorkWeb.JobDetailsWithAppliedCandidate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHead" runat="server">
    <title>Deatils</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    
    
    <link href="Repeater.css" rel="stylesheet" />

            <div class="container-fluid" style="background-color: #dcdcdc; min-height: 100vh">
                <br />
                <br />
                <br />
                <br />
                <div class="container panel">

                    <h1 style="color: #1e90ff;"><strong>Job Details with applied candidate</strong></h1>
                    <br />
                    <hr />
                    <br />
                    <br />
                    <div class="row">
                        <div class="col-xs-3">
                            <div class="panel panel-primary">
                                <div class="panel-heading">Job Details</div>
                                <div class="panel-body">
                                    <h5>
                                        <asp:Label ID="Label1" runat="server" Text="Job Type : "></asp:Label>
                                        <asp:Label ID="typeLabel" runat="server"></asp:Label>
                                        <br />
                                        <asp:Label ID="Label3" runat="server" Text="Location : "></asp:Label>
                                        <asp:Label ID="locationLabel" runat="server" Text="Label"></asp:Label>
                                        <br />
                                        <asp:Label ID="Label5" runat="server" Text="Category : "></asp:Label>
                                        <asp:Label ID="categoryLabel" runat="server"></asp:Label>
                                        <br />
                                        <asp:Label ID="Label7" runat="server" Text="Job Responsibility : "></asp:Label>
                                        <asp:Label ID="jobResponsibilityLabel" runat="server"></asp:Label>
                                        <br />
                                        <asp:Label ID="Label9" runat="server" Text="Details : "></asp:Label>
                                        <asp:Label ID="detailsLabel" runat="server"></asp:Label>
                                        <br />
                                        <asp:Label ID="Label11" runat="server" Text="Cover Photo : "></asp:Label>
                                        <asp:Image ID="coverImage" runat="server" CssClass="img-responsive img-rounded" />
                                        <br />
                                        <asp:Label ID="Label13" runat="server" Text="Payment : "></asp:Label>
                                        <asp:Label ID="paymentLabel" runat="server"></asp:Label>
                                        <br />
                                        <asp:Label ID="Label15" runat="server" Text="Deadline : "></asp:Label>
                                        <asp:Label ID="deadLineLabel" runat="server"></asp:Label>
                                        <br />
                                        <asp:Label ID="Label17" runat="server" Text="Job Code : "></asp:Label>
                                        <asp:Label ID="jobCodeLabel" runat="server"></asp:Label></h5>
                                </div>
                            </div>

                        </div>
                        <div class="col-xs-9">
                            <div class="panel panel-primary">
                                <div class="panel-heading">Candidate Details</div>
                                <div class="panel-body">
                                    <asp:Repeater ID="Repeater2" runat="server" OnItemCommand="Repeater2_OnItemCommand">
                                        <ItemTemplate>
                                            <div class="rptr">
                                                <table>
                                                    <tr>
                                                        <th><%#Eval("JobCode")%>
                                                            <%#Eval("JobTitle")%>
                                                        </th>
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
                    </div>


                </div>
            </div>
</asp:Content>