Public Class Login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If UsernameBox.Text = "username" And PasswordBox.Text = "12345" Then                'This is the username and password to login into the application
            MainMenu.Show()                                                                 'opens the main Menu form
            Me.DialogResult = DialogResult.OK
            Me.Close()                                                                      'Closes the login form
        Else
            MsgBox("Username or password incorrect", MsgBoxStyle.OkOnly, "Invalid")         'sends a message if username and password is wrong

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ToolTip.Click

        LoginHelp.Show()                                                                     'Opens up a login help form
    End Sub
End Class
