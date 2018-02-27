<%@ Page Title="" Language="C#" MasterPageFile="~/JobSeekerMasterPage.Master" AutoEventWireup="true" CodeBehind="UpdateProfileJobSeeker.aspx.cs" Inherits="UpWorkWeb.UpdateProfileJobSeeker" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHead" runat="server">
    <title>Update Profile</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <br />
    <br />
    <br />
    <br />
    <br />
    <div class="container-fluid" style="background-color: #dcdcdc; min-height: 100vh">

        <div class="container panel">

            <h2 style="color: #1e90ff">My Profile</h2>
            <hr style="border: 1px solid; color: #1e90ff" />
            <div class="panel panel-primary">
                <div class="panel-heading">
                    <asp:Label ID="nameLabel" runat="server" Text=""></asp:Label>
                </div>
                <div class="panel-body">
                    <div class="row">
                        <div class="col-md-3 col-lg-3 " align="center">
                            <asp:Image ID="profileImage" runat="server" CssClass="img-rounded img-responsive" Height="300" Width="300" />
                            <br />
                            <p style="background-color: #dcdcdc; border-radius: 5px;">
                                <label>Change Picture</label>

                                <asp:FileUpload ID="FileUpload1" runat="server" CssClass="form-control" />
                                <br />
                                <a style="color: #1e90ff" class="btn" href="ChangePasswordJobSeeker.aspx">Change Password</a>

                            </p>
                        </div>
                        <div class=" col-md-9 col-lg-9 " style="background-color: #dcdcdc; border-radius: 5px;">
                            <table class="table table-user-information">
                                <tbody>
                                    <tr>
                                        <td>Full Name:
                                        </td>
                                        <td>
                                            <asp:TextBox ID="fullNameTextBox" runat="server" CssClass="form-control" placeholder="full name..."></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidatorfullname" runat="server" ErrorMessage="*" ControlToValidate="fullNameTextBox" ForeColor="red"></asp:RequiredFieldValidator>

                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Date of Birth</td>
                                        <td>
                                            <asp:TextBox ID="birthDateTextBox" runat="server" CssClass="form-control" TextMode="Date"></asp:TextBox>

                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Gender:</td>
                                        <td>
                                            <asp:DropDownList ID="genderDropDownList" runat="server" CssClass="form-control">
                                                <asp:ListItem>...Select One...</asp:ListItem>
                                                <asp:ListItem>Male</asp:ListItem>
                                                <asp:ListItem>Female</asp:ListItem>
                                                <asp:ListItem>Others</asp:ListItem>
                                            </asp:DropDownList>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" ForeColor="red" ControlToValidate="genderDropDownList" InitialValue="...Select One..."></asp:RequiredFieldValidator>


                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Nationality</td>
                                        <td>
                                            <%--<asp:TextBox ID="nationnalityTextBox" runat="server" CssClass="form-control"></asp:TextBox>--%>
                                            <asp:DropDownList ID="nationnalityDropDownList" runat="server" CssClass="form-control"></asp:DropDownList>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="*" ForeColor="red" ControlToValidate="nationnalityDropDownList"></asp:RequiredFieldValidator>

                                        </td>
                                    </tr>
                                    <%--<tr>
                                        <td>Expert In:</td>
                                        <td>
                                            <asp:Label ID="categoryLabel" runat="server" Text=""></asp:Label></td>
                                    </tr>--%>
                                    <tr>
                                        <td>Email:</td>
                                        <td>
                                            <asp:TextBox ID="emailTextBox" runat="server" CssClass="form-control" placeholder="email..."></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ForeColor="red" ControlToValidate="emailTextBox"></asp:RequiredFieldValidator>


                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Phone:</td>
                                        <td>
                                            <asp:TextBox ID="phnTextBox" runat="server" CssClass="form-control"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="*" ForeColor="red" ControlToValidate="phnTextBox"></asp:RequiredFieldValidator>


                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Location:</td>
                                        <td>
                                            <asp:TextBox ID="locationTextBox" runat="server" CssClass="form-control"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ErrorMessage="*" ForeColor="red" ControlToValidate="locationTextBox"></asp:RequiredFieldValidator>


                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Type:</td>
                                        <td>
                                            <asp:DropDownList ID="typeDropDownList" runat="server" CssClass="form-control">
                                                <asp:ListItem>...Select One...</asp:ListItem>
                                                <asp:ListItem>Online</asp:ListItem>
                                                <asp:ListItem>Offline</asp:ListItem>
                                            </asp:DropDownList>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ErrorMessage="*" ForeColor="red" ControlToValidate="typeDropDownList"></asp:RequiredFieldValidator>


                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Payment Procedure:</td>
                                        <td>
                                            <asp:DropDownList ID="paymentProcedureDropDownList" runat="server" CssClass="form-control">
                                                <asp:ListItem>...Select One...</asp:ListItem>
                                                <asp:ListItem>Bkash</asp:ListItem>
                                                <asp:ListItem>Rocket</asp:ListItem>
                                            </asp:DropDownList>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ErrorMessage="*" ForeColor="red" ControlToValidate="paymentProcedureDropDownList"></asp:RequiredFieldValidator>

                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Rate:</td>
                                        <td>
                                            <asp:TextBox ID="rateTextBox" runat="server" CssClass="form-control" TextMode="Number" min="0" placeholder="taka per day"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ErrorMessage="*" ForeColor="red" ControlToValidate="rateTextBox"></asp:RequiredFieldValidator>


                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Available Time:</td>
                                        <td>
                                            <asp:TextBox ID="availableStartTextBox" runat="server" CssClass="form-control" TextMode="Time"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="*" ForeColor="red" ControlToValidate="availableStartTextBox"></asp:RequiredFieldValidator>
                                            <asp:TextBox ID="availableEndTextBox" runat="server" CssClass="form-control" TextMode="Time"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage="*" ForeColor="red" ControlToValidate="availableEndTextBox"></asp:RequiredFieldValidator>


                                        </td>
                                    </tr>
                                    <tr>
                                        <td>Comments and Links:</td>
                                        <td>
                                            <asp:TextBox ID="commentTextBox" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>

                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <asp:Button ID="editButton" runat="server" Text="Update" CssClass="btn btn-primary" OnClick="editButton_OnClick" />
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
