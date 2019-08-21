Imports System.Data
Imports System.Data.SqlClient

Public Class Conexion
    Private sqlconexion_ As SqlConnection

    Public Property sqlconexion() As SqlConnection
        Get
            Return sqlconexion_

        End Get

        Set(ByVal value As SqlConnection)
            sqlconexion_ = value
        End Set
    End Property


    Public Sub abrir()

        Try
            sqlconexion.Open()
        Catch ex As SqlException
            MsgBox("le erraste a la base de datos")
        Catch ex As InvalidOperationException
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub cerrar()
        sqlconexion.Close()

    End Sub

    Public Sub New()

        Dim strconexion As String = "Server=DESKTOP-G3KUM5N\SQLEXPRESS;Database=Materias;User Id=sa;Password=carena;"
        sqlconexion = New SqlConnection(strconexion)

    End Sub
End Class
