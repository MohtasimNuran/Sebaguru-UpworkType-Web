<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/JobSeekerMasterPage.Master" CodeBehind="AppliedJobListForJobSeeker.aspx.cs" Inherits="UpWorkWeb.AppliedJobListForJobSeeker" EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHead" runat="server">
    <title>Applied Job</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <div class="container-fluid" style="background-color: #dcdcdc; min-height: 100vh">
        <br />
        <br />
        <br />
        <br />
        <div class="container panel">

            <h1 style="color: #1e90ff;"><strong>Applied Job List</strong></h1>

            <hr />

            <asp:Repeater ID="Repeater2" runat="server" OnItemCommand="Repeater2_OnItemCommand">
                <ItemTemplate>
                    <div class="rptr">
                        <table class="table table-hover table-responsive table-striped" style="background-color: #dcdcdc; ">
                            <tr >
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
</asp:Content>
