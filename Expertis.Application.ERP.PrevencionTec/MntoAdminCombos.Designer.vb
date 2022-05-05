<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MntoAdminCombos
    Inherits Solmicro.Expertis.Engine.UI.FormBase

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim GridFormacion_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MntoAdminCombos))
        Dim GridEncarga_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridSancion_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridPuesto_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridEpis_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridPuestoObra_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridCorreo_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridComunicado_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridEnvio_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.TabAdminCombos = New Solmicro.Expertis.Engine.UI.Tab
        Me.TabEncargados = New Janus.Windows.UI.Tab.UITabPage
        Me.GridFormacion = New Solmicro.Expertis.Engine.UI.Grid
        Me.tabEncargado = New Janus.Windows.UI.Tab.UITabPage
        Me.GridEncarga = New Solmicro.Expertis.Engine.UI.Grid
        Me.tabSancion = New Janus.Windows.UI.Tab.UITabPage
        Me.GridSancion = New Solmicro.Expertis.Engine.UI.Grid
        Me.TabPuestos = New Janus.Windows.UI.Tab.UITabPage
        Me.GridPuesto = New Solmicro.Expertis.Engine.UI.Grid
        Me.tabEpis = New Janus.Windows.UI.Tab.UITabPage
        Me.GridEpis = New Solmicro.Expertis.Engine.UI.Grid
        Me.tabPuestosContr = New Janus.Windows.UI.Tab.UITabPage
        Me.GridPuestoObra = New Solmicro.Expertis.Engine.UI.Grid
        Me.tabEmail = New Janus.Windows.UI.Tab.UITabPage
        Me.GridCorreo = New Solmicro.Expertis.Engine.UI.Grid
        Me.tabComunicado = New Janus.Windows.UI.Tab.UITabPage
        Me.GridComunicado = New Solmicro.Expertis.Engine.UI.Grid
        Me.TabModEnvio = New Janus.Windows.UI.Tab.UITabPage
        Me.GridEnvio = New Solmicro.Expertis.Engine.UI.Grid
        CType(Me.TabAdminCombos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabAdminCombos.SuspendLayout()
        Me.TabEncargados.SuspendLayout()
        CType(Me.GridFormacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabEncargado.SuspendLayout()
        CType(Me.GridEncarga, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabSancion.SuspendLayout()
        CType(Me.GridSancion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPuestos.SuspendLayout()
        CType(Me.GridPuesto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabEpis.SuspendLayout()
        CType(Me.GridEpis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPuestosContr.SuspendLayout()
        CType(Me.GridPuestoObra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabEmail.SuspendLayout()
        CType(Me.GridCorreo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabComunicado.SuspendLayout()
        CType(Me.GridComunicado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabModEnvio.SuspendLayout()
        CType(Me.GridEnvio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabAdminCombos
        '
        Me.TabAdminCombos.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.TabAdminCombos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabAdminCombos.Location = New System.Drawing.Point(0, 0)
        Me.TabAdminCombos.Name = "TabAdminCombos"
        Me.TabAdminCombos.Size = New System.Drawing.Size(964, 337)
        Me.TabAdminCombos.TabIndex = 0
        Me.TabAdminCombos.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.TabEncargados, Me.tabEncargado, Me.tabSancion, Me.TabPuestos, Me.tabEpis, Me.tabPuestosContr, Me.tabEmail, Me.tabComunicado, Me.TabModEnvio})
        Me.TabAdminCombos.UseThemes = True
        '
        'TabEncargados
        '
        Me.TabEncargados.Controls.Add(Me.GridFormacion)
        Me.TabEncargados.Location = New System.Drawing.Point(1, 21)
        Me.TabEncargados.Name = "TabEncargados"
        Me.TabEncargados.Size = New System.Drawing.Size(962, 315)
        Me.TabEncargados.TabStop = True
        Me.TabEncargados.Text = "Clase Formacion"
        '
        'GridFormacion
        '
        GridFormacion_DesignTimeLayout.LayoutString = resources.GetString("GridFormacion_DesignTimeLayout.LayoutString")
        Me.GridFormacion.DesignTimeLayout = GridFormacion_DesignTimeLayout
        Me.GridFormacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridFormacion.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridFormacion.EntityName = "PrevencionFormacionTipo"
        Me.GridFormacion.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridFormacion.Location = New System.Drawing.Point(0, 0)
        Me.GridFormacion.Name = "GridFormacion"
        Me.GridFormacion.NewRowPosition = Janus.Windows.GridEX.NewRowPosition.BottomRow
        Me.GridFormacion.PrimaryDataFields = Nothing
        Me.GridFormacion.RelationMode = Solmicro.Expertis.Engine.RelationMode.NoRelation
        Me.GridFormacion.SecondaryDataFields = "claseformacion"
        Me.GridFormacion.Size = New System.Drawing.Size(962, 315)
        Me.GridFormacion.TabIndex = 0
        Me.GridFormacion.ViewName = "tbOperarioFormacionTipo"
        '
        'tabEncargado
        '
        Me.tabEncargado.Controls.Add(Me.GridEncarga)
        Me.tabEncargado.Location = New System.Drawing.Point(1, 21)
        Me.tabEncargado.Name = "tabEncargado"
        Me.tabEncargado.Size = New System.Drawing.Size(962, 315)
        Me.tabEncargado.TabStop = True
        Me.tabEncargado.Text = "Encargados/Jefes/Técnico"
        '
        'GridEncarga
        '
        GridEncarga_DesignTimeLayout.LayoutString = resources.GetString("GridEncarga_DesignTimeLayout.LayoutString")
        Me.GridEncarga.DesignTimeLayout = GridEncarga_DesignTimeLayout
        Me.GridEncarga.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridEncarga.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridEncarga.EntityName = Nothing
        Me.GridEncarga.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridEncarga.Location = New System.Drawing.Point(0, 0)
        Me.GridEncarga.Name = "GridEncarga"
        Me.GridEncarga.NewRowPosition = Janus.Windows.GridEX.NewRowPosition.BottomRow
        Me.GridEncarga.PrimaryDataFields = Nothing
        Me.GridEncarga.RelationMode = Solmicro.Expertis.Engine.RelationMode.NoRelation
        Me.GridEncarga.SecondaryDataFields = "idencargajefe"
        Me.GridEncarga.Size = New System.Drawing.Size(962, 315)
        Me.GridEncarga.TabIndex = 0
        Me.GridEncarga.ViewName = "tbOperarioEncargaJefe"
        '
        'tabSancion
        '
        Me.tabSancion.Controls.Add(Me.GridSancion)
        Me.tabSancion.Location = New System.Drawing.Point(1, 21)
        Me.tabSancion.Name = "tabSancion"
        Me.tabSancion.Size = New System.Drawing.Size(962, 315)
        Me.tabSancion.TabStop = True
        Me.tabSancion.Text = "Sanción"
        '
        'GridSancion
        '
        GridSancion_DesignTimeLayout.LayoutString = resources.GetString("GridSancion_DesignTimeLayout.LayoutString")
        Me.GridSancion.DesignTimeLayout = GridSancion_DesignTimeLayout
        Me.GridSancion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridSancion.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridSancion.EntityName = Nothing
        Me.GridSancion.Location = New System.Drawing.Point(0, 0)
        Me.GridSancion.Name = "GridSancion"
        Me.GridSancion.NewRowPosition = Janus.Windows.GridEX.NewRowPosition.BottomRow
        Me.GridSancion.PrimaryDataFields = Nothing
        Me.GridSancion.RelationMode = Solmicro.Expertis.Engine.RelationMode.NoRelation
        Me.GridSancion.SecondaryDataFields = Nothing
        Me.GridSancion.Size = New System.Drawing.Size(962, 315)
        Me.GridSancion.TabIndex = 0
        Me.GridSancion.ViewName = "tbOperarioNotificacionSan"
        '
        'TabPuestos
        '
        Me.TabPuestos.Controls.Add(Me.GridPuesto)
        Me.TabPuestos.Location = New System.Drawing.Point(1, 21)
        Me.TabPuestos.Name = "TabPuestos"
        Me.TabPuestos.Size = New System.Drawing.Size(962, 315)
        Me.TabPuestos.TabStop = True
        Me.TabPuestos.Text = "Puestos"
        '
        'GridPuesto
        '
        GridPuesto_DesignTimeLayout.LayoutString = resources.GetString("GridPuesto_DesignTimeLayout.LayoutString")
        Me.GridPuesto.DesignTimeLayout = GridPuesto_DesignTimeLayout
        Me.GridPuesto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridPuesto.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridPuesto.EntityName = Nothing
        Me.GridPuesto.Location = New System.Drawing.Point(0, 0)
        Me.GridPuesto.Name = "GridPuesto"
        Me.GridPuesto.NewRowPosition = Janus.Windows.GridEX.NewRowPosition.BottomRow
        Me.GridPuesto.PrimaryDataFields = Nothing
        Me.GridPuesto.RelationMode = Solmicro.Expertis.Engine.RelationMode.NoRelation
        Me.GridPuesto.SecondaryDataFields = "idSancion"
        Me.GridPuesto.Size = New System.Drawing.Size(962, 315)
        Me.GridPuesto.TabIndex = 0
        Me.GridPuesto.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed
        Me.GridPuesto.ViewName = "tbOperarioPuesto"
        '
        'tabEpis
        '
        Me.tabEpis.Controls.Add(Me.GridEpis)
        Me.tabEpis.Location = New System.Drawing.Point(1, 21)
        Me.tabEpis.Name = "tabEpis"
        Me.tabEpis.Size = New System.Drawing.Size(962, 315)
        Me.tabEpis.TabStop = True
        Me.tabEpis.Text = "Tipos EPIS"
        '
        'GridEpis
        '
        GridEpis_DesignTimeLayout.LayoutString = resources.GetString("GridEpis_DesignTimeLayout.LayoutString")
        Me.GridEpis.DesignTimeLayout = GridEpis_DesignTimeLayout
        Me.GridEpis.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridEpis.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridEpis.EntityName = "PrevencionComboEpi"
        Me.GridEpis.KeyField = "idEpisTipo"
        Me.GridEpis.Location = New System.Drawing.Point(0, 0)
        Me.GridEpis.Name = "GridEpis"
        Me.GridEpis.NewRowPosition = Janus.Windows.GridEX.NewRowPosition.BottomRow
        Me.GridEpis.PrimaryDataFields = "idEpisTipo"
        Me.GridEpis.RelationMode = Solmicro.Expertis.Engine.RelationMode.NoRelation
        Me.GridEpis.SecondaryDataFields = "idRecoPuesto"
        Me.GridEpis.Size = New System.Drawing.Size(962, 315)
        Me.GridEpis.TabIndex = 0
        Me.GridEpis.ViewName = "tbOperarioEpisTipo"
        '
        'tabPuestosContr
        '
        Me.tabPuestosContr.Controls.Add(Me.GridPuestoObra)
        Me.tabPuestosContr.Location = New System.Drawing.Point(1, 21)
        Me.tabPuestosContr.Name = "tabPuestosContr"
        Me.tabPuestosContr.Size = New System.Drawing.Size(962, 315)
        Me.tabPuestosContr.TabStop = True
        Me.tabPuestosContr.Text = "Puestos en Contrata"
        '
        'GridPuestoObra
        '
        GridPuestoObra_DesignTimeLayout.LayoutString = resources.GetString("GridPuestoObra_DesignTimeLayout.LayoutString")
        Me.GridPuestoObra.DesignTimeLayout = GridPuestoObra_DesignTimeLayout
        Me.GridPuestoObra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridPuestoObra.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridPuestoObra.EntityName = Nothing
        Me.GridPuestoObra.Location = New System.Drawing.Point(0, 0)
        Me.GridPuestoObra.Name = "GridPuestoObra"
        Me.GridPuestoObra.NewRowPosition = Janus.Windows.GridEX.NewRowPosition.BottomRow
        Me.GridPuestoObra.PrimaryDataFields = Nothing
        Me.GridPuestoObra.RelationMode = Solmicro.Expertis.Engine.RelationMode.NoRelation
        Me.GridPuestoObra.SecondaryDataFields = Nothing
        Me.GridPuestoObra.Size = New System.Drawing.Size(962, 315)
        Me.GridPuestoObra.TabIndex = 0
        Me.GridPuestoObra.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridPuestoObra.ViewName = "tbObraPuesto"
        '
        'tabEmail
        '
        Me.tabEmail.Controls.Add(Me.GridCorreo)
        Me.tabEmail.Location = New System.Drawing.Point(1, 21)
        Me.tabEmail.Name = "tabEmail"
        Me.tabEmail.Size = New System.Drawing.Size(962, 315)
        Me.tabEmail.TabStop = True
        Me.tabEmail.Text = "Cuentas E-Mail"
        '
        'GridCorreo
        '
        GridCorreo_DesignTimeLayout.LayoutString = resources.GetString("GridCorreo_DesignTimeLayout.LayoutString")
        Me.GridCorreo.DesignTimeLayout = GridCorreo_DesignTimeLayout
        Me.GridCorreo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridCorreo.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridCorreo.EntityName = "PrevencionEmail"
        Me.GridCorreo.Location = New System.Drawing.Point(0, 0)
        Me.GridCorreo.Name = "GridCorreo"
        Me.GridCorreo.NewRowPosition = Janus.Windows.GridEX.NewRowPosition.BottomRow
        Me.GridCorreo.PrimaryDataFields = Nothing
        Me.GridCorreo.RelationMode = Solmicro.Expertis.Engine.RelationMode.NoRelation
        Me.GridCorreo.SecondaryDataFields = "idObraPuesto"
        Me.GridCorreo.Size = New System.Drawing.Size(962, 315)
        Me.GridCorreo.TabIndex = 0
        Me.GridCorreo.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridCorreo.ViewName = "tbOperarioEmailCombo"
        '
        'tabComunicado
        '
        Me.tabComunicado.Controls.Add(Me.GridComunicado)
        Me.tabComunicado.Location = New System.Drawing.Point(1, 21)
        Me.tabComunicado.Name = "tabComunicado"
        Me.tabComunicado.Size = New System.Drawing.Size(962, 315)
        Me.tabComunicado.TabStop = True
        Me.tabComunicado.Text = "Comunicado"
        '
        'GridComunicado
        '
        GridComunicado_DesignTimeLayout.LayoutString = resources.GetString("GridComunicado_DesignTimeLayout.LayoutString")
        Me.GridComunicado.DesignTimeLayout = GridComunicado_DesignTimeLayout
        Me.GridComunicado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridComunicado.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridComunicado.EntityName = "ObraComunicadoTipo"
        Me.GridComunicado.Location = New System.Drawing.Point(0, 0)
        Me.GridComunicado.Name = "GridComunicado"
        Me.GridComunicado.NewRowPosition = Janus.Windows.GridEX.NewRowPosition.BottomRow
        Me.GridComunicado.PrimaryDataFields = Nothing
        Me.GridComunicado.RelationMode = Solmicro.Expertis.Engine.RelationMode.NoRelation
        Me.GridComunicado.SecondaryDataFields = "idemail"
        Me.GridComunicado.Size = New System.Drawing.Size(962, 315)
        Me.GridComunicado.TabIndex = 0
        Me.GridComunicado.ViewName = "tbObraComunicadoTipo"
        '
        'TabModEnvio
        '
        Me.TabModEnvio.Controls.Add(Me.GridEnvio)
        Me.TabModEnvio.Location = New System.Drawing.Point(1, 21)
        Me.TabModEnvio.Name = "TabModEnvio"
        Me.TabModEnvio.Size = New System.Drawing.Size(962, 315)
        Me.TabModEnvio.TabStop = True
        Me.TabModEnvio.Text = "Modo Envio"
        '
        'GridEnvio
        '
        GridEnvio_DesignTimeLayout.LayoutString = resources.GetString("GridEnvio_DesignTimeLayout.LayoutString")
        Me.GridEnvio.DesignTimeLayout = GridEnvio_DesignTimeLayout
        Me.GridEnvio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridEnvio.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridEnvio.EntityName = Nothing
        Me.GridEnvio.Location = New System.Drawing.Point(0, 0)
        Me.GridEnvio.Name = "GridEnvio"
        Me.GridEnvio.NewRowPosition = Janus.Windows.GridEX.NewRowPosition.BottomRow
        Me.GridEnvio.PrimaryDataFields = Nothing
        Me.GridEnvio.SecondaryDataFields = "idtipo"
        Me.GridEnvio.Size = New System.Drawing.Size(962, 315)
        Me.GridEnvio.TabIndex = 0
        Me.GridEnvio.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridEnvio.ViewName = "tbObraEnvioTipo"
        '
        'MntoAdminCombos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(964, 337)
        Me.Controls.Add(Me.TabAdminCombos)
        Me.Name = "MntoAdminCombos"
        Me.Text = "MntoAdminCombos"
        CType(Me.TabAdminCombos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabAdminCombos.ResumeLayout(False)
        Me.TabEncargados.ResumeLayout(False)
        CType(Me.GridFormacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabEncargado.ResumeLayout(False)
        CType(Me.GridEncarga, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabSancion.ResumeLayout(False)
        CType(Me.GridSancion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPuestos.ResumeLayout(False)
        CType(Me.GridPuesto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabEpis.ResumeLayout(False)
        CType(Me.GridEpis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPuestosContr.ResumeLayout(False)
        CType(Me.GridPuestoObra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabEmail.ResumeLayout(False)
        CType(Me.GridCorreo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabComunicado.ResumeLayout(False)
        CType(Me.GridComunicado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabModEnvio.ResumeLayout(False)
        CType(Me.GridEnvio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabAdminCombos As Solmicro.Expertis.Engine.UI.Tab
    Friend WithEvents tabFormacion As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents GridFormacion As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents tabEncargado As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents GridEncarga As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents tabSancion As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents GridSancion As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents TabPuestos As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents tabEpis As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents tabPuestosContr As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents GridEpis As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents GridPuesto As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents GridPuestoObra As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents tabEmail As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents tabComunicado As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents TabModEnvio As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents GridCorreo As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents GridComunicado As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents GridEnvio As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents TabEncargados As Janus.Windows.UI.Tab.UITabPage
End Class
