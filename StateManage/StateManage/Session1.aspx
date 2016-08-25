<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Session1.aspx.cs" Inherits="StateManage.Session1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Kullanıcı Adı:
        <asp:TextBox runat="server" id="txtKullanici"/>  
        Şifre
       <asp:TextBox runat="server" id="txtSifre"/>   <br />

        <asp:Button Text="Giris" runat="server" id="btnGiris" OnClick="btnGiris_Click"/>   </div>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
