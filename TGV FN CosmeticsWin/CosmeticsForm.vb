Imports System.Net
Imports Newtonsoft.Json
Imports TGVFNCosmeticsCore
Imports System.IO
Public Class CosmeticsForm

    Dim OfficersFort As New OfficersFortniteAPI
    Dim allCosmetics As List(Of Fortnite_API.Objects.V2.BrCosmeticV2) = OfficersFort.GetAllCosmetics()
    Dim newCosmetics As Fortnite_API.Objects.V2.BrNewCosmeticsV2 = OfficersFort.GetNewCosmetics()
    Dim stopwatch As New Stopwatch

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        sender.Enabled = False
        Dim file As New StreamWriter("DisplayType.txt")
        Dim DisplayTypeList As New ArrayList

        For Each c As Fortnite_API.Objects.V2.BrCosmeticV2 In allCosmetics

            If c.Type.DisplayValue = "Back Bling" Then
                TreeView1.Nodes("BackBlingNode").Nodes.Add(c.Id, c.Name)
            End If

            If c.Type.DisplayValue = "Outfit" Then
                TreeView1.Nodes("OutfitNode").Nodes.Add(c.Id, c.Name)
            End If

            If c.Type.DisplayValue = "Banner" Then
                TreeView1.Nodes("BannerNode").Nodes.Add(c.Id, c.Name)
            End If

            If c.Type.DisplayValue = "Pet" Or c.Type.DisplayValue = "PET" Then
                TreeView1.Nodes("PetNode").Nodes.Add(c.Id, c.Name)
            End If

            If Not DisplayTypeList.Contains(c.Type.DisplayValue) Then
                DisplayTypeList.Add(c.Type.DisplayValue)
            End If
        Next

        For Each s As String In DisplayTypeList
            file.WriteLine(s)
        Next

        file.Close()
        sender.Enabled = True

    End Sub

    Private Sub TreeView1_DoubleClick(sender As Object, e As EventArgs) Handles TreeView1.DoubleClick

        If TreeView1.SelectedNode.Nodes.Count = 0 Then
            Dim selectedNode = TreeView1.SelectedNode
            Dim selectedCosmetic = allCosmetics.Find(Function(value As Fortnite_API.Objects.V2.BrCosmeticV2)
                                                         Return value.Name = selectedNode.Text
                                                     End Function)


            PictureBox1.Load(selectedCosmetic.Images.Icon.AbsoluteUri)

        End If

    End Sub

    Private Sub CosmeticsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect

    End Sub
End Class