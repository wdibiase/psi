﻿Public Class Usuario
    Public Function Nuevo(User As psi_el.Usuario) As Int32
        Dim a As New Acceso
        Dim P(10) As SqlClient.SqlParameter
        P(0) = a.BuildParam("@usuario", User.nombreUsuario)
        P(1) = a.BuildParam("@tipoDoc", User.tipoDoc)
        P(2) = a.BuildParam("@numDoc", User.numDoc)
        P(3) = a.BuildParam("@apellido", User.apellido)
        P(4) = a.BuildParam("@nombre", User.nombre)
        P(5) = a.BuildParam("@estado", User.estado)
        P(6) = a.BuildParam("@idioma", User.idioma)
        P(7) = a.BuildParam("@idCliente", User.cliente)
        P(8) = a.BuildParam("@password", User.pwd)
        P(9) = a.BuildParam("@email", User.email)
        P(10) = a.BuildParam("@perfil", User.perfil)
        Return a.Grabar("dbo.usp_usuariosInsert", P)
    End Function

    Public Function Listar() As List(Of psi_el.Usuario)
        Dim usuarios As New List(Of psi_el.Usuario)
        Dim a As New Acceso
        Dim dt As DataTable = a.Leer("dbo.usp_usuariosSelect")
        Dim u As psi_el.Usuario
        For Each fila As DataRow In dt.Rows
            u = New psi_el.seguridad
            u.nombreUsuario = fila("usuario")
            u.tipoDoc = fila("descDoc")
            u.numDoc = fila("numDoc")
            u.apellido = fila("apellido")
            u.nombre = fila("nombre")
            u.estado = fila("descestado")
            u.idioma = fila("cultura")
            u.cliente = fila("razonSocial")
            u.email = fila("email")
            u.pwd = fila("pwd")
            If Len(fila("descPerfil").ToString) > 0 Then u.perfil = fila("descPerfil")
            usuarios.Add(u)
        Next
        Return usuarios
    End Function

    Public Function Listar(user As String) As psi_el.Usuario
        Dim entidadUsuario As New psi_el.seguridad
        Dim a As New Acceso
        Dim P(0) As SqlClient.SqlParameter
        P(0) = a.BuildParam("@Usuario", user)

        Dim dt As DataTable = a.Leer("dbo.usp_usuariosSelect", P)
        Dim u As psi_el.Usuario = Nothing
        For Each fila As DataRow In dt.Rows
            u = New psi_el.seguridad
            u.nombreUsuario = fila("usuario")
            u.tipoDoc = fila("descDoc")
            u.numDoc = fila("numDoc")
            u.apellido = fila("apellido")
            u.nombre = fila("nombre")
            u.estado = fila("descestado")
            u.idioma = fila("cultura")
            u.cliente = fila("razonSocial")
            u.email = fila("email")
            u.pwd = fila("pwd")
            If Len(fila("descPerfil").ToString) > 0 Then u.perfil = fila("descPerfil")
        Next
        Return u
    End Function

    Public Function Listar(cliente As String, excepcion As String) As List(Of psi_el.Usuario)
        Dim usuarios As New List(Of psi_el.Usuario)
        Dim a As New Acceso
        Dim P(0) As SqlClient.SqlParameter
        P(0) = a.BuildParam("@cliente", cliente)
        Dim dt As DataTable = a.Leer("dbo.usp_usuariosSelect", P)
        Dim u As psi_el.Usuario
        For Each fila As DataRow In dt.Rows
            If fila("usuario") <> excepcion Then
                u = New psi_el.seguridad
                u.nombreUsuario = fila("usuario")
                u.tipoDoc = fila("descDoc")
                u.numDoc = fila("numDoc")
                u.apellido = fila("apellido")
                u.nombre = fila("nombre")
                u.estado = fila("descestado")
                u.idioma = fila("cultura")
                u.cliente = fila("razonSocial")
                u.email = fila("email")
                u.pwd = fila("pwd")
                If Len(fila("descPerfil").ToString) > 0 Then u.perfil = fila("descPerfil")
                usuarios.Add(u)
            End If
        Next
        Return usuarios
    End Function

    Public Function ListarDocs() As List(Of psi_el.documento)
        Dim docs As New List(Of psi_el.documento)
        Dim a As New Acceso
        Dim dt As DataTable = a.Leer("dbo.usp_documentosSelect")
        Dim d As psi_el.documento
        For Each fila As DataRow In dt.Rows
            d = New psi_el.documento
            d.tipo = fila("tipoDoc")
            d.desc = fila("descDoc")
            docs.Add(d)
        Next
        Return docs
    End Function

    Public Function ListarClientes() As List(Of psi_el.Cliente)
        Dim clientes As New List(Of psi_el.Cliente)
        Dim misClientes As New psi_dal.Cliente
        clientes = misClientes.ListarClientes()
        Return clientes
    End Function

    Public Function listarIdiomas() As List(Of psi_el.idioma)
        Dim idiomas As New List(Of psi_el.idioma)
        Dim acceso As New Acceso
        Dim dt As DataTable = acceso.Leer("usp_idiomasSelect")
        Dim idioma As psi_el.idioma
        For Each fila As DataRow In dt.Rows
            idioma = New psi_el.idioma
            idioma.id = fila("cultura")
            idioma.desc = fila("descripcion")
            idiomas.Add(idioma)
        Next
        Return idiomas
    End Function

    Public Function ValidarUsuario(nombreUsuario As String, contraseña As String) As Boolean
        Dim usuario As New psi_el.seguridad
        Dim conexion As New Acceso
        Dim P(1) As SqlClient.SqlParameter
        P(0) = conexion.BuildParam("@Usuario", nombreUsuario)
        P(1) = conexion.BuildParam("@Contrasena", contraseña)

        Dim dt As DataTable = conexion.Leer("dbo.usp_usuarioValido", P)
        Return dt.Rows(0).Item(0).ToString
    End Function

    Public Function AsignarPerfil(idUsuario As Integer, descPerfil As String) As Short
        Dim usuario As New psi_el.seguridad
        Dim conexion As New Acceso
        Dim P(1) As SqlClient.SqlParameter
        P(0) = conexion.BuildParam("@usuario", idUsuario)
        P(1) = conexion.BuildParam("@descPerfil", descPerfil)

        Return conexion.Grabar("dbo.usp_perfilesUsuarioUpdate", P)
    End Function

    Public Function ListarPerfiles() As List(Of psi_el.perfil)
        Dim perfiles As New List(Of psi_el.perfil)
        Dim a As New Acceso
        Dim dt As DataTable = a.Leer("dbo.usp_perfilesSelect")
        Dim perf As psi_el.perfil
        For Each fila As DataRow In dt.Rows
            perf = New psi_el.perfil
            perf.id = fila("idPerfil")
            perf.desc = fila("descPerfil")
            perfiles.Add(perf)
        Next
        Return perfiles
    End Function

    Public Function Guardar(usuario As psi_el.seguridad) As Boolean
        Dim conexion As New Acceso
        Dim params(10) As SqlClient.SqlParameter
        params(0) = conexion.BuildParam("@usuario", usuario.nombreUsuario)
        params(1) = conexion.BuildParam("@descDoc", usuario.tipoDoc)
        params(2) = conexion.BuildParam("@numDoc", usuario.numDoc)
        params(3) = conexion.BuildParam("@apellido", usuario.apellido)
        params(4) = conexion.BuildParam("@nombre", usuario.nombre)
        params(5) = conexion.BuildParam("@descEstado", usuario.estado)
        params(6) = conexion.BuildParam("@idioma", usuario.idioma)
        params(7) = conexion.BuildParam("@razonSocial", usuario.cliente)
        params(8) = conexion.BuildParam("@password", usuario.pwd)
        params(9) = conexion.BuildParam("@email", usuario.email)
        params(10) = conexion.BuildParam("@perfil", usuario.perfil)
        Return conexion.Grabar("usp_usuariosUpdate", params)
    End Function

    Public Function ChangePassword(user As String, password As String) As Boolean
        Dim cn As New Acceso
        Dim pars(1) As SqlClient.SqlParameter
        pars(0) = cn.BuildParam("@usuario", user)
        pars(1) = cn.BuildParam("@password", password)
        Return cn.Grabar("usp_passwordUpdate", pars)
    End Function
End Class

