<%@ Page Title="" Language="C#" MasterPageFile="~/Aplicacion/PrincipalAdministrador.Master" AutoEventWireup="true" CodeBehind="AgregarTutor.aspx.cs" Inherits="PAMTEC.Aplicacion.AgregarTutor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <!-- Bootstrap core CSS -->
  <link href="../css/bootstrap.min.css" rel="stylesheet">
    <link href="../css/varAdministrador.css" rel="stylesheet">
    <form  id="form1" runat="server">


        <br />
        <asp:Panel ID="Panel1" runat="server" Style="z-index: 1; width: 1101px; height: 500px; position: absolute; top: 223px; left: 332px; color: #333333; border-style: outset; border-width: 6px; margin-left: 4px; margin-top: 10px">
            <asp:Label ID="Label1" runat="server" Text="Nombre:" Style="z-index: 1; position: absolute; top: 125px; left: 84px; font-family: 'Century Gothic'; font-size: large"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Style="z-index: 1; position: absolute; top: 198px; left: 85px; font-family: 'Century Gothic'; font-size: large" Text="Apellidos:"></asp:Label>
            <asp:TextBox ID="TextBoxNombre" runat="server" Style="left: 294px; top: 114px" OnTextChanged="TextBoxNombre_TextChanged"></asp:TextBox>
            <asp:TextBox ID="TextBoxApellidos" runat="server" Style="left: 294px; top: 188px; width: 189px;"></asp:TextBox>
            <asp:Button ID="Button1"  class="btn btn-primary"  runat="server" Style="left: 816px; top: 362px; width: 187px;" Text="Agregar" OnClick="Button1_Click" />
            <asp:Label ID="Label3" runat="server" Style="z-index: 1; position: absolute; top: 59px; left: 86px; font-family: 'Century Gothic'; font-size: large; width: 83px" Text="Carnet:"></asp:Label>
            <asp:Label ID="Label4" runat="server" Style="z-index: 1; position: absolute; top: 282px; left: 84px; font-family: 'Century Gothic'; font-size: large;" Text="Fecha Nacimiento:"></asp:Label>
            <asp:Label ID="Label5" runat="server" Style="z-index: 1; position: absolute; top: 58px; left: 603px; font-family: 'Century Gothic'; font-size: large;" Text="Número de Teléfono:"></asp:Label>
            <asp:Label ID="Label6" runat="server" Style="z-index: 1; position: absolute; top: 279px; left: 615px; font-family: 'Century Gothic'; font-size: large;" Text="Correo:"></asp:Label>
            <asp:Label ID="Label7" runat="server" Style="z-index: 1; position: absolute; top: 128px; left: 606px; font-family: 'Century Gothic'; font-size: large;" Text="Categoria:"></asp:Label>
            <asp:TextBox ID="TextBoxCarnet" runat="server" Style="left: 295px; top: 44px"></asp:TextBox>
            <asp:TextBox ID="TextBoxNumeroTelefono"  runat="server" Style="left: 811px; top: 49px"></asp:TextBox>
            <asp:DropDownList ID="DropDownList1" runat="server" Style="left: 815px; top: 124px; height: 36px; z-index: 1; position: absolute">
                <asp:ListItem>Asistencia Especial</asp:ListItem>
                <asp:ListItem>Horas Beca</asp:ListItem>
                <asp:ListItem>Voluntariado</asp:ListItem>
            </asp:DropDownList>
            <asp:TextBox ID="TextBoxDireccion" runat="server" Style="left: 816px; top: 194px"></asp:TextBox>

            <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="#3366CC" BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#003399" Height="200px" Style="z-index: 1; width: 216px; height: 162px; position: absolute; top: 318px; left: 292px; font-family: 'Century Gothic'; font-size: small;" Width="220px" Visible="False" OnSelectionChanged="Calendar1_SelectionChanged">
                <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
                <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
                <OtherMonthDayStyle ForeColor="#999999" />
                <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
                <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
                <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
                <WeekendDayStyle BackColor="#CCCCFF" />
            </asp:Calendar>
            <asp:TextBox ID="TextBoxfchNacimiento" runat="server" Style="left: 294px; top: 262px; height: 50px;"></asp:TextBox>
            <asp:Label ID="Label8" runat="server" Style="z-index: 1; position: absolute; top: 201px; left: 606px; font-family: 'Century Gothic'; font-size: large;" Text="Dirección:"></asp:Label>
            <asp:TextBox ID="TextBoxCorreo" runat="server"></asp:TextBox>
            <asp:Button ID="Button2" class="btn btn-primary"   runat="server" OnClick="Button2_Click" Style="left: 504px; top: 264px; width: 40px; height: 39px" Text="..." />
            <asp:Label ID="LabelMensaje" runat="server" style="z-index: 1; position: absolute; top: 326px; left: 818px; height: 22px; color: #FF0000" Text="Label" Visible="False"></asp:Label>
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
            <asp:Panel ID="Panel3" runat="server" Style="z-index: 1; width: 1054px; height: 101px; position: absolute; top: 153px; left: 318px; font-family: 'Century Gothic'; font-size: large">
                <div >
                    <span style="font-family: 'Century Gothic';">En esta sección se brinda la opción de agregar un nuevo tutor al sistema administrador del programa PAMTEC. A continuación se muestra el formulario para ingresar un nuevo tutor </span>
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
