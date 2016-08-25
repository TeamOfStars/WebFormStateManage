<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SessionUygulama.aspx.cs" Inherits="StateManage.SessionUygulama" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="txt_kullanici" runat="server" />
        <asp:RequiredFieldValidator ErrorMessage="boş geçillemez" ControlToValidate="txt_kullanici" runat="server" ValidationGroup="grup"  Text="!" ForeColor="Red" />
        <asp:TextBox ID="txt_sifre" runat="server" />
        <asp:RequiredFieldValidator ErrorMessage="boş geçillemez" ControlToValidate="txt_sifre" runat="server" ValidationGroup="grup"  Text="!" ForeColor="Red"  />
        <asp:Button Id="btn_giris" Text="giriş" runat="server" ValidationGroup="grup" OnClick="btn_giris_Click" />
        <asp:Label ID="lbl" Text="" runat="server" />
        <asp:ValidationSummary ShowMessageBox="true" ValidationGroup="grup" runat="server" HeaderText="sayfadaki hatalar" />
    </div>
    </form>
</body>
</html>
