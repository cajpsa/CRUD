<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-weight: bold;
            background-color: #009933;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    
        <asp:Label ID="lblTitulo" runat="server" Text="Ejemplo de CRUD" style="font-weight: 700; font-size: xx-large; text-align: center; background-color: #999999;"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblCodigo" runat="server" Text="Codigo"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtCodigo" runat="server" Width="200px" MaxLength="8" TextMode="Number"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblNombre" runat="server" Text="Nombre"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtNombre" runat="server" Width="200px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblEstilo" runat="server" Text="Estilo"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtEstilo" runat="server" Width="203px"></asp:TextBox>
            <br />
            <br />

    </div>
       <asp:Button ID="btnBuscar" runat="server" Text="Buscar" CssClass="auto-style1" />  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  <asp:Button ID="btnCrear" runat="server" Text="Insertar" Width="85px" CssClass="auto-style1" OnClick="btnCrear_Click" /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" CssClass="auto-style1" OnClick="btnActualizar_Click" />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="codigo" DataSourceID="SqlDataSource1" ForeColor="Black" GridLines="Horizontal" Width="720px"  OnRowCommand="GridView1_RowCommand">
            <Columns>
                <asp:BoundField DataField="codigo" HeaderText="codigo" InsertVisible="False" ReadOnly="True" SortExpression="codigo" />
                <asp:BoundField DataField="nombre" HeaderText="nombre" SortExpression="nombre" />
                <asp:BoundField DataField="estilo" HeaderText="estilo" SortExpression="estilo" />
                <asp:TemplateField ShowHeader="False" AccessibleHeaderText="Seleccione" HeaderText="Seleccione">
                    <ItemTemplate>
                        <asp:Button  ID="btnSeleccionar" runat="server"  CausesValidation="False"  CommandName="Seleccionar"  Text="Seleccionar"  CommandArgument='<%# Eval("codigo") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#242121" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:bandas_bdConnectionString %>" SelectCommand="SELECT * FROM [banda] ORDER BY [codigo], [nombre]"></asp:SqlDataSource>
        <br />
    </form>
</body>
</html>
