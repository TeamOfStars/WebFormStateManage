<%@ page language="C#" autoeventwireup="true" codebehind="Anasayfa.aspx.cs" inherits="StateManage.Anasayfa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView runat="server" ID="grid" OnRowCommand="grid_RowCommand" AutoGenerateColumns="false" DataKeyNames="categoryId">
                <Columns>
                    <asp:BoundField  DataField="categoryName" HeaderText="Kategori Adı" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:TextBox ID="min" runat="server" Width="35" ></asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:TextBox ID="max" runat="server" Width="35"></asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>
                        <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton Text="Arama Yap" ID="aramayap" CommandName="arama" CommandArgument='<%#Eval("CategoryID") %>'
                            runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
                </Columns>
                
            </asp:GridView>

        </div>
    </form>
</body>
</html>
