<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage/HeadofficeMasterPageUI.Master" AutoEventWireup="true" CodeBehind="MedicineEntryUI.aspx.cs" Inherits="FinalProjectAPP.UI.MedicineEntryUI1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TittlePlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="HeaderPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
     <form id="form1" runat="server">
        <div align="center" style="height: 399px; width: 866px">
        <fieldset style="width: 508px; height: 131px; margin-top: 98px">
            <legend>New Medicine</legend>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Name of Medicine with Mg/Ml "></asp:Label>
        <asp:TextBox ID="medicineNameTextBox" runat="server" style="margin-left: 8px" Width="200px"></asp:TextBox>
            <br />
            <asp:Label ID="Label4" runat="server"></asp:Label>
            <br />
        <asp:Button ID="saveButton" runat="server" Text="Save" Width="125px" OnClick="saveButton_Click" />
    
            <br />
    
            <asp:Label ID="saveLabel" runat="server"></asp:Label>
    
            <br />

        </fieldset>            <br />
            <asp:GridView ID="medicineGridView" runat="server" AllowPaging="True" OnPageIndexChanging="medicineGridView_PageIndexChanging" style="margin-top: 59px" Width="519px">
            </asp:GridView>
    
    </div>
    </form>
</asp:Content>
