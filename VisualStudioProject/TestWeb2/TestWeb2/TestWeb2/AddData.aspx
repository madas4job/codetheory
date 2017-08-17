<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddData.aspx.cs" Inherits="TestWeb2.AddData" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        User Id :&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="userid" runat="server"></asp:TextBox>
        <br />
        Blood Glucose :&nbsp;
        <asp:TextBox ID="glucose" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="addButton" runat="server" OnClick="Button1_Click" Text="Add" />
    </form>
</body>
</html>
