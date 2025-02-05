﻿Public Class Cliente
    Public Function ListarClientes() As List(Of psi_el.Cliente)
        Dim cliente As New psi_dal.Cliente
        Return cliente.ListarClientes
    End Function

    Public Function ListarSuscripciones() As List(Of psi_el.suscripcion)
        Dim suscripcion As New psi_dal.Cliente
        Return suscripcion.ListarSuscripciones
    End Function

    Public Function ListarProvincias() As List(Of psi_el.provincia)
        Dim prov As New psi_dal.Cliente
        Return prov.ListarProvincias
    End Function

    Public Function ListarPartidos(pcia As Int16) As List(Of psi_el.partido)
        Dim par As New psi_dal.Cliente
        Return par.ListarPartidos(pcia)
    End Function

    Public Function ListarLocalidades(partido As Int16) As List(Of psi_el.localidad)
        Dim loc As New psi_dal.Cliente
        Return loc.ListarLocalidades(partido)
    End Function

    Public Function ListarEstados() As List(Of psi_el.estado)
        Dim est As New psi_dal.Cliente
        Return est.ListarEstados()
    End Function

    Public Function Guardar(cliente As psi_el.Cliente) As Integer
        Dim bd As New psi_dal.Cliente
        bd.Guardar(cliente)
        Return Err.Number
    End Function

    Public Function Nuevo(cliente As psi_el.Cliente) As Integer
        Dim bd As New psi_dal.Cliente
        Return bd.Nuevo(cliente)
    End Function
End Class
