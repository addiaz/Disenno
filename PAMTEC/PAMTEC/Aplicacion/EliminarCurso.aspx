<%@ Page Title="" Language="C#" MasterPageFile="~/Aplicacion/PrincipalAdministrador.Master" AutoEventWireup="true" CodeBehind="EliminarCurso.aspx.cs" Inherits="PAMTEC.Aplicacion.EliminarCurso" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server" style="margin-left: 40px">

    <asp:Panel ID="Panel3" runat="server" Style="z-index: 1; width: 1054px; height: 101px; position: absolute; top: 184px; left: 365px; font-family: 'Century Gothic'; font-size: large">
                <div class="text-justify">
                    <span style="font-family: 'Century Gothic';"><strong>A continuación se muestra una tabla con los cursos existentes y su respectiva informacion. Si desea filtrar los resultados por nombre o por código del curso dar clic 
                        
                </div>
            </asp:Panel>
        <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" style="z-index: 1; width: 709px; height: 197px; position: absolute; top: 273px; left: 493px; font-family: 'Century Gothic'; font-size: medium;" Visible="False" OnRowDeleting="Eliminar" >
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

        <br />
        <br />
        

        <asp:Label ID="Label3" runat="server" style="z-index: 1; position: absolute; top: 494px; left: 527px; width: 35px; height: 20px; color: #FF0000" Text="Label" Visible="False"></asp:Label>
        

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

