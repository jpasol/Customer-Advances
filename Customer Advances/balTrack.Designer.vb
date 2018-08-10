<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class balTrack
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dvBalances = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtOrnum = New System.Windows.Forms.TextBox()
        Me.txtOrdttm = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtOramt = New System.Windows.Forms.TextBox()
        Me.txtOrbal = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ccrnum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.amtpay = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ccrdte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dvBalances, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dvBalances
        '
        Me.dvBalances.AllowUserToAddRows = False
        Me.dvBalances.AllowUserToDeleteRows = False
        Me.dvBalances.AllowUserToResizeColumns = False
        Me.dvBalances.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.dvBalances.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dvBalances.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dvBalances.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvBalances.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ccrnum, Me.amtpay, Me.ccrdte})
        Me.dvBalances.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dvBalances.Location = New System.Drawing.Point(12, 94)
        Me.dvBalances.Name = "dvBalances"
        Me.dvBalances.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dvBalances.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dvBalances.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dvBalances.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dvBalances.ShowCellErrors = False
        Me.dvBalances.ShowCellToolTips = False
        Me.dvBalances.ShowEditingIcon = False
        Me.dvBalances.ShowRowErrors = False
        Me.dvBalances.Size = New System.Drawing.Size(512, 344)
        Me.dvBalances.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Label1.Location = New System.Drawing.Point(8, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "OR Number"
        '
        'txtOrnum
        '
        Me.txtOrnum.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.txtOrnum.Location = New System.Drawing.Point(118, 21)
        Me.txtOrnum.Name = "txtOrnum"
        Me.txtOrnum.ReadOnly = True
        Me.txtOrnum.Size = New System.Drawing.Size(151, 27)
        Me.txtOrnum.TabIndex = 2
        '
        'txtOrdttm
        '
        Me.txtOrdttm.Location = New System.Drawing.Point(118, 68)
        Me.txtOrdttm.Name = "txtOrdttm"
        Me.txtOrdttm.ReadOnly = True
        Me.txtOrdttm.Size = New System.Drawing.Size(406, 20)
        Me.txtOrdttm.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Date Recently Used"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Label3.Location = New System.Drawing.Point(286, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 22)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "OR Amount"
        '
        'txtOramt
        '
        Me.txtOramt.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.txtOramt.Location = New System.Drawing.Point(399, 9)
        Me.txtOramt.Name = "txtOramt"
        Me.txtOramt.ReadOnly = True
        Me.txtOramt.Size = New System.Drawing.Size(125, 27)
        Me.txtOramt.TabIndex = 6
        '
        'txtOrbal
        '
        Me.txtOrbal.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.txtOrbal.Location = New System.Drawing.Point(399, 35)
        Me.txtOrbal.Name = "txtOrbal"
        Me.txtOrbal.ReadOnly = True
        Me.txtOrbal.Size = New System.Drawing.Size(125, 27)
        Me.txtOrbal.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Label4.Location = New System.Drawing.Point(286, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 22)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "OR Balance"
        '
        'ccrnum
        '
        Me.ccrnum.HeaderText = "Ref. #"
        Me.ccrnum.Name = "ccrnum"
        Me.ccrnum.ReadOnly = True
        Me.ccrnum.Width = 130
        '
        'amtpay
        '
        Me.amtpay.HeaderText = "Amount"
        Me.amtpay.Name = "amtpay"
        Me.amtpay.ReadOnly = True
        Me.amtpay.Width = 130
        '
        'ccrdte
        '
        Me.ccrdte.HeaderText = "Date"
        Me.ccrdte.Name = "ccrdte"
        Me.ccrdte.ReadOnly = True
        Me.ccrdte.Width = 209
        '
        'balTrack
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtOrbal)
        Me.Controls.Add(Me.txtOramt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtOrdttm)
        Me.Controls.Add(Me.txtOrnum)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dvBalances)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "balTrack"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Balance Tracker"
        Me.TopMost = True
        CType(Me.dvBalances, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dvBalances As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtOrnum As TextBox
    Friend WithEvents txtOrdttm As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtOramt As TextBox
    Friend WithEvents txtOrbal As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ccrnum As DataGridViewTextBoxColumn
    Friend WithEvents amtpay As DataGridViewTextBoxColumn
    Friend WithEvents ccrdte As DataGridViewTextBoxColumn
End Class
