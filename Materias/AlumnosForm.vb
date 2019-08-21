Imports System.Data
Imports System.Data.SqlClient

Public Class AlumnosForm

    Dim Alu As New Alumnos
    Dim conex As New Conexion


    Private Sub AlumnosForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Alu.LlenarTabla(DataGridView1)

    End Sub

    
    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar.Click
        Close()

    End Sub
End Class