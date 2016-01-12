<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage/CenterMasterPageUI.Master" AutoEventWireup="true" CodeBehind="TreatmentUI.aspx.cs" Inherits="FinalProjectAPP.UI.CenterUI.TreatmentUI" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TittlePlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="HeaderPlaceHolder" runat="server">
    <style type="text/css">
        #form1 {
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <form id="form1" runat="server">
        <div>
            <fieldset style="height: 597px; width: 946px; margin-left: 205px;">
                <legend style="width: 113px; height: 23px;">Treatment Given</legend>

                <br />
                <div style="text-align: right; width: 625px; height: 205px; margin-left: 219px" id="box">




                    <div style="width: 431px; margin-left: 0px">
                        <asp:Label ID="Label1" runat="server" Text="Voter ID"></asp:Label>
                        &nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="voterIdTextBox" runat="server" Width="165px"></asp:TextBox>
                        <br />
                        <asp:Button ID="showDetailsButton" runat="server" Text="Show Details" OnClick="showDetailsButton_Click" />

                        <br />

                        <br />

                        <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
                        &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="nameTextBox" runat="server" Width="165px"></asp:TextBox>

                        <br />

                        <asp:Label ID="Label3" runat="server" Text="Address"></asp:Label>
                        &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="addressTextBox" runat="server" Width="165px"></asp:TextBox>

                        <br />

                        <asp:Label ID="Label4" runat="server" Text="Age"></asp:Label>
                        &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="ageTextBox" runat="server" Width="165px"></asp:TextBox>

                        <br />

                        <br />

                        <asp:Label ID="Label5" runat="server" Text="Service Given"></asp:Label>
                        &nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="serviceNumberTextBox" runat="server" Width="85px"></asp:TextBox>
                        &nbsp;&nbsp;
                        <asp:Label ID="Label6" runat="server" Text="times"></asp:Label>

                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

                        <br />



                    </div>



                    <br />
                    <div style="text-align: center; height: 327px;">
                        <asp:Label ID="Label7" runat="server" Text="Show All History"></asp:Label>
                        <br />
                        <br />


                        <asp:Label ID="Label8" runat="server" Text="Observation"></asp:Label>
                        &nbsp;
                        <asp:TextBox ID="observationTextBox" runat="server"></asp:TextBox>

                        &nbsp;&nbsp;&nbsp;&nbsp;
        
         <asp:Label ID="Label9" runat="server" Text="Date"></asp:Label>

                        &nbsp;&nbsp;&nbsp;<asp:TextBox ID="dateTextBox" runat="server"></asp:TextBox>
                        
                        
                        &nbsp;<br />
                        <br />
&nbsp;<asp:Label ID="Label10" runat="server" Text="Doctor"></asp:Label>
                        &nbsp;
                        <asp:DropDownList ID="doctorDropDownList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="docterDropDownList_SelectedIndexChanged"></asp:DropDownList>

                        <br />
                        <br />

                        <asp:Label ID="Label11" runat="server" Text="Disease"></asp:Label>
                        &nbsp;
        <asp:DropDownList ID="diseaseDropDownList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="diseaseDropDownList_SelectedIndexChanged"></asp:DropDownList>

                        &nbsp;&nbsp;&nbsp;&nbsp;
        
        <asp:Label ID="Label12" runat="server" Text="Medicine"></asp:Label>
                        &nbsp;
                        <asp:DropDownList ID="medicineDropDownList" runat="server" OnSelectedIndexChanged="medicineDropDownList_SelectedIndexChanged"></asp:DropDownList>

                        &nbsp;&nbsp;&nbsp;
        
        <asp:Label ID="Label13" runat="server" Text="Dose"></asp:Label>
                        &nbsp;
        <asp:DropDownList ID="doseDropDownList" runat="server" OnSelectedIndexChanged="doseDropDownList_SelectedIndexChanged">
            <asp:ListItem>1-1-1</asp:ListItem>
            <asp:ListItem>1-0-1</asp:ListItem>
            <asp:ListItem>0-0-1</asp:ListItem>
            <asp:ListItem>1-0-0</asp:ListItem>
            <asp:ListItem>1-1-0 </asp:ListItem>
        </asp:DropDownList>

                        &nbsp;&nbsp;&nbsp;&nbsp;

        <br />
                        <br />

                        <asp:RadioButton ID="RadioButton1" runat="server" Text="Before Meal" GroupName="afterBefore" />
                        <br />
                        <asp:RadioButton ID="RadioButton2" runat="server" Style="text-align: left" Text="After Meal" GroupName="afterBefore" />

                        <br />
                        <br />

                        <asp:Label ID="Label14" runat="server" Text="Quantity Given"></asp:Label>
                        &nbsp;
        <asp:TextBox ID="quantityTextBox" runat="server"></asp:TextBox>

                        &nbsp;&nbsp;&nbsp;&nbsp;
        
        <asp:Label ID="Label15" runat="server" Text="Note"></asp:Label>
                        &nbsp;
        <asp:TextBox ID="noteTextBox" runat="server"></asp:TextBox>

                        &nbsp;
        <asp:Button ID="addButton" runat="server" Text="Add" OnClick="addButton_Click" Width="61px" />
                        <br />

                        &nbsp;&nbsp;
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label16" runat="server"></asp:Label>
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </div>

                </div>
                <br />
            </fieldset>
        </div>
                        <div style="text-align: center">
                            <asp:GridView ID="treatmentGridView" runat="server" Style="margin-left: 349px; text-align: center;" Width="626px"></asp:GridView>

                        </div>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="saveButton" runat="server" Text="Save" OnClick="saveButton_Click" Width="127px" style="text-align: center; margin-left: 431px" />
                        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="massegeLabel" runat="server"></asp:Label>
    </form>
    <br />
    <br />
    <br />
</asp:Content>
