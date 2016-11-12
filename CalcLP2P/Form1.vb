Public Class Startup

    Private Sub MenuItem_About_Click(sender As Object, e As EventArgs) Handles MenuItem_About.Click
        My.Forms.About.ShowDialog()
        If My.Application.IsNetworkDeployed Then
            My.Application.Deployment.Update()
        End If
    End Sub

End Class
