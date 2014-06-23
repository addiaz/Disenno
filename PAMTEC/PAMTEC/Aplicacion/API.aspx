<%@ Page Title="" Language="C#" MasterPageFile="~/Aplicacion/PrincipalAdministrador.Master" AutoEventWireup="true" CodeBehind="API.aspx.cs" Inherits="PAMTEC.API" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 339px;
            left: 617px;
            z-index: 1;
        }
        .auto-style2 {
            position: absolute;
            top: 267px;
            left: 467px;
            z-index: 1;
            width: 430px;
        }
        .auto-style3 {
            position: absolute;
            top: 206px;
            left: 374px;
            z-index: 1;
            font-size: large;
        }
        .auto-style4 {
            position: absolute;
            top: 346px;
            left: 837px;
            z-index: 1;
            color: #FF0000;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:FileUpload ID="FileUpload1" runat="server" CssClass="auto-style2" />
    
        <asp:Label ID="LabelMensaje" runat="server" CssClass="auto-style4" Text="Label" Visible="False"></asp:Label>
    
    </div>
        <p>
            <asp:Button ID="Button1" class="form-default" runat="server" CssClass="auto-style1" OnClick="Button1_Click" Text="SubirArchivo" />
            <strong>
            <asp:Label ID="Label1" runat="server" CssClass="auto-style3" Text="Seleccione el archivo que desea subir al google drive:"></asp:Label>
            </strong>
        </p>
    </form>
</body>
</asp:Content>