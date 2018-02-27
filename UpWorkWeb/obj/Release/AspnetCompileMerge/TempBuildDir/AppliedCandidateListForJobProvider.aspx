<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/JobProviderMasterPage.Master" CodeBehind="AppliedCandidateListForJobProvider.aspx.cs" Inherits="UpWorkWeb.AppliedCandidateListForJobProvider" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHead" runat="server">
    <title>Applied Candidate List</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <br />
    <br />
    <br />
    <br />
    <br />
    <div class="container-fluid" style="background-color: #dcdcdc; min-height: 100vh">

        <div class="container panel">
            <h1><strong style="color: #1e90ff;">Job Seeker List</strong></h1>
            <hr style="border: 1px solid; color: #1e90ff" />
            <asp:Repeater ID="Repeater2" runat="server" OnItemCommand="Repeater2_OnItemCommand">
                <ItemTemplate>
                    <div class="rptr">
                        <table class="table table-hover table-responsive table-striped" style="border: 5px; background-color: #dcdcdc; -webkit-border-radius: 5px;">
                            <tr style="background-color: #dcdcdc; -webkit-border-radius: 5px;">
                                <td>
                                    <h5>
                                        <strong>Job Title : </strong><%#Eval("JobCode")%><br />
                                        <br />
                                        <strong>Job Code : </strong><%#Eval("JobCode")%>
                                    </h5>
                                </td>
                                <td></td>
                                <td>Deadline date & time : 
                                    <br />
                                    <strong style="color: red"><%#Eval("DeadLine")%></strong>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Image ID="Image1" runat="server" Height="122px"
                                        ImageUrl='<%#Eval("Picture")%>' Width="250px" CssClass="img-responsive img-rounded" />

                                </td>
                                <td>
                                    <p style="text-align: center">
                                        <strong style="color: #1e90ff">Name : <%#Eval("FullName")%></strong>
                                        <br />
                                        Email : <%#Eval("Email")%>
                                    </p>

                                </td>
                                <td>
                                    <p>
                                        Comments : <%#Eval("YourSay")%>
                                        <br />
                                        Phone : <%#Eval("Phone")%>
                                        <br />
                                        <br />
                                        <asp:LinkButton Text="View Profile" CssClass="" CommandName='<%# DataBinder.Eval(Container.DataItem, "Email")%>' Style="display: block" runat="server" />
                                    </p>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:LinkButton Text="Select Candidate" CssClass="btn btn-primary" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "Email")%>' Style="display: block" runat="server" />

                                </td>
                            </tr>
                        </table>
                    </div>
                </ItemTemplate>

            </asp:Repeater>
        </div>
    </div>
</asp:Content>
