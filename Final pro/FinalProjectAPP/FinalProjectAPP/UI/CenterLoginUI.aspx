<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage/HeadofficeMasterPageUI.Master" AutoEventWireup="true" CodeBehind="CenterLoginUI.aspx.cs" Inherits="FinalProjectAPP.UI.CenterLoginUI1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TittlePlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="HeaderPlaceHolder" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 105px;
        }
        #passwordTextBox {
            width: 250px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder" runat="server">




    <form id="form2" runat="server">
        <div align="center" style="height: 388px">


            <fieldset style="width: 484px; margin-top: 22px; height: 325px;">
                <legend class="auto-style2">Center Login</legend>


                <div style="width: 372px; text-align: right; margin-top: 11px;">
                    <br />
                    <br />
                    <strong style="font-size: x-large">Center Login&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </strong>
                    <strong style="font-size: large; text-decoration: underline">
                        <br />
                    </strong>
                    <br />
                    <br />
                    <asp:Label ID="Label1" runat="server" Text="Center Code"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="codeTextBox" runat="server" Width="250px"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="Label2" runat="server" Text="Password "></asp:Label>
                    &nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="passwordTextBox" TextMode="Password" runat="server" Width="250px"></asp:TextBox><br />
                    <br />
                    &nbsp;<asp:Button ID="loginButton" runat="server" Text="Login" Width="134px" OnClick="loginButton_Click" Height="32px" />



                    <br />
                    <br />
                    <asp:Label ID="massegeLabel" runat="server"></asp:Label>



                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <br />



                </div>

            </fieldset>
        </div>

    </form>












</asp:Content>
