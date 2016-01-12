<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage/HeadofficeMasterPageUI.Master" AutoEventWireup="true" CodeBehind="NewCenterInfo.aspx.cs" Inherits="FinalProjectAPP.UI.NewCenterInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TittlePlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="HeaderPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <form id="form1" runat="server">
        <div align="center">
            <fieldset style="width: 491px; height: 200px">
                <legend>New Center Information</legend>
                <br />
                <br />
                <asp:Label ID="Label1" runat="server" Text="CENTER NAME : "></asp:Label>
                <asp:Label ID="nameLabel" runat="server" Text=""></asp:Label>
                <br />
                <br />
                <asp:Label ID="Label2" runat="server" Text="CENTER CODE :"></asp:Label>
                <asp:Label ID="codeLabel" runat="server" Text=""></asp:Label>
                <br />
                <br />
                <asp:Label ID="Label3" runat="server" Text="PASSWORD :"></asp:Label>
                <asp:Label ID="passLabel" runat="server" Text=""></asp:Label>
                <br />
            </fieldset>
        </div>
    </form>

</asp:Content>
