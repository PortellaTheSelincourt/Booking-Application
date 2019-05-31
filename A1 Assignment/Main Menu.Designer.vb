<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.btnContacts = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnSwitchUser = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnEvents = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.EventBooking = New System.Windows.Forms.Button()
        Me.DataSet1 = New System.Data.DataSet()
        Me.btnUserManual = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnContacts
        '
        Me.btnContacts.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnContacts.Location = New System.Drawing.Point(340, 172)
        Me.btnContacts.Name = "btnContacts"
        Me.btnContacts.Size = New System.Drawing.Size(152, 92)
        Me.btnContacts.TabIndex = 1
        Me.btnContacts.Text = "Manage Contacts"
        Me.btnContacts.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnExit.BackColor = System.Drawing.Color.Yellow
        Me.btnExit.Location = New System.Drawing.Point(498, 270)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(152, 92)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnSwitchUser
        '
        Me.btnSwitchUser.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSwitchUser.Location = New System.Drawing.Point(498, 172)
        Me.btnSwitchUser.Name = "btnSwitchUser"
        Me.btnSwitchUser.Size = New System.Drawing.Size(152, 92)
        Me.btnSwitchUser.TabIndex = 4
        Me.btnSwitchUser.Text = "Switch User"
        Me.btnSwitchUser.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox1.Image = Global.A1_Assignment.My.Resources.Resources.b26neslogo
        Me.PictureBox1.Location = New System.Drawing.Point(129, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(418, 139)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnEvents
        '
        Me.btnEvents.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnEvents.Location = New System.Drawing.Point(182, 172)
        Me.btnEvents.Name = "btnEvents"
        Me.btnEvents.Size = New System.Drawing.Size(152, 92)
        Me.btnEvents.TabIndex = 5
        Me.btnEvents.Text = "Manage Events"
        Me.btnEvents.UseVisualStyleBackColor = True
        '
        'btnHelp
        '
        Me.btnHelp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnHelp.Location = New System.Drawing.Point(627, 12)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(40, 38)
        Me.btnHelp.TabIndex = 6
        Me.btnHelp.Text = "?"
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'EventBooking
        '
        Me.EventBooking.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.EventBooking.Location = New System.Drawing.Point(24, 172)
        Me.EventBooking.Name = "EventBooking"
        Me.EventBooking.Size = New System.Drawing.Size(152, 92)
        Me.EventBooking.TabIndex = 8
        Me.EventBooking.Text = "Events Booking"
        Me.EventBooking.UseVisualStyleBackColor = True
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        '
        'btnUserManual
        '
        Me.btnUserManual.Location = New System.Drawing.Point(340, 270)
        Me.btnUserManual.Name = "btnUserManual"
        Me.btnUserManual.Size = New System.Drawing.Size(152, 92)
        Me.btnUserManual.TabIndex = 9
        Me.btnUserManual.Text = "User Manual"
        Me.btnUserManual.UseVisualStyleBackColor = True
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(679, 394)
        Me.Controls.Add(Me.btnUserManual)
        Me.Controls.Add(Me.EventBooking)
        Me.Controls.Add(Me.btnContacts)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnEvents)
        Me.Controls.Add(Me.btnSwitchUser)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(695, 433)
        Me.Name = "MainMenu"
        Me.Text = "Main Menu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnContacts As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnSwitchUser As Button
    Friend WithEvents btnEvents As Button
    Friend WithEvents btnHelp As Button
    Friend WithEvents EventBooking As Button
    Friend WithEvents DataSet1 As DataSet
    Friend WithEvents btnUserManual As Button
End Class
