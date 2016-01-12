<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomeUI.aspx.cs" Inherits="FinalProjectAPP.UI.HomeUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../HomeDesign.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="nav">
        
    <ul>
        <li><a href="CenterEntryUI.aspx">Head office Section</a></li>
        <li><a href="CenterLoginUI.aspx">Center Section</a></li>
    </ul>
        <img src="../communityMedicine.jpg" height="450" width="1360"  />
    </div>
        
        <asp:Label ID="textLabel" runat="server"></asp:Label>
    </form>
    
    
             <div class="footer" align="center">
            Home @ Community Medicine Automation 2015
        </div>
    

</body>
</html>
