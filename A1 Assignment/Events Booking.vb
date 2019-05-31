Imports System.Data.OleDb
Imports System.IO
Imports System

Public Class EventsBooking
    Dim incEvents As Integer
    Dim incContacts As Integer
    Dim MaxRowsContacts As Integer
    Dim MaxRowsEvents As Integer
    Dim con As New OleDb.OleDbConnection                                'this makes the connection to the database in access
    Dim dbProvider As String                                            'Holds the provider
    Dim dbSource As String                                              'Holds the data source
    Dim ds As New DataSet                                               'Holds a dataSet object    
    Dim da As OleDb.OleDbDataAdapter                                    'Holds a dataAdapter object 
    Dim da2 As OleDb.OleDbDataAdapter                                   'Holds a dataAdapter object 
    Dim SQL As String                                                   'holds a SQL string
    Dim SQL1 As String                                                  'holds a SQL string
    Dim cb As New OleDb.OleDbCommandBuilder(da)


    Private Sub EventsBooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbProvider = "PROVIDER=Microsoft.ACE.OLEDB.12.0;"               'Set up the provider
        dbSource = "Data Source = .\BathChildrenLit2018.accdb"          'location of the database used on this program

        con.ConnectionString = dbProvider & dbSource                    'Sets the connection String

        con.Open()                                                      'opens the database

        'Contacts table
        SQL1 = "SELECT * FROM tblContacts"                              'Stores the SQL string for tblContacts
        da = New OleDb.OleDbDataAdapter(SQL1, con)                      'holds reference to the data adapter
        da.FillLoadOption = LoadOption.OverwriteChanges                 'Fill the dataset with records from the database table

        Dim builderContacts As OleDbCommandBuilder = New OleDb.OleDbCommandBuilder(da)


        'Events Table
        SQL = "SELECT * FROM tblEvents"                                 'Stores the SQL string for tblEvents
        da2 = New OleDb.OleDbDataAdapter(SQL, con)                      'holds reference to the data adapter
        da2.FillLoadOption = LoadOption.OverwriteChanges                'Fill the dataset with records from the database table

        Dim builderEvents As OleDbCommandBuilder = New OleDb.OleDbCommandBuilder(da2)

        refreshDataTable()

        con.Close()                                                     'Closes the database

        If incEvents <> MaxRowsEvents - 1 Then
            incEvents = incEvents + 1
            NavigateRecordsEvents()
        End If

        If incContacts <> MaxRowsContacts - 1 Then
            incContacts = incContacts + 1
            NavigateRecordsContacts()
        End If

        TxtBoxTicketsSold.Clear()
        txtBoxTicketsLeft.Clear()
        txtBoxNotes.Clear()

    End Sub



    Private Sub refreshDataTable()                                      'live update the database

        da.Fill(ds, "AddressBook")
        da2.Fill(ds, "Events")

        da.Update(ds, "AddressBook")
        da2.Update(ds, "Events")

        MaxRowsContacts = ds.Tables("AddressBook").Rows.Count           'get how many rows are in the database table
        MaxRowsEvents = ds.Tables("Events").Rows.Count
        incEvents = -1                                                  'this set the inc variable to minus one when the form loads
        incContacts = -1

    End Sub

    Private Sub NavigateRecordsEvents()

        'Events Table
        TxtBoxEventTitle.Text = ds.Tables("Events").Rows(incEvents).Item(1)
        TxtBoxEventLocation.Text = ds.Tables("Events").Rows(incEvents).Item(2)
        TxtBoxEventDate.Text = ds.Tables("Events").Rows(incEvents).Item(3)
        TxtBoxEventTime.Text = ds.Tables("Events").Rows(incEvents).Item(4)
        TxtBoxEventDuration.Text = ds.Tables("Events").Rows(incEvents).Item(5)
        TxtBoxAvailableTickets.Text = ds.Tables("Events").Rows(incEvents).Item(8)

    End Sub

    Private Sub NavigateRecordsContacts()

        'Contacts table
        txtBoxFirstName.Text = ds.Tables("AddressBook").Rows(incContacts).Item(2)
        txtBoxSurname.Text = ds.Tables("AddressBook").Rows(incContacts).Item(3)
        txtBoxAddress1.Text = ds.Tables("AddressBook").Rows(incContacts).Item(4)
        txtBoxAddress2.Text = ds.Tables("AddressBook").Rows(incContacts).Item(5)
        txtBoxAddress3.Text = ds.Tables("AddressBook").Rows(incContacts).Item(6)
        txtBoxPostCode.Text = ds.Tables("AddressBook").Rows(incContacts).Item(7)
        txtBoxPhone.Text = ds.Tables("AddressBook").Rows(incContacts).Item(8)
        txtBoxEmail.Text = ds.Tables("AddressBook").Rows(incContacts).Item(9)

    End Sub

    Private Sub TxtBoxTime_TextChanged(sender As Object, e As EventArgs)

        TxtBoxTime.Text = Format(Now, "yyyy-MM-dd hh:mm:ss")

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        CaptureScreen()
        PrintDialog1.Document = PrintBooking
        PrintDialog1.PrinterSettings = PrintBooking.PrinterSettings
        PrintDialog1.AllowSomePages = True
        If PrintDialog1.ShowDialog = DialogResult.OK Then
            PrintBooking.PrinterSettings = PrintDialog1.PrinterSettings
            PrintBooking.Print()
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        If incEvents <> MaxRowsEvents - 1 Then
            incEvents = incEvents + 1
            NavigateRecordsEvents()
        Else
            MsgBox("No More Events")
        End If

    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click

        If incEvents > 0 Then
            incEvents = incEvents - 1
            NavigateRecordsEvents()
        ElseIf incEvents = -1 Then
            MessageBox.Show("No Records Yet")
        ElseIf incEvents = 0 Then
            MessageBox.Show("First Record")
        End If

    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click

        If incEvents <> MaxRowsEvents - 1 Then
            incEvents = MaxRowsEvents - 1
            NavigateRecordsEvents()
        End If

    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click

        If incEvents <> 0 Then
            incEvents = 0
            NavigateRecordsEvents()

        End If

    End Sub

    Private Sub btnContactNext_Click(sender As Object, e As EventArgs) Handles btnContactNext.Click

        If incContacts <> MaxRowsContacts - 1 Then
            incContacts = incContacts + 1
            NavigateRecordsContacts()
        Else
            MsgBox("No More Records")
        End If

    End Sub

    Private Sub btnContactsPrevious_Click(sender As Object, e As EventArgs) Handles btnContactsPrevious.Click

        If incContacts > 0 Then
            incContacts = incContacts - 1
            NavigateRecordsContacts()
        ElseIf incContacts = -1 Then
            MessageBox.Show("No Records Yet")
        ElseIf incContacts = 0 Then
            MessageBox.Show("First Record")
        End If

    End Sub

    Private Sub btnContactsLast_Click(sender As Object, e As EventArgs) Handles btnContactsLast.Click

        If incContacts <> MaxRowsContacts - 1 Then
            incContacts = MaxRowsContacts - 1
            NavigateRecordsContacts()
        End If

    End Sub

    Private Sub btnContactsFirst_Click(sender As Object, e As EventArgs) Handles btnContactsFirst.Click

        If incContacts <> 0 Then
            incContacts = 0
            NavigateRecordsContacts()

        End If

    End Sub

    Private Sub TxtBoxAvailableTickets_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBoxAvailableTickets.TextChanged, TxtBoxTicketsSold.TextChanged

        If String.IsNullOrEmpty(TxtBoxAvailableTickets.Text) OrElse String.IsNullOrEmpty(TxtBoxTicketsSold.Text) Then Exit Sub

        If Not IsNumeric(TxtBoxAvailableTickets.Text) OrElse Not IsNumeric(TxtBoxTicketsSold.Text) Then Exit Sub

        txtBoxTicketsLeft.Text = CDbl(TxtBoxAvailableTickets.Text) - CDbl(TxtBoxTicketsSold.Text)

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click           'saves information to AuditFiles.txt, it also creates the file if not already there.

        Dim closeWindow As Boolean
        Dim cb As New OleDb.OleDbCommandBuilder(da)
        Dim FILE_NAME As String = ".\AuditFiles.txt"
        Dim buyNumber As Integer
        Dim isValid As Boolean = Int32.TryParse(TxtBoxTicketsSold.Text, buyNumber)

        If isValid And buyNumber > 0 Then
            If IO.File.Exists(FILE_NAME) = False Then                                           'checks for the path ".\AuditFiles.txt" if path not there then it creates it

                ds.Tables("Events").Rows(incEvents).Item(7) = TxtBoxTicketsSold.Text            'Updates the database with how many tickets were sold
                ds.Tables("Events").Rows(incEvents).Item(8) = txtBoxTicketsLeft.Text            'updates the database with available tickets ammount

                If ds.HasChanges Then
                    da2.Update(ds, "Events")                                                    'makes the changes to the actual database

                    File.Create(".\AuditFiles.txt").Dispose()                                   'Creates ".\AuditFiles.txt"

                    Using sw As System.IO.StreamWriter = File.AppendText(FILE_NAME)                       'writes form information to ".\AuditFiles.txt"

                        'array for the information to be displayed on the AuditFiles
                        sw.WriteLine(String.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17}", TxtBoxTime.Text, txtBoxFirstName.Text, txtBoxSurname.Text, txtBoxAddress1.Text, txtBoxAddress2.Text, txtBoxAddress3.Text, txtBoxPostCode.Text, txtBoxPhone.Text, txtBoxEmail.Text, TxtBoxEventTitle.Text, TxtBoxAvailableTickets.Text, TxtBoxEventLocation.Text, TxtBoxEventDate.Text, TxtBoxEventTime.Text, TxtBoxEventDuration.Text, TxtBoxTicketsSold.Text, txtBoxTicketsLeft.Text, txtBoxNotes.Text, Environment.NewLine))
                        sw.WriteLine("")
                    End Using

                    MsgBox("Text written to file and tickets updated")                          'lets you know that the operation was successfull

                    closeWindow = True
                End If

            ElseIf System.IO.File.Exists(FILE_NAME) = True Then                                 'checks for the path ".\AuditFiles.txt" if path is there then it updates the file in the path

                ds.Tables("Events").Rows(incEvents).Item(7) = TxtBoxTicketsSold.Text            'Updates the database with how many tickets were sold
                ds.Tables("Events").Rows(incEvents).Item(8) = txtBoxTicketsLeft.Text            'updates the database with available tickets ammount

                If ds.HasChanges Then
                    da2.Update(ds, "Events")                                                    'makes the changes to the actual database

                    File.Create(".\AuditFiles.txt").Dispose()                                   'Creates ".\AuditFiles.txt"

                    Using sw As System.IO.StreamWriter = File.AppendText(FILE_NAME)                      'writes form information to ".\AuditFiles.txt"

                        'array for the information to be displayed on the AuditFiles
                        sw.WriteLine(String.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17}", TxtBoxTime.Text, txtBoxFirstName.Text, txtBoxSurname.Text, txtBoxAddress1.Text, txtBoxAddress2.Text, txtBoxAddress3.Text, txtBoxPostCode.Text, txtBoxPhone.Text, txtBoxEmail.Text, TxtBoxEventTitle.Text, TxtBoxAvailableTickets.Text, TxtBoxEventLocation.Text, TxtBoxEventDate.Text, TxtBoxEventTime.Text, TxtBoxEventDuration.Text, TxtBoxTicketsSold.Text, txtBoxTicketsLeft.Text, txtBoxNotes.Text, Environment.NewLine))
                        sw.WriteLine("")

                    End Using

                    MsgBox("Text written to file and tickets updated")                          'lets you know that the operation was successfull

                    closeWindow = True

                    ' .clear()
                End If


            End If
        Else
            MsgBox("Adjust the number of tickets required")

        End If

        If closeWindow Then
            Me.Close()
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        TxtBoxTime.Text = Now                                                            'Shows the time

    End Sub

    Private Sub PrintBooking_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintBooking.PrintPage

        e.Graphics.DrawImage(memoryImage, 0, 0)

    End Sub

    Dim memoryImage As Bitmap

    Private Sub CaptureScreen()
        Dim myGraphics As Graphics = Me.CreateGraphics()
        Dim s As Size = Me.Size
        memoryImage = New Bitmap(s.Width, s.Height, myGraphics)
        Dim memoryGraphics As Graphics = Graphics.FromImage(memoryImage)
        memoryGraphics.CopyFromScreen(Me.Location.X, Me.Location.Y, 0, 0, s)
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        BookingsHelp.Show()

    End Sub

End Class