<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Contacts
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Contacts))
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtBoxNotes = New System.Windows.Forms.TextBox()
        Me.txtBoxEmail = New System.Windows.Forms.TextBox()
        Me.txtBoxPhone = New System.Windows.Forms.TextBox()
        Me.txtBoxPostCode = New System.Windows.Forms.TextBox()
        Me.txtBoxAddress3 = New System.Windows.Forms.TextBox()
        Me.txtBoxAddress2 = New System.Windows.Forms.TextBox()
        Me.txtBoxAddress1 = New System.Windows.Forms.TextBox()
        Me.txtBoxSurname = New System.Windows.Forms.TextBox()
        Me.txtBoxFirstName = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSaveRecord = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PrintContacts = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(415, 282)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 13)
        Me.Label9.TabIndex = 59
        Me.Label9.Text = "Notes:"
        '
        'txtBoxNotes
        '
        Me.txtBoxNotes.Location = New System.Drawing.Point(280, 299)
        Me.txtBoxNotes.Multiline = True
        Me.txtBoxNotes.Name = "txtBoxNotes"
        Me.txtBoxNotes.Size = New System.Drawing.Size(329, 258)
        Me.txtBoxNotes.TabIndex = 58
        '
        'txtBoxEmail
        '
        Me.txtBoxEmail.Location = New System.Drawing.Point(380, 238)
        Me.txtBoxEmail.Name = "txtBoxEmail"
        Me.txtBoxEmail.Size = New System.Drawing.Size(209, 20)
        Me.txtBoxEmail.TabIndex = 57
        '
        'txtBoxPhone
        '
        Me.txtBoxPhone.Location = New System.Drawing.Point(380, 203)
        Me.txtBoxPhone.Name = "txtBoxPhone"
        Me.txtBoxPhone.Size = New System.Drawing.Size(209, 20)
        Me.txtBoxPhone.TabIndex = 56
        '
        'txtBoxPostCode
        '
        Me.txtBoxPostCode.Location = New System.Drawing.Point(77, 378)
        Me.txtBoxPostCode.Name = "txtBoxPostCode"
        Me.txtBoxPostCode.Size = New System.Drawing.Size(178, 20)
        Me.txtBoxPostCode.TabIndex = 55
        '
        'txtBoxAddress3
        '
        Me.txtBoxAddress3.Location = New System.Drawing.Point(77, 343)
        Me.txtBoxAddress3.Name = "txtBoxAddress3"
        Me.txtBoxAddress3.Size = New System.Drawing.Size(178, 20)
        Me.txtBoxAddress3.TabIndex = 54
        '
        'txtBoxAddress2
        '
        Me.txtBoxAddress2.Location = New System.Drawing.Point(77, 308)
        Me.txtBoxAddress2.Name = "txtBoxAddress2"
        Me.txtBoxAddress2.Size = New System.Drawing.Size(178, 20)
        Me.txtBoxAddress2.TabIndex = 53
        '
        'txtBoxAddress1
        '
        Me.txtBoxAddress1.Location = New System.Drawing.Point(77, 273)
        Me.txtBoxAddress1.Name = "txtBoxAddress1"
        Me.txtBoxAddress1.Size = New System.Drawing.Size(178, 20)
        Me.txtBoxAddress1.TabIndex = 52
        '
        'txtBoxSurname
        '
        Me.txtBoxSurname.Location = New System.Drawing.Point(77, 238)
        Me.txtBoxSurname.Name = "txtBoxSurname"
        Me.txtBoxSurname.Size = New System.Drawing.Size(178, 20)
        Me.txtBoxSurname.TabIndex = 51
        '
        'txtBoxFirstName
        '
        Me.txtBoxFirstName.Location = New System.Drawing.Point(77, 203)
        Me.txtBoxFirstName.Name = "txtBoxFirstName"
        Me.txtBoxFirstName.Size = New System.Drawing.Size(178, 20)
        Me.txtBoxFirstName.TabIndex = 50
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(326, 241)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "Email:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(326, 206)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "Phone:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 381)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Post Code:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 276)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Address:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 241)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Surname:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 206)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "First Name:"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Orange
        Me.btnExit.Location = New System.Drawing.Point(511, 578)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(98, 23)
        Me.btnExit.TabIndex = 41
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(393, 578)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(98, 23)
        Me.btnLast.TabIndex = 40
        Me.btnLast.Text = ">>"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(275, 578)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(98, 23)
        Me.btnNext.TabIndex = 39
        Me.btnNext.Text = ">"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(157, 578)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(98, 23)
        Me.btnPrevious.TabIndex = 38
        Me.btnPrevious.Text = "<"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(39, 578)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(98, 23)
        Me.btnFirst.TabIndex = 37
        Me.btnFirst.Text = "<<"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(89, 534)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(105, 23)
        Me.btnDelete.TabIndex = 36
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(157, 434)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(105, 23)
        Me.btnUpdate.TabIndex = 34
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnAddNew
        '
        Me.btnAddNew.Location = New System.Drawing.Point(39, 434)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(98, 23)
        Me.btnAddNew.TabIndex = 33
        Me.btnAddNew.Text = "Add New"
        Me.btnAddNew.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(597, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 38)
        Me.Button1.TabIndex = 64
        Me.Button1.Text = "?"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(157, 485)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(98, 23)
        Me.btnCancel.TabIndex = 66
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSaveRecord
        '
        Me.btnSaveRecord.Enabled = False
        Me.btnSaveRecord.Location = New System.Drawing.Point(39, 485)
        Me.btnSaveRecord.Name = "btnSaveRecord"
        Me.btnSaveRecord.Size = New System.Drawing.Size(98, 23)
        Me.btnSaveRecord.TabIndex = 67
        Me.btnSaveRecord.Text = "Save Record"
        Me.btnSaveRecord.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Image = Global.A1_Assignment.My.Resources.Resources._920x312_Contacts
        Me.PictureBox1.Location = New System.Drawing.Point(129, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(367, 152)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'Contacts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(641, 626)
        Me.Controls.Add(Me.btnSaveRecord)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtBoxNotes)
        Me.Controls.Add(Me.txtBoxEmail)
        Me.Controls.Add(Me.txtBoxPhone)
        Me.Controls.Add(Me.txtBoxPostCode)
        Me.Controls.Add(Me.txtBoxAddress3)
        Me.Controls.Add(Me.txtBoxAddress2)
        Me.Controls.Add(Me.txtBoxAddress1)
        Me.Controls.Add(Me.txtBoxSurname)
        Me.Controls.Add(Me.txtBoxFirstName)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnFirst)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAddNew)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Contacts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contacts"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtBoxNotes As TextBox
    Friend WithEvents txtBoxEmail As TextBox
    Friend WithEvents txtBoxPhone As TextBox
    Friend WithEvents txtBoxPostCode As TextBox
    Friend WithEvents txtBoxAddress3 As TextBox
    Friend WithEvents txtBoxAddress2 As TextBox
    Friend WithEvents txtBoxAddress1 As TextBox
    Friend WithEvents txtBoxSurname As TextBox
    Friend WithEvents txtBoxFirstName As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnLast As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnFirst As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnAddNew As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSaveRecord As Button
    Friend WithEvents PrintContacts As Printing.PrintDocument
    Friend WithEvents PrintDialog1 As PrintDialog
End Class
