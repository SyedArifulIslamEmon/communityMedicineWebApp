<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage/CenterMasterPageUI.Master" AutoEventWireup="true" CodeBehind="AllTreatmentHistoryUI.aspx.cs" Inherits="FinalProjectAPP.UI.CenterUI.AllTreatmentHistoryUI" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TittlePlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="HeaderPlaceHolder" runat="server">
   
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    

    <div style="text-align: center">

    <form id="form1" runat="server">

        <div style="text-align: center; height: 989px">
            
            <fieldset style="width: 484px; margin-top: 22px; height: 276px; margin-left: 436px;">
            <legend class="auto-style2">Patient Info</legend>

            <div style="text-align: right; width: 331px; height: 189px; margin-left: 75px; margin-top: 49px;" id="box">
                <asp:Label ID="Label1" runat="server" Text="National ID"></asp:Label>
                &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="nationalIdTextBox" runat="server" Width="200px"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="showButton" runat="server" Text="Show" Width="122px" style="margin-left: 0px" OnClick="showButton_Click" />

                <br />

                <br />

                <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
                &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="nameTextBox" runat="server" Width="200px"></asp:TextBox>

                <br />

                <br />

                <asp:Label ID="Label3" runat="server" Text="Address"></asp:Label>
                &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="addressTextBox" runat="server" Width="200px"></asp:TextBox>

                <br />
                </div>
        </fieldset>
        

        
        <br />
        <br />

        
 <fieldset style="width: 479px; margin-top: 22px; height: 536px; margin-left: 439px;">
                <legend class="auto-style2">Treatment History</legend>
                <div style="height: 297px; text-align: right; width: 406px;">
            <br />
            <asp:Label ID="Label8" runat="server" Text="Treatment n :"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
                    <br />
            <asp:Label ID="Label4" runat="server" Text="Center Name"></asp:Label>
            &nbsp;
            <asp:TextBox ID="centerNameTextBox" runat="server" Width="200px"></asp:TextBox>
                    <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="Date"></asp:Label>
            &nbsp;
            <asp:TextBox ID="dateTextBox" runat="server" Width="200px"></asp:TextBox>
                    <br />
            <br />
            <asp:Label ID="Label6" runat="server" Text="Doctor"></asp:Label>
            &nbsp;
            <asp:TextBox ID="docterTextBox" runat="server" Width="200px"></asp:TextBox>
                    <br />
            <br />
            <asp:Label ID="Label7" runat="server" Text="Observation"></asp:Label>
            &nbsp;
            <asp:TextBox ID="observationTextBox" runat="server" TextMode="MultiLine" Width="200px"></asp:TextBox>
            <br />
            <br />
            <asp:HyperLink ID="pdfHyperLink" runat="server">Convert into PDF</asp:HyperLink>
            <br />
                    <br />
            <div style="width: 472px; height: 202px">

        
        <asp:GridView ID="treatmentHistoryGridView" runat="server" Style="margin-left: 23px; margin-top: 33px; text-align: center;" Width="422px">
        </asp:GridView>
            </div>
        </div>
            </fieldset>
            <br />
            </div>
    </form>
    
        </div>

</asp:Content>
