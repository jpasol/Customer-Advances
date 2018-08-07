<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCusadv
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
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dvAdvances = New System.Windows.Forms.DataGridView()
        Me.ornum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cusnam = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.oramt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.orbal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lstddtm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdRefresh = New System.Windows.Forms.Button()
        Me.cmdDel = New System.Windows.Forms.Button()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.cmdNew = New System.Windows.Forms.Button()
        Me.pnlCRUD = New System.Windows.Forms.Panel()
        Me.txtOrdttm = New System.Windows.Forms.TextBox()
        Me.txtOrbal = New System.Windows.Forms.TextBox()
        Me.txtOramt = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtChkdttm = New System.Windows.Forms.TextBox()
        Me.txtChkbnk = New System.Windows.Forms.TextBox()
        Me.txtChkno = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pnlEntries = New System.Windows.Forms.Panel()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.txtCusnam = New System.Windows.Forms.TextBox()
        Me.txtCuscde = New System.Windows.Forms.TextBox()
        Me.lblCusnam = New System.Windows.Forms.Label()
        Me.lblCuscde = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtOrnum = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.dvAdvances, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.pnlCRUD.SuspendLayout()
        Me.pnlEntries.SuspendLayout()
        Me.SuspendLayout()
        '
        'dvAdvances
        '
        Me.dvAdvances.AllowUserToAddRows = False
        Me.dvAdvances.AllowUserToDeleteRows = False
        Me.dvAdvances.AllowUserToResizeColumns = False
        Me.dvAdvances.AllowUserToResizeRows = False
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.MistyRose
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White
        Me.dvAdvances.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dvAdvances.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dvAdvances.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvAdvances.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ornum, Me.cusnam, Me.oramt, Me.orbal, Me.lstddtm})
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dvAdvances.DefaultCellStyle = DataGridViewCellStyle12
        Me.dvAdvances.Location = New System.Drawing.Point(12, 256)
        Me.dvAdvances.MultiSelect = False
        Me.dvAdvances.Name = "dvAdvances"
        Me.dvAdvances.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dvAdvances.Size = New System.Drawing.Size(979, 330)
        Me.dvAdvances.TabIndex = 0
        '
        'ornum
        '
        Me.ornum.HeaderText = "OR Number"
        Me.ornum.Name = "ornum"
        Me.ornum.ReadOnly = True
        '
        'cusnam
        '
        Me.cusnam.HeaderText = "Customer Name"
        Me.cusnam.Name = "cusnam"
        Me.cusnam.ReadOnly = True
        Me.cusnam.Width = 300
        '
        'oramt
        '
        Me.oramt.HeaderText = "OR Amount"
        Me.oramt.Name = "oramt"
        Me.oramt.ReadOnly = True
        Me.oramt.Width = 150
        '
        'orbal
        '
        Me.orbal.HeaderText = "OR Balance"
        Me.orbal.Name = "orbal"
        Me.orbal.ReadOnly = True
        Me.orbal.Width = 150
        '
        'lstddtm
        '
        Me.lstddtm.HeaderText = "Recent Use"
        Me.lstddtm.Name = "lstddtm"
        Me.lstddtm.ReadOnly = True
        Me.lstddtm.Width = 236
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1003, 24)
        Me.MenuStrip1.TabIndex = 19
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'cmdExit
        '
        Me.cmdExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.cmdExit.Location = New System.Drawing.Point(834, 0)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(145, 46)
        Me.cmdExit.TabIndex = 24
        Me.cmdExit.Text = "Exit (F3)"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.cmdSave.Location = New System.Drawing.Point(655, 0)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(145, 46)
        Me.cmdSave.TabIndex = 25
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        Me.cmdSave.Visible = False
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.cmdRefresh.Location = New System.Drawing.Point(477, 0)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(145, 46)
        Me.cmdRefresh.TabIndex = 31
        Me.cmdRefresh.Text = "Refresh (F5)"
        Me.cmdRefresh.UseVisualStyleBackColor = True
        '
        'cmdDel
        '
        Me.cmdDel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.cmdDel.Location = New System.Drawing.Point(318, 0)
        Me.cmdDel.Name = "cmdDel"
        Me.cmdDel.Size = New System.Drawing.Size(145, 46)
        Me.cmdDel.TabIndex = 30
        Me.cmdDel.Text = "Delete (DEL)"
        Me.cmdDel.UseVisualStyleBackColor = True
        '
        'cmdEdit
        '
        Me.cmdEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.cmdEdit.Location = New System.Drawing.Point(159, 0)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(145, 46)
        Me.cmdEdit.TabIndex = 29
        Me.cmdEdit.Text = "Edit (F2)"
        Me.cmdEdit.UseVisualStyleBackColor = True
        '
        'cmdNew
        '
        Me.cmdNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.cmdNew.Location = New System.Drawing.Point(0, 0)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(145, 46)
        Me.cmdNew.TabIndex = 28
        Me.cmdNew.Text = "New (F1)"
        Me.cmdNew.UseVisualStyleBackColor = True
        '
        'pnlCRUD
        '
        Me.pnlCRUD.Controls.Add(Me.cmdRefresh)
        Me.pnlCRUD.Controls.Add(Me.cmdDel)
        Me.pnlCRUD.Controls.Add(Me.cmdEdit)
        Me.pnlCRUD.Controls.Add(Me.cmdNew)
        Me.pnlCRUD.Controls.Add(Me.cmdSave)
        Me.pnlCRUD.Controls.Add(Me.cmdExit)
        Me.pnlCRUD.Location = New System.Drawing.Point(12, 604)
        Me.pnlCRUD.Name = "pnlCRUD"
        Me.pnlCRUD.Size = New System.Drawing.Size(981, 53)
        Me.pnlCRUD.TabIndex = 32
        '
        'txtOrdttm
        '
        Me.txtOrdttm.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.txtOrdttm.Location = New System.Drawing.Point(655, 125)
        Me.txtOrdttm.Name = "txtOrdttm"
        Me.txtOrdttm.Size = New System.Drawing.Size(294, 27)
        Me.txtOrdttm.TabIndex = 50
        '
        'txtOrbal
        '
        Me.txtOrbal.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.txtOrbal.Location = New System.Drawing.Point(655, 91)
        Me.txtOrbal.MaxLength = 8
        Me.txtOrbal.Name = "txtOrbal"
        Me.txtOrbal.Size = New System.Drawing.Size(228, 27)
        Me.txtOrbal.TabIndex = 49
        '
        'txtOramt
        '
        Me.txtOramt.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.txtOramt.Location = New System.Drawing.Point(655, 57)
        Me.txtOramt.MaxLength = 8
        Me.txtOramt.Name = "txtOramt"
        Me.txtOramt.Size = New System.Drawing.Size(228, 27)
        Me.txtOramt.TabIndex = 48
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Label9.Location = New System.Drawing.Point(546, 127)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 22)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "OR Date"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Label8.Location = New System.Drawing.Point(546, 93)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 22)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "OR Balance"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Label7.Location = New System.Drawing.Point(546, 59)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 22)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "OR Amount"
        '
        'txtChkdttm
        '
        Me.txtChkdttm.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.txtChkdttm.Location = New System.Drawing.Point(211, 161)
        Me.txtChkdttm.Name = "txtChkdttm"
        Me.txtChkdttm.Size = New System.Drawing.Size(302, 27)
        Me.txtChkdttm.TabIndex = 46
        '
        'txtChkbnk
        '
        Me.txtChkbnk.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.txtChkbnk.Location = New System.Drawing.Point(211, 125)
        Me.txtChkbnk.MaxLength = 10
        Me.txtChkbnk.Name = "txtChkbnk"
        Me.txtChkbnk.Size = New System.Drawing.Size(302, 27)
        Me.txtChkbnk.TabIndex = 45
        '
        'txtChkno
        '
        Me.txtChkno.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.txtChkno.Location = New System.Drawing.Point(211, 89)
        Me.txtChkno.MaxLength = 10
        Me.txtChkno.Name = "txtChkno"
        Me.txtChkno.Size = New System.Drawing.Size(302, 27)
        Me.txtChkno.TabIndex = 44
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Label5.Location = New System.Drawing.Point(47, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 22)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Cheque Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Label4.Location = New System.Drawing.Point(47, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 22)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Cheque Bank"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Label3.Location = New System.Drawing.Point(47, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 22)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Cheque Number"
        '
        'pnlEntries
        '
        Me.pnlEntries.Controls.Add(Me.txtUser)
        Me.pnlEntries.Controls.Add(Me.lblUser)
        Me.pnlEntries.Controls.Add(Me.txtChkdttm)
        Me.pnlEntries.Controls.Add(Me.txtChkbnk)
        Me.pnlEntries.Controls.Add(Me.txtChkno)
        Me.pnlEntries.Controls.Add(Me.Label5)
        Me.pnlEntries.Controls.Add(Me.Label4)
        Me.pnlEntries.Controls.Add(Me.Label3)
        Me.pnlEntries.Controls.Add(Me.txtOrdttm)
        Me.pnlEntries.Controls.Add(Me.txtOrbal)
        Me.pnlEntries.Controls.Add(Me.txtOramt)
        Me.pnlEntries.Controls.Add(Me.Label9)
        Me.pnlEntries.Controls.Add(Me.Label8)
        Me.pnlEntries.Controls.Add(Me.Label7)
        Me.pnlEntries.Enabled = False
        Me.pnlEntries.Location = New System.Drawing.Point(12, 36)
        Me.pnlEntries.Name = "pnlEntries"
        Me.pnlEntries.Size = New System.Drawing.Size(979, 206)
        Me.pnlEntries.TabIndex = 47
        '
        'txtUser
        '
        Me.txtUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.txtUser.Location = New System.Drawing.Point(655, 159)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.ReadOnly = True
        Me.txtUser.Size = New System.Drawing.Size(294, 27)
        Me.txtUser.TabIndex = 51
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.lblUser.Location = New System.Drawing.Point(546, 161)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(48, 22)
        Me.lblUser.TabIndex = 47
        Me.lblUser.Text = "User"
        '
        'txtCusnam
        '
        Me.txtCusnam.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCusnam.Location = New System.Drawing.Point(183, 83)
        Me.txtCusnam.Name = "txtCusnam"
        Me.txtCusnam.Size = New System.Drawing.Size(342, 30)
        Me.txtCusnam.TabIndex = 43
        '
        'txtCuscde
        '
        Me.txtCuscde.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuscde.Location = New System.Drawing.Point(183, 47)
        Me.txtCuscde.MaxLength = 6
        Me.txtCuscde.Name = "txtCuscde"
        Me.txtCuscde.Size = New System.Drawing.Size(166, 30)
        Me.txtCuscde.TabIndex = 42
        '
        'lblCusnam
        '
        Me.lblCusnam.AutoSize = True
        Me.lblCusnam.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCusnam.Location = New System.Drawing.Point(25, 86)
        Me.lblCusnam.Name = "lblCusnam"
        Me.lblCusnam.Size = New System.Drawing.Size(154, 25)
        Me.lblCusnam.TabIndex = 49
        Me.lblCusnam.Text = "Customer Name"
        '
        'lblCuscde
        '
        Me.lblCuscde.AutoSize = True
        Me.lblCuscde.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuscde.Location = New System.Drawing.Point(25, 47)
        Me.lblCuscde.Name = "lblCuscde"
        Me.lblCuscde.Size = New System.Drawing.Size(150, 25)
        Me.lblCuscde.TabIndex = 48
        Me.lblCuscde.Text = "Customer Code"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(9, 588)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Label1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtOrnum
        '
        Me.txtOrnum.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.txtOrnum.Location = New System.Drawing.Point(667, 50)
        Me.txtOrnum.MaxLength = 8
        Me.txtOrnum.Name = "txtOrnum"
        Me.txtOrnum.Size = New System.Drawing.Size(145, 27)
        Me.txtOrnum.TabIndex = 47
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Label6.Location = New System.Drawing.Point(558, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 22)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "OR Number"
        '
        'frmCusadv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1003, 662)
        Me.Controls.Add(Me.txtOrnum)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCusnam)
        Me.Controls.Add(Me.txtCuscde)
        Me.Controls.Add(Me.lblCusnam)
        Me.Controls.Add(Me.lblCuscde)
        Me.Controls.Add(Me.pnlEntries)
        Me.Controls.Add(Me.pnlCRUD)
        Me.Controls.Add(Me.dvAdvances)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmCusadv"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer Advances"
        CType(Me.dvAdvances, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.pnlCRUD.ResumeLayout(False)
        Me.pnlEntries.ResumeLayout(False)
        Me.pnlEntries.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dvAdvances As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cmdExit As Button
    Friend WithEvents ornum As DataGridViewTextBoxColumn
    Friend WithEvents cusnam As DataGridViewTextBoxColumn
    Friend WithEvents oramt As DataGridViewTextBoxColumn
    Friend WithEvents orbal As DataGridViewTextBoxColumn
    Friend WithEvents lstddtm As DataGridViewTextBoxColumn
    Friend WithEvents cmdSave As Button
    Friend WithEvents cmdRefresh As Button
    Friend WithEvents cmdDel As Button
    Friend WithEvents cmdEdit As Button
    Friend WithEvents cmdNew As Button
    Friend WithEvents pnlCRUD As Panel
    Friend WithEvents txtOrdttm As TextBox
    Friend WithEvents txtOrbal As TextBox
    Friend WithEvents txtOramt As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtChkdttm As TextBox
    Friend WithEvents txtChkbnk As TextBox
    Friend WithEvents txtChkno As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents pnlEntries As Panel
    Friend WithEvents txtCusnam As TextBox
    Friend WithEvents txtCuscde As TextBox
    Friend WithEvents lblCusnam As Label
    Friend WithEvents lblCuscde As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents lblUser As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtOrnum As TextBox
    Friend WithEvents Label6 As Label
End Class
