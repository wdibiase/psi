﻿Public Class Paciente
    Public Enum Sexos
        Masculino
        Femenino
    End Enum

    Public Enum Lateralidades
        Diestro
        Zurdo
        Ambidiestro
    End Enum

    Private _dni As Integer
    Public Property DNI As Integer
        Get
            Return _dni
        End Get
        Set(value As Integer)
            _dni = value
        End Set
    End Property

    Private _tipoDoc As String
    Public Property tipoDoc As String
        Get
            Return _tipoDoc
        End Get
        Set(value As String)
            _tipoDoc = value
        End Set
    End Property

    Private _fechaNacimiento As Date
    Public Property fechaNacimiento As Date
        Get
            Return _fechaNacimiento
        End Get
        Set(value As Date)
            _fechaNacimiento = value
        End Set
    End Property

    Private _nombre As String
    Public Property nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Private _apellido As String
    Public Property apellido As String
        Get
            Return _apellido
        End Get
        Set(value As String)
            _apellido = value
        End Set
    End Property

    Private _sexo As String
    Public Property sexo As String
        Get
            Return _sexo
        End Get
        Set(value As String)
            _sexo = value
        End Set
    End Property

    Private _escuela As String
    Public Property escuela As String
        Get
            Return _escuela
        End Get
        Set(value As String)
            _escuela = value
        End Set
    End Property

    Private _año As Int16
    Public Property año As Int16
        Get
            Return _año
        End Get
        Set(value As Int16)
            _año = value
        End Set
    End Property

    Private _lateralidad As String
    Public Property lateralidad As String
        Get
            Return _lateralidad
        End Get
        Set(value As String)
            _lateralidad = value
        End Set
    End Property

    Private _eval As Integer?
    Public Property evaluador As Integer?
        Get
            Return _eval
        End Get
        Set(value As Integer?)
            _eval = value
        End Set
    End Property

    Public ReadOnly Property DisplayName As String
        Get
            Return nombre & " " & apellido
        End Get
    End Property
End Class
