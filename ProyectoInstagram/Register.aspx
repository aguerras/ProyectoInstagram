<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="ProyectoInstagram.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registrar</title>
    <link rel="stylesheet" type="text/css" href="/Content/Login.css" />
</head>
<body>
<div id="wrapper">
    <div class="login-main-content">
        <div class="header">Registrar</div>
        <br>
        <div class="l-part">
            <form method="post" runat="server">
                <asp:TextBox runat="server" id="nombre" placeholder="Nombre completo" class="input-1"/>
                <asp:RequiredFieldValidator runat="server" id="req" controltovalidate="nombre" errormessage="Nombre completo es requerido!" Display="Dynamic" class="form-error"/>

                <span class="label-form">Fecha de nacimiento: </span><asp:TextBox runat="server" id="fecha_nacimiento" class="input-1"/>
                <asp:RequiredFieldValidator runat="server" id="req2" controltovalidate="fecha_nacimiento" errormessage="Fecha de nacimiento es requerido!" Display="Dynamic" class="form-error"/>

                <asp:TextBox runat="server" id="nombre_usuario" placeholder="Nombre de usuario" class="input-1"/>
                <asp:RequiredFieldValidator runat="server" id="req3" controltovalidate="nombre_usuario" errormessage="Nombre de usuario es requerido!" Display="Dynamic" class="form-error"/>
                <asp:CustomValidator id="reqUserName" ControlToValidate="nombre_usuario" OnServerValidate="valid_user_name" Display="Dynamic" ErrorMessage="Este nombre de usuario ya existe." class="form-error" runat="server"/>

                <asp:TextBox runat="server" id="password" placeholder="Contraseña" class="input-2" type="password"/>
                <asp:RequiredFieldValidator runat="server" id="req4" controltovalidate="password" errormessage="Contraseña es requerido!" Display="Dynamic" class="form-error"/>

                <asp:Button runat="server" id="btnSubmitForm" text="Registrarte" class="btn-login" OnClick="btn_registrar"/>
            </form>
        </div>
    </div>
    <div class="sub-content">
        <div class="s-part">¿Tienes una cuenta? <a href="/Login.aspx">Iniciar sesión</a></div>
    </div>
</div>

</body>
</html>
