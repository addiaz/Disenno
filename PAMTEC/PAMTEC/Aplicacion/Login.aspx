<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PAMTEC.Aplicacion.Login" %>


<!DOCTYPE html>
<html lang="en">
<head>


    <title>Login</title>
    <link href="../css/bootstrap.min.css" rel="stylesheet">
    

    <link href="../css/varAdministrador.css" rel="stylesheet">


    <style type="text/css">
        .auto-style1 {
            width: 501px;
            height: 294px;
            position: absolute;
            top: 51px;
            left: 223px;
            z-index: 1;
        }

        .auto-style5 {
            position: absolute;
            top: 80px;
            left: 189px;
            z-index: 1;
        }

        .auto-style6 {
            position: absolute;
            top: 130px;
            left: 189px;
            z-index: 1;
        }

        .auto-style8 {
            border-style: solid;
            border-width: 1px;
            padding: 1px 4px;
            position: absolute;
            top: 180px;
            left: 191px;
            z-index: 1;
            width: 188px;
            height: 40px;
            font-weight: bold;
            background-color: #6699FF;
        }

        .auto-style9 {
            width: 118px;
            height: 33px;
            position: absolute;
            top: 63px;
            left: 49px;
            z-index: 1;
            font-size: x-large;
        }

        .auto-style10 {
            width: 118px;
            height: 33px;
            position: absolute;
            top: 117px;
            left: 49px;
            z-index: 1;
            font-size: x-large;
        }

        .auto-style11 {
            width: 318px;
            height: 33px;
            position: absolute;
            top: 0px;
            left: 50px;
            z-index: 1;
        }

        .auto-style12 {
            max-width: 330px;
            padding: 15px;
            margin: 0 auto;
            height: 358px;
            width: 1181px;
        }

        .auto-style13 {
            width: 509px;
            height: 246px;
            position: absolute;
            top: 378px;
            left: 223px;
            z-index: 1;
        }

        .auto-style15 {
            width: 426px;
            height: 33px;
            position: absolute;
            top: 19px;
            left: 47px;
            z-index: 1;
            font-size: x-large;
        }

        .auto-style19 {
            position: absolute;
            top: 242px;
            left: 29px;
            z-index: 1;
        }

        .auto-style20 {
            position: absolute;
            top: 106px;
            left: 168px;
            z-index: 1;
            height: 26px;
        }
        .auto-style21 {
            position: absolute;
            top: 151px;
            left: 168px;
            z-index: 1;
            height: 26px;
        }

        </style>


</head>

<body>

    <div class="container">
        <form class="auto-style12" role="form" id="form1" runat="server">
            <div class="form-group">
                <asp:Panel ID="Panel1" runat="server" CssClass="auto-style1" BorderStyle="Solid">
                    <h2 class="auto-style11">Por favor, inicie sesión</h2>
                    <h2 class="auto-style9">Usuario:</h2>
                    <h2 class="auto-style10">Contraseña:</h2>
                    <asp:TextBox class="form-control" ID="TextBoxUsuario" runat="server" CssClass="auto-style5"></asp:TextBox>
                    <asp:TextBox class="form-control" ID="TextBoxPass" runat="server" CssClass="auto-style6" TextMode="Password"></asp:TextBox>
                    <strong>
                        <asp:Button ID="Button1" runat="server" class="btn btn-lg btn-primary btn-block" CssClass="auto-style8" Text="Iniciar Sesión" OnClick="Button1_Click1" />
                    </strong>
                    <asp:Label ID="LabelMensaje" runat="server" CssClass="auto-style19" Text="Label" Visible="False"></asp:Label>
                </asp:Panel>
                <asp:Panel ID="Panel2" runat="server" BorderStyle="Solid" CssClass="auto-style13" BackColor="White" Visible="False">
                    <h2 class="auto-style15">Elija el rol con que desea ingresar.</h2>
                   
                        <asp:Button ID="Button2" runat="server" CssClass="auto-style20" OnClick="Button2_Click" Text="Administrador" />
                    <asp:Button ID="Button3" runat="server" CssClass="auto-style21" OnClick="Button3_Click" Text="Tutor" />
                  
                </asp:Panel>
        </form>
    </div>

    <script src="https://code.jquery.com/jquery.js"></script>
    <script src="../js/bootstrap.js"></script>
</body>
</html>
