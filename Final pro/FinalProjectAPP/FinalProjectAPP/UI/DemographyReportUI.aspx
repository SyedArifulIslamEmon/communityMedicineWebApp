<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage/HeadofficeMasterPageUI.Master" AutoEventWireup="true" CodeBehind="DemographyReportUI.aspx.cs" Inherits="FinalProjectAPP.UI.DemographyReportUI" %>
<%@ Register TagPrefix="cc1" Namespace="EGIS.Web.Controls" Assembly="EGIS.Web.Controls, Version=4.3.0.0, Culture=neutral, PublicKeyToken=05b98c869b5ffe6a" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TittlePlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="HeaderPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    
     <form id="form1" runat="server">
    
    <div>
        Select Custom Render Settings<br />
        <asp:DropDownList ID="DropDownList1" runat="server" Width="175px">
            <asp:ListItem>Please Select..</asp:ListItem>
            <asp:ListItem>Population Density</asp:ListItem>
         
        </asp:DropDownList>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Generate Map"
            Width="103px" /><br />
                     
    <cc1:SFMap ID="SFMap1" runat="server" Height="964px" Width="861px" ProjectName="~/bangladesh.egp" style="border-right: gray thin dashed; border-top: gray thin dashed; border-left: gray thin dashed; border-bottom: gray thin dashed" MaxZoomLevel="1000" MinZoomLevel="0.5"   CacheOnClient="false" />    
    <cc1:MapPanControl ID="MapPanControl1" runat="server"  MapReferenceId="SFMap1" style="z-index: 100; left: 20px; position: absolute; top: 200px; text-align: center" />        
    </div>

    </form>

</asp:Content>
