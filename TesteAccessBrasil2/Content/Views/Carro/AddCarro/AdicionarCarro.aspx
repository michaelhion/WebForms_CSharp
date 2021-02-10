<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdicionarCarro.aspx.cs" Inherits="TesteAccessBrasil2.Content.Views.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="../../bootstrap.css" rel="stylesheet" />

    <title>Adicionar carro</title>
</head>
<body>
    <div style=" width:200px;margin-left:auto;margin-right:auto; margin-top:30px">
    <form id="form1" runat="server">
        <div class="container" >
            <asp:Label ID="Codigo" runat="server" Text="Codigo" ></asp:Label><br />
            <asp:TextBox ID="TextCod" runat="server"></asp:TextBox>  <br /><br />       
            
            <asp:Label ID="CodMarca" runat="server" Text="Codigo da marca"></asp:Label><br />
            <asp:TextBox ID="TextCodMarca" runat="server"></asp:TextBox><br /><br />
            
            <asp:Label ID="Modelo" runat="server" Text="Modelo"></asp:Label><br />
            <asp:TextBox ID="TextModel" runat="server"></asp:TextBox><br /><br />

            <asp:Label ID="Ano" runat="server" Text="Ano de fabricação"></asp:Label><br />
            <asp:TextBox ID="TextAno" runat="server"></asp:TextBox><br /><br />

            <asp:Label ID="Cor" runat="server" Text="Cor"></asp:Label><br />
            <asp:TextBox ID="TextCor" runat="server"></asp:TextBox><br /><br />

            <asp:Button ID="enviar" runat="server" Text="enviar" OnClick="enviar_Click" />
        </div>
    </form>
        </div>
</body>
</html>
