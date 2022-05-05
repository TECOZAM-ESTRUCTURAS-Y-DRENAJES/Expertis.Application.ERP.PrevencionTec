Imports Solmicro.Expertis.Engine
Imports Expertis.Business.Prevencion
Imports System.Windows.Forms

Public Class MntoObrasHoras
    Inherits Solmicro.Expertis.Engine.UI.FormBase

    Private Sub MntoObrasHoras_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DefFecha()
    End Sub

    Private Sub DefFecha()
        Try
            IntUDMes.Value = DateAdd(DateInterval.Month, -1, Now).Month
            IntUDYear.Value = DateAdd(DateInterval.Month, -1, Now).Year
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TraerDatos()

        Dim ob As New Funciones
        Dim f As New Filter

        If IntUDYear.Value = "1979" Then
            Return
        End If
        Try
            Dim dt As DataTable
            Dim sSql As String
            Dim dDesde As Date
            Dim dHasta As Date

            dDesde = DateAdd(DateInterval.Month, -1, CDate("20-" & Nz(IntUDMes.Value, Now.Month) & "-" & Nz(IntUDYear.Value, Now.Year)))
            dHasta = CDate("20-" & Nz(IntUDMes.Value, Now.Month) & "-" & Nz(IntUDYear.Value, Now.Year))

            sSql = "SELECT * from vFrmPrevObrasHoras"
            sSql &= " Where (FechaInicio >= '" & dDesde & "') "
            sSql &= " AND (FechaInicio <= '" & dHasta & "') "

            dt = ob.RecogeDatos(sSql)

            GridObrasHoras.DataSource = dt
            Me.Refresh()
        Catch ex As Exception
            MsgBox("Error al obtener datos." & ex.Message)
        End Try
    End Sub

    Private Sub IntUDMes_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles IntUDMes.ValueChanged
        TraerDatos()
    End Sub

    Private Sub IntUDYear_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles IntUDYear.ValueChanged
        TraerDatos()
    End Sub
End Class