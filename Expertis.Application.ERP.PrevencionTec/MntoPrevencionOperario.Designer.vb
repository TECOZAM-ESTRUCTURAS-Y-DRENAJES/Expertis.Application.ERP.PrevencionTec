<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MntoPrevencionOperario
    Inherits Solmicro.Expertis.Engine.UI.SimpleMnto

    'Form invalida a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim GridReconocimiento_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MntoPrevencionOperario))
        Dim GridCorreoReconocimiento_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridPuestos_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridFInterna_hist_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim UICB_FormacionI_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridFExterna_hist_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim UiCB_FormacionE_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridFormacion50_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim UiCB_Formacion50_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridFormacion20_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim UiCB_Formacion20_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridFiltroCurso_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridTPC_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridEpis_hist_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim UiCB_Epi_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridAccidentes_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridCorreoAcc_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim UiCB_AccidentesJ_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim UiCB_AccidentesE_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridNotificacion_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim UiCB_NotificacionesJ_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim UiCB_NotificacionesS_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim UiCB_NotificacionesE_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridBajas_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridCorreoBajas_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim UiCB_BajasE_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.txtIDOperario = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblIDOperario = New Solmicro.Expertis.Engine.UI.Label
        Me.txtDescOperario = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtTipoContrato = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblTipoContrato = New Solmicro.Expertis.Engine.UI.Label
        Me.clbFechaAlta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaAlta = New Solmicro.Expertis.Engine.UI.Label
        Me.UiCheckBox1 = New Janus.Windows.EditControls.UICheckBox
        Me.clbFecha_Baja = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFecha_Baja = New Solmicro.Expertis.Engine.UI.Label
        Me.clbFecha_Nacimiento = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFecha_Nacimiento = New Solmicro.Expertis.Engine.UI.Label
        Me.txtDNI = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblDNI = New Solmicro.Expertis.Engine.UI.Label
        Me.txtN_Social = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblN_Social = New Solmicro.Expertis.Engine.UI.Label
        Me.txtNifPortu = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblNifPortu = New Solmicro.Expertis.Engine.UI.Label
        Me.txtDireccion = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblDireccion = New Solmicro.Expertis.Engine.UI.Label
        Me.txtPoblacion = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblPoblacion = New Solmicro.Expertis.Engine.UI.Label
        Me.txtProvincia = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblProvincia = New Solmicro.Expertis.Engine.UI.Label
        Me.advCodPostal = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblCodPostal = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDPais = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblIDPais = New Solmicro.Expertis.Engine.UI.Label
        Me.ulbDescPais = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.ulbDescDepartamento = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.advIDDepartamento = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblIDDepartamento = New Solmicro.Expertis.Engine.UI.Label
        Me.ulbDescOficio = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.advIDOficio = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblIDOficio = New Solmicro.Expertis.Engine.UI.Label
        Me.ulbDescCategoria = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.txtEmail = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblEmail = New Solmicro.Expertis.Engine.UI.Label
        Me.txtFax = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblFax = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTelefono = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblTelefono = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDCategoria = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblIDCategoria = New Solmicro.Expertis.Engine.UI.Label
        Me.tabOperarioPrev = New Solmicro.Expertis.Engine.UI.Tab
        Me.tabReconocimiento = New Janus.Windows.UI.Tab.UITabPage
        Me.Panel2 = New Solmicro.Expertis.Engine.UI.Panel
        Me.RB_Reconocimiento_ap = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.brnRecon = New Solmicro.Expertis.Engine.UI.Button
        Me.GridReconocimiento = New Solmicro.Expertis.Engine.UI.Grid
        Me.lbltbOperarioReconocimiento_Lugar = New Solmicro.Expertis.Engine.UI.Label
        Me.btnRecoh = New Solmicro.Expertis.Engine.UI.Button
        Me.txtLugarReconocimiento = New Solmicro.Expertis.Engine.UI.TextBox
        Me.GridCorreoReconocimiento = New Solmicro.Expertis.Engine.UI.Grid
        Me.RB_Reconocimiento_no = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.Label1 = New Solmicro.Expertis.Engine.UI.Label
        Me.txtdesLimitacion = New Solmicro.Expertis.Engine.UI.TextBox
        Me.RB_Reconocimiento_Apto = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.UICheckLimitaciones = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.lbltbOperarioReconocimiento_Fecha = New Solmicro.Expertis.Engine.UI.Label
        Me.lbltbOperarioReconocimiento_snLimitacion = New Solmicro.Expertis.Engine.UI.Label
        Me.clbFechaReconocimiento = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.txtdesSensible = New Solmicro.Expertis.Engine.UI.TextBox
        Me.GridPuestos = New Solmicro.Expertis.Engine.UI.Grid
        Me.lbltbOperarioReconocimiento_desSensible = New Solmicro.Expertis.Engine.UI.Label
        Me.lbltbOperarioReconocimiento_snSensible = New Solmicro.Expertis.Engine.UI.Label
        Me.clbtbOperarioReconocimiento_nDiasAviso = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.UiCheckSensible = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.lbltbOperarioReconocimiento_nDiasAviso = New Solmicro.Expertis.Engine.UI.Label
        Me.tabFormacion = New Janus.Windows.UI.Tab.UITabPage
        Me.Tab2Formacion = New Solmicro.Expertis.Engine.UI.Tab
        Me.UiTabPageFInterna = New Janus.Windows.UI.Tab.UITabPage
        Me.Panel3 = New Solmicro.Expertis.Engine.UI.Panel
        Me.Label2 = New Solmicro.Expertis.Engine.UI.Label
        Me.GridFInterna_hist = New Solmicro.Expertis.Engine.UI.Grid
        Me.clb_FInterna_fecha = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblvFrmPrevencionFormacion50_fecha = New Solmicro.Expertis.Engine.UI.Label
        Me.SLE_FInterna_Horas = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblvFrmPrevencionFormacionI_Horas = New Solmicro.Expertis.Engine.UI.Label
        Me.SLE_FInterna_Especificar = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblvFrmPrevencionFormacionI_DesFormacion = New Solmicro.Expertis.Engine.UI.Label
        Me.UICB_FormacionI = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblvFrmPrevencionFormacionI_DescClaseFormacion = New Solmicro.Expertis.Engine.UI.Label
        Me.chbvFrmPrevencionFormacionI_snEspecifica = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.lblvFrmPrevencionFormacionI_snEspecifica = New Solmicro.Expertis.Engine.UI.Label
        Me.chbvFrmPrevencionFormacionI_snPuesto = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.lblvFrmPrevencionFormacionI_snPuesto = New Solmicro.Expertis.Engine.UI.Label
        Me.btnFInternaNew = New Solmicro.Expertis.Engine.UI.Button
        Me.UiTabPageFExterna = New Janus.Windows.UI.Tab.UITabPage
        Me.Panel4 = New Solmicro.Expertis.Engine.UI.Panel
        Me.GridFExterna_hist = New Solmicro.Expertis.Engine.UI.Grid
        Me.Label3 = New Solmicro.Expertis.Engine.UI.Label
        Me.ClB_FExterna_Fecha = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblvFrmPrevencionFormacionE_Horas1 = New Solmicro.Expertis.Engine.UI.Label
        Me.SLE_FExternaHoras = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblvFrmPrevencionFormacionE_Horas = New Solmicro.Expertis.Engine.UI.Label
        Me.SLE_FExterna_Especificar = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblvFrmPrevencionFormacionE_DesFormacion = New Solmicro.Expertis.Engine.UI.Label
        Me.UiCB_FormacionE = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblvFrmPrevencionFormacionI_DescClaseFormacion1 = New Solmicro.Expertis.Engine.UI.Label
        Me.btnFExternaNew = New Solmicro.Expertis.Engine.UI.Button
        Me.UiTabPageFormFLC = New Janus.Windows.UI.Tab.UITabPage
        Me.Panel5 = New Solmicro.Expertis.Engine.UI.Panel
        Me.Fr50 = New Solmicro.Expertis.Engine.UI.Frame
        Me.clbvFrmPrevencionFormacion50_fecha = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblvFrmPrevencionFormacion50_fecha1 = New Solmicro.Expertis.Engine.UI.Label
        Me.GridFormacion50 = New Solmicro.Expertis.Engine.UI.Grid
        Me.SLE_FFLC_Lugar50 = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblvFrmPrevencionFormacion50_Lugar = New Solmicro.Expertis.Engine.UI.Label
        Me.SLE_FFLC_Empresa50 = New Solmicro.Expertis.Engine.UI.TextBox
        Me.Label5 = New Solmicro.Expertis.Engine.UI.Label
        Me.UiCB_Formacion50 = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblvFrmPrevencionFormacion50_DescClaseFormacion = New Solmicro.Expertis.Engine.UI.Label
        Me.btnF50 = New Solmicro.Expertis.Engine.UI.Button
        Me.Fr20 = New Solmicro.Expertis.Engine.UI.Frame
        Me.ClB_FFLC_Fecha20 = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblvFrmPrevencionFormacion20_fecha = New Solmicro.Expertis.Engine.UI.Label
        Me.GridFormacion20 = New Solmicro.Expertis.Engine.UI.Grid
        Me.SLE_FFLC_Lugar20 = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblvFrmPrevencionFormacion20_Lugar = New Solmicro.Expertis.Engine.UI.Label
        Me.Label4 = New Solmicro.Expertis.Engine.UI.Label
        Me.SLE_FFLC_Empresa20 = New Solmicro.Expertis.Engine.UI.TextBox
        Me.UiCheck20 = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.UiCB_Formacion20 = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblvFrmPrevencionFormacion20_DescClaseFormacion = New Solmicro.Expertis.Engine.UI.Label
        Me.btnF20 = New Solmicro.Expertis.Engine.UI.Button
        Me.fr8 = New Solmicro.Expertis.Engine.UI.Frame
        Me.Frame1 = New Solmicro.Expertis.Engine.UI.Frame
        Me.txtvFrmPrevencionFormacion8_empresaforma = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblvFrmPrevencionFormacion8_empresaforma = New Solmicro.Expertis.Engine.UI.Label
        Me.ClB_FFLC_Fecha8 = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblvFrmPrevencionFormacion8_fecha = New Solmicro.Expertis.Engine.UI.Label
        Me.SLE_FFLC_Lugar8 = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblvFrmPrevencionFormacion8_lugar = New Solmicro.Expertis.Engine.UI.Label
        Me.TabPageTPC = New Janus.Windows.UI.Tab.UITabPage
        Me.Panel6 = New Solmicro.Expertis.Engine.UI.Panel
        Me.SLE_FTPC_Observaciones = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblvFrmPrevencionFormacionTPC_DesFormacion = New Solmicro.Expertis.Engine.UI.Label
        Me.chbvFrmPrevencionFormacionTPC_sntpc = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.SLE_FTPC_Contraseña = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblvFrmPrevencionFormacionTPC_password = New Solmicro.Expertis.Engine.UI.Label
        Me.SLE_FTPC_Usuario = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblvFrmPrevencionFormacionTPC_usuario = New Solmicro.Expertis.Engine.UI.Label
        Me.Label7 = New Solmicro.Expertis.Engine.UI.Label
        Me.Label6 = New Solmicro.Expertis.Engine.UI.Label
        Me.GridFiltroCurso = New Solmicro.Expertis.Engine.UI.Grid
        Me.GridTPC = New Solmicro.Expertis.Engine.UI.Grid
        Me.TabPageEpis = New Janus.Windows.UI.Tab.UITabPage
        Me.Panel7 = New Solmicro.Expertis.Engine.UI.Panel
        Me.Label8 = New Solmicro.Expertis.Engine.UI.Label
        Me.GridEpis_hist = New Solmicro.Expertis.Engine.UI.Grid
        Me.SLE_EPIS_Equipo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lbltbOperarioEpis_DesAdicional = New Solmicro.Expertis.Engine.UI.Label
        Me.UiCB_Epi = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lbltbOperarioEpis_DesEpis = New Solmicro.Expertis.Engine.UI.Label
        Me.ClB_EPIS_Fecha = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lbltbOperarioEpis_fecha = New Solmicro.Expertis.Engine.UI.Label
        Me.btnEPIS = New Solmicro.Expertis.Engine.UI.Button
        Me.tabAccidentes = New Janus.Windows.UI.Tab.UITabPage
        Me.Panel8 = New Solmicro.Expertis.Engine.UI.Panel
        Me.GridAccidentes = New Solmicro.Expertis.Engine.UI.Grid
        Me.btnAccidentesH = New Solmicro.Expertis.Engine.UI.Button
        Me.SLE_Accidentes_Seguimiento = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lbltbOperarioAccidentes_desSeguimiento = New Solmicro.Expertis.Engine.UI.Label
        Me.SLE_Accidentes_Descripcion = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lbltbOperarioAccidentes_descripcioninves = New Solmicro.Expertis.Engine.UI.Label
        Me.UiC_Accidentes_Requiere = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.UiC_Accidentes_Investigacion = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.UiC_Accidentes_Obra = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.ClB_Accidentes_Requiere = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lbltbOperarioAccidentes_fechaseg = New Solmicro.Expertis.Engine.UI.Label
        Me.GridCorreoAcc = New Solmicro.Expertis.Engine.UI.Grid
        Me.Ul_Accidentes_obra = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.AdvS_Accidentes_Obra = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lbltbOperarioAccidentes_codobra = New Solmicro.Expertis.Engine.UI.Label
        Me.UiCB_AccidentesJ = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lbltbOperarioAccidentes_JefeProd = New Solmicro.Expertis.Engine.UI.Label
        Me.UiCB_AccidentesE = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lbl_ACC_Encargado = New Solmicro.Expertis.Engine.UI.Label
        Me.SLE_Accidentes_Lugar = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lbltbOperarioAccidentes_Lugar = New Solmicro.Expertis.Engine.UI.Label
        Me.UiC_Accidentes_Recaida = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.RB_Accidentes_SinBaja = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.rbttbOperarioAccidentes_tipo2 = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.RB_Accidentes_Grave = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.RB_Accidentes_leve = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.clbtbOperarioAccidentes_falta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lbltbOperarioAccidentes_falta = New Solmicro.Expertis.Engine.UI.Label
        Me.sle_Accidentes_Dias = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lbltbOperarioAccidentes_nDiasBaja = New Solmicro.Expertis.Engine.UI.Label
        Me.clbtbOperarioAccidentes_fNotificacion = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lbltbOperarioAccidentes_fNotificacion = New Solmicro.Expertis.Engine.UI.Label
        Me.ClB_Accidentes_Fbaja = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lbltbOperarioAccidentes_fbaja = New Solmicro.Expertis.Engine.UI.Label
        Me.ClB_Accidentes_FAccidente = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lbltbOperarioAccidentes_faccidente = New Solmicro.Expertis.Engine.UI.Label
        Me.btnAccidentessn = New Solmicro.Expertis.Engine.UI.Button
        Me.tabNotificaciones = New Janus.Windows.UI.Tab.UITabPage
        Me.Panel9 = New Solmicro.Expertis.Engine.UI.Panel
        Me.GridNotificacion = New Solmicro.Expertis.Engine.UI.Grid
        Me.btnNotificacionesN = New Solmicro.Expertis.Engine.UI.Button
        Me.SLE_Notificaciones_Tipo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lbltbOperarioNotificacion_tipo = New Solmicro.Expertis.Engine.UI.Label
        Me.SLE_Notificaciones_Observaciones = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lbltbOperarioNotificacion_Observaciones = New Solmicro.Expertis.Engine.UI.Label
        Me.Frame2 = New Solmicro.Expertis.Engine.UI.Frame
        Me.RB_Notificaciones_MuyGrave = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.RB_Notificaciones_Grave = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.RB_Notificaciones_leve = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.UiCB_NotificacionesJ = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lbltbOperarioNotificacion_JefeProd = New Solmicro.Expertis.Engine.UI.Label
        Me.UiC_Notificaciones_Recibida = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.UiCB_NotificacionesS = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lbltbOperarioNotificacion_DescSancion = New Solmicro.Expertis.Engine.UI.Label
        Me.UiCB_NotificacionesE = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lbltbOperarioNotificacion_Encargado = New Solmicro.Expertis.Engine.UI.Label
        Me.UL_Notificaciones_Obra = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.AdS_Notificaciones_Obra = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lbltbOperarioNotificacion_idobra = New Solmicro.Expertis.Engine.UI.Label
        Me.ClB_Notificaciones_Fecha = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lbltbOperarioNotificacion_fechaSeguimiento = New Solmicro.Expertis.Engine.UI.Label
        Me.btnNotificacionesNuevo = New Solmicro.Expertis.Engine.UI.Button
        Me.tabBajasCC = New Janus.Windows.UI.Tab.UITabPage
        Me.GridBajas = New Solmicro.Expertis.Engine.UI.Grid
        Me.btnBajasH = New Solmicro.Expertis.Engine.UI.Button
        Me.sle_bajas_descripcion = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lbltbOperarioAlertas_descripcion = New Solmicro.Expertis.Engine.UI.Label
        Me.sle_bajas_seguimiento = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lbltbOperarioAlertas_seguimiento = New Solmicro.Expertis.Engine.UI.Label
        Me.GridCorreoBajas = New Solmicro.Expertis.Engine.UI.Grid
        Me.UiCB_BajasE = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lbltbOperarioAlertas_encargado = New Solmicro.Expertis.Engine.UI.Label
        Me.UiCheck_bajas_baja = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.ulbDescObra = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.AdvS_Bajas_Obra = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lbltbOperarioAlertas_lugar = New Solmicro.Expertis.Engine.UI.Label
        Me.ClB_Bajas_Email = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lbltbOperarioAlertas_fEmail = New Solmicro.Expertis.Engine.UI.Label
        Me.ClB_Bajas_conf = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lbltbOperarioAlertas_fConf = New Solmicro.Expertis.Engine.UI.Label
        Me.sle_Bajas_Dias = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lbltbOperarioAlertas_nDias = New Solmicro.Expertis.Engine.UI.Label
        Me.ClB_Bajas_Alta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lbltbOperarioAlertas_fAlta = New Solmicro.Expertis.Engine.UI.Label
        Me.ClB_Bajas_Baja = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lbltbOperarioAlertas_fBaja = New Solmicro.Expertis.Engine.UI.Label
        Me.btnBajasN = New Solmicro.Expertis.Engine.UI.Button
        CType(Me.ToolBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.suspendlayout()
        Me.Panel1.suspendlayout()
        CType(Me.tabOperarioPrev, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabOperarioPrev.SuspendLayout()
        Me.tabReconocimiento.SuspendLayout()
        Me.Panel2.suspendlayout()
        CType(Me.GridReconocimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridCorreoReconocimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPuestos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabFormacion.SuspendLayout()
        CType(Me.Tab2Formacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tab2Formacion.SuspendLayout()
        Me.UiTabPageFInterna.SuspendLayout()
        Me.Panel3.suspendlayout()
        CType(Me.GridFInterna_hist, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UICB_FormacionI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiTabPageFExterna.SuspendLayout()
        Me.Panel4.suspendlayout()
        CType(Me.GridFExterna_hist, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCB_FormacionE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiTabPageFormFLC.SuspendLayout()
        Me.Panel5.suspendlayout()
        Me.Fr50.SuspendLayout()
        CType(Me.GridFormacion50, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCB_Formacion50, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Fr20.SuspendLayout()
        CType(Me.GridFormacion20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCB_Formacion20, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fr8.SuspendLayout()
        Me.TabPageTPC.SuspendLayout()
        Me.Panel6.suspendlayout()
        CType(Me.GridFiltroCurso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridTPC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageEpis.SuspendLayout()
        Me.Panel7.suspendlayout()
        CType(Me.GridEpis_hist, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCB_Epi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabAccidentes.SuspendLayout()
        Me.Panel8.suspendlayout()
        CType(Me.GridAccidentes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridCorreoAcc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCB_AccidentesJ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCB_AccidentesE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabNotificaciones.SuspendLayout()
        Me.Panel9.suspendlayout()
        CType(Me.GridNotificacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame2.SuspendLayout()
        CType(Me.UiCB_NotificacionesJ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCB_NotificacionesS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCB_NotificacionesE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabBajasCC.SuspendLayout()
        CType(Me.GridBajas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridCorreoBajas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCB_BajasE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolBar
        '
        Me.ToolBar.Size = New System.Drawing.Size(721, 39)
        '
        'MenuBar
        '
        Me.MenuBar.Location = New System.Drawing.Point(0, 39)
        Me.MenuBar.Size = New System.Drawing.Size(504, 26)
        '
        'MainPanel
        '
        Me.MainPanel.Controls.Add(Me.tabOperarioPrev)
        Me.MainPanel.Controls.Add(Me.Panel1)
        Me.MainPanel.Size = New System.Drawing.Size(946, 688)
        '
        'txtIDOperario
        '
        Me.txtIDOperario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TryDataBinding(txtIDOperario, New System.Windows.Forms.Binding("Text", Me, "IDOperario", True))
        Me.txtIDOperario.DisabledBackColor = System.Drawing.Color.White
        Me.txtIDOperario.Enabled = False
        Me.txtIDOperario.Location = New System.Drawing.Point(96, 16)
        Me.txtIDOperario.Name = "txtIDOperario"
        Me.txtIDOperario.Size = New System.Drawing.Size(57, 21)
        Me.txtIDOperario.TabIndex = 0
        '
        'lblIDOperario
        '
        Me.lblIDOperario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblIDOperario.Location = New System.Drawing.Point(7, 20)
        Me.lblIDOperario.Name = "lblIDOperario"
        Me.lblIDOperario.Size = New System.Drawing.Size(71, 13)
        Me.lblIDOperario.TabIndex = 1
        Me.lblIDOperario.Text = "IDOperario"
        '
        'txtDescOperario
        '
        Me.txtDescOperario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TryDataBinding(txtDescOperario, New System.Windows.Forms.Binding("Text", Me, "DescOperario", True))
        Me.txtDescOperario.DisabledBackColor = System.Drawing.Color.White
        Me.txtDescOperario.Enabled = False
        Me.txtDescOperario.Location = New System.Drawing.Point(159, 16)
        Me.txtDescOperario.Name = "txtDescOperario"
        Me.txtDescOperario.Size = New System.Drawing.Size(588, 21)
        Me.txtDescOperario.TabIndex = 2
        '
        'txtTipoContrato
        '
        Me.txtTipoContrato.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TryDataBinding(txtTipoContrato, New System.Windows.Forms.Binding("Text", Me, "TipoContrato", True))
        Me.txtTipoContrato.DisabledBackColor = System.Drawing.Color.White
        Me.txtTipoContrato.Enabled = False
        Me.txtTipoContrato.Location = New System.Drawing.Point(816, 16)
        Me.txtTipoContrato.Name = "txtTipoContrato"
        Me.txtTipoContrato.Size = New System.Drawing.Size(121, 21)
        Me.txtTipoContrato.TabIndex = 3
        '
        'lblTipoContrato
        '
        Me.lblTipoContrato.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTipoContrato.Location = New System.Drawing.Point(753, 20)
        Me.lblTipoContrato.Name = "lblTipoContrato"
        Me.lblTipoContrato.Size = New System.Drawing.Size(57, 13)
        Me.lblTipoContrato.TabIndex = 4
        Me.lblTipoContrato.Text = "Contrato"
        '
        'clbFechaAlta
        '
        Me.clbFechaAlta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TryDataBinding(clbFechaAlta, New System.Windows.Forms.Binding("BindableValue", Me, "FechaAlta", True))
        Me.clbFechaAlta.DisabledBackColor = System.Drawing.Color.White
        Me.clbFechaAlta.Enabled = False
        Me.clbFechaAlta.Location = New System.Drawing.Point(96, 41)
        Me.clbFechaAlta.Name = "clbFechaAlta"
        Me.clbFechaAlta.Size = New System.Drawing.Size(121, 21)
        Me.clbFechaAlta.TabIndex = 5
        '
        'lblFechaAlta
        '
        Me.lblFechaAlta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblFechaAlta.Location = New System.Drawing.Point(7, 45)
        Me.lblFechaAlta.Name = "lblFechaAlta"
        Me.lblFechaAlta.Size = New System.Drawing.Size(66, 13)
        Me.lblFechaAlta.TabIndex = 6
        Me.lblFechaAlta.Text = "Fecha Alta"
        '
        'UiCheckBox1
        '
        Me.UiCheckBox1.Enabled = False
        Me.UiCheckBox1.Location = New System.Drawing.Point(234, 41)
        Me.UiCheckBox1.Name = "UiCheckBox1"
        Me.UiCheckBox1.Size = New System.Drawing.Size(66, 21)
        Me.UiCheckBox1.TabIndex = 7
        Me.UiCheckBox1.Text = "Activo"
        '
        'clbFecha_Baja
        '
        Me.clbFecha_Baja.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TryDataBinding(clbFecha_Baja, New System.Windows.Forms.Binding("BindableValue", Me, "Fecha_Baja", True))
        Me.clbFecha_Baja.DisabledBackColor = System.Drawing.Color.White
        Me.clbFecha_Baja.Enabled = False
        Me.clbFecha_Baja.Location = New System.Drawing.Point(385, 41)
        Me.clbFecha_Baja.Name = "clbFecha_Baja"
        Me.clbFecha_Baja.Size = New System.Drawing.Size(121, 21)
        Me.clbFecha_Baja.TabIndex = 8
        '
        'lblFecha_Baja
        '
        Me.lblFecha_Baja.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblFecha_Baja.Location = New System.Drawing.Point(306, 45)
        Me.lblFecha_Baja.Name = "lblFecha_Baja"
        Me.lblFecha_Baja.Size = New System.Drawing.Size(70, 13)
        Me.lblFecha_Baja.TabIndex = 9
        Me.lblFecha_Baja.Text = "Fecha Baja"
        '
        'clbFecha_Nacimiento
        '
        Me.clbFecha_Nacimiento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TryDataBinding(clbFecha_Nacimiento, New System.Windows.Forms.Binding("BindableValue", Me, "Fecha_Nacimiento", True))
        Me.clbFecha_Nacimiento.DisabledBackColor = System.Drawing.Color.White
        Me.clbFecha_Nacimiento.Enabled = False
        Me.clbFecha_Nacimiento.Location = New System.Drawing.Point(636, 41)
        Me.clbFecha_Nacimiento.Name = "clbFecha_Nacimiento"
        Me.clbFecha_Nacimiento.Size = New System.Drawing.Size(121, 21)
        Me.clbFecha_Nacimiento.TabIndex = 10
        '
        'lblFecha_Nacimiento
        '
        Me.lblFecha_Nacimiento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblFecha_Nacimiento.Location = New System.Drawing.Point(521, 45)
        Me.lblFecha_Nacimiento.Name = "lblFecha_Nacimiento"
        Me.lblFecha_Nacimiento.Size = New System.Drawing.Size(107, 13)
        Me.lblFecha_Nacimiento.TabIndex = 11
        Me.lblFecha_Nacimiento.Text = "Fecha Nacimiento"
        '
        'txtDNI
        '
        Me.txtDNI.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TryDataBinding(txtDNI, New System.Windows.Forms.Binding("Text", Me, "DNI", True))
        Me.txtDNI.DisabledBackColor = System.Drawing.Color.White
        Me.txtDNI.Enabled = False
        Me.txtDNI.Location = New System.Drawing.Point(96, 68)
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(121, 21)
        Me.txtDNI.TabIndex = 12
        '
        'lblDNI
        '
        Me.lblDNI.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDNI.Location = New System.Drawing.Point(7, 72)
        Me.lblDNI.Name = "lblDNI"
        Me.lblDNI.Size = New System.Drawing.Size(29, 13)
        Me.lblDNI.TabIndex = 13
        Me.lblDNI.Text = "DNI"
        '
        'txtN_Social
        '
        Me.txtN_Social.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TryDataBinding(txtN_Social, New System.Windows.Forms.Binding("Text", Me, "N_Social", True))
        Me.txtN_Social.DisabledBackColor = System.Drawing.Color.White
        Me.txtN_Social.Enabled = False
        Me.txtN_Social.Location = New System.Drawing.Point(296, 68)
        Me.txtN_Social.Name = "txtN_Social"
        Me.txtN_Social.Size = New System.Drawing.Size(210, 21)
        Me.txtN_Social.TabIndex = 14
        '
        'lblN_Social
        '
        Me.lblN_Social.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblN_Social.Location = New System.Drawing.Point(219, 72)
        Me.lblN_Social.Name = "lblN_Social"
        Me.lblN_Social.Size = New System.Drawing.Size(71, 13)
        Me.lblN_Social.TabIndex = 15
        Me.lblN_Social.Text = "Seg. Social"
        '
        'txtNifPortu
        '
        Me.txtNifPortu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TryDataBinding(txtNifPortu, New System.Windows.Forms.Binding("Text", Me, "NifPortu", True))
        Me.txtNifPortu.DisabledBackColor = System.Drawing.Color.White
        Me.txtNifPortu.Enabled = False
        Me.txtNifPortu.Location = New System.Drawing.Point(595, 68)
        Me.txtNifPortu.Name = "txtNifPortu"
        Me.txtNifPortu.Size = New System.Drawing.Size(121, 21)
        Me.txtNifPortu.TabIndex = 16
        '
        'lblNifPortu
        '
        Me.lblNifPortu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblNifPortu.Location = New System.Drawing.Point(521, 72)
        Me.lblNifPortu.Name = "lblNifPortu"
        Me.lblNifPortu.Size = New System.Drawing.Size(52, 13)
        Me.lblNifPortu.TabIndex = 17
        Me.lblNifPortu.Text = "NifPortu"
        '
        'txtDireccion
        '
        Me.txtDireccion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TryDataBinding(txtDireccion, New System.Windows.Forms.Binding("Text", Me, "Direccion", True))
        Me.txtDireccion.DisabledBackColor = System.Drawing.Color.White
        Me.txtDireccion.Enabled = False
        Me.txtDireccion.Location = New System.Drawing.Point(96, 95)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(841, 21)
        Me.txtDireccion.TabIndex = 18
        '
        'lblDireccion
        '
        Me.lblDireccion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDireccion.Location = New System.Drawing.Point(7, 99)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(60, 13)
        Me.lblDireccion.TabIndex = 19
        Me.lblDireccion.Text = "Direccion"
        '
        'txtPoblacion
        '
        Me.txtPoblacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TryDataBinding(txtPoblacion, New System.Windows.Forms.Binding("Text", Me, "Poblacion", True))
        Me.txtPoblacion.DisabledBackColor = System.Drawing.Color.White
        Me.txtPoblacion.Enabled = False
        Me.txtPoblacion.Location = New System.Drawing.Point(290, 123)
        Me.txtPoblacion.Name = "txtPoblacion"
        Me.txtPoblacion.Size = New System.Drawing.Size(121, 21)
        Me.txtPoblacion.TabIndex = 20
        '
        'lblPoblacion
        '
        Me.lblPoblacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblPoblacion.Location = New System.Drawing.Point(223, 127)
        Me.lblPoblacion.Name = "lblPoblacion"
        Me.lblPoblacion.Size = New System.Drawing.Size(61, 13)
        Me.lblPoblacion.TabIndex = 21
        Me.lblPoblacion.Text = "Poblacion"
        '
        'txtProvincia
        '
        Me.txtProvincia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TryDataBinding(txtProvincia, New System.Windows.Forms.Binding("Text", Me.advIDPais, "DescPais", True))
        Me.txtProvincia.DisabledBackColor = System.Drawing.Color.White
        Me.txtProvincia.Enabled = False
        Me.txtProvincia.Location = New System.Drawing.Point(482, 122)
        Me.txtProvincia.Name = "txtProvincia"
        Me.txtProvincia.Size = New System.Drawing.Size(121, 21)
        Me.txtProvincia.TabIndex = 22
        '
        'lblProvincia
        '
        Me.lblProvincia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblProvincia.Location = New System.Drawing.Point(417, 127)
        Me.lblProvincia.Name = "lblProvincia"
        Me.lblProvincia.Size = New System.Drawing.Size(59, 13)
        Me.lblProvincia.TabIndex = 23
        Me.lblProvincia.Text = "Provincia"
        '
        'advCodPostal
        '
        Me.advCodPostal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TryDataBinding(advCodPostal, New System.Windows.Forms.Binding("Text", Me, "CodPostal", True))
        Me.advCodPostal.DisabledBackColor = System.Drawing.Color.White
        Me.advCodPostal.DisplayField = "CodPostal"
        Me.advCodPostal.Enabled = False
        Me.advCodPostal.EntityName = "Poblacion"
        Me.advCodPostal.Location = New System.Drawing.Point(96, 122)
        Me.advCodPostal.Name = "advCodPostal"
        Me.advCodPostal.PrimaryDataFields = "CodPostal"
        Me.advCodPostal.SecondaryDataFields = "CodPostal"
        Me.advCodPostal.Size = New System.Drawing.Size(121, 23)
        Me.advCodPostal.TabIndex = 24
        Me.advCodPostal.ViewName = "tbMaestroPoblacion"
        '
        'lblCodPostal
        '
        Me.lblCodPostal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCodPostal.Location = New System.Drawing.Point(7, 127)
        Me.lblCodPostal.Name = "lblCodPostal"
        Me.lblCodPostal.Size = New System.Drawing.Size(64, 13)
        Me.lblCodPostal.TabIndex = 25
        Me.lblCodPostal.Text = "CodPostal"
        '
        'advIDPais
        '
        Me.advIDPais.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TryDataBinding(advIDPais, New System.Windows.Forms.Binding("Text", Me, "IDPais", True))
        Me.advIDPais.DisabledBackColor = System.Drawing.Color.White
        Me.advIDPais.DisplayField = "IDPais"
        Me.advIDPais.Enabled = False
        Me.advIDPais.EntityName = "Pais"
        Me.advIDPais.Location = New System.Drawing.Point(645, 120)
        Me.advIDPais.Name = "advIDPais"
        Me.advIDPais.PrimaryDataFields = "IDPais"
        Me.advIDPais.SecondaryDataFields = "IDPais"
        Me.advIDPais.Size = New System.Drawing.Size(98, 23)
        Me.advIDPais.TabIndex = 26
        Me.advIDPais.ViewName = "tbMaestroPais"
        '
        'lblIDPais
        '
        Me.lblIDPais.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblIDPais.Location = New System.Drawing.Point(609, 127)
        Me.lblIDPais.Name = "lblIDPais"
        Me.lblIDPais.Size = New System.Drawing.Size(30, 13)
        Me.lblIDPais.TabIndex = 27
        Me.lblIDPais.Text = "Pais"
        '
        'ulbDescPais
        '
        Me.TryDataBinding(ulbDescPais, New System.Windows.Forms.Binding("Text", Me, "DescPais", True))
        Me.ulbDescPais.Location = New System.Drawing.Point(749, 130)
        Me.ulbDescPais.Name = "ulbDescPais"
        Me.ulbDescPais.Size = New System.Drawing.Size(188, 13)
        Me.ulbDescPais.TabIndex = 28
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ulbDescDepartamento)
        Me.Panel1.Controls.Add(Me.advIDDepartamento)
        Me.Panel1.Controls.Add(Me.lblIDDepartamento)
        Me.Panel1.Controls.Add(Me.ulbDescOficio)
        Me.Panel1.Controls.Add(Me.advIDOficio)
        Me.Panel1.Controls.Add(Me.lblIDOficio)
        Me.Panel1.Controls.Add(Me.ulbDescCategoria)
        Me.Panel1.Controls.Add(Me.txtEmail)
        Me.Panel1.Controls.Add(Me.lblEmail)
        Me.Panel1.Controls.Add(Me.txtFax)
        Me.Panel1.Controls.Add(Me.lblFax)
        Me.Panel1.Controls.Add(Me.txtTelefono)
        Me.Panel1.Controls.Add(Me.lblTelefono)
        Me.Panel1.Controls.Add(Me.advIDCategoria)
        Me.Panel1.Controls.Add(Me.lblIDCategoria)
        Me.Panel1.Controls.Add(Me.lblIDOperario)
        Me.Panel1.Controls.Add(Me.ulbDescPais)
        Me.Panel1.Controls.Add(Me.txtIDOperario)
        Me.Panel1.Controls.Add(Me.advIDPais)
        Me.Panel1.Controls.Add(Me.txtDescOperario)
        Me.Panel1.Controls.Add(Me.lblIDPais)
        Me.Panel1.Controls.Add(Me.lblTipoContrato)
        Me.Panel1.Controls.Add(Me.advCodPostal)
        Me.Panel1.Controls.Add(Me.txtTipoContrato)
        Me.Panel1.Controls.Add(Me.lblCodPostal)
        Me.Panel1.Controls.Add(Me.lblFechaAlta)
        Me.Panel1.Controls.Add(Me.txtProvincia)
        Me.Panel1.Controls.Add(Me.clbFechaAlta)
        Me.Panel1.Controls.Add(Me.lblProvincia)
        Me.Panel1.Controls.Add(Me.UiCheckBox1)
        Me.Panel1.Controls.Add(Me.txtPoblacion)
        Me.Panel1.Controls.Add(Me.lblFecha_Baja)
        Me.Panel1.Controls.Add(Me.lblPoblacion)
        Me.Panel1.Controls.Add(Me.clbFecha_Baja)
        Me.Panel1.Controls.Add(Me.txtDireccion)
        Me.Panel1.Controls.Add(Me.lblFecha_Nacimiento)
        Me.Panel1.Controls.Add(Me.lblDireccion)
        Me.Panel1.Controls.Add(Me.clbFecha_Nacimiento)
        Me.Panel1.Controls.Add(Me.txtNifPortu)
        Me.Panel1.Controls.Add(Me.lblDNI)
        Me.Panel1.Controls.Add(Me.lblNifPortu)
        Me.Panel1.Controls.Add(Me.txtDNI)
        Me.Panel1.Controls.Add(Me.txtN_Social)
        Me.Panel1.Controls.Add(Me.lblN_Social)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(946, 239)
        Me.Panel1.TabIndex = 29
        '
        'ulbDescDepartamento
        '
        Me.TryDataBinding(ulbDescDepartamento, New System.Windows.Forms.Binding("Text", Me, "DescDepartamento", True))
        Me.ulbDescDepartamento.Location = New System.Drawing.Point(223, 207)
        Me.ulbDescDepartamento.Name = "ulbDescDepartamento"
        Me.ulbDescDepartamento.Size = New System.Drawing.Size(587, 23)
        Me.ulbDescDepartamento.TabIndex = 43
        '
        'advIDDepartamento
        '
        Me.TryDataBinding(advIDDepartamento, New System.Windows.Forms.Binding("Text", Me, "IDDepartamento", True))
        Me.advIDDepartamento.DisabledBackColor = System.Drawing.Color.White
        Me.advIDDepartamento.Enabled = False
        Me.advIDDepartamento.EntityName = "Departamento"
        Me.advIDDepartamento.Location = New System.Drawing.Point(96, 207)
        Me.advIDDepartamento.Name = "advIDDepartamento"
        Me.advIDDepartamento.PrimaryDataFields = "IDDepartamento"
        Me.advIDDepartamento.SecondaryDataFields = "IDDepartamento"
        Me.advIDDepartamento.Size = New System.Drawing.Size(121, 23)
        Me.advIDDepartamento.TabIndex = 41
        '
        'lblIDDepartamento
        '
        Me.lblIDDepartamento.Location = New System.Drawing.Point(8, 213)
        Me.lblIDDepartamento.Name = "lblIDDepartamento"
        Me.lblIDDepartamento.Size = New System.Drawing.Size(89, 13)
        Me.lblIDDepartamento.TabIndex = 42
        Me.lblIDDepartamento.Text = "Departamento"
        '
        'ulbDescOficio
        '
        Me.TryDataBinding(ulbDescOficio, New System.Windows.Forms.Binding("Text", Me, "DescOficio", True))
        Me.ulbDescOficio.Location = New System.Drawing.Point(610, 178)
        Me.ulbDescOficio.Name = "ulbDescOficio"
        Me.ulbDescOficio.Size = New System.Drawing.Size(200, 23)
        Me.ulbDescOficio.TabIndex = 40
        '
        'advIDOficio
        '
        Me.TryDataBinding(advIDOficio, New System.Windows.Forms.Binding("Text", Me, "IDOficio", True))
        Me.advIDOficio.DisabledBackColor = System.Drawing.Color.White
        Me.advIDOficio.Enabled = False
        Me.advIDOficio.EntityName = "Oficio"
        Me.advIDOficio.Location = New System.Drawing.Point(482, 178)
        Me.advIDOficio.Name = "advIDOficio"
        Me.advIDOficio.PrimaryDataFields = "IDOficio"
        Me.advIDOficio.SecondaryDataFields = "IDOficio"
        Me.advIDOficio.Size = New System.Drawing.Size(121, 23)
        Me.advIDOficio.TabIndex = 38
        '
        'lblIDOficio
        '
        Me.lblIDOficio.Location = New System.Drawing.Point(417, 183)
        Me.lblIDOficio.Name = "lblIDOficio"
        Me.lblIDOficio.Size = New System.Drawing.Size(39, 13)
        Me.lblIDOficio.TabIndex = 39
        Me.lblIDOficio.Text = "Oficio"
        '
        'ulbDescCategoria
        '
        Me.TryDataBinding(ulbDescCategoria, New System.Windows.Forms.Binding("Text", Me, "DescCategoria", True))
        Me.ulbDescCategoria.Location = New System.Drawing.Point(223, 178)
        Me.ulbDescCategoria.Name = "ulbDescCategoria"
        Me.ulbDescCategoria.Size = New System.Drawing.Size(188, 23)
        Me.ulbDescCategoria.TabIndex = 37
        '
        'txtEmail
        '
        Me.TryDataBinding(txtEmail, New System.Windows.Forms.Binding("Text", Me, "Email", True))
        Me.txtEmail.DisabledBackColor = System.Drawing.Color.White
        Me.txtEmail.Enabled = False
        Me.txtEmail.Location = New System.Drawing.Point(482, 151)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(261, 21)
        Me.txtEmail.TabIndex = 35
        '
        'lblEmail
        '
        Me.lblEmail.Location = New System.Drawing.Point(417, 155)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(38, 13)
        Me.lblEmail.TabIndex = 36
        Me.lblEmail.Text = "Email"
        '
        'txtFax
        '
        Me.TryDataBinding(txtFax, New System.Windows.Forms.Binding("Text", Me, "Fax", True))
        Me.txtFax.DisabledBackColor = System.Drawing.Color.White
        Me.txtFax.Enabled = False
        Me.txtFax.Location = New System.Drawing.Point(290, 151)
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Size = New System.Drawing.Size(121, 21)
        Me.txtFax.TabIndex = 33
        '
        'lblFax
        '
        Me.lblFax.Location = New System.Drawing.Point(223, 155)
        Me.lblFax.Name = "lblFax"
        Me.lblFax.Size = New System.Drawing.Size(26, 13)
        Me.lblFax.TabIndex = 34
        Me.lblFax.Text = "Fax"
        '
        'txtTelefono
        '
        Me.TryDataBinding(txtTelefono, New System.Windows.Forms.Binding("Text", Me, "Telefono", True))
        Me.txtTelefono.DisabledBackColor = System.Drawing.Color.White
        Me.txtTelefono.Enabled = False
        Me.txtTelefono.Location = New System.Drawing.Point(96, 151)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(121, 21)
        Me.txtTelefono.TabIndex = 31
        '
        'lblTelefono
        '
        Me.lblTelefono.Location = New System.Drawing.Point(7, 155)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(55, 13)
        Me.lblTelefono.TabIndex = 32
        Me.lblTelefono.Text = "Telefono"
        '
        'advIDCategoria
        '
        Me.TryDataBinding(advIDCategoria, New System.Windows.Forms.Binding("Text", Me, "IDCategoria", True))
        Me.advIDCategoria.DisabledBackColor = System.Drawing.Color.White
        Me.advIDCategoria.Enabled = False
        Me.advIDCategoria.EntityName = "Categoria"
        Me.advIDCategoria.Location = New System.Drawing.Point(96, 178)
        Me.advIDCategoria.Name = "advIDCategoria"
        Me.advIDCategoria.PrimaryDataFields = "IDCategoria"
        Me.advIDCategoria.SecondaryDataFields = "IDCategoria"
        Me.advIDCategoria.Size = New System.Drawing.Size(121, 23)
        Me.advIDCategoria.TabIndex = 29
        '
        'lblIDCategoria
        '
        Me.lblIDCategoria.Location = New System.Drawing.Point(7, 183)
        Me.lblIDCategoria.Name = "lblIDCategoria"
        Me.lblIDCategoria.Size = New System.Drawing.Size(63, 13)
        Me.lblIDCategoria.TabIndex = 30
        Me.lblIDCategoria.Text = "Categoria"
        '
        'tabOperarioPrev
        '
        Me.tabOperarioPrev.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.tabOperarioPrev.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabOperarioPrev.Location = New System.Drawing.Point(0, 239)
        Me.tabOperarioPrev.Name = "tabOperarioPrev"
        Me.tabOperarioPrev.Size = New System.Drawing.Size(946, 449)
        Me.tabOperarioPrev.TabIndex = 30
        Me.tabOperarioPrev.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.tabReconocimiento, Me.tabFormacion, Me.tabAccidentes, Me.tabNotificaciones, Me.tabBajasCC})
        Me.tabOperarioPrev.UseThemes = True
        '
        'tabReconocimiento
        '
        Me.tabReconocimiento.Controls.Add(Me.Panel2)
        Me.tabReconocimiento.Location = New System.Drawing.Point(1, 21)
        Me.tabReconocimiento.Name = "tabReconocimiento"
        Me.tabReconocimiento.Size = New System.Drawing.Size(944, 427)
        Me.tabReconocimiento.TabStop = True
        Me.tabReconocimiento.Text = "Reconocimiento"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.RB_Reconocimiento_ap)
        Me.Panel2.Controls.Add(Me.brnRecon)
        Me.Panel2.Controls.Add(Me.GridReconocimiento)
        Me.Panel2.Controls.Add(Me.lbltbOperarioReconocimiento_Lugar)
        Me.Panel2.Controls.Add(Me.btnRecoh)
        Me.Panel2.Controls.Add(Me.txtLugarReconocimiento)
        Me.Panel2.Controls.Add(Me.GridCorreoReconocimiento)
        Me.Panel2.Controls.Add(Me.RB_Reconocimiento_no)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txtdesLimitacion)
        Me.Panel2.Controls.Add(Me.RB_Reconocimiento_Apto)
        Me.Panel2.Controls.Add(Me.UICheckLimitaciones)
        Me.Panel2.Controls.Add(Me.lbltbOperarioReconocimiento_Fecha)
        Me.Panel2.Controls.Add(Me.lbltbOperarioReconocimiento_snLimitacion)
        Me.Panel2.Controls.Add(Me.clbFechaReconocimiento)
        Me.Panel2.Controls.Add(Me.txtdesSensible)
        Me.Panel2.Controls.Add(Me.GridPuestos)
        Me.Panel2.Controls.Add(Me.lbltbOperarioReconocimiento_desSensible)
        Me.Panel2.Controls.Add(Me.lbltbOperarioReconocimiento_snSensible)
        Me.Panel2.Controls.Add(Me.clbtbOperarioReconocimiento_nDiasAviso)
        Me.Panel2.Controls.Add(Me.UiCheckSensible)
        Me.Panel2.Controls.Add(Me.lbltbOperarioReconocimiento_nDiasAviso)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(944, 427)
        Me.Panel2.TabIndex = 22
        '
        'RB_Reconocimiento_ap
        '
        Me.RB_Reconocimiento_ap.Location = New System.Drawing.Point(85, 3)
        Me.RB_Reconocimiento_ap.Name = "RB_Reconocimiento_ap"
        Me.RB_Reconocimiento_ap.Size = New System.Drawing.Size(121, 23)
        Me.RB_Reconocimiento_ap.TabIndex = 3
        Me.RB_Reconocimiento_ap.Text = "Apto Provisional"
        '
        'brnRecon
        '
        Me.brnRecon.Location = New System.Drawing.Point(12, 208)
        Me.brnRecon.Name = "brnRecon"
        Me.brnRecon.Size = New System.Drawing.Size(104, 23)
        Me.brnRecon.TabIndex = 5
        Me.brnRecon.Text = "GUARDAR"
        '
        'GridReconocimiento
        '
        Me.GridReconocimiento.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridReconocimiento.ColumnAutoResize = True
        GridReconocimiento_DesignTimeLayout.LayoutString = resources.GetString("GridReconocimiento_DesignTimeLayout.LayoutString")
        Me.GridReconocimiento.DesignTimeLayout = GridReconocimiento_DesignTimeLayout
        Me.GridReconocimiento.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridReconocimiento.EntityName = "PrevencionReconocimiento"
        Me.GridReconocimiento.FrozenColumns = 3
        Me.GridReconocimiento.Location = New System.Drawing.Point(10, 266)
        Me.GridReconocimiento.Name = "GridReconocimiento"
        Me.GridReconocimiento.PrimaryDataFields = "IDOperario"
        Me.GridReconocimiento.SecondaryDataFields = "IdOperario"
        Me.GridReconocimiento.Size = New System.Drawing.Size(865, 154)
        Me.GridReconocimiento.TabIndex = 21
        Me.GridReconocimiento.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridReconocimiento.ViewName = "vFrmPrevencionReconocimiento_hist_group"
        '
        'lbltbOperarioReconocimiento_Lugar
        '
        Me.lbltbOperarioReconocimiento_Lugar.Location = New System.Drawing.Point(4, 36)
        Me.lbltbOperarioReconocimiento_Lugar.Name = "lbltbOperarioReconocimiento_Lugar"
        Me.lbltbOperarioReconocimiento_Lugar.Size = New System.Drawing.Size(39, 13)
        Me.lbltbOperarioReconocimiento_Lugar.TabIndex = 1
        Me.lbltbOperarioReconocimiento_Lugar.Text = "Lugar"
        '
        'btnRecoh
        '
        Me.btnRecoh.Location = New System.Drawing.Point(12, 237)
        Me.btnRecoh.Name = "btnRecoh"
        Me.btnRecoh.Size = New System.Drawing.Size(104, 23)
        Me.btnRecoh.TabIndex = 20
        Me.btnRecoh.Text = "Ver Histórico"
        '
        'txtLugarReconocimiento
        '
        Me.txtLugarReconocimiento.DisabledBackColor = System.Drawing.Color.White
        Me.txtLugarReconocimiento.Location = New System.Drawing.Point(49, 32)
        Me.txtLugarReconocimiento.Name = "txtLugarReconocimiento"
        Me.txtLugarReconocimiento.Size = New System.Drawing.Size(264, 21)
        Me.txtLugarReconocimiento.TabIndex = 0
        '
        'GridCorreoReconocimiento
        '
        Me.GridCorreoReconocimiento.ColumnAutoResize = True
        GridCorreoReconocimiento_DesignTimeLayout.LayoutString = resources.GetString("GridCorreoReconocimiento_DesignTimeLayout.LayoutString")
        Me.GridCorreoReconocimiento.DesignTimeLayout = GridCorreoReconocimiento_DesignTimeLayout
        Me.GridCorreoReconocimiento.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridCorreoReconocimiento.EntityName = "PrevencionEmail"
        Me.GridCorreoReconocimiento.Location = New System.Drawing.Point(625, 113)
        Me.GridCorreoReconocimiento.Name = "GridCorreoReconocimiento"
        Me.GridCorreoReconocimiento.PrimaryDataFields = "IDOperario"
        Me.GridCorreoReconocimiento.SecondaryDataFields = "idOperario"
        Me.GridCorreoReconocimiento.Size = New System.Drawing.Size(300, 99)
        Me.GridCorreoReconocimiento.TabIndex = 19
        Me.GridCorreoReconocimiento.ViewName = "vFrmPrevencionEmail_rec"
        '
        'RB_Reconocimiento_no
        '
        Me.RB_Reconocimiento_no.Location = New System.Drawing.Point(12, 3)
        Me.RB_Reconocimiento_no.Name = "RB_Reconocimiento_no"
        Me.RB_Reconocimiento_no.Size = New System.Drawing.Size(104, 23)
        Me.RB_Reconocimiento_no.TabIndex = 2
        Me.RB_Reconocimiento_no.Text = "No Apto"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(184, 141)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Descripción"
        '
        'txtdesLimitacion
        '
        Me.txtdesLimitacion.DisabledBackColor = System.Drawing.Color.White
        Me.txtdesLimitacion.Location = New System.Drawing.Point(263, 141)
        Me.txtdesLimitacion.Multiline = True
        Me.txtdesLimitacion.Name = "txtdesLimitacion"
        Me.txtdesLimitacion.Size = New System.Drawing.Size(356, 71)
        Me.txtdesLimitacion.TabIndex = 17
        '
        'RB_Reconocimiento_Apto
        '
        Me.RB_Reconocimiento_Apto.Location = New System.Drawing.Point(206, 3)
        Me.RB_Reconocimiento_Apto.Name = "RB_Reconocimiento_Apto"
        Me.RB_Reconocimiento_Apto.Size = New System.Drawing.Size(104, 23)
        Me.RB_Reconocimiento_Apto.TabIndex = 4
        Me.RB_Reconocimiento_Apto.Text = "Apto"
        '
        'UICheckLimitaciones
        '
        Me.TryDataBinding(UICheckLimitaciones, New System.Windows.Forms.Binding("BindableValue", Me, "tbOperarioReconocimiento_snLimitacion", True))
        Me.UICheckLimitaciones.Location = New System.Drawing.Point(93, 141)
        Me.UICheckLimitaciones.Name = "UICheckLimitaciones"
        Me.UICheckLimitaciones.Size = New System.Drawing.Size(15, 15)
        Me.UICheckLimitaciones.TabIndex = 15
        '
        'lbltbOperarioReconocimiento_Fecha
        '
        Me.lbltbOperarioReconocimiento_Fecha.Location = New System.Drawing.Point(319, 36)
        Me.lbltbOperarioReconocimiento_Fecha.Name = "lbltbOperarioReconocimiento_Fecha"
        Me.lbltbOperarioReconocimiento_Fecha.Size = New System.Drawing.Size(134, 13)
        Me.lbltbOperarioReconocimiento_Fecha.TabIndex = 7
        Me.lbltbOperarioReconocimiento_Fecha.Text = "Fecha Reconocimiento"
        '
        'lbltbOperarioReconocimiento_snLimitacion
        '
        Me.lbltbOperarioReconocimiento_snLimitacion.Location = New System.Drawing.Point(5, 141)
        Me.lbltbOperarioReconocimiento_snLimitacion.Name = "lbltbOperarioReconocimiento_snLimitacion"
        Me.lbltbOperarioReconocimiento_snLimitacion.Size = New System.Drawing.Size(77, 13)
        Me.lbltbOperarioReconocimiento_snLimitacion.TabIndex = 16
        Me.lbltbOperarioReconocimiento_snLimitacion.Text = "Limitaciones"
        '
        'clbFechaReconocimiento
        '
        Me.clbFechaReconocimiento.DisabledBackColor = System.Drawing.Color.White
        Me.clbFechaReconocimiento.Location = New System.Drawing.Point(478, 32)
        Me.clbFechaReconocimiento.Name = "clbFechaReconocimiento"
        Me.clbFechaReconocimiento.Size = New System.Drawing.Size(121, 21)
        Me.clbFechaReconocimiento.TabIndex = 6
        '
        'txtdesSensible
        '
        Me.txtdesSensible.DisabledBackColor = System.Drawing.Color.White
        Me.txtdesSensible.Location = New System.Drawing.Point(263, 64)
        Me.txtdesSensible.Multiline = True
        Me.txtdesSensible.Name = "txtdesSensible"
        Me.txtdesSensible.Size = New System.Drawing.Size(356, 71)
        Me.txtdesSensible.TabIndex = 13
        '
        'GridPuestos
        '
        Me.GridPuestos.ColumnAutoResize = True
        GridPuestos_DesignTimeLayout.LayoutString = resources.GetString("GridPuestos_DesignTimeLayout.LayoutString")
        Me.GridPuestos.DesignTimeLayout = GridPuestos_DesignTimeLayout
        Me.GridPuestos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridPuestos.EntityName = "PrevencionPuesto"
        Me.GridPuestos.Location = New System.Drawing.Point(625, 3)
        Me.GridPuestos.Name = "GridPuestos"
        Me.GridPuestos.PrimaryDataFields = "IDOperario"
        Me.GridPuestos.SecondaryDataFields = "idOperario"
        Me.GridPuestos.Size = New System.Drawing.Size(300, 104)
        Me.GridPuestos.TabIndex = 8
        Me.GridPuestos.ViewName = "vFrmPrevencionPuesto"
        '
        'lbltbOperarioReconocimiento_desSensible
        '
        Me.lbltbOperarioReconocimiento_desSensible.Location = New System.Drawing.Point(184, 68)
        Me.lbltbOperarioReconocimiento_desSensible.Name = "lbltbOperarioReconocimiento_desSensible"
        Me.lbltbOperarioReconocimiento_desSensible.Size = New System.Drawing.Size(73, 13)
        Me.lbltbOperarioReconocimiento_desSensible.TabIndex = 14
        Me.lbltbOperarioReconocimiento_desSensible.Text = "Descripción"
        '
        'lbltbOperarioReconocimiento_snSensible
        '
        Me.lbltbOperarioReconocimiento_snSensible.Location = New System.Drawing.Point(4, 68)
        Me.lbltbOperarioReconocimiento_snSensible.Name = "lbltbOperarioReconocimiento_snSensible"
        Me.lbltbOperarioReconocimiento_snSensible.Size = New System.Drawing.Size(83, 13)
        Me.lbltbOperarioReconocimiento_snSensible.TabIndex = 10
        Me.lbltbOperarioReconocimiento_snSensible.Text = "Esp. Sensible"
        '
        'clbtbOperarioReconocimiento_nDiasAviso
        '
        Me.TryDataBinding(clbtbOperarioReconocimiento_nDiasAviso, New System.Windows.Forms.Binding("BindableValue", Me, "tbOperarioReconocimiento_nDiasAviso", True))
        Me.clbtbOperarioReconocimiento_nDiasAviso.DisabledBackColor = System.Drawing.Color.White
        Me.clbtbOperarioReconocimiento_nDiasAviso.Location = New System.Drawing.Point(124, 90)
        Me.clbtbOperarioReconocimiento_nDiasAviso.Name = "clbtbOperarioReconocimiento_nDiasAviso"
        Me.clbtbOperarioReconocimiento_nDiasAviso.Size = New System.Drawing.Size(121, 21)
        Me.clbtbOperarioReconocimiento_nDiasAviso.TabIndex = 11
        '
        'UiCheckSensible
        '
        Me.TryDataBinding(UiCheckSensible, New System.Windows.Forms.Binding("BindableValue", Me, "tbOperarioReconocimiento_snSensible", True))
        Me.UiCheckSensible.Location = New System.Drawing.Point(93, 66)
        Me.UiCheckSensible.Name = "UiCheckSensible"
        Me.UiCheckSensible.Size = New System.Drawing.Size(15, 15)
        Me.UiCheckSensible.TabIndex = 9
        '
        'lbltbOperarioReconocimiento_nDiasAviso
        '
        Me.lbltbOperarioReconocimiento_nDiasAviso.Location = New System.Drawing.Point(3, 94)
        Me.lbltbOperarioReconocimiento_nDiasAviso.Name = "lbltbOperarioReconocimiento_nDiasAviso"
        Me.lbltbOperarioReconocimiento_nDiasAviso.Size = New System.Drawing.Size(115, 13)
        Me.lbltbOperarioReconocimiento_nDiasAviso.TabIndex = 12
        Me.lbltbOperarioReconocimiento_nDiasAviso.Text = "Fecha Seguimiento"
        '
        'tabFormacion
        '
        Me.tabFormacion.Controls.Add(Me.Tab2Formacion)
        Me.tabFormacion.Location = New System.Drawing.Point(1, 21)
        Me.tabFormacion.Name = "tabFormacion"
        Me.tabFormacion.Size = New System.Drawing.Size(944, 427)
        Me.tabFormacion.TabStop = True
        Me.tabFormacion.Text = "Formación/Epis"
        '
        'Tab2Formacion
        '
        Me.Tab2Formacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Tab2Formacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tab2Formacion.Location = New System.Drawing.Point(0, 0)
        Me.Tab2Formacion.Name = "Tab2Formacion"
        Me.Tab2Formacion.Size = New System.Drawing.Size(944, 427)
        Me.Tab2Formacion.TabIndex = 0
        Me.Tab2Formacion.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.UiTabPageFInterna, Me.UiTabPageFExterna, Me.UiTabPageFormFLC, Me.TabPageTPC, Me.TabPageEpis})
        Me.Tab2Formacion.TabStripAlignment = Janus.Windows.UI.Tab.TabStripAlignment.Left
        Me.Tab2Formacion.TextOrientation = Janus.Windows.UI.Tab.TextOrientation.Horizontal
        Me.Tab2Formacion.UseThemes = True
        '
        'UiTabPageFInterna
        '
        Me.UiTabPageFInterna.Controls.Add(Me.Panel3)
        Me.UiTabPageFInterna.Icon = CType(resources.GetObject("UiTabPageFInterna.Icon"), System.Drawing.Icon)
        Me.UiTabPageFInterna.Location = New System.Drawing.Point(109, 1)
        Me.UiTabPageFInterna.Name = "UiTabPageFInterna"
        Me.UiTabPageFInterna.Size = New System.Drawing.Size(834, 425)
        Me.UiTabPageFInterna.TabStop = True
        Me.UiTabPageFInterna.Text = "F. Interna"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.GridFInterna_hist)
        Me.Panel3.Controls.Add(Me.clb_FInterna_fecha)
        Me.Panel3.Controls.Add(Me.lblvFrmPrevencionFormacion50_fecha)
        Me.Panel3.Controls.Add(Me.SLE_FInterna_Horas)
        Me.Panel3.Controls.Add(Me.lblvFrmPrevencionFormacionI_Horas)
        Me.Panel3.Controls.Add(Me.SLE_FInterna_Especificar)
        Me.Panel3.Controls.Add(Me.lblvFrmPrevencionFormacionI_DesFormacion)
        Me.Panel3.Controls.Add(Me.UICB_FormacionI)
        Me.Panel3.Controls.Add(Me.lblvFrmPrevencionFormacionI_DescClaseFormacion)
        Me.Panel3.Controls.Add(Me.chbvFrmPrevencionFormacionI_snEspecifica)
        Me.Panel3.Controls.Add(Me.lblvFrmPrevencionFormacionI_snEspecifica)
        Me.Panel3.Controls.Add(Me.chbvFrmPrevencionFormacionI_snPuesto)
        Me.Panel3.Controls.Add(Me.lblvFrmPrevencionFormacionI_snPuesto)
        Me.Panel3.Controls.Add(Me.btnFInternaNew)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(834, 425)
        Me.Panel3.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(10, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 13)
        Me.Label2.TabIndex = 74
        Me.Label2.Text = "Histórico F. Interna"
        '
        'GridFInterna_hist
        '
        Me.GridFInterna_hist.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridFInterna_hist.ColumnAutoResize = True
        GridFInterna_hist_DesignTimeLayout.LayoutString = resources.GetString("GridFInterna_hist_DesignTimeLayout.LayoutString")
        Me.GridFInterna_hist.DesignTimeLayout = GridFInterna_hist_DesignTimeLayout
        Me.GridFInterna_hist.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridFInterna_hist.EntityName = "PrevencionFormacion"
        Me.GridFInterna_hist.Location = New System.Drawing.Point(13, 148)
        Me.GridFInterna_hist.Name = "GridFInterna_hist"
        Me.GridFInterna_hist.PrimaryDataFields = "IDOperario"
        Me.GridFInterna_hist.SecondaryDataFields = "idOperario"
        Me.GridFInterna_hist.Size = New System.Drawing.Size(814, 196)
        Me.GridFInterna_hist.TabIndex = 73
        Me.GridFInterna_hist.ViewName = "vFrmPrevencionFormacionI_hist"
        '
        'clb_FInterna_fecha
        '
        Me.TryDataBinding(clb_FInterna_fecha, New System.Windows.Forms.Binding("BindableValue", Me, "vFrmPrevencionFormacionI_Fecha", True))
        Me.clb_FInterna_fecha.DisabledBackColor = System.Drawing.Color.White
        Me.clb_FInterna_fecha.Location = New System.Drawing.Point(399, 74)
        Me.clb_FInterna_fecha.Name = "clb_FInterna_fecha"
        Me.clb_FInterna_fecha.Size = New System.Drawing.Size(121, 21)
        Me.clb_FInterna_fecha.TabIndex = 71
        '
        'lblvFrmPrevencionFormacion50_fecha
        '
        Me.lblvFrmPrevencionFormacion50_fecha.Location = New System.Drawing.Point(288, 82)
        Me.lblvFrmPrevencionFormacion50_fecha.Name = "lblvFrmPrevencionFormacion50_fecha"
        Me.lblvFrmPrevencionFormacion50_fecha.Size = New System.Drawing.Size(105, 13)
        Me.lblvFrmPrevencionFormacion50_fecha.TabIndex = 72
        Me.lblvFrmPrevencionFormacion50_fecha.Text = "Fecha Expedicion"
        '
        'SLE_FInterna_Horas
        '
        Me.TryDataBinding(SLE_FInterna_Horas, New System.Windows.Forms.Binding("Text", Me, "vFrmPrevencionFormacionI_Horas", True))
        Me.SLE_FInterna_Horas.DisabledBackColor = System.Drawing.Color.White
        Me.SLE_FInterna_Horas.Location = New System.Drawing.Point(115, 74)
        Me.SLE_FInterna_Horas.Name = "SLE_FInterna_Horas"
        Me.SLE_FInterna_Horas.Size = New System.Drawing.Size(75, 21)
        Me.SLE_FInterna_Horas.TabIndex = 69
        '
        'lblvFrmPrevencionFormacionI_Horas
        '
        Me.lblvFrmPrevencionFormacionI_Horas.Location = New System.Drawing.Point(10, 82)
        Me.lblvFrmPrevencionFormacionI_Horas.Name = "lblvFrmPrevencionFormacionI_Horas"
        Me.lblvFrmPrevencionFormacionI_Horas.Size = New System.Drawing.Size(40, 13)
        Me.lblvFrmPrevencionFormacionI_Horas.TabIndex = 70
        Me.lblvFrmPrevencionFormacionI_Horas.Text = "Horas"
        '
        'SLE_FInterna_Especificar
        '
        Me.TryDataBinding(SLE_FInterna_Especificar, New System.Windows.Forms.Binding("Text", Me, "vFrmPrevencionFormacionI_DesFormacion", True))
        Me.SLE_FInterna_Especificar.DisabledBackColor = System.Drawing.Color.White
        Me.SLE_FInterna_Especificar.Location = New System.Drawing.Point(399, 47)
        Me.SLE_FInterna_Especificar.Name = "SLE_FInterna_Especificar"
        Me.SLE_FInterna_Especificar.Size = New System.Drawing.Size(428, 21)
        Me.SLE_FInterna_Especificar.TabIndex = 67
        '
        'lblvFrmPrevencionFormacionI_DesFormacion
        '
        Me.lblvFrmPrevencionFormacionI_DesFormacion.Location = New System.Drawing.Point(287, 51)
        Me.lblvFrmPrevencionFormacionI_DesFormacion.Name = "lblvFrmPrevencionFormacionI_DesFormacion"
        Me.lblvFrmPrevencionFormacionI_DesFormacion.Size = New System.Drawing.Size(106, 13)
        Me.lblvFrmPrevencionFormacionI_DesFormacion.TabIndex = 68
        Me.lblvFrmPrevencionFormacionI_DesFormacion.Text = "Especificar Curso"
        '
        'UICB_FormacionI
        '
        Me.TryDataBinding(UICB_FormacionI, New System.Windows.Forms.Binding("Value", Me, "vFrmPrevencionFormacionI_DescClaseFormacion", True))
        UICB_FormacionI_DesignTimeLayout.LayoutString = resources.GetString("UICB_FormacionI_DesignTimeLayout.LayoutString")
        Me.UICB_FormacionI.DesignTimeLayout = UICB_FormacionI_DesignTimeLayout
        Me.UICB_FormacionI.DisabledBackColor = System.Drawing.Color.White
        Me.UICB_FormacionI.Location = New System.Drawing.Point(116, 47)
        Me.UICB_FormacionI.Name = "UICB_FormacionI"
        Me.UICB_FormacionI.SelectedIndex = -1
        Me.UICB_FormacionI.SelectedItem = Nothing
        Me.UICB_FormacionI.Size = New System.Drawing.Size(163, 21)
        Me.UICB_FormacionI.TabIndex = 65
        '
        'lblvFrmPrevencionFormacionI_DescClaseFormacion
        '
        Me.lblvFrmPrevencionFormacionI_DescClaseFormacion.Location = New System.Drawing.Point(10, 51)
        Me.lblvFrmPrevencionFormacionI_DescClaseFormacion.Name = "lblvFrmPrevencionFormacionI_DescClaseFormacion"
        Me.lblvFrmPrevencionFormacionI_DescClaseFormacion.Size = New System.Drawing.Size(94, 13)
        Me.lblvFrmPrevencionFormacionI_DescClaseFormacion.TabIndex = 66
        Me.lblvFrmPrevencionFormacionI_DescClaseFormacion.Text = "Tipo Formacion"
        '
        'chbvFrmPrevencionFormacionI_snEspecifica
        '
        Me.TryDataBinding(chbvFrmPrevencionFormacionI_snEspecifica, New System.Windows.Forms.Binding("BindableValue", Me, "vFrmPrevencionFormacionI_snEspecifica", True))
        Me.chbvFrmPrevencionFormacionI_snEspecifica.Location = New System.Drawing.Point(182, 17)
        Me.chbvFrmPrevencionFormacionI_snEspecifica.Name = "chbvFrmPrevencionFormacionI_snEspecifica"
        Me.chbvFrmPrevencionFormacionI_snEspecifica.Size = New System.Drawing.Size(15, 15)
        Me.chbvFrmPrevencionFormacionI_snEspecifica.TabIndex = 63
        '
        'lblvFrmPrevencionFormacionI_snEspecifica
        '
        Me.lblvFrmPrevencionFormacionI_snEspecifica.Location = New System.Drawing.Point(101, 17)
        Me.lblvFrmPrevencionFormacionI_snEspecifica.Name = "lblvFrmPrevencionFormacionI_snEspecifica"
        Me.lblvFrmPrevencionFormacionI_snEspecifica.Size = New System.Drawing.Size(75, 13)
        Me.lblvFrmPrevencionFormacionI_snEspecifica.TabIndex = 64
        Me.lblvFrmPrevencionFormacionI_snEspecifica.Text = "F. Especifica"
        '
        'chbvFrmPrevencionFormacionI_snPuesto
        '
        Me.TryDataBinding(chbvFrmPrevencionFormacionI_snPuesto, New System.Windows.Forms.Binding("BindableValue", Me, "vFrmPrevencionFormacionI_snPuesto", True))
        Me.chbvFrmPrevencionFormacionI_snPuesto.Location = New System.Drawing.Point(73, 17)
        Me.chbvFrmPrevencionFormacionI_snPuesto.Name = "chbvFrmPrevencionFormacionI_snPuesto"
        Me.chbvFrmPrevencionFormacionI_snPuesto.Size = New System.Drawing.Size(15, 15)
        Me.chbvFrmPrevencionFormacionI_snPuesto.TabIndex = 61
        '
        'lblvFrmPrevencionFormacionI_snPuesto
        '
        Me.lblvFrmPrevencionFormacionI_snPuesto.Location = New System.Drawing.Point(10, 17)
        Me.lblvFrmPrevencionFormacionI_snPuesto.Name = "lblvFrmPrevencionFormacionI_snPuesto"
        Me.lblvFrmPrevencionFormacionI_snPuesto.Size = New System.Drawing.Size(57, 13)
        Me.lblvFrmPrevencionFormacionI_snPuesto.TabIndex = 62
        Me.lblvFrmPrevencionFormacionI_snPuesto.Text = "F. Puesto"
        '
        'btnFInternaNew
        '
        Me.btnFInternaNew.Location = New System.Drawing.Point(13, 106)
        Me.btnFInternaNew.Name = "btnFInternaNew"
        Me.btnFInternaNew.Size = New System.Drawing.Size(75, 23)
        Me.btnFInternaNew.TabIndex = 60
        Me.btnFInternaNew.Text = "GUARDAR"
        '
        'UiTabPageFExterna
        '
        Me.UiTabPageFExterna.Controls.Add(Me.Panel4)
        Me.UiTabPageFExterna.Icon = CType(resources.GetObject("UiTabPageFExterna.Icon"), System.Drawing.Icon)
        Me.UiTabPageFExterna.Location = New System.Drawing.Point(109, 1)
        Me.UiTabPageFExterna.Name = "UiTabPageFExterna"
        Me.UiTabPageFExterna.Size = New System.Drawing.Size(834, 398)
        Me.UiTabPageFExterna.TabStop = True
        Me.UiTabPageFExterna.Text = "F. Externa"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.GridFExterna_hist)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.ClB_FExterna_Fecha)
        Me.Panel4.Controls.Add(Me.lblvFrmPrevencionFormacionE_Horas1)
        Me.Panel4.Controls.Add(Me.SLE_FExternaHoras)
        Me.Panel4.Controls.Add(Me.lblvFrmPrevencionFormacionE_Horas)
        Me.Panel4.Controls.Add(Me.SLE_FExterna_Especificar)
        Me.Panel4.Controls.Add(Me.lblvFrmPrevencionFormacionE_DesFormacion)
        Me.Panel4.Controls.Add(Me.UiCB_FormacionE)
        Me.Panel4.Controls.Add(Me.lblvFrmPrevencionFormacionI_DescClaseFormacion1)
        Me.Panel4.Controls.Add(Me.btnFExternaNew)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(834, 398)
        Me.Panel4.TabIndex = 0
        '
        'GridFExterna_hist
        '
        Me.GridFExterna_hist.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridFExterna_hist.ColumnAutoResize = True
        GridFExterna_hist_DesignTimeLayout.LayoutString = resources.GetString("GridFExterna_hist_DesignTimeLayout.LayoutString")
        Me.GridFExterna_hist.DesignTimeLayout = GridFExterna_hist_DesignTimeLayout
        Me.GridFExterna_hist.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridFExterna_hist.EntityName = "PrevencionFormacion"
        Me.GridFExterna_hist.Location = New System.Drawing.Point(12, 141)
        Me.GridFExterna_hist.Name = "GridFExterna_hist"
        Me.GridFExterna_hist.PrimaryDataFields = "IDOperario"
        Me.GridFExterna_hist.SecondaryDataFields = "idOperario"
        Me.GridFExterna_hist.Size = New System.Drawing.Size(815, 198)
        Me.GridFExterna_hist.TabIndex = 55
        Me.GridFExterna_hist.ViewName = "vFrmPrevencionFormacionE_hist"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(12, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 13)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Histórico F. Interna"
        '
        'ClB_FExterna_Fecha
        '
        Me.TryDataBinding(ClB_FExterna_Fecha, New System.Windows.Forms.Binding("BindableValue", Me, "vFrmPrevencionFormacionE_fecha", True))
        Me.ClB_FExterna_Fecha.DisabledBackColor = System.Drawing.Color.White
        Me.ClB_FExterna_Fecha.Location = New System.Drawing.Point(272, 48)
        Me.ClB_FExterna_Fecha.Name = "ClB_FExterna_Fecha"
        Me.ClB_FExterna_Fecha.Size = New System.Drawing.Size(121, 21)
        Me.ClB_FExterna_Fecha.TabIndex = 52
        '
        'lblvFrmPrevencionFormacionE_Horas1
        '
        Me.lblvFrmPrevencionFormacionE_Horas1.Location = New System.Drawing.Point(161, 52)
        Me.lblvFrmPrevencionFormacionE_Horas1.Name = "lblvFrmPrevencionFormacionE_Horas1"
        Me.lblvFrmPrevencionFormacionE_Horas1.Size = New System.Drawing.Size(105, 13)
        Me.lblvFrmPrevencionFormacionE_Horas1.TabIndex = 53
        Me.lblvFrmPrevencionFormacionE_Horas1.Text = "Fecha Expedicion"
        '
        'SLE_FExternaHoras
        '
        Me.TryDataBinding(SLE_FExternaHoras, New System.Windows.Forms.Binding("Text", Me, "vFrmPrevencionFormacionE_Horas", True))
        Me.SLE_FExternaHoras.DisabledBackColor = System.Drawing.Color.White
        Me.SLE_FExternaHoras.Location = New System.Drawing.Point(61, 48)
        Me.SLE_FExternaHoras.Name = "SLE_FExternaHoras"
        Me.SLE_FExternaHoras.Size = New System.Drawing.Size(78, 21)
        Me.SLE_FExternaHoras.TabIndex = 50
        '
        'lblvFrmPrevencionFormacionE_Horas
        '
        Me.lblvFrmPrevencionFormacionE_Horas.Location = New System.Drawing.Point(15, 52)
        Me.lblvFrmPrevencionFormacionE_Horas.Name = "lblvFrmPrevencionFormacionE_Horas"
        Me.lblvFrmPrevencionFormacionE_Horas.Size = New System.Drawing.Size(40, 13)
        Me.lblvFrmPrevencionFormacionE_Horas.TabIndex = 51
        Me.lblvFrmPrevencionFormacionE_Horas.Text = "Horas"
        '
        'SLE_FExterna_Especificar
        '
        Me.TryDataBinding(SLE_FExterna_Especificar, New System.Windows.Forms.Binding("Text", Me, "vFrmPrevencionFormacionE_DesFormacion", True))
        Me.SLE_FExterna_Especificar.DisabledBackColor = System.Drawing.Color.White
        Me.SLE_FExterna_Especificar.Location = New System.Drawing.Point(403, 16)
        Me.SLE_FExterna_Especificar.Name = "SLE_FExterna_Especificar"
        Me.SLE_FExterna_Especificar.Size = New System.Drawing.Size(409, 21)
        Me.SLE_FExterna_Especificar.TabIndex = 48
        '
        'lblvFrmPrevencionFormacionE_DesFormacion
        '
        Me.lblvFrmPrevencionFormacionE_DesFormacion.Location = New System.Drawing.Point(291, 20)
        Me.lblvFrmPrevencionFormacionE_DesFormacion.Name = "lblvFrmPrevencionFormacionE_DesFormacion"
        Me.lblvFrmPrevencionFormacionE_DesFormacion.Size = New System.Drawing.Size(106, 13)
        Me.lblvFrmPrevencionFormacionE_DesFormacion.TabIndex = 49
        Me.lblvFrmPrevencionFormacionE_DesFormacion.Text = "Especificar Curso"
        '
        'UiCB_FormacionE
        '
        Me.TryDataBinding(UiCB_FormacionE, New System.Windows.Forms.Binding("Value", Me, "vFrmPrevencionFormacionE_DescClaseFormacion", True))
        UiCB_FormacionE_DesignTimeLayout.LayoutString = resources.GetString("UiCB_FormacionE_DesignTimeLayout.LayoutString")
        Me.UiCB_FormacionE.DesignTimeLayout = UiCB_FormacionE_DesignTimeLayout
        Me.UiCB_FormacionE.DisabledBackColor = System.Drawing.Color.White
        Me.UiCB_FormacionE.Location = New System.Drawing.Point(115, 16)
        Me.UiCB_FormacionE.Name = "UiCB_FormacionE"
        Me.UiCB_FormacionE.SelectedIndex = -1
        Me.UiCB_FormacionE.SelectedItem = Nothing
        Me.UiCB_FormacionE.Size = New System.Drawing.Size(170, 21)
        Me.UiCB_FormacionE.TabIndex = 46
        '
        'lblvFrmPrevencionFormacionI_DescClaseFormacion1
        '
        Me.lblvFrmPrevencionFormacionI_DescClaseFormacion1.Location = New System.Drawing.Point(15, 20)
        Me.lblvFrmPrevencionFormacionI_DescClaseFormacion1.Name = "lblvFrmPrevencionFormacionI_DescClaseFormacion1"
        Me.lblvFrmPrevencionFormacionI_DescClaseFormacion1.Size = New System.Drawing.Size(94, 13)
        Me.lblvFrmPrevencionFormacionI_DescClaseFormacion1.TabIndex = 47
        Me.lblvFrmPrevencionFormacionI_DescClaseFormacion1.Text = "Tipo Formación"
        '
        'btnFExternaNew
        '
        Me.btnFExternaNew.Location = New System.Drawing.Point(18, 86)
        Me.btnFExternaNew.Name = "btnFExternaNew"
        Me.btnFExternaNew.Size = New System.Drawing.Size(110, 23)
        Me.btnFExternaNew.TabIndex = 45
        Me.btnFExternaNew.Text = "GUARDAR"
        '
        'UiTabPageFormFLC
        '
        Me.UiTabPageFormFLC.Controls.Add(Me.Panel5)
        Me.UiTabPageFormFLC.Icon = CType(resources.GetObject("UiTabPageFormFLC.Icon"), System.Drawing.Icon)
        Me.UiTabPageFormFLC.Location = New System.Drawing.Point(109, 1)
        Me.UiTabPageFormFLC.Name = "UiTabPageFormFLC"
        Me.UiTabPageFormFLC.Size = New System.Drawing.Size(834, 398)
        Me.UiTabPageFormFLC.TabStop = True
        Me.UiTabPageFormFLC.Text = "Formación FLC"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Fr50)
        Me.Panel5.Controls.Add(Me.Fr20)
        Me.Panel5.Controls.Add(Me.fr8)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(834, 398)
        Me.Panel5.TabIndex = 0
        '
        'Fr50
        '
        Me.Fr50.Controls.Add(Me.clbvFrmPrevencionFormacion50_fecha)
        Me.Fr50.Controls.Add(Me.lblvFrmPrevencionFormacion50_fecha1)
        Me.Fr50.Controls.Add(Me.GridFormacion50)
        Me.Fr50.Controls.Add(Me.SLE_FFLC_Lugar50)
        Me.Fr50.Controls.Add(Me.lblvFrmPrevencionFormacion50_Lugar)
        Me.Fr50.Controls.Add(Me.SLE_FFLC_Empresa50)
        Me.Fr50.Controls.Add(Me.Label5)
        Me.Fr50.Controls.Add(Me.UiCB_Formacion50)
        Me.Fr50.Controls.Add(Me.lblvFrmPrevencionFormacion50_DescClaseFormacion)
        Me.Fr50.Controls.Add(Me.btnF50)
        Me.Fr50.Location = New System.Drawing.Point(14, 235)
        Me.Fr50.Name = "Fr50"
        Me.Fr50.Size = New System.Drawing.Size(813, 157)
        Me.Fr50.TabIndex = 2
        Me.Fr50.TabStop = False
        Me.Fr50.Text = "50/60/TPRL"
        '
        'clbvFrmPrevencionFormacion50_fecha
        '
        Me.TryDataBinding(clbvFrmPrevencionFormacion50_fecha, New System.Windows.Forms.Binding("BindableValue", Me, "vFrmPrevencionFormacion50_fecha", True))
        Me.clbvFrmPrevencionFormacion50_fecha.DisabledBackColor = System.Drawing.Color.White
        Me.clbvFrmPrevencionFormacion50_fecha.Location = New System.Drawing.Point(166, 81)
        Me.clbvFrmPrevencionFormacion50_fecha.Name = "clbvFrmPrevencionFormacion50_fecha"
        Me.clbvFrmPrevencionFormacion50_fecha.Size = New System.Drawing.Size(121, 21)
        Me.clbvFrmPrevencionFormacion50_fecha.TabIndex = 12
        '
        'lblvFrmPrevencionFormacion50_fecha1
        '
        Me.lblvFrmPrevencionFormacion50_fecha1.Location = New System.Drawing.Point(7, 85)
        Me.lblvFrmPrevencionFormacion50_fecha1.Name = "lblvFrmPrevencionFormacion50_fecha1"
        Me.lblvFrmPrevencionFormacion50_fecha1.Size = New System.Drawing.Size(123, 13)
        Me.lblvFrmPrevencionFormacion50_fecha1.TabIndex = 13
        Me.lblvFrmPrevencionFormacion50_fecha1.Text = "Fecha de Expedición"
        '
        'GridFormacion50
        '
        Me.GridFormacion50.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridFormacion50.ColumnAutoResize = True
        GridFormacion50_DesignTimeLayout.LayoutString = resources.GetString("GridFormacion50_DesignTimeLayout.LayoutString")
        Me.GridFormacion50.DesignTimeLayout = GridFormacion50_DesignTimeLayout
        Me.GridFormacion50.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridFormacion50.EntityName = "PrevencionFormacion"
        Me.GridFormacion50.Location = New System.Drawing.Point(312, 54)
        Me.GridFormacion50.Name = "GridFormacion50"
        Me.GridFormacion50.PrimaryDataFields = "IDOperario"
        Me.GridFormacion50.SecondaryDataFields = "idOperario"
        Me.GridFormacion50.Size = New System.Drawing.Size(495, 91)
        Me.GridFormacion50.TabIndex = 11
        Me.GridFormacion50.ViewName = "vFrmPrevencionFormacion50_hist"
        '
        'SLE_FFLC_Lugar50
        '
        Me.TryDataBinding(SLE_FFLC_Lugar50, New System.Windows.Forms.Binding("Text", Me, "vFrmPrevencionFormacion50_Lugar", True))
        Me.SLE_FFLC_Lugar50.DisabledBackColor = System.Drawing.Color.White
        Me.SLE_FFLC_Lugar50.Location = New System.Drawing.Point(55, 54)
        Me.SLE_FFLC_Lugar50.Name = "SLE_FFLC_Lugar50"
        Me.SLE_FFLC_Lugar50.Size = New System.Drawing.Size(251, 21)
        Me.SLE_FFLC_Lugar50.TabIndex = 9
        '
        'lblvFrmPrevencionFormacion50_Lugar
        '
        Me.lblvFrmPrevencionFormacion50_Lugar.Location = New System.Drawing.Point(7, 58)
        Me.lblvFrmPrevencionFormacion50_Lugar.Name = "lblvFrmPrevencionFormacion50_Lugar"
        Me.lblvFrmPrevencionFormacion50_Lugar.Size = New System.Drawing.Size(39, 13)
        Me.lblvFrmPrevencionFormacion50_Lugar.TabIndex = 10
        Me.lblvFrmPrevencionFormacion50_Lugar.Text = "Lugar"
        '
        'SLE_FFLC_Empresa50
        '
        Me.TryDataBinding(SLE_FFLC_Empresa50, New System.Windows.Forms.Binding("Text", Me, "vFrmPrevencionFormacion50_EmpresaForma", True))
        Me.SLE_FFLC_Empresa50.DisabledBackColor = System.Drawing.Color.White
        Me.SLE_FFLC_Empresa50.Location = New System.Drawing.Point(396, 27)
        Me.SLE_FFLC_Empresa50.Name = "SLE_FFLC_Empresa50"
        Me.SLE_FFLC_Empresa50.Size = New System.Drawing.Size(326, 21)
        Me.SLE_FFLC_Empresa50.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(270, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Empresa Formación"
        '
        'UiCB_Formacion50
        '
        Me.TryDataBinding(UiCB_Formacion50, New System.Windows.Forms.Binding("Value", Me, "vFrmPrevencionFormacion50_DescClaseFormacion", True))
        UiCB_Formacion50_DesignTimeLayout.LayoutString = resources.GetString("UiCB_Formacion50_DesignTimeLayout.LayoutString")
        Me.UiCB_Formacion50.DesignTimeLayout = UiCB_Formacion50_DesignTimeLayout
        Me.UiCB_Formacion50.DisabledBackColor = System.Drawing.Color.White
        Me.UiCB_Formacion50.Location = New System.Drawing.Point(110, 27)
        Me.UiCB_Formacion50.Name = "UiCB_Formacion50"
        Me.UiCB_Formacion50.SelectedIndex = -1
        Me.UiCB_Formacion50.SelectedItem = Nothing
        Me.UiCB_Formacion50.Size = New System.Drawing.Size(144, 21)
        Me.UiCB_Formacion50.TabIndex = 2
        '
        'lblvFrmPrevencionFormacion50_DescClaseFormacion
        '
        Me.lblvFrmPrevencionFormacion50_DescClaseFormacion.Location = New System.Drawing.Point(10, 31)
        Me.lblvFrmPrevencionFormacion50_DescClaseFormacion.Name = "lblvFrmPrevencionFormacion50_DescClaseFormacion"
        Me.lblvFrmPrevencionFormacion50_DescClaseFormacion.Size = New System.Drawing.Size(94, 13)
        Me.lblvFrmPrevencionFormacion50_DescClaseFormacion.TabIndex = 3
        Me.lblvFrmPrevencionFormacion50_DescClaseFormacion.Text = "Tipo Formación"
        '
        'btnF50
        '
        Me.btnF50.Location = New System.Drawing.Point(6, 122)
        Me.btnF50.Name = "btnF50"
        Me.btnF50.Size = New System.Drawing.Size(75, 23)
        Me.btnF50.TabIndex = 1
        Me.btnF50.Text = "GUARDAR"
        '
        'Fr20
        '
        Me.Fr20.Controls.Add(Me.ClB_FFLC_Fecha20)
        Me.Fr20.Controls.Add(Me.lblvFrmPrevencionFormacion20_fecha)
        Me.Fr20.Controls.Add(Me.GridFormacion20)
        Me.Fr20.Controls.Add(Me.SLE_FFLC_Lugar20)
        Me.Fr20.Controls.Add(Me.lblvFrmPrevencionFormacion20_Lugar)
        Me.Fr20.Controls.Add(Me.Label4)
        Me.Fr20.Controls.Add(Me.SLE_FFLC_Empresa20)
        Me.Fr20.Controls.Add(Me.UiCheck20)
        Me.Fr20.Controls.Add(Me.UiCB_Formacion20)
        Me.Fr20.Controls.Add(Me.lblvFrmPrevencionFormacion20_DescClaseFormacion)
        Me.Fr20.Controls.Add(Me.btnF20)
        Me.Fr20.Location = New System.Drawing.Point(15, 77)
        Me.Fr20.Name = "Fr20"
        Me.Fr20.Size = New System.Drawing.Size(812, 152)
        Me.Fr20.TabIndex = 1
        Me.Fr20.TabStop = False
        Me.Fr20.Text = "20 Horas"
        '
        'ClB_FFLC_Fecha20
        '
        Me.TryDataBinding(ClB_FFLC_Fecha20, New System.Windows.Forms.Binding("BindableValue", Me, "vFrmPrevencionFormacion20_fecha", True))
        Me.ClB_FFLC_Fecha20.DisabledBackColor = System.Drawing.Color.White
        Me.ClB_FFLC_Fecha20.Location = New System.Drawing.Point(165, 84)
        Me.ClB_FFLC_Fecha20.Name = "ClB_FFLC_Fecha20"
        Me.ClB_FFLC_Fecha20.Size = New System.Drawing.Size(121, 21)
        Me.ClB_FFLC_Fecha20.TabIndex = 10
        '
        'lblvFrmPrevencionFormacion20_fecha
        '
        Me.lblvFrmPrevencionFormacion20_fecha.Location = New System.Drawing.Point(6, 92)
        Me.lblvFrmPrevencionFormacion20_fecha.Name = "lblvFrmPrevencionFormacion20_fecha"
        Me.lblvFrmPrevencionFormacion20_fecha.Size = New System.Drawing.Size(123, 13)
        Me.lblvFrmPrevencionFormacion20_fecha.TabIndex = 11
        Me.lblvFrmPrevencionFormacion20_fecha.Text = "Fecha de Expedición"
        '
        'GridFormacion20
        '
        Me.GridFormacion20.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridFormacion20.ColumnAutoResize = True
        GridFormacion20_DesignTimeLayout.LayoutString = resources.GetString("GridFormacion20_DesignTimeLayout.LayoutString")
        Me.GridFormacion20.DesignTimeLayout = GridFormacion20_DesignTimeLayout
        Me.GridFormacion20.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridFormacion20.EntityName = "PrevencionFormacion"
        Me.GridFormacion20.Location = New System.Drawing.Point(311, 55)
        Me.GridFormacion20.Name = "GridFormacion20"
        Me.GridFormacion20.PrimaryDataFields = "IDOperario"
        Me.GridFormacion20.SecondaryDataFields = "idOperario"
        Me.GridFormacion20.Size = New System.Drawing.Size(495, 91)
        Me.GridFormacion20.TabIndex = 9
        Me.GridFormacion20.ViewName = "vFrmPrevencionFormacion20_hist"
        '
        'SLE_FFLC_Lugar20
        '
        Me.TryDataBinding(SLE_FFLC_Lugar20, New System.Windows.Forms.Binding("Text", Me, "vFrmPrevencionFormacion20_Lugar", True))
        Me.SLE_FFLC_Lugar20.DisabledBackColor = System.Drawing.Color.White
        Me.SLE_FFLC_Lugar20.Location = New System.Drawing.Point(54, 55)
        Me.SLE_FFLC_Lugar20.Name = "SLE_FFLC_Lugar20"
        Me.SLE_FFLC_Lugar20.Size = New System.Drawing.Size(251, 21)
        Me.SLE_FFLC_Lugar20.TabIndex = 7
        '
        'lblvFrmPrevencionFormacion20_Lugar
        '
        Me.lblvFrmPrevencionFormacion20_Lugar.Location = New System.Drawing.Point(6, 59)
        Me.lblvFrmPrevencionFormacion20_Lugar.Name = "lblvFrmPrevencionFormacion20_Lugar"
        Me.lblvFrmPrevencionFormacion20_Lugar.Size = New System.Drawing.Size(39, 13)
        Me.lblvFrmPrevencionFormacion20_Lugar.TabIndex = 8
        Me.lblvFrmPrevencionFormacion20_Lugar.Text = "Lugar"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(366, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Empresa Formación"
        '
        'SLE_FFLC_Empresa20
        '
        Me.TryDataBinding(SLE_FFLC_Empresa20, New System.Windows.Forms.Binding("Text", Me, "vFrmPrevencionFormacion20_empresaforma", True))
        Me.SLE_FFLC_Empresa20.DisabledBackColor = System.Drawing.Color.White
        Me.SLE_FFLC_Empresa20.Location = New System.Drawing.Point(492, 20)
        Me.SLE_FFLC_Empresa20.Name = "SLE_FFLC_Empresa20"
        Me.SLE_FFLC_Empresa20.Size = New System.Drawing.Size(229, 21)
        Me.SLE_FFLC_Empresa20.TabIndex = 4
        '
        'UiCheck20
        '
        Me.UiCheck20.Checked = True
        Me.UiCheck20.CheckState = System.Windows.Forms.CheckState.Checked
        Me.TryDataBinding(UiCheck20, New System.Windows.Forms.Binding("BindableValue", Me, "vFrmPrevencionFormacion20_horas", True))
        Me.UiCheck20.Location = New System.Drawing.Point(259, 18)
        Me.UiCheck20.Name = "UiCheck20"
        Me.UiCheck20.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UiCheck20.Size = New System.Drawing.Size(105, 23)
        Me.UiCheck20.TabIndex = 3
        Me.UiCheck20.Text = "Primer Curso"
        '
        'UiCB_Formacion20
        '
        Me.TryDataBinding(UiCB_Formacion20, New System.Windows.Forms.Binding("Value", Me, "vFrmPrevencionFormacion20_DescClaseFormacion", True))
        UiCB_Formacion20_DesignTimeLayout.LayoutString = resources.GetString("UiCB_Formacion20_DesignTimeLayout.LayoutString")
        Me.UiCB_Formacion20.DesignTimeLayout = UiCB_Formacion20_DesignTimeLayout
        Me.UiCB_Formacion20.DisabledBackColor = System.Drawing.Color.White
        Me.UiCB_Formacion20.Location = New System.Drawing.Point(109, 20)
        Me.UiCB_Formacion20.Name = "UiCB_Formacion20"
        Me.UiCB_Formacion20.SelectedIndex = -1
        Me.UiCB_Formacion20.SelectedItem = Nothing
        Me.UiCB_Formacion20.Size = New System.Drawing.Size(144, 21)
        Me.UiCB_Formacion20.TabIndex = 1
        '
        'lblvFrmPrevencionFormacion20_DescClaseFormacion
        '
        Me.lblvFrmPrevencionFormacion20_DescClaseFormacion.Location = New System.Drawing.Point(9, 24)
        Me.lblvFrmPrevencionFormacion20_DescClaseFormacion.Name = "lblvFrmPrevencionFormacion20_DescClaseFormacion"
        Me.lblvFrmPrevencionFormacion20_DescClaseFormacion.Size = New System.Drawing.Size(94, 13)
        Me.lblvFrmPrevencionFormacion20_DescClaseFormacion.TabIndex = 2
        Me.lblvFrmPrevencionFormacion20_DescClaseFormacion.Text = "Tipo Formación"
        '
        'btnF20
        '
        Me.btnF20.Location = New System.Drawing.Point(9, 123)
        Me.btnF20.Name = "btnF20"
        Me.btnF20.Size = New System.Drawing.Size(75, 23)
        Me.btnF20.TabIndex = 0
        Me.btnF20.Text = "GUARDAR"
        '
        'fr8
        '
        Me.fr8.Controls.Add(Me.Frame1)
        Me.fr8.Controls.Add(Me.txtvFrmPrevencionFormacion8_empresaforma)
        Me.fr8.Controls.Add(Me.lblvFrmPrevencionFormacion8_empresaforma)
        Me.fr8.Controls.Add(Me.ClB_FFLC_Fecha8)
        Me.fr8.Controls.Add(Me.lblvFrmPrevencionFormacion8_fecha)
        Me.fr8.Controls.Add(Me.SLE_FFLC_Lugar8)
        Me.fr8.Controls.Add(Me.lblvFrmPrevencionFormacion8_lugar)
        Me.fr8.Location = New System.Drawing.Point(15, 14)
        Me.fr8.Name = "fr8"
        Me.fr8.Size = New System.Drawing.Size(812, 57)
        Me.fr8.TabIndex = 0
        Me.fr8.TabStop = False
        Me.fr8.Text = "8 Horas"
        '
        'Frame1
        '
        Me.Frame1.Location = New System.Drawing.Point(0, 63)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(820, 128)
        Me.Frame1.TabIndex = 1
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Frame1"
        '
        'txtvFrmPrevencionFormacion8_empresaforma
        '
        Me.TryDataBinding(txtvFrmPrevencionFormacion8_empresaforma, New System.Windows.Forms.Binding("Text", Me, "vFrmPrevencionFormacion8_empresaforma", True))
        Me.txtvFrmPrevencionFormacion8_empresaforma.DisabledBackColor = System.Drawing.Color.White
        Me.txtvFrmPrevencionFormacion8_empresaforma.Location = New System.Drawing.Point(577, 20)
        Me.txtvFrmPrevencionFormacion8_empresaforma.Name = "txtvFrmPrevencionFormacion8_empresaforma"
        Me.txtvFrmPrevencionFormacion8_empresaforma.Size = New System.Drawing.Size(229, 21)
        Me.txtvFrmPrevencionFormacion8_empresaforma.TabIndex = 4
        '
        'lblvFrmPrevencionFormacion8_empresaforma
        '
        Me.lblvFrmPrevencionFormacion8_empresaforma.Location = New System.Drawing.Point(451, 24)
        Me.lblvFrmPrevencionFormacion8_empresaforma.Name = "lblvFrmPrevencionFormacion8_empresaforma"
        Me.lblvFrmPrevencionFormacion8_empresaforma.Size = New System.Drawing.Size(120, 13)
        Me.lblvFrmPrevencionFormacion8_empresaforma.TabIndex = 5
        Me.lblvFrmPrevencionFormacion8_empresaforma.Text = "Empresa Formación"
        '
        'ClB_FFLC_Fecha8
        '
        Me.TryDataBinding(ClB_FFLC_Fecha8, New System.Windows.Forms.Binding("BindableValue", Me, "vFrmPrevencionFormacion8_fecha", True))
        Me.ClB_FFLC_Fecha8.DisabledBackColor = System.Drawing.Color.White
        Me.ClB_FFLC_Fecha8.Location = New System.Drawing.Point(324, 20)
        Me.ClB_FFLC_Fecha8.Name = "ClB_FFLC_Fecha8"
        Me.ClB_FFLC_Fecha8.Size = New System.Drawing.Size(121, 21)
        Me.ClB_FFLC_Fecha8.TabIndex = 2
        '
        'lblvFrmPrevencionFormacion8_fecha
        '
        Me.lblvFrmPrevencionFormacion8_fecha.Location = New System.Drawing.Point(213, 24)
        Me.lblvFrmPrevencionFormacion8_fecha.Name = "lblvFrmPrevencionFormacion8_fecha"
        Me.lblvFrmPrevencionFormacion8_fecha.Size = New System.Drawing.Size(105, 13)
        Me.lblvFrmPrevencionFormacion8_fecha.TabIndex = 3
        Me.lblvFrmPrevencionFormacion8_fecha.Text = "Fecha Expedicion"
        '
        'SLE_FFLC_Lugar8
        '
        Me.TryDataBinding(SLE_FFLC_Lugar8, New System.Windows.Forms.Binding("Text", Me, "vFrmPrevencionFormacion8_lugar", True))
        Me.SLE_FFLC_Lugar8.DisabledBackColor = System.Drawing.Color.White
        Me.SLE_FFLC_Lugar8.Location = New System.Drawing.Point(51, 20)
        Me.SLE_FFLC_Lugar8.Name = "SLE_FFLC_Lugar8"
        Me.SLE_FFLC_Lugar8.Size = New System.Drawing.Size(147, 21)
        Me.SLE_FFLC_Lugar8.TabIndex = 0
        '
        'lblvFrmPrevencionFormacion8_lugar
        '
        Me.lblvFrmPrevencionFormacion8_lugar.Location = New System.Drawing.Point(6, 24)
        Me.lblvFrmPrevencionFormacion8_lugar.Name = "lblvFrmPrevencionFormacion8_lugar"
        Me.lblvFrmPrevencionFormacion8_lugar.Size = New System.Drawing.Size(39, 13)
        Me.lblvFrmPrevencionFormacion8_lugar.TabIndex = 1
        Me.lblvFrmPrevencionFormacion8_lugar.Text = "Lugar"
        '
        'TabPageTPC
        '
        Me.TabPageTPC.Controls.Add(Me.Panel6)
        Me.TabPageTPC.Icon = CType(resources.GetObject("TabPageTPC.Icon"), System.Drawing.Icon)
        Me.TabPageTPC.Location = New System.Drawing.Point(109, 1)
        Me.TabPageTPC.Name = "TabPageTPC"
        Me.TabPageTPC.Size = New System.Drawing.Size(834, 398)
        Me.TabPageTPC.TabStop = True
        Me.TabPageTPC.Text = "TPC"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.SLE_FTPC_Observaciones)
        Me.Panel6.Controls.Add(Me.lblvFrmPrevencionFormacionTPC_DesFormacion)
        Me.Panel6.Controls.Add(Me.chbvFrmPrevencionFormacionTPC_sntpc)
        Me.Panel6.Controls.Add(Me.SLE_FTPC_Contraseña)
        Me.Panel6.Controls.Add(Me.lblvFrmPrevencionFormacionTPC_password)
        Me.Panel6.Controls.Add(Me.SLE_FTPC_Usuario)
        Me.Panel6.Controls.Add(Me.lblvFrmPrevencionFormacionTPC_usuario)
        Me.Panel6.Controls.Add(Me.Label7)
        Me.Panel6.Controls.Add(Me.Label6)
        Me.Panel6.Controls.Add(Me.GridFiltroCurso)
        Me.Panel6.Controls.Add(Me.GridTPC)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(834, 398)
        Me.Panel6.TabIndex = 0
        '
        'SLE_FTPC_Observaciones
        '
        Me.TryDataBinding(SLE_FTPC_Observaciones, New System.Windows.Forms.Binding("Text", Me, "vFrmPrevencionFormacionTPC_DesFormacion", True))
        Me.SLE_FTPC_Observaciones.DisabledBackColor = System.Drawing.Color.White
        Me.SLE_FTPC_Observaciones.Location = New System.Drawing.Point(458, 224)
        Me.SLE_FTPC_Observaciones.Multiline = True
        Me.SLE_FTPC_Observaciones.Name = "SLE_FTPC_Observaciones"
        Me.SLE_FTPC_Observaciones.Size = New System.Drawing.Size(369, 150)
        Me.SLE_FTPC_Observaciones.TabIndex = 9
        '
        'lblvFrmPrevencionFormacionTPC_DesFormacion
        '
        Me.lblvFrmPrevencionFormacionTPC_DesFormacion.Location = New System.Drawing.Point(455, 205)
        Me.lblvFrmPrevencionFormacionTPC_DesFormacion.Name = "lblvFrmPrevencionFormacionTPC_DesFormacion"
        Me.lblvFrmPrevencionFormacionTPC_DesFormacion.Size = New System.Drawing.Size(91, 13)
        Me.lblvFrmPrevencionFormacionTPC_DesFormacion.TabIndex = 10
        Me.lblvFrmPrevencionFormacionTPC_DesFormacion.Text = "Observaciones"
        '
        'chbvFrmPrevencionFormacionTPC_sntpc
        '
        Me.TryDataBinding(chbvFrmPrevencionFormacionTPC_sntpc, New System.Windows.Forms.Binding("BindableValue", Me, "vFrmPrevencionFormacionTPC_sntpc", True))
        Me.chbvFrmPrevencionFormacionTPC_sntpc.Location = New System.Drawing.Point(481, 41)
        Me.chbvFrmPrevencionFormacionTPC_sntpc.Name = "chbvFrmPrevencionFormacionTPC_sntpc"
        Me.chbvFrmPrevencionFormacionTPC_sntpc.Size = New System.Drawing.Size(96, 26)
        Me.chbvFrmPrevencionFormacionTPC_sntpc.TabIndex = 8
        Me.chbvFrmPrevencionFormacionTPC_sntpc.Text = "Entregada"
        '
        'SLE_FTPC_Contraseña
        '
        Me.TryDataBinding(SLE_FTPC_Contraseña, New System.Windows.Forms.Binding("Text", Me, "vFrmPrevencionFormacionTPC_password", True))
        Me.SLE_FTPC_Contraseña.DisabledBackColor = System.Drawing.Color.White
        Me.SLE_FTPC_Contraseña.Location = New System.Drawing.Point(583, 107)
        Me.SLE_FTPC_Contraseña.Name = "SLE_FTPC_Contraseña"
        Me.SLE_FTPC_Contraseña.Size = New System.Drawing.Size(167, 21)
        Me.SLE_FTPC_Contraseña.TabIndex = 6
        '
        'lblvFrmPrevencionFormacionTPC_password
        '
        Me.lblvFrmPrevencionFormacionTPC_password.Location = New System.Drawing.Point(479, 111)
        Me.lblvFrmPrevencionFormacionTPC_password.Name = "lblvFrmPrevencionFormacionTPC_password"
        Me.lblvFrmPrevencionFormacionTPC_password.Size = New System.Drawing.Size(73, 13)
        Me.lblvFrmPrevencionFormacionTPC_password.TabIndex = 7
        Me.lblvFrmPrevencionFormacionTPC_password.Text = "Contraseña"
        '
        'SLE_FTPC_Usuario
        '
        Me.TryDataBinding(SLE_FTPC_Usuario, New System.Windows.Forms.Binding("Text", Me, "vFrmPrevencionFormacionTPC_usuario", True))
        Me.SLE_FTPC_Usuario.DisabledBackColor = System.Drawing.Color.White
        Me.SLE_FTPC_Usuario.Location = New System.Drawing.Point(583, 72)
        Me.SLE_FTPC_Usuario.Name = "SLE_FTPC_Usuario"
        Me.SLE_FTPC_Usuario.Size = New System.Drawing.Size(167, 21)
        Me.SLE_FTPC_Usuario.TabIndex = 4
        '
        'lblvFrmPrevencionFormacionTPC_usuario
        '
        Me.lblvFrmPrevencionFormacionTPC_usuario.Location = New System.Drawing.Point(482, 76)
        Me.lblvFrmPrevencionFormacionTPC_usuario.Name = "lblvFrmPrevencionFormacionTPC_usuario"
        Me.lblvFrmPrevencionFormacionTPC_usuario.Size = New System.Drawing.Size(50, 13)
        Me.lblvFrmPrevencionFormacionTPC_usuario.TabIndex = 5
        Me.lblvFrmPrevencionFormacionTPC_usuario.Text = "Usuario"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(24, 205)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Cursos Incluidos"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(23, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Cursos Disponibles"
        '
        'GridFiltroCurso
        '
        Me.GridFiltroCurso.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridFiltroCurso.ColumnAutoResize = True
        GridFiltroCurso_DesignTimeLayout.LayoutString = resources.GetString("GridFiltroCurso_DesignTimeLayout.LayoutString")
        Me.GridFiltroCurso.DesignTimeLayout = GridFiltroCurso_DesignTimeLayout
        Me.GridFiltroCurso.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridFiltroCurso.EntityName = "PrevencionFormacion"
        Me.GridFiltroCurso.Location = New System.Drawing.Point(24, 224)
        Me.GridFiltroCurso.Name = "GridFiltroCurso"
        Me.GridFiltroCurso.PrimaryDataFields = "IDOperario"
        Me.GridFiltroCurso.SecondaryDataFields = "idOperario"
        Me.GridFiltroCurso.Size = New System.Drawing.Size(423, 150)
        Me.GridFiltroCurso.TabIndex = 1
        Me.GridFiltroCurso.ViewName = "vFrmPrevencionFormacionTPC_sel"
        '
        'GridTPC
        '
        Me.GridTPC.ColumnAutoResize = True
        GridTPC_DesignTimeLayout.LayoutString = resources.GetString("GridTPC_DesignTimeLayout.LayoutString")
        Me.GridTPC.DesignTimeLayout = GridTPC_DesignTimeLayout
        Me.GridTPC.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridTPC.EntityName = "PrevencionFormacion"
        Me.GridTPC.Location = New System.Drawing.Point(23, 34)
        Me.GridTPC.Name = "GridTPC"
        Me.GridTPC.PrimaryDataFields = "IDOperario"
        Me.GridTPC.SecondaryDataFields = "idOperario"
        Me.GridTPC.Size = New System.Drawing.Size(425, 154)
        Me.GridTPC.TabIndex = 0
        Me.GridTPC.ViewName = "vFrmPrevencionFormacionTPC_all"
        '
        'TabPageEpis
        '
        Me.TabPageEpis.Controls.Add(Me.Panel7)
        Me.TabPageEpis.Icon = CType(resources.GetObject("TabPageEpis.Icon"), System.Drawing.Icon)
        Me.TabPageEpis.Location = New System.Drawing.Point(109, 1)
        Me.TabPageEpis.Name = "TabPageEpis"
        Me.TabPageEpis.Size = New System.Drawing.Size(834, 398)
        Me.TabPageEpis.TabStop = True
        Me.TabPageEpis.Text = "E.P.I.S."
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Label8)
        Me.Panel7.Controls.Add(Me.GridEpis_hist)
        Me.Panel7.Controls.Add(Me.SLE_EPIS_Equipo)
        Me.Panel7.Controls.Add(Me.lbltbOperarioEpis_DesAdicional)
        Me.Panel7.Controls.Add(Me.UiCB_Epi)
        Me.Panel7.Controls.Add(Me.lbltbOperarioEpis_DesEpis)
        Me.Panel7.Controls.Add(Me.ClB_EPIS_Fecha)
        Me.Panel7.Controls.Add(Me.lbltbOperarioEpis_fecha)
        Me.Panel7.Controls.Add(Me.btnEPIS)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(834, 398)
        Me.Panel7.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(13, 110)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Histórico E.P.I.S."
        '
        'GridEpis_hist
        '
        Me.GridEpis_hist.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridEpis_hist_DesignTimeLayout.LayoutString = resources.GetString("GridEpis_hist_DesignTimeLayout.LayoutString")
        Me.GridEpis_hist.DesignTimeLayout = GridEpis_hist_DesignTimeLayout
        Me.GridEpis_hist.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridEpis_hist.EntityName = "PrevencionEpis"
        Me.GridEpis_hist.Location = New System.Drawing.Point(16, 136)
        Me.GridEpis_hist.Name = "GridEpis_hist"
        Me.GridEpis_hist.PrimaryDataFields = "IDOperario"
        Me.GridEpis_hist.SecondaryDataFields = "idOperario"
        Me.GridEpis_hist.Size = New System.Drawing.Size(812, 247)
        Me.GridEpis_hist.TabIndex = 13
        Me.GridEpis_hist.ViewName = "vFrmPrevencionEpis_hist"
        '
        'SLE_EPIS_Equipo
        '
        Me.TryDataBinding(SLE_EPIS_Equipo, New System.Windows.Forms.Binding("Text", Me, "tbOperarioEpis_DesAdicional", True))
        Me.SLE_EPIS_Equipo.DisabledBackColor = System.Drawing.Color.White
        Me.SLE_EPIS_Equipo.Location = New System.Drawing.Point(606, 28)
        Me.SLE_EPIS_Equipo.Name = "SLE_EPIS_Equipo"
        Me.SLE_EPIS_Equipo.Size = New System.Drawing.Size(221, 21)
        Me.SLE_EPIS_Equipo.TabIndex = 11
        '
        'lbltbOperarioEpis_DesAdicional
        '
        Me.lbltbOperarioEpis_DesAdicional.Location = New System.Drawing.Point(500, 32)
        Me.lbltbOperarioEpis_DesAdicional.Name = "lbltbOperarioEpis_DesAdicional"
        Me.lbltbOperarioEpis_DesAdicional.Size = New System.Drawing.Size(100, 13)
        Me.lbltbOperarioEpis_DesAdicional.TabIndex = 12
        Me.lbltbOperarioEpis_DesAdicional.Text = "Equipo Adicional"
        '
        'UiCB_Epi
        '
        Me.TryDataBinding(UiCB_Epi, New System.Windows.Forms.Binding("Value", Me, "tbOperarioEpis_DesEpis", True))
        UiCB_Epi_DesignTimeLayout.LayoutString = resources.GetString("UiCB_Epi_DesignTimeLayout.LayoutString")
        Me.UiCB_Epi.DesignTimeLayout = UiCB_Epi_DesignTimeLayout
        Me.UiCB_Epi.DisabledBackColor = System.Drawing.Color.White
        Me.UiCB_Epi.Location = New System.Drawing.Point(307, 28)
        Me.UiCB_Epi.Name = "UiCB_Epi"
        Me.UiCB_Epi.SelectedIndex = -1
        Me.UiCB_Epi.SelectedItem = Nothing
        Me.UiCB_Epi.Size = New System.Drawing.Size(186, 21)
        Me.UiCB_Epi.TabIndex = 9
        '
        'lbltbOperarioEpis_DesEpis
        '
        Me.lbltbOperarioEpis_DesEpis.Location = New System.Drawing.Point(257, 32)
        Me.lbltbOperarioEpis_DesEpis.Name = "lbltbOperarioEpis_DesEpis"
        Me.lbltbOperarioEpis_DesEpis.Size = New System.Drawing.Size(44, 13)
        Me.lbltbOperarioEpis_DesEpis.TabIndex = 10
        Me.lbltbOperarioEpis_DesEpis.Text = "E.P.I.S"
        '
        'ClB_EPIS_Fecha
        '
        Me.TryDataBinding(ClB_EPIS_Fecha, New System.Windows.Forms.Binding("BindableValue", Me, "tbOperarioEpis_fecha", True))
        Me.ClB_EPIS_Fecha.DisabledBackColor = System.Drawing.Color.White
        Me.ClB_EPIS_Fecha.Location = New System.Drawing.Point(124, 28)
        Me.ClB_EPIS_Fecha.Name = "ClB_EPIS_Fecha"
        Me.ClB_EPIS_Fecha.Size = New System.Drawing.Size(121, 21)
        Me.ClB_EPIS_Fecha.TabIndex = 7
        '
        'lbltbOperarioEpis_fecha
        '
        Me.lbltbOperarioEpis_fecha.Location = New System.Drawing.Point(13, 32)
        Me.lbltbOperarioEpis_fecha.Name = "lbltbOperarioEpis_fecha"
        Me.lbltbOperarioEpis_fecha.Size = New System.Drawing.Size(105, 13)
        Me.lbltbOperarioEpis_fecha.TabIndex = 8
        Me.lbltbOperarioEpis_fecha.Text = "Fecha Expedición"
        '
        'btnEPIS
        '
        Me.btnEPIS.Location = New System.Drawing.Point(16, 68)
        Me.btnEPIS.Name = "btnEPIS"
        Me.btnEPIS.Size = New System.Drawing.Size(75, 23)
        Me.btnEPIS.TabIndex = 6
        Me.btnEPIS.Text = "GUARDAR"
        '
        'tabAccidentes
        '
        Me.tabAccidentes.Controls.Add(Me.Panel8)
        Me.tabAccidentes.Location = New System.Drawing.Point(1, 21)
        Me.tabAccidentes.Name = "tabAccidentes"
        Me.tabAccidentes.Size = New System.Drawing.Size(944, 427)
        Me.tabAccidentes.TabStop = True
        Me.tabAccidentes.Text = "Accidentes"
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.GridAccidentes)
        Me.Panel8.Controls.Add(Me.btnAccidentesH)
        Me.Panel8.Controls.Add(Me.SLE_Accidentes_Seguimiento)
        Me.Panel8.Controls.Add(Me.lbltbOperarioAccidentes_desSeguimiento)
        Me.Panel8.Controls.Add(Me.SLE_Accidentes_Descripcion)
        Me.Panel8.Controls.Add(Me.lbltbOperarioAccidentes_descripcioninves)
        Me.Panel8.Controls.Add(Me.UiC_Accidentes_Requiere)
        Me.Panel8.Controls.Add(Me.UiC_Accidentes_Investigacion)
        Me.Panel8.Controls.Add(Me.UiC_Accidentes_Obra)
        Me.Panel8.Controls.Add(Me.ClB_Accidentes_Requiere)
        Me.Panel8.Controls.Add(Me.lbltbOperarioAccidentes_fechaseg)
        Me.Panel8.Controls.Add(Me.GridCorreoAcc)
        Me.Panel8.Controls.Add(Me.Ul_Accidentes_obra)
        Me.Panel8.Controls.Add(Me.AdvS_Accidentes_Obra)
        Me.Panel8.Controls.Add(Me.lbltbOperarioAccidentes_codobra)
        Me.Panel8.Controls.Add(Me.UiCB_AccidentesJ)
        Me.Panel8.Controls.Add(Me.lbltbOperarioAccidentes_JefeProd)
        Me.Panel8.Controls.Add(Me.UiCB_AccidentesE)
        Me.Panel8.Controls.Add(Me.lbl_ACC_Encargado)
        Me.Panel8.Controls.Add(Me.SLE_Accidentes_Lugar)
        Me.Panel8.Controls.Add(Me.lbltbOperarioAccidentes_Lugar)
        Me.Panel8.Controls.Add(Me.UiC_Accidentes_Recaida)
        Me.Panel8.Controls.Add(Me.RB_Accidentes_SinBaja)
        Me.Panel8.Controls.Add(Me.rbttbOperarioAccidentes_tipo2)
        Me.Panel8.Controls.Add(Me.RB_Accidentes_Grave)
        Me.Panel8.Controls.Add(Me.RB_Accidentes_leve)
        Me.Panel8.Controls.Add(Me.clbtbOperarioAccidentes_falta)
        Me.Panel8.Controls.Add(Me.lbltbOperarioAccidentes_falta)
        Me.Panel8.Controls.Add(Me.sle_Accidentes_Dias)
        Me.Panel8.Controls.Add(Me.lbltbOperarioAccidentes_nDiasBaja)
        Me.Panel8.Controls.Add(Me.clbtbOperarioAccidentes_fNotificacion)
        Me.Panel8.Controls.Add(Me.lbltbOperarioAccidentes_fNotificacion)
        Me.Panel8.Controls.Add(Me.ClB_Accidentes_Fbaja)
        Me.Panel8.Controls.Add(Me.lbltbOperarioAccidentes_fbaja)
        Me.Panel8.Controls.Add(Me.ClB_Accidentes_FAccidente)
        Me.Panel8.Controls.Add(Me.lbltbOperarioAccidentes_faccidente)
        Me.Panel8.Controls.Add(Me.btnAccidentessn)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(944, 427)
        Me.Panel8.TabIndex = 0
        '
        'GridAccidentes
        '
        Me.GridAccidentes.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridAccidentes_DesignTimeLayout.LayoutString = resources.GetString("GridAccidentes_DesignTimeLayout.LayoutString")
        Me.GridAccidentes.DesignTimeLayout = GridAccidentes_DesignTimeLayout
        Me.GridAccidentes.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridAccidentes.EntityName = "PrevencionAccidentes"
        Me.GridAccidentes.Location = New System.Drawing.Point(88, 281)
        Me.GridAccidentes.Name = "GridAccidentes"
        Me.GridAccidentes.PrimaryDataFields = "IDOperario"
        Me.GridAccidentes.SecondaryDataFields = "idOperario"
        Me.GridAccidentes.Size = New System.Drawing.Size(848, 116)
        Me.GridAccidentes.TabIndex = 46
        Me.GridAccidentes.ViewName = "vFrmPrevencionAccidentes_hist"
        '
        'btnAccidentesH
        '
        Me.btnAccidentesH.Location = New System.Drawing.Point(7, 281)
        Me.btnAccidentesH.Name = "btnAccidentesH"
        Me.btnAccidentesH.Size = New System.Drawing.Size(75, 23)
        Me.btnAccidentesH.TabIndex = 45
        Me.btnAccidentesH.Text = "Historico ..."
        '
        'SLE_Accidentes_Seguimiento
        '
        Me.TryDataBinding(SLE_Accidentes_Seguimiento, New System.Windows.Forms.Binding("Text", Me, "tbOperarioAccidentes_desSeguimiento", True))
        Me.SLE_Accidentes_Seguimiento.DisabledBackColor = System.Drawing.Color.White
        Me.SLE_Accidentes_Seguimiento.Location = New System.Drawing.Point(468, 196)
        Me.SLE_Accidentes_Seguimiento.Multiline = True
        Me.SLE_Accidentes_Seguimiento.Name = "SLE_Accidentes_Seguimiento"
        Me.SLE_Accidentes_Seguimiento.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.SLE_Accidentes_Seguimiento.Size = New System.Drawing.Size(468, 79)
        Me.SLE_Accidentes_Seguimiento.TabIndex = 43
        '
        'lbltbOperarioAccidentes_desSeguimiento
        '
        Me.lbltbOperarioAccidentes_desSeguimiento.Location = New System.Drawing.Point(465, 180)
        Me.lbltbOperarioAccidentes_desSeguimiento.Name = "lbltbOperarioAccidentes_desSeguimiento"
        Me.lbltbOperarioAccidentes_desSeguimiento.Size = New System.Drawing.Size(78, 13)
        Me.lbltbOperarioAccidentes_desSeguimiento.TabIndex = 44
        Me.lbltbOperarioAccidentes_desSeguimiento.Text = "Seguimiento"
        '
        'SLE_Accidentes_Descripcion
        '
        Me.TryDataBinding(SLE_Accidentes_Descripcion, New System.Windows.Forms.Binding("Text", Me, "tbOperarioAccidentes_descripcioninves", True))
        Me.SLE_Accidentes_Descripcion.DisabledBackColor = System.Drawing.Color.White
        Me.SLE_Accidentes_Descripcion.Location = New System.Drawing.Point(7, 196)
        Me.SLE_Accidentes_Descripcion.Multiline = True
        Me.SLE_Accidentes_Descripcion.Name = "SLE_Accidentes_Descripcion"
        Me.SLE_Accidentes_Descripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.SLE_Accidentes_Descripcion.Size = New System.Drawing.Size(455, 79)
        Me.SLE_Accidentes_Descripcion.TabIndex = 41
        '
        'lbltbOperarioAccidentes_descripcioninves
        '
        Me.lbltbOperarioAccidentes_descripcioninves.Location = New System.Drawing.Point(6, 180)
        Me.lbltbOperarioAccidentes_descripcioninves.Name = "lbltbOperarioAccidentes_descripcioninves"
        Me.lbltbOperarioAccidentes_descripcioninves.Size = New System.Drawing.Size(170, 13)
        Me.lbltbOperarioAccidentes_descripcioninves.TabIndex = 42
        Me.lbltbOperarioAccidentes_descripcioninves.Text = "Descripción / Observaciones"
        '
        'UiC_Accidentes_Requiere
        '
        Me.TryDataBinding(UiC_Accidentes_Requiere, New System.Windows.Forms.Binding("BindableValue", Me, "tbOperarioAccidentes_snseguimiento", True))
        Me.UiC_Accidentes_Requiere.Location = New System.Drawing.Point(506, 143)
        Me.UiC_Accidentes_Requiere.Name = "UiC_Accidentes_Requiere"
        Me.UiC_Accidentes_Requiere.Size = New System.Drawing.Size(151, 27)
        Me.UiC_Accidentes_Requiere.TabIndex = 40
        Me.UiC_Accidentes_Requiere.Text = "Requiere Seguimiento"
        '
        'UiC_Accidentes_Investigacion
        '
        Me.TryDataBinding(UiC_Accidentes_Investigacion, New System.Windows.Forms.Binding("BindableValue", Me, "tbOperarioAccidentes_sninvestigacionpre", True))
        Me.UiC_Accidentes_Investigacion.Location = New System.Drawing.Point(339, 143)
        Me.UiC_Accidentes_Investigacion.Name = "UiC_Accidentes_Investigacion"
        Me.UiC_Accidentes_Investigacion.Size = New System.Drawing.Size(166, 27)
        Me.UiC_Accidentes_Investigacion.TabIndex = 39
        Me.UiC_Accidentes_Investigacion.Text = "Investigación Prevención"
        '
        'UiC_Accidentes_Obra
        '
        Me.TryDataBinding(UiC_Accidentes_Obra, New System.Windows.Forms.Binding("BindableValue", Me, "tbOperarioAccidentes_sninvestigaciono", True))
        Me.UiC_Accidentes_Obra.Location = New System.Drawing.Point(203, 148)
        Me.UiC_Accidentes_Obra.Name = "UiC_Accidentes_Obra"
        Me.UiC_Accidentes_Obra.Size = New System.Drawing.Size(140, 18)
        Me.UiC_Accidentes_Obra.TabIndex = 38
        Me.UiC_Accidentes_Obra.Text = "Investigación Obra"
        '
        'ClB_Accidentes_Requiere
        '
        Me.TryDataBinding(ClB_Accidentes_Requiere, New System.Windows.Forms.Binding("BindableValue", Me, "tbOperarioAccidentes_fechaseg", True))
        Me.ClB_Accidentes_Requiere.DisabledBackColor = System.Drawing.Color.White
        Me.ClB_Accidentes_Requiere.Location = New System.Drawing.Point(95, 147)
        Me.ClB_Accidentes_Requiere.Name = "ClB_Accidentes_Requiere"
        Me.ClB_Accidentes_Requiere.Size = New System.Drawing.Size(102, 21)
        Me.ClB_Accidentes_Requiere.TabIndex = 36
        '
        'lbltbOperarioAccidentes_fechaseg
        '
        Me.lbltbOperarioAccidentes_fechaseg.Location = New System.Drawing.Point(6, 151)
        Me.lbltbOperarioAccidentes_fechaseg.Name = "lbltbOperarioAccidentes_fechaseg"
        Me.lbltbOperarioAccidentes_fechaseg.Size = New System.Drawing.Size(90, 13)
        Me.lbltbOperarioAccidentes_fechaseg.TabIndex = 37
        Me.lbltbOperarioAccidentes_fechaseg.Text = "F. Seguimiento"
        '
        'GridCorreoAcc
        '
        GridCorreoAcc_DesignTimeLayout.LayoutString = resources.GetString("GridCorreoAcc_DesignTimeLayout.LayoutString")
        Me.GridCorreoAcc.DesignTimeLayout = GridCorreoAcc_DesignTimeLayout
        Me.GridCorreoAcc.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridCorreoAcc.EntityName = "PrevencionEmail"
        Me.GridCorreoAcc.Location = New System.Drawing.Point(663, 104)
        Me.GridCorreoAcc.Name = "GridCorreoAcc"
        Me.GridCorreoAcc.PrimaryDataFields = "IDOperario"
        Me.GridCorreoAcc.SecondaryDataFields = "idOperario"
        Me.GridCorreoAcc.Size = New System.Drawing.Size(273, 89)
        Me.GridCorreoAcc.TabIndex = 35
        Me.GridCorreoAcc.ViewName = "vFrmPrevencionEmail_acc"
        '
        'Ul_Accidentes_obra
        '
        Me.TryDataBinding(Ul_Accidentes_obra, New System.Windows.Forms.Binding("Text", Me.AdvS_Accidentes_Obra, "DescObra", True))
        Me.Ul_Accidentes_obra.Location = New System.Drawing.Point(172, 108)
        Me.Ul_Accidentes_obra.Name = "Ul_Accidentes_obra"
        Me.Ul_Accidentes_obra.Size = New System.Drawing.Size(466, 23)
        Me.Ul_Accidentes_obra.TabIndex = 34
        '
        'AdvS_Accidentes_Obra
        '
        Me.TryDataBinding(AdvS_Accidentes_Obra, New System.Windows.Forms.Binding("Text", Me, "tbOperarioAccidentes_codobra", True))
        Me.AdvS_Accidentes_Obra.DisabledBackColor = System.Drawing.Color.White
        Me.AdvS_Accidentes_Obra.EntityName = "ObraCabecera"
        Me.AdvS_Accidentes_Obra.Location = New System.Drawing.Point(80, 108)
        Me.AdvS_Accidentes_Obra.Name = "AdvS_Accidentes_Obra"
        Me.AdvS_Accidentes_Obra.PrimaryDataFields = "tbOperarioAccidentes_codobra"
        Me.AdvS_Accidentes_Obra.SecondaryDataFields = "IDObra"
        Me.AdvS_Accidentes_Obra.Size = New System.Drawing.Size(86, 23)
        Me.AdvS_Accidentes_Obra.TabIndex = 32
        Me.AdvS_Accidentes_Obra.ViewName = "tbObraCabecera"
        '
        'lbltbOperarioAccidentes_codobra
        '
        Me.lbltbOperarioAccidentes_codobra.Location = New System.Drawing.Point(13, 113)
        Me.lbltbOperarioAccidentes_codobra.Name = "lbltbOperarioAccidentes_codobra"
        Me.lbltbOperarioAccidentes_codobra.Size = New System.Drawing.Size(35, 13)
        Me.lbltbOperarioAccidentes_codobra.TabIndex = 33
        Me.lbltbOperarioAccidentes_codobra.Text = "Obra"
        '
        'UiCB_AccidentesJ
        '
        Me.TryDataBinding(UiCB_AccidentesJ, New System.Windows.Forms.Binding("Value", Me, "tbOperarioAccidentes_JefeProd", True))
        UiCB_AccidentesJ_DesignTimeLayout.LayoutString = resources.GetString("UiCB_AccidentesJ_DesignTimeLayout.LayoutString")
        Me.UiCB_AccidentesJ.DesignTimeLayout = UiCB_AccidentesJ_DesignTimeLayout
        Me.UiCB_AccidentesJ.DisabledBackColor = System.Drawing.Color.White
        Me.UiCB_AccidentesJ.Location = New System.Drawing.Point(533, 77)
        Me.UiCB_AccidentesJ.Name = "UiCB_AccidentesJ"
        Me.UiCB_AccidentesJ.SelectedIndex = -1
        Me.UiCB_AccidentesJ.SelectedItem = Nothing
        Me.UiCB_AccidentesJ.Size = New System.Drawing.Size(403, 21)
        Me.UiCB_AccidentesJ.TabIndex = 30
        '
        'lbltbOperarioAccidentes_JefeProd
        '
        Me.lbltbOperarioAccidentes_JefeProd.Location = New System.Drawing.Point(431, 81)
        Me.lbltbOperarioAccidentes_JefeProd.Name = "lbltbOperarioAccidentes_JefeProd"
        Me.lbltbOperarioAccidentes_JefeProd.Size = New System.Drawing.Size(96, 13)
        Me.lbltbOperarioAccidentes_JefeProd.TabIndex = 31
        Me.lbltbOperarioAccidentes_JefeProd.Text = "Jefe Producción"
        '
        'UiCB_AccidentesE
        '
        Me.TryDataBinding(UiCB_AccidentesE, New System.Windows.Forms.Binding("Value", Me, "tbOperarioAccidentes_encargado", True))
        UiCB_AccidentesE_DesignTimeLayout.LayoutString = resources.GetString("UiCB_AccidentesE_DesignTimeLayout.LayoutString")
        Me.UiCB_AccidentesE.DesignTimeLayout = UiCB_AccidentesE_DesignTimeLayout
        Me.UiCB_AccidentesE.DisabledBackColor = System.Drawing.Color.White
        Me.UiCB_AccidentesE.Location = New System.Drawing.Point(80, 77)
        Me.UiCB_AccidentesE.Name = "UiCB_AccidentesE"
        Me.UiCB_AccidentesE.SelectedIndex = -1
        Me.UiCB_AccidentesE.SelectedItem = Nothing
        Me.UiCB_AccidentesE.Size = New System.Drawing.Size(342, 21)
        Me.UiCB_AccidentesE.TabIndex = 28
        '
        'lbl_ACC_Encargado
        '
        Me.lbl_ACC_Encargado.Location = New System.Drawing.Point(7, 81)
        Me.lbl_ACC_Encargado.Name = "lbl_ACC_Encargado"
        Me.lbl_ACC_Encargado.Size = New System.Drawing.Size(67, 13)
        Me.lbl_ACC_Encargado.TabIndex = 29
        Me.lbl_ACC_Encargado.Text = "Encargado"
        '
        'SLE_Accidentes_Lugar
        '
        Me.TryDataBinding(SLE_Accidentes_Lugar, New System.Windows.Forms.Binding("Text", Me, "tbOperarioAccidentes_Lugar", True))
        Me.SLE_Accidentes_Lugar.DisabledBackColor = System.Drawing.Color.White
        Me.SLE_Accidentes_Lugar.Location = New System.Drawing.Point(565, 46)
        Me.SLE_Accidentes_Lugar.Name = "SLE_Accidentes_Lugar"
        Me.SLE_Accidentes_Lugar.Size = New System.Drawing.Size(371, 21)
        Me.SLE_Accidentes_Lugar.TabIndex = 26
        '
        'lbltbOperarioAccidentes_Lugar
        '
        Me.lbltbOperarioAccidentes_Lugar.Location = New System.Drawing.Point(520, 50)
        Me.lbltbOperarioAccidentes_Lugar.Name = "lbltbOperarioAccidentes_Lugar"
        Me.lbltbOperarioAccidentes_Lugar.Size = New System.Drawing.Size(39, 13)
        Me.lbltbOperarioAccidentes_Lugar.TabIndex = 27
        Me.lbltbOperarioAccidentes_Lugar.Text = "Lugar"
        '
        'UiC_Accidentes_Recaida
        '
        Me.TryDataBinding(UiC_Accidentes_Recaida, New System.Windows.Forms.Binding("BindableValue", Me, "tbOperarioAccidentes_snrecaida", True))
        Me.UiC_Accidentes_Recaida.Location = New System.Drawing.Point(448, 44)
        Me.UiC_Accidentes_Recaida.Name = "UiC_Accidentes_Recaida"
        Me.UiC_Accidentes_Recaida.Size = New System.Drawing.Size(79, 24)
        Me.UiC_Accidentes_Recaida.TabIndex = 25
        Me.UiC_Accidentes_Recaida.Text = "Recaida"
        '
        'RB_Accidentes_SinBaja
        '
        Me.TryDataBinding(RB_Accidentes_SinBaja, New System.Windows.Forms.Binding("BindableValue", Me, "tbOperarioAccidentes_tipo", True))
        Me.RB_Accidentes_SinBaja.Location = New System.Drawing.Point(367, 46)
        Me.RB_Accidentes_SinBaja.Name = "RB_Accidentes_SinBaja"
        Me.RB_Accidentes_SinBaja.Size = New System.Drawing.Size(75, 19)
        Me.RB_Accidentes_SinBaja.TabIndex = 24
        Me.RB_Accidentes_SinBaja.Text = "Sin Baja"
        '
        'rbttbOperarioAccidentes_tipo2
        '
        Me.TryDataBinding(rbttbOperarioAccidentes_tipo2, New System.Windows.Forms.Binding("BindableValue", Me, "tbOperarioAccidentes_tipo", True))
        Me.rbttbOperarioAccidentes_tipo2.Location = New System.Drawing.Point(308, 46)
        Me.rbttbOperarioAccidentes_tipo2.Name = "rbttbOperarioAccidentes_tipo2"
        Me.rbttbOperarioAccidentes_tipo2.Size = New System.Drawing.Size(102, 19)
        Me.rbttbOperarioAccidentes_tipo2.TabIndex = 22
        Me.rbttbOperarioAccidentes_tipo2.Text = "Mortal"
        '
        'RB_Accidentes_Grave
        '
        Me.TryDataBinding(RB_Accidentes_Grave, New System.Windows.Forms.Binding("BindableValue", Me, "tbOperarioAccidentes_tipo", True))
        Me.RB_Accidentes_Grave.Location = New System.Drawing.Point(247, 42)
        Me.RB_Accidentes_Grave.Name = "RB_Accidentes_Grave"
        Me.RB_Accidentes_Grave.Size = New System.Drawing.Size(93, 27)
        Me.RB_Accidentes_Grave.TabIndex = 20
        Me.RB_Accidentes_Grave.Text = "Grave"
        '
        'RB_Accidentes_leve
        '
        Me.TryDataBinding(RB_Accidentes_leve, New System.Windows.Forms.Binding("BindableValue", Me, "tbOperarioAccidentes_tipo", True))
        Me.RB_Accidentes_leve.Location = New System.Drawing.Point(194, 44)
        Me.RB_Accidentes_leve.Name = "RB_Accidentes_leve"
        Me.RB_Accidentes_leve.Size = New System.Drawing.Size(95, 24)
        Me.RB_Accidentes_leve.TabIndex = 18
        Me.RB_Accidentes_leve.Text = "Leve"
        '
        'clbtbOperarioAccidentes_falta
        '
        Me.TryDataBinding(clbtbOperarioAccidentes_falta, New System.Windows.Forms.Binding("BindableValue", Me, "tbOperarioAccidentes_falta", True))
        Me.clbtbOperarioAccidentes_falta.DisabledBackColor = System.Drawing.Color.White
        Me.clbtbOperarioAccidentes_falta.Location = New System.Drawing.Point(54, 46)
        Me.clbtbOperarioAccidentes_falta.Name = "clbtbOperarioAccidentes_falta"
        Me.clbtbOperarioAccidentes_falta.Size = New System.Drawing.Size(121, 21)
        Me.clbtbOperarioAccidentes_falta.TabIndex = 16
        '
        'lbltbOperarioAccidentes_falta
        '
        Me.lbltbOperarioAccidentes_falta.Location = New System.Drawing.Point(7, 50)
        Me.lbltbOperarioAccidentes_falta.Name = "lbltbOperarioAccidentes_falta"
        Me.lbltbOperarioAccidentes_falta.Size = New System.Drawing.Size(41, 13)
        Me.lbltbOperarioAccidentes_falta.TabIndex = 17
        Me.lbltbOperarioAccidentes_falta.Text = "F. Alta"
        '
        'sle_Accidentes_Dias
        '
        Me.TryDataBinding(sle_Accidentes_Dias, New System.Windows.Forms.Binding("Text", Me, "tbOperarioAccidentes_nDiasBaja", True))
        Me.sle_Accidentes_Dias.DisabledBackColor = System.Drawing.Color.White
        Me.sle_Accidentes_Dias.Enabled = False
        Me.sle_Accidentes_Dias.Location = New System.Drawing.Point(777, 17)
        Me.sle_Accidentes_Dias.Name = "sle_Accidentes_Dias"
        Me.sle_Accidentes_Dias.Size = New System.Drawing.Size(159, 21)
        Me.sle_Accidentes_Dias.TabIndex = 14
        '
        'lbltbOperarioAccidentes_nDiasBaja
        '
        Me.lbltbOperarioAccidentes_nDiasBaja.Location = New System.Drawing.Point(709, 21)
        Me.lbltbOperarioAccidentes_nDiasBaja.Name = "lbltbOperarioAccidentes_nDiasBaja"
        Me.lbltbOperarioAccidentes_nDiasBaja.Size = New System.Drawing.Size(62, 13)
        Me.lbltbOperarioAccidentes_nDiasBaja.TabIndex = 15
        Me.lbltbOperarioAccidentes_nDiasBaja.Text = "Dias Baja"
        '
        'clbtbOperarioAccidentes_fNotificacion
        '
        Me.TryDataBinding(clbtbOperarioAccidentes_fNotificacion, New System.Windows.Forms.Binding("BindableValue", Me, "tbOperarioAccidentes_fNotificacion", True))
        Me.clbtbOperarioAccidentes_fNotificacion.DisabledBackColor = System.Drawing.Color.White
        Me.clbtbOperarioAccidentes_fNotificacion.Location = New System.Drawing.Point(573, 17)
        Me.clbtbOperarioAccidentes_fNotificacion.Name = "clbtbOperarioAccidentes_fNotificacion"
        Me.clbtbOperarioAccidentes_fNotificacion.Size = New System.Drawing.Size(121, 21)
        Me.clbtbOperarioAccidentes_fNotificacion.TabIndex = 12
        '
        'lbltbOperarioAccidentes_fNotificacion
        '
        Me.lbltbOperarioAccidentes_fNotificacion.Location = New System.Drawing.Point(483, 21)
        Me.lbltbOperarioAccidentes_fNotificacion.Name = "lbltbOperarioAccidentes_fNotificacion"
        Me.lbltbOperarioAccidentes_fNotificacion.Size = New System.Drawing.Size(84, 13)
        Me.lbltbOperarioAccidentes_fNotificacion.TabIndex = 13
        Me.lbltbOperarioAccidentes_fNotificacion.Text = "F. Notificacion"
        '
        'ClB_Accidentes_Fbaja
        '
        Me.TryDataBinding(ClB_Accidentes_Fbaja, New System.Windows.Forms.Binding("BindableValue", Me, "tbOperarioAccidentes_fbaja", True))
        Me.ClB_Accidentes_Fbaja.DisabledBackColor = System.Drawing.Color.White
        Me.ClB_Accidentes_Fbaja.Location = New System.Drawing.Point(356, 17)
        Me.ClB_Accidentes_Fbaja.Name = "ClB_Accidentes_Fbaja"
        Me.ClB_Accidentes_Fbaja.Size = New System.Drawing.Size(121, 21)
        Me.ClB_Accidentes_Fbaja.TabIndex = 10
        '
        'lbltbOperarioAccidentes_fbaja
        '
        Me.lbltbOperarioAccidentes_fbaja.Location = New System.Drawing.Point(305, 21)
        Me.lbltbOperarioAccidentes_fbaja.Name = "lbltbOperarioAccidentes_fbaja"
        Me.lbltbOperarioAccidentes_fbaja.Size = New System.Drawing.Size(45, 13)
        Me.lbltbOperarioAccidentes_fbaja.TabIndex = 11
        Me.lbltbOperarioAccidentes_fbaja.Text = "F. Baja"
        '
        'ClB_Accidentes_FAccidente
        '
        Me.TryDataBinding(ClB_Accidentes_FAccidente, New System.Windows.Forms.Binding("BindableValue", Me, "tbOperarioAccidentes_faccidente", True))
        Me.ClB_Accidentes_FAccidente.DisabledBackColor = System.Drawing.Color.White
        Me.ClB_Accidentes_FAccidente.Location = New System.Drawing.Point(172, 17)
        Me.ClB_Accidentes_FAccidente.Name = "ClB_Accidentes_FAccidente"
        Me.ClB_Accidentes_FAccidente.Size = New System.Drawing.Size(121, 21)
        Me.ClB_Accidentes_FAccidente.TabIndex = 8
        '
        'lbltbOperarioAccidentes_faccidente
        '
        Me.lbltbOperarioAccidentes_faccidente.Location = New System.Drawing.Point(92, 21)
        Me.lbltbOperarioAccidentes_faccidente.Name = "lbltbOperarioAccidentes_faccidente"
        Me.lbltbOperarioAccidentes_faccidente.Size = New System.Drawing.Size(74, 13)
        Me.lbltbOperarioAccidentes_faccidente.TabIndex = 9
        Me.lbltbOperarioAccidentes_faccidente.Text = "F. Accidente"
        '
        'btnAccidentessn
        '
        Me.btnAccidentessn.Location = New System.Drawing.Point(9, 15)
        Me.btnAccidentessn.Name = "btnAccidentessn"
        Me.btnAccidentessn.Size = New System.Drawing.Size(75, 23)
        Me.btnAccidentessn.TabIndex = 7
        Me.btnAccidentessn.Text = "GUARDAR"
        '
        'tabNotificaciones
        '
        Me.tabNotificaciones.Controls.Add(Me.Panel9)
        Me.tabNotificaciones.Location = New System.Drawing.Point(1, 21)
        Me.tabNotificaciones.Name = "tabNotificaciones"
        Me.tabNotificaciones.Size = New System.Drawing.Size(944, 427)
        Me.tabNotificaciones.TabStop = True
        Me.tabNotificaciones.Text = "Notificaciones"
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.GridNotificacion)
        Me.Panel9.Controls.Add(Me.btnNotificacionesN)
        Me.Panel9.Controls.Add(Me.SLE_Notificaciones_Tipo)
        Me.Panel9.Controls.Add(Me.lbltbOperarioNotificacion_tipo)
        Me.Panel9.Controls.Add(Me.SLE_Notificaciones_Observaciones)
        Me.Panel9.Controls.Add(Me.lbltbOperarioNotificacion_Observaciones)
        Me.Panel9.Controls.Add(Me.Frame2)
        Me.Panel9.Controls.Add(Me.UiCB_NotificacionesJ)
        Me.Panel9.Controls.Add(Me.lbltbOperarioNotificacion_JefeProd)
        Me.Panel9.Controls.Add(Me.UiC_Notificaciones_Recibida)
        Me.Panel9.Controls.Add(Me.UiCB_NotificacionesS)
        Me.Panel9.Controls.Add(Me.lbltbOperarioNotificacion_DescSancion)
        Me.Panel9.Controls.Add(Me.UiCB_NotificacionesE)
        Me.Panel9.Controls.Add(Me.lbltbOperarioNotificacion_Encargado)
        Me.Panel9.Controls.Add(Me.UL_Notificaciones_Obra)
        Me.Panel9.Controls.Add(Me.AdS_Notificaciones_Obra)
        Me.Panel9.Controls.Add(Me.lbltbOperarioNotificacion_idobra)
        Me.Panel9.Controls.Add(Me.ClB_Notificaciones_Fecha)
        Me.Panel9.Controls.Add(Me.lbltbOperarioNotificacion_fechaSeguimiento)
        Me.Panel9.Controls.Add(Me.btnNotificacionesNuevo)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(944, 427)
        Me.Panel9.TabIndex = 0
        '
        'GridNotificacion
        '
        Me.GridNotificacion.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridNotificacion.ColumnAutoResize = True
        GridNotificacion_DesignTimeLayout.LayoutString = resources.GetString("GridNotificacion_DesignTimeLayout.LayoutString")
        Me.GridNotificacion.DesignTimeLayout = GridNotificacion_DesignTimeLayout
        Me.GridNotificacion.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridNotificacion.EntityName = "PrevencionNotificacion"
        Me.GridNotificacion.Location = New System.Drawing.Point(47, 213)
        Me.GridNotificacion.Name = "GridNotificacion"
        Me.GridNotificacion.PrimaryDataFields = "IDOperario"
        Me.GridNotificacion.SecondaryDataFields = "idOperario"
        Me.GridNotificacion.Size = New System.Drawing.Size(842, 180)
        Me.GridNotificacion.TabIndex = 47
        Me.GridNotificacion.ViewName = "vFrmPrevencionNotificacion_hist"
        '
        'btnNotificacionesN
        '
        Me.btnNotificacionesN.Location = New System.Drawing.Point(289, 184)
        Me.btnNotificacionesN.Name = "btnNotificacionesN"
        Me.btnNotificacionesN.Size = New System.Drawing.Size(75, 23)
        Me.btnNotificacionesN.TabIndex = 46
        Me.btnNotificacionesN.Text = "Historico"
        '
        'SLE_Notificaciones_Tipo
        '
        Me.TryDataBinding(SLE_Notificaciones_Tipo, New System.Windows.Forms.Binding("Text", Me, "tbOperarioNotificacion_tipo", True))
        Me.SLE_Notificaciones_Tipo.DisabledBackColor = System.Drawing.Color.White
        Me.SLE_Notificaciones_Tipo.Location = New System.Drawing.Point(47, 150)
        Me.SLE_Notificaciones_Tipo.Name = "SLE_Notificaciones_Tipo"
        Me.SLE_Notificaciones_Tipo.Size = New System.Drawing.Size(300, 21)
        Me.SLE_Notificaciones_Tipo.TabIndex = 24
        Me.SLE_Notificaciones_Tipo.Visible = False
        '
        'lbltbOperarioNotificacion_tipo
        '
        Me.lbltbOperarioNotificacion_tipo.Location = New System.Drawing.Point(10, 154)
        Me.lbltbOperarioNotificacion_tipo.Name = "lbltbOperarioNotificacion_tipo"
        Me.lbltbOperarioNotificacion_tipo.Size = New System.Drawing.Size(31, 13)
        Me.lbltbOperarioNotificacion_tipo.TabIndex = 25
        Me.lbltbOperarioNotificacion_tipo.Text = "Tipo"
        Me.lbltbOperarioNotificacion_tipo.Visible = False
        '
        'SLE_Notificaciones_Observaciones
        '
        Me.TryDataBinding(SLE_Notificaciones_Observaciones, New System.Windows.Forms.Binding("Text", Me, "tbOperarioNotificacion_Observaciones", True))
        Me.SLE_Notificaciones_Observaciones.DisabledBackColor = System.Drawing.Color.White
        Me.SLE_Notificaciones_Observaciones.Location = New System.Drawing.Point(392, 75)
        Me.SLE_Notificaciones_Observaciones.Multiline = True
        Me.SLE_Notificaciones_Observaciones.Name = "SLE_Notificaciones_Observaciones"
        Me.SLE_Notificaciones_Observaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.SLE_Notificaciones_Observaciones.Size = New System.Drawing.Size(544, 96)
        Me.SLE_Notificaciones_Observaciones.TabIndex = 22
        '
        'lbltbOperarioNotificacion_Observaciones
        '
        Me.lbltbOperarioNotificacion_Observaciones.Location = New System.Drawing.Point(295, 75)
        Me.lbltbOperarioNotificacion_Observaciones.Name = "lbltbOperarioNotificacion_Observaciones"
        Me.lbltbOperarioNotificacion_Observaciones.Size = New System.Drawing.Size(91, 13)
        Me.lbltbOperarioNotificacion_Observaciones.TabIndex = 23
        Me.lbltbOperarioNotificacion_Observaciones.Text = "Observaciones"
        '
        'Frame2
        '
        Me.Frame2.Controls.Add(Me.RB_Notificaciones_MuyGrave)
        Me.Frame2.Controls.Add(Me.RB_Notificaciones_Grave)
        Me.Frame2.Controls.Add(Me.RB_Notificaciones_leve)
        Me.Frame2.Location = New System.Drawing.Point(13, 75)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Size = New System.Drawing.Size(276, 60)
        Me.Frame2.TabIndex = 21
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "Gravedad"
        '
        'RB_Notificaciones_MuyGrave
        '
        Me.TryDataBinding(RB_Notificaciones_MuyGrave, New System.Windows.Forms.Binding("BindableValue", Me, "tbOperarioNotificacion_gravedad", True))
        Me.RB_Notificaciones_MuyGrave.Location = New System.Drawing.Point(174, 20)
        Me.RB_Notificaciones_MuyGrave.Name = "RB_Notificaciones_MuyGrave"
        Me.RB_Notificaciones_MuyGrave.Size = New System.Drawing.Size(78, 20)
        Me.RB_Notificaciones_MuyGrave.TabIndex = 2
        Me.RB_Notificaciones_MuyGrave.Text = "Muy Grave"
        '
        'RB_Notificaciones_Grave
        '
        Me.TryDataBinding(RB_Notificaciones_Grave, New System.Windows.Forms.Binding("BindableValue", Me, "tbOperarioNotificacion_gravedad", True))
        Me.RB_Notificaciones_Grave.Location = New System.Drawing.Point(99, 20)
        Me.RB_Notificaciones_Grave.Name = "RB_Notificaciones_Grave"
        Me.RB_Notificaciones_Grave.Size = New System.Drawing.Size(78, 20)
        Me.RB_Notificaciones_Grave.TabIndex = 1
        Me.RB_Notificaciones_Grave.Text = "Grave"
        '
        'RB_Notificaciones_leve
        '
        Me.TryDataBinding(RB_Notificaciones_leve, New System.Windows.Forms.Binding("BindableValue", Me, "tbOperarioNotificacion_gravedad", True))
        Me.RB_Notificaciones_leve.Location = New System.Drawing.Point(19, 20)
        Me.RB_Notificaciones_leve.Name = "RB_Notificaciones_leve"
        Me.RB_Notificaciones_leve.Size = New System.Drawing.Size(78, 20)
        Me.RB_Notificaciones_leve.TabIndex = 0
        Me.RB_Notificaciones_leve.Text = "Leve"
        '
        'UiCB_NotificacionesJ
        '
        Me.TryDataBinding(UiCB_NotificacionesJ, New System.Windows.Forms.Binding("Value", Me, "tbOperarioNotificacion_JefeProd", True))
        UiCB_NotificacionesJ_DesignTimeLayout.LayoutString = resources.GetString("UiCB_NotificacionesJ_DesignTimeLayout.LayoutString")
        Me.UiCB_NotificacionesJ.DesignTimeLayout = UiCB_NotificacionesJ_DesignTimeLayout
        Me.UiCB_NotificacionesJ.DisabledBackColor = System.Drawing.Color.White
        Me.UiCB_NotificacionesJ.Location = New System.Drawing.Point(734, 49)
        Me.UiCB_NotificacionesJ.Name = "UiCB_NotificacionesJ"
        Me.UiCB_NotificacionesJ.SelectedIndex = -1
        Me.UiCB_NotificacionesJ.SelectedItem = Nothing
        Me.UiCB_NotificacionesJ.Size = New System.Drawing.Size(202, 21)
        Me.UiCB_NotificacionesJ.TabIndex = 19
        '
        'lbltbOperarioNotificacion_JefeProd
        '
        Me.lbltbOperarioNotificacion_JefeProd.Location = New System.Drawing.Point(632, 53)
        Me.lbltbOperarioNotificacion_JefeProd.Name = "lbltbOperarioNotificacion_JefeProd"
        Me.lbltbOperarioNotificacion_JefeProd.Size = New System.Drawing.Size(96, 13)
        Me.lbltbOperarioNotificacion_JefeProd.TabIndex = 20
        Me.lbltbOperarioNotificacion_JefeProd.Text = "Jefe Producción"
        '
        'UiC_Notificaciones_Recibida
        '
        Me.TryDataBinding(UiC_Notificaciones_Recibida, New System.Windows.Forms.Binding("BindableValue", Me, "tbOperarioNotificacion_snRecibida", True))
        Me.UiC_Notificaciones_Recibida.Location = New System.Drawing.Point(557, 49)
        Me.UiC_Notificaciones_Recibida.Name = "UiC_Notificaciones_Recibida"
        Me.UiC_Notificaciones_Recibida.Size = New System.Drawing.Size(81, 20)
        Me.UiC_Notificaciones_Recibida.TabIndex = 18
        Me.UiC_Notificaciones_Recibida.Text = "Recibida"
        '
        'UiCB_NotificacionesS
        '
        Me.TryDataBinding(UiCB_NotificacionesS, New System.Windows.Forms.Binding("Value", Me, "tbOperarioNotificacion_DescSancion", True))
        UiCB_NotificacionesS_DesignTimeLayout.LayoutString = resources.GetString("UiCB_NotificacionesS_DesignTimeLayout.LayoutString")
        Me.UiCB_NotificacionesS.DesignTimeLayout = UiCB_NotificacionesS_DesignTimeLayout
        Me.UiCB_NotificacionesS.DisabledBackColor = System.Drawing.Color.White
        Me.UiCB_NotificacionesS.Location = New System.Drawing.Point(353, 48)
        Me.UiCB_NotificacionesS.Name = "UiCB_NotificacionesS"
        Me.UiCB_NotificacionesS.SelectedIndex = -1
        Me.UiCB_NotificacionesS.SelectedItem = Nothing
        Me.UiCB_NotificacionesS.Size = New System.Drawing.Size(198, 21)
        Me.UiCB_NotificacionesS.TabIndex = 16
        '
        'lbltbOperarioNotificacion_DescSancion
        '
        Me.lbltbOperarioNotificacion_DescSancion.Location = New System.Drawing.Point(295, 52)
        Me.lbltbOperarioNotificacion_DescSancion.Name = "lbltbOperarioNotificacion_DescSancion"
        Me.lbltbOperarioNotificacion_DescSancion.Size = New System.Drawing.Size(52, 13)
        Me.lbltbOperarioNotificacion_DescSancion.TabIndex = 17
        Me.lbltbOperarioNotificacion_DescSancion.Text = "Sanción"
        '
        'UiCB_NotificacionesE
        '
        Me.TryDataBinding(UiCB_NotificacionesE, New System.Windows.Forms.Binding("Value", Me, "tbOperarioNotificacion_Encargado", True))
        UiCB_NotificacionesE_DesignTimeLayout.LayoutString = resources.GetString("UiCB_NotificacionesE_DesignTimeLayout.LayoutString")
        Me.UiCB_NotificacionesE.DesignTimeLayout = UiCB_NotificacionesE_DesignTimeLayout
        Me.UiCB_NotificacionesE.DisabledBackColor = System.Drawing.Color.White
        Me.UiCB_NotificacionesE.Location = New System.Drawing.Point(83, 48)
        Me.UiCB_NotificacionesE.Name = "UiCB_NotificacionesE"
        Me.UiCB_NotificacionesE.SelectedIndex = -1
        Me.UiCB_NotificacionesE.SelectedItem = Nothing
        Me.UiCB_NotificacionesE.Size = New System.Drawing.Size(206, 21)
        Me.UiCB_NotificacionesE.TabIndex = 14
        '
        'lbltbOperarioNotificacion_Encargado
        '
        Me.lbltbOperarioNotificacion_Encargado.Location = New System.Drawing.Point(10, 52)
        Me.lbltbOperarioNotificacion_Encargado.Name = "lbltbOperarioNotificacion_Encargado"
        Me.lbltbOperarioNotificacion_Encargado.Size = New System.Drawing.Size(67, 13)
        Me.lbltbOperarioNotificacion_Encargado.TabIndex = 15
        Me.lbltbOperarioNotificacion_Encargado.Text = "Encargado"
        '
        'UL_Notificaciones_Obra
        '
        Me.TryDataBinding(UL_Notificaciones_Obra, New System.Windows.Forms.Binding("Text", Me.AdS_Notificaciones_Obra, "DescObra", True))
        Me.UL_Notificaciones_Obra.Location = New System.Drawing.Point(292, 13)
        Me.UL_Notificaciones_Obra.Name = "UL_Notificaciones_Obra"
        Me.UL_Notificaciones_Obra.Size = New System.Drawing.Size(546, 23)
        Me.UL_Notificaciones_Obra.TabIndex = 13
        '
        'AdS_Notificaciones_Obra
        '
        Me.TryDataBinding(AdS_Notificaciones_Obra, New System.Windows.Forms.Binding("Text", Me, "tbOperarioNotificacion_idobra", True))
        Me.AdS_Notificaciones_Obra.DisabledBackColor = System.Drawing.Color.White
        Me.AdS_Notificaciones_Obra.DisplayField = "NObra"
        Me.AdS_Notificaciones_Obra.EntityName = "ObraCabecera"
        Me.AdS_Notificaciones_Obra.Location = New System.Drawing.Point(191, 12)
        Me.AdS_Notificaciones_Obra.Name = "AdS_Notificaciones_Obra"
        Me.AdS_Notificaciones_Obra.PrimaryDataFields = "tbOperarioNotificacion_idobra"
        Me.AdS_Notificaciones_Obra.SecondaryDataFields = "IDObra"
        Me.AdS_Notificaciones_Obra.Size = New System.Drawing.Size(95, 23)
        Me.AdS_Notificaciones_Obra.TabIndex = 11
        Me.AdS_Notificaciones_Obra.ViewName = "tbObraCabecera"
        '
        'lbltbOperarioNotificacion_idobra
        '
        Me.lbltbOperarioNotificacion_idobra.Location = New System.Drawing.Point(156, 17)
        Me.lbltbOperarioNotificacion_idobra.Name = "lbltbOperarioNotificacion_idobra"
        Me.lbltbOperarioNotificacion_idobra.Size = New System.Drawing.Size(35, 13)
        Me.lbltbOperarioNotificacion_idobra.TabIndex = 12
        Me.lbltbOperarioNotificacion_idobra.Text = "Obra"
        '
        'ClB_Notificaciones_Fecha
        '
        Me.TryDataBinding(ClB_Notificaciones_Fecha, New System.Windows.Forms.Binding("BindableValue", Me, "tbOperarioNotificacion_fechaSeguimiento", True))
        Me.ClB_Notificaciones_Fecha.DisabledBackColor = System.Drawing.Color.White
        Me.ClB_Notificaciones_Fecha.Location = New System.Drawing.Point(60, 13)
        Me.ClB_Notificaciones_Fecha.Name = "ClB_Notificaciones_Fecha"
        Me.ClB_Notificaciones_Fecha.Size = New System.Drawing.Size(90, 21)
        Me.ClB_Notificaciones_Fecha.TabIndex = 9
        '
        'lbltbOperarioNotificacion_fechaSeguimiento
        '
        Me.lbltbOperarioNotificacion_fechaSeguimiento.Location = New System.Drawing.Point(10, 17)
        Me.lbltbOperarioNotificacion_fechaSeguimiento.Name = "lbltbOperarioNotificacion_fechaSeguimiento"
        Me.lbltbOperarioNotificacion_fechaSeguimiento.Size = New System.Drawing.Size(44, 13)
        Me.lbltbOperarioNotificacion_fechaSeguimiento.TabIndex = 10
        Me.lbltbOperarioNotificacion_fechaSeguimiento.Text = "Fecha "
        '
        'btnNotificacionesNuevo
        '
        Me.btnNotificacionesNuevo.Location = New System.Drawing.Point(21, 184)
        Me.btnNotificacionesNuevo.Name = "btnNotificacionesNuevo"
        Me.btnNotificacionesNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNotificacionesNuevo.TabIndex = 8
        Me.btnNotificacionesNuevo.Text = "GUARDAR"
        '
        'tabBajasCC
        '
        Me.tabBajasCC.Controls.Add(Me.GridBajas)
        Me.tabBajasCC.Controls.Add(Me.btnBajasH)
        Me.tabBajasCC.Controls.Add(Me.sle_bajas_descripcion)
        Me.tabBajasCC.Controls.Add(Me.lbltbOperarioAlertas_descripcion)
        Me.tabBajasCC.Controls.Add(Me.sle_bajas_seguimiento)
        Me.tabBajasCC.Controls.Add(Me.lbltbOperarioAlertas_seguimiento)
        Me.tabBajasCC.Controls.Add(Me.GridCorreoBajas)
        Me.tabBajasCC.Controls.Add(Me.UiCB_BajasE)
        Me.tabBajasCC.Controls.Add(Me.lbltbOperarioAlertas_encargado)
        Me.tabBajasCC.Controls.Add(Me.UiCheck_bajas_baja)
        Me.tabBajasCC.Controls.Add(Me.ulbDescObra)
        Me.tabBajasCC.Controls.Add(Me.AdvS_Bajas_Obra)
        Me.tabBajasCC.Controls.Add(Me.lbltbOperarioAlertas_lugar)
        Me.tabBajasCC.Controls.Add(Me.ClB_Bajas_Email)
        Me.tabBajasCC.Controls.Add(Me.lbltbOperarioAlertas_fEmail)
        Me.tabBajasCC.Controls.Add(Me.ClB_Bajas_conf)
        Me.tabBajasCC.Controls.Add(Me.lbltbOperarioAlertas_fConf)
        Me.tabBajasCC.Controls.Add(Me.sle_Bajas_Dias)
        Me.tabBajasCC.Controls.Add(Me.lbltbOperarioAlertas_nDias)
        Me.tabBajasCC.Controls.Add(Me.ClB_Bajas_Alta)
        Me.tabBajasCC.Controls.Add(Me.lbltbOperarioAlertas_fAlta)
        Me.tabBajasCC.Controls.Add(Me.ClB_Bajas_Baja)
        Me.tabBajasCC.Controls.Add(Me.lbltbOperarioAlertas_fBaja)
        Me.tabBajasCC.Controls.Add(Me.btnBajasN)
        Me.tabBajasCC.Location = New System.Drawing.Point(1, 21)
        Me.tabBajasCC.Name = "tabBajasCC"
        Me.tabBajasCC.Size = New System.Drawing.Size(944, 427)
        Me.tabBajasCC.TabStop = True
        Me.tabBajasCC.Text = "Bajas CC"
        '
        'GridBajas
        '
        Me.GridBajas.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridBajas_DesignTimeLayout.LayoutString = resources.GetString("GridBajas_DesignTimeLayout.LayoutString")
        Me.GridBajas.DesignTimeLayout = GridBajas_DesignTimeLayout
        Me.GridBajas.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridBajas.EntityName = "PrevencionAlertas"
        Me.GridBajas.Location = New System.Drawing.Point(95, 223)
        Me.GridBajas.Name = "GridBajas"
        Me.GridBajas.PrimaryDataFields = "IDOperario"
        Me.GridBajas.SecondaryDataFields = "idOperario"
        Me.GridBajas.Size = New System.Drawing.Size(839, 170)
        Me.GridBajas.TabIndex = 48
        Me.GridBajas.ViewName = "vFrmPrevencionAlertas_hist"
        '
        'btnBajasH
        '
        Me.btnBajasH.Location = New System.Drawing.Point(10, 223)
        Me.btnBajasH.Name = "btnBajasH"
        Me.btnBajasH.Size = New System.Drawing.Size(75, 23)
        Me.btnBajasH.TabIndex = 47
        Me.btnBajasH.Text = "Historico ..."
        '
        'sle_bajas_descripcion
        '
        Me.TryDataBinding(sle_bajas_descripcion, New System.Windows.Forms.Binding("Text", Me, "tbOperarioAlertas_descripcion", True))
        Me.sle_bajas_descripcion.DisabledBackColor = System.Drawing.Color.White
        Me.sle_bajas_descripcion.Location = New System.Drawing.Point(95, 161)
        Me.sle_bajas_descripcion.Multiline = True
        Me.sle_bajas_descripcion.Name = "sle_bajas_descripcion"
        Me.sle_bajas_descripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.sle_bajas_descripcion.Size = New System.Drawing.Size(532, 53)
        Me.sle_bajas_descripcion.TabIndex = 29
        '
        'lbltbOperarioAlertas_descripcion
        '
        Me.lbltbOperarioAlertas_descripcion.Location = New System.Drawing.Point(7, 161)
        Me.lbltbOperarioAlertas_descripcion.Name = "lbltbOperarioAlertas_descripcion"
        Me.lbltbOperarioAlertas_descripcion.Size = New System.Drawing.Size(73, 13)
        Me.lbltbOperarioAlertas_descripcion.TabIndex = 30
        Me.lbltbOperarioAlertas_descripcion.Text = "Descripción"
        '
        'sle_bajas_seguimiento
        '
        Me.TryDataBinding(sle_bajas_seguimiento, New System.Windows.Forms.Binding("Text", Me, "tbOperarioAlertas_seguimiento", True))
        Me.sle_bajas_seguimiento.DisabledBackColor = System.Drawing.Color.White
        Me.sle_bajas_seguimiento.Location = New System.Drawing.Point(95, 105)
        Me.sle_bajas_seguimiento.Multiline = True
        Me.sle_bajas_seguimiento.Name = "sle_bajas_seguimiento"
        Me.sle_bajas_seguimiento.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.sle_bajas_seguimiento.Size = New System.Drawing.Size(532, 51)
        Me.sle_bajas_seguimiento.TabIndex = 27
        '
        'lbltbOperarioAlertas_seguimiento
        '
        Me.lbltbOperarioAlertas_seguimiento.Location = New System.Drawing.Point(7, 109)
        Me.lbltbOperarioAlertas_seguimiento.Name = "lbltbOperarioAlertas_seguimiento"
        Me.lbltbOperarioAlertas_seguimiento.Size = New System.Drawing.Size(78, 13)
        Me.lbltbOperarioAlertas_seguimiento.TabIndex = 28
        Me.lbltbOperarioAlertas_seguimiento.Text = "Seguimiento"
        '
        'GridCorreoBajas
        '
        GridCorreoBajas_DesignTimeLayout.LayoutString = resources.GetString("GridCorreoBajas_DesignTimeLayout.LayoutString")
        Me.GridCorreoBajas.DesignTimeLayout = GridCorreoBajas_DesignTimeLayout
        Me.GridCorreoBajas.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridCorreoBajas.EntityName = "PrevencionEmail"
        Me.GridCorreoBajas.Location = New System.Drawing.Point(633, 79)
        Me.GridCorreoBajas.Name = "GridCorreoBajas"
        Me.GridCorreoBajas.PrimaryDataFields = "IDOperario"
        Me.GridCorreoBajas.SecondaryDataFields = "idOperario"
        Me.GridCorreoBajas.Size = New System.Drawing.Size(301, 135)
        Me.GridCorreoBajas.TabIndex = 26
        Me.GridCorreoBajas.ViewName = "vFrmPrevencionEmail_baj"
        '
        'UiCB_BajasE
        '
        Me.TryDataBinding(UiCB_BajasE, New System.Windows.Forms.Binding("Value", Me, "tbOperarioAlertas_encargado", True))
        UiCB_BajasE_DesignTimeLayout.LayoutString = resources.GetString("UiCB_BajasE_DesignTimeLayout.LayoutString")
        Me.UiCB_BajasE.DesignTimeLayout = UiCB_BajasE_DesignTimeLayout
        Me.UiCB_BajasE.DisabledBackColor = System.Drawing.Color.White
        Me.UiCB_BajasE.Location = New System.Drawing.Point(206, 79)
        Me.UiCB_BajasE.Name = "UiCB_BajasE"
        Me.UiCB_BajasE.SelectedIndex = -1
        Me.UiCB_BajasE.SelectedItem = Nothing
        Me.UiCB_BajasE.Size = New System.Drawing.Size(421, 21)
        Me.UiCB_BajasE.TabIndex = 24
        '
        'lbltbOperarioAlertas_encargado
        '
        Me.lbltbOperarioAlertas_encargado.Location = New System.Drawing.Point(133, 82)
        Me.lbltbOperarioAlertas_encargado.Name = "lbltbOperarioAlertas_encargado"
        Me.lbltbOperarioAlertas_encargado.Size = New System.Drawing.Size(67, 13)
        Me.lbltbOperarioAlertas_encargado.TabIndex = 25
        Me.lbltbOperarioAlertas_encargado.Text = "Encargado"
        '
        'UiCheck_bajas_baja
        '
        Me.TryDataBinding(UiCheck_bajas_baja, New System.Windows.Forms.Binding("BindableValue", Me, "tbOperarioAlertas_snotrosPaises", True))
        Me.UiCheck_bajas_baja.Location = New System.Drawing.Point(10, 78)
        Me.UiCheck_bajas_baja.Name = "UiCheck_bajas_baja"
        Me.UiCheck_bajas_baja.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.UiCheck_bajas_baja.Size = New System.Drawing.Size(117, 19)
        Me.UiCheck_bajas_baja.TabIndex = 23
        Me.UiCheck_bajas_baja.Text = "Baja Otros Paises"
        '
        'ulbDescObra
        '
        Me.TryDataBinding(ulbDescObra, New System.Windows.Forms.Binding("Text", Me.AdvS_Bajas_Obra, "DescObra", True))
        Me.ulbDescObra.Location = New System.Drawing.Point(381, 50)
        Me.ulbDescObra.Name = "ulbDescObra"
        Me.ulbDescObra.Size = New System.Drawing.Size(528, 23)
        Me.ulbDescObra.TabIndex = 22
        '
        'AdvS_Bajas_Obra
        '
        Me.TryDataBinding(AdvS_Bajas_Obra, New System.Windows.Forms.Binding("Text", Me, "tbOperarioAlertas_lugar", True))
        Me.AdvS_Bajas_Obra.DisabledBackColor = System.Drawing.Color.White
        Me.AdvS_Bajas_Obra.DisplayField = "NObra"
        Me.AdvS_Bajas_Obra.EntityName = "ObraCabecera"
        Me.AdvS_Bajas_Obra.Location = New System.Drawing.Point(280, 50)
        Me.AdvS_Bajas_Obra.Name = "AdvS_Bajas_Obra"
        Me.AdvS_Bajas_Obra.PrimaryDataFields = "tbOperarioAlertas_lugar"
        Me.AdvS_Bajas_Obra.SecondaryDataFields = "IDObra"
        Me.AdvS_Bajas_Obra.Size = New System.Drawing.Size(95, 23)
        Me.AdvS_Bajas_Obra.TabIndex = 20
        Me.AdvS_Bajas_Obra.ViewName = "tbObraCabecera"
        '
        'lbltbOperarioAlertas_lugar
        '
        Me.lbltbOperarioAlertas_lugar.Location = New System.Drawing.Point(235, 55)
        Me.lbltbOperarioAlertas_lugar.Name = "lbltbOperarioAlertas_lugar"
        Me.lbltbOperarioAlertas_lugar.Size = New System.Drawing.Size(39, 13)
        Me.lbltbOperarioAlertas_lugar.TabIndex = 21
        Me.lbltbOperarioAlertas_lugar.Text = "Lugar"
        '
        'ClB_Bajas_Email
        '
        Me.TryDataBinding(ClB_Bajas_Email, New System.Windows.Forms.Binding("BindableValue", Me, "tbOperarioAlertas_fEmail", True))
        Me.ClB_Bajas_Email.DisabledBackColor = System.Drawing.Color.White
        Me.ClB_Bajas_Email.Location = New System.Drawing.Point(788, 18)
        Me.ClB_Bajas_Email.Name = "ClB_Bajas_Email"
        Me.ClB_Bajas_Email.Size = New System.Drawing.Size(121, 21)
        Me.ClB_Bajas_Email.TabIndex = 18
        '
        'lbltbOperarioAlertas_fEmail
        '
        Me.lbltbOperarioAlertas_fEmail.Location = New System.Drawing.Point(667, 22)
        Me.lbltbOperarioAlertas_fEmail.Name = "lbltbOperarioAlertas_fEmail"
        Me.lbltbOperarioAlertas_fEmail.Size = New System.Drawing.Size(115, 13)
        Me.lbltbOperarioAlertas_fEmail.TabIndex = 19
        Me.lbltbOperarioAlertas_fEmail.Text = "Fecha Seguimiento"
        '
        'ClB_Bajas_conf
        '
        Me.TryDataBinding(ClB_Bajas_conf, New System.Windows.Forms.Binding("BindableValue", Me, "tbOperarioAlertas_fConf", True))
        Me.ClB_Bajas_conf.DisabledBackColor = System.Drawing.Color.White
        Me.ClB_Bajas_conf.Location = New System.Drawing.Point(108, 51)
        Me.ClB_Bajas_conf.Name = "ClB_Bajas_conf"
        Me.ClB_Bajas_conf.Size = New System.Drawing.Size(121, 21)
        Me.ClB_Bajas_conf.TabIndex = 16
        '
        'lbltbOperarioAlertas_fConf
        '
        Me.lbltbOperarioAlertas_fConf.Location = New System.Drawing.Point(7, 55)
        Me.lbltbOperarioAlertas_fConf.Name = "lbltbOperarioAlertas_fConf"
        Me.lbltbOperarioAlertas_fConf.Size = New System.Drawing.Size(95, 13)
        Me.lbltbOperarioAlertas_fConf.TabIndex = 17
        Me.lbltbOperarioAlertas_fConf.Text = "F. Confirmacion"
        '
        'sle_Bajas_Dias
        '
        Me.TryDataBinding(sle_Bajas_Dias, New System.Windows.Forms.Binding("Text", Me, "tbOperarioAlertas_nDias", True))
        Me.sle_Bajas_Dias.DisabledBackColor = System.Drawing.Color.White
        Me.sle_Bajas_Dias.Enabled = False
        Me.sle_Bajas_Dias.Location = New System.Drawing.Point(566, 18)
        Me.sle_Bajas_Dias.Name = "sle_Bajas_Dias"
        Me.sle_Bajas_Dias.Size = New System.Drawing.Size(64, 21)
        Me.sle_Bajas_Dias.TabIndex = 14
        '
        'lbltbOperarioAlertas_nDias
        '
        Me.lbltbOperarioAlertas_nDias.Location = New System.Drawing.Point(498, 22)
        Me.lbltbOperarioAlertas_nDias.Name = "lbltbOperarioAlertas_nDias"
        Me.lbltbOperarioAlertas_nDias.Size = New System.Drawing.Size(62, 13)
        Me.lbltbOperarioAlertas_nDias.TabIndex = 15
        Me.lbltbOperarioAlertas_nDias.Text = "Dias Baja"
        '
        'ClB_Bajas_Alta
        '
        Me.TryDataBinding(ClB_Bajas_Alta, New System.Windows.Forms.Binding("BindableValue", Me, "tbOperarioAlertas_fAlta", True))
        Me.ClB_Bajas_Alta.DisabledBackColor = System.Drawing.Color.White
        Me.ClB_Bajas_Alta.Location = New System.Drawing.Point(343, 18)
        Me.ClB_Bajas_Alta.Name = "ClB_Bajas_Alta"
        Me.ClB_Bajas_Alta.Size = New System.Drawing.Size(121, 21)
        Me.ClB_Bajas_Alta.TabIndex = 12
        '
        'lbltbOperarioAlertas_fAlta
        '
        Me.lbltbOperarioAlertas_fAlta.Location = New System.Drawing.Point(271, 22)
        Me.lbltbOperarioAlertas_fAlta.Name = "lbltbOperarioAlertas_fAlta"
        Me.lbltbOperarioAlertas_fAlta.Size = New System.Drawing.Size(66, 13)
        Me.lbltbOperarioAlertas_fAlta.TabIndex = 13
        Me.lbltbOperarioAlertas_fAlta.Text = "Fecha Alta"
        '
        'ClB_Bajas_Baja
        '
        Me.TryDataBinding(ClB_Bajas_Baja, New System.Windows.Forms.Binding("BindableValue", Me, "tbOperarioAlertas_fBaja", True))
        Me.ClB_Bajas_Baja.DisabledBackColor = System.Drawing.Color.White
        Me.ClB_Bajas_Baja.Location = New System.Drawing.Point(168, 18)
        Me.ClB_Bajas_Baja.Name = "ClB_Bajas_Baja"
        Me.ClB_Bajas_Baja.Size = New System.Drawing.Size(97, 21)
        Me.ClB_Bajas_Baja.TabIndex = 10
        '
        'lbltbOperarioAlertas_fBaja
        '
        Me.lbltbOperarioAlertas_fBaja.Location = New System.Drawing.Point(92, 22)
        Me.lbltbOperarioAlertas_fBaja.Name = "lbltbOperarioAlertas_fBaja"
        Me.lbltbOperarioAlertas_fBaja.Size = New System.Drawing.Size(70, 13)
        Me.lbltbOperarioAlertas_fBaja.TabIndex = 11
        Me.lbltbOperarioAlertas_fBaja.Text = "Fecha Baja"
        '
        'btnBajasN
        '
        Me.btnBajasN.Location = New System.Drawing.Point(10, 16)
        Me.btnBajasN.Name = "btnBajasN"
        Me.btnBajasN.Size = New System.Drawing.Size(75, 23)
        Me.btnBajasN.TabIndex = 9
        Me.btnBajasN.Text = "GUARDAR"
        '
        'MntoPrevencionOperario
        '
        Me.ClientSize = New System.Drawing.Size(954, 761)
        Me.EntityName = "PrevencionTecozamCabecera"
        Me.Name = "MntoPrevencionOperario"
        Me.NavigationFields = "Ordenacion"
        Me.ViewName = "vMntoBusquedaPrevencion"
        CType(Me.ToolBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.tabOperarioPrev, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabOperarioPrev.ResumeLayout(False)
        Me.tabReconocimiento.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.GridReconocimiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridCorreoReconocimiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPuestos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabFormacion.ResumeLayout(False)
        CType(Me.Tab2Formacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tab2Formacion.ResumeLayout(False)
        Me.UiTabPageFInterna.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.GridFInterna_hist, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UICB_FormacionI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiTabPageFExterna.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.GridFExterna_hist, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCB_FormacionE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiTabPageFormFLC.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Fr50.ResumeLayout(False)
        Me.Fr50.PerformLayout()
        CType(Me.GridFormacion50, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCB_Formacion50, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Fr20.ResumeLayout(False)
        Me.Fr20.PerformLayout()
        CType(Me.GridFormacion20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCB_Formacion20, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fr8.ResumeLayout(False)
        Me.fr8.PerformLayout()
        Me.TabPageTPC.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.GridFiltroCurso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridTPC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageEpis.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.GridEpis_hist, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCB_Epi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabAccidentes.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        CType(Me.GridAccidentes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridCorreoAcc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCB_AccidentesJ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCB_AccidentesE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabNotificaciones.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        CType(Me.GridNotificacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame2.ResumeLayout(False)
        CType(Me.UiCB_NotificacionesJ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCB_NotificacionesS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCB_NotificacionesE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabBajasCC.ResumeLayout(False)
        Me.tabBajasCC.PerformLayout()
        CType(Me.GridBajas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridCorreoBajas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCB_BajasE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtIDOperario As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblIDOperario As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents clbFechaAlta As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFechaAlta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtTipoContrato As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblTipoContrato As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtDescOperario As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents UiCheckBox1 As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents clbFecha_Nacimiento As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFecha_Nacimiento As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents clbFecha_Baja As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFecha_Baja As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtDNI As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblDNI As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtProvincia As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblProvincia As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtPoblacion As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblPoblacion As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtDireccion As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblDireccion As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtNifPortu As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblNifPortu As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtN_Social As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblN_Social As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advCodPostal As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblCodPostal As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDPais As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblIDPais As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ulbDescPais As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents Panel1 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents advIDCategoria As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblIDCategoria As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtTelefono As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblTelefono As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ulbDescCategoria As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents txtEmail As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblEmail As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtFax As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblFax As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDOficio As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblIDOficio As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents tabOperarioPrev As Solmicro.Expertis.Engine.UI.Tab
    Friend WithEvents ulbDescDepartamento As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents advIDDepartamento As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblIDDepartamento As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ulbDescOficio As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents tabReconocimiento As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents tabFormacion As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents tabAccidentes As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents tabNotificaciones As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents tabBajasCC As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents txtLugarReconocimiento As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lbltbOperarioReconocimiento_Lugar As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents RB_Reconocimiento_Apto As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents RB_Reconocimiento_ap As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents RB_Reconocimiento_no As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents clbFechaReconocimiento As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lbltbOperarioReconocimiento_Fecha As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents brnRecon As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents GridPuestos As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents UiCheckSensible As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents lbltbOperarioReconocimiento_snSensible As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtdesSensible As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lbltbOperarioReconocimiento_desSensible As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents clbtbOperarioReconocimiento_nDiasAviso As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lbltbOperarioReconocimiento_nDiasAviso As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtdesLimitacion As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents UICheckLimitaciones As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents lbltbOperarioReconocimiento_snLimitacion As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Label1 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents GridCorreoReconocimiento As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents GridReconocimiento As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents btnRecoh As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents Panel2 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents Tab2Formacion As Solmicro.Expertis.Engine.UI.Tab
    Friend WithEvents UiTabPageFInterna As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents Panel3 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents Label2 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents GridFInterna_hist As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents clb_FInterna_fecha As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblvFrmPrevencionFormacion50_fecha As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents SLE_FInterna_Horas As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblvFrmPrevencionFormacionI_Horas As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents SLE_FInterna_Especificar As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblvFrmPrevencionFormacionI_DesFormacion As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents UICB_FormacionI As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblvFrmPrevencionFormacionI_DescClaseFormacion As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents chbvFrmPrevencionFormacionI_snEspecifica As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents lblvFrmPrevencionFormacionI_snEspecifica As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents chbvFrmPrevencionFormacionI_snPuesto As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents lblvFrmPrevencionFormacionI_snPuesto As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents btnFInternaNew As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents UiTabPageFExterna As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents Panel4 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents GridFExterna_hist As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents Label3 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ClB_FExterna_Fecha As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblvFrmPrevencionFormacionE_Horas1 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents SLE_FExternaHoras As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblvFrmPrevencionFormacionE_Horas As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents SLE_FExterna_Especificar As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblvFrmPrevencionFormacionE_DesFormacion As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents UiCB_FormacionE As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblvFrmPrevencionFormacionI_DescClaseFormacion1 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents btnFExternaNew As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents UiTabPageFormFLC As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents Panel5 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents fr8 As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents SLE_FFLC_Lugar8 As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblvFrmPrevencionFormacion8_lugar As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Fr20 As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents Frame1 As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents txtvFrmPrevencionFormacion8_empresaforma As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblvFrmPrevencionFormacion8_empresaforma As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ClB_FFLC_Fecha8 As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblvFrmPrevencionFormacion8_fecha As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Fr50 As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents btnF20 As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents Label4 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents SLE_FFLC_Empresa20 As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents UiCheck20 As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents UiCB_Formacion20 As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblvFrmPrevencionFormacion20_DescClaseFormacion As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents GridFormacion20 As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents SLE_FFLC_Lugar20 As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblvFrmPrevencionFormacion20_Lugar As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ClB_FFLC_Fecha20 As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblvFrmPrevencionFormacion20_fecha As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents btnF50 As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents UiCB_Formacion50 As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblvFrmPrevencionFormacion50_DescClaseFormacion As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents SLE_FFLC_Lugar50 As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblvFrmPrevencionFormacion50_Lugar As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents SLE_FFLC_Empresa50 As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents Label5 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents GridFormacion50 As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents clbvFrmPrevencionFormacion50_fecha As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblvFrmPrevencionFormacion50_fecha1 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents TabPageTPC As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents Panel6 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents Label7 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Label6 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents GridFiltroCurso As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents GridTPC As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents SLE_FTPC_Observaciones As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblvFrmPrevencionFormacionTPC_DesFormacion As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents chbvFrmPrevencionFormacionTPC_sntpc As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents SLE_FTPC_Contraseña As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblvFrmPrevencionFormacionTPC_password As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents SLE_FTPC_Usuario As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblvFrmPrevencionFormacionTPC_usuario As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents TabPageEpis As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents Panel7 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents ClB_EPIS_Fecha As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lbltbOperarioEpis_fecha As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents btnEPIS As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents UiCB_Epi As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lbltbOperarioEpis_DesEpis As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Label8 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents GridEpis_hist As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents SLE_EPIS_Equipo As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lbltbOperarioEpis_DesAdicional As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Panel8 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents ClB_Accidentes_Fbaja As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lbltbOperarioAccidentes_fbaja As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ClB_Accidentes_FAccidente As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lbltbOperarioAccidentes_faccidente As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents btnAccidentessn As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents clbtbOperarioAccidentes_falta As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lbltbOperarioAccidentes_falta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents sle_Accidentes_Dias As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lbltbOperarioAccidentes_nDiasBaja As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents clbtbOperarioAccidentes_fNotificacion As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lbltbOperarioAccidentes_fNotificacion As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents RB_Accidentes_SinBaja As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents rbttbOperarioAccidentes_tipo2 As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents RB_Accidentes_Grave As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents RB_Accidentes_leve As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents SLE_Accidentes_Lugar As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lbltbOperarioAccidentes_Lugar As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents UiC_Accidentes_Recaida As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents UiCB_AccidentesE As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lbl_ACC_Encargado As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents UiCB_AccidentesJ As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lbltbOperarioAccidentes_JefeProd As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvS_Accidentes_Obra As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lbltbOperarioAccidentes_codobra As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Ul_Accidentes_obra As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents GridCorreoAcc As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents UiC_Accidentes_Investigacion As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents UiC_Accidentes_Obra As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents ClB_Accidentes_Requiere As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lbltbOperarioAccidentes_fechaseg As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents UiC_Accidentes_Requiere As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents SLE_Accidentes_Seguimiento As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lbltbOperarioAccidentes_desSeguimiento As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents SLE_Accidentes_Descripcion As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lbltbOperarioAccidentes_descripcioninves As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents GridAccidentes As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents btnAccidentesH As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents Panel9 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents AdS_Notificaciones_Obra As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lbltbOperarioNotificacion_idobra As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ClB_Notificaciones_Fecha As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lbltbOperarioNotificacion_fechaSeguimiento As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents btnNotificacionesNuevo As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents UL_Notificaciones_Obra As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents UiCB_NotificacionesE As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lbltbOperarioNotificacion_Encargado As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents UiCB_NotificacionesJ As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lbltbOperarioNotificacion_JefeProd As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents UiC_Notificaciones_Recibida As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents UiCB_NotificacionesS As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lbltbOperarioNotificacion_DescSancion As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Frame2 As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents RB_Notificaciones_Grave As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents RB_Notificaciones_leve As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents RB_Notificaciones_MuyGrave As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents SLE_Notificaciones_Observaciones As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lbltbOperarioNotificacion_Observaciones As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents GridNotificacion As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents btnNotificacionesN As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents SLE_Notificaciones_Tipo As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lbltbOperarioNotificacion_tipo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents btnBajasN As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents ClB_Bajas_conf As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lbltbOperarioAlertas_fConf As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents sle_Bajas_Dias As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lbltbOperarioAlertas_nDias As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ClB_Bajas_Alta As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lbltbOperarioAlertas_fAlta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ClB_Bajas_Baja As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lbltbOperarioAlertas_fBaja As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ClB_Bajas_Email As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lbltbOperarioAlertas_fEmail As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvS_Bajas_Obra As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lbltbOperarioAlertas_lugar As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents UiCheck_bajas_baja As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents ulbDescObra As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents GridCorreoBajas As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents UiCB_BajasE As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lbltbOperarioAlertas_encargado As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents GridBajas As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents btnBajasH As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents sle_bajas_descripcion As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lbltbOperarioAlertas_descripcion As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents sle_bajas_seguimiento As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lbltbOperarioAlertas_seguimiento As Solmicro.Expertis.Engine.UI.Label

End Class
