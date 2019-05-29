<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ProyectoInstagram.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link rel="stylesheet" type="text/css" href="/Content/Login.css" />
</head>
<body>
    <div id="wrapper">
        <div class="login-main-content">
            <div class="header">Login</div>
            <br />
            <div class="l-part">
                <input type="text" placeholder="Nombre de usuario" class="input-1" />
                <input type="password" placeholder="Contraseña" class="input-2" />
                <input type="button" value="Iniciar sesión" class="btn-login" />
            </div>
        </div>
        <div class="sub-content">
            <div class="s-part">¿Crear una cuenta? <a href="/Register.aspx">Registrar</a></div>
        </div>
    </div>
</body>
</html>
