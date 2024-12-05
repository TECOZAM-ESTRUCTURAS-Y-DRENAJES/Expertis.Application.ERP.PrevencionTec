Imports System.Windows.Forms
Imports Solmicro.Expertis.Business.ClasesTecozam
Imports Solmicro.Expertis.Engine.UI
Imports System.IO

Public Class frmCursosSubcontratas

    Private Sub frmCursosSubcontratas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadToolbarActions()
    End Sub

#Region "ToolbarActions"
    Private Sub LoadToolbarActions()
        Me.FormActions.Add("Cargar datos desde Excel", AddressOf cargaDatosDesdeExcel)
    End Sub

    Public Sub cargaDatosDesdeExcel()
        Dim ruta As String
        Dim hoja As String = "Hoja1"
        Dim rango As String = "A1:J2000"
        Dim openFD As New OpenFileDialog()
        With openFD
            .Title = "Seleccionar archivos"
            .Filter = "Archivos Excel(*.xls;*.xlsx)|*.xls;*xlsx|Todos los archivos(*.*)|*.*"
            .Multiselect = False
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
            If .ShowDialog = Windows.Forms.DialogResult.OK Then

                Dim dtCoste As New DataTable
                Dim control = 0
                Try
                    ruta = openFD.FileName
                    Dim dt As DataTable = ObtenerDatosExcel(ruta, hoja, rango)

                    Dim dtOperarioInfo As New DataTable
                    dtOperarioInfo.Columns.Add("empresa")
                    dtOperarioInfo.Columns.Add("trabajador")
                    dtOperarioInfo.Columns.Add("cursoencofrador")
                    dtOperarioInfo.Columns.Add("cursoferralla")
                    dtOperarioInfo.Columns.Add("cursoapelevador")
                    dtOperarioInfo.Columns.Add("cursoestructuratubular")
                    dtOperarioInfo.Columns.Add("curso60horas")
                    dtOperarioInfo.Columns.Add("cursoprefabricados")
                    dtOperarioInfo.Columns.Add("cursosoldadura")
                    dtOperarioInfo.Columns.Add("cursomovitierras")


                    Dim drLinea As DataRow
                    For Each dr As DataRow In dt.Rows
                        drLinea = dtOperarioInfo.NewRow

                        drLinea("empresa") = dr(0)
                        drLinea("trabajador") = dr(1)
                        If Len(dr(2).ToString) > 0 Then
                            drLinea("cursoencofrador") = True
                        Else
                            drLinea("cursoencofrador") = False
                        End If

                        If Len(dr(3).ToString) > 0 Then
                            drLinea("cursoferralla") = True
                        Else
                            drLinea("cursoferralla") = False
                        End If

                        If Len(dr(4).ToString) > 0 Then
                            drLinea("cursoapelevador") = True
                        Else
                            drLinea("cursoapelevador") = False
                        End If

                        If Len(dr(5).ToString) > 0 Then
                            drLinea("cursoestructuratubular") = True
                        Else
                            drLinea("cursoestructuratubular") = False
                        End If

                        If Len(dr(6).ToString) > 0 Then
                            drLinea("curso60horas") = True
                        Else
                            drLinea("curso60horas") = False
                        End If

                        If Len(dr(7).ToString) > 0 Then
                            drLinea("cursoprefabricados") = True
                        Else
                            drLinea("cursoprefabricados") = False
                        End If

                        If Len(dr(8).ToString) > 0 Then
                            drLinea("cursosoldadura") = True
                        Else
                            drLinea("cursosoldadura") = False
                        End If

                        If Len(dr(9).ToString) > 0 Then
                            drLinea("cursomovitierras") = True
                        Else
                            drLinea("cursomovitierras") = False
                        End If

                        dtOperarioInfo.Rows.Add(drLinea)
                    Next

                    Dim contador = 1
                    For Each drInsert As DataRow In dtOperarioInfo.Rows
                        Dim clscCe As New Solmicro.Expertis.Business.ClasesTecozam.CursosSubcontratas
                        Dim dtCe As DataTable = clscCe.AddNewForm
                        dtCe.Rows(0)("IDLinea") = contador
                        dtCe.Rows(0)("Empresa") = drInsert("empresa")
                        dtCe.Rows(0)("Trabajador") = drInsert("trabajador")
                        dtCe.Rows(0)("CursoEncofrador") = drInsert("cursoencofrador")
                        dtCe.Rows(0)("CursoFerralla") = drInsert("cursoferralla")
                        dtCe.Rows(0)("CursoApElevadores") = drInsert("cursoapelevador")
                        dtCe.Rows(0)("CursoEstrucTubulares") = drInsert("cursoestructuratubular")
                        dtCe.Rows(0)("Curso60Horas") = drInsert("curso60horas")
                        dtCe.Rows(0)("CursoPrefabricados") = drInsert("cursoprefabricados")
                        dtCe.Rows(0)("CursoSoldadura") = drInsert("cursosoldadura")
                        dtCe.Rows(0)("CursoMovTierras") = drInsert("cursomovitierras")

                        Try
                            clscCe.Update(dtCe)
                            contador = contador + 1
                        Catch ex As Exception

                        End Try

                    Next
                Catch ex As Exception
                End Try
            End If
            MsgBox("Datos de subcontratas actualizados correctamente.")
        End With
    End Sub

    Public Function ObtenerDatosExcel(ByVal ruta As String, ByVal hoja As String, ByVal rango As String) As DataTable
        Dim MyConnection As System.Data.OleDb.OleDbConnection
        Dim DtSet As System.Data.DataSet
        Dim MyCommand As System.Data.OleDb.OleDbDataAdapter
        MyConnection = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" & ruta & "';Extended Properties=Excel 12.0;")
        MyCommand = New System.Data.OleDb.OleDbDataAdapter("select * from [" & hoja & "$" & rango & "]", MyConnection)
        'MyCommand.TableMappings.Add("Table", "Net-informations.com")
        DtSet = New System.Data.DataSet
        MyCommand.Fill(DtSet)
        Dim dt As DataTable = DtSet.Tables(0)
        MyConnection.Close()

        Return dt

    End Function
#End Region


    Private Sub Grid_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grid.DoubleClick
        Try
            With Grid
                If .Columns("Empresa").EditType = Janus.Windows.GridEX.EditType.TextBox Then
                    .Columns("Empresa").EditType = Janus.Windows.GridEX.EditType.DropDownList
                    CargarLista("Empresa", "Empresa", "Select Distinct(Empresa) FROM tbCursosSubcontratas")
                    .Refresh()
                Else
                    .Columns("Empresa").HasValueList = False
                    .Columns("Empresa").ButtonStyle = Janus.Windows.GridEX.ButtonStyle.NoButton
                    .Columns("Empresa").EditType = Janus.Windows.GridEX.EditType.TextBox
                    .Columns("Empresa").HasValueList = False
                    .Refresh()
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Dim auxiliares As New MetodosAuxiliares

    Private Sub CargarLista(ByVal seleccion As String, ByVal columna As String, ByVal sql As String)
        Dim dt As DataTable
        Dim jsCol2 As Janus.Windows.GridEX.GridEXColumn      'JSColumn
        Dim vl2 As Janus.Windows.GridEX.GridEXValueListItemCollection  ' JSValueList
        Dim aux As Janus.Windows.GridEX.GridEXValueListItem

        Try

            jsCol2 = Grid.Columns(columna)
            If Not jsCol2 Is Nothing Then
                vl2 = jsCol2.ValueList
                If Not vl2 Is Nothing Then
                    If vl2.Count > 0 Then
                        vl2.Clear()
                    End If
                End If
            End If

            dt = auxiliares.EjecutarSqlSelect(sql)

            'FwConsulta = Nothing
            If Not dt Is Nothing Then
                If dt.Rows.Count <> 0 Then

                    jsCol2 = Grid.Columns(columna)
                    jsCol2.HasValueList = True
                    'jsCol.ReplaceValues = True

                    vl2 = jsCol2.ValueList
                    For Each dr As DataRow In dt.Rows
                        aux = New Janus.Windows.GridEX.GridEXValueListItem
                        aux.Value = Nz(dr(seleccion), DBNull.Value)
                        aux.Text = Nz(dr(seleccion), "")
                        vl2.Add(aux)  ', rcsRdo!Estructura
                    Next
                Else
                    Grid.Columns(columna).ButtonStyle = Janus.Windows.GridEX.ButtonStyle.NoButton
                    Grid.Columns(columna).EditType = Janus.Windows.GridEX.EditType.TextBox
                    Grid.Columns(columna).HasValueList = False

                End If

            End If

        Catch ex As Exception
            ExpertisApp.GenerateMessage(ex.Message)
        End Try
    End Sub

    Public Function Nz(ByVal value As Object, ByVal alternateValue As Object) As Object
        If IsDBNull(value) OrElse value Is Nothing Then
            Return alternateValue
        Else
            Return value
        End If
    End Function

End Class