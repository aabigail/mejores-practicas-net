<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BuscarPersona.aspx.cs" Inherits="MejoresPracticasWeb.Persona.BuscarPersona" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Página sin título</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table border="0" cellpadding="0" cellspacing="0">
            <tr>
                <td colspan="2">
                    <asp:Label ID="Label1" runat="server" Text="Buscar Persona"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Nombres y Apellidos :"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtNombresApellidos" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
                </td>
                <td align="right"">
                     <asp:Button ID="btnBuscar" runat="server" Text="Buscar" 
                         onclick="btnBuscar_Click" />
                </td>
            </tr>
            <tr>
                 <td colspan="2">
                    <asp:GridView ID="gvPersonas" runat="server" AutoGenerateColumns="False">
                        <Columns>
                            <asp:BoundField DataField="Codigo" HeaderText="Codigo" />
                            <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" />
                            <asp:BoundField DataField="Nombres" HeaderText="Nombres" />
                            <asp:BoundField DataField="Apellidos" HeaderText="Apellidos" />
                        </Columns>
                     </asp:GridView>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
