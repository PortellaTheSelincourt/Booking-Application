<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EventsForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EventsForm))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtBoxEventTitle = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtBoxEventLocation = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtBoxEventDuration = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtBoxSoldTickets = New System.Windows.Forms.TextBox()
        Me.TxtBoxAvailableTickets = New System.Windows.Forms.TextBox()
        Me.TxtBoxTotalTickets = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintEvents = New System.Drawing.Printing.PrintDocument()
        Me.TxtBoxEventDate = New System.Windows.Forms.DateTimePicker()
        Me.TxtBoxEventTime = New System.Windows.Forms.DateTimePicker()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.A1_Assignment.My.Resources.Resources.events
        Me.PictureBox1.Location = New System.Drawing.Point(175, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(327, 108)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(188, 151)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Event Title:"
        '
        'TxtBoxEventTitle
        '
        Me.TxtBoxEventTitle.Location = New System.Drawing.Point(255, 147)
        Me.TxtBoxEventTitle.Name = "TxtBoxEventTitle"
        Me.TxtBoxEventTitle.Size = New System.Drawing.Size(210, 20)
        Me.TxtBoxEventTitle.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(167, 181)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Event Location:"
        '
        'TxtBoxEventLocation
        '
        Me.TxtBoxEventLocation.Location = New System.Drawing.Point(255, 177)
        Me.TxtBoxEventLocation.Name = "TxtBoxEventLocation"
        Me.TxtBoxEventLocation.Size = New System.Drawing.Size(210, 20)
        Me.TxtBoxEventLocation.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(182, 209)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Event Date::"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(185, 235)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Event Time:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(168, 261)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Event Duration:"
        '
        'TxtBoxEventDuration
        '
        Me.TxtBoxEventDuration.Location = New System.Drawing.Point(255, 257)
        Me.TxtBoxEventDuration.Name = "TxtBoxEventDuration"
        Me.TxtBoxEventDuration.Size = New System.Drawing.Size(210, 20)
        Me.TxtBoxEventDuration.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(509, 181)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Total Tickets:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(512, 238)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Sold Tickets:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(490, 209)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Available Tickets:"
        '
        'TxtBoxSoldTickets
        '
        Me.TxtBoxSoldTickets.Location = New System.Drawing.Point(587, 234)
        Me.TxtBoxSoldTickets.Name = "TxtBoxSoldTickets"
        Me.TxtBoxSoldTickets.Size = New System.Drawing.Size(38, 20)
        Me.TxtBoxSoldTickets.TabIndex = 14
        '
        'TxtBoxAvailableTickets
        '
        Me.TxtBoxAvailableTickets.Location = New System.Drawing.Point(587, 205)
        Me.TxtBoxAvailableTickets.Name = "TxtBoxAvailableTickets"
        Me.TxtBoxAvailableTickets.Size = New System.Drawing.Size(38, 20)
        Me.TxtBoxAvailableTickets.TabIndex = 15
        '
        'TxtBoxTotalTickets
        '
        Me.TxtBoxTotalTickets.Location = New System.Drawing.Point(587, 177)
        Me.TxtBoxTotalTickets.Name = "TxtBoxTotalTickets"
        Me.TxtBoxTotalTickets.Size = New System.Drawing.Size(38, 20)
        Me.TxtBoxTotalTickets.TabIndex = 16
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Orange
        Me.btnExit.Location = New System.Drawing.Point(515, 378)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(98, 23)
        Me.btnExit.TabIndex = 68
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(401, 378)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(105, 23)
        Me.btnLast.TabIndex = 67
        Me.btnLast.Text = ">>"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(283, 378)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(105, 23)
        Me.btnNext.TabIndex = 66
        Me.btnNext.Text = ">"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(165, 378)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(98, 23)
        Me.btnPrevious.TabIndex = 65
        Me.btnPrevious.Text = "<"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(47, 378)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(105, 23)
        Me.btnFirst.TabIndex = 64
        Me.btnFirst.Text = "<<"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(401, 333)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(105, 23)
        Me.btnDelete.TabIndex = 63
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(283, 333)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(105, 23)
        Me.btnSave.TabIndex = 62
        Me.btnSave.Text = "Save Record"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(47, 333)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(105, 23)
        Me.btnUpdate.TabIndex = 61
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnAddNew
        '
        Me.btnAddNew.Location = New System.Drawing.Point(165, 333)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(98, 23)
        Me.btnAddNew.TabIndex = 60
        Me.btnAddNew.Text = "Add New"
        Me.btnAddNew.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(515, 333)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(98, 23)
        Me.btnCancel.TabIndex = 59
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnHelp
        '
        Me.btnHelp.Location = New System.Drawing.Point(642, 12)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(40, 38)
        Me.btnHelp.TabIndex = 72
        Me.btnHelp.Text = "?"
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'TxtBoxEventDate
        '
        Me.TxtBoxEventDate.Location = New System.Drawing.Point(255, 203)
        Me.TxtBoxEventDate.Name = "TxtBoxEventDate"
        Me.TxtBoxEventDate.Size = New System.Drawing.Size(210, 20)
        Me.TxtBoxEventDate.TabIndex = 73
        Me.TxtBoxEventDate.Value = New Date(2018, 1, 1, 0, 0, 0, 0)
        '
        'TxtBoxEventTime
        '
        Me.TxtBoxEventTime.CustomFormat = "hh:mm:ss"
        Me.TxtBoxEventTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.TxtBoxEventTime.Location = New System.Drawing.Point(255, 229)
        Me.TxtBoxEventTime.Name = "TxtBoxEventTime"
        Me.TxtBoxEventTime.ShowUpDown = True
        Me.TxtBoxEventTime.Size = New System.Drawing.Size(210, 20)
        Me.TxtBoxEventTime.TabIndex = 74
        Me.TxtBoxEventTime.Value = New Date(2018, 1, 1, 21, 56, 0, 0)
        '
        'EventsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 442)
        Me.Controls.Add(Me.TxtBoxEventTime)
        Me.Controls.Add(Me.TxtBoxEventDate)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnFirst)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAddNew)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.TxtBoxTotalTickets)
        Me.Controls.Add(Me.TxtBoxAvailableTickets)
        Me.Controls.Add(Me.TxtBoxSoldTickets)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtBoxEventDuration)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtBoxEventLocation)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtBoxEventTitle)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EventsForm"
        Me.Text = "Events"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtBoxEventTitle As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtBoxEventLocation As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtBoxEventDuration As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtBoxSoldTickets As TextBox
    Friend WithEvents TxtBoxAvailableTickets As TextBox
    Friend WithEvents TxtBoxTotalTickets As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnLast As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnFirst As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnAddNew As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnHelp As Button
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintEvents As Printing.PrintDocument
    Friend WithEvents TxtBoxEventDate As DateTimePicker
    Friend WithEvents TxtBoxEventTime As DateTimePicker
End Class
