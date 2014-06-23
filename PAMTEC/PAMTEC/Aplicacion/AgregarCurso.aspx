<%@ Page Title="" Language="C#" MasterPageFile="~/Aplicacion/PrincipalAdministrador.Master" AutoEventWireup="true" CodeBehind="AgregarCurso.aspx.cs" Inherits="PAMTEC.Aplicacion.AgregarCurso" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <!-- Bootstrap core CSS -->
    <link href="../css/bootstrap.min.css" rel="stylesheet">
    <link href="../css/varAdministrador.css" rel="stylesheet">
    <form class= "form-inline" role="form" id="form1" runat="server">


        <br />
        <asp:Panel ID="Panel1" class="panel panel-default" runat="server" Style="z-index: 1; width: 690px; height: 464px; position: absolute; top: 271px; left: 549px; color: #333333; border-style: outset; border-width: 6px; margin-left: 4px; margin-top: 10px">
            <asp:Label ID="Label1" runat="server" Text="Nombre:" Style="z-index: 1; position: absolute; top: 131px; left: 84px; font-family: 'Century Gothic'; font-size: large"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Style="z-index: 1; position: absolute; top: 212px; left: 84px; font-family: 'Century Gothic'; font-size: large" Text="Descripción:"></asp:Label>
            <asp:TextBox ID="TextBoxNombre" runat="server" Style="left: 294px; top: 121px"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" class="btn btn-primary" OnClick="Button1_Click" Style="left: 292px; top: 330px; width: 187px;" Text="Agregar" />
            <asp:Label ID="Label3" runat="server" Style="z-index: 1; position: absolute; top: 59px; left: 86px; font-family: 'Century Gothic'; font-size: large; width: 83px" Text="Código:"></asp:Label>
            <asp:TextBox ID="TextBoxCodigo" runat="server" Style="left: 295px; top: 44px; "></asp:TextBox>
            <textarea id="TextArea1" runat="server" cols="20" name="S1" rows="2" style="left: 293px; top: 199px"></textarea><asp:Label ID="Label4" runat="server" style="z-index: 1; position: absolute; top: 269px; left: 299px; width: 184px; color: #FF0000" Text="Label" Visible="False"></asp:Label>
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

        <strong>
            <asp:Panel ID="Panel3" runat="server" Style="z-index: 1; width: 1054px; height: 101px; position: absolute; top: 181px; left: 333px; font-family: 'Century Gothic'; font-size: large">
                <div class="text-justify">
                    <span style="font-family: 'Century Gothic';">En esta sección se brinda la opción de agregar un nuevo Curso al sistema administrador del programa PAMTEC. A continuación se muestra el formulario para ingresar un nuevo curso </span>
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