Public Class Settings
    Private Sub BtnProxySettings_Click(sender As Object, e As EventArgs) Handles BtnProxySettings.Click
        Dim f1 As New ProxySettings()
        f1.ShowDialog()
    End Sub

    Private Sub BtnOption_Click(sender As Object, e As EventArgs) Handles BtnOption.Click
        Dim f2 As New FOption()
        f2.ShowDialog()
    End Sub

    Private Sub BtnSpeedTest_Click(sender As Object, e As EventArgs) Handles BtnSpeedTest.Click
        Dim f3 As New SpeedTest()
        f3.ShowDialog()
    End Sub

    Private Sub BtnPinger_Click(sender As Object, e As EventArgs) Handles BtnPinger.Click
        Dim f4 As New Pinger()
        f4.ShowDialog()
    End Sub

    Private Sub BtnTAPDriver_Click(sender As Object, e As EventArgs) Handles BtnTAPDriver.Click
        Dim f5 As New TapDriver()
        f5.ShowDialog()
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim f6 As New Update()
        f6.ShowDialog()
    End Sub
End Class
