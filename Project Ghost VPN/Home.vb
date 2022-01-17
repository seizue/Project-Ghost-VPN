Imports System.Windows.Forms
Imports System.IO
Imports System.Drawing
Imports System.Collections.Generic
Imports System.Text

Public Class Home
    Public SelectServer As String
    Public IPServer As String
    Public tnew As Integer
    Dim ipConfig(10) As String
    Dim Folder As IO.FileInfo
    Dim nOsname As String
    Dim proto As String
    Dim serverf As String
    Dim servers As String
    Dim nOs As Integer
    Dim pingurl As String
    Dim c As Integer = 0
    Private ConfigPathname As String = Application.StartupPath & "\data\settings.dat"
    Private configport As String = Application.StartupPath & "\data\port.dat"

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnConnect_Click(sender As Object, e As EventArgs) Handles BtnConnect.Click

    End Sub
End Class


