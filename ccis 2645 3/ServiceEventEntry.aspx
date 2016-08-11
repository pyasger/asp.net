<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ServiceEventEntry.aspx.cs" Inherits="ccis_2645_3.ServiceEventEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="btnClear" runat="server" style="z-index: 1; left: 279px; top: 432px; position: absolute" Text="Clear" />
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 123px; top: 307px; position: absolute" Text="*Contact:"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 124px; top: 268px; position: absolute" Text="*Client:"></asp:Label>
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 339px; top: 55px; position: absolute" Text="Service Event Entry"></asp:Label>
        <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 125px; top: 212px; position: absolute" Text="Event Date:"></asp:Label>
        <asp:Label ID="lblIR" runat="server" ForeColor="#CC0000" style="z-index: 1; left: 122px; top: 393px; position: absolute" Text="* indicates required information"></asp:Label>
        <asp:Button ID="btnNext" runat="server" style="z-index: 1; left: 118px; top: 437px; position: absolute" Text="Next" />
        <asp:Label ID="Label7" runat="server" style="z-index: 1; left: 122px; top: 345px; position: absolute" Text="*Phone:"></asp:Label>
        <asp:Label ID="lblEM" runat="server" style="z-index: 1; left: 89px; top: 578px; position: absolute" Text="(error message)"></asp:Label>
        <asp:DropDownList ID="ddC" runat="server" style="z-index: 1; left: 257px; top: 264px; position: absolute">
        </asp:DropDownList>
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 254px; top: 307px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 254px; top: 344px; position: absolute"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 174px; top: 139px; position: absolute" Text="Return to Main Menu" />
    
    </div>
    </form>
</body>
</html>
