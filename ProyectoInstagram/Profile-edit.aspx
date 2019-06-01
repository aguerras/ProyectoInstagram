<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Profile-edit.aspx.cs" Inherits="ProyectoInstagram.Profile_edit" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <div id="wrapper">
        <div class="edti-main-content">
            <center><h1 class="title-form">Editar información</h1></center>
            <br>
            <div class="l-part">
                <div class="form-image">
			        <img src="/Images/default-user.png" alt="">
                    <asp:FileUpload id="foto" runat="server" class="input-1"/>
		        </div>
                
                <span class="label-form">Nombre</span>
                <asp:TextBox runat="server" id="nombre" placeholder="Nombre completo" class="input-1"/>
                <asp:RequiredFieldValidator runat="server" id="req" controltovalidate="nombre" errormessage="Nombre completo es requerido!" Display="Dynamic" class="form-error"/>

                <span class="label-form">Nombre de usuario</span>
                <asp:TextBox runat="server" id="nombre_usuario" placeholder="Nombre de usuario" class="input-1" ReadOnly="true"/>

                <span class="label-form">Biografía </span>
                <asp:TextBox runat="server" TextMode="multiline" Columns="50" Rows="5" id="bio" class="input-1"/>

                <span class="label-form">Fecha de nacimiento: </span>
                <asp:TextBox runat="server" id="fecha_nacimiento" class="input-1"/>
                <asp:RequiredFieldValidator runat="server" id="req2" controltovalidate="fecha_nacimiento" errormessage="Fecha de nacimiento es requerido!" Display="Dynamic" class="form-error"/>

                <span class="label-form">Contraseña</span>
                <asp:TextBox runat="server" id="password" placeholder="Contraseña" class="input-2" type="password"/>
                <asp:RequiredFieldValidator runat="server" id="req4" controltovalidate="password" errormessage="Contraseña es requerido!" Display="Dynamic" class="form-error"/>

                <asp:Button runat="server" id="btnSubmitForm" text="Enviar" class="btn-form" OnClick="btn_editar_perfil"/>
            </div>
        </div>
    </div>
</asp:Content>
