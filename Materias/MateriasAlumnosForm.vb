Public Class MateriasAlumnosForm

    Private Sub Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Agregar.Click
        AlumnosForm.ShowDialog()
    End Sub

    Private materia_ As Materias
    Private esNuevo_ As Boolean

    Public Property materia() As Materias
        Get
            Return materia_
        End Get
        Set(ByVal value As Materias)
            materia_ = value

        End Set
    End Property


    Public Property esNuevo() As Boolean
        Get
            Return esNuevo_
        End Get
        Set(ByVal value As Boolean)
            esNuevo_ = value

        End Set
    End Property

    Public Sub New(ByVal mat As Materias)
        InitializeComponent()
        materia = mat
        TxtId.Text = materia.Id
        TxtNombre.Text = materia.Nombre
        TxtAnio.Text = materia.Anio

    End Sub

    Public Sub New()

        InitializeComponent()

        TxtId.Text = 0
        TxtNombre.Text = ""
        TxtAnio.Text = 0
        esNuevo = True

    End Sub

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar.Click
        Close()

    End Sub
End Class