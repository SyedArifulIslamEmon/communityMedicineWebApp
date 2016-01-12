<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage/HeadofficeMasterPageUI.Master" AutoEventWireup="true" CodeBehind="DiseaseEntryUI.aspx.cs" Inherits="FinalProjectAPP.UI.DiseaseEntryUI1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TittlePlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="HeaderPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <form id="form1" runat="server">
    <div align="center" style="height: 605px; width: 874px;">
    
        <fieldset style="width: 463px; height: 304px">
            <legend style="text-align: left">Disease Entry</legend>
            <div style="height: 230px; text-align: right; width: 418px">
                <br />
                <asp:Label ID="Label" runat="server" Text="Name"></asp:Label>
                &nbsp;&nbsp;
        <asp:TextBox ID="diseaseNameTextBox" runat="server" Width="250px" Height="20px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Description"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="descriptionTextBox" runat="server" TextMode="MultiLine" Width="250px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Treatment Procedure"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="treatmentProcedureTextBox" runat="server" TextMode="MultiLine" Width="250px" style="margin-left: 0px"></asp:TextBox>
                <br />
                <br />
        <asp:Button ID="saveButton" runat="server" Text="Save" OnClick="saveButton_Click" Height="30px" style="margin-left: 0px" Width="99px" />
            </div>
        <asp:Label ID="savelable" runat="server"></asp:Label>
        </fieldset>
        <br />
        <br />
        <br />
        <asp:GridView ID="dieseaseGridView" runat="server" Width="497px">
        </asp:GridView>
    
    </div>
    </form>
</asp:Content>
