Public Class EventsForm

    Dim inc As Integer                      'Declares inc
    Dim MaxRows As Integer                  'Declares MaxRows
    Dim con As New OleDb.OleDbConnection    'this makes the connection to the database in access
    Dim dbProvider As String                'Holds the provider
    Dim dbSource As String                  'Holds the data source
    Dim ds As New DataSet                   'Holds a dataSet object 
    Dim da As OleDb.OleDbDataAdapter        'Holds a dataAdapter object 
    Dim SQL As String                       'holds a SQL string

    Private Sub Events_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dbProvider = "PROVIDER=Microsoft.ACE.OLEDB.12.0;"       'Provider technology used here'
        dbSource = "Data Source = .\BathChildrenLit2018.accdb"  'location of the database used on this program

        con.ConnectionString = dbProvider & dbSource            'Sets the connection String


        con.Open()                                              'opens the database


        SQL = "SELECT * FROM tblEvents"                         'Stores the SQL string
        da = New OleDb.OleDbDataAdapter(SQL, con)               'holds reference to the data adapter
        da.FillLoadOption = LoadOption.OverwriteChanges         'Fill the dataset with records from the database table


        refreshDataTable()

        con.Close()

        btnSave.Enabled = False
        btnAddNew.Enabled = True
        btnUpdate.Enabled = True
        btnDelete.Enabled = True

        inc = 0
        NavigateRecords()

    End Sub

    Private Sub refreshDataTable()                      'live update the database

        da.Fill(ds, "AddressBook")

        MaxRows = ds.Tables("AddressBook").Rows.Count   'get how many rows are in the database table

        inc = -1                                        'this set the inc variable to minus one when the form loads

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim PrintEvents As New System.Drawing.Printing.PrintDocument

        PrintDialog1.Document = PrintEvents
        PrintDialog1.PrinterSettings = PrintEvents.PrinterSettings
        PrintDialog1.AllowSomePages = True
        If PrintDialog1.ShowDialog = DialogResult.OK Then
            PrintEvents.PrinterSettings = PrintDialog1.PrinterSettings
            PrintEvents.Print()
        End If
    End Sub

    Private Sub NavigateRecords()

        TxtBoxEventTitle.Text = ds.Tables("AddressBook").Rows(inc).Item(1)
        TxtBoxEventLocation.Text = ds.Tables("AddressBook").Rows(inc).Item(2)
        TxtBoxEventDate.Text = ds.Tables("AddressBook").Rows(inc).Item(3)
        TxtBoxEventTime.Text = ds.Tables("AddressBook").Rows(inc).Item(4)
        TxtBoxEventDuration.Text = ds.Tables("AddressBook").Rows(inc).Item(5)
        TxtBoxTotalTickets.Text = ds.Tables("AddressBook").Rows(inc).Item(6)
        TxtBoxSoldTickets.Text = ds.Tables("AddressBook").Rows(inc).Item(7)
        TxtBoxAvailableTickets.Text = ds.Tables("AddressBook").Rows(inc).Item(8)

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        If inc <> MaxRows - 1 Then
            inc = inc + 1
            NavigateRecords()
        Else
            MsgBox("No More Events")
        End If

    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click

        If inc > 0 Then
            inc = inc - 1
            NavigateRecords()
        ElseIf inc = -1 Then
            MessageBox.Show("No Records Yet")
        ElseIf inc = 0 Then
            MessageBox.Show("First Record")
        End If

    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click

        If inc <> MaxRows - 1 Then
            inc = MaxRows - 1
            NavigateRecords()
        End If

    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click

        If inc <> 0 Then
            inc = 0
            NavigateRecords()

        End If

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Dim result As DialogResult = MessageBox.Show("Confirm update?", "Title", MessageBoxButtons.YesNo)

        If String.IsNullOrEmpty(TxtBoxEventTitle.Text & TxtBoxEventLocation.Text) Then

            MsgBox("Record has not got updated because it is blank")

        ElseIf (result = DialogResult.Yes) Then
            Dim cb As New OleDb.OleDbCommandBuilder(da)                                         'Command builder which updates the database it self

            'collects the information from each txtboxnamed below
            ds.Tables("AddressBook").Rows(inc).Item(1) = TxtBoxEventTitle.Text
            ds.Tables("AddressBook").Rows(inc).Item(2) = TxtBoxEventLocation.Text
            ds.Tables("AddressBook").Rows(inc).Item(3) = TxtBoxEventDate.Text
            ds.Tables("AddressBook").Rows(inc).Item(4) = TxtBoxEventTime.Text
            ds.Tables("AddressBook").Rows(inc).Item(5) = TxtBoxEventDuration.Text
            ds.Tables("AddressBook").Rows(inc).Item(6) = TxtBoxTotalTickets.Text
            ds.Tables("AddressBook").Rows(inc).Item(7) = TxtBoxSoldTickets.Text
            ds.Tables("AddressBook").Rows(inc).Item(8) = TxtBoxAvailableTickets.Text

            da.Update(ds, "AddressBook")                                                        'makes the changes to the actual database

            refreshDataTable()
            inc = 0
            NavigateRecords()
            MsgBox("Data updated")

        End If

    End Sub

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click

        btnSave.Enabled = True
        btnAddNew.Enabled = False
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        btnNext.Enabled = False
        btnPrevious.Enabled = False
        btnLast.Enabled = False
        btnFirst.Enabled = False

        TxtBoxEventTitle.Clear()
        TxtBoxEventLocation.Clear()
        TxtBoxEventDuration.Clear()
        TxtBoxTotalTickets.Clear()
        TxtBoxSoldTickets.Clear()
        TxtBoxAvailableTickets.Clear()


    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        btnSave.Enabled = False
        btnAddNew.Enabled = True
        btnUpdate.Enabled = True
        btnDelete.Enabled = True
        btnNext.Enabled = True
        btnPrevious.Enabled = True
        btnLast.Enabled = True
        btnFirst.Enabled = True

        inc = 0
        NavigateRecords()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If String.IsNullOrEmpty(TxtBoxEventTitle.Text & TxtBoxEventLocation.Text) Then          'stops you from adding blank data

            MsgBox("Record has not got updated because it is missing data")


        ElseIf inc <> -1 Then

            Dim cb As New OleDb.OleDbCommandBuilder(da)
            Dim dsNewRow As DataRow

            dsNewRow = ds.Tables("AddressBook").NewRow()

            dsNewRow.Item("EventTitle") = TxtBoxEventTitle.Text
            dsNewRow.Item("EventLocation") = TxtBoxEventLocation.Text
            dsNewRow.Item("EventDate") = TxtBoxEventDate.Text
            dsNewRow.Item("EventTime") = TxtBoxEventTime.Text
            dsNewRow.Item("EventDuration") = TxtBoxEventDuration.Text
            dsNewRow.Item("TotalTickets") = TxtBoxTotalTickets.Text
            dsNewRow.Item("SoldTickets") = TxtBoxSoldTickets.Text
            dsNewRow.Item("AvailableTickets") = TxtBoxAvailableTickets.Text

            ds.Tables("AddressBook").Rows.Add(dsNewRow)

            da.Update(ds, "AddressBook")

            MsgBox("New Record added to the Database")

            btnSave.Enabled = False
            btnAddNew.Enabled = True
            btnUpdate.Enabled = True
            btnDelete.Enabled = True
            btnNext.Enabled = True
            btnPrevious.Enabled = True
            btnLast.Enabled = True
            btnFirst.Enabled = True

            refreshDataTable()

            MsgBox("Database has updated!")
            inc = 0
            NavigateRecords()
        End If

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Dim result As DialogResult = MessageBox.Show("Confirm update?", "Title", MessageBoxButtons.YesNo)

        If (result = DialogResult.Yes) Then

            Dim cb As New OleDb.OleDbCommandBuilder(da)

            ds.Tables("AddressBook").Rows(inc).Delete()

            da.Update(ds, "AddressBook")

            MaxRows = MaxRows - 1

            inc = 0
            NavigateRecords()


        Else

        End If

    End Sub

    Private Sub TxtBoxEventTime_ValueChanged(sender As Object, e As EventArgs) Handles TxtBoxEventTime.ValueChanged

    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        EventsHelp.Show()
    End Sub

    Private Sub TxtBoxTotalTickets_TextChanged(sender As Object, e As EventArgs) Handles TxtBoxTotalTickets.TextChanged

    End Sub
End Class