<%@ Page Title="" Language="C#" MasterPageFile="~/Aplicacion/PrincipalTutor.Master" AutoEventWireup="true" CodeBehind="RealizarMatriculaTutor.aspx.cs" Inherits="PAMTEC.Aplicacion.RealizarMatriculaTutor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link href="../css/bootstrap.min.css" rel="stylesheet" />

    <form id="form1" role="form" runat="server" style="height: 243px; z-index: 1; width: 1026px; position: absolute; top: 454px; left: 0px;">
          
        <asp:Panel ID="Panel3" runat="server" Style="z-index: 1; width: 1054px; height: 71px; position: absolute; top: -301px; left: 318px; font-family: 'Century Gothic'; font-size: large">
                <div class="text-justify">
                    <span style="font-family: 'Century Gothic';"><strong>En esta sección se permite realizar la matricula a un estudiante ya inscrito en el programa PAMTEC. A continuación se presenta un campo en el cual deberá de agregar la cédula del estudiante que desea matricular. </strong>  </span>
                </div>
            </asp:Panel>



        <asp:TextBox ID="TextBoxCedula" runat="server" Style="z-index: 1; position: absolute; top: -192px; left: 773px"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Style="z-index: 1; position: absolute; top: -188px; left: 982px" Text="Cursos Disponibles" />


     
                <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Style="z-index: 1; width: 429px; height: 127px; position: absolute; top: -98px; left: 533px" CssClass="table-responsive" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4">
                    <Columns>
                        <asp:CommandField HeaderText="Matricular" ShowSelectButton="True" SelectText="Matricular" />
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
 


        <asp:Label ID="LabelMensaje" runat="server" Style="z-index: 1; position: absolute; top: -140px; left: 779px; color: #FF0000" Text="Label" Visible="False"></asp:Label>










        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 576px; top: -180px; position: absolute; font-size: medium; font-family: 'Century Gothic'" Text="Cédula del estudiante"></asp:Label>










    </form>



</asp:Content>
