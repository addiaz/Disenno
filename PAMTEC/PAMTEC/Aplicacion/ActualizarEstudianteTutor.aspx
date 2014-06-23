<%@ Page Title="" Language="C#" MasterPageFile="~/Aplicacion/PrincipalTutor.Master" AutoEventWireup="true" CodeBehind="ActualizarEstudianteTutor.aspx.cs" Inherits="PAMTEC.Aplicacion.ActualizarEstudianteTutor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="from1" runat="server">
<asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4"  style="z-index: 1; width: 650px; height: 203px; position: absolute; top: 372px; left: 518px; font-family: 'Century Gothic'; font-size: medium;" OnSelectedIndexChanged="Editar" >
   
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

 <asp:Panel ID="Panel3" runat="server" Style="z-index: 1; width: 1054px; height: 101px; position: absolute; top: 185px; left: 407px; font-family: 'Century Gothic'; font-size: large">
                <div class="text-justify">
                    <span style="font-family: 'Century Gothic';"><strong>En esta sección se brinda la opción de actualizar un curso existente en el sistema administrador del programa PAMTEC. A continuación se muestra el formulario </strong>  </span>
                </div>
            </asp:Panel>
  <asp:Panel ID="Panel1" runat="server" Style="z-index: 1; width: 1101px; height: 500px; position: absolute; top: 257px; left: 416px; color: #333333; border-style: outset; border-width: 6px; margin-left: 4px; margin-top: 10px" Visible="False">
            <asp:Label ID="Label1" runat="server" Text="Nombre:" Style="z-index: 1; position: absolute; top: 125px; left: 84px; font-family: 'Century Gothic'; font-size: large"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Style="z-index: 1; position: absolute; top: 198px; left: 85px; font-family: 'Century Gothic'; font-size: large" Text="Apellidos:"></asp:Label>
            <asp:TextBox ID="TextBoxNombre" runat="server" Style="left: 294px; top: 114px"></asp:TextBox>
            <asp:TextBox ID="TextBoxApellidos" runat="server" Style="left: 294px; top: 188px; width: 189px;"></asp:TextBox>
            <asp:Button ID="Button1"  class="btn btn-primary"  runat="server" Style="left: 820px; top: 290px; width: 187px;" Text="Actualizar" OnClick="Button1_Click"/>
            <asp:Label ID="Label3" runat="server" Style="z-index: 1; position: absolute; top: 59px; left: 86px; font-family: 'Century Gothic'; font-size: large; width: 83px" Text="Cédula:"></asp:Label>
            <asp:Label ID="Label4" runat="server" Style="z-index: 1; position: absolute; top: 282px; left: 84px; font-family: 'Century Gothic'; font-size: large;" Text="Fecha Nacimiento:"></asp:Label>
            <asp:Label ID="Label5" runat="server" Style="z-index: 1; position: absolute; top: 58px; left: 603px; font-family: 'Century Gothic'; font-size: large;" Text="Número de Teléfono:"></asp:Label>
            <asp:TextBox ID="TextBoxCedula" runat="server" Style="left: 295px; top: 44px" ReadOnly="True"></asp:TextBox>
            <asp:TextBox ID="TextBoxNumeroTelefono"  runat="server" Style="left: 811px; top: 49px"></asp:TextBox>
            <asp:TextBox ID="TextBoxDireccion" runat="server" Style="left: 811px; top: 121px"></asp:TextBox>

            <asp:TextBox ID="TextBoxfchNacimiento" runat="server" Style="left: 294px; top: 262px; height: 50px;" ReadOnly="True"></asp:TextBox>
            <asp:Label ID="Label8" runat="server" Style="z-index: 1; position: absolute; top: 128px; left: 609px; font-family: 'Century Gothic'; font-size: large;" Text="Dirección:"></asp:Label>
            
        </asp:Panel>
        <asp:TextBox ID="TextBoxBuscaNombre" runat="server" style="left: 605px; top: 286px"></asp:TextBox>
        <asp:Button ID="ButtonBuscar" runat="server" Text="Ver" OnClick="ButtonBuscar_Click" style="z-index: 1; position: absolute; top: 292px; left: 828px" />
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="LabelMensaje" runat="server" style="z-index: 1; position: absolute; top: 369px; left: 427px; color: #FF0000" Text="Label" Visible="False"></asp:Label>
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

