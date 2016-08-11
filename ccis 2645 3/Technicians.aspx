<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Technicians.aspx.cs" Inherits="ccis_2645_3.Technicians" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 473px; top: 90px; position: absolute" Text="Technicians Maintenance"></asp:Label>
        <asp:Button ID="btnMM" runat="server" OnClick="btnMM_Click" style="z-index: 1; left: 127px; top: 128px; position: absolute" Text="Return to Main Menu" />
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 125px; top: 326px; position: absolute" Text="*Last Name:"></asp:Label>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 120px; top: 506px; position: absolute" Text="*Hourly Rate:"></asp:Label>
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 122px; top: 419px; position: absolute" Text="Department:"></asp:Label>
        <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 118px; top: 232px; position: absolute" Text="*First Name:"></asp:Label>
        <asp:Label ID="Label6" runat="server" style="z-index: 1; left: 126px; top: 375px; position: absolute" Text="Email:"></asp:Label>
        <asp:Label ID="Label7" runat="server" style="z-index: 1; left: 115px; top: 191px; position: absolute" Text="Technician:"></asp:Label>
        <asp:Label ID="Label8" runat="server" style="z-index: 1; left: 125px; top: 280px; position: absolute" Text="Middle Initial:"></asp:Label>
        <asp:Label ID="Label9" runat="server" style="z-index: 1; left: 119px; top: 463px; position: absolute" Text="*Phone:"></asp:Label>
        <asp:Label ID="Label10" runat="server" ForeColor="#FF5050" style="z-index: 1; left: 118px; top: 550px; position: absolute" Text="*indicates required information"></asp:Label>
        <asp:Button ID="btnRemove" runat="server" style="z-index: 1; left: 872px; top: 726px; position: absolute" Text="Remove" Enabled="False" />
        <asp:DropDownList ID="drpTech" runat="server" style="z-index: 1; left: 270px; top: 187px; position: absolute; width: 175px; height: 20px" AutoPostBack="True" OnSelectedIndexChanged="drpTech_SelectedIndexChanged">
        </asp:DropDownList>
        <asp:Button ID="btnEnter" runat="server" style="z-index: 1; left: 92px; top: 618px; position: absolute" Text="Enter" OnClick="btnEnter_Click" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 211px; top: 618px; position: absolute" Text="Edit" />
        <asp:TextBox ID="txtPh" runat="server" OnTextChanged="txtPh_TextChanged1" style="z-index: 1; left: 281px; top: 457px; position: absolute" MaxLength="11"></asp:TextBox>
        <asp:Button ID="btnReset" runat="server" OnClick="btnReset_Click" style="z-index: 1; left: 315px; top: 622px; position: absolute" Text="Delete" />
        <asp:TextBox ID="txtFN" runat="server" style="z-index: 1; left: 276px; top: 233px; position: absolute; bottom: 423px;" MaxLength="30"></asp:TextBox>
        <asp:TextBox ID="txtEM" runat="server" style="z-index: 1; left: 281px; top: 374px; position: absolute; width: 165px"></asp:TextBox>
        <asp:TextBox ID="txtDP" runat="server" style="z-index: 1; left: 283px; top: 416px; position: absolute; width: 88px"></asp:TextBox>
        <asp:TextBox ID="txtMI" runat="server" style="z-index: 1; left: 278px; top: 275px; position: absolute; width: 40px" MaxLength="1"></asp:TextBox>
        <asp:TextBox ID="txtLN" runat="server" style="z-index: 1; left: 280px; top: 327px; position: absolute" MaxLength="30"></asp:TextBox>
        <asp:TextBox ID="txtHR" runat="server" style="z-index: 1; left: 280px; top: 503px; position: absolute; width: 83px" OnTextChanged="txtHR_TextChanged"></asp:TextBox>
    
        <asp:Label ID="lblEM" runat="server" style="z-index: 1; left: 110px; top: 715px; position: absolute" Text="(error message)"></asp:Label>
    
        <asp:TextBox ID="txtITech" runat="server" style="z-index: 1; left: 556px; top: 188px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label11" runat="server" style="z-index: 1; left: 495px; top: 187px; position: absolute" Text="TechID"></asp:Label>
    
    </div>
        <p>
            &nbsp;</p>
        <asp:Button ID="btnNewTech" runat="server" OnClick="btnNewTech_Click" style="z-index: 1; left: 435px; top: 125px; position: absolute" Text="New Tech" />
    </form>
    </body>
</html>
