
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
        Me.trvcosmetics = New System.Windows.Forms.TreeView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnLoadNew = New System.Windows.Forms.Button()
        Me.btnLoadAll = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnShopGen = New System.Windows.Forms.Button()
        Me.btnIDGen = New System.Windows.Forms.Button()
        Me.lblCosmeticInfo = New System.Windows.Forms.TextBox()
        Me.cosmeticPanel = New System.Windows.Forms.Panel()
        Me.lbldesc = New System.Windows.Forms.TextBox()
        Me.lblRarity = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cosImg = New System.Windows.Forms.PictureBox()
        Me.lblCosmeticName = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtVariantInfo = New System.Windows.Forms.TextBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.cosmeticPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.cosImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'trvcosmetics
        '
        Me.trvcosmetics.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.trvcosmetics.Dock = System.Windows.Forms.DockStyle.Left
        Me.trvcosmetics.Location = New System.Drawing.Point(0, 99)
        Me.trvcosmetics.Name = "trvcosmetics"
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
        Me.trvcosmetics.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4, TreeNode5, TreeNode6, TreeNode7, TreeNode8, TreeNode9, TreeNode10, TreeNode11, TreeNode12, TreeNode13, TreeNode14, TreeNode15, TreeNode16})
        Me.trvcosmetics.Size = New System.Drawing.Size(246, 505)
        Me.trvcosmetics.TabIndex = 10
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
        Me.TabPage1.Controls.Add(Me.btnLoadNew)
        Me.TabPage1.Controls.Add(Me.btnLoadAll)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(798, 71)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Fetch Options"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnLoadNew
        '
        Me.btnLoadNew.Location = New System.Drawing.Point(96, 13)
        Me.btnLoadNew.Name = "btnLoadNew"
        Me.btnLoadNew.Size = New System.Drawing.Size(75, 44)
        Me.btnLoadNew.TabIndex = 1
        Me.btnLoadNew.Text = "Load New"
        Me.btnLoadNew.UseVisualStyleBackColor = True
        '
        'btnLoadAll
        '
        Me.btnLoadAll.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnLoadAll.Location = New System.Drawing.Point(15, 13)
        Me.btnLoadAll.Name = "btnLoadAll"
        Me.btnLoadAll.Size = New System.Drawing.Size(75, 44)
        Me.btnLoadAll.TabIndex = 0
        Me.btnLoadAll.Text = "Load All"
        Me.btnLoadAll.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnShopGen)
        Me.TabPage2.Controls.Add(Me.btnIDGen)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(798, 71)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Exports"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnShopGen
        '
        Me.btnShopGen.Location = New System.Drawing.Point(194, 15)
        Me.btnShopGen.Name = "btnShopGen"
        Me.btnShopGen.Size = New System.Drawing.Size(177, 39)
        Me.btnShopGen.TabIndex = 2
        Me.btnShopGen.Text = "Json Shop Generator"
        Me.btnShopGen.UseVisualStyleBackColor = True
        '
        'btnIDGen
        '
        Me.btnIDGen.Location = New System.Drawing.Point(11, 15)
        Me.btnIDGen.Name = "btnIDGen"
        Me.btnIDGen.Size = New System.Drawing.Size(177, 39)
        Me.btnIDGen.TabIndex = 1
        Me.btnIDGen.Text = "Generate ids.config"
        Me.btnIDGen.UseVisualStyleBackColor = True
        '
        'lblCosmeticInfo
        '
        Me.lblCosmeticInfo.BackColor = System.Drawing.SystemColors.Control
        Me.lblCosmeticInfo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblCosmeticInfo.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblCosmeticInfo.Location = New System.Drawing.Point(0, 367)
        Me.lblCosmeticInfo.Multiline = True
        Me.lblCosmeticInfo.Name = "lblCosmeticInfo"
        Me.lblCosmeticInfo.ReadOnly = True
        Me.lblCosmeticInfo.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.lblCosmeticInfo.Size = New System.Drawing.Size(280, 114)
        Me.lblCosmeticInfo.TabIndex = 7
        '
        'cosmeticPanel
        '
        Me.cosmeticPanel.Controls.Add(Me.lblCosmeticInfo)
        Me.cosmeticPanel.Controls.Add(Me.lbldesc)
        Me.cosmeticPanel.Controls.Add(Me.lblRarity)
        Me.cosmeticPanel.Controls.Add(Me.Panel1)
        Me.cosmeticPanel.Controls.Add(Me.lblCosmeticName)
        Me.cosmeticPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.cosmeticPanel.Location = New System.Drawing.Point(246, 99)
        Me.cosmeticPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.cosmeticPanel.Name = "cosmeticPanel"
        Me.cosmeticPanel.Size = New System.Drawing.Size(280, 505)
        Me.cosmeticPanel.TabIndex = 11
        '
        'lbldesc
        '
        Me.lbldesc.BackColor = System.Drawing.SystemColors.Control
        Me.lbldesc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbldesc.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbldesc.Location = New System.Drawing.Point(0, 317)
        Me.lbldesc.Multiline = True
        Me.lbldesc.Name = "lbldesc"
        Me.lbldesc.ReadOnly = True
        Me.lbldesc.Size = New System.Drawing.Size(280, 50)
        Me.lbldesc.TabIndex = 13
        Me.lbldesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblRarity
        '
        Me.lblRarity.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblRarity.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblRarity.Location = New System.Drawing.Point(0, 285)
        Me.lblRarity.Name = "lblRarity"
        Me.lblRarity.Size = New System.Drawing.Size(280, 32)
        Me.lblRarity.TabIndex = 11
        Me.lblRarity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.Controls.Add(Me.cosImg)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 35)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(280, 250)
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
        Me.cosImg.Size = New System.Drawing.Size(280, 250)
        Me.cosImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.cosImg.TabIndex = 9
        Me.cosImg.TabStop = False
        '
        'lblCosmeticName
        '
        Me.lblCosmeticName.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblCosmeticName.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCosmeticName.Location = New System.Drawing.Point(0, 0)
        Me.lblCosmeticName.Name = "lblCosmeticName"
        Me.lblCosmeticName.Size = New System.Drawing.Size(280, 35)
        Me.lblCosmeticName.TabIndex = 10
        Me.lblCosmeticName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtVariantInfo)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(526, 99)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(280, 505)
        Me.Panel2.TabIndex = 12
        '
        'txtVariantInfo
        '
        Me.txtVariantInfo.BackColor = System.Drawing.Color.White
        Me.txtVariantInfo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtVariantInfo.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtVariantInfo.Location = New System.Drawing.Point(0, 0)
        Me.txtVariantInfo.Multiline = True
        Me.txtVariantInfo.Name = "txtVariantInfo"
        Me.txtVariantInfo.ReadOnly = True
        Me.txtVariantInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtVariantInfo.Size = New System.Drawing.Size(280, 285)
        Me.txtVariantInfo.TabIndex = 14
        Me.txtVariantInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(806, 604)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.cosmeticPanel)
        Me.Controls.Add(Me.trvcosmetics)
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
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents trvcosmetics As TreeView
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btnLoadNew As Button
    Friend WithEvents btnLoada As Button
    Friend WithEvents lblCosmeticInfo As TextBox
    Friend WithEvents cosmeticPanel As Panel
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btnIDGen As Button
    Friend WithEvents lblCosmeticName As Label
    Friend WithEvents lblRarity As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cosImg As PictureBox
    Friend WithEvents btnShop As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnLoadAll As Button
    Friend WithEvents btnShopGen As Button
    Friend WithEvents l As TextBox
    Friend WithEvents b As TextBox
    Friend WithEvents lbld As TextBox
    Friend WithEvents lbldesc As TextBox
    Friend WithEvents txtVariantInfo As TextBox
    Friend WithEvents o As TextBox
End Class
