<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/JobProviderMasterPage.Master"  CodeBehind="MessageNotificationJobProvider.aspx.cs" Inherits="UpWorkWeb.MessageNotificationJobProvider" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHead" runat="server">
    <title>Message Notification</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
            <div class="container-fluid" style="background-color: #dcdcdc; min-height: 100vh">
                <br />
                <br />
                <br />
                <br />
                <div class="container panel">

                    <h1 style="color: #1e90ff">Message Notification</h1>
                    <hr />
                    <div>
                        <asp:Button ID="makeReadButton" runat="server" Text="Make Read" OnClick="makeReadButton_Click" />
                        <asp:Repeater ID="notificationRepeater" runat="server">
                            <ItemTemplate>
                                <div class="">
                                    <table class="table table-hover table-responsive table-striped">

                                        <tr>
                                            <td>
                                                <%#Eval("Sender")%>---
                                    <%#Eval("Msg")%>---
                                            </td>
                                            <td>
                                                <%#Eval("SendingDate")%>
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