<%@ Page Title="" Language="C#" MasterPageFile="~/Aplicacion/PrincipalAdministrador.Master" AutoEventWireup="true" CodeBehind="RealizarMatricula.aspx.cs" Inherits="PAMTEC.Aplicacion.RealizarMatricula" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



    <form id="form1" role="form" runat="server" style="height: 243px; z-index: 1; width: 1026px; position: absolute; top: 454px; left: 0px;">
          
        <asp:TextBox ID="TextBoxCedula" runat="server" Style="z-index: 1; position: absolute; top: -91px; left: 427px"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Style="z-index: 1; position: absolute; top: -90px; left: 628px" Text="Ver Disponibles" />


        <div class="table-responsive">
            <table class="table">
                <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" Style="z-index: 1; width: 262px; height: 127px; position: absolute; top: 50px; left: 344px">
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
            </table>
        </div>



        <asp:Label ID="LabelMensaje" runat="server" Style="z-index: 1; position: absolute; top: -18px; left: 473px; color: #FF0000" Text="Label" Visible="False"></asp:Label>










    </form>



</asp:Content>
