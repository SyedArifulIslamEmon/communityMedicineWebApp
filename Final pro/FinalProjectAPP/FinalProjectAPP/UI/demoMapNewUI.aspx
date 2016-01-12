<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage/HeadofficeMasterPageUI.Master" AutoEventWireup="true" CodeBehind="demoMapNewUI.aspx.cs" Inherits="FinalProjectAPP.UI.demoMapNewUI" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TittlePlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="HeaderPlaceHolder" runat="server">
    <script type="text/javascript" src="https://www.google.com/jsapi"></script>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    
    <form id="form1" runat="server">

    <div>

        <asp:Literal ID="lt" runat="server"></asp:Literal>  

       <div id="chart_div" style="width: 650px; height: 350px;"></div>      
    </div>

   </form>

</asp:Content>
