
Public Class Main
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        End
    End Sub

    Private Sub BtnHome_Click(sender As Object, e As EventArgs) Handles BtnHome.Click
        Indicator.Width = BtnHome.Width
        Indicator.Left = BtnHome.Left

        Home1.Visible = False
        Home1.BringToFront()
        Animator1.ShowSync(Home1)
    End Sub

    Private Sub BtnSettings_Click(sender As Object, e As EventArgs) Handles BtnSettings.Click
        Indicator.Width = BtnSettings.Width
        Indicator.Left = BtnSettings.Left

        Settings1.Visible = False
        Settings1.BringToFront()
        Animator1.ShowSync(Settings1)
    End Sub

    Private Sub BtnAbout_Click(sender As Object, e As EventArgs) Handles BtnAbout.Click
        Indicator.Width = BtnAbout.Width
        Indicator.Left = BtnAbout.Left

        About1.Visible = False
        About1.BringToFront()
        Animator1.ShowSync(About1)
    End Sub

    Private Sub BtnAccount_Click(sender As Object, e As EventArgs) Handles BtnAccount.Click
        Dim f1 As New Account()
        f1.ShowDialog()
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
