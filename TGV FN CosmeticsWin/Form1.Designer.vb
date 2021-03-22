<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.tls_main = New System.Windows.Forms.ToolStrip()
        Me.tls_cosmetics = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tls_main.SuspendLayout()
        Me.SuspendLayout()
        '
        'tls_main
        '
        Me.tls_main.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tls_cosmetics})
        Me.tls_main.Location = New System.Drawing.Point(0, 0)
        Me.tls_main.Name = "tls_main"
        Me.tls_main.Size = New System.Drawing.Size(927, 38)
        Me.tls_main.TabIndex = 0
        Me.tls_main.Text = "ToolStrip1"
        '
        'tls_cosmetics
        '
        Me.tls_cosmetics.Image = CType(resources.GetObject("tls_cosmetics.Image"), System.Drawing.Image)
        Me.tls_cosmetics.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tls_cosmetics.Name = "tls_cosmetics"
        Me.tls_cosmetics.Size = New System.Drawing.Size(66, 35)
        Me.tls_cosmetics.Text = "Cosmetics"
        Me.tls_cosmetics.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 579)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(927, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(927, 601)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.tls_main)
        Me.HelpButton = True
        Me.IsMdiContainer = True
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TGV FN Cosmetics"
        Me.tls_main.ResumeLayout(False)
        Me.tls_main.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tls_main As ToolStrip
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents tls_cosmetics As ToolStripButton
End Class
