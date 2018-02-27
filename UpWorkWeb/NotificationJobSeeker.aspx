<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/JobSeekerMasterPage.Master" CodeBehind="NotificationJobSeeker.aspx.cs" Inherits="UpWorkWeb.NotificationJobSeeker" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHead" runat="server">
    <title>Notification</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
            <div class="container-fluid" style="background-color: #dcdcdc; min-height: 100vh">
                <br />
                <br />
                <br />
                <br />
                <div class="container panel">

                    <h1 style="color: #1e90ff">Notification</h1>
                    <hr />
                    <asp:Button ID="clearButton" runat="server" Text="Clear" OnClick="clearButton_Click" />

                    <div>
                        <asp:Repeater ID="notificationRepeater" runat="server" OnItemCommand="notificationRepeater_OnItemCommand">
                            <ItemTemplate>
                                <div class="">
                                    <table class="table table-hover table-responsive table-striped">

                                        <tr>
                                            <td>
                                                <%#Eval("Comments")%>
                                            ---<asp:LinkButton CommandName="Details" Text="Details" runat="server" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "JobCode")%>' />
                                            </td>
                                            <%--<tr>
                                            <td>Posted By
                                                <asp:LinkButton CommandName="CompanyId" Text='<%#Eval("CompanyName")%>' runat="server" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "CompanyId")%>' />
                                                <asp:LinkButton CommandName="PersonalId" Text='<%#Eval("FullName")%>' runat="server" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "PersonalId")%>' />
                                            </td>
                                        </tr>--%>
                                            <td>
                                                <%#Eval("PostedDate")%>
                                            </td>
                                            <hr style="border: .15px solid; color: #1e90ff" />
                                        </tr>

                                    </table>
                                </div>
                            </ItemTemplate>
                        </asp:Repeater>
                    </div>
                </div>
            </div>

</asp:Content>