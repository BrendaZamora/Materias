Imports System.Data
Imports System.Data.SqlClient

Public Class Materias
    Inherits Conexion
    Dim Id_ As Integer
    Dim Nombre_ As String
    Dim Anio_ As Integer


    Public Property Id() As Integer
        Get
            Return Id_
        End Get
        Set(ByVal value As Integer)
            Id_ = value
        End Set
    End Property


    Public Property Nombre() As String
        Get
            Return Nombre_
        End Get
        Set(ByVal value As String)
            Nombre_ = value
        End Set
    End Property


    Public Property Anio() As Integer
        Get
            Return Anio_
        End Get
        Set(ByVal value As Integer)
            Anio_ = value
        End Set
    End Property

    Public Sub LlenarTabla(ByVal tabla As DataGridView)
        abrir()
        Dim sqlcomando As New SqlCommand("MateriasLlenarTabla", sqlconexion)
        sqlcomando.CommandType = CommandType.StoredProcedure
        Dim sqladapter As New SqlDataAdapter(sqlcomando)
        Dim sqldatatable As New DataTable
        sqladapter.Fill(sqldatatable)
        tabla.DataSource = sqldatatable
        tabla.Columns("Id").Width = 50
        'tabla.Columns("ShipCity").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        cerrar()
    End Sub
End Class
