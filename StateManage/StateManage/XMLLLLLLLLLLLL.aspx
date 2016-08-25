<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="XMLLLLLLLLLLLL.aspx.cs" Inherits="StateManage.XMLLLLLLLLLLLL" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td>Ad:</td>
                <td><asp:TextBox runat="server" ID="tbxAd" /></td>
                <td>
                    <asp:RequiredFieldValidator  ErrorMessage="Ad Boş Geçilemez" ControlToValidate="tbxAd" runat="server" ValidationGroup="kont" Text="*" /></td>
            </tr>
            <tr>
                <td>Soyad:</td>
                <td><asp:TextBox runat="server" ID="soyad" /></td>
                <td>
                    <asp:RequiredFieldValidator ErrorMessage="Soyad Boş Geçilemez" ControlToValidate="soyad" runat="server" ValidationGroup="kont" Text="*" /></td>
                
            </tr>
            <tr>
                <td>Tel:</td>
                <td><asp:TextBox runat="server" ID="tel"/></td>
                <td></td>
            </tr>
            <tr>
                <td>Mail:</td>
                <td><asp:TextBox runat="server" ID="mail" /></td>
                <td>
                    <asp:RegularExpressionValidator ErrorMessage="Uygunsuz Mail" ControlToValidate="mail" ValidationGroup="kont" runat="server" Text="*" />
                </td>
            </tr>
            <tr>
                <td>Cinsiyet:</td>
                <td>
                    <asp:DropDownList runat="server" ID="ddlCins">
                        <asp:ListItem Text="ERKEK" />
                        <asp:ListItem Text="kadın" />
                    </asp:DropDownList></td>
                <td></td>
            </tr>
            <tr>
                
                <td colspan="2"><asp:Button Text="Kaydet" runat="server" ID="kaydet" OnClick="kaydet_Click" ValidationGroup="kont" />
                    <asp:Button Text="Txt Oluştur" runat="server"  ID="btn_txtolustur" OnClick="btn_txtolustur_Click"/>
                </td>
                <td>
                    <asp:ValidationSummary ID="summary" runat="server" Visible="true"  ValidationGroup="kont" ShowMessageBox="true"/>
                    </td>
                
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
