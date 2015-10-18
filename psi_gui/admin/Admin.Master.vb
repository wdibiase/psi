﻿Public Class AdminMaster
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If UsuarioLogueado Is Nothing Then
            Response.Redirect("../login.aspx")
        Else
            If Not UsuarioLogueado.perfil = "Administrador" Then
                Response.Redirect("../unauthorized.aspx")
            End If
            If Not Page.IsPostBack Then
                CargarIdiomas()
                CargarDatosUsuario()
            End If
            lnkLogged.Text = UsuarioLogueado.nombreUsuario
        End If
    End Sub

    Protected Sub lnkLogout_Click(sender As Object, e As EventArgs)
        UsuarioLogueado = Nothing
        Response.Redirect("../default.aspx")
    End Sub

    Private Sub CargarDatosUsuario()
        cboIdioma.ClearSelection()
        txtApellido.Text = String.Empty
        txtNombre.Text = String.Empty
        txtUsuario.Text = String.Empty
        txtEmail.Text = String.Empty

        lnkLogged.Text = UsuarioLogueado.nombreUsuario
        txtApellido.Text = UsuarioLogueado.apellido
        txtEmail.Text = UsuarioLogueado.email
        txtNombre.Text = UsuarioLogueado.nombre
        txtUsuario.Text = UsuarioLogueado.nombreUsuario
        cboIdioma.Items.FindByText(UsuarioLogueado.idioma).Selected = True
    End Sub

    Private Sub CargarIdiomas()
        Dim idioma As List(Of psi_el.idioma)
        Dim usuario As New psi_bll.Usuario
        idioma = usuario.listarIdiomas
        cboIdioma.DataSource = idioma
        cboIdioma.DataTextField = "id"
        cboIdioma.DataValueField = "desc"
        cboIdioma.DataBind()
        usuario = Nothing
        idioma = Nothing
    End Sub

    Protected Sub btnOk_Click(sender As Object, e As EventArgs)
        ModificarPerfil(txtApellido.Text, txtEmail.Text, cboIdioma.SelectedItem.ToString, txtNombre.Text, txtUsuario.Text)
        Traducir(Me)
    End Sub

    Protected Sub btnClaveOk_Click(sender As Object, e As EventArgs)

    End Sub

    Protected Sub btnClaveCancel_Click(sender As Object, e As EventArgs)

    End Sub
End Class