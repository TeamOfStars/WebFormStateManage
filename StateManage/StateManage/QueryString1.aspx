<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QueryString1.aspx.cs" Inherits="StateManage.QueryString" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Repeater runat="server" ID="repeater">
            <ItemTemplate>
                <asp:HyperLink NavigateUrl='<%#Eval("CategoryID","/QueryString1.aspx?cId={0}") %>' runat="server" Text='<%#Eval("CategoryName") %>'/><br/>
            </ItemTemplate>
        </asp:Repeater>
        <br />
        <asp:GridView runat="server" ID="grid">

        </asp:GridView>
    </div>
    </form>
</body>
</html>
