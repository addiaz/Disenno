<%@ Page Title="" Language="C#" MasterPageFile="~/Aplicacion/PrincipalAdministrador.Master" AutoEventWireup="true" CodeBehind="EliminarEstudiante.aspx.cs" Inherits="PAMTEC.Aplicacion.EliminarEstudiante" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

   
    <form id="form1" runat="server">
        <p>
            <br />
     
   
        <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" style="z-index: 1; width: 688px; height: 197px; position: absolute; top: 320px; left: 536px; font-family: 'Century Gothic'; font-size: medium;" Visible="False" OnRowDeleting="Eliminar" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" >
            <Columns>
                <asp:CommandField ShowDeleteButton="True" />
            </Columns>
            <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
            <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
            <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
            <RowStyle BackColor="White" ForeColor="#003399" />
            <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
            <SortedAscendingCellStyle BackColor="#EDF6F6" />
            <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
            <SortedDescendingCellStyle BackColor="#D6DFDF" />
            <SortedDescendingHeaderStyle BackColor="#002876" />
        </asp:GridView>
            <asp:TextBox ID="TextBoxNombre" runat="server" style="z-index: 1; position: absolute; top: 229px; left: 659px"></asp:TextBox>
            <asp:Button ID="ButtonBuscar" runat="server" OnClick="Buscar" style="z-index: 1; position: absolute; top: 232px; left: 873px" Text="Ver" />
            <asp:Label ID="LabelMensaje" runat="server" style="z-index: 1; position: absolute; top: 282px; left: 660px; color: #FF0000" Text="Label" Visible="False"></asp:Label>
        </p>
    </form>

</asp:Content>
