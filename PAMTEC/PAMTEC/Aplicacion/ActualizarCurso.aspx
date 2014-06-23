<%@ Page Title="" Language="C#" MasterPageFile="~/Aplicacion/PrincipalAdministrador.Master" AutoEventWireup="true" CodeBehind="ActualizarCurso.aspx.cs" Inherits="PAMTEC.ActualizarCurso" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="from1" runat="server">
<asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4"  style="z-index: 1; width: 583px; height: 173px; position: absolute; top: 264px; left: 479px; font-family: 'Century Gothic'; font-size: medium;"  OnSelectedIndexChanged="GridView1_SelectedIndexChanged">

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

    <asp:Panel ID="Panel3" runat="server" Style="z-index: 1; width: 1054px; height: 101px; position: absolute; top: 164px; left: 313px; font-family: 'Century Gothic'; font-size: large">
                <div class="text-justify">
                    <span style="font-family: 'Century Gothic';"><strong>En esta sección se brinda la opción de actualizar un curso existente en el sistema administrador del programa PAMTEC. A continuación se muestra el formulario </strong>  </span>
                </div>
            </asp:Panel>
    <asp:Panel ID="Panel1" runat="server" style="z-index: 1; width: 592px; height: 411px; position: absolute; top: 300px; left: 368px; border-style: inset; border-width: 6px; padding: 1px 4px" Visible="False">
        <asp:Label ID="Label9" runat="server" style="z-index: 1; position: absolute; top: 42px; left: 78px; font-family: 'Century Gothic'; font-size: large;" Text="Código:"></asp:Label>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; position: absolute; top: 115px; left: 79px; font-family: 'Century Gothic'; font-size: large; height: 23px;" Text="Nombre:"></asp:Label>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; position: absolute; top: 188px; left: 80px; font-family: 'Century Gothic'; font-size: large;" Text="Descripción:"></asp:Label>
        <asp:TextBox ID="TextBoxCodigo" runat="server" Font-Bold="True" ReadOnly="True" style="left: 250px; top: 37px; height: 29px"></asp:TextBox>
        <asp:TextBox ID="TextBoxNombre" runat="server" Font-Bold="True" style="left: 253px; top: 110px; width: 179px; height: 26px"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" style="left: 263px; top: 289px" Text="Actualizar" OnClick="Button1_Click" />
        <textarea id="TextArea1" runat="server" cols="20" name="S1" rows="2" style="left: 254px; top: 179px"></textarea><asp:Label ID="LabelMensaje" runat="server" style="z-index: 1; position: absolute; top: 265px; left: 351px; color: #FF0000" Text="Label" Visible="False"></asp:Label>
        </asp:Panel>
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
