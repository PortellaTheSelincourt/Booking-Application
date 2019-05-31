Public Class Contacts

    Dim inc As Integer                      'Declares inc
    Dim MaxRows As Integer                  'Declares MaxRows
    Dim con As New OleDb.OleDbConnection    'this makes the connection to the database in access
    Dim dbProvider As String                'Holds the provider
    Dim dbSource As String                  'Holds the data source
    Dim ds As New DataSet                   'Holds the data object
    Dim da As OleDb.OleDbDataAdapter        'Holds the dataAdapter object
    Dim SQL As String                       'Holds a SQL string




    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dbProvider = "PROVIDER=Microsoft.ACE.OLEDB.12.0;"       'Set up the provider
        dbSource = "Data Source = .\BathChildrenLit2018.accdb"  'location of the database used on this program

        con.ConnectionString = dbProvider & dbSource            'Set the data source

        con.Open()                                              'open the database


        SQL = "SELECT * FROM tblContacts"                       'Store the SQL string
        da = New OleDb.OleDbDataAdapter(SQL, con)               'holds reference to the data adapter
        da.FillLoadOption = LoadOption.OverwriteChanges         'makes the changes to the database

        refreshDataTable()                                      'refresh the database

        con.Close()                                             'closes the database

        btnSaveRecord.Enabled = False                           'turns save records button off
        btnAddNew.Enabled = True                                'turns add new button on
        btnUpdate.Enabled = True                                'turns update button on
        btnDelete.Enabled = True                                'turns delete button on

        inc = 0                                                 'sets inc to zero
        NavigateRecords()                                       'identifies the rows and columns in the database

    End Sub

    Private Sub NavigateRecords()                               'identifies the rows and columns in the database

        txtBoxFirstName.Text = ds.Tables("AddressBook").Rows(inc).Item(2)
        txtBoxSurname.Text = ds.Tables("AddressBook").Rows(inc).Item(3)
        txtBoxAddress1.Text = ds.Tables("AddressBook").Rows(inc).Item(4)
        txtBoxAddress2.Text = ds.Tables("AddressBook").Rows(inc).Item(5)
        txtBoxAddress3.Text = ds.Tables("AddressBook").Rows(inc).Item(6)
        txtBoxPostCode.Text = ds.Tables("AddressBook").Rows(inc).Item(7)
        txtBoxPhone.Text = ds.Tables("AddressBook").Rows(inc).Item(8)
        txtBoxEmail.Text = ds.Tables("AddressBook").Rows(inc).Item(9)
        txtBoxNotes.Text = ds.Tables("AddressBook").Rows(inc).Item(10)

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()                                              'closes exits the current form
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click  '  ">" button which makes records move 1 forward

        If inc <> MaxRows - 1 Then                              'says if inc is less or more then maxrows -1
            inc = inc + 1                                       'increments 1 to inc 
            NavigateRecords()                                   'identifies the rows and columns in the database
        Else
            MsgBox("No More Records")                           'message box letting you know that there are no more records
        End If


    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click   '  "<" Button which makes records move 1 backword

        If inc > 0 Then
            inc = inc - 1
            NavigateRecords()
        ElseIf inc = -1 Then
            MessageBox.Show("No Records Yet")
        ElseIf inc = 0 Then
            MessageBox.Show("First Record")
        End If


    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click   '  ">>" Button which makes records move to the last record on the database

        If inc <> MaxRows - 1 Then
            inc = MaxRows - 1
            NavigateRecords()
        End If

    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click '  "<<" Button which makes records move to the very first record in the database

        If inc <> 0 Then
            inc = 0
            NavigateRecords()

        End If

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click   ' Update Button, update the records in the database

        Dim result As DialogResult = MessageBox.Show("Confirm update?", "Title", MessageBoxButtons.YesNo)
        Dim cb As New OleDb.OleDbCommandBuilder(da)

        If String.IsNullOrEmpty(txtBoxFirstName.Text & txtBoxSurname.Text) Then

            MsgBox("Record has not got updated because it is blank")

        ElseIf (result = DialogResult.Yes) Then

            ds.Tables("AddressBook").Rows(inc).Item(2) = txtBoxFirstName.Text
            ds.Tables("AddressBook").Rows(inc).Item(3) = txtBoxSurname.Text
            ds.Tables("AddressBook").Rows(inc).Item(4) = txtBoxAddress1.Text
            ds.Tables("AddressBook").Rows(inc).Item(5) = txtBoxAddress2.Text
            ds.Tables("AddressBook").Rows(inc).Item(6) = txtBoxAddress3.Text
            ds.Tables("AddressBook").Rows(inc).Item(7) = txtBoxPostCode.Text
            ds.Tables("AddressBook").Rows(inc).Item(8) = txtBoxPhone.Text
            ds.Tables("AddressBook").Rows(inc).Item(9) = txtBoxEmail.Text
            ds.Tables("AddressBook").Rows(inc).Item(10) = txtBoxNotes.Text

            da.Update(ds, "AddressBook")                                                    'makes the changes to the actual database

            MsgBox("Data updated")

            inc = 0
            NavigateRecords()
        End If

    End Sub

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click   'AddNew gets the form ready to have a new record



        btnSaveRecord.Enabled = True
        btnAddNew.Enabled = False
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        btnNext.Enabled = False
        btnPrevious.Enabled = False
        btnLast.Enabled = False
        btnFirst.Enabled = False

        txtBoxFirstName.Clear()
        txtBoxSurname.Clear()
        txtBoxAddress1.Clear()
        txtBoxAddress2.Clear()
        txtBoxAddress3.Clear()
        txtBoxPostCode.Clear()
        txtBoxPhone.Clear()
        txtBoxEmail.Clear()
        txtBoxNotes.Clear()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click   'Cancels any activity that you are doing

        btnSaveRecord.Enabled = False
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

    Private Sub btnSaveRecord_Click(sender As Object, e As EventArgs) Handles btnSaveRecord.Click   'adds a new record to the database

        If String.IsNullOrEmpty(txtBoxFirstName.Text & txtBoxSurname.Text) Then             'stops you from adding blank data

            MsgBox("Record has not got updated because it is missing data")


        ElseIf inc <> -1 Then
            Dim cb As New OleDb.OleDbCommandBuilder(da)
            Dim dsNewRow As DataRow

            dsNewRow = ds.Tables("AddressBook").NewRow()

            dsNewRow.Item("FirstName") = txtBoxFirstName.Text
            dsNewRow.Item("Surname") = txtBoxSurname.Text
            dsNewRow.Item("Address1") = txtBoxAddress1.Text
            dsNewRow.Item("Address2") = txtBoxAddress2.Text
            dsNewRow.Item("Address3") = txtBoxAddress3.Text
            dsNewRow.Item("Postcode") = txtBoxPostCode.Text
            dsNewRow.Item("Phone") = txtBoxPhone.Text
            dsNewRow.Item("Email") = txtBoxEmail.Text
            dsNewRow.Item("Notes") = txtBoxNotes.Text

            ds.Tables("AddressBook").Rows.Add(dsNewRow)

            da.Update(ds, "AddressBook")

            MsgBox("New Record added to the Database")

            btnSaveRecord.Enabled = False
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

    Private Sub refreshDataTable()                      'live update the database

        da.Fill(ds, "AddressBook")

        MaxRows = ds.Tables("AddressBook").Rows.Count   'get how many rows are in the database table

        inc = -1                                        'this set the inc variable to minus one when the form loads

    End Sub



    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click 'Deletes a record from the database

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ContactsHelp.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

        Dim PrintContacts As New System.Drawing.Printing.PrintDocument

        PrintDialog1.Document = PrintContacts
        PrintDialog1.PrinterSettings = PrintContacts.PrinterSettings
        PrintDialog1.AllowSomePages = True
        If PrintDialog1.ShowDialog = DialogResult.OK Then
            PrintContacts.PrinterSettings = PrintDialog1.PrinterSettings
            PrintContacts.Print()
        End If


    End Sub

End Class