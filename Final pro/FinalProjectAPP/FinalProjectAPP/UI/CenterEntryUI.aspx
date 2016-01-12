<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage/HeadofficeMasterPageUI.Master" AutoEventWireup="true" CodeBehind="CenterEntryUI.aspx.cs" Inherits="FinalProjectAPP.UI.CenterEntryUI1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TittlePlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="HeaderPlaceHolder" runat="server">
    <style type="text/css">
        #form1 {
            height: 354px;
            width: 585px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    
    
    <form id="form2" runat="server">
    <div align="center" style="height: 388px">
    
           
        <fieldset style="width: 484px; margin-top: 22px; height: 325px;">
            <legend class="auto-style2">Center Entry</legend>
                <div style="width: 371px; text-align: right; height: 293px; margin-left: 0px;">
                     <br />
                     <br />
                     <br />
                     <br />
                     <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="centerNameTextBox" runat="server" Width="250px"></asp:TextBox>
                        <br />
                        <br />
                        <asp:Label ID="Label2" runat="server" Text="District"></asp:Label>
            &nbsp;&nbsp;&nbsp;
                        <asp:DropDownList ID="districtDropDownList" runat="server" Height="16px" Width="260px" AutoPostBack="True" OnSelectedIndexChanged="districtDropDownList_SelectedIndexChanged">
                        </asp:DropDownList>
                        <br />
                        <br />
                        <asp:Label ID="Label3" runat="server" Text="Thana"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:DropDownList ID="thanaDropDownList" runat="server" Height="19px" Width="260px" OnSelectedIndexChanged="thanaDropDownList_SelectedIndexChanged">
                        </asp:DropDownList>
                        <br />
                        <br />
                        <asp:Label ID="Label4" runat="server"></asp:Label>
                        <asp:Button ID="saveButton" runat="server" Text="Save" OnClick="saveButton_Click" Width="120px" />

                
                </div>
            
        </fieldset><br />
              
        <br />
    
    </div>
    </form>
    
    
    
    


</asp:Content>
