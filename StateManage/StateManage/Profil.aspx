<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Profil.aspx.cs" Inherits="StateManage.Profil" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <p>Kullanıcı Adı :</p>
    <asp:Label ID="lblKullanici" runat="server"></asp:Label>
        <p>Şifre :</p>
        <asp:Label ID="lblSifre" runat="server"></asp:Label>
        <asp:Button runat="server" ID="btnyonlendir" Text="Yönlendir" OnClick="btnyonlendir_Click"/>
    </div>
    </form>
</body>
</html>
