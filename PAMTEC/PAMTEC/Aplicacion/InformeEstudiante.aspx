<%@ Page Title="" Language="C#" MasterPageFile="~/Aplicacion/PrincipalAdministrador.Master" AutoEventWireup="true" CodeBehind="InformeEstudiante.aspx.cs" Inherits="PAMTEC.Aplicacion.InformeEstudiante" %>
<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <form id="form1" runat="server" style="height: 178px">
    <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; position: absolute; top: 357px; left: 453px"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="left: 663px; top: 357px" Text="Reporte" />
    <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" style="z-index: 1; width: 187px; height: 127px; position: absolute; top: 474px; left: 498px" Visible="False">
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
    <asp:Label ID="Label1" runat="server" style="height: 31px; z-index: 1; position: absolute; top: 360px; left: 860px; color: #FF0000" Text="Label" Visible="False"></asp:Label>
</form>


</asp:Content>
