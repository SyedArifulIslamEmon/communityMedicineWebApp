<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage/CenterMasterPageUI.Master" AutoEventWireup="true" CodeBehind="MedicineStockReportUI.aspx.cs" Inherits="FinalProjectAPP.UI.CenterUI.MedicineStockReportUI" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TittlePlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="HeaderPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <form id="form1" runat="server">
    <div style="width: 945px; text-align: center; margin-left: 0px">
    <fieldset style="width: 557px; height: 234px; margin-left: 171px">
        <legend>Medicine Stock</legend>
        <asp:GridView ID="medicineStockGridView" runat="server" Height="161px" style="margin-left: 36px; margin-top: 46px" Width="481px"></asp:GridView>
    </fieldset>
    </div>
    </form>
</asp:Content>
