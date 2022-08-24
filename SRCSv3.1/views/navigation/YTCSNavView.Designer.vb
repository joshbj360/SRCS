<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class YTCSNavView
    Inherits DevExpress.XtraEditors.XtraUserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TileControl1 = New DevExpress.XtraEditors.TileControl()
        Me.TileGroup2 = New DevExpress.XtraEditors.TileGroup()
        Me.SuspendLayout()
        '
        'TileControl1
        '
        Me.TileControl1.AllowDrag = False
        Me.TileControl1.AllowDragTilesBetweenGroups = False
        Me.TileControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.TileControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TileControl1.Groups.Add(Me.TileGroup2)
        Me.TileControl1.HorizontalContentAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.TileControl1.LayoutMode = DevExpress.XtraEditors.TileControlLayoutMode.Adaptive
        Me.TileControl1.Location = New System.Drawing.Point(0, 0)
        Me.TileControl1.MaxId = 3
        Me.TileControl1.Name = "TileControl1"
        Me.TileControl1.OptionsAdaptiveLayout.ScrollMode = DevExpress.XtraEditors.TileControlAdaptiveLayoutScrollMode.ItemScrolling
        Me.TileControl1.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TileControl1.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons
        Me.TileControl1.Size = New System.Drawing.Size(248, 459)
        Me.TileControl1.TabIndex = 0
        Me.TileControl1.Text = "TileControl1"
        '
        'TileGroup2
        '
        Me.TileGroup2.Name = "TileGroup2"
        '
        'YTCSNavView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TileControl1)
        Me.Name = "YTCSNavView"
        Me.Size = New System.Drawing.Size(248, 459)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TileControl1 As DevExpress.XtraEditors.TileControl
    Friend WithEvents TileGroup2 As DevExpress.XtraEditors.TileGroup
End Class
