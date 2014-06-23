<%@ Page Title="" Language="C#" MasterPageFile="~/Aplicacion/PrincipalAdministrador.Master" AutoEventWireup="true" CodeBehind="EliminarTutor.aspx.cs" Inherits="PAMTEC.Aplicacion.EliminarTutor" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server" style="margin-left: 40px">

    <asp:Panel ID="Panel3" runat="server" Style="z-index: 1; width: 1054px; height: 64px; position: absolute; top: 194px; left: 334px; font-family: 'Century Gothic'; font-size: large">
                <div class="text-justify">
                    <span style="font-family: 'Century Gothic';"><strong>A continuación se muestra una tabla con los tutores y su respectiva informacion. Si desea filtrar los resultados indique el nombre en el siguiente espacio:</strong></span></div>
            </asp:Panel>
     
   
        <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" style="z-index: 1; width: 688px; height: 197px; position: absolute; top: 345px; left: 348px; font-family: 'Century Gothic'; font-size: medium;" Visible="False" OnRowDeleting="Eliminar" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" >
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
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" style="z-index: 1; position: absolute; top: 277px; left: 879px" Text="Ver" OnClick="Button2_Click" />
        <asp:Label ID="LabelMensaje" runat="server" style="z-index: 1; position: absolute; top: 318px; left: 576px; color: #FF0000" Text="Label" Visible="False"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="TextBoxNombre" runat="server" style="z-index: 1; position: absolute; top: 274px; left: 652px"></asp:TextBox>
        <br />
        <br />
        <br />
        <br />
        
    </form>


</asp:Content>



