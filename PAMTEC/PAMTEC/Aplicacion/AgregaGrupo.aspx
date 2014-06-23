<%@ Page Title="" Language="C#" MasterPageFile="~/Aplicacion/PrincipalAdministrador.Master" AutoEventWireup="true" CodeBehind="AgregaGrupo.aspx.cs" Inherits="PAMTEC.Aplicacion.AgregaGrupo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form id="form1" runat="server">
        <br />
        <asp:Panel ID="Panel1" runat="server" style="z-index: 1; width: 757px; height: 691px; position: absolute; top: 276px; left: 441px; color: #333333; border-style: outset; border-width: 6px; margin-left: 4px; margin-top: 10px">
            <asp:Label ID="Label1" runat="server" Text="Número de Grupo:" style="z-index: 1; position: absolute; top: 41px; left: 164px; font-family: 'Century Gothic'; font-size: large; width: 170px;"></asp:Label>
            <asp:Label ID="Label6" runat="server" style="z-index: 1; position: absolute; top: 405px; left: 164px; font-family: 'Century Gothic'; font-size: large" Text="Aula:"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" style="z-index: 1; position: absolute; top: 110px; left: 164px; font-family: 'Century Gothic'; font-size: large; " Text="Curso:" width="122"></asp:Label>
            <asp:Label ID="Label3" runat="server" style="z-index: 1; position: absolute; top: 186px; left: 164px; width: 36px; height: 21px; font-family: 'Century Gothic'; font-size: large;" Text="Tutor:"></asp:Label>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="left: 389px; top: 574px; width: 187px; right: 181px;" Text="Agregar" />
            <asp:DropDownList ID="DropDownList1" runat="server" style="left: 381px; top: 475px; height: 36px">
                <asp:ListItem>I Trimestre</asp:ListItem>
                <asp:ListItem>II Trimestre</asp:ListItem>
            </asp:DropDownList>
            <asp:TextBox ID="TextBox1" runat="server" style="left: 381px; top: 326px"></asp:TextBox>
            <asp:DropDownList ID="DropDownList2" runat="server" style="left: 381px; top: 103px">
                <asp:ListItem>C-001</asp:ListItem>
                <asp:ListItem>C-002</asp:ListItem>
                <asp:ListItem>C-003</asp:ListItem>
            </asp:DropDownList>
            <asp:TextBox ID="TextBox2" runat="server" style="left: 381px; top: 178px"></asp:TextBox>
            <asp:TextBox ID="TextBox4" runat="server" style="left: 381px; top: 252px"></asp:TextBox>
            <asp:Label ID="Label4" runat="server" style="z-index: 1; position: absolute; top: 258px; left: 164px; font-family: 'Century Gothic'; font-size: large" Text="Fecha Inicio"></asp:Label>
            <asp:Label ID="Label5" runat="server" style="z-index: 1; position: absolute; top: 332px; left: 164px; font-family: 'Century Gothic'; font-size: large" Text="Fecha Final"></asp:Label>
            <asp:Label ID="Label7" runat="server" style="z-index: 1; position: absolute; top: 482px; left: 164px; height: 18px; font-family: 'Century Gothic'; font-size: large" Text="Trimestre:"></asp:Label>
            <asp:DropDownList ID="DropDownList3" runat="server" style="left: 381px; top: 401px">
                <asp:ListItem>LabH</asp:ListItem>
                <asp:ListItem>LabATI</asp:ListItem>
                <asp:ListItem>CIC</asp:ListItem>
            </asp:DropDownList>
            <asp:TextBox ID="TextBox5" runat="server" style="z-index: 1; position: absolute; top: 24px; left: 382px; width: 165px"></asp:TextBox>
            <asp:Label ID="LabelMensaje" runat="server" style="z-index: 1; position: absolute; top: 546px; left: 395px; color: #FF0000" Text="Label" Visible="False"></asp:Label>
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
        <strong>
        <asp:Panel ID="Panel3" runat="server" style="z-index: 1; width: 1054px; height: 101px; position: absolute; top: 179px; left: 329px; font-family: 'Century Gothic'; font-size: large">
            <div class="text-justify">
                <span style="font-family: 'Century Gothic'; ">En esta sección se brinda la opción de agregar un nuevo grupo para un curso ya inscrito en el programa PAMTEC. Se deben de llenar todos los campos. A continuación se muestra el formulario </span>
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

