<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ApplicationErrorHAndling.aspx.cs" Inherits="StateManage.ApplicationErrorHAndling" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <<asp:Button Text="Rastgele hata" runat="server"  OnClick="btnRast_Click" ID="btnRast"/>
        <asp:Button Text="Sql Hata" runat="server" Id="btnSql" OnClick="btnSql_Click"/>
    </div>
    </form>
</body>
</html>
