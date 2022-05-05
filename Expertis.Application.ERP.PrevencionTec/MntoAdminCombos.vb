Imports Solmicro.Expertis.Engine.UI
Imports Janus.Windows.GridEX
Imports Expertis.Business.Prevencion

Public Class MntoAdminCombos
    Private Sub MntoAdminCombos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim objAuten As New Solmicro.Expertis.Engine.AutenticationInfo
        'Try
        '    objAuten.Autentication = AutenticationMode.ExpertisAutentication
        '    'AdminData.Logout()
        '    Dim Conexion As New Solmicro.Expertis.Engine.DAL.AdminData

        '    Conexion.GetSystemConnection()
        '    objAuten.CUsuario = "eusebioex"
        '    objAuten.Pwd = "1234"
        '    'AdminData.GetAutentication("SERVIDOR")
        '    Conexion.Login(objAuten, "SERVIDOR")
        '    ''''''''''''''''''''''''''''''''''''''' Realmente conecta
        '    Conexion.BeginTx()
        '    Conexion.GetConnectionString()
        '    Conexion.GetAutentication("SERVIDOR")
        '    ''admindata.Connection
        '    AdminData.SetSessionDataBase("xTecozam4demo")
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try

        CargarCombos()
    End Sub

#Region "Cargar Combos"
    Private Sub CargarCombos()
        CargartipoFormacion()
        CargartipoJefe()
    End Sub

    Private Sub CargartipoFormacion()

        Try

            Dim dt As New DataTable
            'Dim dc As New DataColumn("ClaseFormacion", Type.GetType("System.String"))
            dt.Columns.Add(New DataColumn("ClaseFormacion"))
            dt.Columns.Add(New DataColumn("DescClaseFormacion", Type.GetType("System.String")))

            Dim dr As DataRow = dt.NewRow()

            dr("ClaseFormacion") = 1
            dr("DescClaseFormacion") = "Interna"
            dt.Rows.Add(dr)

            dr = dt.NewRow()
            dr("ClaseFormacion") = 2
            dr("DescClaseFormacion") = "Externa"
            dt.Rows.Add(dr)

            dr = dt.NewRow()
            dr("ClaseFormacion") = 20
            dr("DescClaseFormacion") = "20h."
            dt.Rows.Add(dr)

            dr = dt.NewRow()
            dr("ClaseFormacion") = 50
            dr("DescClaseFormacion") = "50h."
            dt.Rows.Add(dr)

            Dim drlist As New Janus.Windows.GridEX.GridEXValueListItemCollection
            GridFormacion.Columns("ClaseFormacion").HasValueList = True

            Dim objMod As Janus.Windows.GridEX.GridEXValueListItem
            If Not dt Is Nothing And dt.Rows.Count > 0 Then
                For Each drFor As DataRow In dt.Rows
                    If Len(drFor("ClaseFormacion")) > 0 Then
                        'objMod = New Janus.Windows.GridEX.GridEXValueListItem(drModelo("Modelo"), drModelo("Modelo"))
                        objMod = New Janus.Windows.GridEX.GridEXValueListItem(drFor("ClaseFormacion"), drFor("DescClaseFormacion"))
                        ' ExpertisApp.GenerateMessage("La Formacion es " & drFor("ClaseFormacion") & " - " & drFor("DescClaseFormacion"))
                        drlist.Add(objMod)
                    End If
                Next
            End If
            GridFormacion.Columns("ClaseFormacion").ValueList.PopulateValueList(drlist, "Value", "Text")



            'rcsRdo = Nothing
        Catch ex As Exception
            ExpertisApp.GenerateMessage(ex.Message)
        End Try
    End Sub

    Private Sub CargartipoJefe()
        Try
            Dim dropClaseForm As New GridEXDropDown
            Dim dt As New DataTable
            'Dim dc As New DataColumn("ClaseFormacion", Type.GetType("System.String"))
            dt.Columns.Add(New DataColumn("ctipo", Type.GetType("System.String")))
            dt.Columns.Add(New DataColumn("Nombre", Type.GetType("System.String")))
            Dim dr As DataRow = dt.NewRow()

            dr("ctipo") = "E"
            dr("Nombre") = "Encargado"
            dt.Rows.Add(dr)

            dr = dt.NewRow()
            dr("ctipo") = "J"
            dr("Nombre") = "Jefe"
            dt.Rows.Add(dr)

            dr = dt.NewRow()
            dr("ctipo") = "T"
            dr("Nombre") = "Técnico"
            dt.Rows.Add(dr)
           
            Dim drlist As New Janus.Windows.GridEX.GridEXValueListItemCollection
            GridEncarga.Columns("ctipo").HasValueList = True

            Dim objMod As Janus.Windows.GridEX.GridEXValueListItem
            If Not dt Is Nothing And dt.Rows.Count > 0 Then
                For Each drEnc As DataRow In dt.Rows
                    If Len(drEnc("ctipo")) > 0 Then
                        'objMod = New Janus.Windows.GridEX.GridEXValueListItem(drModelo("Modelo"), drModelo("Modelo"))
                        objMod = New Janus.Windows.GridEX.GridEXValueListItem(drEnc("ctipo"), drEnc("Nombre"))
                        ' ExpertisApp.GenerateMessage("La Formacion es " & drFor("ClaseFormacion") & " - " & drFor("DescClaseFormacion"))
                        drlist.Add(objMod)
                    End If
                Next
            End If
            GridEncarga.Columns("cTipo").ValueList.PopulateValueList(drlist, "Value", "Text")

        Catch ex As Exception
            ExpertisApp.GenerateMessage(ex.Message)
        End Try
    End Sub

#End Region

#Region "Update Grids"
    Private Sub GridFormacion_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridFormacion.RecordUpdated, GridFormacion.RecordAdded, GridFormacion.RecordsDeleted
        Try
            Dim tf As New PrevencionFormacionTipo
            tf.Update(GridFormacion.DataSource)
            tf = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GridEpis_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridEpis.RecordUpdated, GridEpis.RecordAdded
        Try
            For shcont As Short = 0 To GridEpis.DataSource.Rows.Count - 1
                If IsDBNull(GridEpis.DataSource.Rows(shcont)("idEpisTipo")) Then
                    Dim Random As New Random
                    GridEpis.DataSource.Rows(shcont)("idEpisTipo") = Random.Next(10000000, 19999999)
                End If
            Next
            Dim te As New PrevencionComboEpi
            te.Update(GridEpis.DataSource)
            te = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GridEpis_RecordDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridEpis.RecordsDeleted
        Try
            Dim te As New PrevencionComboEpi
            te.Update(GridEpis.DataSource)
            te = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub GridEncarga_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridEncarga.RecordUpdated, GridEncarga.RecordAdded
        Try
            For shcont As Short = 0 To GridEncarga.DataSource.Rows.Count - 1
                If IsDBNull(GridEncarga.DataSource.Rows(shcont)("idencargajefe")) Then
                    Dim Random As New Random
                    GridEncarga.DataSource.Rows(shcont)("idencargajefe") = Random.Next(10000000, 19999999)
                End If
            Next
            Dim enc As New PrevencionEncargaJefe
            enc.Update(GridEncarga.DataSource)
            enc = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GridEncarga_RecordDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridEncarga.RecordsDeleted
        Try
            Dim enc As New PrevencionEncargaJefe
            enc.Update(GridEncarga.DataSource)
            enc = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GridPuesto_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridPuesto.RecordUpdated, GridPuesto.RecordAdded
        Try
            For shcont As Short = 0 To GridPuesto.DataSource.Rows.Count - 1
                If IsDBNull(GridPuesto.DataSource.Rows(shcont)("idRecoPuesto")) Then
                    Dim Random As New Random()
                    GridPuesto.DataSource.Rows(shcont)("idRecoPuesto") = Random.Next(10000000, 19999999)
                End If
            Next
            Dim PP As New PrevencionRecoPuesto
            PP.Update(GridPuesto.DataSource)
            PP = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GridPuesto_RecordDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridPuesto.RecordsDeleted
        Try
            Dim PP As New PrevencionRecoPuesto
            PP.Update(GridPuesto.DataSource)
            PP = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GridPuestoObra_RecordDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridPuestoObra.RecordsDeleted
        Try
            Dim PO As New PrevencionObraPuesto
            PO.Update(GridPuestoObra.DataSource)
            PO = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GridPuestoObra_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridPuestoObra.RecordUpdated, GridPuestoObra.RecordAdded
        Try
            For shcont As Short = 0 To GridPuestoObra.DataSource.Rows.Count - 1
                If IsDBNull(GridPuestoObra.DataSource.Rows(shcont)("idObraPuesto")) Then
                    Dim Random As New Random
                    GridPuestoObra.DataSource.Rows(shcont)("idObraPuesto") = Random.Next(10000000, 19999999)
                End If
            Next
            Dim PO As New PrevencionObraPuesto
            PO.Update(GridPuestoObra.DataSource)
            PO = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub GridSancion_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridSancion.RecordUpdated, GridSancion.RecordAdded
        Try
            For shcont As Short = 0 To GridSancion.DataSource.Rows.Count - 1
                If IsDBNull(GridSancion.DataSource.Rows(shcont)("idSancion")) Then
                    Dim Random As New Random
                    GridSancion.DataSource.Rows(shcont)("idSancion") = Random.Next(10000000, 19999999)
                End If
            Next
            Dim PS As New PrevencionCombonotifSancion
            PS.Update(GridSancion.DataSource)
            PS = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GridSancion_RecordDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridSancion.RecordsDeleted
        Try
            Dim PS As New PrevencionCombonotifSancion
            PS.Update(GridSancion.DataSource)
            PS = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub GridCorreo_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridCorreo.RecordUpdated, GridCorreo.RecordAdded
        Try
            For shcont As Short = 0 To GridCorreo.DataSource.Rows.Count - 1
                If IsDBNull(GridCorreo.DataSource.Rows(shcont)("idEmail")) Then
                    Dim Random As New Random
                    GridCorreo.DataSource.Rows(shcont)("idEmail") = Random.Next(10000000, 19999999)
                End If
            Next
            Dim PS As New PrevencionEmailCombo
            PS.Update(GridCorreo.DataSource)
            PS = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GridCorreo_RecordDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridCorreo.RecordsDeleted
        Try
            Dim PS As New PrevencionEmailCombo
            PS.Update(GridCorreo.DataSource)
            PS = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GridComunicado_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridComunicado.RecordUpdated, GridComunicado.RecordAdded
        Try
            For shcont As Short = 0 To GridComunicado.DataSource.Rows.Count - 1
                If IsDBNull(GridComunicado.DataSource.Rows(shcont)("idtipo")) Then
                    Dim Random As New Random
                    GridComunicado.DataSource.Rows(shcont)("idtipo") = Random.Next(10000000, 19999999)
                End If
            Next
            Dim PC As New ObraComunicadoTipo
            PC.Update(GridComunicado.DataSource)
            PC = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GridComunicado_RecordDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridComunicado.RecordsDeleted
        Try
            Dim PC As New ObraComunicadoTipo
            PC.Update(GridComunicado.DataSource)
            PC = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GridEnvio_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridEnvio.RecordUpdated, GridEnvio.RecordAdded
        Try
            For shcont As Short = 0 To GridEnvio.DataSource.Rows.Count - 1
                If IsDBNull(GridEnvio.DataSource.Rows(shcont)("idmod")) Then
                    Dim Random As New Random
                    GridEnvio.DataSource.Rows(shcont)("idmod") = Random.Next(10000000, 19999999)
                End If
            Next
            Dim PT As New ObraEnvioTipo
            PT.Update(GridEnvio.DataSource)
            PT = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GridEnvio_RecordDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridEnvio.RecordsDeleted
        Try
            Dim PT As New ObraEnvioTipo
            PT.Update(GridEnvio.DataSource)
            PT = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


#End Region
End Class