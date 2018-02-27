<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/JobProviderMasterPage.Master" CodeBehind="SelectedJobSeekerListForJobProvider.aspx.cs" Inherits="UpWorkWeb.SelectedJobSeekerListForJobProvider" EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHead" runat="server">
    <title>Selected</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">

    <link href="Repeater.css" rel="stylesheet" />
    <%--<link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-1.9.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>--%>
    <%--    <link type="text/css" rel="stylesheet" href="http://code.jquery.com/ui/1.10.3/themes/smoothness/jquery-ui.css" />

    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>--%>

    <%--<script type="text/javascript" src="http://code.jquery.com/ui/1.10.3/jquery-ui.js"></script>--%>

    <%--for this project--%>
    <%-- <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-1.9.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            $('#btnGetEmail').click(function () {
                var emailId = $('#emaillbl').val();
                alert(emailId);
                $('#txtEmailId').val(emailId);

            });
        });
    </script>--%>

            <div>
                <br/>
                <br />
                <br />
                <br />
                <br />
                <div class="container panel">
                    <h1 style="color: #1e90ff">Selected Job Seeker</h1>
                    <hr style="border: 1px solid; color: #1e90ff" />
                    <p>
                        <asp:GridView ID="selectedJobSeekerListGridView" runat="server" AutoGenerateColumns="False" OnRowDataBound="selectedJobSeekerListGridView_OnRowDataBound" OnSelectedIndexChanged="selectedJobSeekerListGridView_OnSelectedIndexChanged">
                            <Columns>
                                <asp:BoundField DataField="JobCode" HeaderText="Job Code" />
                                <asp:BoundField DataField="Full_Name" HeaderText="Full Name" />
                                <asp:BoundField DataField="Email" HeaderText="Email" />
                                <asp:BoundField DataField="Phone" HeaderText="Phone" />
                            </Columns>
                        </asp:GridView>
                    </p>
                    <asp:Repeater ID="Repeater2" runat="server" OnItemCommand="Repeater2_OnItemCommand">
                        <ItemTemplate>
                            <div class="rptr" style="-webkit-border-radius: 3px!important;">
                                <table>
                                    <tr>
                                        <th><%#Eval("JobCode")%></th>
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
                                            <asp:LinkButton Text="Review/Complete" CssClass="btn btn-success" CommandName="Review" CommandArgument='<%#Eval("Email") + ";" +Eval("JobCode")%>' Style="display: block" runat="server" ForeColor="White" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:LinkButton Text="Profile" CssClass="btn btn-warning" CommandName="Profile" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "Email")%>' Style="display: block" runat="server" ForeColor="White" />
                                        </td>
                                    </tr>

                                </table>
                            </div>

                        </ItemTemplate>

                    </asp:Repeater>
                    <br />
                    <br />
                </div>


                <!-- Popup Div Starts -->
                <%--<div id="popupdiv" style="display: none">
            <table>
                <tbody>
                    <tr>
                        <td>
                            <label class="label">
                                Email:</label>
                        </td>
                        <td>
                            <label id="txtEmailId">
                            </label>
                        </td>
                    </tr>
                    
                </tbody>
            </table>
        </div>--%>
                <!-- Popup Div Ends -->



                <%--<!-- Donate Modal -->
        <div class="modal fade" id="donateModal" tabindex="-1" role="dialog" aria-labelledby="donateModalLabel" aria-hidden="true">
            <div class="modal-dialog">
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                        <h4 class="modal-title" id="donateModalLabel">Write Review</h4>
                    </div>
                    <div class="modal-body">


                        <div class="row">
                            <div class="form-group col-md-12 ">
                                <input id="txtEmailId" type="text"/>
                                <asp:TextBox ID="reviewTextBox" runat="server" CssClass="form-control" placeholder="Write Review..."></asp:TextBox>
                            </div>
                        </div>

                        <div class="row">
                            <div class="form-group col-md-12">
                                <asp:Button ID="saveButton" runat="server" Text="Save" OnClick="saveButton_OnClick" CssClass="btn btn-primary pull-left" />
                            </div>
                        </div>


                    </div>
                </div>
            </div>
        </div>
        <!-- /.modal -->--%>
            </div>

</asp:Content>