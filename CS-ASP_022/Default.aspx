<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS_ASP_022.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            From:</div>
        <asp:RadioButton ID="fromChicagoRadio" runat="server" Text="Chicago" GroupName="fromCity" />
        <br />
        <br />
        <asp:RadioButton ID="fromNewYorkRadio" runat="server" Text="New York" GroupName="fromCity" />
        <br />
        <br />
        <asp:RadioButton ID="fromLondonRadio" runat="server" Text="London" GroupName="fromCity" />
        <br />
        <br />
        To:<br />
        <br />
        <asp:RadioButton ID="toChicagoRadio" runat="server" Text="Chicago" GroupName="toCity"  />
        <br />
        <br />
        <asp:RadioButton ID="toNewYorkRadio" runat="server" Text="New York" GroupName="toCity" />
        <br />
        <br />
        <asp:RadioButton ID="toLondonRadio" runat="server" Text="London" GroupName="toCity" />
        <br />
        <br />
        <asp:Button ID="okButton" runat="server" OnClick="okButton_Click" Text="OK" />
        <br />
        <br />
        Ticket Price: <asp:Label ID="resultLabel" runat="server"></asp:Label>
    </form>
</body>
</html>
