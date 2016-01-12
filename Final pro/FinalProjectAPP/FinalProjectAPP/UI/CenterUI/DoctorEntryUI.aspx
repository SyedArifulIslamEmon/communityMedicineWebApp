<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage/CenterMasterPageUI.Master" AutoEventWireup="true" CodeBehind="DoctorEntryUI.aspx.cs" Inherits="FinalProjectAPP.UI.CenterUI.DoctorEntryUI" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TittlePlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="HeaderPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <form id="form1" runat="server" style="width: 1019px; height: 279px; margin-left: 0px">
        <div style="width: 1024px; " >
            <fieldset style="text-align: center; width: 471px; margin-left: 408px">
                <legend>Doctor Entry</legend>
                <div style="text-align: right; width: 378px">
&nbsp;
                
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
&nbsp;&nbsp;
                <br />
                <br />

                <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
                &nbsp;
                <asp:TextBox ID="nameTextBox" runat="server" Width="200px"></asp:TextBox>
                    <br />
                <br />
                <asp:Label ID="Label3" runat="server" Text="Degree"></asp:Label>
                &nbsp;
                <asp:TextBox ID="degreeTextBox" runat="server" Width="200px"></asp:TextBox>
                    <br />
                <br />
                <asp:Label ID="Label4" runat="server" Text="Specialization"></asp:Label>
                &nbsp;
                <asp:TextBox ID="specializationTextBox" runat="server" Width="200px"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="saveButton" runat="server" Text="Save" style="text-align: center; margin-left: 10px" Width="106px" OnClick="saveButton_Click" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                <asp:Label ID="massegeLabel" runat="server"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </div>
                <br />
            </fieldset>
        </div>
    </form>
</asp:Content>
