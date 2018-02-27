<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FaceBookLogin.aspx.cs" Inherits="UpWorkWeb.FaceBookLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-1.9.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container-fluid" style="background-color: #dcdcdc; min-height: 100vh">
            <nav class="navbar navbar-default navbar-fixed-top" role="navigation">
                <div class="container-fluid">
                    <!-- Brand and toggle get grouped for better mobile display -->
                    <div class="navbar-header">
                        <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1">
                            <span class="sr-only">Toggle navigation</span>
                            <span class="icon-bar"></span>
                            <span class="icon-bar"></span>
                            <span class="icon-bar"></span>
                        </button>
                        <a class="navbar-brand" href="#">Brand</a>
                    </div>

                    <!-- Collect the nav links, forms, and other content for toggling -->
                    <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
                        <ul class="nav navbar-nav">
                            <li><a href="Default.aspx">Home</a></li>
                            <li><a href="JobList.aspx">Find Job</a></li>
                            <li><a href="PostJobByJobProvider.aspx">Hire People</a></li>
                        </ul>
                        <ul class="nav navbar-nav navbar-right">
                            <li><a href="#">Dashboard</a></li>
                            <li class="dropdown">
                                <a href="#" class="dropdown-toggle" data-toggle="dropdown">Register <b class="caret"></b></a>
                                <ul class="dropdown-menu">
                                    <li><a href="RegisterJobSeeker.aspx">Register as Job Seeker</a></li>
                                    <li><a href="RegisterCompanyAccountJobProvider.aspx">Register as Job Provider(Company)</a></li>
                                    <li><a href="RegisterPersonalAccountJobProvider.aspx">Register as Job Provider(Personal)</a></li>
                                </ul>
                            </li>
                        </ul>
                    </div>
                    <!-- /.navbar-collapse -->
                </div>
                <!-- /.container-fluid -->
            </nav>


        <div class="container" style="background-color: #dcdcdc">
            <div class="col-md-12">
                <br />
                <br />
                <br />
                <br />
                <h1 style="color: #1e90ff;">Registration form for Job Seeker by FaceBook</h1>
                <br />
                <br />
                <hr />
            </div>
            <div class="col-md-6">
                <asp:Image ID="Image1" runat="server" CssClass="img-responsive img-rounded"/>

                <div class="form-group col-lg-6">
                    <label>Full Name</label>
                    <asp:Label ID="nameLabel" runat="server" CssClass="form-control"></asp:Label>
                </div>
                <div class="form-group col-lg-6">
                    <label>Email</label>
                    <asp:Label ID="emailLabel" runat="server" CssClass="form-control"></asp:Label>
                </div>
                <div class="form-group col-lg-6">
                    <label>Gender</label>
                    <asp:Label ID="genderLabel" runat="server" CssClass="form-control"></asp:Label>

                </div>
                <div class="form-group col-lg-6">
                    <label>Facebook Id</label>
                    <asp:Label ID="facebookIdLabel" runat="server" CssClass="form-control"></asp:Label>
                </div>

                <div class="form-group col-lg-6">
                    <label>Date of birth</label>
                    <%--<asp:TextBox ID="birthDateTextBox" runat="server" CssClass="form-control"></asp:TextBox>--%>
                    <input type="date" id="birthDateTextBox" runat="server" class="form-control" required />
                </div>
                <div class="form-group col-lg-6">
                    <label>Password(if u deactivate ur Fb)</label>
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
                    <asp:TextBox ID="nationnalityTextBox" runat="server" CssClass="form-control"></asp:TextBox>
                    <%--<asp:DropDownList ID="nationDropDownList" runat="server">
            </asp:DropDownList>--%>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="*" ForeColor="red" ControlToValidate="nationnalityTextBox"></asp:RequiredFieldValidator>
                </div>
                <div class="form-group col-lg-12">
                    <label>Category</label>
                    <asp:DropDownList ID="categoryDropDownList" runat="server" CssClass="form-control">
                        <asp:ListItem>...Select One...</asp:ListItem>
                        <asp:ListItem>web</asp:ListItem>
                        <asp:ListItem>design</asp:ListItem>
                        <asp:ListItem>nothing</asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="*" ForeColor="red" ControlToValidate="categoryDropDownList" InitialValue="...Select One..."></asp:RequiredFieldValidator>
                </div>
                <div class="form-group col-lg-12">
                    <label>About You</label>
                    <asp:TextBox ID="commentTextBox" runat="server" TextMode="MultiLine" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-sm-6">
                    <input type="checkbox" class="checkbox" />Agree with our terms & conditions.
			
                </div>

                <div class="col-sm-6">
                    <input type="checkbox" class="checkbox" />Send notifications to this email
		
                    <br />
                    <br />
                </div>

                <asp:Button ID="saveButton" runat="server" Text="Save" OnClick="saveButton_Click" />
            </div>

            <div class="col-md-6">
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
            </div>
        </div>
    </form>
</body>
</html>
