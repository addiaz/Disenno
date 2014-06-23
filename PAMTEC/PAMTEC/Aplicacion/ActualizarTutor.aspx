<%@ Page Title="" Language="C#" MasterPageFile="~/Aplicacion/PrincipalAdministrador.Master" AutoEventWireup="true" CodeBehind="ActualizarTutor.aspx.cs" Inherits="PAMTEC.Aplicacion.ActualizarTutor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="from1" runat="server">

  <asp:Panel ID="Panel3" runat="server" Style="z-index: 1; width: 1054px; height: 101px; position: absolute; top: 215px; left: 215px; font-family: 'Century Gothic'; font-size: large">
                <div class="text-justify">
                    <span style="font-family: 'Century Gothic';"><strong>En esta sección se brinda la opción de actualizar un tutor existente en el sistema administrador del programa PAMTEC. A continuación se muestra el formulario </strong>  </span>
                </div>
            </asp:Panel>


    <asp:Panel ID="Panel1" runat="server" Style="z-index: 1; width: 1101px; height: 500px; position: absolute; top: 344px; left: 262px; color: #333333; border-style: outset; border-width: 6px; margin-left: 4px; margin-top: 10px">
            <asp:Label ID="Label1" runat="server" Text="Nombre:" Style="z-index: 1; position: absolute; top: 125px; left: 84px; font-family: 'Century Gothic'; font-size: large"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Style="z-index: 1; position: absolute; top: 198px; left: 85px; font-family: 'Century Gothic'; font-size: large" Text="Apellidos:"></asp:Label>
            <asp:TextBox ID="TextBoxNombre" runat="server" Style="left: 294px; top: 114px"></asp:TextBox>
            <asp:TextBox ID="TextBoxApellidos" runat="server" Style="left: 294px; top: 188px; width: 189px;"></asp:TextBox>
            <asp:Button ID="Button1"  class="btn btn-primary"  runat="server" Style="left: 816px; top: 362px; width: 187px;" Text="Actualizar" OnClick="Button1_Click" />
            <asp:Label ID="Label3" runat="server" Style="z-index: 1; position: absolute; top: 59px; left: 86px; font-family: 'Century Gothic'; font-size: large; width: 83px" Text="Carnet:"></asp:Label>
            <asp:Label ID="Label4" runat="server" Style="z-index: 1; position: absolute; top: 282px; left: 84px; font-family: 'Century Gothic'; font-size: large;" Text="Fecha Nacimiento:"></asp:Label>
            <asp:Label ID="Label5" runat="server" Style="z-index: 1; position: absolute; top: 58px; left: 603px; font-family: 'Century Gothic'; font-size: large;" Text="Número de Teléfono:"></asp:Label>
            <asp:Label ID="Label6" runat="server" Style="z-index: 1; position: absolute; top: 279px; left: 615px; font-family: 'Century Gothic'; font-size: large;" Text="Correo:"></asp:Label>
            <asp:Label ID="Label7" runat="server" Style="z-index: 1; position: absolute; top: 128px; left: 606px; font-family: 'Century Gothic'; font-size: large;" Text="Categoria:"></asp:Label>
            <asp:TextBox ID="TextBoxCarnet" runat="server" Style="left: 295px; top: 44px" ReadOnly="True"></asp:TextBox>
                  
           
        
            <asp:TextBox ID="TextBoxTel"  runat="server" Style="left: 811px; top: 49px"></asp:TextBox>
            <asp:DropDownList ID="DropDownList1" runat="server" Style="left: 815px; top: 124px; height: 36px; z-index: 1; position: absolute">
                <asp:ListItem>Asistencia Especial</asp:ListItem>
                <asp:ListItem>Horas Beca</asp:ListItem>
                <asp:ListItem>Voluntariado</asp:ListItem>
            </asp:DropDownList>
            <asp:TextBox ID="TextBoxDireccion" runat="server" Style="left: 816px; top: 194px"></asp:TextBox>

            <asp:TextBox ID="TextBoxFecha" runat="server" Style="left: 294px; top: 262px; height: 50px;" ReadOnly="True"></asp:TextBox>
            <asp:Label ID="Label8" runat="server" Style="z-index: 1; position: absolute; top: 201px; left: 606px; font-family: 'Century Gothic'; font-size: large;" Text="Dirección:"></asp:Label>
            <asp:TextBox ID="TextBoxCorreo" runat="server"></asp:TextBox>
          
        </asp:Panel>
          <asp:Label ID="LabelMensaje" runat="server" style="z-index: 1; position: absolute; top: 324px; left: 504px; color: #FF0000" Text="Label" Visible="False"></asp:Label>
         
           <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" style="z-index: 1; width: 280px; height: 127px; position: absolute; top: 371px; left: 497px" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
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
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
</form>
    </asp:Content>