<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/JobProviderMasterPage.Master" CodeBehind="PostedJobListForJobProvider.aspx.cs" Inherits="UpWorkWeb.PostedJobListForJobProvider" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHead" runat="server">
    <title>Posted Job</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <br />
    <br />
    <br />
    <br />
    <br />
    <div class="container-fluid" style="background-color: #dcdcdc">

        <div class="container panel">
            <h1 style="color: #1e90ff; background-color: white;"><strong>My Posted Jobs</strong></h1>
            
            <hr style="border: 1px solid; color: #1e90ff" />
            <asp:Repeater ID="Repeater2" runat="server" OnItemCommand="Repeater2_OnItemCommand">
                <ItemTemplate>
                    <div class="rptr">
                        <table class="table table-hover table-responsive table-striped" style="border: 5px; background-color: #dcdcdc; -webkit-border-radius: 5px;">
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
                                        <asp:LinkButton Text="Edit as new post" CssClass="" CommandName='<%# DataBinder.Eval(Container.DataItem, "JobCode")%>' Style="display: block" runat="server" />
                                    </p>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:LinkButton Text="Applied Candidate Details" CssClass="btn btn-primary" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "JobCode")%>' Style="display: block" runat="server" />

                                </td>
                            </tr>

                        </table>
                    </div>

                </ItemTemplate>

            </asp:Repeater>
        </div>
    </div>

</asp:Content>
