<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Desktop
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.StartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ApplicationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RondowsBrowserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RondowsAppStoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 612)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(862, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'StartToolStripMenuItem
        '
        Me.StartToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ApplicationsToolStripMenuItem, Me.SettingsToolStripMenuItem})
        Me.StartToolStripMenuItem.Name = "StartToolStripMenuItem"
        Me.StartToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.StartToolStripMenuItem.Text = "Start"
        '
        'ApplicationsToolStripMenuItem
        '
        Me.ApplicationsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RondowsBrowserToolStripMenuItem, Me.RondowsAppStoreToolStripMenuItem})
        Me.ApplicationsToolStripMenuItem.Name = "ApplicationsToolStripMenuItem"
        Me.ApplicationsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ApplicationsToolStripMenuItem.Text = "Applications"
        '
        'RondowsBrowserToolStripMenuItem
        '
        Me.RondowsBrowserToolStripMenuItem.Name = "RondowsBrowserToolStripMenuItem"
        Me.RondowsBrowserToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.RondowsBrowserToolStripMenuItem.Text = "Rondows Browser"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'RondowsAppStoreToolStripMenuItem
        '
        Me.RondowsAppStoreToolStripMenuItem.Name = "RondowsAppStoreToolStripMenuItem"
        Me.RondowsAppStoreToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.RondowsAppStoreToolStripMenuItem.Text = "Rondows App Store"
        '
        'Desktop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OrangeRed
        Me.ClientSize = New System.Drawing.Size(862, 636)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Desktop"
        Me.Text = "Desktop"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents StartToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ApplicationsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RondowsBrowserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RondowsAppStoreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
