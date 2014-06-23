<%@ Page Title="" Language="C#" MasterPageFile="~/Aplicacion/PrincipalAdministrador.Master" AutoEventWireup="true" CodeBehind="ConsultarGrupo.aspx.cs" Inherits="PAMTEC.Aplicacion.ConsultarGrupo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form id="form1" runat="server">
        <br />
        <asp:Panel ID="Panel1" runat="server" style="z-index: 1; width: 716px; height: 340px; position: absolute; top: 259px; left: 536px; color: #333333; border-style: outset; border-width: 6px; margin-left: 4px; margin-top: 10px">
            <asp:Label ID="Label1" runat="server" Text="Curso:" style="z-index: 1; position: absolute; top: 41px; left: 150px; font-family: 'Century Gothic'; font-size: large; width: 117px;"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" style="z-index: 1; position: absolute; top: 110px; left: 150px; font-family: 'Century Gothic'; font-size: large; right: 485px;" Text="Trimestre:"></asp:Label>
            <asp:Label ID="Label3" runat="server" style="z-index: 1; position: absolute; top: 186px; left: 154px; width: 36px; height: 21px; font-family: 'Century Gothic'; font-size: large;" Text="Carnet:"></asp:Label>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="left: 367px; top: 260px; width: 187px; right: 162px;" Text="Consultar" />
            <asp:DropDownList ID="DropDownList1" runat="server" style="left: 364px; top: 108px; height: 36px">
                <asp:ListItem>I Trimestre</asp:ListItem>
                <asp:ListItem>II Trimestre</asp:ListItem>
            </asp:DropDownList>
            <asp:TextBox ID="TextBox1" runat="server" style="left: 364px; top: 178px"></asp:TextBox>
            <asp:DropDownList ID="DropDownList2" runat="server" style="left: 365px; top: 41px">
                
                <asp:ListItem>C-001</asp:ListItem>
                <asp:ListItem>C-002</asp:ListItem>
                <asp:ListItem>C-003</asp:ListItem>
            </asp:DropDownList>
        </asp:Panel>
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="LabelMensaje" runat="server" style="z-index: 1; position: absolute; top: 512px; left: 924px; color: #FF3300" Text="Label" Visible="False"></asp:Label>
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
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <table class="table">
        <asp:GridView ID="GridView1" runat="server" CellPadding="4" style="z-index: 1; width: 656px; height: 127px; position: absolute; top: 630px; left: 319px; font-family: 'Century Gothic'; font-size: medium; margin-left: 0px" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px">
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
            <tr>
                <td>
                    <img alt="" src="../Images/grupo.jpg" style="width: 168px; height: 161px; z-index: 1; position: absolute; top: 317px; left: 1291px" /></td>
            </tr>
            </table>
        <br />
        <br />
        <br />
        <br />
        <br />
        <strong>
        <asp:Panel ID="Panel3" runat="server" style="z-index: 1; width: 1054px; height: 101px; position: absolute; top: 177px; left: 352px; font-family: 'Century Gothic'; font-size: large">
            <div class="text-justify">
                <span style="font-family: 'Century Gothic'; ">En esta sección se brinda la opción de consultar los grupos por curso que estan inscritos en el programa PAMTEC. Se puede realizar una búsqueda de un grupo en específico  por  medio del curso, el trimestre y año en el que se impartió. A continuación se muestra el formulario de búsqueda </span>
            </div>
        </asp:Panel>
        </strong><b>
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
        </b>
    </form>

</asp:Content>
