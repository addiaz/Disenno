<%@ Page Title="" Language="C#" MasterPageFile="~/Aplicacion/PrincipalTutor.Master" AutoEventWireup="true" CodeBehind="ConsultarEstudianteTutor.aspx.cs" Inherits="PAMTEC.Aplicacion.ConsultarEstudianteTutor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../css/bootstrap.min.css" rel="stylesheet" />
    <form id="form1" runat="server">
        <br />
        <asp:Panel ID="Panel1" runat="server" style="z-index: 1; width: 716px; height: 302px; position: absolute; top: 260px; left: 415px; color: #333333; border-style: outset; border-width: 6px; margin-left: 4px; margin-top: 10px">
            <asp:Label ID="Label1" runat="server" Text="Nombre:" style="z-index: 1; position: absolute; top: 57px; left: 144px; font-family: 'Century Gothic'; font-size: large"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" style="z-index: 1; position: absolute; top: 141px; left: 145px; font-family: 'Century Gothic'; font-size: large" Text="Apellidos:"></asp:Label>
            <asp:TextBox ID="TextBoxNombre" runat="server" style="left: 353px; top: 43px"></asp:TextBox>
            <asp:TextBox ID="TextBoxApellidos" runat="server" style="left: 355px; top: 119px"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" style="left: 361px; top: 206px; width: 187px;" Text="Consultar" OnClick="Button1_Click" />
            <asp:Label ID="LabelMensaje" runat="server" style="z-index: 1; position: absolute; top: 176px; left: 379px; color: #FF0000" Text="LabelMensaje" Visible="False"></asp:Label>
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
        <asp:Panel ID="Panel2" runat="server" style="z-index: 1; width: 179px; height: 208px; position: absolute; top: 307px; left: 1197px">
            <img alt="" src="../Images/iconoUsuario.jpg" style="width: 177px; height: 200px" />
        </asp:Panel>
        <br />
        <br />
       
        <asp:GridView ID="GridView1" runat="server" CellPadding="4" style="z-index: 1; width: 656px; height: 127px; position: absolute; top: 312px; left: 471px; font-family: 'Century Gothic'; font-size: medium; margin-left: 0px" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CssClass="table table-responsive">
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
        <strong>
        <asp:Panel ID="Panel3" runat="server" style="z-index: 1; width: 1054px; height: 101px; position: absolute; top: 170px; left: 318px; font-family: 'Century Gothic'; font-size: large">
            <div class="text-justify">
                <span style="font-family: 'Century Gothic'; ">En esta sección se brinda la opción de consultar los estudiantes que estan inscritos en el programa PAMTEC. Se puede realizar una búsqueda de un estudiante en específico ya sea por nombre, por apellidos o ambos. Si quiere ver todo los estudiantes dar click
                <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">aquí</asp:LinkButton>
                . A continuación se muestra el formulario de búsqueda </span>
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
