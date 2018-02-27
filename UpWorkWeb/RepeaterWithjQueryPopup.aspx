<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RepeaterWithjQueryPopup.aspx.cs" Inherits="UpWorkWeb.RepeaterWithjQueryPopup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ASP.NET Repeater with jQuery Popup Example</title>
    <link href="Repeater.css" rel="stylesheet" />
    <link type="text/css" rel="stylesheet" href="http://code.jquery.com/ui/1.10.3/themes/smoothness/jquery-ui.css" />
    <script type="text/javascript" src="http://code.jquery.com/jquery-1.8.2.js"></script>
    <script type="text/javascript" src="http://code.jquery.com/ui/1.10.3/jquery-ui.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            // Prototype to assign HTML to the dialog title bar.
            $.widget('ui.dialog', jQuery.extend({}, jQuery.ui.dialog.prototype, {
                _title: function (titleBar) {
                    titleBar.html(this.options.title || '&#160;');
                }
            }));

            // ImageButton Click Event.
            $('#tblEmployeeDetails .imgButton').click(function () {
                // Get the Current Row and its values.
                var currentRow = $(this).parents("tr");
                var empId = currentRow.find("span[id*='lblEmployeeId']").text();
                var empName = currentRow.find("span[id*='lblName']").text();
                var empLocation = currentRow.find("span[id*='lblLocation']").text();

                // Populate labels inside the dailog.
                $("#lblEmpId").text(empId);
                $("#lblEmpName").text(empName);
                $("#lblEmpLocation").text(empLocation);

                // Open the dialog.
                $("#donateModal").dialog({
                    title: "Details of <em>" + empName + "</em>",
                    modal: true,
                    buttons: {
                        Close: function () {
                            $(this).dialog('close');
                        }
                    }
                });

                return false;
            });
        });
    </script>
    <style type="text/css">
        .ui-widget {
            font-family: Segoe UI Light;
        }

        .label {
            font-weight: bold;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <!-- Container Div Starts -->
        <div style="font-family: Segoe UI Light; font-size: large; text-align: center;">
            <h2>Employee Details</h2>
            <!-- Repeater Starts -->
            <asp:Repeater ID="rptEmployees" runat="server">


                <ItemTemplate>
                    <div class="rptr">
                        <table id="tblEmployeeDetails" style="border: 1px solid; margin-left: auto; margin-right: auto;">
                            <tr>
                                <td bgcolor="#CCFFCC">
                                    <asp:Label runat="server" ID="lblEmployeeId" Text='<%# Eval("JobCode") %>' />
                                </td>


                                <td>
                                    <asp:Image ID="Image1" runat="server" Height="122px"
                                        ImageUrl='<%#Eval("Picture")%>' Width="250px" CssClass="img-rounded" />

                                </td>


                                <td bgcolor="#CCFFCC">
                                    <asp:Label runat="server" ID="lblName" Text='<%# Eval("Full_Name") %>' />
                                </td>


                                <td bgcolor="#CCFFCC">
                                    <asp:Label runat="server" ID="lblLocation" Text='<%# Eval("Email") %>' />
                                </td>


                                <td bgcolor="#CCFFCC">
                                    <asp:ImageButton ID="imbShowDetails" class="imgButton" Height="50" runat="server"
                                        ImageUrl="images/popup.png" />
                                </td>

                            </tr>

                        </table>
                    </div>
                </ItemTemplate>




            </asp:Repeater>
            <!-- Repeater Ends -->
        </div>
        <!-- Container Div Ends -->
        <%--        <!-- Popup Div Starts -->
        <div id="popupdiv" style="display: none">
            <table>
                <tbody>
                    <tr>
                        <td>
                            <label class="label">
                                Employee Id:</label>
                        </td>
                        <td>
                            <label id="lblEmpId">
                            </label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <label class="label">
                                Name:</label>
                        </td>
                        <td>
                            <label id="lblEmpName">
                            </label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <label class="label">
                                Location:</label>
                        </td>
                        <td>
                            <label id="lblEmpLocation">
                            </label>
                        </td>
                    </tr>
                </tbody>
            </table>
        </div>
        <!-- Popup Div Ends -->--%>

        <!-- Donate Modal -->
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
                                <label id="lblEmpLocation">
                                </label>
                                <asp:TextBox ID="reviewTextBox" runat="server" CssClass="form-control" placeholder="Write Review..."></asp:TextBox>
                            </div>
                        </div>

                        <%--<div class="row">
                            <div class="form-group col-md-12">
                                <asp:Button ID="saveButton" runat="server" Text="Save" OnClick="saveButton_OnClick" CssClass="btn btn-primary pull-left" />
                            </div>
                        </div>--%>
                    </div>
                </div>
            </div>
        </div>
        <!-- /.modal -->
    </form>
</body>
</html>
