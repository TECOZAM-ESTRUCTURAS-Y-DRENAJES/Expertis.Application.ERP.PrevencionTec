<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MntoObrasHoras
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
        Dim GridObrasHoras_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MntoObrasHoras))
        Me.Frame1 = New Solmicro.Expertis.Engine.UI.Frame
        Me.IntUDYear = New Janus.Windows.GridEX.EditControls.IntegerUpDown
        Me.IntUDMes = New Janus.Windows.GridEX.EditControls.IntegerUpDown
        Me.Label2 = New Solmicro.Expertis.Engine.UI.Label
        Me.Label1 = New Solmicro.Expertis.Engine.UI.Label
        Me.GridObrasHoras = New Solmicro.Expertis.Engine.UI.Grid
        Me.Frame1.SuspendLayout()
        CType(Me.GridObrasHoras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Frame1
        '
        Me.Frame1.Controls.Add(Me.IntUDYear)
        Me.Frame1.Controls.Add(Me.IntUDMes)
        Me.Frame1.Controls.Add(Me.Label2)
        Me.Frame1.Controls.Add(Me.Label1)
        Me.Frame1.Location = New System.Drawing.Point(9, 8)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(192, 90)
        Me.Frame1.TabIndex = 0
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Filtro Periodo"
        '
        'IntUDYear
        '
        Me.IntUDYear.Location = New System.Drawing.Point(99, 54)
        Me.IntUDYear.Maximum = 2050
        Me.IntUDYear.Minimum = 1979
        Me.IntUDYear.Name = "IntUDYear"
        Me.IntUDYear.Size = New System.Drawing.Size(86, 21)
        Me.IntUDYear.TabIndex = 1
        Me.IntUDYear.Value = 1979
        '
        'IntUDMes
        '
        Me.IntUDMes.Location = New System.Drawing.Point(12, 54)
        Me.IntUDMes.Maximum = 12
        Me.IntUDMes.Minimum = 1
        Me.IntUDMes.Name = "IntUDMes"
        Me.IntUDMes.Size = New System.Drawing.Size(55, 21)
        Me.IntUDMes.TabIndex = 2
        Me.IntUDMes.Value = 1
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(96, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ejercicio"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mes"
        '
        'GridObrasHoras
        '
        GridObrasHoras_DesignTimeLayout.LayoutString = resources.GetString("GridObrasHoras_DesignTimeLayout.LayoutString")
        Me.GridObrasHoras.DesignTimeLayout = GridObrasHoras_DesignTimeLayout
        Me.GridObrasHoras.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridObrasHoras.EntityName = Nothing
        Me.GridObrasHoras.Location = New System.Drawing.Point(-2, 105)
        Me.GridObrasHoras.Name = "GridObrasHoras"
        Me.GridObrasHoras.PrimaryDataFields = Nothing
        Me.GridObrasHoras.SecondaryDataFields = Nothing
        Me.GridObrasHoras.Size = New System.Drawing.Size(860, 254)
        Me.GridObrasHoras.TabIndex = 1
        Me.GridObrasHoras.ViewName = "vFrmPrevObrasHoras"
        '
        'MntoObrasHoras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 358)
        Me.Controls.Add(Me.GridObrasHoras)
        Me.Controls.Add(Me.Frame1)
        Me.Name = "MntoObrasHoras"
        Me.Text = "MntoObrasHoras"
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        CType(Me.GridObrasHoras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Frame1 As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents IntUDYear As Janus.Windows.GridEX.EditControls.IntegerUpDown
    Friend WithEvents IntUDMes As Janus.Windows.GridEX.EditControls.IntegerUpDown
    Friend WithEvents Label2 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Label1 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents GridObrasHoras As Solmicro.Expertis.Engine.UI.Grid
End Class
