<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewState.aspx.cs" Inherits="StateManage.ViewState" EnableViewState="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox runat="server"  ID="txtIsim"/>
        <asp:Button Text="Ekle" runat="server" ID="btnEkle" OnClick="btnEkle_Click" />
        <asp:ListBox runat="server" ID="lstBoxIsim" >
        </asp:ListBox>
    </div>
    </form>
</body>
</html>
