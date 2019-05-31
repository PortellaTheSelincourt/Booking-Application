Public Class MainMenu

    Private Sub Contacts_Click(sender As Object, e As EventArgs) Handles btnContacts.Click

        Contacts.ShowDialog(Me)     'Opens up Contacts form

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()                  'Closes the application
        End
    End Sub

    Private Sub BtnSwitchUser_Click(sender As Object, e As EventArgs) Handles btnSwitchUser.Click

        Login.Show()                'opens login form
        Me.Close()                  'closes main menu form

    End Sub

    Private Sub BtnEvents_Click(sender As Object, e As EventArgs) Handles btnEvents.Click

        EventsForm.ShowDialog(Me)   'Opens up Events form

    End Sub

    Private Sub EventBooking_Click(sender As Object, e As EventArgs) Handles EventBooking.Click

        EventsBooking.ShowDialog(Me)    ''Opens up Events Booking form

    End Sub

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        MainHelp.Show()             'Opens up main help form
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnUserManual.Click

        Dim FILE_NAME As String = ".\usermanual.docx"

        If System.IO.File.Exists(FILE_NAME) = True Then
            Process.Start(FILE_NAME)
        Else
            MsgBox("File Does Not Exist")
        End If
    End Sub
End Class


