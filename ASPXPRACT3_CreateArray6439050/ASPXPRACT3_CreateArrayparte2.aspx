<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ASPXPRACT3_CreateArrayparte2.aspx.cs" Inherits="ASPXPRACT3_CreateArray6439050.ASPXPRACT3_CreateArrayparte2" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Parte 2 - Categorías</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Use Category Array</h2>
            <asp:TextBox ID="txtIndex" runat="server"></asp:TextBox>
            <asp:Button ID="btnLookup" runat="server" Text="Lookup" OnClick="btnLookup_Click" />
            <asp:Label ID="lblCategory" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>

