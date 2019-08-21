Imports System.Data
Imports System.Data.SqlClient

Public Class MateriasForm

    Dim Mat As New Materias
    Dim conex As New Conexion

    Private Sub Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Agregar.Click
        MateriasAlumnosForm.ShowDialog()

    End Sub

    Private Sub MateriasForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Mat.LlenarTabla(DataGridView1)

    End Sub

    Private Sub Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Modificar.Click
        Mat.Id = DataGridView1.Item("Id", DataGridView1.CurrentRow.Index).Value
        Mat.Nombre = DataGridView1.Item("Nombre", DataGridView1.CurrentRow.Index).Value
        Mat.Anio = DataGridView1.Item("Anio", DataGridView1.CurrentRow.Index).Value

        Dim MateriasAlumnosForm As New MateriasAlumnosForm(Mat)
        MateriasAlumnosForm.ShowDialog()
        Mat.LlenarTabla(DataGridView1)
    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salir.Click
        Close()

    End Sub
End Class
