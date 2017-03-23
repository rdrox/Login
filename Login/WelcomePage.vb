Public Class WelcomePage
    Private Sub WelcomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblWelcome.Left = (lblWelcome.Parent.Width \ 2) - (lblWelcome.Width \ 2)
        'btnLogout.Left = (btnLogout.Parent.Width \ 2) - (btnLogout.Width \ 2)
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Hide()
    End Sub
End Class