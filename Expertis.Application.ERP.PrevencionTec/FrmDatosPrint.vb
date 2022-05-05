Imports Expertis.Business.Prevencion
Imports Solmicro.Expertis.Engine

Public Class FrmDatosPrint

    Inherits Solmicro.Expertis.Engine.UI.FormBase
    Friend blnImprimir As Boolean
    Friend sJefe As String
    Private Sub FrmDatosPrint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarCombos()
    End Sub

    Private Sub CargarCombos()

        Dim obj As New PrevencionEncargaJefe
        Dim f As New Filter

        f.Add("cTipo", FilterOperator.Equal, "J")

        Try
            Dim Strsql As String
            Strsql = "SELECT Nombre,cTipo FROM tbOperarioEncargaJefe"
            ' Cargar Jefes
            UiCB_DireccionJ.DataSource = obj.Filter(f, "Nombre", "Nombre")
            UiCB_DireccionJ.DisplayMember = UiCB_DireccionJ.DataSource.Columns("Nombre").Caption.ToString
            UiCB_DireccionJ.ValueMember = UiCB_DireccionJ.DisplayMember
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        blnImprimir = False
        Me.Close()
    End Sub


    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        blnImprimir = True
        sJefe = UiCB_DireccionJ.Text
        If Trim(sJefe).Length = 0 Then
            MsgBox("Debe de seleccional algún criterio de filtro")
        Else
            Me.Close()
        End If

    End Sub
End Class
