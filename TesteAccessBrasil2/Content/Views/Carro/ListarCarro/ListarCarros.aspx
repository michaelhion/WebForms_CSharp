<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListarCarros.aspx.cs" Inherits="TesteAccessBrasil2.Content.Views.ListarCarro.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="id" DataSourceID="Carros" ForeColor="#333333" GridLines="None" Height="291px" Width="1141px">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                    <asp:BoundField DataField="Codigo" HeaderText="Codigo" SortExpression="Codigo" />
                    <asp:BoundField DataField="Codigo_Marca" HeaderText="Codigo_Marca" SortExpression="Codigo_Marca" />
                    <asp:BoundField DataField="Modelo" HeaderText="Modelo" SortExpression="Modelo" />
                    <asp:BoundField DataField="Ano" HeaderText="Ano" SortExpression="Ano" />
                    <asp:BoundField DataField="cor" HeaderText="cor" SortExpression="cor" />
                </Columns>
                <EditRowStyle BackColor="#7C6F57" />
                <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#E3EAEB" />
                <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F8FAFA" />
                <SortedAscendingHeaderStyle BackColor="#246B61" />
                <SortedDescendingCellStyle BackColor="#D4DFE1" />
                <SortedDescendingHeaderStyle BackColor="#15524A" />
            </asp:GridView>
            <asp:SqlDataSource ID="Carros" runat="server" ConnectionString="<%$ ConnectionStrings:CarrosConnectionString %>" SelectCommand="SELECT [id], [Codigo], [Codigo_Marca], [Modelo], [Ano], [cor] FROM [Carro]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
