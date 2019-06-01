<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Publicar.aspx.cs" Inherits="ProyectoInstagram.Publicar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:FileUpload ID="FileUpload1" runat="server" />
    <asp:Button ID="btnUpload" Text="Upload" runat="server" OnClick="UploadFile" />
    <hr />
    <asp:Image ID="Image1" runat="server" Height = "100" Width = "100" />
    <asp:TextBox id="txt_descripcion" TextMode="multiline" MaxLength="150" runat="server" />
    <asp:Button id="btn_guardar" Text="Subir Imagen" OnClick="SubirImagenBtn_Click"  runat="server"/>
</asp:Content>
