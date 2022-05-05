Imports Janus.Windows.GridEX
Imports System.Windows.Forms
Imports Solmicro.Expertis.Engine.UI
Imports Solmicro.Expertis.Business.Obra
Imports Solmicro.Expertis.Engine

Public Class FrmInformeFecha
    Inherits Solmicro.Expertis.Engine.UI.FormBase

    Public blEstado As Boolean
    Public fecha1 As Date
    Public fecha2 As Date
    Public dtObrasSelect As DataTable



    Public Sub cargarGridObras()
        Dim obj As New ObraCabecera
        Dim f As New Filter
        Dim strSqlObras As String = "select IDObra,NObra,DescObra from tbObraCabecera"
        Dim dtObras As DataTable = obj.Filter(f, , "IDObra,NObra,DescObra")
        gridObras.DataSource = dtObras
        'gridObras.UseCheck = True

    End Sub
    Public Function crearDataTableObras()
        Dim dt As DataTable = New DataTable
        Dim dc As New DataColumn("NObra")
        dt.Columns.Add(dc)
        For Each row As GridEXRow In gridObras.GetCheckedRows
            Dim drG As DataRow = dt.NewRow
            Dim nObra As String = row.Cells.Item("NObra").Value
            drG.Item("NObra") = nObra
            dt.Rows.Add(drG)

        Next
        dtObrasSelect = dt

    End Function

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        blEstado = True
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        'IBIS. David. 02/06/2010. Controlado esto, ya que daba errores.
        If FechaDesde.Text = "" Or FechaHasta.Text = "" Then
            ExpertisApp.GenerateMessage("Debe indicar fechas para poder continuar o pulse Cancelar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        'VM = Nz(fwiMes.Value, 0)
        fecha1 = Nz(FechaDesde.Value, "01-01-1979")
        'VA = Nz(fwiAno.Value, 0)
        fecha2 = Nz(FechaHasta.Value, "31-12-2040")
        crearDataTableObras()

        blEstado = False
        Me.Close()
    End Sub

    Private Sub frmInformeFecha_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarGridObras()
    End Sub


End Class