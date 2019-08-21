Imports System.Data
Imports System.Data.SqlClient

Public Class AluMateria

    Dim Id_ As Integer
    Dim IdMateria_ As Integer
    Dim IdAlumno_ As Integer

    Public Property Id() As Integer
        Get
            Return Id_
        End Get
        Set(ByVal value As Integer)
            Id_ = value
        End Set
    End Property

    Public Property IdMateria() As Integer
        Get
            Return IdMateria_
        End Get
        Set(ByVal value As Integer)
            IdMateria_ = value
        End Set
    End Property

    Public Property IdAlumno() As Integer
        Get
            Return IdAlumno_
        End Get
        Set(ByVal value As Integer)
            IdAlumno_ = value
        End Set
    End Property
End Class
