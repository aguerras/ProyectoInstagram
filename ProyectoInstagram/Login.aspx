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
                <form method="post" runat="server">
                    <asp:TextBox runat="server" id="nombre_usuario" placeholder="Nombre de usuario" class="input-1"/>
                    <asp:RequiredFieldValidator runat="server" id="req1" controltovalidate="nombre_usuario" errormessage="Nombre de usuario es requerido!" Display="Dynamic" class="form-error"/>
                    <asp:CustomValidator id="reqUserName" ControlToValidate="nombre_usuario" Display="Dynamic" ErrorMessage="Datos incorrectos" class="form-error" runat="server"/>

                    <asp:TextBox runat="server" id="password" placeholder="Contraseña" class="input-2" type="password"/>
                    <asp:RequiredFieldValidator runat="server" id="req3" controltovalidate="password" errormessage="Contraseña es requerido!" Display="Dynamic" class="form-error"/>
                    <asp:CustomValidator id="reqPassword" ControlToValidate="password" Display="Dynamic" ErrorMessage="Datos incorrectos" class="form-error" runat="server"/>

                    <asp:Button runat="server" id="btnSubmitForm" text="Iniciar sesión" class="btn-login" OnClick="btn_login"/>
                </form>
            </div>
        </div>
        <div class="sub-content">
            <div class="s-part">¿Crear una cuenta? <a href="/Register.aspx">Registrar</a></div>
        </div>
    </div>
</body>
</html>
