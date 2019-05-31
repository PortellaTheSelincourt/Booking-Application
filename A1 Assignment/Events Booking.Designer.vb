<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EventsBooking
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EventsBooking))
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.TxtBoxAvailableTickets = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtBoxEventDuration = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtBoxEventTime = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtBoxEventDate = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtBoxEventLocation = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtBoxEventTitle = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBoxNotes = New System.Windows.Forms.TextBox()
        Me.txtBoxEmail = New System.Windows.Forms.TextBox()
        Me.txtBoxPhone = New System.Windows.Forms.TextBox()
        Me.txtBoxPostCode = New System.Windows.Forms.TextBox()
        Me.txtBoxAddress3 = New System.Windows.Forms.TextBox()
        Me.txtBoxAddress2 = New System.Windows.Forms.TextBox()
        Me.txtBoxAddress1 = New System.Windows.Forms.TextBox()
        Me.txtBoxSurname = New System.Windows.Forms.TextBox()
        Me.txtBoxFirstName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnContactsLast = New System.Windows.Forms.Button()
        Me.btnContactNext = New System.Windows.Forms.Button()
        Me.btnContactsPrevious = New System.Windows.Forms.Button()
        Me.btnContactsFirst = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtBoxTicketsLeft = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtBoxTicketsSold = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtBoxTime = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintBooking = New System.Drawing.Printing.PrintDocument()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(346, 604)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(105, 23)
        Me.btnPrint.TabIndex = 94
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(457, 604)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(106, 23)
        Me.btnSave.TabIndex = 92
        Me.btnSave.Text = "Save Record"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'TxtBoxAvailableTickets
        '
        Me.TxtBoxAvailableTickets.Location = New System.Drawing.Point(96, 60)
        Me.TxtBoxAvailableTickets.Name = "TxtBoxAvailableTickets"
        Me.TxtBoxAvailableTickets.Size = New System.Drawing.Size(38, 20)
        Me.TxtBoxAvailableTickets.TabIndex = 87
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(0, 64)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 13)
        Me.Label8.TabIndex = 85
        Me.Label8.Text = "Available Tickets:"
        '
        'TxtBoxEventDuration
        '
        Me.TxtBoxEventDuration.Location = New System.Drawing.Point(96, 196)
        Me.TxtBoxEventDuration.Name = "TxtBoxEventDuration"
        Me.TxtBoxEventDuration.Size = New System.Drawing.Size(210, 20)
        Me.TxtBoxEventDuration.TabIndex = 82
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 200)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 81
        Me.Label5.Text = "Event Duration:"
        '
        'TxtBoxEventTime
        '
        Me.TxtBoxEventTime.Location = New System.Drawing.Point(95, 170)
        Me.TxtBoxEventTime.Name = "TxtBoxEventTime"
        Me.TxtBoxEventTime.Size = New System.Drawing.Size(210, 20)
        Me.TxtBoxEventTime.TabIndex = 80
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "Event Time:"
        '
        'TxtBoxEventDate
        '
        Me.TxtBoxEventDate.Location = New System.Drawing.Point(95, 142)
        Me.TxtBoxEventDate.Name = "TxtBoxEventDate"
        Me.TxtBoxEventDate.Size = New System.Drawing.Size(210, 20)
        Me.TxtBoxEventDate.TabIndex = 78
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 77
        Me.Label3.Text = "Event Date::"
        '
        'TxtBoxEventLocation
        '
        Me.TxtBoxEventLocation.Location = New System.Drawing.Point(96, 116)
        Me.TxtBoxEventLocation.Name = "TxtBoxEventLocation"
        Me.TxtBoxEventLocation.Size = New System.Drawing.Size(210, 20)
        Me.TxtBoxEventLocation.TabIndex = 76
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 75
        Me.Label2.Text = "Event Location:"
        '
        'TxtBoxEventTitle
        '
        Me.TxtBoxEventTitle.Location = New System.Drawing.Point(96, 86)
        Me.TxtBoxEventTitle.Name = "TxtBoxEventTitle"
        Me.TxtBoxEventTitle.Size = New System.Drawing.Size(210, 20)
        Me.TxtBoxEventTitle.TabIndex = 74
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "Event Title:"
        '
        'txtBoxNotes
        '
        Me.txtBoxNotes.Location = New System.Drawing.Point(6, 144)
        Me.txtBoxNotes.Multiline = True
        Me.txtBoxNotes.Name = "txtBoxNotes"
        Me.txtBoxNotes.Size = New System.Drawing.Size(257, 223)
        Me.txtBoxNotes.TabIndex = 112
        '
        'txtBoxEmail
        '
        Me.txtBoxEmail.Location = New System.Drawing.Point(95, 268)
        Me.txtBoxEmail.Name = "txtBoxEmail"
        Me.txtBoxEmail.Size = New System.Drawing.Size(209, 20)
        Me.txtBoxEmail.TabIndex = 111
        '
        'txtBoxPhone
        '
        Me.txtBoxPhone.Location = New System.Drawing.Point(95, 233)
        Me.txtBoxPhone.Name = "txtBoxPhone"
        Me.txtBoxPhone.Size = New System.Drawing.Size(209, 20)
        Me.txtBoxPhone.TabIndex = 110
        '
        'txtBoxPostCode
        '
        Me.txtBoxPostCode.Location = New System.Drawing.Point(95, 198)
        Me.txtBoxPostCode.Name = "txtBoxPostCode"
        Me.txtBoxPostCode.Size = New System.Drawing.Size(210, 20)
        Me.txtBoxPostCode.TabIndex = 109
        '
        'txtBoxAddress3
        '
        Me.txtBoxAddress3.Location = New System.Drawing.Point(95, 163)
        Me.txtBoxAddress3.Name = "txtBoxAddress3"
        Me.txtBoxAddress3.Size = New System.Drawing.Size(210, 20)
        Me.txtBoxAddress3.TabIndex = 108
        '
        'txtBoxAddress2
        '
        Me.txtBoxAddress2.Location = New System.Drawing.Point(95, 128)
        Me.txtBoxAddress2.Name = "txtBoxAddress2"
        Me.txtBoxAddress2.Size = New System.Drawing.Size(210, 20)
        Me.txtBoxAddress2.TabIndex = 107
        '
        'txtBoxAddress1
        '
        Me.txtBoxAddress1.Location = New System.Drawing.Point(95, 93)
        Me.txtBoxAddress1.Name = "txtBoxAddress1"
        Me.txtBoxAddress1.Size = New System.Drawing.Size(210, 20)
        Me.txtBoxAddress1.TabIndex = 106
        '
        'txtBoxSurname
        '
        Me.txtBoxSurname.Location = New System.Drawing.Point(95, 58)
        Me.txtBoxSurname.Name = "txtBoxSurname"
        Me.txtBoxSurname.Size = New System.Drawing.Size(210, 20)
        Me.txtBoxSurname.TabIndex = 105
        '
        'txtBoxFirstName
        '
        Me.txtBoxFirstName.Location = New System.Drawing.Point(95, 23)
        Me.txtBoxFirstName.Name = "txtBoxFirstName"
        Me.txtBoxFirstName.Size = New System.Drawing.Size(210, 20)
        Me.txtBoxFirstName.TabIndex = 104
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(41, 271)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 103
        Me.Label6.Text = "Email:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(41, 236)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 102
        Me.Label7.Text = "Phone:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(30, 201)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 13)
        Me.Label10.TabIndex = 101
        Me.Label10.Text = "Post Code:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(30, 96)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 13)
        Me.Label11.TabIndex = 100
        Me.Label11.Text = "Address:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(30, 61)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 13)
        Me.Label12.TabIndex = 99
        Me.Label12.Text = "Surname:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(30, 26)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 13)
        Me.Label13.TabIndex = 98
        Me.Label13.Text = "First Name:"
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(254, 234)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(52, 23)
        Me.btnLast.TabIndex = 119
        Me.btnLast.Text = ">>"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(202, 234)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(46, 23)
        Me.btnNext.TabIndex = 118
        Me.btnNext.Text = ">"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(151, 234)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(45, 23)
        Me.btnPrevious.TabIndex = 117
        Me.btnPrevious.Text = "<"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(96, 234)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(49, 23)
        Me.btnFirst.TabIndex = 116
        Me.btnFirst.Text = "<<"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'btnContactsLast
        '
        Me.btnContactsLast.Location = New System.Drawing.Point(253, 304)
        Me.btnContactsLast.Name = "btnContactsLast"
        Me.btnContactsLast.Size = New System.Drawing.Size(52, 23)
        Me.btnContactsLast.TabIndex = 123
        Me.btnContactsLast.Text = ">>"
        Me.btnContactsLast.UseVisualStyleBackColor = True
        '
        'btnContactNext
        '
        Me.btnContactNext.Location = New System.Drawing.Point(201, 304)
        Me.btnContactNext.Name = "btnContactNext"
        Me.btnContactNext.Size = New System.Drawing.Size(46, 23)
        Me.btnContactNext.TabIndex = 122
        Me.btnContactNext.Text = ">"
        Me.btnContactNext.UseVisualStyleBackColor = True
        '
        'btnContactsPrevious
        '
        Me.btnContactsPrevious.Location = New System.Drawing.Point(150, 304)
        Me.btnContactsPrevious.Name = "btnContactsPrevious"
        Me.btnContactsPrevious.Size = New System.Drawing.Size(45, 23)
        Me.btnContactsPrevious.TabIndex = 121
        Me.btnContactsPrevious.Text = "<"
        Me.btnContactsPrevious.UseVisualStyleBackColor = True
        '
        'btnContactsFirst
        '
        Me.btnContactsFirst.Location = New System.Drawing.Point(95, 304)
        Me.btnContactsFirst.Name = "btnContactsFirst"
        Me.btnContactsFirst.Size = New System.Drawing.Size(49, 23)
        Me.btnContactsFirst.TabIndex = 120
        Me.btnContactsFirst.Text = "<<"
        Me.btnContactsFirst.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtBoxEventLocation)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TxtBoxEventTitle)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btnLast)
        Me.GroupBox1.Controls.Add(Me.TxtBoxEventDate)
        Me.GroupBox1.Controls.Add(Me.btnNext)
        Me.GroupBox1.Controls.Add(Me.TxtBoxAvailableTickets)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btnPrevious)
        Me.GroupBox1.Controls.Add(Me.TxtBoxEventTime)
        Me.GroupBox1.Controls.Add(Me.btnFirst)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TxtBoxEventDuration)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(329, 282)
        Me.GroupBox1.TabIndex = 124
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Event Details"
        '
        'txtBoxTicketsLeft
        '
        Me.txtBoxTicketsLeft.Location = New System.Drawing.Point(170, 107)
        Me.txtBoxTicketsLeft.Name = "txtBoxTicketsLeft"
        Me.txtBoxTicketsLeft.Size = New System.Drawing.Size(38, 20)
        Me.txtBoxTicketsLeft.TabIndex = 121
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(13, 110)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(150, 13)
        Me.Label16.TabIndex = 120
        Me.Label16.Text = "Tickets Left After Transaction:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtBoxSurname)
        Me.GroupBox2.Controls.Add(Me.btnContactsLast)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.btnContactNext)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.btnContactsPrevious)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.btnContactsFirst)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtBoxEmail)
        Me.GroupBox2.Controls.Add(Me.txtBoxFirstName)
        Me.GroupBox2.Controls.Add(Me.txtBoxPhone)
        Me.GroupBox2.Controls.Add(Me.txtBoxAddress1)
        Me.GroupBox2.Controls.Add(Me.txtBoxPostCode)
        Me.GroupBox2.Controls.Add(Me.txtBoxAddress2)
        Me.GroupBox2.Controls.Add(Me.txtBoxAddress3)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 300)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(328, 346)
        Me.GroupBox2.TabIndex = 125
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Customer Details"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(77, 90)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 13)
        Me.Label9.TabIndex = 127
        Me.Label9.Text = "Tickets required:"
        '
        'TxtBoxTicketsSold
        '
        Me.TxtBoxTicketsSold.Location = New System.Drawing.Point(170, 83)
        Me.TxtBoxTicketsSold.Name = "TxtBoxTicketsSold"
        Me.TxtBoxTicketsSold.Size = New System.Drawing.Size(38, 20)
        Me.TxtBoxTicketsSold.TabIndex = 120
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtBoxTicketsLeft)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.txtBoxNotes)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.TxtBoxTime)
        Me.GroupBox4.Controls.Add(Me.TxtBoxTicketsSold)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Location = New System.Drawing.Point(366, 17)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(274, 373)
        Me.GroupBox4.TabIndex = 128
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Booking Details"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(10, 129)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(38, 13)
        Me.Label15.TabIndex = 131
        Me.Label15.Text = "Notes:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(75, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(112, 13)
        Me.Label14.TabIndex = 130
        Me.Label14.Text = "Time/date of booking:"
        '
        'TxtBoxTime
        '
        Me.TxtBoxTime.BackColor = System.Drawing.Color.White
        Me.TxtBoxTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBoxTime.Location = New System.Drawing.Point(64, 32)
        Me.TxtBoxTime.Multiline = True
        Me.TxtBoxTime.Name = "TxtBoxTime"
        Me.TxtBoxTime.Size = New System.Drawing.Size(144, 46)
        Me.TxtBoxTime.TabIndex = 129
        Me.TxtBoxTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Orange
        Me.btnExit.Location = New System.Drawing.Point(570, 604)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(105, 23)
        Me.btnExit.TabIndex = 130
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnHelp
        '
        Me.btnHelp.Location = New System.Drawing.Point(646, 12)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(40, 38)
        Me.btnHelp.TabIndex = 131
        Me.btnHelp.Text = "?"
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.A1_Assignment.My.Resources.Resources.Bookings
        Me.PictureBox1.Location = New System.Drawing.Point(396, 396)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(204, 205)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 132
        Me.PictureBox1.TabStop = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintBooking
        '
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'EventsBooking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 653)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EventsBooking"
        Me.Text = "Events Booking Details"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPrint As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents TxtBoxAvailableTickets As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtBoxEventDuration As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtBoxEventTime As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtBoxEventDate As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtBoxEventLocation As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtBoxEventTitle As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBoxNotes As TextBox
    Friend WithEvents txtBoxEmail As TextBox
    Friend WithEvents txtBoxPhone As TextBox
    Friend WithEvents txtBoxPostCode As TextBox
    Friend WithEvents txtBoxAddress3 As TextBox
    Friend WithEvents txtBoxAddress2 As TextBox
    Friend WithEvents txtBoxAddress1 As TextBox
    Friend WithEvents txtBoxSurname As TextBox
    Friend WithEvents txtBoxFirstName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents btnLast As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnFirst As Button
    Friend WithEvents btnContactsLast As Button
    Friend WithEvents btnContactNext As Button
    Friend WithEvents btnContactsPrevious As Button
    Friend WithEvents btnContactsFirst As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtBoxTicketsSold As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TxtBoxTime As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnHelp As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label15 As Label
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintBooking As Printing.PrintDocument
    Friend WithEvents Timer1 As Timer
    Friend WithEvents txtBoxTicketsLeft As TextBox
    Friend WithEvents Label16 As Label
End Class
