<%@ Page Title="" Language="C#" MasterPageFile="~/Aplicacion/PrincipalAdministrador.Master" AutoEventWireup="true" CodeBehind="ConsultarCurso.aspx.cs" Inherits="PAMTEC.Aplicacion.ConsultarCurso" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">




    <link href="../css/bootstrap.min.css" rel="stylesheet" />

    <form id="form1" runat="server">

<asp:Panel ID="Panel3" runat="server" Style="z-index: 1; width: 1054px; height: 101px; position: absolute; top: 171px; left: 356px; font-family: 'Century Gothic'; font-size: large">
                <div class="text-justify">
                    <span style="font-family: 'Century Gothic';"><strong>En esta sección se pueden observar todos los cursos existentes en el sistema administrador del programa PAMTEC. </strong>  </span>
                </div>
            </asp:Panel>

        <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" style="z-index: 1; width: 576px; height: 127px; position: absolute; top: 244px; left: 486px; font-family: 'Century Gothic'; font-size: medium;" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" CssClass="table table-responsive">
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
    </form>






    <img alt="" src="../Images/cursos.jpg" style="width: 240px; height: 178px; z-index: 1; position: absolute; top: 246px; left: 1106px" />






</asp:Content>