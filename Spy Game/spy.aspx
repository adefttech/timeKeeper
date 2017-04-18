<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="spy.aspx.cs" Inherits="Spy_Game.spy" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            Spy New Assignment Form<br />
            <br />
            Spy Code Name
            <asp:TextBox ID="spyName" runat="server"></asp:TextBox>
            <br />
            <br />
            New Assignment Name
            <asp:TextBox ID="assName" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Calendar ID="myCalendar" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Start Assignment" />
        </div>
    </form>
</body>
</html>
