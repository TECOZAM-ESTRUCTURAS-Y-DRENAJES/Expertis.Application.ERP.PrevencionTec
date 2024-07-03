Imports Solmicro.Expertis.Engine
Imports Janus.Windows.GridEX
Imports Solmicro.Expertis.Engine.UI
Imports System.Windows.Forms
Imports Expertis.Business.Prevencion
Imports Solmicro.Expertis.Business.Negocio
Imports Solmicro.Expertis.Business.Obra
Imports Solmicro.Expertis

Public Class MntoPrevencionOperario
    Private Sub advCodPostal_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles advCodPostal.TextChanged
        Dim DE As New BE.DataEngine
        Dim filtro As New filter
        filtro.Add("CodPostal", advCodPostal.Text)
        Dim dtloc As DataTable = DE.Filter("tbMaestroPoblacion", filtro, , , False)
        txtPoblacion.Text = dtloc.Rows(0)("DescPoblacion")
        Dim FProv As New Filter
        FProv.Add("IDprovincia", dtloc.Rows(0)("IDProvincia"))
        Dim dtProv As DataTable = DE.Filter("tbMaestroProvincia", FProv, , , False)
        txtProvincia.Text = dtProv.Rows(0)("DescProvincia")
    End Sub

#Region "Load"
    Private Sub MntoPrevencionOperario_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.Requery.Visible = Janus.Windows.UI.InheritableBoolean.True
        Me.Find.Visible = Janus.Windows.UI.InheritableBoolean.False
        Me.FindText.Visible = Janus.Windows.UI.InheritableBoolean.False
        Me.NewRow.Visible = Janus.Windows.UI.InheritableBoolean.False
        Me.Delete.Visible = Janus.Windows.UI.InheritableBoolean.False
        ' Me.FindText.Visible = Janus.Windows.UI.InheritableBoolean.False
        'Opciones de menu
        Me.FormActions.Add("Administración de combos", AddressOf AdminCombos)
        Me.FormActions.Add("Listado obras finalizadas con horas", AddressOf ListObraHoras)
        ' Cargar Combos Iniciales
        CargarCombos()
        'VaciarDatos()
    End Sub
#End Region
    Private Sub VaciarDatos()
        txtLugarReconocimiento.Text = ""
        clbFechaReconocimiento.Text = ""
        RB_Reconocimiento_no.Checked = False
        RB_Reconocimiento_ap.Checked = False
        RB_Reconocimiento_Apto.Checked = False
        txtdesSensible.Text = ""
        txtdesLimitacion.Text = ""
        UICheckLimitaciones.Text = ""
        clbtbOperarioReconocimiento_nDiasAviso.Text = ""
        UiCheckSensible.Text = ""
    End Sub

    Private Sub MntoPrevencionOperario_RecordUpdating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.RecordUpdating
        Try
            'Reconocimiento
            Dim RP As New PrevencionReconocimiento
            Me.CurrentRow("tbOperarioReconocimiento_idReconocimiento") = RP.UpdateForm(Me.CurrentRow).Rows(0)("idReconocimiento")
            RP = Nothing
            ' TabPage Formacion
            Dim PF As New PrevencionFormacion
            Me.CurrentRow("vFrmPrevencionFormacionI_idFormacion") = PF.UpdateForm(Me.CurrentRow, "vFrmPrevencionFormacionI").Rows(0)("idFormacion")
            Me.CurrentRow("vFrmPrevencionFormacionE_idFormacion") = PF.UpdateForm(Me.CurrentRow, "vFrmPrevencionFormacionE").Rows(0)("idFormacion")
            Me.CurrentRow("vFrmPrevencionFormacion8_idFormacion") = PF.UpdateForm(Me.CurrentRow, "vFrmPrevencionFormacion8").Rows(0)("idFormacion")
            Me.CurrentRow("vFrmPrevencionFormacion20_idFormacion") = PF.UpdateForm(Me.CurrentRow, "vFrmPrevencionFormacion20").Rows(0)("idFormacion")
            Me.CurrentRow("vFrmPrevencionFormacion50_idFormacion") = PF.UpdateForm(Me.CurrentRow, "vFrmPrevencionFormacion50").Rows(0)("idFormacion")
            Me.CurrentRow("vFrmPrevencionFormacionTPC_idFormacion") = PF.UpdateForm(Me.CurrentRow, "vFrmPrevencionFormacionTPC").Rows(0)("idFormacion")
            PF = Nothing
            ' Recargar Combos
            CargarListaFormacion()
            'Epis
            Dim FE As New PrevencionEpis
            Me.CurrentRow("tbOperarioEpis_idEpis") = FE.UpdateForm(Me.CurrentRow).Rows(0)("idEpis")
            FE = Nothing

            ' TabPAge Accidentes
            'Dim RA As New PrevencionAccidentes
            'Me.CurrentRow("tbOperarioAccidentes_idAccidente") = RA.UpdateForm(Me.CurrentRow).Rows(0)("idAccidente")

            ' TabPage Bajas
            Dim RB As New PrevencionAlertas
            Me.CurrentRow("tbOperarioAlertas_idAlertas") = RB.UpdateForm(Me.CurrentRow).Rows(0)("idAlertas")
            'Limpiar Memoria
            RB = Nothing
            ' TabPage Notif.
            Dim RN As New PrevencionNotificacion
            Me.CurrentRow("tbOperarioNotificacion_idnotificacion") = RN.UpdateForm(Me.CurrentRow).Rows(0)("idnotificacion")
            RN = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

#Region "Acciones del play"
    Private Sub AdminCombos()
        Dim frm As New MntoAdminCombos
        frm.ShowDialog()
        bCargarCombos = True
        CargarCombos()
        frm = Nothing
    End Sub

    Private Sub ListObraHoras()
        Dim frm As New MntoObrasHoras
        frm.ShowDialog()
        frm = Nothing
    End Sub
#End Region

#Region "Cargar Combos"
    Private bCargarCombos = True
    Private Sub CargarCombos()
        Try
            ''Para sólo recorrerlos una vez
            If bCargarCombos Then
                'Combos de puestos
                CargarListaPuesto()
                CargarListaEmail(GridCorreoReconocimiento)
                If GridReconocimiento.Columns("snApto").EditType = Janus.Windows.GridEX.EditType.TextBox Then
                    GridReconocimiento.Columns("snApto").EditType = Janus.Windows.GridEX.EditType.DropDownList
                    CargarListaApto()
                    GridReconocimiento.Refresh()
                End If

                ' Combos de formación
                CargarListaFormacion()
                CargarEpis()

                'Combos Accidentes
                If GridAccidentes.Columns("Tipo").EditType = Janus.Windows.GridEX.EditType.TextBox Then
                    GridAccidentes.Columns("Tipo").EditType = Janus.Windows.GridEX.EditType.DropDownList
                    CargarListaAccidentes()
                    GridAccidentes.Refresh()
                    GridAccidentes.Columns("CodObra").EditType = Janus.Windows.GridEX.EditType.DropDownList
                    CargarListaIdObra()
                    GridAccidentes.Refresh()
                    CargarListaEmail(GridCorreoAcc)
                End If

                ' Combo Notificaciones
                If GridNotificacion.Columns("Gravedad").EditType = Janus.Windows.GridEX.EditType.TextBox Then
                    GridNotificacion.Columns("Gravedad").EditType = Janus.Windows.GridEX.EditType.DropDownList
                    GridNotificacion.Columns("idObra").EditType = Janus.Windows.GridEX.EditType.DropDownList
                    CargarListaNotificacion()
                    'CargarListaIdObra()
                    GridNotificacion.Refresh()
                End If
                ' Cargar combos de Encargado y Jefe
                CargarEncargaJefe()
                ' Cargar Sanción
                CargarSancion()

                ' Combo Email bajascc
                CargarListaEmail(GridCorreoBajas)
                ' Cancelar recargar combos
                bCargarCombos = False

            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub CargarListaPuesto()
        Try
            Dim dropClaseForm As New GridEXDropDown
            Dim dt As New DataTable

            Dim BE As New Solmicro.Expertis.Engine.BE.DataEngine
            dt = BE.RetrieveData("tbOperarioPuesto", "DescPuesto", , , False)

            'ExpertisApp.GenerateMessage("Hay " & dt.Rows.Count & " Puestos")



            Dim drlist As New Janus.Windows.GridEX.GridEXValueListItemCollection
            GridPuestos.Columns("idOficio").HasValueList = True

            Dim objMod As Janus.Windows.GridEX.GridEXValueListItem
            If Not dt Is Nothing And dt.Rows.Count > 0 Then
                For Each drPuesto As DataRow In dt.Rows
                    If Len(drPuesto("DescPuesto")) > 0 Then
                        'objMod = New Janus.Windows.GridEX.GridEXValueListItem(drModelo("Modelo"), drModelo("Modelo"))
                        objMod = New Janus.Windows.GridEX.GridEXValueListItem(drPuesto("DescPuesto"), drPuesto("DescPuesto"))
                        ' ExpertisApp.GenerateMessage("La Formacion es " & drFor("ClaseFormacion") & " - " & drFor("DescClaseFormacion"))
                        drlist.Add(objMod)
                    End If
                Next
            End If
            GridPuestos.Columns("idOficio").ValueList.PopulateValueList(drlist, "Value", "Text")

        Catch ex As Exception
            ExpertisApp.GenerateMessage(ex.Message)
        End Try
    End Sub

    Private Sub CargarListaEmail(ByRef Grid As Solmicro.Expertis.Engine.UI.Grid)
        Try
            Dim dropClaseForm As New GridEXDropDown
            Dim dt As New DataTable

            Dim BE As New Solmicro.Expertis.Engine.BE.DataEngine
            dt = BE.RetrieveData("tbOperarioEmailCombo", "email", , , False)

            'ExpertisApp.GenerateMessage("Hay " & dt.Rows.Count & " Puestos")



            Dim drlist As New Janus.Windows.GridEX.GridEXValueListItemCollection
            Grid.Columns("email").HasValueList = True

            Dim objMod As Janus.Windows.GridEX.GridEXValueListItem
            If Not dt Is Nothing And dt.Rows.Count > 0 Then
                For Each drEmail As DataRow In dt.Rows
                    If Len(drEmail("email")) > 0 Then
                        'objMod = New Janus.Windows.GridEX.GridEXValueListItem(drModelo("Modelo"), drModelo("Modelo"))
                        objMod = New Janus.Windows.GridEX.GridEXValueListItem(drEmail("email"), drEmail("email"))
                        ' ExpertisApp.GenerateMessage("La Formacion es " & drFor("ClaseFormacion") & " - " & drFor("DescClaseFormacion"))
                        drlist.Add(objMod)
                    End If
                Next
            End If
            Grid.Columns("email").ValueList.PopulateValueList(drlist, "Value", "Text")

        Catch ex As Exception
            ExpertisApp.GenerateMessage(ex.Message)
        End Try
    End Sub

    Private Sub CargarListaApto()
        Try
            Dim dropClaseForm As New GridEXDropDown
            Dim dt As New DataTable
            'Dim dc As New DataColumn("ClaseFormacion", Type.GetType("System.String"))
            dt.Columns.Add(New DataColumn("Valor", Type.GetType("System.String")))
            dt.Columns.Add(New DataColumn("Tipo", Type.GetType("System.String")))
            Dim dr As DataRow = dt.NewRow()

            dr("valor") = 1
            dr("Tipo") = "No Apto"
            dt.Rows.Add(dr)

            dr = dt.NewRow()
            dr("valor") = 2
            dr("Tipo") = "Apto Provisional"
            dt.Rows.Add(dr)

            dr = dt.NewRow()
            dr("valor") = 3
            dr("Tipo") = "Apto"
            dt.Rows.Add(dr)

            Dim drlist As New Janus.Windows.GridEX.GridEXValueListItemCollection
            GridReconocimiento.Columns("snApto").HasValueList = True

            Dim objMod As Janus.Windows.GridEX.GridEXValueListItem
            If Not dt Is Nothing And dt.Rows.Count > 0 Then
                For Each drRec As DataRow In dt.Rows
                    If Len(drRec("valor")) > 0 Then
                        'objMod = New Janus.Windows.GridEX.GridEXValueListItem(drModelo("Modelo"), drModelo("Modelo"))
                        objMod = New Janus.Windows.GridEX.GridEXValueListItem(drRec("valor"), drRec("Tipo"))
                        ' ExpertisApp.GenerateMessage("La Formacion es " & drFor("ClaseFormacion") & " - " & drFor("DescClaseFormacion"))
                        drlist.Add(objMod)
                    End If
                Next
            End If
            GridReconocimiento.Columns("snApto").ValueList.PopulateValueList(drlist, "Value", "Text")

        Catch ex As Exception
            ExpertisApp.GenerateMessage(ex.Message)
        End Try
    End Sub

    Private Sub CargarListaFormacion()
        Try
            Dim BE As New BE.DataEngine
            ' Combos Formación

            ' F. Interna
            Dim FInt As New Filter
            FInt.Add("claseformacion", 1)
            Dim dtInt As DataTable = BE.Filter("tbOperarioFormacionTipo", FInt, "claseFormacion,DescClaseFormacion", , False)
            UICB_FormacionI.DataSource = dtInt
            UICB_FormacionI.DisplayMember = UICB_FormacionI.DataSource.Columns("DescClaseFormacion").Caption.ToString
            UICB_FormacionI.ValueMember = UICB_FormacionI.DisplayMember

            ' F. Externa
            Dim FExt As New Filter
            FExt.Add("claseformacion", 2)
            Dim dtExt As DataTable = BE.Filter("tbOperarioFormacionTipo", FExt, "claseFormacion,DescClaseFormacion", , False)
            UiCB_FormacionE.DataSource = dtExt
            UiCB_FormacionE.DisplayMember = UiCB_FormacionE.DataSource.Columns("DescClaseFormacion").Caption.ToString
            UiCB_FormacionE.ValueMember = UiCB_FormacionE.DisplayMember

            ' F. 20
            Dim F20 As New Filter
            F20.Add("claseformacion", 20)
            Dim dt20 As DataTable = BE.Filter("tbOperarioFormacionTipo", F20, "claseFormacion,DescClaseFormacion", , False)
            UiCB_Formacion20.DataSource = dt20
            UiCB_Formacion20.DisplayMember = UiCB_Formacion20.DataSource.Columns("DescClaseFormacion").Caption.ToString
            UiCB_Formacion20.ValueMember = UiCB_Formacion20.DisplayMember

            ' F. 50
            Dim F50 As New Filter
            F50.Add("claseformacion", 50)
            Dim dt50 As DataTable = BE.Filter("tbOperarioFormacionTipo", F50, "claseFormacion,DescClaseFormacion", , False)
            UiCB_Formacion50.DataSource = dt50
            UiCB_Formacion50.DisplayMember = UiCB_Formacion50.DataSource.Columns("DescClaseFormacion").Caption.ToString
            UiCB_Formacion50.ValueMember = UiCB_Formacion50.DisplayMember

        Catch ex As Exception
            ExpertisApp.GenerateMessage(ex.Message)
        End Try
    End Sub

    Private Sub CargarEpis()
        Try
            'Dim Strsql As String
            'Strsql = "SELECT DescEpi FROM tbOperarioEpisTipo"

            Dim BE As New BE.DataEngine

            ' Cargar Encargados
            UiCB_Epi.DataSource = BE.RetrieveData("tbOperarioEpisTipo", "DescEpi", , , False)
            UiCB_Epi.DisplayMember = UiCB_Epi.DataSource.Columns("DescEpi").Caption.ToString
            UiCB_Epi.ValueMember = UiCB_Epi.DisplayMember

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CargarListaAccidentes()
        Try
            Dim dropClaseForm As New GridEXDropDown
            Dim dt As New DataTable
            'Dim dc As New DataColumn("ClaseFormacion", Type.GetType("System.String"))
            dt.Columns.Add(New DataColumn("Valor", Type.GetType("System.String")))
            dt.Columns.Add(New DataColumn("Tipo", Type.GetType("System.String")))
            Dim dr As DataRow = dt.NewRow()

            dr("valor") = 1
            dr("Tipo") = "Leve"
            dt.Rows.Add(dr)

            dr = dt.NewRow()
            dr("valor") = 2
            dr("Tipo") = "Grave"
            dt.Rows.Add(dr)

            dr = dt.NewRow()
            dr("valor") = 3
            dr("Tipo") = "Mortal"
            dt.Rows.Add(dr)

            dr = dt.NewRow()
            dr("valor") = 4
            dr("Tipo") = "Sin Baja"
            dt.Rows.Add(dr)

            Dim drlist As New Janus.Windows.GridEX.GridEXValueListItemCollection
            GridAccidentes.Columns("Tipo").HasValueList = True

            Dim objMod As Janus.Windows.GridEX.GridEXValueListItem
            If Not dt Is Nothing And dt.Rows.Count > 0 Then
                For Each drRec As DataRow In dt.Rows
                    If Len(drRec("valor")) > 0 Then
                        'objMod = New Janus.Windows.GridEX.GridEXValueListItem(drModelo("Modelo"), drModelo("Modelo"))
                        objMod = New Janus.Windows.GridEX.GridEXValueListItem(drRec("valor"), drRec("Tipo"))
                        ' ExpertisApp.GenerateMessage("La Formacion es " & drFor("ClaseFormacion") & " - " & drFor("DescClaseFormacion"))
                        drlist.Add(objMod)
                    End If
                Next
            End If
            GridAccidentes.Columns("Tipo").ValueList.PopulateValueList(drlist, "Value", "Text")

        Catch ex As Exception
            ExpertisApp.GenerateMessage(ex.Message)
        End Try
    End Sub

    Private Sub CargarListaIdObra()

        Try
            Dim dropClaseForm As New GridEXDropDown
            Dim dt As New DataTable
            Dim BE As New BE.DataEngine

            dt = BE.RetrieveData("tbObraCabecera", "IDObra,DescObra", , , False)


            Dim drlist As New Janus.Windows.GridEX.GridEXValueListItemCollection
            GridAccidentes.Columns("codObra").HasValueList = True
            Dim contador As Integer = 1
            Dim objMod As Janus.Windows.GridEX.GridEXValueListItem
            If Not dt Is Nothing And dt.Rows.Count > 0 Then

                For Each drObra As DataRow In dt.Rows
                    If Len(drObra("idObra")) > 0 Then

                        'objMod = New Janus.Windows.GridEX.GridEXValueListItem(drModelo("Modelo"), drModelo("Modelo"))
                        objMod = New Janus.Windows.GridEX.GridEXValueListItem(drObra("idObra"), Nz(drObra("DescObra"), ""))

                        ' ExpertisApp.GenerateMessage("La Formacion es " & drFor("ClaseFormacion") & " - " & drFor("DescClaseFormacion"))
                        drlist.Add(objMod)

                    End If
                Next
            End If

            GridAccidentes.Columns("codObra").ValueList.PopulateValueList(drlist, "Value", "Text")


        Catch ex As Exception
            ExpertisApp.GenerateMessage(ex.Message)
        End Try
    End Sub

    Private Sub CargarListaNotificacion()
        Try
            Dim dropClaseForm As New GridEXDropDown
            Dim dt As New DataTable
            'Dim dc As New DataColumn("ClaseFormacion", Type.GetType("System.String"))

            dt.Columns.Add(New DataColumn("Valor", Type.GetType("System.String")))

            dt.Columns.Add(New DataColumn("Tipo", Type.GetType("System.String")))

            Dim dr As DataRow = dt.NewRow()

            dr("valor") = "1"
            dr("Tipo") = "Leve"
            dt.Rows.Add(dr)

            dr = dt.NewRow()
            dr("valor") = "2"
            dr("Tipo") = "Grave"
            dt.Rows.Add(dr)

            dr = dt.NewRow()
            dr("valor") = "3"
            dr("Tipo") = "Muy Grave"
            dt.Rows.Add(dr)

            Dim drlist As New Janus.Windows.GridEX.GridEXValueListItemCollection

            GridNotificacion.Columns("Gravedad").HasValueList = True

            Dim objMod As New Janus.Windows.GridEX.GridEXValueListItem

            If Not dt Is Nothing And dt.Rows.Count > 0 Then

                For Each drRec As DataRow In dt.Rows
                    If Length(drRec("valor")) > 0 Then
                        'objMod = New Janus.Windows.GridEX.GridEXValueListItem(drModelo("Modelo"), drModelo("Modelo"))

                        objMod = New Janus.Windows.GridEX.GridEXValueListItem(drRec("valor"), drRec("Tipo"))
                        ' ExpertisApp.GenerateMessage("La Formacion es " & drFor("ClaseFormacion") & " - " & drFor("DescClaseFormacion"))
                        drlist.Add(objMod)
                    End If
                Next
            End If
            GridNotificacion.Columns("Gravedad").ValueList.PopulateValueList(drlist, "Value", "Text")

            Dim drlistObra As New Janus.Windows.GridEX.GridEXValueListItemCollection
            GridNotificacion.Columns("IdObra").HasValueList = True
            Dim BE As New BE.DataEngine
            Dim dtObra = BE.RetrieveData("tbObraCabecera", "IDObra,DescObra", , , False)

            Dim objModObra As Janus.Windows.GridEX.GridEXValueListItem
            If Not dtObra Is Nothing And dtObra.Rows.Count > 0 Then
                For Each drObra As DataRow In dtObra.Rows
                    If Len(drObra("IDObra")) > 0 Then
                        'objMod = New Janus.Windows.GridEX.GridEXValueListItem(drModelo("Modelo"), drModelo("Modelo"))
                        objModObra = New Janus.Windows.GridEX.GridEXValueListItem(drObra("IDObra"), Nz(drObra("DescObra"), ""))
                        ' ExpertisApp.GenerateMessage("La Formacion es " & drFor("ClaseFormacion") & " - " & drFor("DescClaseFormacion"))
                        drlistObra.Add(objModObra)
                    End If
                Next
            End If
            GridNotificacion.Columns("IdObra").ValueList.PopulateValueList(drlistObra, "Value", "Text")


        Catch ex As Exception
            ExpertisApp.GenerateMessage(ex.Message)
        End Try
    End Sub

    Private Sub CargarEncargaJefe()
        Try
            Dim DE As New BE.DataEngine

            Dim FiltroEnc As New Filter
            FiltroEnc.Add("ctipo", "E")

            Dim FiltroJP As New Filter
            FiltroJP.Add("ctipo", "J")

            'Cargar Encargados
            'Accidentes
            UiCB_AccidentesE.DataSource = DE.Filter("tbOperarioEncargajefe", FiltroEnc, "Nombre,ctipo", , False)
            UiCB_AccidentesE.DisplayMember = UiCB_AccidentesE.DataSource.Columns("Nombre").Caption.ToString
            UiCB_AccidentesE.ValueMember = UiCB_AccidentesE.DisplayMember
            'Notificaciones
            UiCB_NotificacionesE.DataSource = DE.Filter("tbOperarioEncargajefe", FiltroEnc, "Nombre,ctipo", , False)
            UiCB_NotificacionesE.DisplayMember = UiCB_AccidentesE.DataSource.Columns("Nombre").Caption.ToString
            UiCB_NotificacionesE.ValueMember = UiCB_AccidentesE.DisplayMember
            'Bajas
            UiCB_BajasE.DataSource = DE.Filter("tbOperarioEncargajefe", FiltroEnc, "Nombre,ctipo", , False)
            UiCB_BajasE.DisplayMember = UiCB_AccidentesE.DataSource.Columns("Nombre").Caption.ToString
            UiCB_BajasE.ValueMember = UiCB_AccidentesE.DisplayMember

            'Cargar Jefes
            'Accidentes
            UiCB_AccidentesJ.DataSource = DE.Filter("tbOperarioEncargajefe", FiltroJP, "Nombre,ctipo", , False)
            UiCB_AccidentesJ.DisplayMember = UiCB_AccidentesE.DataSource.Columns("Nombre").Caption.ToString
            UiCB_AccidentesJ.ValueMember = UiCB_AccidentesE.DisplayMember
            'Notificaciones
            UiCB_NotificacionesJ.DataSource = DE.Filter("tbOperarioEncargajefe", FiltroJP, "Nombre,ctipo", , False)
            UiCB_NotificacionesJ.DisplayMember = UiCB_AccidentesE.DataSource.Columns("Nombre").Caption.ToString
            UiCB_NotificacionesJ.ValueMember = UiCB_AccidentesE.DisplayMember
        Catch ex As Exception
            ExpertisApp.GenerateMessage(ex.Message)
        End Try
    End Sub

    Private Sub CargarSancion()
        Try
            Dim DE As New BE.DataEngine
            Dim dt As DataTable = DE.RetrieveData("tbOperarioNotificacionSan", "DescSancion", , , False)
            UiCB_NotificacionesS.DataSource = dt
            UiCB_NotificacionesS.DisplayMember = UiCB_NotificacionesS.DataSource.Columns("DescSancion").Caption.ToString
            UiCB_NotificacionesS.ValueMember = UiCB_NotificacionesS.DisplayMember
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub


#End Region

#Region "Reglas de validación"
    'Validacion Accidentes
    Private Sub GridAccidentes_CellUpdated(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles GridAccidentes.CellUpdated
        Try
            With GridAccidentes
                With GridAccidentes
                    If Not (.Value(.Columns("fAlta").Index)) Is Nothing And Not (.Value(.Columns("fBaja").Index)) Is Nothing Then
                        If IsDate(.Value(.Columns("fAlta").Index)) And IsDate(.Value(.Columns("fBaja").Index)) Then
                            Select Case DateDiff(DateInterval.Day, .Value(.Columns("fBaja").Index), .Value(.Columns("fAlta").Index))
                                Case Is < 0
                                    MsgBox("La fecha de baja no puede ser superior a la fecha de alta", MsgBoxStyle.Exclamation, "Control días de baja")
                                    .Value(.Columns("fAlta").Index) = .Value(.Columns("fBaja").Index)
                                    .Value(.Columns("NDiasBaja").Index) = 0
                                Case Else
                                    .Value(.Columns("NDiasBaja").Index) = DateDiff(DateInterval.Day, .Value(.Columns("fBaja").Index), .Value(.Columns("fAlta").Index))
                            End Select
                            GridAccidentes.Refresh()
                        End If
                    End If
                End With
            End With
        Catch ex As Exception

        End Try
    End Sub
#End Region

    Private Sub brnRecon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles brnRecon.Click
        NuevoReco()
        'VaciarDatos()
        Me.UpdateData()
    End Sub

    Private Sub btnFInternaNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFInternaNew.Click
        NuevaFormacion("vFrmPrevencionFormacionI")
        Me.UpdateData()

    End Sub

    Private Sub btnAccidentessn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccidentessn.Click
        NuevoAc()
    End Sub

    Private Sub btnNotificacionesNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNotificacionesNuevo.Click
        NuevaNotif()
    End Sub

    Private Sub btnBajasN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBajasN.Click
        NuevaBaja()
    End Sub

    Private Sub btnFExternaNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFExternaNew.Click
        NuevaFormacion("vFrmPrevencionFormacionE")
    End Sub

    Private Sub btnF20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnF20.Click
        NuevaFormacion("vFrmPrevencionFormacion20")
    End Sub

    Private Sub btnF50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnF50.Click
        NuevaFormacion("vFrmPrevencionFormacion50")
    End Sub

    Private Sub btnEPIS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEPIS.Click
        NuevoEpi()
    End Sub

    Private Sub NuevoReco()
        ' TabPage Bajas
        If MsgBox("¿Desea guardar al histórico el registro actual y añadir uno nuevo?", MsgBoxStyle.YesNo, "Generar histórico") = MsgBoxResult.Yes Then
            Dim PR As New PrevencionReconocimiento

            Dim dt As New DataTable

            dt.Columns.Add("IDReconocimiento")
            dt.Columns.Add("IDOperario")
            dt.Columns.Add("snApto")
            dt.Columns.Add("Fecha")
            dt.Columns.Add("Lugar")
            dt.Columns.Add("snLimitacion")
            dt.Columns.Add("desLimitacion")
            dt.Columns.Add("snSensible")
            dt.Columns.Add("desSensible")
            dt.Columns.Add("snAvisoPrevio")
            dt.Columns.Add("nDiasAviso")
            dt.Columns.Add("idRemesa")
            dt.Columns.Add("snHistorico")

            Dim dr As DataRow = dt.NewRow()

            dr("IDOperario") = Me.CurrentRow("IDOperario")
            If Me.RB_Reconocimiento_no.Checked Then
                dr("snApto") = 1
            ElseIf Me.RB_Reconocimiento_ap.Checked Then
                dr("snApto") = 2
            ElseIf Me.RB_Reconocimiento_Apto.Checked Then
                dr("snApto") = 3
            Else
                dr("snApto") = DBNull.Value
            End If

            dr("Fecha") = Me.clbFechaReconocimiento.Value
            dr("Lugar") = Me.txtLugarReconocimiento.Text
            If Me.UICheckLimitaciones.Checked Then
                dr("snLimitacion") = 1
            Else
                dr("snLimitacion") = 0
            End If

            dr("desLimitacion") = Me.txtdesLimitacion.Text

            If Me.UiCheckSensible.Checked Then
                dr("snSensible") = 1
            Else
                dr("snSensible") = 0
            End If

            dr("DesSensible") = Me.txtdesSensible.Text
            dr("snAvisoPrevio") = 0
            dr("nDiasAviso") = Me.clbtbOperarioReconocimiento_nDiasAviso.Value
            'dr("IDRemesa") = Me.CurrentRow("IDRemesa")
            dr("snHistorico") = 1

            dt.Rows.Add(dr)

            PR.Update(dt)
            Me.CurrentRow("tbOperarioReconocimiento_idReconocimiento") = DBNull.Value
            ' Limpiar memoria
            PR = Nothing
            'Me.RequeryData()
            'Me.UpdateData()

        End If
    End Sub


    Private Sub NuevaFormacion(ByVal sVistaFormacion As String)
        ' TabPage Bajas
        If MsgBox("¿Desea guardar al histórico el registro actual y añadir uno nuevo?", MsgBoxStyle.YesNo, "Generar histórico") = MsgBoxResult.Yes Then
            Dim PF As New PrevencionFormacion
            Dim dt As New DataTable

            dt.Columns.Add("IDFormacion")
            dt.Columns.Add("IDOperario")
            dt.Columns.Add("ClaseFormacion")
            dt.Columns.Add("DescClaseFormacion")
            dt.Columns.Add("DesFormacion")
            dt.Columns.Add("snIncluir")
            dt.Columns.Add("Horas")
            dt.Columns.Add("Lugar")
            dt.Columns.Add("Fecha")
            dt.Columns.Add("EmpresaForma")
            dt.Columns.Add("sntpc")
            dt.Columns.Add("Usuario")
            dt.Columns.Add("Password")
            dt.Columns.Add("snhistorico")
            dt.Columns.Add("snPuesto")
            dt.Columns.Add("snEspecifica")

            Dim dr As DataRow = dt.NewRow
            dr("IDOperario") = Me.CurrentRow("IDOperario")

            Select Case sVistaFormacion
                Case "vFrmPrevencionFormacionI"

                    dr("ClaseFormacion") = Me.UICB_FormacionI.SelectedItem(0)
                    dr("DescClaseFormacion") = Me.UICB_FormacionI.Value
                    dr("DesFormacion") = Me.SLE_FInterna_Especificar.Text
                    dr("Horas") = Me.SLE_FInterna_Horas.Text
                    dr("Fecha") = Me.clb_FInterna_fecha.Value
                    dr("snPuesto") = Me.chbvFrmPrevencionFormacionI_snPuesto.CheckedValue
                    dr("snEspecifica") = Me.chbvFrmPrevencionFormacionI_snEspecifica.CheckedValue

                Case "vFrmPrevencionFormacionE"

                    dr("ClaseFormacion") = Me.UiCB_FormacionE.SelectedItem(0)
                    dr("DescClaseFormacion") = Me.UiCB_FormacionE.Value
                    dr("DesFormacion") = Me.SLE_FInterna_Especificar.Text
                    dr("Horas") = Me.SLE_FExternaHoras.Text
                    dr("Fecha") = Me.ClB_FExterna_Fecha.Value

                Case "vFrmPrevencionFormacion20"

                    dr("ClaseFormacion") = Me.UiCB_Formacion20.SelectedItem(0)
                    dr("DescClaseFormacion") = Me.UiCB_Formacion20.Value
                    dr("sntpc") = Me.UiCheck20.CheckedValue
                    dr("EmpresaForma") = Me.SLE_FFLC_Empresa20.Text
                    dr("Lugar") = Me.SLE_FFLC_Lugar20.Text
                    dr("Fecha") = Me.ClB_FFLC_Fecha20.Value

                Case "vFrmPrevencionFormacion50"

                    dr("ClaseFormacion") = Me.UiCB_Formacion50.SelectedItem(0)
                    dr("DescClaseFormacion") = Me.UiCB_Formacion50.Value
                    dr("EmpresaForma") = Me.SLE_FFLC_Empresa50.Text
                    dr("Lugar") = Me.SLE_FFLC_Lugar50.Text
                    dr("Fecha") = Me.clbvFrmPrevencionFormacion50_fecha.Value

            End Select

            dr("snHistorico") = 1

            dt.Rows.Add(dr)

            PF.Update(dt)
            Me.CurrentRow(sVistaFormacion & "_idFormacion") = DBNull.Value
            ' Limpiar memoria
            PF = Nothing
            'Me.RequeryData()
            Me.UpdateData()
        End If
    End Sub

    Private Sub NuevoEpi()
        ' TabPage Bajas
        If MsgBox("¿Desea guardar al histórico el registro actual y añadir uno nuevo?", MsgBoxStyle.YesNo, "Generar histórico") = MsgBoxResult.Yes Then
            Dim PR As New PrevencionEpis
            Dim dt As New DataTable

            dt.Columns.Add("IDEpis")
            dt.Columns.Add("IDOperario")
            dt.Columns.Add("Fecha")
            dt.Columns.Add("DesEpis")
            dt.Columns.Add("DesAdicional")
            dt.Columns.Add("snhistorico")

            Dim dr As DataRow = dt.NewRow()

            dr("IDOperario") = Me.CurrentRow("IDOperario")
            dr("Fecha") = Me.ClB_EPIS_Fecha.Value
            dr("DesEpis") = Me.UiCB_Epi.Text
            dr("DesAdicional") = Me.SLE_EPIS_Equipo.Text
            dr("snHistorico") = 1

            dt.Rows.Add(dr)

            PR.Update(dt)
            Me.CurrentRow("tbOperarioEpis_idEpis") = DBNull.Value
            ' Limpiar memoria
            PR = Nothing
            'Me.RequeryData()
            Me.UpdateData()
        End If
    End Sub

    Private Sub NuevoAc()
        ' TabPage Bajas
        If MsgBox("¿Desea guardar al histórico el registro actual y añadir uno nuevo?", MsgBoxStyle.YesNo, "Generar histórico") = MsgBoxResult.Yes Then
            Dim PA As New PrevencionAccidentes
            Dim dt As New DataTable

            dt.Columns.Add("idAccidente")
            dt.Columns.Add("idOperario")
            dt.Columns.Add("fAccidente")
            dt.Columns.Add("fBaja")
            dt.Columns.Add("fAlta")
            dt.Columns.Add("nDiasBaja")
            dt.Columns.Add("fNotificacion")
            dt.Columns.Add("tipo")
            dt.Columns.Add("snrecaida")
            dt.Columns.Add("Lugar")
            dt.Columns.Add("Encargado")
            dt.Columns.Add("JefeProd")
            dt.Columns.Add("obra")
            dt.Columns.Add("codobra")
            dt.Columns.Add("sninvestigaciono")
            dt.Columns.Add("sninvestigacionpre")
            dt.Columns.Add("descripcioninves")
            dt.Columns.Add("snseguimiento")
            dt.Columns.Add("desSeguimiento")
            dt.Columns.Add("fechaseg")
            dt.Columns.Add("fAlerta")
            dt.Columns.Add("idRemesa")
            dt.Columns.Add("snHistorico")

            Dim dr As DataRow = dt.NewRow

            dr("idOperario") = Me.CurrentRow("IDOperario")
            dr("fAccidente") = Me.ClB_Accidentes_FAccidente.Value
            dr("fBaja") = Me.ClB_Accidentes_Fbaja.Value


            If Me.clbtbOperarioAccidentes_falta.Value.ToString.Length = 0 Then
                'dr("nDiasBaja") = Me.sle_Accidentes_Dias.Text
            Else
                dr("fAlta") = Me.clbtbOperarioAccidentes_falta.Value
                'sle_Accidentes_Dias.Text = DateDiff(DateInterval.Day, ClB_Accidentes_Fbaja.Value, clbtbOperarioAccidentes_falta.Value)
                dr("nDiasBaja") = Me.sle_Accidentes_Dias.Text

                'dfernandez 03/07/2024


            End If
            Try
                dr("fNotificacion") = Me.clbtbOperarioAccidentes_fNotificacion.Value
            Catch ex As Exception

            End Try


            If Me.RB_Accidentes_leve.Checked Then
                dr("tipo") = 1
            ElseIf Me.RB_Accidentes_Grave.Checked Then
                dr("tipo") = 2
            ElseIf Me.rbttbOperarioAccidentes_tipo2.Checked Then
                dr("tipo") = 3
            ElseIf Me.RB_Accidentes_SinBaja.Checked Then
                dr("tipo") = 4
            Else
                dr("tipo") = DBNull.Value
            End If

            dr("snrecaida") = UiC_Accidentes_Recaida.CheckedValue
            dr("Lugar") = Me.SLE_Accidentes_Lugar.Text
            dr("Encargado") = Me.UiCB_AccidentesE.Value
            dr("JefeProd") = Me.UiCB_AccidentesJ.Value
            dr("obra") = Me.Ul_Accidentes_obra.Text
            dr("codobra") = Me.AdvS_Accidentes_Obra.Text
            'dr("obra") = Me.AdvS_Accidentes_Obra.Text
            dr("sninvestigaciono") = Me.UiC_Accidentes_Obra.CheckedValue
            dr("sninvestigacionpre") = Me.UiC_Accidentes_Investigacion.CheckedValue
            dr("descripcioninves") = Me.SLE_Accidentes_Descripcion.Text
            dr("snseguimiento") = Me.UiC_Accidentes_Requiere.CheckedValue
            dr("desSeguimiento") = Me.SLE_Accidentes_Seguimiento.Text
            dr("fechaseg") = Me.ClB_Accidentes_Requiere.Value

            'Dim prev As New Business.Prevencion.PrevencionAccidentes
            'dr("idaccidente") = prev.DevuelveID()

            'dr("fAlerta")
            'dr("idRemesa")
            dr("snHistorico") = 1
            dt.Rows.Add(dr)
            Dim dt2 As New DataTable
            dt2 = dt
            PA.Update(dt2)
            Me.CurrentRow("tbOperarioAccidentes_idAccidente") = DBNull.Value
            ' Limpiar memoria
            'PA = Nothing
            'Me.RequeryData()
            Me.UpdateData()


        End If
    End Sub

    Private Sub NuevaNotif()
        ' TabPage Bajas
        If MsgBox("¿Desea guardar al histórico el registro actual y añadir uno nuevo?", MsgBoxStyle.YesNo, "Generar histórico") = MsgBoxResult.Yes Then

            Dim PN As New PrevencionNotificacion
            Dim dt As New DataTable

            dt.Columns.Add("IDNotificacion")
            dt.Columns.Add("IDOperario")
            dt.Columns.Add("FechaSeguimiento")
            dt.Columns.Add("IDObra")
            dt.Columns.Add("Tipo")
            dt.Columns.Add("Gravedad")
            dt.Columns.Add("Observaciones")
            dt.Columns.Add("snHistorico")
            dt.Columns.Add("Encargado")
            dt.Columns.Add("Jefeprod")
            dt.Columns.Add("DescSancion")
            dt.Columns.Add("snRecibida")

            Dim dr As DataRow = dt.NewRow()

            dr("IDOperario") = Me.CurrentRow("IDOperario")
            dr("FechaSeguimiento") = Me.ClB_Notificaciones_Fecha.Value
            dr("IDObra") = Me.AdS_Notificaciones_Obra.Text
            dr("Tipo") = Me.SLE_Notificaciones_Tipo.Text
            If Me.RB_Notificaciones_leve.Checked Then
                dr("Gravedad") = 1
            ElseIf Me.RB_Notificaciones_Grave.Checked Then
                dr("Gravedad") = 2
            ElseIf Me.RB_Notificaciones_MuyGrave.Checked Then
                dr("Gravedad") = 3
            Else
                dr("Gravedad") = DBNull.Value
            End If

            dr("Observaciones") = Me.SLE_Notificaciones_Observaciones.Text
            dr("snHistorico") = 1
            dr("Encargado") = Me.UiCB_NotificacionesE.Text
            dr("JefeProd") = Me.UiCB_NotificacionesJ.Text
            dr("DescSancion") = Me.UiCB_NotificacionesS.Text
            If UiC_Notificaciones_Recibida.Checked Then
                dr("SNRecibida") = 1
            Else
                dr("SNRecibida") = 0
            End If

            dt.Rows.Add(dr)

            PN.Update(dt)

            Me.CurrentRow("tbOperarioNotificacion_IdNotificacion") = DBNull.Value
            ' Limpiar memoria
            PN = Nothing
            'Me.RequeryData()
            Me.UpdateData()

        End If
    End Sub

    Private Sub NuevaBaja()
        ' TabPage Bajas
        If MsgBox("¿Desea guardar al histórico el registro actual y añadir uno nuevo?", MsgBoxStyle.YesNo, "Generar histórico") = MsgBoxResult.Yes Then
            Dim PB As New PrevencionAlertas
            Dim dt As New DataTable

            dt.Columns.Add("idAlertas")
            dt.Columns.Add("idOperario")
            dt.Columns.Add("fBaja")
            dt.Columns.Add("fAlta")
            dt.Columns.Add("ndias")
            dt.Columns.Add("fConf")
            dt.Columns.Add("Lugar")
            dt.Columns.Add("Encargado")
            dt.Columns.Add("sndejaPaises")
            dt.Columns.Add("snotrosPaises")
            dt.Columns.Add("fEmail")
            dt.Columns.Add("descripcion")
            dt.Columns.Add("Seguimiento")
            dt.Columns.Add("idRemesa")
            dt.Columns.Add("snHistorico")

            Dim dr As DataRow = dt.NewRow
            dr("idOperario") = Me.CurrentRow("IDOperario")
            dr("fBaja") = Me.ClB_Bajas_Baja.Value

            If Me.ClB_Bajas_Alta.Value.ToString.Length = 0 Then

            Else
                dr("fAlta") = Me.ClB_Bajas_Alta.Value
                sle_Bajas_Dias.Text = DateDiff(DateInterval.Day, ClB_Bajas_Baja.Value, ClB_Bajas_Alta.Value)
                dr("ndias") = Me.sle_Bajas_Dias.Text
            End If
            Try
                dr("fConf") = Me.ClB_Bajas_conf.Value
            Catch ex As Exception

            End Try

            dr("Lugar") = Me.AdvS_Bajas_Obra.Value
            dr("Encargado") = Me.UiCB_BajasE.Text
            'dr("sndejaPaises") = Me.UiCheck_bajas_baja.CheckedValue
            dr("snotrosPaises") = Me.UiCheck_bajas_baja.CheckedValue
            'dr("fEmail")
            dr("descripcion") = Me.sle_bajas_descripcion.Text
            dr("Seguimiento") = Me.sle_bajas_seguimiento.Text
            'dr("idRemesa")
            dr("snHistorico") = 1

            dt.Rows.Add(dr)

            PB.Update(dt)
            Me.CurrentRow("tbOperarioAlertas_idAlertas") = DBNull.Value

            ' Limpiar memoria
            PB = Nothing
            'Me.RequeryData()
            Me.UpdateData()
        End If

    End Sub



    Private Sub btnRecoh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecoh.Click
        If GridReconocimiento.Visible = False Then
            GridReconocimiento.Visible = True
        Else
            GridReconocimiento.Visible = False
        End If
    End Sub

    Private Sub btnAccidentesH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccidentesH.Click
        If GridAccidentes.Visible = False Then
            GridAccidentes.Visible = True
        Else
            GridAccidentes.Visible = False
        End If
    End Sub

    Private Sub btnNotificacionesN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNotificacionesN.Click
        If GridNotificacion.Visible = False Then
            GridNotificacion.Visible = True
        Else
            GridNotificacion.Visible = False
        End If
    End Sub

    Private Sub btnBajasH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBajasH.Click
        If GridBajas.Visible = False Then
            GridBajas.Visible = True
        Else
            GridBajas.Visible = False
        End If
    End Sub

    Private Sub GridReconocimiento_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridReconocimiento.RowDoubleClick
        CargahReconocimiento(GridReconocimiento.GetValue("IDReconocimiento"))
        GridReconocimiento.CurrentRow.Delete()

    End Sub

    Private Sub GridFInterna_hist_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridFInterna_hist.RowDoubleClick
        CargahFormacion(GridFInterna_hist.GetValue("idFormacion"), "I")
    End Sub

    Private Sub GridFExterna_hist_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridFExterna_hist.RowDoubleClick
        CargahFormacion(GridFInterna_hist.GetValue("idFormacion"), "E")
    End Sub

    Private Sub GridFormacion20_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridFormacion20.RowDoubleClick
        CargahFormacion(GridFormacion20.GetValue("idFormacion"), "20")
    End Sub

    Private Sub GridFormacion50_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridFormacion50.RowDoubleClick
        CargahFormacion(GridFormacion50.GetValue("idFormacion"), "50")
    End Sub

    Private Sub GridEpis_hist_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridEpis_hist.RowDoubleClick
        CargahEPI(GridEpis_hist.GetValue("idEpis"))
    End Sub

    Private Sub GridAccidentes_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridAccidentes.RowDoubleClick
        'Actualizo la tbOperarioAccidentes para que no haya bloqueo de concurrencia.
        Dim pa As New Business.Prevencion.PrevencionAccidentes
        Dim nDiasBaja As Object = If(IsDBNull(GridAccidentes.GetValue("nDiasBaja")), DBNull.Value, GridAccidentes.GetValue("nDiasBaja"))
        Dim idAccidente As String = If(IsDBNull(GridAccidentes.GetValue("idAccidente")), "", GridAccidentes.GetValue("idAccidente"))

        pa.ActualizaInfo(nDiasBaja, idAccidente)

        CargahAccidentes(idAccidente)
        GridAccidentes.CurrentRow.Delete()
    End Sub

    Private Sub GridNotificacion_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridNotificacion.RowDoubleClick
        CargahNotif(GridNotificacion.GetValue("idnotificacion"))
        GridNotificacion.CurrentRow.Delete()
    End Sub

    Private Sub GridBajas_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridBajas.RowDoubleClick
        Dim pa As New Business.Prevencion.PrevencionAlertas
        pa.ActualizaInfo(GridBajas.GetValue("nDias"), GridBajas.GetValue("idAlertas"))

        CargahBajas(GridBajas.GetValue("idAlertas"), GridBajas.GetValue("nDias"))
        GridBajas.CurrentRow.Delete()
    End Sub

    Private Sub CalculadiasAct()
        Try
            Dim dfCalculo As Date
            If IsDate(ClB_Accidentes_Fbaja.Text) Then
                If IsDate(clbtbOperarioAccidentes_falta.Text) Then
                    dfCalculo = clbtbOperarioAccidentes_falta.Text
                Else
                    dfCalculo = Today
                End If
                sle_Accidentes_Dias.Text = DateDiff(DateInterval.Day, CDate(ClB_Accidentes_Fbaja.Text), dfCalculo)
            Else
                sle_Accidentes_Dias.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FiltroDependientes(ByRef Gridobj As Solmicro.Expertis.Engine.UI.Grid, ByVal idCruce As Integer, ByVal scolumna As String)
        Try
            ' Filtrar grid dependientes
            Dim filtro As New Filter
            filtro.Add(scolumna, FilterOperator.Equal, idCruce)
            Gridobj.ReQuery(filtro)
            filtro = Nothing
            Me.RefreshData()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CargahReconocimiento(ByVal pIDReconocimiento As Integer)
        Try
            'MsgBox(Me.CurrentRow("tbOperarioReconocimiento_idReconocimiento") & " registro histórico " & pIDReconocimiento)
            Dim dt As DataTable
            Dim op As New PrevencionReconocimiento
            Dim f As New Filter

            f.Add("idReconocimiento", pIDReconocimiento)

            dt = op.Filter(f)
            dt.TableName = "tbOperarioReconocimiento"
            If IsNothing(dt) Or dt.Rows.Count = 0 Then
                MsgBox("No se ha podido cargar el código de reconocimiento Nº " & pIDReconocimiento)
            Else
                Me.LastRetriveData.Tables(0).Rows(0)("tbOperarioReconocimiento_idReconocimiento") = dt.Rows(0)("idReconocimiento")
                Me.LastRetriveData.Tables(0).Rows(0)("tbOperarioReconocimiento_Lugar") = dt.Rows(0)("Lugar")
                Me.LastRetriveData.Tables(0).Rows(0)("tbOperarioReconocimiento_snApto") = dt.Rows(0)("snApto")
                Me.LastRetriveData.Tables(0).Rows(0)("tbOperarioReconocimiento_Fecha") = dt.Rows(0)("Fecha")
                Me.LastRetriveData.Tables(0).Rows(0)("tbOperarioReconocimiento_snLimitacion") = dt.Rows(0)("snLimitacion")
                Me.LastRetriveData.Tables(0).Rows(0)("tbOperarioReconocimiento_DesLimitacion") = dt.Rows(0)("DesLimitacion")
                Me.LastRetriveData.Tables(0).Rows(0)("tbOperarioReconocimiento_snSensible") = dt.Rows(0)("snSensible")
                Me.LastRetriveData.Tables(0).Rows(0)("tbOperarioReconocimiento_DesSensible") = dt.Rows(0)("DesSensible")
                Me.LastRetriveData.Tables(0).Rows(0)("tbOperarioReconocimiento_snAvisoPrevio") = dt.Rows(0)("snAvisoPrevio")
                Me.LastRetriveData.Tables(0).Rows(0)("tbOperarioReconocimiento_nDiasAviso") = dt.Rows(0)("nDiasAviso")
                ' Cargar filtros de grid dependientes
                ''Reunión 11/06/2012. Correos por trabajador.
                ''FiltroDependientes(GridCorreoReconocimiento, Me.LastRetriveData.Tables(0).Rows(0)("tbOperarioReconocimiento_idReconocimiento"), "idCruce")
                FiltroDependientes(GridPuestos, Me.LastRetriveData.Tables(0).Rows(0)("tbOperarioReconocimiento_idReconocimiento"), "idReconocimiento")
                ' Actualizar los datos de ventana con los datos de la fila
                Me.RefreshData()
                If (dt.Rows(0)("snApto") = "1") Then
                    RB_Reconocimiento_no.Checked = True
                ElseIf (dt.Rows(0)("snApto") = "2") Then
                    RB_Reconocimiento_ap.Checked = True
                ElseIf (dt.Rows(0)("snApto") = "3") Then
                    RB_Reconocimiento_Apto.Checked = True

                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CargahFormacion(ByVal pidFormacion As Integer, ByVal stipo As String)
        Try
            Dim dt As DataTable
            Dim op As New PrevencionFormacion
            Dim f As New Filter

            f.Add("idFormacion", pidFormacion)

            dt = op.Filter(f)
            dt.TableName = "tbOperarioFormacion"
            If IsNothing(dt) Or dt.Rows.Count = 0 Then
                MsgBox("No se ha podido cargar el código de formación Nº " & pidFormacion)
            Else
                Me.LastRetriveData.Tables(0).Rows(0)("vFrmPrevencionFormacion" & stipo & "_idFormacion") = dt.Rows(0)("idFormacion")
                Select Case stipo
                    Case "I"
                        Me.LastRetriveData.Tables(0).Rows(0)("vFrmPrevencionFormacionI_DescClaseFormacion") = dt.Rows(0)("DescClaseFormacion")
                        Me.LastRetriveData.Tables(0).Rows(0)("vFrmPrevencionFormacionI_DesFormacion") = dt.Rows(0)("DesFormacion")
                        Me.LastRetriveData.Tables(0).Rows(0)("vFrmPrevencionFormacionI_Horas") = dt.Rows(0)("Horas")
                        Me.LastRetriveData.Tables(0).Rows(0)("vFrmPrevencionFormacionI_Fecha") = dt.Rows(0)("Fecha")
                        Me.LastRetriveData.Tables(0).Rows(0)("vFrmPrevencionFormacionI_snPuesto") = dt.Rows(0)("snPuesto")
                        Me.LastRetriveData.Tables(0).Rows(0)("vFrmPrevencionFormacionI_snEspecifica") = dt.Rows(0)("snEspecifica")
                    Case "E"
                        Me.LastRetriveData.Tables(0).Rows(0)("vFrmPrevencionFormacionE_DescClaseFormacion") = dt.Rows(0)("DescClaseFormacion")
                        Me.LastRetriveData.Tables(0).Rows(0)("vFrmPrevencionFormacionE_DesFormacion") = dt.Rows(0)("DesFormacion")
                        Me.LastRetriveData.Tables(0).Rows(0)("vFrmPrevencionFormacionE_Horas") = dt.Rows(0)("Horas")
                        Me.LastRetriveData.Tables(0).Rows(0)("vFrmPrevencionFormacionE_Fecha") = dt.Rows(0)("Fecha")
                    Case "20"
                        Me.LastRetriveData.Tables(0).Rows(0)("vFrmPrevencionFormacion20_DescClaseFormacion") = dt.Rows(0)("DescClaseFormacion")
                        Me.LastRetriveData.Tables(0).Rows(0)("vFrmPrevencionFormacion20_horas") = dt.Rows(0)("horas")
                        Me.LastRetriveData.Tables(0).Rows(0)("vFrmPrevencionFormacion20_Lugar") = dt.Rows(0)("Lugar")
                        Me.LastRetriveData.Tables(0).Rows(0)("vFrmPrevencionFormacion20_fecha") = dt.Rows(0)("fecha")
                        Me.LastRetriveData.Tables(0).Rows(0)("vFrmPrevencionFormacion20_empresaforma") = dt.Rows(0)("empresaforma")
                    Case "50"
                        Me.LastRetriveData.Tables(0).Rows(0)("vFrmPrevencionFormacion50_DescClaseFormacion") = dt.Rows(0)("DescClaseFormacion")
                        Me.LastRetriveData.Tables(0).Rows(0)("vFrmPrevencionFormacion50_Lugar") = dt.Rows(0)("Lugar")
                        Me.LastRetriveData.Tables(0).Rows(0)("vFrmPrevencionFormacion50_fecha") = dt.Rows(0)("fecha")
                        Me.LastRetriveData.Tables(0).Rows(0)("vFrmPrevencionFormacion50_empresaforma") = dt.Rows(0)("empresaforma")
                End Select
                ' Actualizar los datos de ventana con los datos de la fila
                Me.RefreshData()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub CargahEPI(ByVal pidEpi As Integer)
        Try
            Dim dt As DataTable
            Dim op As New PrevencionEpis
            Dim f As New Filter

            f.Add("idEpis", pidEpi)

            dt = op.Filter(f)
            dt.TableName = "tbOperarioEpis"
            If IsNothing(dt) Or dt.Rows.Count = 0 Then
                MsgBox("No se ha podido cargar el código de EPI Nº " & pidEpi)
            Else
                Me.LastRetriveData.Tables(0).Rows(0)("tbOperarioEpis_idEpis") = dt.Rows(0)("idEpis")
                Me.LastRetriveData.Tables(0).Rows(0)("tbOperarioEpis_fecha") = dt.Rows(0)("fecha")
                Me.LastRetriveData.Tables(0).Rows(0)("tbOperarioEpis_DesEpis") = dt.Rows(0)("DesEpis")
                Me.LastRetriveData.Tables(0).Rows(0)("tbOperarioEpis_DesAdicional") = dt.Rows(0)("DesAdicional")
                ' Actualizar los datos de ventana con los datos de la fila
                Me.RefreshData()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub CargahAccidentes(ByVal pidAcc As String)
        Try
            Dim pidAccidente As Integer
            'Dim nDiasBaja As Integer
            ', ByVal nDias As String)

            If Integer.TryParse(pidAcc, pidAccidente) Then
            Else
                pidAccidente = 0
            End If

            Dim dt As DataTable
            Dim op As New PrevencionAccidentes
            Dim f As New Filter

            f.Add("idAccidente", pidAccidente)

            dt = op.Filter(f)
            'dt.TableName = "tbOperarioEpis"
            dt.TableName = "tbOperarioAccidentes"
            If IsNothing(dt) Or dt.Rows.Count = 0 Then
                MsgBox("No se ha podido cargar el código de accidente Nº " & pidAccidente)
            Else
                Me.LastRetriveData.Tables(0).Rows(0)("tbOperarioAccidentes_idAccidente") = dt.Rows(0)("idAccidente")

                Me.LastRetriveData.Tables(0).Rows(0)("tbOperarioAccidentes_faccidente") = dt.Rows(0)("faccidente")
                Me.LastRetriveData.Tables(0).Rows(0)("tbOperarioAccidentes_fbaja") = dt.Rows(0)("fbaja")
                If (dt.Rows(0)("falta").ToString.Length = 0) Then
                    'Me.LastRetriveData.Tables(0).Rows(0)("tbOperarioAccidentes_falta") = Today
                Else
                    Me.LastRetriveData.Tables(0).Rows(0)("tbOperarioAccidentes_falta") = dt.Rows(0)("falta")
                    Me.LastRetriveData.Tables(0).Rows(0)("tbOperarioAccidentes_nDiasBaja") = dt.Rows(0)("nDiasBaja")
                End If


                Me.LastRetriveData.Tables(0).Rows(0)("tbOperarioAccidentes_fNotificacion") = dt.Rows(0)("fNotificacion")
                Me.LastRetriveData.Tables(0).Rows(0)("tbOperarioAccidentes_tipo") = dt.Rows(0)("tipo")
                Me.LastRetriveData.Tables(0).Rows(0)("tbOperarioAccidentes_snrecaida") = dt.Rows(0)("snrecaida")
                Me.LastRetriveData.Tables(0).Rows(0)("tbOperarioAccidentes_Lugar") = dt.Rows(0)("Lugar")
                Me.LastRetriveData.Tables(0).Rows(0)("tbOperarioAccidentes_sninvestigaciono") = dt.Rows(0)("sninvestigaciono")
                Me.LastRetriveData.Tables(0).Rows(0)("tbOperarioAccidentes_sninvestigacionpre") = dt.Rows(0)("sninvestigacionpre")
                Me.LastRetriveData.Tables(0).Rows(0)("tbOperarioAccidentes_descripcioninves") = dt.Rows(0)("descripcioninves")
                Me.LastRetriveData.Tables(0).Rows(0)("tbOperarioAccidentes_snseguimiento") = dt.Rows(0)("snseguimiento")
                Me.LastRetriveData.Tables(0).Rows(0)("tbOperarioAccidentes_desSeguimiento") = dt.Rows(0)("desSeguimiento")
                Me.LastRetriveData.Tables(0).Rows(0)("tbOperarioAccidentes_fechaseg") = dt.Rows(0)("fechaseg")
                Me.LastRetriveData.Tables(0).Rows(0)("tbOperarioAccidentes_encargado") = dt.Rows(0)("encargado")
                Me.LastRetriveData.Tables(0).Rows(0)("tbOperarioAccidentes_JefeProd") = dt.Rows(0)("JefeProd")
                Me.LastRetriveData.Tables(0).Rows(0)("tbOperarioAccidentes_codobra") = dt.Rows(0)("codobra")

                'Me.LastRetriveData.Tables(0).Rows(0)("tbOperarioAccidentes_obra") = dt.Rows(0)("obra")
                ''Reunión 11/06/2012. Correos por trabajador.
                ''FiltroDependientes(GridCorreoAcc, Me.LastRetriveData.Tables(0).Rows(0)("tbOperarioAccidentes_idAccidente"), "idcruce")
                ' Actualizar los datos de ventana con los datos de la fila
                CalculadiasAct()
                'sle_Accidentes_Dias.Text = nDiasBaja
                Me.RefreshData()
                Try
                    Ul_Accidentes_obra.Text = dt.Rows(0)("obra")
                Catch ex As Exception

                End Try


                If (dt.Rows(0)("tipo") = "1") Then
                    RB_Accidentes_leve.Checked = True
                ElseIf (dt.Rows(0)("tipo") = "2") Then
                    RB_Accidentes_Grave.Checked = True
                ElseIf (dt.Rows(0)("tipo") = "3") Then
                    rbttbOperarioAccidentes_tipo2.Checked = True
                ElseIf (dt.Rows(0)("tipo") = "4") Then
                    RB_Accidentes_SinBaja.Checked = True
                Else

                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CargahNotif(ByVal pidNotificacion As Integer)
        Try
            Dim dt As DataTable
            Dim op As New PrevencionNotificacion
            Dim f As New Filter

            f.Add("idNotificacion", pidNotificacion)

            dt = op.Filter(f)
            dt.TableName = "tbOperarioNotificacion"
            If IsNothing(dt) Or dt.Rows.Count = 0 Then
                MsgBox("No se ha podido cargar el código de notificación Nº " & pidNotificacion)
            Else
                Me.LastRetriveData.Tables(0).Rows(0)("tbOperarioNotificacion_idnotificacion") = dt.Rows(0)("idnotificacion")

                Me.LastRetriveData.Tables(0).Rows(0)("tbOperarioNotificacion_fechaSeguimiento") = dt.Rows(0)("fechaSeguimiento")
                Me.LastRetriveData.Tables(0).Rows(0)("tbOperarioNotificacion_idobra") = dt.Rows(0)("idobra")
                Me.LastRetriveData.Tables(0).Rows(0)("tbOperarioNotificacion_tipo") = dt.Rows(0)("tipo")
                Me.LastRetriveData.Tables(0).Rows(0)("tbOperarioNotificacion_gravedad") = dt.Rows(0)("gravedad")
                Me.LastRetriveData.Tables(0).Rows(0)("tbOperarioNotificacion_snRecibida") = dt.Rows(0)("snRecibida")
                Me.LastRetriveData.Tables(0).Rows(0)("tbOperarioNotificacion_encargado") = dt.Rows(0)("encargado")
                Me.LastRetriveData.Tables(0).Rows(0)("tbOperarioNotificacion_JefeProd") = dt.Rows(0)("JefeProd")
                Me.LastRetriveData.Tables(0).Rows(0)("tbOperarioNotificacion_DescSancion") = dt.Rows(0)("DescSancion")
                Me.LastRetriveData.Tables(0).Rows(0)("tbOperarioNotificacion_Observaciones") = dt.Rows(0)("Observaciones")

                ' Actualizar los datos de ventana con los datos de la fila

                Me.RefreshData()
                If (dt.Rows(0)("gravedad") = "1") Then
                    RB_Notificaciones_leve.Checked = True
                ElseIf (dt.Rows(0)("gravedad") = "2") Then
                    RB_Notificaciones_Grave.Checked = True
                ElseIf (dt.Rows(0)("gravedad") = "3") Then
                    RB_Notificaciones_MuyGrave.Checked = True
                Else

                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CargahBajas(ByVal pidAlertas As Integer, ByVal nDias As Integer)
        Try
            Dim dt As DataTable
            Dim op As New PrevencionAlertas
            Dim f As New Filter

            f.Add("idAlertas", pidAlertas)

            dt = op.Filter(f)
            dt.TableName = "tbOperarioEpis"
            If IsNothing(dt) Or dt.Rows.Count = 0 Then
                MsgBox("No se ha podido cargar el código de baja Nº " & pidAlertas)
            Else
                Me.LastRetriveData.Tables(0).Rows(0)("tbOperarioAlertas_idAlertas") = dt.Rows(0)("idAlertas")
                Me.LastRetriveData.Tables(0).Rows(0)("tbOperarioAlertas_fBaja") = dt.Rows(0)("fBaja")
                Me.LastRetriveData.Tables(0).Rows(0)("tbOperarioAlertas_fAlta") = dt.Rows(0)("fAlta")
                Me.LastRetriveData.Tables(0).Rows(0)("tbOperarioAlertas_nDias") = dt.Rows(0)("nDias")
                Me.LastRetriveData.Tables(0).Rows(0)("tbOperarioAlertas_fConf") = dt.Rows(0)("fConf")
                Me.LastRetriveData.Tables(0).Rows(0)("tbOperarioAlertas_lugar") = dt.Rows(0)("lugar")
                Me.LastRetriveData.Tables(0).Rows(0)("tbOperarioAlertas_snotrosPaises") = dt.Rows(0)("snotrosPaises")
                Me.LastRetriveData.Tables(0).Rows(0)("tbOperarioAlertas_fEmail") = dt.Rows(0)("fEmail")
                Me.LastRetriveData.Tables(0).Rows(0)("tbOperarioAlertas_seguimiento") = dt.Rows(0)("seguimiento")
                Me.LastRetriveData.Tables(0).Rows(0)("tbOperarioAlertas_descripcion") = dt.Rows(0)("descripcion")
                Me.LastRetriveData.Tables(0).Rows(0)("tbOperarioAlertas_encargado") = dt.Rows(0)("encargado")

                sle_Bajas_Dias.Text = nDias
                ' Actualizar los datos de ventana con los datos de la fila
                ''Reunión 11/06/2012. Correos por trabajador.
                '' FiltroDependientes(GridCorreoBajas, Me.LastRetriveData.Tables(0).Rows(0)("tbOperarioAlertas_idAlertas"), "idcruce")
                Me.RefreshData()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

#Region "CargaHistoricoForm"

    Private Sub ActivarUltimoHistorico()
        Try
            'Reconocimiento
            If IsDBNull(Me.CurrentRow("tbOperarioReconocimiento_idReconocimiento")) And GridReconocimiento.RowCount > 0 Then
                CargahReconocimiento(Dameultimoid(GridReconocimiento, New PrevencionReconocimiento, "tbOperarioReconocimiento_idReconocimiento"))
            End If
            'Formacion I,E,20,50
            If IsDBNull(Me.CurrentRow("vFrmPrevencionFormacionI_idFormacion")) And GridFInterna_hist.RowCount > 0 Then
                CargahFormacion(Dameultimoid(GridFInterna_hist, New PrevencionFormacion, "vFrmPrevencionFormacionI_idFormacion"), "I")
            End If
            If IsDBNull(Me.CurrentRow("vFrmPrevencionFormacionE_idFormacion")) And GridFExterna_hist.RowCount > 0 Then
                CargahFormacion(Dameultimoid(GridFExterna_hist, New PrevencionFormacion, "vFrmPrevencionFormacionE_idFormacion"), "E")
            End If
            If IsDBNull(Me.CurrentRow("vFrmPrevencionFormacion20_idFormacion")) And GridFormacion20.RowCount > 0 Then
                CargahFormacion(Dameultimoid(GridFormacion20, New PrevencionFormacion, "vFrmPrevencionFormacion20_idFormacion"), "20")
            End If
            If IsDBNull(Me.CurrentRow("vFrmPrevencionFormacion50_idFormacion")) And GridFormacion50.RowCount > 0 Then
                CargahFormacion(Dameultimoid(GridFormacion50, New PrevencionFormacion, "vFrmPrevencionFormacion50_idFormacion"), "50")
            End If
            'Epi
            If IsDBNull(Me.CurrentRow("tbOperarioEpis_idEpis")) And GridEpis_hist.RowCount > 0 Then
                CargahReconocimiento(Dameultimoid(GridEpis_hist, New PrevencionEpis, "tbOperarioEpis_idEpis"))
            End If
            'Accidente
            If IsDBNull(Me.CurrentRow("tbOperarioAccidentes_idAccidente")) And GridAccidentes.RowCount > 0 Then
                CargahReconocimiento(Dameultimoid(GridAccidentes, New PrevencionAccidentes, "tbOperarioAccidentes_idAccidente"))
            End If
            'Notif
            If IsDBNull(Me.CurrentRow("tbOperarioNotificacion_idnotificacion")) And GridNotificacion.RowCount > 0 Then
                CargahReconocimiento(Dameultimoid(GridNotificacion, New PrevencionNotificacion, "tbOperarioNotificacion_idnotificacion"))
            End If
            'Bajas
            If IsDBNull(Me.CurrentRow("tbOperarioAlertas_idAlertas")) And GridBajas.RowCount > 0 Then
                CargahReconocimiento(Dameultimoid(GridBajas, New PrevencionAlertas, "tbOperarioAlertas_idAlertas"))
            End If
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub

    Private Function Dameultimoid(ByVal objGrid As Solmicro.Expertis.Engine.UI.Grid, ByVal prevencionBusiness As Object, ByVal Nombreid As String) As Integer
        ' Se encarga de dar el último id del histórico
        Dim sSql As String
        sSql = "select max(" & Nombreid & ") from " & objGrid.ViewName
        Dim dt As DataTable
        dt = prevencionBusiness.Filter(sSql, , objGrid.ViewName & " = " & Me.CurrentRow("idOpeario"), , False).DataTable
        Return dt.Rows(0)(0)
    End Function

#End Region


    'Private Sub clbtbOperarioAccidentes_falta_Change(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clbtbOperarioAccidentes_falta.Change
    '    Try
    '        sle_Accidentes_Dias.Text = DateDiff(DateInterval.Day, ClB_Accidentes_Fbaja.Value, clbtbOperarioAccidentes_falta.Value)
    '    Catch ex As Exception

    '    End Try

    'End Sub

    Private Sub clbtbOperarioAccidentes_falta_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clbtbOperarioAccidentes_falta.Validated
        Try
            sle_Accidentes_Dias.Text = DateDiff(DateInterval.Day, ClB_Accidentes_Fbaja.Value, clbtbOperarioAccidentes_falta.Value)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GridAccidentes_DeletingRecords(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles GridAccidentes.DeletingRecords
        Dim pa As New Business.Prevencion.PrevencionAccidentes
        Dim nDiasBaja As Object = If(IsDBNull(GridAccidentes.GetValue("nDiasBaja")), DBNull.Value, GridAccidentes.GetValue("nDiasBaja"))
        Dim idAccidente As String = If(IsDBNull(GridAccidentes.GetValue("idAccidente")), "", GridAccidentes.GetValue("idAccidente"))

        pa.ActualizaInfo(nDiasBaja, idAccidente)
    End Sub

    Private Sub MntoPrevencionOperario_Navigated(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.NavigatedEventArgs) Handles MyBase.Navigated
        '---DATOS DEL PERSONAL
        Dim operario As String
        operario = Me.CurrentRow("IDOperario")

        Dim dt As New DataTable
        Dim filtro As New Filter
        filtro.Add("idoperario", FilterOperator.Equal, operario)
        dt = New BE.DataEngine().Filter("tbMaestroOperarioSat", filtro)
        txtLugarReconocimiento.Text = dt.Rows(0)("Lugar").ToString
        clbFechaReconocimiento.Text = dt.Rows(0)("Fecha_Reconocimiento").ToString
    End Sub

    Private Sub GridBajas_DeletingRecords(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles GridBajas.DeletingRecords
        Dim pa As New Business.Prevencion.PrevencionAlertas
        pa.ActualizaInfo(GridBajas.GetValue("nDias"), GridBajas.GetValue("idAlertas"))
    End Sub
End Class
