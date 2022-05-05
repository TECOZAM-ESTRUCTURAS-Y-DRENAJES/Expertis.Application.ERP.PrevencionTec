Public Class frmFecha

    Inherits Solmicro.Expertis.Engine.UI.FormBase

    Public blEstado As Boolean
    Public mes As Integer
    Public anio As Integer
    Private Sub cargarCombos()
        ' Cargamos combo mes 
        Dim dtMes As New DataTable
        dtMes.Columns.Add("Numero")
        dtMes.Columns.Add("Desc")

        Dim drMes As DataRow = dtMes.NewRow
        drMes("Numero") = 1
        drMes("Desc") = "Enero"
        dtMes.Rows.Add(drMes)

        drMes = dtMes.NewRow
        drMes("Numero") = 2
        drMes("Desc") = "Febrero"
        dtMes.Rows.Add(drMes)

        drMes = dtMes.NewRow
        drMes("Numero") = 3
        drMes("Desc") = "Marzo"
        dtMes.Rows.Add(drMes)

        drMes = dtMes.NewRow
        drMes("Numero") = 4
        drMes("Desc") = "Abril"
        dtMes.Rows.Add(drMes)

        drMes = dtMes.NewRow
        drMes("Numero") = 5
        drMes("Desc") = "Mayo"
        dtMes.Rows.Add(drMes)

        drMes = dtMes.NewRow
        drMes("Numero") = 6
        drMes("Desc") = "Junio"
        dtMes.Rows.Add(drMes)

        drMes = dtMes.NewRow
        drMes("Numero") = 7
        drMes("Desc") = "Julio"
        dtMes.Rows.Add(drMes)

        drMes = dtMes.NewRow
        drMes("Numero") = 8
        drMes("Desc") = "Agosto"
        dtMes.Rows.Add(drMes)

        drMes = dtMes.NewRow
        drMes("Numero") = 9
        drMes("Desc") = "Septiembre"
        dtMes.Rows.Add(drMes)

        drMes = dtMes.NewRow
        drMes("Numero") = 10
        drMes("Desc") = "Octubre"
        dtMes.Rows.Add(drMes)

        drMes = dtMes.NewRow
        drMes("Numero") = 11
        drMes("Desc") = "Noviembre"
        dtMes.Rows.Add(drMes)

        drMes = dtMes.NewRow
        drMes("Numero") = 12
        drMes("Desc") = "Diciembre"
        dtMes.Rows.Add(drMes)

        cbxMes.DataSource = dtMes
        cbxMes.ValueMember = "Numero"
        cbxMes.DisplayMember = "Desc"

        ' Cargamos el combo Año

        Dim dtAnio As New DataTable
        dtAnio.Columns.Add("Anio")

        Dim dr As DataRow

        For i As Integer = 0 To 10
            Dim j As Integer = Year(Today)
            dr = dtAnio.NewRow()
            dr("Anio") = j - i
            dtAnio.Rows.Add(dr)
        Next
        cbxAnio.DataSource = dtAnio
        cbxAnio.DisplayMember = "Anio"
        cbxAnio.ValueMember = "Anio"


    End Sub

    Private Sub FrmFecha_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarCombos()
    End Sub
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        blEstado = True
        mes = cbxMes.Value
        anio = cbxAnio.Value

        If Trim(mes).Length = 0 And Trim(anio).Length = 0 Then
            MsgBox("Debe de seleccionar un mes y un año")
        Else
            'MsgBox("Ha elegido mes " & mes & " año " & anio)
            Me.Close()
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        blEstado = False
        Me.Close()
    End Sub
End Class
