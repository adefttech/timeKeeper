<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="CS_006._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="timeKeeperForm" runat="server">
        Sonny&#39;s Time Sheet Keeper!<p>
            Enter date worked and how many hours for that day.</p>
        <p>
            Date:&nbsp;
            <asp:TextBox ID="dateTextbox" runat="server" OnTextChanged="dateTextbox_TextChanged"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp; Hours worked:&nbsp;
            <asp:TextBox ID="hoursTextbox" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="addButton" runat="server" OnClick="submitButton_Click" Text="Add Time" />
        </p>
        <asp:Label ID="resultLabel" runat="server" Text="..."></asp:Label>
    </form>
</body>
</html>
