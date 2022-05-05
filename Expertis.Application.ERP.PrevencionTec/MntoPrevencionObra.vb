Imports Solmicro.Expertis.Engine
Imports Solmicro.Expertis.Engine.UI
Imports Expertis.Business.Prevencion
Imports Solmicro.Expertis
Imports Solmicro.Expertis.Business.Negocio

Public Class MntoPrevencionObra

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        EnlaceDatos()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

#Region " Código acceso a datos "
    Private Sub EnlaceDatos()
        Try
            EnlaceCabecera()
            EnlaceVisitas()
            EnlaceObra()
            EnlaceRec()
            EnlaceInfor()
            EnlaceDoc()
        Catch ex As Exception
            MsgBox("Error en enlace a datos : " & ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub EnlaceCabecera()
        ' Enlace datos de cabecera
        Me.TryDataBinding(Me.txtNObra, New System.Windows.Forms.Binding("Text", Me, "NObra"))
        Me.TryDataBinding(Me.txtDescObra, New System.Windows.Forms.Binding("Text", Me, "DescObra"))
        Me.TryDataBinding(Me.txtUbicacionPrev, New System.Windows.Forms.Binding("Text", Me, "UbicacionPrev"))
        Me.TryDataBinding(Me.txtContratistaPrev, New System.Windows.Forms.Binding("Text", Me, "ContratistaPrev"))
        Me.TryDataBinding(Me.clbFechaInicio, New System.Windows.Forms.Binding("BindableValue", Me, "FechaInicio"))
        Me.TryDataBinding(Me.clbFFinPrev, New System.Windows.Forms.Binding("BindableValue", Me, "FFinPrev"))
        Me.TryDataBinding(Me.txtDirObraPrev, New System.Windows.Forms.Binding("Text", Me, "DirObraPrev"))
        Me.TryDataBinding(Me.chbEstado, New System.Windows.Forms.Binding("BindableValue", Me, "estadoPrev"))
        Me.TryDataBinding(Me.txtObservacionesPrev, New System.Windows.Forms.Binding("Text", Me, "ObservacionesPrev"))
    End Sub

    Private Sub EnlaceVisitas()
        ' Conexión con datos de visitas actuales
        Dim Visita As New PrevencionObraVisitas
        ' Me.TryDataBinding(Me.txtNvisita, New System.Windows.Forms.Binding("Text", Me, "tbObraPrevVisitas.nvisita"))
        Me.TryDataBinding(Me.txtNvisita, New System.Windows.Forms.Binding("Text", GridVisitas.EntityName, "nvisitas"))
        Me.TryDataBinding(Me.cbxfechaVisita, New System.Windows.Forms.Binding("BindableValue", GridVisitas.EntityName, "fecha"))
        ' Me.TryDataBinding(Me.cboTecnico, New System.Windows.Forms.Binding("Text", Me, "tbObraPrevVisitas.Tecnico"))
        Me.TryDataBinding(Me.cboTecnico, New System.Windows.Forms.Binding("Text", GridVisitas.EntityName, "Tecnico"))
        Me.TryDataBinding(Me.cboComunicado, New System.Windows.Forms.Binding("Text", GridVisitas.EntityName, "Comunicado"))
        Me.TryDataBinding(Me.txtObservacionesVisitas, New System.Windows.Forms.Binding("Text", GridVisitas.EntityName, "Observaciones"))
    End Sub

    Private Sub EnlaceObra()
        Me.TryDataBinding(Me.cboDireccionJ, New System.Windows.Forms.Binding("Text", Me, "vFrmPrevObraDireccionj_Nombre"))
        Me.TryDataBinding(Me.cbxFiniJ, New System.Windows.Forms.Binding("BindableValue", Me, "vFrmPrevObraDireccionj_FInicio"))
        Me.TryDataBinding(Me.cbxFfinJ, New System.Windows.Forms.Binding("BindableValue", Me, "vFrmPrevObraDireccionj_FFin"))
        Me.TryDataBinding(Me.cboDireccionE, New System.Windows.Forms.Binding("Text", Me, "vFrmPrevObraDireccione_Nombre"))
        Me.TryDataBinding(Me.cbxFiniE, New System.Windows.Forms.Binding("BindableValue", Me, "vFrmPrevObraDireccione_FInicio"))
        Me.TryDataBinding(Me.cbxFfinE, New System.Windows.Forms.Binding("BindableValue", Me, "vFrmPrevObraDireccione_FFin"))
    End Sub

    Private Sub EnlaceRec()
        Me.TryDataBinding(Me.txtRec, New System.Windows.Forms.Binding("Text", Me, "tbObraPrevRec_RecPreventivo"))
        Me.TryDataBinding(Me.cbxfiniRec, New System.Windows.Forms.Binding("BindableValue", Me, "tbObraPrevRec_fInicio"))
        Me.TryDataBinding(Me.cbxffinRec, New System.Windows.Forms.Binding("BindableValue", Me, "tbObraPrevRec_fFin"))
        Me.TryDataBinding(Me.AdvS_Rec_Codigo, New System.Windows.Forms.Binding("Text", Me, "tbObraPrevRec_idOperario"))
        Me.TryDataBinding(Me.Ul_Operario, New System.Windows.Forms.Binding("text", Me.AdvS_Rec_Codigo, "DescOperario"))
    End Sub

    Private Sub EnlaceInfor()
        Me.TryDataBinding(Me.txtNombreInfor, New System.Windows.Forms.Binding("Text", Me, "tbObraPrevInfor_Nombre"))
        Me.TryDataBinding(Me.cboPuestoI, New System.Windows.Forms.Binding("Text", Me, "tbObraPrevInfor_Puesto"))
        Me.TryDataBinding(Me.txtTelefonoInfor, New System.Windows.Forms.Binding("Text", Me, "tbObraPrevInfor_Telefono"))
        Me.TryDataBinding(Me.txtMailInfor, New System.Windows.Forms.Binding("Text", Me, "tbObraPrevInfor_Mail"))
        Me.TryDataBinding(Me.txtObservacionesInfor, New System.Windows.Forms.Binding("Text", Me, "tbObraPrevInfor_Observaciones"))
    End Sub

    Private Sub EnlaceDoc()
        Me.TryDataBinding(Me.cbxFechaDoc, New System.Windows.Forms.Binding("BindableValue", Me, "tbObraPrevDoc_Fecha"))
        Me.TryDataBinding(Me.txtSolicitante, New System.Windows.Forms.Binding("Text", Me, "tbObraPrevDoc_Solicitante"))
        Me.TryDataBinding(Me.txtSolicita, New System.Windows.Forms.Binding("Text", Me, "tbObraPrevDoc_Solicita"))
        Me.TryDataBinding(Me.cboEnvio, New System.Windows.Forms.Binding("Text", Me, "tbObraPrevDoc_ModEnvio"))
        Me.TryDataBinding(Me.TxtObservaDoc, New System.Windows.Forms.Binding("Text", Me, "tbObraPrevDoc_Observaciones"))
    End Sub

#End Region

#Region "Combos"

    Dim DE As New Solmicro.Expertis.Engine.BE.DataEngine

    Private Sub CargarCombos()
        CargarEncargaJefeTec()
        CargarComunicado()
        'CargarListaDoc()
        CargarPuestoEnvio()
    End Sub

    Private Sub CargarEncargaJefeTec()
        Try
            Dim Strsql As String
            Strsql = "SELECT Nombre,cTipo FROM tbOperarioEncargaJefe"
            Dim FiltroTec As New Filter
            FiltroTec.Add("ctipo", "T")

            Dim FiltroEnc As New Filter
            FiltroEnc.Add("ctipo", "E")

            Dim FiltroJP As New Filter
            FiltroEnc.Add("ctipo", "J")


            ' Cargar Tecnicos
            'cboTecnico.DataSource = AdminData.Filter(Strsql, , "cTipo = 'T'", "Nombre", False).DataTable
            cboTecnico.DataSource = DE.Filter("tbOperarioEncargaJefe", FiltroTec, "Nombre", "Nombre", False)
            'cboTecnico.DataSource = DE.Filter("tbOperarioEncargaJefe", "Nombre,cTipo", "cTipo = 'T'")
            cboTecnico.DisplayMember = cboTecnico.DataSource.Columns("Nombre").Caption.ToString
            cboTecnico.ValueMember = cboTecnico.DisplayMember
            cboTecnico.DataSource = cboTecnico.DataSource
            ' Cargar Encargados

            'cboDireccionE.DataSource = AdminData.Filter(Strsql, , "cTipo = 'E'", "Nombre", False).DataTable
            Dim dt2 As New DataTable
            Dim filtro2 As New Filter

            filtro2.Add("cTipo", FilterOperator.Equal, "E")

            cboDireccionE.DataSource = DE.Filter("tbOperarioEncargaJefe", filtro2, "Nombre", "Nombre", False)
            cboDireccionE.DisplayMember = cboDireccionE.DataSource.Columns("Nombre").Caption.ToString
            cboDireccionE.ValueMember = cboDireccionE.DisplayMember

            'Cargar Jefes
            Dim dt As New DataTable
            Dim filtro As New Filter

            filtro.Add("cTipo", FilterOperator.Equal, "J")
            'dt = New BE.DataEngine().Filter("tbOperarioEncargaJefe", filtro)

            cboDireccionJ.DataSource = DE.Filter("tbOperarioEncargaJefe", filtro, "Nombre", "Nombre", False)
            cboDireccionJ.DisplayMember = cboDireccionJ.DataSource.Columns("Nombre").Caption.ToString
            cboDireccionJ.ValueMember = cboDireccionJ.DisplayMember
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub CargarComunicado()
        Try
            Dim Strsql As String
            Strsql = "SELECT DesComunicado FROM tbObraComunicadoTipo"

            ' Cargar Tecnicos
            cboComunicado.DataSource = DE.RetrieveData("tbObraComunicadoTipo", "desComunicado")
            cboComunicado.DisplayMember = cboComunicado.DataSource.Columns("DesComunicado").Caption.ToString
            cboComunicado.ValueMember = cboComunicado.DisplayMember
            'UICB_Comunicado.DataSource = UICB_Comunicado.DataSource

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub CargarPuestoEnvio()
        Try
            Dim Strsql As String
            Strsql = "SELECT DescPuesto FROM tbObraPuesto"
            ' Cargar Tecnicos

            cboPuestoI.DataSource = DE.RetrieveData("tbObraPuesto", "DescPuesto")
            cboPuestoI.DisplayMember = cboPuestoI.DataSource.Columns("DescPuesto").Caption.ToString
            cboPuestoI.ValueMember = cboPuestoI.DisplayMember
            'UiCB_PuestoI.DataSource = UiCB_PuestoI.DataSource

            Strsql = "SELECT DescEnvio FROM tbObraEnvioTipo"
            cboEnvio.DataSource = DE.RetrieveData("tbObraEnvioTipo", "DescEnvio")
            'cboEnvio.DataSource = AdminData.Filter(Strsql, , , "DescEnvio", False).DataTable
            cboEnvio.DisplayMember = cboEnvio.DataSource.Columns("DescEnvio").Caption.ToString
            cboEnvio.ValueMember = cboEnvio.DisplayMember
            'UiCB_Envio.DataSource = UiCB_Envio.DataSource

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

#End Region

#Region "Load"


    Private Sub MntoPrevencionObra_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LoadToolBarActions()
        CargarCombos()
        DefFecha()
    End Sub

    Private Sub LoadToolBarActions()
        'ADDLineaToExecuteActions(Me.UiCommandManager1)
        'Me.FormActions.Add("Documentos Relacionados", New ActionProcedure(AddressOf AccionDocumentosRelacionados))
        'Me.FormActions.Add("Vincular Documentos", New ActionProcedure(AddressOf AccionVincularDocumentos))
        'Opciones de menu
        Me.FormActions.Add("Administración de combos", AddressOf AdminCombos)
    End Sub
    Private Sub DefFecha()
        Try
            iup_FiltroMesEObra.Value = DateAdd(DateInterval.Month, -1, Now).Month
            iup_FiltroMesEEmpresa.Value = DateAdd(DateInterval.Month, -1, Now).Month
            iup_FiltroPeriodoEObra.Value = DateAdd(DateInterval.Month, -1, Now).Year
            iup_FiltroPeriodoEEmpresa.Value = DateAdd(DateInterval.Month, -1, Now).Year
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "Eventos Cargar Grid"
    Private bCargarCombos = True
    Private bCalculaDias = False
    Private Sub tabObraPrevencion_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tabObraPrevencion.Click
        Try
            '' Para sólo recorrerlos 1 vez.
            If bCargarCombos Then
                'Combos dirección
                If GridDireccion.Columns("Tipo").EditType = Janus.Windows.GridEX.EditType.TextBox Then
                    GridDireccion.Columns("Tipo").EditType = Janus.Windows.GridEX.EditType.DropDownList
                    CargarListaDireccion()
                    GridDireccion.Refresh()
                End If
                'Combos Doc.
                If GridDoc.Columns("ModEnvio").EditType = Janus.Windows.GridEX.EditType.TextBox Then
                    GridDoc.Columns("ModEnvio").EditType = Janus.Windows.GridEX.EditType.DropDownList
                    CargarListaDoc()
                    GridDoc.Refresh()
                End If
                If GridInfor.Columns("Puesto").EditType = Janus.Windows.GridEX.EditType.TextBox Then
                    GridInfor.Columns("Puesto").EditType = Janus.Windows.GridEX.EditType.DropDownList
                    CargarListaPuestos()
                    GridInfor.Refresh()
                End If
            End If
        Catch ex As Exception
            ExpertisApp.GenerateMessage(ex.Message)
        End Try

    End Sub
#End Region

    Private Sub CargarListaPuestos()
        ' Dim FwConsulta As Aplicacion
        'Dim Strsql As String
        'Dim rcsRdo As DataTable
        Dim jsCol As Janus.Windows.GridEX.GridEXColumn      'JSColumn
        Dim vl As Janus.Windows.GridEX.GridEXValueListItemCollection  ' JSValueList
        'Dim i As Integer
        'Dim n As Integer
        Dim aux As Janus.Windows.GridEX.GridEXValueListItem

        Try
            jsCol = GridInfor.Columns("Puesto")
            jsCol.HasValueList = True

            vl = jsCol.ValueList

            aux = New Janus.Windows.GridEX.GridEXValueListItem
            aux.Value = "Tecnico prevención Obra"
            aux.Text = Nz("Tecnico prevención Obra", "")
            vl.Add(aux)  ', rcsRdo!Estructura

            aux = New Janus.Windows.GridEX.GridEXValueListItem
            aux.Value = "Administrativo"
            aux.Text = Nz("Administrativo", "")
            vl.Add(aux)  ', rcsRdo!Estructura


            aux = New Janus.Windows.GridEX.GridEXValueListItem
            aux.Value = "Jefe de Produccion"
            aux.Text = Nz("Jefe de Produccion", "")
            vl.Add(aux)  ', rcsRdo!Estructura

        Catch ex As Exception
            ExpertisApp.GenerateMessage(ex.Message)
        End Try
    End Sub

#Region "Eventos usuario"
    Private Sub cbxFFinPrev_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles clbFFinPrev.Validated
        If IsDate(clbFFinPrev.Value) Then
            chbEstado.Checked = 1
        Else
            chbEstado.Checked = 0
        End If
    End Sub

    Private Sub btnVisitas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisitas.Click
        NuevaVisita()
    End Sub

    Private Sub GridVisitas_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridVisitas.RowDoubleClick
        Dim idVisita As Integer = GridVisitas.GetValue("IDVisitas")
        Dim rowPosition As Integer = GridVisitas.Row()
        'ExpertisApp.GenerateMessage("El id de la Visita es " & idVisita)
        CargahVisitas(idVisita, rowPosition)
        GridVisitas.CurrentRow.Delete()
    End Sub


    Private Sub btnDir_E_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDir_E.Click

        ' NuevaDir2("E", cboDireccionE.Value, cbxFiniE.Value.ToString, cbxFfinE.Value.ToString)
        NuevaDir3("E")
        cboDireccionE.Value = ""
        cbxFiniE.Value = ""
        cbxFfinE.Value = ""
    End Sub

    Private Sub btnDir_J_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDir_J.Click
        'NuevaDir2("J", cboDireccionJ.Value, cbxFiniJ.Value.ToString, cbxFfinJ.Value.ToString)

        NuevaDir3("J")
        cboDireccionJ.Value = ""
        cbxFiniJ.Value = ""
        cbxFfinJ.Value = ""
        'NuevaDir("J")
    End Sub

    Private Sub GridDireccion_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridDireccion.RowDoubleClick
        CargahDir(GridDireccion.GetValue("idDireccion"))
        GridDireccion.CurrentRow.Delete()
    End Sub

    Private Sub btnRec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRec.Click
        'NuevoRec()
        'NuevoRec2()
        NuevoRec3()

        txtRec.Text = ""
        cbxfiniRec.Text = ""
        cbxffinRec.Text = ""
        AdvS_Rec_Codigo.Clear()
        Ul_Operario.Text = ""
    End Sub

    Private Sub GridRec_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridRec.RowDoubleClick
        CargahRec(GridRec.GetValue("IDRec"))
        GridRec.CurrentRow.Delete()
    End Sub

    Private Sub btnInf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInf.Click
        'NuevaInf2()
        NuevaInf4()
        'Me.Update()

        txtNombreInfor.Text = ""
        cboPuestoI.Text = ""
        txtTelefonoInfor.Text = ""
        txtMailInfor.Text = ""
        txtObservacionesInfor.Text = ""

    End Sub


    Private Sub GridInfor_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridInfor.RowDoubleClick
        CargahInf(GridInfor.GetValue("IdInformacion"))
        GridInfor.CurrentRow.Delete()
    End Sub

    Private Sub btnDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDoc.Click
        'NuevaDoc2()
        NuevaDoc3()
        cbxFechaDoc.Text = ""
        txtSolicitante.Text = ""
        txtSolicita.Text = ""
        cboEnvio.Text = ""
        TxtObservaDoc.Text = ""

    End Sub


    Private Sub GridDoc_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridDoc.RowDoubleClick
        CargahDoc(GridDoc.GetValue("idDocumentacion"))
        GridDoc.CurrentRow.Delete()
    End Sub

#End Region

#Region "Acciones del play"
    Private Sub AdminCombos()
        Dim frm As New MntoAdminCombos
        frm.ShowDialog()
        bCargarCombos = True
        CargarCombos()
        frm = Nothing
    End Sub
#End Region

    Private Sub MntoPrevencionObra_RecordUpdating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.RecordUpdating
        'Try
        ' Actualizar visitas a obra
        '    Dim OV As New PrevencionObraVisitas
        '    'Me.CurrentRow("tbObraPrevVisitas_IDVisitas") = OV.UpdateForm(Me.CurrentRow).Rows(0)("IDVisitas")
        '    OV = Nothing
        '    ' Obra (Dirección)
        '    Dim PD As New PrevencionObraDireccion
        '    Me.CurrentRow("vFrmPrevObraDireccionj_idDireccion") = PD.UpdateForm(Me.CurrentRow, "J").Rows(0)("IDDireccion")
        '    Me.CurrentRow("vFrmPrevObraDireccione_idDireccion") = PD.UpdateForm(Me.CurrentRow, "E").Rows(0)("IDDireccion")
        '    PD = Nothing
        '    ' Actualizar Rec.
        '    Dim PR As New PrevencionObraRec
        '    Me.CurrentRow("tbObraPrevRec_idRec") = PR.UpdateForm(Me.CurrentRow).Rows(0)("IDRec")
        '    PR = Nothing

        '    ' Actualizar Infor.
        '    Dim PI As New PrevencionObraInfor
        '    Me.CurrentRow("tbObraPrevInfor_IdInformacion") = PI.UpdateForm(Me.CurrentRow).Rows(0)("IdInformacion")
        '    PI = Nothing

        '    ' Actualizar Infor.
        '    Dim PDoc As New PrevencionObraDoc
        '    Me.CurrentRow("tbObraPrevDoc_idDocumentacion") = PDoc.UpdateForm(Me.CurrentRow).Rows(0)("idDocumentacion")
        '    PDoc = Nothing

        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub


    Private Sub NuevaVisita()
        ' TabPage Visitas
        If MsgBox("¿Desea guardar al histórico el registro actual y añadir uno nuevo?", MsgBoxStyle.YesNo, "Generar histórico") = MsgBoxResult.Yes Then
            Dim DataVisita As New Business.Prevencion.dataVisita
            DataVisita.nvisita = 1
            DataVisita.fecha = Me.cbxfechaVisita.Value
            DataVisita.Tecnico = Me.cboTecnico.Text
            DataVisita.Comunicado = Me.cboComunicado.Text
            DataVisita.Observaciones = Me.txtObservacionesVisitas.Text
            DataVisita.snHistorico = 1
            DataVisita.idObra = Me.CurrentRow("IDObra")

            Dim OV As New PrevencionObraVisitas
            'Dim DtNVisita As DataTable = OV.AddNew

            ExpertisApp.ExecuteTask(Of dataVisita)(AddressOf PrevencionObraVisitas.GenerarNuevaVisita, DataVisita)

            MsgBox("Se ha insertado una fila correctamente.")
            '.GenerateMessage("Se Ha insertado una nueva Visita")

            'OV.UpdateForm(Me.CurrentRow, 1)
            'Me.CurrentRow("tbObraPrevVisitas_IDVisitas") = DBNull.Value
            '' Limpiar memoria
            OV = Nothing
            'Me.RequeryData()
            Me.txtNvisita.Text = ""
            Me.cbxfechaVisita.Value = ""
            Me.cboTecnico.Text = ""
            cboComunicado.Text = ""
            Me.txtObservacionesVisitas.Text = ""
            Me.UpdateData()

        End If
    End Sub

    Private Sub NuevaInf4()
        ' TabPage Visitas
        If MsgBox("¿Desea guardar al histórico el registro actual y añadir uno nuevo?", MsgBoxStyle.YesNo, "Generar histórico") = MsgBoxResult.Yes Then
            Dim DataInforma As New Business.Prevencion.dataInformacion
            DataInforma.nombre = txtNombreInfor.Text
            Try
                DataInforma.puesto = cboPuestoI.Value.ToString
            Catch ex As Exception

            End Try

            DataInforma.telefono = txtTelefonoInfor.Text
            DataInforma.email = txtMailInfor.Text
            DataInforma.Observaciones = txtObservacionesInfor.Text
            DataInforma.snHistorico = 1
            DataInforma.idObra = Me.CurrentRow("IDObra")

            Dim OV As New PrevencionObraInfor

            ExpertisApp.ExecuteTask(Of dataInformacion)(AddressOf PrevencionObraInfor.GenerarNuevaInformacion, DataInforma)

            MsgBox("Se ha insertado una fila correctamente.")
            'Me.RequeryData()
            OV = Nothing
            Me.UpdateData()
        End If
    End Sub


    Private Sub CargahVisitas(ByVal pidVisitas As Integer, ByVal row As Integer)
        Try
            Dim dt As DataTable
            'dt = AdminData.Filter("select * from tbObraPrevVisitas", , "IDVisitas = " & pidVisitas, , False).DataTable
            Dim FiltroVisitas As New Filter
            FiltroVisitas.Add("idVisitas", pidVisitas)
            dt = DE.Filter("tbObraPrevVisitas", FiltroVisitas, , , False, False)
            'dt.TableName = "tbObraPrevVisitas"
            Dim Visita As Integer = 0
            If IsNothing(dt) Or dt.Rows.Count = 0 Then
                MsgBox("No se ha podido cargar el código de visita Nº " & pidVisitas)
            Else
                Visita = dt.Rows(0)("idvisitas")
                Me.txtNvisita.Text = dt.Rows(0)("nvisita")
                Me.cbxfechaVisita.Value = dt.Rows(0)("fecha")
                Me.cboTecnico.Text = dt.Rows(0)("Tecnico")
                Me.cboComunicado.Text = dt.Rows(0)("Comunicado")
                Me.txtObservacionesVisitas.Text = dt.Rows(0)("Observaciones")
                ' Actualizar los datos de ventana con los datos de la fila
                Me.RefreshData()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub NuevaDir(ByVal ctipo As Char)
        ' TabPage Visitas
        If MsgBox("¿Desea guardar al histórico el registro actual y añadir uno nuevo?", MsgBoxStyle.YesNo, "Generar histórico") = MsgBoxResult.Yes Then
            Dim PD As New PrevencionObraDireccion
            PD.UpdateForm(Me.CurrentRow, ctipo, 1)
            'Me.CurrentRow("vFrmPrevObraDireccion" & ctipo & "_idDireccion") = DBNull.Value
            ' Limpiar memoria
            PD = Nothing
            Me.RequeryData()
        End If
    End Sub
    Private Sub NuevaDir2(ByVal ctipo As Char, ByVal nombre As String, ByVal fini As String, ByVal ffin As String)
        ' TabPage Visitas
        If MsgBox("¿Desea guardar al histórico el registro actual y añadir uno nuevo?", MsgBoxStyle.YesNo, "Generar histórico") = MsgBoxResult.Yes Then
            Dim PD As New PrevencionObraDireccion
            PD.UpdateForm2(Me.CurrentRow, ctipo, nombre, fini, ffin, 1)
            'Me.CurrentRow("vFrmPrevObraDireccion" & ctipo & "_idDireccion") = DBNull.Value
            ' Limpiar memoria
            PD = Nothing
            Me.RequeryData()
        End If
    End Sub
    Private Sub NuevaDir3(ByVal tipo As String)
        ' TabPage Visitas
        If MsgBox("¿Desea guardar al histórico el registro actual y añadir uno nuevo?", MsgBoxStyle.YesNo, "Generar histórico") = MsgBoxResult.Yes Then

            Dim DataDirecc As New Business.Prevencion.dataDireccion

            DataDirecc.ctipo = tipo
            DataDirecc.snHistorico = 1
            DataDirecc.IdObra = Me.CurrentRow("IDObra")


            If (tipo.Equals("E")) Then
                DataDirecc.Nombre = cboDireccionE.Value.ToString
                Try
                    DataDirecc.FInicio = cbxFiniE.Value.ToString
                Catch ex As Exception

                End Try

                Try
                    If cbxFfinE.Value.ToString.Length = 0 Then

                    Else
                        DataDirecc.FFin = cbxFfinE.Value.ToString
                    End If
                Catch ex As Exception

                End Try

            ElseIf (tipo.Equals("J")) Then
                DataDirecc.Nombre = cboDireccionJ.Value.ToString
                DataDirecc.FInicio = cbxFiniJ.Value.ToString
                Try
                    DataDirecc.FFin = cbxFfinJ.Value.ToString
                Catch ex As Exception

                End Try
                Try

                Catch ex As Exception

                End Try

            End If

            Dim OV As New PrevencionObraDireccion

            ExpertisApp.ExecuteTask(Of dataDireccion)(AddressOf PrevencionObraDireccion.GenerarNuevaDireccion, DataDirecc)

            MsgBox("Se ha insertado una fila correctamente.")
            'Me.RequeryData()
            OV = Nothing
            Me.UpdateData()


        End If
    End Sub

    Private Sub CargahDir(ByVal pidDir As Integer)
        Try
            Dim dt As DataTable
            Dim ctipo As Char
            'dt = AdminData.Filter("select * from tbObraPrevDireccion", , "IDDireccion = " & pidDir, , False).DataTable
            Dim FtipoDir As New Filter
            FtipoDir.Add("IDDireccion", pidDir)
            dt = DE.Filter("tbObraPrevDireccion", FtipoDir, , , False, False)
            dt.TableName = "tbObraPrevDireccion"
            If IsNothing(dt) Or dt.Rows.Count = 0 Then
                MsgBox("No se ha podido cargar el código de dirección Nº " & pidDir)
            Else
                ctipo = dt.Rows(0)("Tipo")
                'Me.LastRetriveData.Tables(0).Rows(0)("vFrmPrevObraDireccion" & ctipo & "_IDDireccion") = dt.Rows(0)("IDDireccion")
                'Me.LastRetriveData.Tables(0).Rows(0)("vFrmPrevObraDireccion" & ctipo & "_Tipo") = dt.Rows(0)("Tipo")
                'Me.LastRetriveData.Tables(0).Rows(0)("vFrmPrevObraDireccion" & ctipo & "_Nombre") = dt.Rows(0)("Nombre")
                'Me.LastRetriveData.Tables(0).Rows(0)("vFrmPrevObraDireccion" & ctipo & "_FInicio") = dt.Rows(0)("FInicio")
                'Me.LastRetriveData.Tables(0).Rows(0)("vFrmPrevObraDireccion" & ctipo & "_FFin") = dt.Rows(0)("FFin")
                ' Actualizar los datos de ventana con los datos de la fila

                'Si es encargado
                If (ctipo = "E") Then
                    Me.cboDireccionE.Value = dt.Rows(0)("Nombre")
                    Me.cbxFiniE.Value = dt.Rows(0)("FInicio")
                    Me.cbxFfinE.Value = dt.Rows(0)("FFin")
                    'Si es jefe de produccion
                ElseIf (ctipo = "J") Then
                    Me.cboDireccionJ.Value = dt.Rows(0)("Nombre")
                    Me.cbxFiniJ.Value = dt.Rows(0)("FInicio")
                    Me.cbxFfinJ.Value = dt.Rows(0)("FFin")
                End If
                Me.RefreshData()
                End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub NuevoRec3()
        ' TabPage Visitas
        If MsgBox("¿Desea guardar al histórico el registro actual y añadir uno nuevo?", MsgBoxStyle.YesNo, "Generar histórico") = MsgBoxResult.Yes Then
            Dim DataRec As New Business.Prevencion.dataRec
            DataRec.codop = AdvS_Rec_Codigo.Value.ToString
            DataRec.finicio = cbxfiniRec.Value.ToString
            DataRec.ffin = cbxffinRec.Value.ToString
            DataRec.rec = txtRec.Text

            DataRec.snHistorico = 1
            DataRec.idObra = Me.CurrentRow("IDObra")

            Dim OV As New PrevencionObraRec

            ExpertisApp.ExecuteTask(Of dataRec)(AddressOf PrevencionObraRec.GenerarNuevoRec, DataRec)

            MsgBox("Se ha insertado una fila correctamente.")
            'Me.RequeryData()
            OV = Nothing
            Me.UpdateData()
        End If
    End Sub

    Private Sub NuevoRec2()
        ' TabPage Visitas
        If MsgBox("¿Desea guardar al histórico el registro actual y añadir uno nuevo?", MsgBoxStyle.YesNo, "Generar histórico") = MsgBoxResult.Yes Then
            Dim PR As New PrevencionObraRec
            PR.UpdateForm2(Me.CurrentRow, txtRec.Text.ToString, AdvS_Rec_Codigo.Value.ToString, Ul_Operario.Text, cbxfiniRec.Value.ToString, cbxffinRec.Value.ToString, 1)
            'Me.CurrentRow("tbObraPrevRec_idRec") = DBNull.Value
            ' Limpiar memoria
            PR = Nothing
            Me.RequeryData()
        End If
    End Sub

    Private Sub NuevoRec()
        ' TabPage Visitas
        If MsgBox("¿Desea guardar al histórico el registro actual y añadir uno nuevo?", MsgBoxStyle.YesNo, "Generar histórico") = MsgBoxResult.Yes Then
            Dim PR As New PrevencionObraRec
            PR.UpdateForm(Me.CurrentRow, 1)
            Me.CurrentRow("tbObraPrevRec_idRec") = DBNull.Value
            ' Limpiar memoria
            PR = Nothing
            Me.RequeryData()
        End If
    End Sub

    Private Sub CargahRec(ByVal pidRec As Integer)
        Try
            Dim dt As DataTable
            'dt = AdminData.Filter("select * from tbObraPrevRec", , "IDRec = " & pidRec, , False).DataTable
            Dim FRec As New Filter
            FRec.Add("idrec", pidRec)
            dt = DE.Filter("tbObraPrevRec", FRec, , , False, False)
            dt.TableName = "tbObraPrevRec"
            If IsNothing(dt) Or dt.Rows.Count = 0 Then
                MsgBox("No se ha podido cargar el código de requerimiento Nº " & pidRec)
            Else
                'Me.LastRetriveData.Tables(0).Rows(0)("tbObraPrevRec_IDRec") = dt.Rows(0)("IDRec")
                'Me.LastRetriveData.Tables(0).Rows(0)("tbObraPrevRec_RecPreventivo") = dt.Rows(0)("RecPreventivo")
                'Me.LastRetriveData.Tables(0).Rows(0)("tbObraPrevRec_fInicio") = dt.Rows(0)("fInicio")
                'Me.LastRetriveData.Tables(0).Rows(0)("tbObraPrevRec_fFin") = dt.Rows(0)("fFin")
                'Me.LastRetriveData.Tables(0).Rows(0)("tbObraPrevRec_idOperario") = dt.Rows(0)("idOperario")

                Me.txtRec.Text = dt.Rows(0)("RecPreventivo")
                Me.cbxfiniRec.Value = dt.Rows(0)("fInicio")
                Me.cbxffinRec.Text = dt.Rows(0)("fFin")
                Me.AdvS_Rec_Codigo.Text = dt.Rows(0)("idOperario")

                'Me.txtObservacionesInfor.Text = dt.Rows(0)("Observaciones")

                ' Actualizar los datos de ventana con los datos de la fila
                Me.RefreshData()
                'Me.AdvS_Rec_Codigo.Focus()
                'Me.txtRec.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub NuevaInf()
        ' TabPage Visitas
        If MsgBox("¿Desea guardar al histórico el registro actual y añadir uno nuevo?", MsgBoxStyle.YesNo, "Generar histórico") = MsgBoxResult.Yes Then
            Dim PR As New PrevencionObraInfor
            PR.UpdateForm(Me.CurrentRow, 1)
            Me.CurrentRow("tbObraPrevInfor_IdInformacion") = DBNull.Value
            ' Limpiar memoria
            PR = Nothing
            Me.RequeryData()
        End If
    End Sub

    Private Sub NuevaInf2()
        ' TabPage Visitas
        If MsgBox("¿Desea guardar al histórico el registro actual y añadir uno nuevo?", MsgBoxStyle.YesNo, "Generar histórico") = MsgBoxResult.Yes Then
            Dim PR As New PrevencionObraInfor
            PR.UpdateForm2(Me.CurrentRow, txtNombreInfor.Text, cboPuestoI.Text, txtTelefonoInfor.Text, txtMailInfor.Text, txtObservacionesInfor.Text, 1)
            'Me.CurrentRow("tbObraPrevInfor_IdInformacion") = DBNull.Value
            ' Limpiar memoria
            PR = Nothing
            'Me.RequeryData()
            Me.Update()

        End If
    End Sub
    Private Sub NuevaInf3()
        ' TabPage Visitas
        If MsgBox("¿Desea guardar al histórico el registro actual y añadir uno nuevo?", MsgBoxStyle.YesNo, "Generar histórico") = MsgBoxResult.Yes Then
            Dim PR As New PrevencionObraInfor
            MsgBox(Me.CurrentRow("IDDireccion"))
            PR.UpdateForm3(Me.CurrentRow("IDDireccion"), txtNombreInfor.Text, cboPuestoI.Text, txtTelefonoInfor.Text, txtMailInfor.Text, txtObservacionesInfor.Text, 1)
            'Me.CurrentRow("tbObraPrevInfor_IdInformacion") = DBNull.Value
            ' Limpiar memoria
            PR = Nothing
            'Me.RequeryData()
            Me.Update()

        End If
    End Sub


    Private Sub CargahInf(ByVal pidInf As Integer)
        Try
            Dim dt As DataTable
            'dt = AdminData.Filter("select * from tbObraPrevInfor", , "IdInformacion = " & pidInf, , False).DataTable
            Dim FiltroInf As New Filter
            FiltroInf.Add("IdInformacion", pidInf)
            dt = DE.Filter("tbObraPrevInfor", FiltroInf, , , False, False)
            dt.TableName = "tbObraPrevInfor"
            If IsNothing(dt) Or dt.Rows.Count = 0 Then
                MsgBox("No se ha podido cargar el código de información Nº " & pidInf)
            Else
                'Me.LastRetriveData.Tables(0).Rows(0)("tbObraPrevInfor_IdInformacion") = dt.Rows(0)("IdInformacion")
                'Me.LastRetriveData.Tables(0).Rows(0)("tbObraPrevInfor_Nombre") = dt.Rows(0)("Nombre")
                'Me.LastRetriveData.Tables(0).Rows(0)("tbObraPrevInfor_Puesto") = dt.Rows(0)("Puesto")
                'Me.LastRetriveData.Tables(0).Rows(0)("tbObraPrevInfor_Telefono") = dt.Rows(0)("Telefono")
                'Me.LastRetriveData.Tables(0).Rows(0)("tbObraPrevInfor_Mail") = dt.Rows(0)("Mail")
                'Me.LastRetriveData.Tables(0).Rows(0)("tbObraPrevInfor_Observaciones") = dt.Rows(0)("Observaciones")

                Me.txtNombreInfor.Text = dt.Rows(0)("Nombre")
                Me.cboPuestoI.Value = dt.Rows(0)("Puesto")
                Me.txtTelefonoInfor.Text = dt.Rows(0)("Telefono")
                Me.txtMailInfor.Text = dt.Rows(0)("Mail")
                Me.txtObservacionesInfor.Text = dt.Rows(0)("Observaciones")
                ' Actualizar los datos de ventana con los datos de la fila

                Me.RefreshData()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub NuevaDoc()
        ' TabPage Visitas
        If MsgBox("¿Desea guardar al histórico el registro actual y añadir uno nuevo?", MsgBoxStyle.YesNo, "Generar histórico") = MsgBoxResult.Yes Then
            Dim PD As New PrevencionObraDoc
            PD.UpdateForm(Me.CurrentRow, 1)
            Me.CurrentRow("tbObraPrevDoc_idDocumentacion") = DBNull.Value
            ' Limpiar memoria
            PD = Nothing
            Me.RequeryData()
        End If
    End Sub

    Private Sub NuevaDoc2()
        ' TabPage Visitas
        If MsgBox("¿Desea guardar al histórico el registro actual y añadir uno nuevo?", MsgBoxStyle.YesNo, "Generar histórico") = MsgBoxResult.Yes Then
            Dim PD As New PrevencionObraDoc
            PD.UpdateForm2(Me.CurrentRow, cbxFechaDoc.Value, txtSolicitante.Text, txtSolicita.Text, cboEnvio.Text, TxtObservaDoc.Text, 1)
            'Me.CurrentRow("tbObraPrevDoc_idDocumentacion") = DBNull.Value
            ' Limpiar memoria
            PD = Nothing
            Me.RequeryData()
        End If
    End Sub
    Private Sub NuevaDoc3()
        ' TabPage Visitas
        If MsgBox("¿Desea guardar al histórico el registro actual y añadir uno nuevo?", MsgBoxStyle.YesNo, "Generar histórico") = MsgBoxResult.Yes Then
            Dim DataDoc As New Business.Prevencion.dataDoc
            DataDoc.fecha = cbxFechaDoc.Value.ToString
            Try
                DataDoc.envio = cboEnvio.Value.ToString
            Catch ex As Exception

            End Try
            Try
                DataDoc.solcita = txtSolicita.Text
            Catch ex As Exception

            End Try
            Try
                DataDoc.solicitante = txtSolicitante.Text
            Catch ex As Exception

            End Try
            Try
                DataDoc.observaciones = TxtObservaDoc.Text
            Catch ex As Exception

            End Try

            DataDoc.snHistorico = 1
            DataDoc.idObra = Me.CurrentRow("IDObra")

            Dim OV As New PrevencionObraDoc

            ExpertisApp.ExecuteTask(Of dataDoc)(AddressOf PrevencionObraDoc.GenerarNuevaDoc, DataDoc)

            MsgBox("Se ha insertado una fila correctamente.")
            'Me.RequeryData()
            OV = Nothing
            Me.UpdateData()


        End If
    End Sub

    Private Sub CargahDoc(ByVal pidDoc As Integer)
        Try
            Dim dt As DataTable
            'dt = AdminData.Filter("select * from tbObraPrevDoc", , "idDocumentacion = " & pidDoc, , False).DataTable
            Dim FDoc As New Filter
            FDoc.Add("idDocumentacion", pidDoc)
            dt = DE.Filter("tbObraPrevDoc", FDoc, , , False, False)
            dt.TableName = "tbObraPrevDoc"
            If IsNothing(dt) Or dt.Rows.Count = 0 Then
                MsgBox("No se ha podido cargar el código de documentación Nº " & pidDoc)
            Else
                'Me.LastRetriveData.Tables(0).Rows(0)("tbObraPrevDoc_idDocumentacion") = dt.Rows(0)("idDocumentacion")
                'Me.LastRetriveData.Tables(0).Rows(0)("tbObraPrevDoc_Fecha") = dt.Rows(0)("Fecha")
                'Me.LastRetriveData.Tables(0).Rows(0)("tbObraPrevDoc_Solicitante") = dt.Rows(0)("Solicitante")
                'Me.LastRetriveData.Tables(0).Rows(0)("tbObraPrevDoc_Solicita") = dt.Rows(0)("Solicita")
                'Me.LastRetriveData.Tables(0).Rows(0)("tbObraPrevDoc_ModEnvio") = dt.Rows(0)("ModEnvio")
                'Me.LastRetriveData.Tables(0).Rows(0)("tbObraPrevDoc_Observaciones") = dt.Rows(0)("Observaciones")



                Me.cbxFechaDoc.Text = dt.Rows(0)("Fecha")
                Try
                    Me.txtSolicitante.Text = dt.Rows(0)("Solicitante")
                Catch ex As Exception

                End Try

                Try
                    Me.txtSolicita.Text = dt.Rows(0)("Solicita")
                Catch ex As Exception

                End Try

                Try
                    Me.cboEnvio.Text = dt.Rows(0)("ModEnvio")
                Catch ex As Exception

                End Try

                Try
                    Me.TxtObservaDoc.Text = dt.Rows(0)("Observaciones")
                Catch ex As Exception

                End Try

                ' Actualizar los datos de ventana con los datos de la fila

                Me.RefreshData()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub AbrirOperario(ByVal pidOperario As String)
        Dim f As New Filter
        Try
            f.Add("idOperario", pidOperario)
            If ExpertisApp.IsFormOpen("PREVENTECO") = False Then
                ExpertisApp.OpenForm("PREVENTECO", f, , )
            Else
                ExpertisApp.CloseForm("PREVENTECO")
                ExpertisApp.OpenForm("PREVENTECO", f, , )
            End If
        Catch ex As Exception
            ExpertisApp.GenerateMessage(ex.Message)
        Finally
            f = Nothing
        End Try
    End Sub

    Private Sub AbrirCalendario(ByVal pidOperario As String, ByVal sMes As String)
        Dim f As New Filter
        Try
            f.Add("idOperario", pidOperario)
            If ExpertisApp.IsFormOpen("CALOBRAS") = False Then
                ExpertisApp.OpenForm("CALOBRAS", f, , )
            Else
                ExpertisApp.CloseForm("CALOBRAS")
                ExpertisApp.OpenForm("CALOBRAS", f, , )
            End If
        Catch ex As Exception
            ExpertisApp.GenerateMessage(ex.Message)
        Finally
            f = Nothing
        End Try
    End Sub


    Private Sub GridAccidentes_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs)
        If Not IsDBNull(GridAccidentes.GetValue("idOperario")) Then
            AbrirOperario(GridAccidentes.GetValue("idOperario"))
        End If
    End Sub

    Private Sub GridCalendario_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs)
        If Not IsDBNull(GridCalendario.GetValue("idOperario")) Then
            AbrirCalendario(GridCalendario.GetValue("idOperario"), Strings.Left(GridCalendario.GetValue("MesYear"), 2))
        End If
    End Sub

#Region "Calculo Estadísticas"

    Private Sub MntoPrevencionObra_Navigated(ByVal sender As Object, ByVal e As Engine.UI.NavigatedEventArgs) Handles MyBase.Navigated
        ValidarTabSelect()
    End Sub

    Private Sub tabObraPrevencion_SelectedTabChanged1(ByVal sender As Object, ByVal e As Janus.Windows.UI.Tab.TabEventArgs) Handles tabObraPrevencion.SelectedTabChanged
        ValidarTabSelect()
    End Sub

    Private Sub IntUDMes_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles iup_FiltroMesEObra.ValueChanged, iup_FiltroMesEEmpresa.ValueChanged, iup_FiltroPeriodoEObra.ValueChanged, iup_FiltroPeriodoEEmpresa.ValueChanged
        ValidarTabSelect()
    End Sub

    Private Sub ValidarTabSelect()
        Try
            If Not IsNothing(tabObraPrevencion.SelectedTab) Then
                ' 7 Obra, 8 Empresa
                Select Case tabObraPrevencion.SelectedTab.TabIndex
                    Case 7
                        CalcularEstObra()
                    Case 8
                        CalcularEstEmpresa()
                End Select
            End If
        Catch ex As Exception
            ExpertisApp.GenerateMessage(ex.Message)
        End Try
    End Sub


    Private Sub CalcularEstObra()
        Dim clEstObra As New EstadisticasPreven
        Dim svalor() As String
        Dim imes, iyear As Integer

        ' Obtener mes/año
        imes = iup_FiltroMesEObra.Value
        iyear = iup_FiltroPeriodoEObra.Value

        '1
        svalor = clEstObra.NumTrabaMesObra(Me.CurrentRow("idObra"), imes, iyear).Split("-")
        txtmObra1a.Text = svalor(0)
        txtmObra1b.Text = svalor(1)
        '2
        txtmObra2.Text = clEstObra.MediaHorasObra(Me.CurrentRow("idObra"), imes, iyear).ToString
        '3,4
        svalor = clEstObra.AccidentesDias(Me.CurrentRow("idObra"), imes, iyear).Split("-")
        txtmObra3.Text = svalor(0)
        txtmObra4.Text = svalor(1)
        '5,6 y 9,10 (24/09/2012)
        svalor = clEstObra.AccidentesMil(Me.CurrentRow("idObra"), imes, iyear).Split("-")
        txtmObra5.Text = svalor(0)
        txtmObra6.Text = svalor(1)
        txtmObra9.Text = svalor(2)
        txtmObra10.Text = svalor(3)
        '7,8
        svalor = clEstObra.DayLost(Me.CurrentRow("idObra"), imes, iyear).Split("-")
        txtmObra7.Text = svalor(0)
        txtmObra8.Text = svalor(1)

        '11,12
        svalor = clEstObra.JornadasJob(Me.CurrentRow("idObra"), imes, iyear).Split("-")
        txtmObra11.Text = svalor(0)
        txtmObra12.Text = svalor(1)
        ' Limpiar memoria
        clEstObra = Nothing
    End Sub

    Private Sub CalcularEstEmpresa()
        Dim clEstObra As New EstadisticasPreven
        Dim svalor() As String
        Dim imes, iyear As Integer

        ' Obtener mes/año
        imes = iup_FiltroMesEEmpresa.Value
        iyear = iup_FiltroPeriodoEEmpresa.Value

        '1,2
        svalor = clEstObra.HorasNumTrabaE(imes, iyear).Split("-")
        txtmEmp1.Text = svalor(0)
        txtmEmp2.Text = svalor(1)

        '3 Media
        txtmEmp3.Text = clEstObra.MedTrabaEmp(imes, iyear)

        '4 
        txtmEmp4.Text = clEstObra.MediaHorasEmp(imes, iyear)

        '5
        txtmEmp5.Text = clEstObra.AccidentesMilEmpresa(imes, iyear, False)


        '8 Se carga con la empresa
        svalor = clEstObra.DayLost(Me.CurrentRow("idObra"), imes, iyear, False).Split("-")
        txtmEmp8.Text = svalor(1)

        ' Recalcular Grid de días
        If bCalculaDias = False Then
            clEstObra.DiasPerdidosEmp(GridDiasP.DataSource)
            bCalculaDias = True
        End If
        ' Limpiar memoria
        clEstObra = Nothing
    End Sub
#End Region

    Private Sub btnExporExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExporExcel.Click
        GridAccidentes.ExportToExcel()
    End Sub

    Private Sub btnExpCalendario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExpCalendario.Click
        GridCalendario.ExportToExcel()
    End Sub

#Region "Cargar Combos"
    Private Sub CargarListaDireccion()
        ' Dim FwConsulta As Aplicacion
        'Dim Strsql As String
        'Dim rcsRdo As DataTable
        Dim jsCol As Janus.Windows.GridEX.GridEXColumn      'JSColumn
        Dim vl As Janus.Windows.GridEX.GridEXValueListItemCollection  ' JSValueList
        'Dim i As Integer
        'Dim n As Integer
        Dim aux As Janus.Windows.GridEX.GridEXValueListItem

        Try
            jsCol = GridDireccion.Columns("Tipo")
            jsCol.HasValueList = True

            vl = jsCol.ValueList

            aux = New Janus.Windows.GridEX.GridEXValueListItem
            aux.Value = "E"
            aux.Text = Nz("Encargado", "")
            vl.Add(aux)  ', rcsRdo!Estructura

            aux = New Janus.Windows.GridEX.GridEXValueListItem
            aux.Value = "J"
            aux.Text = Nz("Jefe de pro.", "")
            vl.Add(aux)  ', rcsRdo!Estructura


            aux = New Janus.Windows.GridEX.GridEXValueListItem
            aux.Value = "O"
            aux.Text = Nz("Otros", "")
            vl.Add(aux)  ', rcsRdo!Estructura

        Catch ex As Exception
            ExpertisApp.GenerateMessage(ex.Message)
        End Try
    End Sub

    Private Sub CargarListaDoc()
        ' Dim FwConsulta As Aplicacion
        'Dim Strsql As String
        'Dim rcsRdo As Recordset
        Dim jsCol As Janus.Windows.GridEX.GridEXColumn      'JSColumn
        Dim vl As Janus.Windows.GridEX.GridEXValueListItemCollection  ' JSValueList
        'Dim i As Integer
        'Dim n As Integer
        Dim aux As Janus.Windows.GridEX.GridEXValueListItem

        Try
            jsCol = GridDoc.Columns("ModEnvio")
            jsCol.HasValueList = True

            vl = jsCol.ValueList

            aux = New Janus.Windows.GridEX.GridEXValueListItem
            aux.Value = 1
            aux.Text = Nz("E-Mail", "")
            vl.Add(aux)  ', rcsRdo!Estructura

            aux = New Janus.Windows.GridEX.GridEXValueListItem
            aux.Value = 2
            aux.Text = Nz("Envio Postal", "")
            vl.Add(aux)  ', rcsRdo!Estructura


            aux = New Janus.Windows.GridEX.GridEXValueListItem
            aux.Value = 3
            aux.Text = Nz("Fax", "")
            vl.Add(aux)  ', rcsRdo!Estructura

            aux = New Janus.Windows.GridEX.GridEXValueListItem
            aux.Value = 4
            aux.Text = Nz("BuroFax", "")
            vl.Add(aux)  ', rcsRdo!Estructura

            aux = New Janus.Windows.GridEX.GridEXValueListItem
            aux.Value = 5
            aux.Text = Nz("Otros", "")
            vl.Add(aux)  ', rcsRdo!Estructura

        Catch ex As Exception
            ExpertisApp.GenerateMessage(ex.Message)
        End Try
    End Sub

#End Region

    Private Sub MntoOperario_SetReportDesignObjects(ByVal sender As Object, ByVal e As ReportDesignObjectsEventArgs) Handles MyBase.SetReportDesignObjects
        Select Case e.Alias
            Case "INFPREVJEFEPROD"
                PrintJefeProd(e)
            Case "INFHORASFECHA"
                generarInformeHorasFechas()
                e.Cancel = True
            Case "INFSINIS"
                generarInfSinis(e)
                'e.Cancel = True
        End Select

    End Sub

    Private Sub generarInfSinis(ByRef e As ReportDesignObjectsEventArgs)
        Dim dDesde As Date
        Dim dHasta As Date
        Try
            Dim frmPrint As New FrmFecha
            frmPrint.ShowDialog()

            If frmPrint.blEstado = False Then
                e.Cancel = True
            Else
                If frmPrint.mes = 1 Then
                    dDesde = CDate(frmPrint.anio - 1 & "/" & 12 & "/" & 21)
                    dHasta = CDate(frmPrint.anio & "/" & frmPrint.mes & "/" & 20)
                Else
                    dDesde = CDate(frmPrint.anio & "/" & frmPrint.mes - 1 & "/" & 21)
                    dHasta = CDate(frmPrint.anio & "/" & frmPrint.mes & "/" & 20)
                End If

                MsgBox("el intervalo de fechas elegido es entre " & dDesde & " y " & dHasta)
                e.Parameters("@desde").Values.Add(dDesde)
                e.Parameters("@hasta").Values.Add(dHasta)
                e.Subreports("ResumenMes").Parameters("@desde").Values.Add(dDesde)
                e.Subreports("ResumenMes").Parameters("@hasta").Values.Add(dHasta)
                e.Subreports("AccJefeProd").Parameters("@hasta").Values.Add(dHasta)
                e.Subreports("AccJefeProdUltAnio").Parameters("@hasta").Values.Add(dHasta)
                e.Subreports("Graficas").Parameters("@hasta").Values.Add(dHasta)
                e.Subreports("AccidentesMes").Parameters("@hasta").Values.Add(dHasta)
                e.Subreports("AccidentesMes").Parameters("@Desde").Values.Add(dDesde)
                e.Subreports("TrabajadoresDeBaja").Parameters("@hasta").Values.Add(dHasta)
                frmPrint = Nothing
            End If
            frmPrint = Nothing
        Catch ex As Exception
            MsgBox("Error al asignar parámetros:" & ex.Message)
        End Try


    End Sub
    Private Sub PrintJefeProd(ByRef e As ReportDesignObjectsEventArgs)
        Try
            Dim frmPrint As New FrmDatosPrint
            frmPrint.ShowDialog()

            If frmPrint.blnImprimir = False Then
                e.Cancel = True
            Else
                e.Parameters("@JefeProd").Values.Add(frmPrint.sJefe)
            End If
            frmPrint = Nothing
        Catch ex As Exception
            MsgBox("Error al asignar parámetros:" & ex.Message)
        End Try

    End Sub

    'SERGIO BLANCO 28/02/2014
    Private Sub generarInformeHorasFechas()

        Dim emp As New DatosEmpresa
        Dim f As New Filter

        Try
            Dim rcsempresa As DataTable = emp.Filter(f, , "descEmpresa")
            Dim empresa As String = ""
            If rcsempresa.Rows.Count > 0 Then
                empresa = CStr(rcsempresa.Rows(0)("DescEmpresa"))
            End If

            Dim frm As New FrmInformeFecha
            frm.ShowDialog()
            Dim fDesde As Date = frm.fecha1
            Dim fHasta As Date = frm.fecha2
            Dim dtObras As DataTable = frm.dtObrasSelect
            Dim strWhere As String = ""
            Dim nfilas As Integer = dtObras.Rows.Count
            Dim i As Integer = 0
            If dtObras.Rows.Count > 0 Then
                strWhere = " dbo.tbObraCabecera.NObra in ("
                For Each row As DataRow In dtObras.Rows
                    i = i + 1

                    If i = nfilas Then
                        strWhere &= "'" & row("NObra").ToString & "'"
                    Else
                        strWhere &= "'" & row("NObra").ToString & "',"
                    End If

                Next
                strWhere &= " ) and "

            End If

            Dim ob As New Funciones

            Dim rp As New Report("INFHORASFECHA")
            Dim strSelect As String = "SELECT TOP 100 PERCENT dbo.tbObraMODControl.IDObra, dbo.tbObraCabecera.NObra, dbo.tbObraCabecera.DescObra, "
            strSelect &= " SUM(dbo.tbObraMODControl.HorasRealMod) AS HorasTrabajadas, COUNT(dbo.tbObraMODControl.FechaInicio) AS JornadasTrabajadas"
            strSelect &= " FROM dbo.tbObraMODControl INNER JOIN dbo.tbObraCabecera ON dbo.tbObraMODControl.IDObra = dbo.tbObraCabecera.IDObra"
            strSelect &= " WHERE " & strWhere & " dbo.tbObraMODControl.FechaInicio between '" & fDesde & "' and '" & fHasta & "'"
            strSelect &= " GROUP BY dbo.tbObraMODControl.IDObra, dbo.tbObraCabecera.NObra, dbo.tbObraCabecera.DescObra"
            strSelect &= " ORDER BY dbo.tbObraCabecera.NObra"

            rp.DataSource = ob.RecogeDatos(strSelect)
            rp.Formulas("fdesde").Text = Format(fDesde, "dd/MM/yyyy")
            rp.Formulas("fhasta").Text = Format(fHasta, "dd/MM/yyyy")
            rp.Formulas("DescEmpresa").Text = empresa

            ExpertisApp.OpenReport(rp)
        Catch e As Exception
            MsgBox(e.Message)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim descop As String = ""
            Dim dt As DataTable = New Business.Prevencion.Operario().Filter(New StringFilterItem("IDOperario", AdvS_Rec_Codigo.Text))
            If Not IsNothing(dt) AndAlso dt.Rows.Count > 0 Then
                Dim contador As Integer = 0
                For Each dr As DataRow In dt.Rows
                    descop = dr("DesCOperario")
                    Exit For
                Next
            End If
            Ul_Operario.Text = descop

        Catch ex As Exception
            MsgBox("ERROR")
        End Try
    End Sub
End Class
