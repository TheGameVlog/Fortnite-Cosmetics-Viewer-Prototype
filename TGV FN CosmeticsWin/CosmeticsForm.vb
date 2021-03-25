Imports System.Net
Imports Newtonsoft.Json
Imports TGVFNCosmeticsCore
Imports System.IO
Imports System.Drawing.Drawing2D
Imports Fortnite_API.Objects.V2

Public Class Form1


#Region "Basic Declarations"
    Dim OfficersFort As New OfficersFortniteAPI
    Dim allCosmetics As List(Of Fortnite_API.Objects.V2.BrCosmeticV2) = OfficersFort.GetAllCosmetics()
    Dim newCosmetics As Fortnite_API.Objects.V2.BrNewCosmeticsV2 = OfficersFort.GetNewCosmetics()
    Dim stopwatch As New Stopwatch
#End Region

#Region "Collection Variables Declaration"
    Dim DisplayTypeList As New ArrayList
    Dim BackBlingList, BannerList, OutfitList, PetList, PickaxeList, EmoteList, BuiltInEmoteList, EmoticonList, LoadingScreenList, ContrailList, GliderList, MusicList, MusicPackList, SprayList, ToyList, WrapList, MiscList As New Dictionary(Of String, BrCosmeticV2)

    Private Sub TabControl1_Selected(sender As Object, e As TabControlEventArgs) Handles TabControl1.Selected
        If TabControl1.SelectedIndex = 1 Then
            trvcosmetics.CheckBoxes = True
        Else
            trvcosmetics.CheckBoxes = False
        End If
    End Sub
    Dim isVariantNode As Boolean = False

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles trvcosmetics.AfterSelect

        Dim selectedNode = e.Node

        Dim selectedCosmetic = allCosmetics.Find(Function(value As Fortnite_API.Objects.V2.BrCosmeticV2)
                                                     Return value.Id = selectedNode.Name
                                                 End Function)

        If selectedCosmetic IsNot Nothing Then
            lblCosmeticInfo.ResetText()
            lbldesc.ResetText()
            cosImg.SizeMode = PictureBoxSizeMode.StretchImage
            cosImg.Load(selectedCosmetic.Images.Icon.AbsoluteUri)
            With selectedCosmetic
                lblCosmeticName.Text = .Name
                lblRarity.Text = .Rarity.DisplayValue
                ColorRarity(.Rarity.DisplayValue.ToLower())
                lblCosmeticInfo.AppendText(.Id)
                lblCosmeticInfo.AppendText(vbCrLf)
                If .HasIntroduction Then
                    lbldesc.AppendText(.Introduction.Text)
                    lbldesc.AppendText(vbCrLf)
                End If
                lbldesc.AppendText(.Description)
                lbldesc.AppendText(.ExclusiveDescription)
                If .HasSet Then
                    lbldesc.AppendText(vbCrLf)
                    lbldesc.AppendText(.Set.Text)
                End If
                txtVariantInfo.ResetText()

                If .HasVariants Then
                    txtVariantInfo.AppendText("Has Variants : " & .HasVariants)
                    txtVariantInfo.AppendText(vbCrLf)
                    txtVariantInfo.AppendText("=========")
                    .Variants(0).Options.RemoveAt(0)
                    For Each v As BrCosmeticV2Variant In .Variants
                        For Each op In v.Options

                            txtVariantInfo.AppendText(vbCrLf)
                                txtVariantInfo.AppendText(op.Name)
                                If op.UnlockRequirements <> "" Then
                                    txtVariantInfo.AppendText(vbCrLf)
                                    txtVariantInfo.AppendText(op.UnlockRequirements)
                                End If
                                txtVariantInfo.AppendText(vbCrLf)
                                txtVariantInfo.AppendText("=========")

                        Next
                    Next
                    txtVariantInfo.SelectionLength = 0
                    txtVariantInfo.SelectionStart = 0
                    txtVariantInfo.ScrollToCaret()
                End If
            End With
        Else
            If e.Node.Name.Contains("fortnite-api.com") Then
                cosImg.Refresh()
                Dim req = WebRequest.Create(e.Node.Name)
                Dim res = req.GetResponse().GetResponseStream()
                cosImg.Image = ResizeImage(Bitmap.FromStream(res), 256, 256)
                cosImg.Refresh()
                cosImg.SizeMode = PictureBoxSizeMode.StretchImage
            End If
        End If
        isVariantNode = False
    End Sub
#End Region

#Region " ResizeImage "
    Public Overloads Shared Function ResizeImage(SourceImage As Drawing.Image, TargetWidth As Int32, TargetHeight As Int32) As Drawing.Bitmap
        Dim bmSource = New Drawing.Bitmap(SourceImage)

        Return ResizeImage(bmSource, TargetWidth, TargetHeight)
    End Function

    Public Overloads Shared Function ResizeImage(bmSource As Drawing.Bitmap, TargetWidth As Int32, TargetHeight As Int32) As Drawing.Bitmap
        Dim bmDest As New Drawing.Bitmap(TargetWidth, TargetHeight, Drawing.Imaging.PixelFormat.Format32bppArgb)

        Dim nSourceAspectRatio = bmSource.Width / bmSource.Height
        Dim nDestAspectRatio = bmDest.Width / bmDest.Height

        Dim NewX = 0
        Dim NewY = 0
        Dim NewWidth = bmDest.Width
        Dim NewHeight = bmDest.Height

        If nDestAspectRatio = nSourceAspectRatio Then
            'same ratio
        ElseIf nDestAspectRatio > nSourceAspectRatio Then
            'Source is taller
            NewWidth = Convert.ToInt32(Math.Floor(nSourceAspectRatio * NewHeight))
            NewX = Convert.ToInt32(Math.Floor((bmDest.Width - NewWidth) / 2))
        Else
            'Source is wider
            NewHeight = Convert.ToInt32(Math.Floor((1 / nSourceAspectRatio) * NewWidth))
            NewY = Convert.ToInt32(Math.Floor((bmDest.Height - NewHeight) / 2))
        End If

        Using grDest = Drawing.Graphics.FromImage(bmDest)
            With grDest
                .CompositingQuality = CompositingQuality.HighQuality
                .SmoothingMode = SmoothingMode.HighQuality
                .InterpolationMode = InterpolationMode.NearestNeighbor
                .CompositingMode = CompositingMode.SourceCopy

                .DrawImage(bmSource, NewX, NewY, NewWidth, NewHeight)
            End With
        End Using

        Return bmDest
    End Function
#End Region

    Public Sub ColorRarity(rarity As String)

        Select Case rarity
            Case "common"
                '#cacaca
                '#7b7b7b
                RarityTop = ColorTranslator.FromHtml("#cacaca")
                RarityBottom = ColorTranslator.FromHtml("#7b7b7b")
                lblRarity.BackColor = ColorTranslator.FromHtml("#7b7b7b")
                Panel1.Refresh()

            Case "uncommon"

                RarityTop = ColorTranslator.FromHtml("#80cf3f")
                RarityBottom = ColorTranslator.FromHtml("#3a7913")
                lblRarity.BackColor = ColorTranslator.FromHtml("#3a7913")

            Case "rare"

                RarityTop = ColorTranslator.FromHtml("#2fd5e8")
                RarityBottom = ColorTranslator.FromHtml("#1258a2")
                lblRarity.BackColor = ColorTranslator.FromHtml("#1258a2")

            Case "epic"

                RarityTop = ColorTranslator.FromHtml("#bd3ffa")
                RarityBottom = ColorTranslator.FromHtml("#460d7f")
                lblRarity.BackColor = ColorTranslator.FromHtml("#460d7f")

            Case "legendary"

                RarityTop = ColorTranslator.FromHtml("#fdae53")
                RarityBottom = ColorTranslator.FromHtml("#ff7605")
                lblRarity.BackColor = ColorTranslator.FromHtml("#ff7605")

            Case "mytic"
                RarityTop = ColorTranslator.FromHtml("#fcdd79")
                RarityBottom = ColorTranslator.FromHtml("#dca01e")
                lblRarity.BackColor = ColorTranslator.FromHtml("#dca01e")

            Case "marvel series"
                RarityTop = ColorTranslator.FromHtml("#880202")
                RarityBottom = ColorTranslator.FromHtml("#d40205")
                lblRarity.BackColor = ColorTranslator.FromHtml("#d40205")

            Case "dc series"
                RarityTop = ColorTranslator.FromHtml("#152333")
                RarityBottom = ColorTranslator.FromHtml("#2c435d")
                lblRarity.BackColor = ColorTranslator.FromHtml("#2c435d")

            Case "star wars series"
                Panel1.BackgroundImage = My.Resources.ResourceManager.GetObject("swsbg")

            Case "dark series"
                Panel1.BackgroundImage = My.Resources.ResourceManager.GetObject("dsbg")

            Case "frozen series"
                Panel1.BackgroundImage = My.Resources.ResourceManager.GetObject("fsbg")


            Case Else
                RarityTop = Color.Transparent
                RarityBottom = Color.Transparent
        End Select

    End Sub

    Dim RarityTop As Color
    Dim RarityBottom As Color

    Private Sub cosImg_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        Dim direction As LinearGradientMode = LinearGradientMode.Vertical
        Dim Brush As LinearGradientBrush = New LinearGradientBrush(Panel1.ClientRectangle, RarityTop, RarityBottom, direction)
        e.Graphics.FillRectangle(Brush, Panel1.ClientRectangle)
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnLoadNew.Click, btnLoadAll.Click
        sender.Enabled = False
        Select Case sender.text
            Case "Load All"
                LoadCosmetics(allCosmetics)
            Case "Load New"
                LoadCosmetics(newCosmetics.Items)
        End Select

        sender.Enabled = True
    End Sub

    Public Sub LoadCosmetics(cosmeticList As List(Of Fortnite_API.Objects.V2.BrCosmeticV2))

        For Each n As TreeNode In trvcosmetics.Nodes
            n.Nodes.Clear()
        Next

        ClearLists()


        For Each c As Fortnite_API.Objects.V2.BrCosmeticV2 In cosmeticList

#Region "Display Type Switch Case"
            Select Case c.Type.DisplayValue
                Case "Banner"
                    If Not BannerList.ContainsKey(c.Id) Then
                        BannerList.Add(c.Id, c)
                    End If
                Case "Back Bling"
                    If Not BackBlingList.ContainsKey(c.Id) Then
                        BackBlingList.Add(c.Id, c)
                    End If
                Case "PET", "Pet"
                    If Not PetList.ContainsKey(c.Id) Then
                        PetList.Add(c.Id, c)
                    End If
                Case "Harvesting Tool"
                    If Not PickaxeList.ContainsKey(c.Id) Then
                        PickaxeList.Add(c.Id, c)
                    End If
                Case "Outfit"
                    If Not OutfitList.ContainsKey(c.Id) Then
                        OutfitList.Add(c.Id, c)
                    End If
                Case "Contrail"
                    If Not ContrailList.ContainsKey(c.Id) Then
                        ContrailList.Add(c.Id, c)
                    End If
                Case "Glider"
                    If Not GliderList.ContainsKey(c.Id) Then
                        GliderList.Add(c.Id, c)
                    End If
                Case "Emote"
                    If Not EmoteList.ContainsKey(c.Id) Then
                        EmoteList.Add(c.Id, c)
                    End If
                Case "Built-in Emote", "AI Iron Man Emote"
                    If Not BuiltInEmoteList.ContainsKey(c.Id) Then
                        BuiltInEmoteList.Add(c.Id, c)
                    End If

                Case "Emoticon"
                    If Not EmoticonList.ContainsKey(c.Id) Then
                        EmoticonList.Add(c.Id, c)
                    End If
                Case "Loading Screen"
                    If Not LoadingScreenList.ContainsKey(c.Id) Then
                        LoadingScreenList.Add(c.Id, c)
                    End If
                Case "Music"
                    If Not MusicList.ContainsKey(c.Id) Then
                        MusicList.Add(c.Id, c)
                    End If
                Case "Music Pack"
                    If Not MusicPackList.ContainsKey(c.Id) Then
                        MusicPackList.Add(c.Id, c)
                    End If
                Case "Spray", "Test Spray"
                    If Not SprayList.ContainsKey(c.Id) Then
                        SprayList.Add(c.Id, c)
                    End If
                Case "Toy"
                    If Not ToyList.ContainsKey(c.Id) Then
                        ToyList.Add(c.Id, c)
                    End If
                Case "Wrap"
                    If Not WrapList.ContainsKey(c.Id) Then
                        WrapList.Add(c.Id, c)
                    End If
                Case "null"
                    If Not MiscList.ContainsKey(c.Id) Then
                        MiscList.Add(c.Id, c)
                    End If

            End Select
#End Region

        Next


#Region "Adding Items from the List to the Treenode"

        For Each bb As KeyValuePair(Of String, BrCosmeticV2) In BackBlingList
            If bb.Value <> Nothing Then
                trvcosmetics.Nodes("BackBlingNode").Nodes.Add(bb.Key, bb.Value.Name)
                Dim currentCosmetic = bb.Value
                If currentCosmetic IsNot Nothing Then
                    If currentCosmetic.HasVariants Then
                        currentCosmetic.Variants(0).Options.RemoveAt(0)
                        Dim variantList = currentCosmetic.Variants(0).Options
                        For Each v As Fortnite_API.Objects.V2.BrCosmeticV2VariantOption In variantList
                            trvcosmetics.Nodes("BackBlingNode").Nodes(bb.Key).Nodes.Add(v.Image.ToString(), v.Name)
                        Next

                    End If
                End If

            End If
        Next

        For Each bb As KeyValuePair(Of String, BrCosmeticV2) In OutfitList
            If bb.Value <> Nothing Then
                trvcosmetics.Nodes("OutfitNode").Nodes.Add(bb.Key, bb.Value.Name)
            End If
            Dim currentCosmetic = allCosmetics.Find(Function(value As Fortnite_API.Objects.V2.BrCosmeticV2)
                                                        Return value.Id = bb.Key
                                                    End Function)
            If currentCosmetic IsNot Nothing Then
                If currentCosmetic.HasVariants Then
                    currentCosmetic.Variants(0).Options.RemoveAt(0)
                    Dim variantList = currentCosmetic.Variants(0).Options
                    For Each v As Fortnite_API.Objects.V2.BrCosmeticV2VariantOption In variantList
                        trvcosmetics.Nodes("OutfitNode").Nodes(bb.Key).Nodes.Add(v.Image.ToString(), v.Name)
                    Next

                End If
            End If
        Next

        For Each bb As KeyValuePair(Of String, BrCosmeticV2) In BannerList
            If bb.Value <> Nothing Then
                trvcosmetics.Nodes("BannerNode").Nodes.Add(bb.Key, bb.Value.Name)
            End If
        Next

        For Each bb As KeyValuePair(Of String, BrCosmeticV2) In PetList
            If bb.Value <> Nothing Then
                trvcosmetics.Nodes("PetNode").Nodes.Add(bb.Key, bb.Value.Name)
            End If
        Next

        For Each bb As KeyValuePair(Of String, BrCosmeticV2) In PickaxeList
            If bb.Value <> Nothing Then
                trvcosmetics.Nodes("PickaxeNode").Nodes.Add(bb.Key, bb.Value.Name)
            End If
            Dim currentCosmetic = bb.Value
            If currentCosmetic IsNot Nothing Then
                If currentCosmetic.HasVariants Then
                    currentCosmetic.Variants(0).Options.RemoveAt(0)

                    Dim variantList = currentCosmetic.Variants(0).Options
                    For Each v As Fortnite_API.Objects.V2.BrCosmeticV2VariantOption In variantList
                        trvcosmetics.Nodes("PickaxeNode").Nodes(bb.Key).Nodes.Add(v.Image.ToString(), v.Name)
                    Next

                End If
            End If
        Next
        For Each bb As KeyValuePair(Of String, BrCosmeticV2) In MiscList
            If bb.Value <> Nothing Then
                trvcosmetics.Nodes("MiscNodes").Nodes.Add(bb.Key, bb.Value.Name)
            End If
        Next
        For Each bb As KeyValuePair(Of String, BrCosmeticV2) In LoadingScreenList
            If bb.Value <> Nothing Then
                trvcosmetics.Nodes("LoadingScreenNode").Nodes.Add(bb.Key, bb.Value.Name)
            End If

        Next
        For Each bb As KeyValuePair(Of String, BrCosmeticV2) In ContrailList
            If bb.Value <> Nothing Then
                trvcosmetics.Nodes("ContrailNode").Nodes.Add(bb.Key, bb.Value.Name)
            End If
        Next
        For Each bb As KeyValuePair(Of String, BrCosmeticV2) In WrapList
            If bb.Value <> Nothing Then
                trvcosmetics.Nodes("WrapsNode").Nodes.Add(bb.Key, bb.Value.Name)
            End If
        Next

        For Each bb As KeyValuePair(Of String, BrCosmeticV2) In EmoteList
            If bb.Value <> Nothing Then
                trvcosmetics.Nodes("EmotesNode").Nodes.Add(bb.Key, bb.Value.Name)
            End If
        Next

        For Each bb As KeyValuePair(Of String, BrCosmeticV2) In BuiltInEmoteList
            If bb.Value <> Nothing Then
                trvcosmetics.Nodes("BuiltinEmoteNode").Nodes.Add(bb.Key, bb.Value.Name)
            End If
        Next

        For Each bb As KeyValuePair(Of String, BrCosmeticV2) In GliderList
            If bb.Value <> Nothing Then
                trvcosmetics.Nodes("GliderNode").Nodes.Add(bb.Key, bb.Value.Name)
            End If
        Next

        For Each bb As KeyValuePair(Of String, BrCosmeticV2) In EmoticonList
            If bb.Value <> Nothing Then
                trvcosmetics.Nodes("EmoticonNode").Nodes.Add(bb.Key, bb.Value.Name)
            End If
        Next

        For Each bb As KeyValuePair(Of String, BrCosmeticV2) In MusicList
            If bb.Value <> Nothing Then
                trvcosmetics.Nodes("MusicNode").Nodes.Add(bb.Key, bb.Value.Name)
            End If
        Next

        For Each bb As KeyValuePair(Of String, BrCosmeticV2) In SprayList
            If bb.Value <> Nothing Then
                trvcosmetics.Nodes("SprayNode").Nodes.Add(bb.Key, bb.Value.Name)
            End If
        Next

        For Each bb As KeyValuePair(Of String, BrCosmeticV2) In ToyList
            If bb.Value <> Nothing Then
                trvcosmetics.Nodes("ToyNode").Nodes.Add(bb.Key, bb.Value.Name)
            End If
        Next

#End Region

        trvcosmetics.Enabled = True
    End Sub


    Public Sub ClearLists()
        BackBlingList.Clear()
        BannerList.Clear()
        OutfitList.Clear()
        PetList.Clear()
        PickaxeList.Clear()
        EmoteList.Clear()
        BuiltInEmoteList.Clear()
        EmoticonList.Clear()
        LoadingScreenList.Clear()
        ContrailList.Clear()
        GliderList.Clear()
        MusicList.Clear()
        MusicPackList.Clear()
        SprayList.Clear()
        ToyList.Clear()
        WrapList.Clear()
        MiscList.Clear()
    End Sub

    Public Function GenerateIDSConfig() As Boolean
        Dim ids As String = ""

        Try
            For Each c In OutfitList
                If trvcosmetics.Nodes.Find(c.Key, True)(0).Checked Then
                    ids &= "AthenaCharacter:" & c.Key & vbCrLf
                End If
            Next

            For Each c In BackBlingList
                If trvcosmetics.Nodes.Find(c.Key, True)(0).Checked Then
                    ids &= "AthenaBackpack:" & c.Key & vbCrLf
                End If
            Next

            For Each c In PetList
                If trvcosmetics.Nodes.Find(c.Key, True)(0).Checked Then
                    ids &= "AthenaBackpack:" & c.Key & vbCrLf
                End If
            Next

            For Each c In PickaxeList
                If trvcosmetics.Nodes.Find(c.Key, True)(0).Checked Then
                    ids &= "AthenaPickaxe:" & c.Key & vbCrLf
                End If
            Next

            For Each c In EmoteList
                If trvcosmetics.Nodes.Find(c.Key, True)(0).Checked Then
                    ids &= "AthenaDance:" & c.Key & vbCrLf
                End If
            Next

            For Each c In BuiltInEmoteList
                If trvcosmetics.Nodes.Find(c.Key, True)(0).Checked Then
                    ids &= "AthenaDance:" & c.Key & vbCrLf
                End If
            Next

            For Each c In EmoticonList
                If trvcosmetics.Nodes.Find(c.Key, True)(0).Checked Then
                    ids &= "AthenaDance:" & c.Key & vbCrLf
                End If
            Next

            For Each c In SprayList
                If trvcosmetics.Nodes.Find(c.Key, True)(0).Checked Then
                    ids &= "AthenaDance:" & c.Key & vbCrLf
                End If
            Next

            For Each c In ToyList
                If trvcosmetics.Nodes.Find(c.Key, True)(0).Checked Then
                    ids &= "AthenaDance:" & c.Key & vbCrLf
                End If
            Next

            For Each c In LoadingScreenList
                If trvcosmetics.Nodes.Find(c.Key, True)(0).Checked Then
                    ids &= "AthenaLoadingScreen:" & c.Key & vbCrLf
                End If
            Next

            For Each c In ContrailList
                If trvcosmetics.Nodes.Find(c.Key, True)(0).Checked Then
                    ids &= "AthenaSkyDiveContrail:" & c.Key & vbCrLf
                End If
            Next

            For Each c In GliderList
                If trvcosmetics.Nodes.Find(c.Key, True)(0).Checked Then
                    ids &= "AthenaGlider:" & c.Key & vbCrLf
                End If
            Next

            For Each c In MusicList
                If trvcosmetics.Nodes.Find(c.Key, True)(0).Checked Then
                    ids &= "AthenaMusicPack:" & c.Key & vbCrLf
                End If
            Next

            For Each c In WrapList
                If trvcosmetics.Nodes.Find(c.Key, True)(0).Checked Then
                    ids &= "AthenaItemWrap:" & c.Key & vbCrLf
                End If
            Next

            Dim idwriter As New StreamWriter("ids.config")
            idwriter.Write(ids)
            idwriter.Close()

            Return True

        Catch ex As Exception
            Return False

        End Try
    End Function


    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles btnIDGen.Click
        Dim countselected = areCosmeticsSelected()

        If trvcosmetics.Nodes.Count >= 10 And countselected > 0 Then
            GenerateIDSConfig()
            If MsgBox("Exported " & countselected & " Consmetics to ids.config " & vbCrLf & "Do you want to open the folder,where the file is saved?", MsgBoxStyle.YesNo, "ids.config Created") = MsgBoxResult.Yes Then
                Process.Start("explorer", """" & Environment.CurrentDirectory & """")
            End If
        Else
            MessageBox.Show("Load some cosmetics first dumbo", "I told you its for 200 IQ's")
        End If
    End Sub

    Private Sub CosmeticsForm_Enter(sender As Object, e As EventArgs) Handles Me.Enter
        trvcosmetics.Enabled = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        TabControl1.SelectedTab = TabControl1.TabPages(0)
    End Sub

    Public Function areCosmeticsSelected() As Integer
        Dim cnt As Integer = 0
        For Each n As TreeNode In trvcosmetics.Nodes
            For Each nc As TreeNode In n.Nodes
                If nc.Checked = True Then
                    cnt += 1
                End If
            Next
        Next
        Return cnt
    End Function

    Private Sub TreeView1_AfterCheck(sender As Object, e As TreeViewEventArgs) Handles trvCosmetics.AfterCheck
        If e.Node.Nodes.Count <> 0 Then
            If e.Node.Checked = True Then
                For Each n As TreeNode In e.Node.Nodes
                    n.Checked = True
                Next
            Else
                For Each n As TreeNode In e.Node.Nodes
                    n.Checked = False
                Next
            End If

        End If
    End Sub
End Class