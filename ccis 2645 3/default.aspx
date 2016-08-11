<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="ccis_2645_3._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 457px; top: 94px; position: absolute" Text="Main Menu"></asp:Label>
        <asp:Button ID="btnReports" runat="server" Enabled="False" style="z-index: 1; left: 455px; top: 337px; position: absolute" Text="Reports" />
        <asp:Button ID="btnService" runat="server" OnClick="btnService_Click" style="z-index: 1; left: 457px; top: 209px; position: absolute" Text="Service" />
        <asp:Button ID="btnProblem" runat="server" Enabled="False" style="z-index: 1; left: 450px; top: 274px; position: absolute" Text="Problem" />
        <asp:Button ID="btnTechnician" runat="server" OnClick="btnTechnician_Click" style="z-index: 1; left: 446px; top: 411px; position: absolute" Text="Technician" />
    
    </div>
    </form>
</body>
</html>
