<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="technicians2.aspx.cs" Inherits="ccis_2645_3.technicians2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="Button1" runat="server" style="z-index: 1; left: 62px; top: 74px; position: absolute" Text="Return to Main Menu" />
        <asp:Button ID="btnEnter" runat="server" style="z-index: 1; left: 51px; top: 625px; position: absolute" Text="Enter" />
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 162px; top: 625px; position: absolute; right: 275px" Text="Edit" />
        <asp:Button ID="btnReset" runat="server" style="z-index: 1; left: 248px; top: 623px; position: absolute" Text="Reset" />
        <asp:TextBox ID="txtPhone" runat="server" style="z-index: 1; left: 124px; top: 477px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtLastName" runat="server" style="z-index: 1; left: 118px; top: 338px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtHourlyRate" runat="server" style="z-index: 1; left: 122px; top: 532px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 121px; top: 383px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 118px; top: 237px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtDepartment" runat="server" style="z-index: 1; left: 125px; top: 429px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtMiddleInitial" runat="server" style="z-index: 1; left: 115px; top: 286px; position: absolute"></asp:TextBox>
        <asp:DropDownList ID="ddTechnician" runat="server" style="z-index: 1; top: 166px; position: absolute; left: 133px">
        </asp:DropDownList>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 24px; top: 341px; position: absolute" Text="*Last Name"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 27px; top: 240px; position: absolute" Text="*FirstName"></asp:Label>
        <asp:Label ID="Label3" runat="server" ForeColor="Red" style="z-index: 1; left: 44px; top: 555px; position: absolute" Text="*indicates required information"></asp:Label>
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 25px; top: 432px; position: absolute" Text="Department"></asp:Label>
        <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 12px; top: 530px; position: absolute" Text="*Hourly Rate:"></asp:Label>
        <asp:Label ID="Label6" runat="server" style="z-index: 1; left: 29px; top: 387px; position: absolute" Text="Email"></asp:Label>
        <asp:Label ID="Label7" runat="server" style="z-index: 1; left: 29px; top: 167px; position: absolute" Text="Technician"></asp:Label>
        <asp:Label ID="Label8" runat="server" style="z-index: 1; left: 26px; top: 478px; position: absolute" Text="*Phone"></asp:Label>
        <asp:Label ID="Label9" runat="server" style="z-index: 1; left: 21px; top: 290px; position: absolute" Text="Middle Initial"></asp:Label>
        <asp:Label ID="lblErrorMessage" runat="server" style="z-index: 1; left: 13px; top: 675px; position: absolute" Text="(error message)"></asp:Label>
    
    </div>
    </form>
</body>
</html>
