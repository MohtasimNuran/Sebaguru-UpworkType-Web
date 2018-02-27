<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/PartialMasterPage.Master" CodeBehind="RegisterPersonalAccountJobProvider.aspx.cs" Inherits="UpWorkWeb.RegisterPersonalAccountJobProvider" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHead" runat="server">
    <title>Register</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <br />
    <br />
    <br />
    <br />
    <br />
    <div class="container panel">

        <div class="col-md-12">

            <h1 style="color: #1e90ff;">Registration form for Job Provider Personal</h1>
            <hr style="height: 1px; background-color: #1e90ff;" />
        </div>
        <div class="col-md-6">


            <div class="form-group col-lg-6">
                <label>Full Name</label>
                <asp:TextBox ID="fullNameTextBox" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorfullname" runat="server" ErrorMessage="*" ControlToValidate="fullNameTextBox" ForeColor="red"></asp:RequiredFieldValidator>
            </div>
            <div class="form-group col-lg-6">
                <label>Email</label>
                <asp:TextBox ID="emailTextBox" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ForeColor="red" ControlToValidate="emailTextBox"></asp:RequiredFieldValidator>
            </div>
            <div class="form-group col-lg-6">
                <label>Date of birth</label>
                <asp:TextBox ID="birthDateTextBox" runat="server" CssClass="form-control" TextMode="Date"></asp:TextBox>
                <%--                        <input type="date" id="birthDateTextBox" runat="server" class="form-control" required />--%>
            </div>
            <div class="form-group col-lg-6">
                <label>Gender</label>
                <asp:DropDownList ID="genderDropDownList" runat="server" CssClass="form-control">
                    <asp:ListItem>...Select One...</asp:ListItem>
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" ForeColor="red" ControlToValidate="genderDropDownList" InitialValue="...Select One..."></asp:RequiredFieldValidator>
            </div>
            <div class="form-group col-lg-6">
                <label>Password</label>
                <asp:TextBox ID="passwordTextBox" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*" ForeColor="red" ControlToValidate="passwordTextBox"></asp:RequiredFieldValidator>
            </div>

            <div class="form-group col-lg-6">
                <label>Repeat Password</label>
                <asp:TextBox ID="reTypePasswordTextBox" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="password didn't match" ControlToCompare="passwordTextBox" ControlToValidate="reTypePasswordTextBox" Type="String" Operator="Equal" ForeColor="red"></asp:CompareValidator>
            </div>

            <div class="form-group col-lg-6">
                <label>Phone</label>
                <asp:TextBox ID="phnTextBox" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="*" ForeColor="red" ControlToValidate="phnTextBox"></asp:RequiredFieldValidator>
            </div>
            <div class="form-group col-lg-6">
                <label>Nationality</label>
                <%--<asp:TextBox ID="natinonnalityTextBox" runat="server" CssClass="form-control"></asp:TextBox>--%>
                <asp:DropDownList ID="nationnalityDropDownList" runat="server" CssClass="form-control"></asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="*" ForeColor="red" ControlToValidate="nationnalityDropDownList"></asp:RequiredFieldValidator>
            </div>
            <div class="form-group col-lg-12">
                <label>NID</label>
                <asp:TextBox ID="nIDTextBox" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="*" ForeColor="red" ControlToValidate="nIDTextBox"></asp:RequiredFieldValidator>
            </div>
            <div class="form-group col-lg-12">
                <label>Passport Number</label>
                <asp:TextBox ID="passportNumberTextBox" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="*" ForeColor="red" ControlToValidate="passportNumberTextBox"></asp:RequiredFieldValidator>
            </div>
            <div class="col-sm-12">
                <label>Profile Picture</label>

                <asp:FileUpload ID="FileUpload1" runat="server" CssClass="form-control" />
            </div>
            <%--<div class="col-sm-6">
                <input type="checkbox" class="checkbox" />Agree with our terms & conditions.
			
            </div>

            <div class="col-sm-6">
                <input type="checkbox" class="checkbox" />Send notifications to this email
		
                    <br />
                <br />
            </div>--%>
        </div>

        <div class="col-md-6" style="background-color: #dcdcdc; -webkit-border-radius: 3px">
            <h3 class="dark-grey">Terms and Conditions</h3>
            <p>
                By clicking on "Register" you agree to The Company's' Terms and Conditions
			
            </p>
            <p>
                While rare, prices are subject to change based on exchange rate fluctuations - 
					should such a fluctuation happen, we may request an additional payment. You have the option to request a full refund or to pay the new price. (Paragraph 13.5.8)
			
            </p>
            <p>
                Should there be an error in the description or pricing of a product, we will provide you with a full refund (Paragraph 13.5.6)
			
            </p>
            <p>
                Acceptance of an order by us is dependent on our suppliers ability to provide the product. (Paragraph 13.5.6)
			
            </p>


        </div>
        <br />
        <br />
        <div class="col-md-6">
            <h3 class="dark-grey" style="color: #1e90ff">More Information</h3>
            <hr style="height: 1px; background-color: #1e90ff;" />
            <div class="form-group col-lg-6">
                <label>Location</label>
                <asp:TextBox ID="locationTextBox" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ErrorMessage="*" ForeColor="red" ControlToValidate="locationTextBox"></asp:RequiredFieldValidator>
            </div>
            <div class="form-group col-lg-6">
                <label>Type</label>
                <asp:DropDownList ID="typeDropDownList" runat="server" CssClass="form-control">
                    <asp:ListItem>...Select One...</asp:ListItem>
                    <asp:ListItem>Online</asp:ListItem>
                    <asp:ListItem>Offline</asp:ListItem>
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ErrorMessage="*" ForeColor="red" ControlToValidate="typeDropDownList"></asp:RequiredFieldValidator>
            </div>
            <div class="form-group col-lg-6">
                <label>Payment Procedure</label>
                <asp:DropDownList ID="paymentProcedureDropDownList" runat="server" CssClass="form-control">
                    <asp:ListItem>...Select One...</asp:ListItem>
                    <asp:ListItem>Bkash</asp:ListItem>
                    <asp:ListItem>Rocket</asp:ListItem>
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ErrorMessage="*" ForeColor="red" ControlToValidate="paymentProcedureDropDownList"></asp:RequiredFieldValidator>
            </div>
            <div class="form-group col-lg-6">
                <label>Rate</label>
                <asp:TextBox ID="rateTextBox" runat="server" CssClass="form-control" TextMode="Number" min="0" placeholder="taka per day"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ErrorMessage="*" ForeColor="red" ControlToValidate="rateTextBox"></asp:RequiredFieldValidator>
            </div>
        </div>

        <div class="col-md-12">
            <hr style="height: 1px; background-color: #1e90ff;" />
            <asp:Button ID="registerButton" runat="server" OnClick="registerButton_Click" Text="Register" CssClass="btn btn-success" />
            <br />
            <br />
        </div>
    </div>
</asp:Content>
