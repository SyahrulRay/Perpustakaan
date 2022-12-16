Imports System.Configuration
Imports Microsoft.VisualBasic.ApplicationServices

Public Class LoginForm

    Public Shared users As Users
    Public Shared daftarKoleksi As DaftarKoleksi

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        daftarKoleksi = New DaftarKoleksi
        users = New Users
    End Sub
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim plainUser As String = TxtUser.Text
        Dim plainPass As String = TxtPass.Text


        Dim dataUser As List(Of String) = users.CheckAuth(plainUser, plainPass)

        If dataUser.Count > 0 Then
            users.GSUsername = dataUser(1)
            daftarKoleksi.Show()
            Me.Hide()
        Else
            MessageBox.Show("Wrong Username or Password")
        End If


    End Sub

    Private Sub BtnDaftar_Click(sender As Object, e As EventArgs) Handles BtnDaftar.Click
        Register.Show()

    End Sub
End Class