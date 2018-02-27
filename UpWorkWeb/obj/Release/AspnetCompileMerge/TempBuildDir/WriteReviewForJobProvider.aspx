<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/JobProviderMasterPage.Master" CodeBehind="WriteReviewForJobProvider.aspx.cs" Inherits="UpWorkWeb.WriteReviewForJobProvider" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHead" runat="server">
    <title>review</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-1.9.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <script type="text/javascript">
        function DeleteItem() {
            if (confirm("Now that job seeker will be found at Complete Job List ...?")) {
                return true;
            }
            return false;
        }
    </script>

    <div class="container-fluid" style="background-color: #dcdcdc; min-height: 100vh">
        <br />
        <br />
        <br />
        <br />
        <div class="container panel">

            <h1 style="color: #1e90ff;"><strong>Write Review</strong></h1>
            <br />
            <hr />
            <div class="row">
                <div class="col-md-4">
                    <div class="panel panel-primary">
                        <div class="panel-heading">Review</div>
                        <div class="panel-body">
                            <asp:Image ID="Image1" runat="server" CssClass="img-rounded" Height="200px" Width="200" />
                            <br />
                            <br />
                            Name :
                    <asp:Label ID="nameLabel" runat="server"></asp:Label>
                            <br />
                            Email :
                    <asp:Label ID="emailLabel" runat="server"></asp:Label>
                            <br />
                            <br />
                            <asp:TextBox ID="reviewTextBox" runat="server" placeholder="Write Review..." TextMode="MultiLine" CssClass="form-control"></asp:TextBox>
                            <br />
                            <br />
                            <asp:Button ID="saveButton" runat="server" OnClick="saveButton_Click" Text="Still Working" CssClass="btn btn-success" />

                            <asp:button id="completeJobButton" cssclass="btn btn-danger" runat="server" onclientclick="return DeleteItem()" xmlns:asp="#unknown" onclick="completeJobButton_Click" text="Complete Job" />
                        </div>
                    </div>
                </div>
                <div class="col-md-8">
                    <div class="panel panel-primary">
                        <div class="panel-heading"></div>
                        <div class="panel-body">
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
                                                        ImageUrl='<%#Eval("Picture")%>' Width="250px" CssClass="img-rounded" />
                                                </td>
                                                <td>
                                                    <p style="text-align: center">
                                                        <strong>Working Job :</strong> <%#Eval("ReviewForIncomplete")%>
                                                        <br />
                                                        <strong>Complete Job :</strong> <%#Eval("ReviewForComplete")%>
                                                    </p>

                                                </td>
                                                <td>
                                                    <p>
                                                        <strong>Status : </strong><%#Eval("Status")%>
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
                </div>
            </div>
        </div>
    </div>
</asp:Content>
