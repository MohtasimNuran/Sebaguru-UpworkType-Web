<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/JobProviderMasterPage.Master" CodeBehind="CompleteJobListForJobProvider.aspx.cs" Inherits="UpWorkWeb.CompleteJobListForJobProvider" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHead" runat="server">
    <title>Finalising Job</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <br />
    <br />
    <br />
    <br />
    <br />
    <div class="container-fluid" style="background-color: #dcdcdc; min-height: 100vh">

        <div class="container panel">

            <h1 style="color: #1e90ff;"><strong>Complete Job List</strong></h1>
            <hr style="border: 1px solid; color: #1e90ff" />

            <asp:GridView ID="completeJobListGridView" runat="server"></asp:GridView>


            <asp:Repeater ID="Repeater2" runat="server" OnItemCommand="Repeater2_OnItemCommand">
                <ItemTemplate>
                    <div class="">
                        <table class="table table-hover table-responsive table-striped" style="border: 5px; background-color: #dcdcdc; -webkit-border-radius: 5px;">
                            <tr style="background-color: #dcdcdc;">
                                <td>
                                    <h4>
                                        <strong>Job Title : </strong><%#Eval("JobCode")%><br />
                                        <strong>Job Code : </strong><%#Eval("JobCode")%>
                                    </h4>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Image ID="Image1" runat="server" Height="122px"
                                        ImageUrl='<%#Eval("Picture")%>' Width="250px" CssClass="img-rounded" />

                                </td>
                                <td>
                                    <p style="text-align: center">
                                        <strong>Name :</strong> <%#Eval("FullName")%>
                                        <br />
                                        <strong>Category :</strong> <%#Eval("Category")%>
                                    </p>

                                </td>
                                <td>
                                    <p>
                                        <strong>Email : </strong><%#Eval("Email")%>
                                        <br />
                                        <strong>Phone : </strong><%#Eval("Phone")%>
                                    </p>
                                </td>
                            </tr>
                            <%--<tr>
                                <td>
                                    <asp:LinkButton Text="Apply" CssClass="btn btn-primary" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "JobCode")%>' Style="display: block" runat="server" />
                                    <br />
                                </td>
                            </tr>--%>
                        </table>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
</asp:Content>
