<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="ProyectoInstagram.Profile" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <header>
        <div class="container">
	        <div class="profile">
		        <div class="profile-image">
			        <img src="<%= usuario.Foto %>" alt="" width="100" height="100"/>
		        </div>

		        <div class="profile-user-settings">
			        <h1 class="profile-user-name"><%= usuario.Nombre_usuario %></h1>
                    <asp:Button class="btn profile-edit-btn" id="btn_editarPerfil" OnClick="EditarPerfilBtn_Click" runat="server" Text="Editar Perfil"/>
                    <asp:Button class="btn profile-edit-btn" id="btn_eliminarPerfil" OnClick="EliminarPerfilBtn_Click" runat="server" Text="Elimnar Perfil"/>
		        </div>

		        <div class="profile-stats">
			        <ul>
				        <li><span class="profile-stat-count">164</span> posts</li>
				        <li><span class="profile-stat-count">188</span> followers</li>
				        <li><span class="profile-stat-count">206</span> following</li>
			        </ul>
		        </div>

		        <div class="profile-bio">
			        <p><span class="profile-real-name"><%= usuario.Nombre %></span><%= usuario.Bio %></p>
		        </div>

	        </div>
	        <!-- End of profile section -->
        </div>
        <!-- End of container -->
    </header>

    <main>
        <div class="container">
	        <%= strPublicacionesHTML %>
        </div>
        <!-- End of container -->
    </main>
</asp:Content>
