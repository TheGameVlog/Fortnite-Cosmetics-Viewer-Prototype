
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Outfits")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Back Bling")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Pets")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Toys")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Pickaxes")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Gliders")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Emotes")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Built-in Emotes")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Loading Screens")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Wraps")
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Contrails")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Banners")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sprays")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Emoticons")
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Musics")
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Misc")
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.lblCosmeticInfo = New System.Windows.Forms.TextBox()
        Me.cosmeticPanel = New System.Windows.Forms.Panel()
        Me.lblCosmeticName = New System.Windows.Forms.Label()
        Me.lblRarity = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cosImg = New System.Windows.Forms.PictureBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.cosmeticPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.cosImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TreeView1
        '
        Me.TreeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Left
        Me.TreeView1.Location = New System.Drawing.Point(0, 99)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.Name = "OutfitNode"
        TreeNode1.Text = "Outfits"
        TreeNode2.Name = "BackBlingNode"
        TreeNode2.Text = "Back Bling"
        TreeNode3.Name = "PetNode"
        TreeNode3.Text = "Pets"
        TreeNode4.Name = "ToyNode"
        TreeNode4.Text = "Toys"
        TreeNode5.Name = "PickaxeNode"
        TreeNode5.Text = "Pickaxes"
        TreeNode6.Name = "GliderNode"
        TreeNode6.Text = "Gliders"
        TreeNode7.Name = "EmotesNode"
        TreeNode7.Text = "Emotes"
        TreeNode8.Name = "BuiltinEmoteNode"
        TreeNode8.Text = "Built-in Emotes"
        TreeNode9.Name = "LoadingScreenNode"
        TreeNode9.Text = "Loading Screens"
        TreeNode10.Name = "WrapsNode"
        TreeNode10.Text = "Wraps"
        TreeNode11.Name = "ContrailNode"
        TreeNode11.Text = "Contrails"
        TreeNode12.Name = "BannerNode"
        TreeNode12.Text = "Banners"
        TreeNode13.Name = "SprayNode"
        TreeNode13.Text = "Sprays"
        TreeNode14.Name = "EmoticonNode"
        TreeNode14.Text = "Emoticons"
        TreeNode15.Name = "MusicNode"
        TreeNode15.Text = "Musics"
        TreeNode16.Name = "MiscNodes"
        TreeNode16.Text = "Misc"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4, TreeNode5, TreeNode6, TreeNode7, TreeNode8, TreeNode9, TreeNode10, TreeNode11, TreeNode12, TreeNode13, TreeNode14, TreeNode15, TreeNode16})
        Me.TreeView1.Size = New System.Drawing.Size(246, 505)
        Me.TreeView1.TabIndex = 10
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(806, 99)
        Me.TabControl1.TabIndex = 6
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(798, 71)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Fetch Options"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(96, 13)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 44)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Load New"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Location = New System.Drawing.Point(15, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 44)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Load All"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button4)
        Me.TabPage2.Controls.Add(Me.Button3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(798, 71)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Exports"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(194, 15)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(177, 39)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "Json Shop Generator"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(11, 15)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(177, 39)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "Generate ids.config"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'lblCosmeticInfo
        '
        Me.lblCosmeticInfo.BackColor = System.Drawing.SystemColors.Control
        Me.lblCosmeticInfo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblCosmeticInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCosmeticInfo.Location = New System.Drawing.Point(0, 280)
        Me.lblCosmeticInfo.Multiline = True
        Me.lblCosmeticInfo.Name = "lblCosmeticInfo"
        Me.lblCosmeticInfo.ReadOnly = True
        Me.lblCosmeticInfo.Size = New System.Drawing.Size(269, 225)
        Me.lblCosmeticInfo.TabIndex = 7
        '
        'cosmeticPanel
        '
        Me.cosmeticPanel.Controls.Add(Me.lblCosmeticName)
        Me.cosmeticPanel.Controls.Add(Me.lblCosmeticInfo)
        Me.cosmeticPanel.Controls.Add(Me.lblRarity)
        Me.cosmeticPanel.Controls.Add(Me.Panel1)
        Me.cosmeticPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.cosmeticPanel.Location = New System.Drawing.Point(246, 99)
        Me.cosmeticPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.cosmeticPanel.Name = "cosmeticPanel"
        Me.cosmeticPanel.Size = New System.Drawing.Size(269, 505)
        Me.cosmeticPanel.TabIndex = 11
        '
        'lblCosmeticName
        '
        Me.lblCosmeticName.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblCosmeticName.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCosmeticName.Location = New System.Drawing.Point(0, 280)
        Me.lblCosmeticName.Name = "lblCosmeticName"
        Me.lblCosmeticName.Size = New System.Drawing.Size(269, 30)
        Me.lblCosmeticName.TabIndex = 10
        Me.lblCosmeticName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRarity
        '
        Me.lblRarity.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblRarity.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblRarity.Location = New System.Drawing.Point(0, 250)
        Me.lblRarity.Name = "lblRarity"
        Me.lblRarity.Size = New System.Drawing.Size(269, 30)
        Me.lblRarity.TabIndex = 11
        Me.lblRarity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.Controls.Add(Me.cosImg)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(269, 250)
        Me.Panel1.TabIndex = 12
        '
        'cosImg
        '
        Me.cosImg.BackColor = System.Drawing.Color.Transparent
        Me.cosImg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cosImg.Location = New System.Drawing.Point(0, 0)
        Me.cosImg.Margin = New System.Windows.Forms.Padding(5)
        Me.cosImg.Name = "cosImg"
        Me.cosImg.Padding = New System.Windows.Forms.Padding(5)
        Me.cosImg.Size = New System.Drawing.Size(269, 250)
        Me.cosImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.cosImg.TabIndex = 9
        Me.cosImg.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(806, 604)
        Me.Controls.Add(Me.cosmeticPanel)
        Me.Controls.Add(Me.TreeView1)
        Me.Controls.Add(Me.TabControl1)
        Me.DoubleBuffered = True
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TGV FN Cosmetics Viewer"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.cosmeticPanel.ResumeLayout(False)
        Me.cosmeticPanel.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.cosImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents lblCosmeticInfo As TextBox
    Friend WithEvents cosmeticPanel As Panel
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Button3 As Button
    Friend WithEvents lblCosmeticName As Label
    Friend WithEvents lblRarity As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cosImg As PictureBox
    Friend WithEvents Button4 As Button
End Class
