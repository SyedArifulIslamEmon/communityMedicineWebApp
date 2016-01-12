<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage/HeadofficeMasterPageUI.Master" AutoEventWireup="true" CodeBehind="DiseaseWiseReportUI.aspx.cs" Inherits="FinalProjectAPP.UI.CenterUI.DiseaseWiseReportUI" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TittlePlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="HeaderPlaceHolder" runat="server">
    <style type="text/css">
        #endDateText {
            width: 135px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
     <form id="form1" runat="server">
    <div style="width: 1050px; height: 536px; margin-left: 0px">
    <fieldset style="height: 242px; width: 521px; margin-left: 401px; margin-bottom: 0px;">
        <legend>Disease Wise Report</legend>
        <br />
        <div style="text-align: right; width: 473px; height: 235px">
        <br />
            <br />
            <br />
        <asp:Label ID="Label1" runat="server" Text="Select Disease"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="selectDropDownList" runat="server" Width="200px">
        </asp:DropDownList>
&nbsp;&nbsp;
        <asp:Button ID="selectButton" runat="server" Text="Select" Width="70px" OnClick="selectButton_Click" style="height: 26px" />
            <br />
            <br />
        <asp:Label ID="Label2" runat="server" Text="Date Between"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="startTextBox" runat="server"></asp:TextBox>
            &nbsp; TO &nbsp;&nbsp;&nbsp;
       <asp:TextBox ID="endTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="massegeLabel" runat="server"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        </div>
        <br />
        
    </fieldset>
        <br />
        <br />
        <br />
        <div style="width: 810px">
            <fieldset style="width: 519px; height: 173px; margin-left: 404px">
                <asp:GridView ID="diseaseGridView" runat="server" style="margin-left: 23px; margin-top: 21px; text-align: center;" Width="464px">
        </asp:GridView>
            </fieldset>
        </div>
        
    </div>
    </form>
</asp:Content>
