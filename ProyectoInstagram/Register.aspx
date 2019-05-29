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
            <input type="text" placeholder="Número de celular o correo" class="input-1" />
            <input type="text" placeholder="Nombre completo" class="input-1" />
            <input type="text" placeholder="Nombre de usuario" class="input-1" />
            <input type="password" placeholder="Contraseña" class="input-2" />
            <input type="button" value="Registrarte" class="btn-login" />
        </div>
    </div>
    <div class="sub-content">
        <div class="s-part">¿Tienes una cuenta? <a href="/Login.aspx">Iniciar sesión</a></div>
    </div>
</div>

</body>
</html>
