Imports Solmicro.Expertis.Engine.UI
Imports Expertis.Business.Prevencion
Imports Solmicro.Expertis.Engine

Public Class MntoPrevencionAdmin

    Inherits Solmicro.Expertis.Engine.UI.SimpleMnto

    Dim obj As New Funciones

    Private Sub MntoPrevencionAdmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.FindText.Visible = Janus.Windows.UI.InheritableBoolean.False
        Me.GoFirst.Visible = Janus.Windows.UI.InheritableBoolean.False
        Me.GoNext.Visible = Janus.Windows.UI.InheritableBoolean.False
        Me.GoLast.Visible = Janus.Windows.UI.InheritableBoolean.True
        Me.GoPrevious.Visible = Janus.Windows.UI.InheritableBoolean.False
        Me.Requery.Visible = Janus.Windows.UI.InheritableBoolean.False
        '' Busqueda
        Me.Search.Visible = Janus.Windows.UI.InheritableBoolean.False
        Me.Find.Visible = Janus.Windows.UI.InheritableBoolean.False
        Me.NewRow.Visible = Janus.Windows.UI.InheritableBoolean.False
        Me.Delete.Visible = Janus.Windows.UI.InheritableBoolean.False
        '' Acciones del play
        Me.FormActions.Add("Listado obras finalizadas con horas", AddressOf ListObraHoras)
        Me.FormActions.Add("Excel Grid General", AddressOf ExcelCab)
        Me.FormActions.Add("Excel Grid Reconocimientos", AddressOf ExcelReco)
        Me.FormActions.Add("Excel Grid Accidentes", AddressOf ExcelAcc)
        Me.FormActions.Add("Excel Grid Notificaciones", AddressOf ExcelNotif)
        Me.FormActions.Add("Excel Grid Bajas CC", AddressOf ExcelBajas)

        ' Cargar datos
        aplicarFiltros(False)
        CargarCombos()

    End Sub


#Region "Funciones"
    Private Sub aplicarFiltros(ByVal baplicar As Boolean)
        Try
            Dim ssqlGen, sin, sclausula As String
            Dim dDatos As DataTable
            If baplicar = False Then
                ssqlGen = "select * from " & GridGen.ViewName & " where idOperario is null"
                ' Cargar datos
                Me.RequeryData()
            Else
                ssqlGen = "select * from " & GridGen.ViewName & " where idOperario is not null"
                sclausula = " and "
                ' Cabecera, lo cargo con el de reco
                sin = FiltrosCab()
                If sin.Length > 0 Then
                    ssqlGen &= " and idoperario in(" & sin & ")"
                End If
                sin = FiltrosReco()
                If sin.Length > 0 Then
                    ssqlGen &= sclausula & " idoperario in(" & sin & ")"
                    sclausula = " or "
                End If

                sin = FiltrosAcc()
                If sin.Length > 0 Then
                    ssqlGen &= sclausula & " idoperario in(" & sin & ")"
                    sclausula = " or "
                End If

                sin = FiltrosNotif()
                If sin.Length > 0 Then
                    ssqlGen &= sclausula & " idoperario in(" & sin & ")"
                    sclausula = " or "
                End If

                sin = FiltrosBajascc()
                If sin.Length > 0 Then
                    ssqlGen &= sclausula & " idoperario in(" & sin & ")"
                    sclausula = " or "
                End If

                sin = FiltrosFI()
                If sin.Length > 0 Then
                    ssqlGen &= sclausula & " idoperario in(" & sin & ")"
                    sclausula = " or "
                End If

                sin = FiltrosFE()
                If sin.Length > 0 Then
                    ssqlGen &= sclausula & " idoperario in(" & sin & ")"
                    sclausula = " or "
                End If

                sin = FiltrosFLC()
                If sin.Length > 0 Then
                    ssqlGen &= sclausula & " idoperario in(" & sin & ")"
                    sclausula = " or "
                End If

                sin = FiltrosTpc()
                If sin.Length > 0 Then
                    ssqlGen &= sclausula & " idoperario in(" & sin & ")"
                    sclausula = " or "
                End If

                sin = FiltrosEPIS()
                If sin.Length > 0 Then
                    ssqlGen &= sclausula & " idoperario in(" & sin & ")"
                    sclausula = " or "
                End If

            End If

            If baplicar = True Then
                Dim dt As New DataTable
                Dim filtro As New Filter
                filtro.Add("IDOperario", FilterOperator.Equal, txtIDOperario.Text)
                dt = New BE.DataEngine().Filter("vMntoBusquedaPrevencion", filtro)
                'Dim ssqlGen2 As String
                'ssqlGen2 = "select * from " & GridGen.ViewName & " where idOperario = " & txtIDOperario.Text
                'dDatos = obj.RecogeDatos(ssqlGen2)
                GridGen.DataSource = dt
                Me.RequeryData()
            End If

            'MsgBox(ssql)
        Catch ex As Exception
            MsgBox("Error al aplicar filtros." & ex.Message, MsgBoxStyle.Critical, "Error aplicado filtros.")
        End Try

    End Sub

    Private Function FiltrosCab() As String
        Dim sselectcab, swhere As String
        ' Componer la select original
        sselectcab = "Select tbMaestroOperario.IDOperario from tbMaestroOperario "

        If UICheckACtivo.Checked = True Then
            swhere = " where fecha_baja is null"
        Else
            swhere = " where IDOperario is not null"
        End If

        If txtIDOperario.Text.Length > 0 Then
            swhere &= " and tbMaestroOperario.IDOperario = '" & txtIDOperario.Text & "'"
        End If

        If txtDescOperario.Text.Length > 0 Then
            swhere &= " and tbMaestroOperario.DescOperario like '" & txtDescOperario.Text & "%'"
        End If

        ' Bien Retornar si se ha filtrado
        sselectcab = sselectcab & swhere

        Return sselectcab

    End Function

    Private Function FiltrosReco() As String
        Dim sselect, swhere As String
        Dim dDatosReco As DataTable
        ' Componer la select original
        sselect = "Select * from  " & GridReco.ViewName
        ' Filtros Cabecera
        If UICheckACtivo.Checked = True Then
            swhere = " where fecha_baja is null"
        Else
            swhere = " where IDOperario is not null"
        End If
        ' Los recos tienen fecha, quita filas nuevas
        swhere &= " and tbOperarioReconocimiento_fecha is not null "

        If txtIDOperario.Text.Length > 0 Then
            swhere &= " and iDOperario = '" & txtIDOperario.Text & "'"
        End If

        If txtDescOperario.Text.Length > 0 Then
            swhere &= " and DescOperario like '" & txtDescOperario.Text & "%'"
        End If
        ' Filtro Reco

        If IsDate(clbFechaReconocimientod.Value) = True Then
            swhere &= " and tbOperarioReconocimiento_fecha>= '" & clbFechaReconocimientod.Value & "'"
        End If

        If IsDate(clbFechaReconocimientoh.Value) = True Then
            swhere &= " and tbOperarioReconocimiento_fecha<= '" & clbFechaReconocimientoh.Value & "'"
        End If

        If UiComboReco.Value > 0 Then
            swhere &= " and tbOperarioReconocimiento_snApto = " & UiComboReco.Value

        End If

        If UiCheckSensible.Checked Then
            swhere &= " and tbOperarioReconocimiento_snSensible = 1"
        End If

        If UiCheckLimitaciones.Checked Then
            swhere &= " and tbOperarioReconocimiento_snLimitacion = 1"
        End If

        ' Coger la filas marcadas
        If Not IsNothing(GridPuesto.CheckedRecords) Then
            Dim spuestos As String = ""
            For Each dfila As DataRow In GridPuesto.CheckedRecords.Rows
                spuestos &= "'" & dfila("DescPuesto") & "',"
            Next
            If Not IsNothing(spuestos) Then
                spuestos = Strings.Left(spuestos, spuestos.Length - 1)
                swhere &= " and tbOperarioReconocimiento_idOficio in(" & spuestos & ")"
            End If
            GridPuesto.UnCheckAllRecords()
        End If
        ' Bien Retornar si se ha filtrado
        If Not IsNothing(swhere) Then
            dDatosReco = obj.RecogeDatos(sselect & swhere)
            GridReco.DataSource = dDatosReco
            Return Replace(sselect, "*", "idOperario") & swhere
        End If
        Return ""

    End Function

    Private Function FiltrosAcc() As String
        Dim sselect, swhere As String
        Dim dDatosAcc As DataTable
        ' Componer la select original
        sselect = "Select * from  " & GridAcc.ViewName
        ' Filtros Cabecera
        If UICheckACtivo.Checked = True Then
            swhere = " where fecha_baja is null"
        Else
            swhere = " where IDOperario is not null"
        End If

        If txtIDOperario.Text.Length > 0 Then
            swhere &= " and iDOperario = '" & txtIDOperario.Text & "'"
        End If

        If txtDescOperario.Text.Length > 0 Then
            swhere &= " and DescOperario like '" & txtDescOperario.Text & "%'"
        End If
        ' Filtros Acc
        If UICheckAccidentesb.Checked = True Then
            swhere &= " and (tbOperarioAccidentes_fBaja is not null and tbOperarioAccidentes_fAlta is null)"
        End If

        If IsDate(clbFechaAccidentesd.Value) = True Then
            swhere &= " and tbOperarioAccidentes_fBaja >= '" & clbFechaAccidentesd.Value & "'"
        End If

        If IsDate(clbFechaAccidentesh.Value) = True Then
            swhere &= " and tbOperarioAccidentes_fBaja<= '" & clbFechaAccidentesh.Value & "'"
        End If

        If UICB_AccidentesJ.SelectedText <> "" Then
            If UICB_AccidentesJ.SelectedText <> "Todos" Then
                swhere &= " and tbOperarioAccidentes_JefeProd = '" & UICB_AccidentesJ.SelectedText & "'"
            End If
        End If

        If UICB_AccidentesE.SelectedText <> "" Then
            If UICB_AccidentesE.SelectedText <> "Todos" Then
                swhere &= " and tbOperarioAccidentes_Encargado = '" & UICB_AccidentesE.SelectedText & "'"
            End If
        End If
        If AdvS_Accidentes_Obra.Text.Length > 0 Then
            swhere &= " and tbOperarioAccidentes_codObra = " & AdvS_Accidentes_Obra.Value
        End If
        'If Not IsDBNull(AdvS_Accidentes_Obra.Value) Then
        '    swhere &= " and tbOperarioAccidentes_codObra = " & AdvS_Accidentes_Obra.Value
        'End If

        If UICheckAccidentesO.Checked = True Then
            swhere &= " and tbOperarioAccidentes_sninvestigaciono = 1 "
        End If
        If UICheckAccidentesP.Checked = True Then
            swhere &= " and tbOperarioAccidentes_sninvestigacionpre = 1 "
        End If
        If UICheckAccidentesS.Checked = True Then
            swhere &= " and tbOperarioAccidentes_snseguimiento = 1"
        End If

        ' Bien Retornar si se ha filtrado
        If Not IsNothing(swhere) Then
            dDatosAcc = obj.RecogeDatos(sselect & swhere)
            GridAcc.DataSource = dDatosAcc
            Return Replace(sselect, "*", "idOperario") & swhere
        End If
        Return ""

    End Function

    Private Function FiltrosNotif() As String
        Dim sselect, swhere As String
        Dim dDatosNotif As DataTable
        ' Componer la select original
        sselect = "Select * from  " & GridNotif.ViewName
        ' Filtros Cabecera
        If UICheckACtivo.Checked = True Then
            swhere = " where fecha_baja is null"
        Else
            swhere = " where IDOperario is not null"
        End If

        If txtIDOperario.Text.Length > 0 Then
            swhere &= " and iDOperario = '" & txtIDOperario.Text & "'"
        End If

        If txtDescOperario.Text.Length > 0 Then
            swhere &= " and DescOperario like '" & txtDescOperario.Text & "%'"
        End If
        ' Filtros Notif

        If IsDate(clbFechaNotifd.Value) = True Then
            swhere &= " and tbOperarioNotificacion_fechaSeguimiento >= '" & clbFechaNotifd.Value & "'"
        End If

        If IsDate(clbFechaNotifh.Value) = True Then
            swhere &= " and tbOperarioNotificacion_fechaSeguimiento<= '" & clbFechaNotifh.Value & "'"
        End If

        If UICB_NotificacionesJ.SelectedText <> "" Then
            If UICB_NotificacionesJ.SelectedText <> "Todos" Then
                swhere &= " and tbOperarioNotificacion_jefeprod = '" & UICB_NotificacionesJ.SelectedText & "'"
            End If
        End If

        If UICB_NotificacionesE.SelectedText <> "" Then
            If UICB_NotificacionesE.SelectedText <> "Todos" Then
                swhere &= " and tbOperarioNotificacion_Encargado = '" & UICB_NotificacionesE.SelectedText & "'"
            End If
        End If

        If UICB_NotificacionesS.SelectedText <> "" Then
            If UICB_NotificacionesS.SelectedText <> "Todos" Then
                swhere &= " and tbOperarioNotificacion_DescSancion = '" & UICB_NotificacionesS.SelectedText & "'"
            End If
        End If

        ' Bien Retornar si se ha filtrado
        If Not IsNothing(swhere) Then
            dDatosNotif = obj.RecogeDatos(sselect & swhere)
            GridNotif.DataSource = dDatosNotif
            Return Replace(sselect, "*", "idOperario") & swhere
        End If
        Return ""

    End Function

    Private Function FiltrosBajascc() As String
        Dim sselect, swhere As String
        Dim dDatosBajas As DataTable
        ' Componer la select original
        sselect = "Select * from  " & GridBajas.ViewName
        ' Filtros Cabecera
        If UICheckACtivo.Checked = True Then
            swhere = " where fecha_baja is null"
        Else
            swhere = " where IDOperario is not null"
        End If

        If txtIDOperario.Text.Length > 0 Then
            swhere &= " and iDOperario = '" & txtIDOperario.Text & "'"
        End If

        If txtDescOperario.Text.Length > 0 Then
            swhere &= " and DescOperario like '" & txtDescOperario.Text & "%'"
        End If
        ' Filtros Bajas CC
        If UICheckBajasccb.Checked = True Then
            swhere &= " and (tbOperarioAlertas_fBaja is not null and tbOperarioAlertas_fAlta is null)"
        End If

        If IsDate(clBFechaBajasccd.Value) = True Then
            swhere &= " and tbOperarioAlertas_fBaja >= '" & clBFechaBajasccd.Value & "'"
        End If

        If IsDate(clBFechaBajascch.Value) = True Then
            swhere &= " and tbOperarioAlertas_fBaja<= '" & clBFechaBajascch.Value & "'"
        End If



        ' Bien Retornar si se ha filtrado
        If Not IsNothing(swhere) Then
            dDatosBajas = obj.RecogeDatos(sselect & swhere)
            GridBajas.DataSource = dDatosBajas
            Return Replace(sselect, "*", "idOperario") & swhere
        End If
        Return ""

    End Function

    Private Function FiltrosFI() As String
        Dim sselect, swhere As String
        Dim dDatosfi As DataTable
        ' Componer la select original
        sselect = "Select * from  " & GridFI.ViewName
        ' Filtros Cabecera
        If UICheckACtivo.Checked = True Then
            swhere = " where fecha_baja is null"
        Else
            swhere = " where IDOperario is not null"
        End If

        If txtIDOperario.Text.Length > 0 Then
            swhere &= " and iDOperario = '" & txtIDOperario.Text & "'"
        End If

        If txtDescOperario.Text.Length > 0 Then
            swhere &= " and DescOperario like '" & txtDescOperario.Text & "%'"
        End If
        ' Filtros 
        If UIC_FI_snPuesto.Checked = True Then
            swhere &= " and (snPuesto= 1)"
        End If

        If UIC_FI_snEspecifica.Checked = True Then
            swhere &= " and (snEspecifica= 1)"
        End If

        If IsDate(CLB_FInterna_FechaD.Value) = True Then
            swhere &= " and fecha >= '" & CLB_FInterna_FechaD.Value & "'"
        End If

        If IsDate(CLB_FInterna_FechaH.Value) = True Then
            swhere &= " and fecha <= '" & CLB_FInterna_FechaH.Value & "'"
        End If

        If UiCB_FormacionI.SelectedText <> "" Then
            If UiCB_FormacionI.SelectedText <> "Todos" Then
                If UIC_FI_Sin.Checked = False Then
                    swhere &= " and DescClaseFormacion = '" & UiCB_FormacionI.SelectedText & "'"
                Else
                    ' Se tiene que hacer un in porque se quieren los trabajadores que no tengan ese curso
                    swhere &= " and idOperario not in (select idoperario from " & GridFI.ViewName & " where DescClaseFormacion = '" & UiCB_FormacionI.SelectedText & "')"
                End If

            End If
        End If

        ' Bien Retornar si se ha filtrado
        If Not IsNothing(swhere) Then
            dDatosfi = obj.RecogeDatos(sselect & swhere)
            GridFI.DataSource = dDatosfi
            Return Replace(sselect, "*", "idOperario") & swhere
        End If
        Return ""

    End Function

    Private Function FiltrosFE() As String
        Dim sselect, swhere As String
        Dim dDatosfe As DataTable
        ' Componer la select original
        sselect = "Select * from  " & GridFE.ViewName
        ' Filtros Cabecera
        If UICheckACtivo.Checked = True Then
            swhere = " where fecha_baja is null"
        Else
            swhere = " where IDOperario is not null"
        End If

        If txtIDOperario.Text.Length > 0 Then
            swhere &= " and iDOperario = '" & txtIDOperario.Text & "'"
        End If

        If txtDescOperario.Text.Length > 0 Then
            swhere &= " and DescOperario like '" & txtDescOperario.Text & "%'"
        End If
        ' Filtros 
        If IsDate(ClB_Fexterna_Fechad.Value) = True Then
            swhere &= " and fecha >= '" & ClB_Fexterna_Fechad.Value & "'"
        End If

        If IsDate(ClB_Fexterna_Fechah.Value) = True Then
            swhere &= " and fecha <= '" & ClB_Fexterna_Fechah.Value & "'"
        End If

        If UICB_FormacionE.SelectedText <> "" Then
            If UICB_FormacionE.SelectedText <> "Todos" Then
                If UIC_FE_Sin.Checked = False Then
                    swhere &= " and DescClaseFormacion = '" & UICB_FormacionE.SelectedText & "'"
                Else
                    ' Se tiene que hacer un in porque se quieren los trabajadores que no tengan ese curso
                    swhere &= " and idOperario not in (select idoperario from " & GridFE.ViewName & " where DescClaseFormacion = '" & UICB_FormacionE.SelectedText & "')"
                End If

            End If
        End If

        ' Bien Retornar si se ha filtrado
        If Not IsNothing(swhere) Then
            dDatosfe = obj.RecogeDatos(sselect & swhere)
            GridFE.DataSource = dDatosfe
            Return Replace(sselect, "*", "idOperario") & swhere
        End If
        Return ""

    End Function

    Private Function FiltrosFLC() As String
        Dim sselect, swhere, swhere20, swhere50 As String
        Dim sselect8 As String = ""
        Dim sselect20 As String = ""
        Dim sselect50 As String = ""
        Dim swhere8 As String = ""
        Dim scont As Short = 0
        Dim dDatosflc As DataTable
        ' Componer la select original
        sselect = "Select * from  " & GridFLC.ViewName
        ' Filtros Cabecera
        If UICheckACtivo.Checked = True Then
            swhere = " where fecha_baja is null"
        Else
            swhere = " where idOperario is not null "
        End If

        If txtIDOperario.Text.Length > 0 Then
            swhere &= " and iDOperario = '" & txtIDOperario.Text & "'"
        End If

        If txtDescOperario.Text.Length > 0 Then
            swhere &= " and DescOperario like '" & txtDescOperario.Text & "%'"
        End If
        ' Filtros 8
        If UiCB_F8.Value > 0 Then
            If UiCB_F8.Value = 1 Then
                swhere8 &= " and idOperario not in (select idoperario from " & GridFLC.ViewName & " where claseformacion = 8 and lugar IS NOT NULL )"
                scont += 1
            Else
                swhere8 &= " and claseformacion = 8 and lugar IS NOT NULL "
            End If

            If SLE_FFLC_Lugar8.Text.Length > 0 Then
                swhere8 &= " and lugar = '" & SLE_FFLC_Lugar8.Text & "'"
            End If

            If IsDate(ClB_FFLC_Fecha8d.Value) = True Then
                swhere8 &= " and fecha >= '" & ClB_FFLC_Fecha8d.Value & "'"
            End If

            If IsDate(ClB_FFLC_Fecha8h.Value) = True Then
                swhere8 &= " and fecha <= '" & ClB_FFLC_Fecha8h.Value & "'"
            End If
            ' Componer select 8
            If swhere8.Length > 0 Then
                sselect8 = sselect & swhere & swhere8
            End If
        End If

        ' Filtros 20
        'swhere20 = ""
        If UiCB_Formacion20.SelectedText <> "" Then
            If UiCB_Formacion20.SelectedText <> "Todos" Then
                swhere20 &= " and DescClaseFormacion = '" & UiCB_Formacion20.SelectedText & "'"
            End If
        End If

        If UiCB_F20.Value > 0 Then
            If UiCB_F20.Value = 1 Then
                ' Control si se quieren coger los trabajadores que no tienen un curso de 20h
                If swhere20.Length > 0 Then
                    swhere20 = " and idOperario not in (select idoperario from " & GridFLC.ViewName & " where claseformacion = 20 and DescClaseFormacion = '" & UiCB_Formacion20.SelectedText & "')"
                Else
                    swhere20 &= " and idOperario not in (select idoperario from " & GridFLC.ViewName & " where claseformacion = 20 and DescClaseFormacion is not null)"
                    scont += 1
                End If
            Else
                swhere20 &= " and claseformacion = 20 and DescClaseFormacion is not null "
            End If

            If UiCheck20.Checked = True Then
                swhere20 &= " and Horas = 20"
            End If
            If IsDate(ClB_FFLC_Fecha20d.Value) = True Then
                swhere20 &= " and fecha >= '" & ClB_FFLC_Fecha20d.Value & "'"
            End If

            If IsDate(ClB_FFLC_Fecha20h.Value) = True Then
                swhere20 &= " and fecha <= '" & ClB_FFLC_Fecha20h.Value & "'"
            End If

            ' Componer select 20
            If swhere20.Length > 0 Then
                sselect20 = sselect & swhere & swhere20
            End If
        End If

        ' Filtros 50
        'swhere50 = ""
        If UiCB_Formacion50.SelectedText <> "" Then
            If UiCB_Formacion50.SelectedText <> "Todos" Then
                swhere50 &= " and DescClaseFormacion = '" & UiCB_Formacion50.SelectedText & "'"
            End If
        End If

        If UICB_F50.Value > 0 Then
            If UICB_F50.Value = 1 Then
                ' Control si se quieren coger los trabajadores que no tienen un curso de 50h
                If swhere50.Length > 0 Then
                    swhere50 = " and idOperario not in (select idoperario from " & GridFLC.ViewName & " where claseformacion = 50 and DescClaseFormacion = '" & UiCB_Formacion50.SelectedText & "')"
                Else
                    swhere50 &= " and idOperario not in (select idoperario from " & GridFLC.ViewName & " where claseformacion = 50 and DescClaseFormacion is not null)"
                    scont += 1
                End If
            Else
                swhere50 &= " and claseformacion = 50 and DescClaseFormacion is not null "
            End If

            If IsDate(ClB_FFLC_Fecha50D.Value) = True Then
                swhere50 &= " and fecha >= '" & ClB_FFLC_Fecha50D.Value & "'"
            End If

            If IsDate(ClB_FFLC_Fecha50h.Value) = True Then
                swhere50 &= " and fecha <= '" & ClB_FFLC_Fecha50h.Value & "'"
            End If
            ' Componer select 50
            If swhere50.Length > 0 Then
                sselect50 = sselect & swhere & swhere50
            End If
        End If
        ' Realizar la unión de select8,select20 y select50
        'COMENTARIO QUE SUPUESTAMENTE SUSTITUYE EL BLOQUE DE ABAJO PERO ESTÁ MAL DAVID 24/3/22
        'sselect = sselect8

        'If sselect.ToString.Length > 0 And sselect20.ToString.Length > 0 Then
        '    sselect = sselect & " UNION " & sselect20
        'Else
        '    sselect = sselect20
        'End If

        'If sselect.ToString.Length > 0 And sselect50.ToString.Length > 0 Then
        '    sselect = sselect & " UNION " & sselect50
        'Else
        '    sselect = sselect50
        'End If
        'fin bloque que sustituye el bloque de abajo

        'David Velasco 24/03/22 Sustituye el codigo de arriba.
        'If Not IsNothing(sselect) And Not IsNothing(sselect20) Then
        '    sselect = sselect & " UNION " & sselect20
        'ElseIf Not IsNothing(sselect20) Then
        '    sselect = sselect20
        'End If
        'If Not IsNothing(sselect) And Not IsNothing(sselect50) Then
        '    sselect = sselect & " UNION " & sselect50
        'ElseIf Not IsNothing(sselect50) Then
        '    sselect = sselect50
        'End If

        '' Control trabajadores sin ningún curso
        If scont = 3 Then
            sselect = "Select * from  " & GridFLC.ViewName & swhere & " and idOperario not in (select idoperario from " & GridFLC.ViewName & " where claseformacion in(8,20,50) and DescClaseFormacion is not null )"
        End If

        ' Bien Retornar si se ha filtrado,select tiene datos
        If Not IsNothing(sselect) Then
            dDatosflc = obj.RecogeDatos(sselect & swhere)
            ' Quitar las filas vacias
            quitarVaciasflc(dDatosflc)
            GridFLC.DataSource = dDatosflc
            Return Replace(sselect, "*", "idOperario")
        End If
        Return ""

    End Function

    Private Function FiltrosTpc() As String
        Dim sselect As String
        Dim swhere As String = ""
        Dim dDatostpc As DataTable
        ' Componer la select original
        sselect = "Select * from  " & GridTPC.ViewName
        ' Filtros Cabecera
        If UICheckACtivo.Checked = True Then
            sselect &= " where fecha_baja is null"
        Else
            swhere = " where idOperario is not null "
        End If

        If txtIDOperario.Text.Length > 0 Then
            swhere &= " and iDOperario = '" & txtIDOperario.Text & "'"
        End If

        If txtDescOperario.Text.Length > 0 Then
            swhere &= " and DescOperario like '" & txtDescOperario.Text & "%'"
        End If
        ' Filtros Tpc
        If UICheckFormacionTPC.Checked = True Then
            swhere &= " and (vFrmPrevencionFormacionTPC_sntpc = 1)"
        End If
        ' Traer registros
        dDatostpc = obj.RecogeDatos(sselect & swhere)
        GridTPC.DataSource = dDatostpc
        ' Bien Retornar si se ha filtrado
        If Not IsNothing(swhere) Then
            Return Replace(sselect, "*", "idOperario") & swhere
        End If
        Return ""

    End Function

    Private Function FiltrosEPIS() As String
        Dim sselect As String
        Dim swhere As String = ""
        Dim dDatosepis As DataTable
        ' Componer la select original
        sselect = "Select * from  " & GridEPIS.ViewName
        ' Filtros Cabecera
        If UICheckACtivo.Checked = True Then
            swhere &= " where fecha_baja is null"
        Else
            swhere &= " where idOperario is not null"
        End If

        If txtIDOperario.Text.Length > 0 Then
            swhere &= " and iDOperario = '" & txtIDOperario.Text & "'"
        End If

        If txtDescOperario.Text.Length > 0 Then
            swhere &= " and DescOperario like '" & txtDescOperario.Text & "%'"
        End If
        ' Filtros 
        If IsDate(ClB_EPIS_Fechad.Value) = True Then
            swhere &= " and fecha >= '" & ClB_EPIS_Fechad.Value & "'"
        End If

        If IsDate(ClB_EPIS_Fechah.Value) = True Then
            swhere &= " and fecha <= '" & ClB_EPIS_Fechah.Value & "'"
        End If

        If UiCB_EPI.SelectedText <> "" Then
            If UiCB_EPI.SelectedText <> "Todos" Then
                swhere &= " and DesEpis = '" & UiCB_EPI.SelectedText & "'"
            End If
        End If

        ' Bien Retornar si se ha filtrado
        If Not IsNothing(swhere) Then
            dDatosepis = obj.RecogeDatos(sselect & swhere)
            GridEPIS.DataSource = dDatosepis
            Return Replace(sselect, "*", "idOperario") & swhere
        End If
        Return ""

    End Function

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

    Private Sub quitarVaciasflc(ByRef dt As DataTable)
        Try
            For Each row As DataRow In dt.Rows
                If row.RowState <> DataRowState.Deleted Then
                    If IsDBNull(row("CLASEFORMACION")) Then
                        row.Delete()
                    Else
                        Select Case row("CLASEFORMACION")
                            Case 8
                                If IsDBNull(row("empresaforma")) And IsDBNull(row("lugar")) Then
                                    row.Delete()
                                End If
                            Case 20
                                If IsDBNull(row("DescClaseFormacion")) Then
                                    row.Delete()
                                End If
                            Case 50
                                If IsDBNull(row("DescClaseFormacion")) Then
                                    row.Delete()
                                End If
                        End Select
                    End If
                End If
            Next
        Catch ex As Exception
            MsgBox("Error al eliminar fila." & ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

#End Region

    Private Sub UiBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UiBuscar.Click
        aplicarFiltros(True)
    End Sub


#Region "Combos"

    Private Sub CargarCombos()
        CargarEstados()
        CargarEncargaJefe()
        linkNombreObra()
        'Combos Accidentes
        'GridAcc.Columns("Tipo").EditType = Janus.Windows.GridEX.EditType.DropDownList
        'CargarListaAccidentes()
        GridAcc.Refresh()
        'CargarListaNotificacion()
        CargarSancion()
        GridNotif.Refresh()
        CargarListaFormacion()
        CargarComboTipos()
    End Sub

    Private Sub CargarEstados()
        Dim dt As New DataTable
        Dim filtro As New Filter
        UiComboReco.DataSource = New BE.DataEngine().Filter("tbEstados", filtro, "DescValor")
        UiComboReco.DisplayMember = UiComboReco.DataSource.Columns("DescValor").Caption.ToString
        UiComboReco.ValueMember = UiComboReco.DisplayMember
    End Sub
    Private Sub CargarEncargaJefe()

        Dim op As New PrevencionEncargaJefe

        Try
            Dim Strsql As String
            Dim dt As DataTable
            Dim dfila As DataRow
            Dim f As New Filter

            Strsql = "SELECT Nombre,cTipo FROM tbOperarioEncargaJefe"

            f.Add("cTIpo", FilterOperator.Equal, "E")

            ' Cargar Encargados
            dt = op.Filter(f, "nombre", "Nombre, cTipo")
            dfila = dt.NewRow
            dfila(0) = "Todos"
            dt.Rows.Add(dfila)
            UICB_AccidentesE.DataSource = dt
            UICB_AccidentesE.DisplayMember = UICB_AccidentesE.DataSource.Columns("Nombre").Caption.ToString
            UICB_AccidentesE.ValueMember = UICB_AccidentesE.DisplayMember

            UICB_NotificacionesE.DataSource = UICB_AccidentesE.DataSource
            UICB_NotificacionesE.DisplayMember = UICB_NotificacionesE.DataSource.Columns("Nombre").Caption.ToString
            UICB_NotificacionesE.ValueMember = UICB_NotificacionesE.DisplayMember
            'CType(CType((UiCB_AccidentesE.DataSource).DataSource,Object),Solmicro.Expertis.Engine.Recordset).Rows.

            ' Cargar Jefes

            f.Clear()
            f.Add("cTipo", FilterOperator.Equal, "J")

            dt = op.Filter(f, "nombre", "Nombre, cTipo")
            dfila = dt.NewRow
            dfila(0) = "Todos"
            dt.Rows.Add(dfila)
            UICB_AccidentesJ.DataSource = dt
            UICB_AccidentesJ.DisplayMember = UICB_AccidentesJ.DataSource.Columns("Nombre").Caption.ToString
            UICB_AccidentesJ.ValueMember = UICB_AccidentesE.DisplayMember

            UICB_NotificacionesJ.DataSource = UICB_AccidentesJ.DataSource
            UICB_NotificacionesJ.DisplayMember = UICB_NotificacionesJ.DataSource.Columns("Nombre").Caption.ToString
            UICB_NotificacionesJ.ValueMember = UICB_NotificacionesJ.DisplayMember

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub linkNombreObra()
        Me.TryDataBinding(Me.Ul_Accidentes_obra, New System.Windows.Forms.Binding("text", Me.AdvS_Accidentes_Obra, "DescObra"))
    End Sub

    Private Sub CargarListaAccidentes()
        ' Dim FwConsulta As Aplicacion
        Dim jsCol As Janus.Windows.GridEX.GridEXColumn      'JSColumn
        Dim vl As Janus.Windows.GridEX.GridEXValueListItemCollection  ' JSValueList
        
        Dim aux As Janus.Windows.GridEX.GridEXValueListItem

        Try
            jsCol = GridAcc.Columns("Tipo")
            If Not jsCol Is Nothing Then
                vl = jsCol.ValueList
                If Not vl Is Nothing Then
                    If vl.Count > 0 Then
                        vl.Clear()
                    End If
                End If
            End If

            'End If
            'Comienzo del Cuerpo del Procedimiento
            'FwConsulta = New Aplicacion

            jsCol = GridAcc.Columns("Tipo")
            jsCol.HasValueList = True

            vl = jsCol.ValueList

            aux = New Janus.Windows.GridEX.GridEXValueListItem
            aux.Value = 1
            aux.Text = Nz("Leve", "")
            vl.Add(aux)  ', rcsRdo!Estructura

            aux = New Janus.Windows.GridEX.GridEXValueListItem
            aux.Value = 2
            aux.Text = Nz("Grave", "")
            vl.Add(aux)  ', rcsRdo!Estructura

            aux = New Janus.Windows.GridEX.GridEXValueListItem
            aux.Value = 3
            aux.Text = Nz("Mortal", "")
            vl.Add(aux)  ', rcsRdo!Estructura

            aux = New Janus.Windows.GridEX.GridEXValueListItem
            aux.Value = 4
            aux.Text = Nz("Recaida", "")
            vl.Add(aux)  ', rcsRdo!Estructura

        Catch ex As Exception
            ExpertisApp.GenerateMessage(ex.Message)
        End Try
    End Sub

    Private Sub CargarListaNotificacion()
        ' Dim FwConsulta As Aplicacion
        
        Dim jsCol As Janus.Windows.GridEX.GridEXColumn      'JSColumn
        Dim vl As Janus.Windows.GridEX.GridEXValueListItemCollection  ' JSValueList
        Dim aux As Janus.Windows.GridEX.GridEXValueListItem
        Try
            jsCol = GridNotif.Columns("Gravedad")
            If Not jsCol Is Nothing Then
                vl = jsCol.ValueList
                If Not vl Is Nothing Then
                    If vl.Count > 0 Then
                        vl.Clear()
                    End If
                End If
            End If

            jsCol = GridNotif.Columns("Gravedad")
            jsCol.HasValueList = True

            vl = jsCol.ValueList

            aux = New Janus.Windows.GridEX.GridEXValueListItem
            aux.Value = 1
            aux.Text = Nz("Leve", "")
            vl.Add(aux)  ', rcsRdo!Estructura

            aux = New Janus.Windows.GridEX.GridEXValueListItem
            aux.Value = 2
            aux.Text = Nz("Grave", "")
            vl.Add(aux)  ', rcsRdo!Estructura

            aux = New Janus.Windows.GridEX.GridEXValueListItem
            aux.Value = 3
            aux.Text = Nz("Muy grave", "")
            vl.Add(aux)  ', rcsRdo!Estructura

        Catch ex As Exception
            ExpertisApp.GenerateMessage(ex.Message)
        End Try
    End Sub

    Private Sub CargarSancion()

        Dim op As New PrevencionComboNotifSancion
        Dim f As New Filter
        Try
            Dim Strsql As String
            Dim dt As DataTable
            Dim dfila As DataRow
            Strsql = "SELECT DescSancion FROM tbOperarioNotificacionSan"
            ' Cargar Encargados

            dt = op.Filter(f, "DescSancion", "DescSancion")
            dfila = dt.NewRow
            dfila(0) = "Todos"
            dt.Rows.Add(dfila)
            UICB_NotificacionesS.DataSource = dt
            UICB_NotificacionesS.DisplayMember = UICB_NotificacionesS.DataSource.Columns("DescSancion").Caption.ToString
            UICB_NotificacionesS.ValueMember = UICB_NotificacionesS.DisplayMember

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub CargarListaFormacion()

        Dim op As New PrevencionFormacion
        Dim f As New Filter
        Try
            ' Combos Formación
            ' F. Interna
            Dim dfila As DataRow
            Dim dt As DataTable
            Dim Strsql As String
            'Strsql = "SELECT claseFormacion,DescClaseFormacion FROM tbOperarioFormacionTipo"
            'f.Add("claseFormacion", FilterOperator.Equal, 1)
            'dt = op.Filter(f, "DescClaseFormacion", "claseFormacion, DescClaseFormacion")
            'dfila = dt.NewRow
            'dfila(1) = "Todos"
            'dt.Rows.Add(dfila)

            Dim dt2 As New DataTable
            Dim filtro As New Filter
            filtro.Add("claseFormacion", FilterOperator.Equal, 1)
            dt2 = New BE.DataEngine().Filter("tbOperarioFormacionTipo", filtro, "DescClaseFormacion")




            UICB_FormacionI.DataSource = dt2
            UICB_FormacionI.DisplayMember = UICB_FormacionI.DataSource.Columns("DescClaseFormacion").Caption.ToString
            UICB_FormacionI.ValueMember = UICB_FormacionI.DisplayMember

            ' F. Externa
            f.Clear()
            f.Add("claseFormacion", FilterOperator.Equal, 2)
            dt = op.Filter(f, "DescClaseFormacion", "claseFormacion, DEscClaseFormacion")
            dfila = dt.NewRow
            dfila(1) = "Todos"
            dt.Rows.Add(dfila)

            filtro.Clear()
            filtro.Add("claseFormacion", FilterOperator.Equal, 2)
            dt2 = New BE.DataEngine().Filter("tbOperarioFormacionTipo", filtro, "DescClaseFormacion")

            UICB_FormacionE.DataSource = dt2
            UICB_FormacionE.DisplayMember = UICB_FormacionE.DataSource.Columns("DescClaseFormacion").Caption.ToString
            UICB_FormacionE.ValueMember = UICB_FormacionE.DisplayMember

            ' F. 20
            f.Clear()
            f.Add("claseFormacion", FilterOperator.Equal, 20)
            dt = op.Filter(f, "DescClaseFormacion", "claseFormacion, DescClaseFormacion")
            dfila = dt.NewRow
            dfila(1) = "Todos"
            dt.Rows.Add(dfila)
            UiCB_Formacion20.DataSource = dt
            UiCB_Formacion20.DisplayMember = UiCB_Formacion20.DataSource.Columns("DescClaseFormacion").Caption.ToString
            UiCB_Formacion20.ValueMember = UiCB_Formacion20.DisplayMember
            ' F. 50
            f.Clear()
            f.Add("claseFormacion", FilterOperator.Equal, 50)
            dt = op.Filter(f, "DescClaseFormacion", "claseFormacion, DescClaseFormacion")
            dfila = dt.NewRow
            dfila(1) = "Todos"
            dt.Rows.Add(dfila)
            UiCB_Formacion50.DataSource = dt
            UiCB_Formacion50.DisplayMember = UiCB_Formacion50.DataSource.Columns("DescClaseFormacion").Caption.ToString
            UiCB_Formacion50.ValueMember = UiCB_Formacion50.DisplayMember

        Catch ex As Exception
            ExpertisApp.GenerateMessage(ex.Message)
        End Try
    End Sub

    Private Sub CargarComboTipos()
        Try
            Dim Strsql As String
            Dim dt As DataTable
            Dim dfila As DataRow

            Dim op As New PrevencionEncargaJefe
            Dim f As New Filter

            f.Add("idEncargaJefe", FilterOperator.Equal, -1)

            Strsql = "SELECT Nombre,idEncargaJefe FROM tbOperarioEncargaJefe"
            ' Cargar Encargados
            dt = op.Filter(f, , "Nombre, idEncargaJefe")
            dfila = dt.NewRow
            dfila(0) = "Sin"
            dfila(1) = 1
            dt.Rows.Add(dfila)
            dfila = dt.NewRow
            dfila(0) = "Con"
            dfila(1) = 2
            dt.Rows.Add(dfila)
            dfila = dt.NewRow
            dfila(0) = "No filtrar"
            dfila(1) = 0
            dt.Rows.Add(dfila)
            UiCB_F8.DataSource = dt
            UiCB_F8.DisplayMember = UiCB_F8.DataSource.Columns("Nombre").Caption.ToString
            UiCB_F8.ValueMember = UiCB_F8.DataSource.Columns("idEncargaJefe").Caption.ToString

            UiCB_F20.DataSource = dt
            UiCB_F20.DisplayMember = UiCB_F20.DataSource.Columns("Nombre").Caption.ToString
            UiCB_F20.ValueMember = UiCB_F20.DataSource.Columns("idEncargaJefe").Caption.ToString

            UICB_F50.DataSource = dt
            UICB_F50.DisplayMember = UICB_F50.DataSource.Columns("Nombre").Caption.ToString
            UICB_F50.ValueMember = UICB_F50.DataSource.Columns("idEncargaJefe").Caption.ToString


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region

    Private Sub ListObraHoras()
        Dim frm As New MntoObrasHoras
        frm.ShowDialog()
        frm = Nothing
    End Sub

#Region "Excel"
    Private Sub ExcelCab()
        If GridGen.RowCount > 0 Then
            GridGen.ExportToExcel()
        Else
            MsgBox("No existen datos en el grid para exportar.", MsgBoxStyle.Information, "Sin filas en Grid.")
        End If
    End Sub
    Private Sub ExcelReco()
        If GridReco.RowCount > 0 Then
            GridReco.ExportToExcel()
        Else
            MsgBox("No existen datos en el grid para exportar.", MsgBoxStyle.Information, "Sin filas en Grid.")
        End If
    End Sub

    Private Sub ExcelAcc()
        If GridAcc.RowCount > 0 Then
            GridAcc.ExportToExcel()
        Else
            MsgBox("No existen datos en el grid para exportar.", MsgBoxStyle.Information, "Sin filas en Grid.")
        End If
    End Sub

    Private Sub ExcelNotif()
        If GridNotif.RowCount > 0 Then
            GridNotif.ExportToExcel()
        Else
            MsgBox("No existen datos en el grid para exportar.", MsgBoxStyle.Information, "Sin filas en Grid.")
        End If
    End Sub

    Private Sub ExcelBajas()
        If GridBajas.RowCount > 0 Then
            GridBajas.ExportToExcel()
        Else
            MsgBox("No existen datos en el grid para exportar.", MsgBoxStyle.Information, "Sin filas en Grid.")
        End If
    End Sub

    Private Sub ExcelTpc()
        If GridTPC.RowCount > 0 Then
            GridTPC.ExportToExcel()
        Else
            MsgBox("No existen datos en el grid para exportar.", MsgBoxStyle.Information, "Sin filas en Grid.")
        End If
    End Sub

    Private Sub ExcelFI()
        If GridFI.RowCount > 0 Then
            GridFI.ExportToExcel()
        Else
            MsgBox("No existen datos en el grid para exportar.", MsgBoxStyle.Information, "Sin filas en Grid.")
        End If
    End Sub

    Private Sub ExcelFE()
        If GridFE.RowCount > 0 Then
            GridFE.ExportToExcel()
        Else
            MsgBox("No existen datos en el grid para exportar.", MsgBoxStyle.Information, "Sin filas en Grid.")
        End If
    End Sub

    Private Sub ExcelFLC()
        If GridFLC.RowCount > 0 Then
            GridFLC.ExportToExcel()
        Else
            MsgBox("No existen datos en el grid para exportar.", MsgBoxStyle.Information, "Sin filas en Grid.")
        End If
    End Sub

    Private Sub ExcelEPIS()
        If GridEPIS.RowCount > 0 Then
            GridEPIS.ExportToExcel()
        Else
            MsgBox("No existen datos en el grid para exportar.", MsgBoxStyle.Information, "Sin filas en Grid.")
        End If
    End Sub
#End Region

    Private Sub UiCheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UICheckBox1.CheckedChanged
        If UICheckBox1.Checked = True Then
            ExcelCab()
        End If
        UICheckBox1.Checked = False
    End Sub


    Private Sub UiCheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UICheckBox2.CheckedChanged
        If UICheckBox2.Checked = True Then
            ExcelReco()
        End If
        UICheckBox2.Checked = False
    End Sub


    Private Sub UiCheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UICheckBox3.CheckedChanged
        If UICheckBox3.Checked = True Then
            ExcelAcc()
        End If
        UICheckBox3.Checked = False
    End Sub

    Private Sub UiCheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UICheckBox4.CheckedChanged
        If UICheckBox4.Checked = True Then
            ExcelNotif()
        End If
        UICheckBox4.Checked = False
    End Sub

    Private Sub UiCheckBox5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UICheckBox5.CheckedChanged
        If UICheckBox5.Checked = True Then
            ExcelBajas()
        End If
        UICheckBox5.Checked = False
    End Sub

    Private Sub UiCheckBox6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UiCheckBox6.CheckedChanged
        If UiCheckBox6.Checked = True Then
            ExcelTpc()
        End If
        UiCheckBox6.Checked = False
    End Sub


    Private Sub UiCheckBox7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UICheckBox7.CheckedChanged
        If UICheckBox7.Checked = True Then
            ExcelFI()
        End If
        UICheckBox7.Checked = False
    End Sub

    Private Sub UiCheckBox8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UICheckBox8.CheckedChanged
        If UICheckBox8.Checked = True Then
            ExcelFE()
        End If
        UICheckBox8.Checked = False
    End Sub

    Private Sub UiCheckBox9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UiCheckBox9.CheckedChanged
        If UiCheckBox9.Checked = True Then
            ExcelFLC()
        End If
        UiCheckBox9.Checked = False
    End Sub

    Private Sub UiCheckBox10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UiCheckBox10.CheckedChanged
        If UiCheckBox10.Checked = True Then
            ExcelEPIS()
        End If
        UiCheckBox10.Checked = False
    End Sub

    Private Sub GridGen_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridGen.RowDoubleClick
        If Not IsDBNull(GridGen.GetValue("idOperario")) Then
            AbrirOperario(GridGen.GetValue("idOperario"))
        End If
    End Sub


    Private Sub GridReco_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridReco.RowDoubleClick
        If Not IsDBNull(GridReco.GetValue("idOperario")) Then
            AbrirOperario(GridReco.GetValue("idOperario"))
        End If
    End Sub


    Private Sub GridAcc_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridAcc.RowDoubleClick
        If Not IsDBNull(GridAcc.GetValue("idOperario")) Then
            AbrirOperario(GridAcc.GetValue("idOperario"))
        End If
    End Sub


    Private Sub GridNotif_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridNotif.RowDoubleClick
        If Not IsDBNull(GridNotif.GetValue("idOperario")) Then
            AbrirOperario(GridNotif.GetValue("idOperario"))
        End If
    End Sub


    Private Sub GridBajas_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridBajas.RowDoubleClick
        If Not IsDBNull(GridBajas.GetValue("idOperario")) Then
            AbrirOperario(GridBajas.GetValue("idOperario"))
        End If
    End Sub


    Private Sub GridFI_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridFI.RowDoubleClick
        If Not IsDBNull(GridFI.GetValue("idOperario")) Then
            AbrirOperario(GridFI.GetValue("idOperario"))
        End If
    End Sub

    Private Sub GridFE_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridFE.RowDoubleClick
        If Not IsDBNull(GridFE.GetValue("idOperario")) Then
            AbrirOperario(GridFE.GetValue("idOperario"))
        End If
    End Sub


    Private Sub GridFLC_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridFLC.RowDoubleClick
        If Not IsDBNull(GridFLC.GetValue("idOperario")) Then
            AbrirOperario(GridFLC.GetValue("idOperario"))
        End If
    End Sub

    Private Sub GridTPC_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridTPC.RowDoubleClick
        If Not IsDBNull(GridTPC.GetValue("idOperario")) Then
            AbrirOperario(GridTPC.GetValue("idOperario"))
        End If
    End Sub

    Private Sub GridPIS_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridEPIS.RowDoubleClick
        If Not IsDBNull(GridEPIS.GetValue("idOperario")) Then
            AbrirOperario(GridEPIS.GetValue("idOperario"))
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ExcelCab()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ExcelReco()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ExcelAcc()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ExcelNotif()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        ExcelBajas()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        ExcelFI()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        ExcelFE()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        ExcelFLC()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        ExcelTpc()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        ExcelEPIS()
    End Sub
End Class