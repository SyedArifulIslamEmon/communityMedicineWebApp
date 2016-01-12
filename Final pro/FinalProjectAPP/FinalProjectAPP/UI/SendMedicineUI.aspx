<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage/HeadofficeMasterPageUI.Master" AutoEventWireup="true" CodeBehind="SendMedicineUI.aspx.cs" Inherits="FinalProjectAPP.UI.SendMedicineUI1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TittlePlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="HeaderPlaceHolder" runat="server">
    <style type="text/css">
        .auto-style1 {
            font-size: x-large;
        }
        .auto-style2 {
            font-size: large;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    
    <form id="form1" runat="server">
    <div align="center" style="height: 388px">
    
            <div style="height: 372px; margin-right: 0px">
        <fieldset style="width: 484px; margin-top: 22px; height: 325px;">
            <legend class="auto-style2">Send Medicine</legend>
                <div style="width: 371px; text-align: right; height: 293px; margin-left: 0px;">
                    <br />
                    <br />
                <asp:Label ID="Label1" runat="server" Text="District"></asp:Label>
        &nbsp;
        <asp:DropDownList ID="districtNameDropDownList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="districtNameDropDownList_SelectedIndexChanged1" style="margin-left: 0px" Width="250px">
            <asp:ListItem></asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Thana"></asp:Label>
        &nbsp;
        <asp:DropDownList ID="thanaDropDownList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="thanaDropDownList_SelectedIndexChanged" Height="19px" Width="250px">
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Center"></asp:Label>
        &nbsp;<asp:DropDownList ID="centerDropDownList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="centerDropDownList_SelectedIndexChanged" Width="250px" style="margin-left: 0px">
        </asp:DropDownList>
        <br />
                    <br />
        <asp:Label ID="Label4" runat="server" Text="Select Medicine"></asp:Label>
                    &nbsp;
        <asp:DropDownList ID="selectMedicineDropDownList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="selectMedicineDropDownList_SelectedIndexChanged" Width="250px">
        </asp:DropDownList>
                    <br />
                    <br />
&nbsp;<asp:Label ID="Label6" runat="server" Text="Quantity"></asp:Label>
&nbsp;<asp:TextBox ID="quantityTextBox" runat="server" Width="243px" style="margin-left: 4px"></asp:TextBox>
                    <br />
                <br />
&nbsp;<asp:Button ID="addButton" runat="server" Text="Add" Width="101px" OnClick="addButton_Click" />
                </div>
            
        </fieldset><br />
                <br />
        <br />
        <br />
            </div>
        &nbsp;<br />
        <legend><strong><span class="auto-style1">Medicine List</legend></span></strong>
        <asp:GridView ID="medicineQueueGridView" runat="server" OnSelectedIndexChanged="medicineQueueGridView_SelectedIndexChanged" Width="513px" style="margin-top: 25px">
        </asp:GridView>
        <br />
        <asp:Button ID="saveButton" runat="server" Text="Save" Width="128px" OnClick="saveButton_Click" Height="33px" />
    
        <br />
    
        <br />
        <asp:Label ID="textLabel" runat="server" Text=""></asp:Label>
        <br />
    
    </div>
    </form>

</asp:Content>
