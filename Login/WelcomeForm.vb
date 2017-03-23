Public Class WelcomeForm
    Private Sub WelcomeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblWelcome.Left = (lblWelcome.Parent.Width \ 2) - (lblWelcome.Width \ 2)
        btnLogout.Left = (btnLogout.Parent.Width \ 4) - (btnLogout.Width \ 4)
        btnReview.Left = (btnReview.Parent.Width \ 4) - (btnReview.Width \ 4)
    End Sub
End Class