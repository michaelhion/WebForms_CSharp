<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeletarCarro.aspx.cs" Inherits="TesteAccessBrasil2.Content.Views.DeleteCarro.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Id" runat="server" Text="Id"></asp:Label><br />
            <asp:TextBox ID="TextId" runat="server"></asp:TextBox><br /><br /> 

             <asp:Label ID="Codigo" runat="server" Text="Codigo"></asp:Label><br />
            <asp:TextBox ID="TextCod" runat="server"></asp:TextBox><br /><br />         
            
            <asp:Label ID="CodMarca" runat="server" Text="Codigo da marca"></asp:Label><br />
            <asp:TextBox ID="TextCodMarca" runat="server"></asp:TextBox><br /><br />
            
            <asp:Label ID="Modelo" runat="server" Text="Modelo"></asp:Label><br />
            <asp:TextBox ID="TextModel" runat="server"></asp:TextBox><br /><br />

            <asp:Label ID="Ano" runat="server" Text="Ano de fabricação"></asp:Label><br />
            <asp:TextBox ID="TextAno" runat="server"></asp:TextBox><br /><br />

            <asp:Label ID="Cor" runat="server" Text="Cor"></asp:Label><br />
            <asp:TextBox ID="TextCor" runat="server"></asp:TextBox><br /><br />
            <asp:Button ID="BtnBuscarDados" runat="server" Text="Buscar dados" OnClick="BtnBuscarDados_Click" />
            <asp:Button ID="Deletar" runat="server" Text="Excluir " OnClick="DeletarBtn" />
        </div>
    </form>
</body>
</html>
