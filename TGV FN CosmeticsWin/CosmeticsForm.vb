Imports System.Net
Imports Newtonsoft.Json
Imports TGVFNCosmeticsCore
Imports System.IO
Imports System.Drawing.Drawing2D

Public Class Form1


#Region "Basic Declarations"
    Dim OfficersFort As New OfficersFortniteAPI
    Dim allCosmetics As List(Of Fortnite_API.Objects.V2.BrCosmeticV2) = OfficersFort.GetAllCosmetics()
    Dim newCosmetics As Fortnite_API.Objects.V2.BrNewCosmeticsV2 = OfficersFort.GetNewCosmetics()
    Dim stopwatch As New Stopwatch
#End Region

#Region "Collection Variables Declaration"
    Dim DisplayTypeList As New ArrayList
    Dim BackBlingList, BannerList, OutfitList, PetList, PickaxeList, EmoteList, BuiltInEmoteList, EmoticonList, LoadingScreenList, ContrailList, GliderList, MusicList, MusicPackList, SprayList, ToyList, WrapList, MiscList As New Dictionary(Of String, String)

    Private Sub TabControl1_Selected(sender As Object, e As TabControlEventArgs) Handles TabControl1.Selected
        If TabControl1.SelectedIndex = 1 Then
            TreeView1.CheckBoxes = True
        Else
            TreeView1.CheckBoxes = False
        End If
    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        If TreeView1.SelectedNode.Nodes.Count = 0 Then
            Dim selectedNode = TreeView1.SelectedNode
            Dim selectedCosmetic = allCosmetics.Find(Function(value As Fortnite_API.Objects.V2.BrCosmeticV2)
                                                         Return value.Id = selectedNode.Name
                                                     End Function)

            If selectedCosmetic IsNot Nothing Then
                lblCosmeticInfo.ResetText()
                cosImg.Load(selectedCosmetic.Images.Icon.AbsoluteUri)
                With selectedCosmetic
                    lblCosmeticName.Text = .Name
                    lblRarity.Text = .Rarity.DisplayValue
                    ColorRarity(.Rarity.DisplayValue)
                    lblCosmeticInfo.AppendText(.Id)
                    lblCosmeticInfo.AppendText(vbCrLf)
                    If .HasGameplayTags Then
                        For Each t As String In .GameplayTags
                            lblCosmeticInfo.AppendText(t)
                            lblCosmeticInfo.AppendText(vbCrLf)
                        Next
                    End If

                End With
            End If

        End If
    End Sub
#End Region

    Public Sub ColorRarity(rarity As String)

        Select Case rarity
            Case "Common"
                '#cacaca
                '#7b7b7b
                RarityTop = ColorTranslator.FromHtml("#cacaca")
                RarityBottom = ColorTranslator.FromHtml("#7b7b7b")
                lblRarity.BackColor = ColorTranslator.FromHtml("#7b7b7b")
                Panel1.Refresh()

            Case "Uncommon"

                RarityTop = ColorTranslator.FromHtml("#80cf3f")
                RarityBottom = ColorTranslator.FromHtml("#3a7913")
                lblRarity.BackColor = ColorTranslator.FromHtml("#3a7913")

            Case "Rare"

                RarityTop = ColorTranslator.FromHtml("#2fd5e8")
                RarityBottom = ColorTranslator.FromHtml("#1258a2")
                lblRarity.BackColor = ColorTranslator.FromHtml("#1258a2")

            Case "Epic"

                RarityTop = ColorTranslator.FromHtml("#bd3ffa")
                RarityBottom = ColorTranslator.FromHtml("#460d7f")
                lblRarity.BackColor = ColorTranslator.FromHtml("#460d7f")

            Case "Legendary"

                RarityTop = ColorTranslator.FromHtml("#fdae53")
                RarityBottom = ColorTranslator.FromHtml("#ff7605")
                lblRarity.BackColor = ColorTranslator.FromHtml("#ff7605")



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


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click, Button1.Click
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

        For Each n As TreeNode In TreeView1.Nodes
            n.Nodes.Clear()
        Next

        'The Display Values returned from the API    
        'Banner
        'null
        'Back Bling
        'PET
        'Pet
        'Harvesting Tool
        'Outfit
        'Contrail
        'Glider
        'Emote
        'Built-in Emote
        'AI Iron Man Emote
        'Emoticon
        'Loading Screen
        'Music
        'Music Pack
        'Test Spray
        'Spray
        'Toy
        'Wrap

        ClearLists()

        For Each c As Fortnite_API.Objects.V2.BrCosmeticV2 In cosmeticList

#Region "Display Type Switch Case"
            Select Case c.Type.DisplayValue
                Case "Banner"
                    If Not BannerList.ContainsKey(c.Id) Then
                        BannerList.Add(c.Id, c.Name)
                    End If
                Case "Back Bling"
                    If Not BackBlingList.ContainsKey(c.Id) Then
                        BackBlingList.Add(c.Id, c.Name)
                    End If
                Case "PET", "Pet"
                    If Not PetList.ContainsKey(c.Id) Then
                        PetList.Add(c.Id, c.Name)
                    End If
                Case "Harvesting Tool"
                    If Not PickaxeList.ContainsKey(c.Id) Then
                        PickaxeList.Add(c.Id, c.Name)
                    End If
                Case "Outfit"
                    If Not OutfitList.ContainsKey(c.Id) Then
                        OutfitList.Add(c.Id, c.Name)
                        If c.HasVariants Then

                        End If
                    End If
                Case "Contrail"
                    If Not ContrailList.ContainsKey(c.Id) Then
                        ContrailList.Add(c.Id, c.Name)
                    End If
                Case "Glider"
                    If Not GliderList.ContainsKey(c.Id) Then
                        GliderList.Add(c.Id, c.Name)
                    End If
                Case "Emote"
                    If Not EmoteList.ContainsKey(c.Id) Then
                        EmoteList.Add(c.Id, c.Name)
                    End If
                Case "Built-in Emote", "AI Iron Man Emote"
                    If Not BuiltInEmoteList.ContainsKey(c.Id) Then
                        BuiltInEmoteList.Add(c.Id, c.Name)
                    End If

                Case "Emoticon"
                    If Not EmoticonList.ContainsKey(c.Id) Then
                        EmoticonList.Add(c.Id, c.Name)
                    End If
                Case "Loading Screen"
                    If Not LoadingScreenList.ContainsKey(c.Id) Then
                        LoadingScreenList.Add(c.Id, c.Name)
                    End If
                Case "Music"
                    If Not MusicList.ContainsKey(c.Id) Then
                        MusicList.Add(c.Id, c.Name)
                    End If
                Case "Music Pack"
                    If Not MusicPackList.ContainsKey(c.Id) Then
                        MusicPackList.Add(c.Id, c.Name)
                    End If
                Case "Spray", "Test Spray"
                    If Not SprayList.ContainsKey(c.Id) Then
                        SprayList.Add(c.Id, c.Name)
                    End If
                Case "Toy"
                    If Not ToyList.ContainsKey(c.Id) Then
                        ToyList.Add(c.Id, c.Name)
                    End If
                Case "Wrap"
                    If Not WrapList.ContainsKey(c.Id) Then
                        WrapList.Add(c.Id, c.Name)
                    End If
                Case "null"
                    If Not MiscList.ContainsKey(c.Id) Then
                        MiscList.Add(c.Id, c.Name)
                    End If

            End Select
#End Region

        Next

#Region "Adding Items from the List to the Treenode"

        For Each bb As KeyValuePair(Of String, String) In BackBlingList
            If bb.Value <> "null" Then
                TreeView1.Nodes("BackBlingNode").Nodes.Add(bb.Key, bb.Value)
            End If
        Next

        For Each bb As KeyValuePair(Of String, String) In OutfitList
            If bb.Value <> "null" Then
                TreeView1.Nodes("OutfitNode").Nodes.Add(bb.Key, bb.Value)
            End If
        Next

        For Each bb As KeyValuePair(Of String, String) In BannerList
            If bb.Value <> "null" Then
                TreeView1.Nodes("BannerNode").Nodes.Add(bb.Key, bb.Value)
            End If
        Next

        For Each bb As KeyValuePair(Of String, String) In PetList
            If bb.Value <> "null" Then
                TreeView1.Nodes("PetNode").Nodes.Add(bb.Key, bb.Value)
            End If
        Next

        For Each bb As KeyValuePair(Of String, String) In PickaxeList
            If bb.Value <> "null" Then
                TreeView1.Nodes("PickaxeNode").Nodes.Add(bb.Key, bb.Value)
            End If
        Next
        For Each bb As KeyValuePair(Of String, String) In MiscList
            If bb.Value <> "null" Then
                TreeView1.Nodes("MiscNodes").Nodes.Add(bb.Key, bb.Value)
            End If
        Next
        For Each bb As KeyValuePair(Of String, String) In LoadingScreenList
            If bb.Value <> "null" Then
                TreeView1.Nodes("LoadingScreenNode").Nodes.Add(bb.Key, bb.Value)
            End If

        Next
        For Each bb As KeyValuePair(Of String, String) In ContrailList
            If bb.Value <> "null" Then
                TreeView1.Nodes("ContrailNode").Nodes.Add(bb.Key, bb.Value)
            End If
        Next
        For Each bb As KeyValuePair(Of String, String) In WrapList
            If bb.Value <> "null" Then
                TreeView1.Nodes("WrapsNode").Nodes.Add(bb.Key, bb.Value)
            End If
        Next

        For Each bb As KeyValuePair(Of String, String) In EmoteList
            If bb.Value <> "null" Then
                TreeView1.Nodes("EmotesNode").Nodes.Add(bb.Key, bb.Value)
            End If
        Next

        For Each bb As KeyValuePair(Of String, String) In BuiltInEmoteList
            If bb.Value <> "null" Then
                TreeView1.Nodes("BuiltinEmoteNode").Nodes.Add(bb.Key, bb.Value)
            End If
        Next

        For Each bb As KeyValuePair(Of String, String) In GliderList
            If bb.Value <> "null" Then
                TreeView1.Nodes("GliderNode").Nodes.Add(bb.Key, bb.Value)
            End If
        Next

        For Each bb As KeyValuePair(Of String, String) In GliderList
            If bb.Value <> "null" Then
                TreeView1.Nodes("GliderNode").Nodes.Add(bb.Key, bb.Value)
            End If
        Next

        For Each bb As KeyValuePair(Of String, String) In EmoticonList
            If bb.Value <> "null" Then
                TreeView1.Nodes("EmoticonNode").Nodes.Add(bb.Key, bb.Value)
            End If
        Next

        For Each bb As KeyValuePair(Of String, String) In MusicList
            If bb.Value <> "null" Then
                TreeView1.Nodes("MusicNode").Nodes.Add(bb.Key, bb.Value)
            End If
        Next

        For Each bb As KeyValuePair(Of String, String) In SprayList
            If bb.Value <> "null" Then
                TreeView1.Nodes("SprayNode").Nodes.Add(bb.Key, bb.Value)
            End If
        Next

        For Each bb As KeyValuePair(Of String, String) In ToyList
            If bb.Value <> "null" Then
                TreeView1.Nodes("ToyNode").Nodes.Add(bb.Key, bb.Value)
            End If
        Next

#End Region

        TreeView1.Enabled = True
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
                If TreeView1.Nodes.Find(c.Key, True)(0).Checked Then
                    ids &= "AthenaCharacter:" & c.Key & vbCrLf
                End If
            Next

            For Each c In BackBlingList
                If TreeView1.Nodes.Find(c.Key, True)(0).Checked Then
                    ids &= "AthenaBackpack:" & c.Key & vbCrLf
                End If
            Next

            For Each c In PetList
                If TreeView1.Nodes.Find(c.Key, True)(0).Checked Then
                    ids &= "AthenaBackpack:" & c.Key & vbCrLf
                End If
            Next

            For Each c In PickaxeList
                If TreeView1.Nodes.Find(c.Key, True)(0).Checked Then
                    ids &= "AthenaPickaxe:" & c.Key & vbCrLf
                End If
            Next

            For Each c In EmoteList
                If TreeView1.Nodes.Find(c.Key, True)(0).Checked Then
                    ids &= "AthenaDance:" & c.Key & vbCrLf
                End If
            Next

            For Each c In BuiltInEmoteList
                If TreeView1.Nodes.Find(c.Key, True)(0).Checked Then
                    ids &= "AthenaDance:" & c.Key & vbCrLf
                End If
            Next

            For Each c In EmoticonList
                If TreeView1.Nodes.Find(c.Key, True)(0).Checked Then
                    ids &= "AthenaDance:" & c.Key & vbCrLf
                End If
            Next

            For Each c In SprayList
                If TreeView1.Nodes.Find(c.Key, True)(0).Checked Then
                    ids &= "AthenaDance:" & c.Key & vbCrLf
                End If
            Next

            For Each c In ToyList
                If TreeView1.Nodes.Find(c.Key, True)(0).Checked Then
                    ids &= "AthenaDance:" & c.Key & vbCrLf
                End If
            Next

            For Each c In LoadingScreenList
                If TreeView1.Nodes.Find(c.Key, True)(0).Checked Then
                    ids &= "AthenaLoadingScreen:" & c.Key & vbCrLf
                End If
            Next

            For Each c In ContrailList
                If TreeView1.Nodes.Find(c.Key, True)(0).Checked Then
                    ids &= "AthenaSkyDiveContrail:" & c.Key & vbCrLf
                End If
            Next

            For Each c In GliderList
                If TreeView1.Nodes.Find(c.Key, True)(0).Checked Then
                    ids &= "AthenaGlider:" & c.Key & vbCrLf
                End If
            Next

            For Each c In MusicList
                If TreeView1.Nodes.Find(c.Key, True)(0).Checked Then
                    ids &= "AthenaMusicPack:" & c.Key & vbCrLf
                End If
            Next

            For Each c In WrapList
                If TreeView1.Nodes.Find(c.Key, True)(0).Checked Then
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


    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Dim countselected = areCosmeticsSelected()

        If TreeView1.Nodes.Count >= 10 And countselected > 0 Then
            GenerateIDSConfig()
            If MsgBox("Exported " & countselected & " Consmetics to ids.config " & vbCrLf & "Do you want to open the folder,where the file is saved?", MsgBoxStyle.YesNo, "ids.config Created") = MsgBoxResult.Yes Then
                Process.Start("explorer", """" & Environment.CurrentDirectory & """")
            End If
        Else
            MessageBox.Show("Load some cosmetics first dumbo", "I told you its for 200 IQ's")
            End If
    End Sub

    Private Sub CosmeticsForm_Enter(sender As Object, e As EventArgs) Handles Me.Enter
        TreeView1.Enabled = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        TabControl1.SelectedTab = TabControl1.TabPages(0)
    End Sub

    Public Function areCosmeticsSelected() As Integer
        Dim cnt As Integer = 0
        For Each n As TreeNode In TreeView1.Nodes
            For Each nc As TreeNode In n.Nodes
                If nc.Checked = True Then
                    cnt += 1
                End If
            Next
        Next
        Return cnt
    End Function

    Private Sub TreeView1_AfterCheck(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterCheck
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