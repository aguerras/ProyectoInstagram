<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Profile-edit.aspx.cs" Inherits="ProyectoInstagram.Profile_edit" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <div id="wrapper">
        <div class="edti-main-content">
            <center><h1 class="title-form">Editar información</h1></center>
            <br>
            <div class="l-part">
                <div class="form-image">
			        <img src="https://images.unsplash.com/photo-1513721032312-6a18a42c8763?w=152&h=152&fit=crop&crop=faces" alt="">
                    <input type="file" class="input-1"/>
		        </div>
                <span class="label-form">Nombre</span>
                <input type="text" placeholder="Nombre completo" class="input-1" />
                <span class="label-form">Nombre de usuario</span>
                <input type="text" placeholder="Nombre de usuario" class="input-1" disabled/>
                <span class="label-form">Biografía</span>
                <input type="text" placeholder="Biografía" class="input-1" />
                <span class="label-form">Contraseña</span>
                <input type="password" placeholder="Contraseña" class="input-2" />
                <input type="button" value="Enviar" class="btn-form" />
            </div>
        </div>
    </div>
</asp:Content>
