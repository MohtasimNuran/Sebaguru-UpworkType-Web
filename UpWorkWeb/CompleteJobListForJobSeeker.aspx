<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/JobSeekerMasterPage.Master" CodeBehind="CompleteJobListForJobSeeker.aspx.cs" Inherits="UpWorkWeb.CompleteJobListForJobSeeker" EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHead" runat="server">
    <title>Complete Job List</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <div class="container-fluid" style="background-color: #dcdcdc; min-height: 100vh">
        <br />
        <br />
        <br />
        <br />
        <div class="container panel">

            <h1 style="color: #1e90ff">Complete Job List</h1>

            <hr />
            <asp:Repeater ID="Repeater2" runat="server" OnItemCommand="Repeater2_OnItemCommand">
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
</asp:Content>
