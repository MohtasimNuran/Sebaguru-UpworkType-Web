<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/JobProviderMasterPage.Master" CodeBehind="PostJobByJobProvider.aspx.cs" Inherits="UpWorkWeb.PostJobByJobProvider" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHead" runat="server">
    <title>Post Job</title>
</asp:Content>
<asp:content id="Content2" contentplaceholderid="ContentPlaceHolderBody" runat="server">
            
            <div class="container panel" style="background-color: #dcdcdc">
                <br />
            <br />
            <br />
            <br />
                <div class="col-md-3">
                </div>
                <div class="col-md-5 panel">
                    <h1 style="color: #1e90ff;"><strong>Post Job</strong></h1>
                    <hr />
                    <asp:Label ID="Label7" runat="server" Text="Title"></asp:Label>
                    <asp:TextBox ID="jobTitleTextBox" runat="server" CssClass="form-control" placeholder="job title"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorfullname" ValidationGroup="Group1" runat="server" ErrorMessage="*" ControlToValidate="jobTitleTextBox" ForeColor="red"></asp:RequiredFieldValidator>
                    <br />
                    <asp:RadioButton ID="onlineRadioButton" runat="server" GroupName="onOrOff" Text="Online" AutoPostBack="True" OnCheckedChanged="onlineRadioButton_CheckedChanged" />
                    <asp:RadioButton ID="offlineRadioButton" runat="server" GroupName="onOrOff" Text="Offline" AutoPostBack="True" Checked="True" OnCheckedChanged="offlineRadioButton_CheckedChanged" />
                    <br />
                    <asp:Label ID="locationLabel" runat="server" Text="Location"></asp:Label>
                    <asp:TextBox ID="locationTextBox" runat="server" CssClass="form-control" placeholder="location..."></asp:TextBox>
                    <br />

                    <asp:Label ID="Label6" runat="server" Text="Category"></asp:Label>
                    <asp:DropDownList ID="categoryDropDownList" runat="server" CssClass="form-control">
                        <asp:ListItem>...select one...</asp:ListItem>
                        <asp:ListItem>web</asp:ListItem>
                        <asp:ListItem>design</asp:ListItem>
                        <asp:ListItem>nothing</asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ValidationGroup="Group1" runat="server" ErrorMessage="*" ControlToValidate="categoryDropDownList" ForeColor="red" InitialValue="...select one..."></asp:RequiredFieldValidator>
                    <br />
                    <asp:Label ID="Label" runat="server" Text="Job Responsibility"></asp:Label>
                    <asp:TextBox ID="jobResponseTextBox" runat="server" CssClass="form-control" TextMode="MultiLine" placeholder="job responsibility in details"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ValidationGroup="Group1" runat="server" ErrorMessage="*" ControlToValidate="jobResponseTextBox" ForeColor="red"></asp:RequiredFieldValidator>
                    <br />
                    <asp:Label ID="Label2" runat="server" Text="Important Message"></asp:Label>
                    <asp:TextBox ID="msgTextBox" runat="server" CssClass="form-control" placeholder="message(not necessary)"></asp:TextBox>
                    <br />
                    <asp:Label ID="Label3" runat="server" Text="Deadline"></asp:Label>
                    <asp:TextBox ID="deadLineTextBox" runat="server" CssClass="form-control" TextMode="Date"></asp:TextBox>
<%--                    <input type="date" id="deadLineTextBox" runat="server" class="form-control" />--%>

                    <br />
                    <asp:Label ID="Label4" runat="server" Text="Cover Photo"></asp:Label>
                    <asp:FileUpload ID="FileUpload1" runat="server" />
                    <br />
                    <asp:Label ID="Label5" runat="server" Text="Payment"></asp:Label>
                    <asp:TextBox ID="paymentTextBox" runat="server" CssClass="form-control" placeholder="in taka"></asp:TextBox><br />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ValidationGroup="Group1" runat="server" ErrorMessage="*" ControlToValidate="paymentTextBox" ForeColor="red"></asp:RequiredFieldValidator>
                    <asp:DropDownList ID="perDropDownList" runat="server" CssClass="form-control">
                        <asp:ListItem>...select one...</asp:ListItem>
                        <asp:ListItem>/hour</asp:ListItem>
                        <asp:ListItem>/day</asp:ListItem>
                        <asp:ListItem>/week</asp:ListItem>
                        <asp:ListItem>/month</asp:ListItem>
                        <asp:ListItem>/year</asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ValidationGroup="Group1" runat="server" ErrorMessage="*" ControlToValidate="perDropDownList" ForeColor="red" InitialValue="...select one..."></asp:RequiredFieldValidator>
                    <br />
                    <br />
                    <asp:Button ID="postButton" ValidationGroup="Group1" CssClass="btn btn-primary" runat="server" OnClick="postButton_Click" Text="Post" />
                    <br />
                    <br />
                    <br />
                </div>



                <div class="col-md-4"></div>
            </div>
</asp:content>
