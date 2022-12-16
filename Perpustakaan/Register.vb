Public Class Register
    Private Sub BtnRegis_Click(sender As Object, e As EventArgs) Handles BtnRegis.Click
        If TxtUser.Text.Length > 0 And TxtPass.Text.Length > 0 And TxtPass.Text = TxtConPass.Text Then
            LoginForm.users.AddUserDatabase(TxtUser.Text, TxtPass.Text)
            Me.Close()
        Else
            MessageBox.Show("Your Pass Doesn't Match")
        End If
        'MessageBox.Show(LoginForm.users.GetData.ToString)

    End Sub
End Class