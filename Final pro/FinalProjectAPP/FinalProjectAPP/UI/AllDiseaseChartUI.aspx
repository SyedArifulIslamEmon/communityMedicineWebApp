<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage/HeadofficeMasterPageUI.Master" AutoEventWireup="true" CodeBehind="AllDiseaseChartUI.aspx.cs" Inherits="FinalProjectAPP.UI.AllDiseaseChartUI" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TittlePlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="HeaderPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <form id="form1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="From "></asp:Label>
     <asp:TextBox ID="startTextBox" runat="server"></asp:TextBox><asp:Label ID="Label2" runat="server" Text="To"></asp:Label>
    <asp:TextBox ID="endTextBox" runat="server"></asp:TextBox>
    <asp:Label ID="Label3" runat="server" Text="District"></asp:Label>
    <asp:DropDownList ID="districtDropDownList" runat="server" OnSelectedIndexChanged="districtDropDownList_SelectedIndexChanged">
    </asp:DropDownList>
    <asp:Button ID="Show" runat="server" Text="Show" OnClick="Show_Click" Width="103px" />
    
    
    


        <br />
        <asp:Chart ID="Chart1" runat="server" OnLoad="Chart1_Load" Width="598px"   ImageStorageMode="UseImageLocation" ImageLocation="~/Chart/ChartPic_#SEQ(300,3)">
            <Series>
                <asp:Series ChartType="StackedColumn" Name="Series1">
                </asp:Series>
                
                
            </Series>
            <ChartAreas>
                <asp:ChartArea Name="ChartArea1">
                </asp:ChartArea>
            </ChartAreas>
        </asp:Chart>
        <br />
    </form>
    
    
    


</asp:Content>
