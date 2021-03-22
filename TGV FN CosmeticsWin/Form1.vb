Public Class Form1
    Dim cForm As New CosmeticsForm
    Private Sub tls_main_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles tls_main.ItemClicked
        If (e.ClickedItem.Text = "Cosmetics") Then
            cForm.MdiParent = Me
            cForm.Show()
            cForm.Activate()
        End If
    End Sub
End Class