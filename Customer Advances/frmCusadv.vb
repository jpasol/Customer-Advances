Imports System.Runtime.InteropServices
Public Class frmCusadv
#Region "Form Functions"
    Public Const KEY_ALT As Integer = &H1
    Public Const _HOTKEY As Integer = &H312

    Private Declare Function GetActiveWindow Lib "user32" Alias "GetActiveWindow" () As IntPtr

    <DllImport("User32.dll")>
    Public Shared Function RegisterHotKey(ByVal hwnd As IntPtr,
                        ByVal id As Integer, ByVal fsModifiers As Integer,
                        ByVal vk As Integer) As Integer
    End Function


    <DllImport("User32.dll")>
    Public Shared Function UnregisterHotKey(ByVal hwnd As IntPtr,
                        ByVal id As Integer) As Integer
    End Function
    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        If m.Msg = _HOTKEY And GetActiveWindow = Me.Handle Then
            Dim id As IntPtr = m.WParam
            Select Case (id.ToString)
                Case "1"
                    If cmdNew.Enabled Then cmdNew_Click(cmdNew, New EventArgs)
                Case "2"
                    If cmdEdit.Enabled Then cmdEdit_Click(cmdEdit, New EventArgs)
                Case "3"
                    If cmdExit.Enabled Then cmdExit_Click(cmdExit, New EventArgs)
                Case "4"
                    If cmdRefresh.Enabled Then cmdRefresh_Click(cmdRefresh, New EventArgs)
                Case "5"
                    If cmdDel.Enabled Then cmdDel_Click(cmdDel, New EventArgs)
                Case "6"
                    If cmdEdit.Enabled = False Then
                        cmdNew_Click(cmdNew, New EventArgs)
                    ElseIf cmdNew.Enabled = False Then
                        cmdEdit_Click(cmdEdit, New EventArgs)
                    End If
                    cmdSave.Visible = False
            End Select
        End If
        MyBase.WndProc(m)
    End Sub
    Public Sub initTxtbox()
        txtCuscde.Text = ""
        txtChkno.Text = ""
        txtChkbnk.Text = ""
        txtChkdttm.Text = ""
        txtOrnum.Text = ""
        txtOramt.Text = ""
        txtOrbal.Text = ""
        txtOrdttm.Text = "" : txtOrdttm_LostFocus(txtOrdttm, New EventArgs)
        txtUser.Text = ""
        pnlEntries.Enabled = False
    End Sub
#End Region
#Region "Form"
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub frmCusadv_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        iniData()
        initTxtbox()
        dbConnect.dbConnect()
        loadAdvances()
        loadCustomer()
        loadadrPay()
        viewAdvances(dsAdvances.Tables.Item("Advances").Rows, dvAdvances)
        Label1.Text = "Logged on as " & UCase(Environment.UserName)


        RegisterHotKey(Me.Handle, 1, 0, Keys.F1)
        RegisterHotKey(Me.Handle, 2, 0, Keys.F2)
        RegisterHotKey(Me.Handle, 3, 0, Keys.F3)
        RegisterHotKey(Me.Handle, 4, 0, Keys.F5)
        RegisterHotKey(Me.Handle, 5, 0, Keys.Delete)
        RegisterHotKey(Me.Handle, 6, 0, Keys.Escape)
    End Sub

    Private Sub frmCusadv_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        UnregisterHotKey(Me.Handle, 1)
        UnregisterHotKey(Me.Handle, 2)
        UnregisterHotKey(Me.Handle, 3)
        UnregisterHotKey(Me.Handle, 4)
        UnregisterHotKey(Me.Handle, 5)
        UnregisterHotKey(Me.Handle, 6)
    End Sub
#End Region
#Region "Textbox"

    Private Sub txtChkdttm_LostFocus(sender As Object, e As EventArgs) Handles txtChkdttm.LostFocus
        With txtChkdttm
            On Error Resume Next
            Dim temp As Object = .Text
            .Text = ""
            .Text = Format(CDate(temp), "MMMM dd, yyyy")
        End With
    End Sub

    Private Sub txtOrdttm_LostFocus(sender As Object, e As EventArgs) Handles txtOrdttm.LostFocus
        With txtOrdttm
            On Error Resume Next
            Dim temp As Object = .Text
            .Text = ""
            .Text = Format(CDate(temp), "MMMM dd, yyyy") : If .Text = "" Then .Text = Format(DateTime.Now, "MMMM dd, yyyy")
        End With
    End Sub

    Private Sub txtOrnum_LostFocus(sender As Object, e As EventArgs)
        With txtOrnum
            On Error Resume Next
            Dim temp As Object = .Text
            .Text = ""
            .Text = CLng(temp)
        End With
    End Sub

    Private Sub txtOramt_LostFocus(sender As Object, e As EventArgs) Handles txtOramt.LostFocus
        With txtOramt
            On Error Resume Next
            Dim temp As Object = .Text
            .Text = ""
            .Text = Format(CDbl(temp), "#,###.#0")
        End With
        If Len(txtOrbal) = 0 Then txtOrbal.Text = txtOramt.Text 'Same Balance with Amount on New Entry
    End Sub

    Private Sub txtOrbal_LostFocus(sender As Object, e As EventArgs) Handles txtOrbal.LostFocus
        With txtOrbal
            On Error Resume Next
            Dim temp As Object = .Text
            .Text = ""
            .Text = Format(CDbl(temp), "#,###.#0")
        End With
        If txtOrbal.Text > txtOramt.Text Then txtOrbal.Focus()
    End Sub
    Private Sub txtOramt_GotFocus(sender As Object, e As EventArgs) Handles txtOramt.GotFocus
        With txtOramt
            If IsNumeric(.Text) Then .Text = CDbl(.Text)
            .SelectAll()
        End With
    End Sub

    Private Sub txtOrbal_GotFocus(sender As Object, e As EventArgs) Handles txtOrbal.GotFocus
        With txtOrbal
            If IsNumeric(.Text) Then .Text = CDbl(.Text)
            .SelectAll()
        End With
    End Sub

    Private Sub txtOramt_KeyDown(sender As Object, e As KeyEventArgs) Handles txtOramt.KeyDown
        On Error Resume Next
        With txtOramt
            If e.KeyCode = Keys.Decimal And Len(CDbl(.Text)) = 8 Then .MaxLength = 10
        End With
    End Sub

    Private Sub txtOramt_TextChanged(sender As Object, e As EventArgs) Handles txtOramt.TextChanged
        With txtOramt
            If InStr(.Text, ".") > 0 Then .MaxLength = 11 Else .MaxLength = 8
        End With
    End Sub

    Private Sub txtOrbal_KeyDown(sender As Object, e As KeyEventArgs) Handles txtOrbal.KeyDown
        On Error Resume Next
        With txtOrbal
            If e.KeyCode = Keys.Decimal And Len(CDbl(.Text)) = 8 Then .MaxLength = 10
        End With
    End Sub

    Private Sub txtOrbal_TextChanged(sender As Object, e As EventArgs) Handles txtOrbal.TextChanged
        With txtOrbal
            If InStr(.Text, ".") > 0 Then .MaxLength = 11 Else .MaxLength = 8
        End With
    End Sub
    Private Sub txtCuscde_TextChanged(sender As Object, e As EventArgs) Handles txtCuscde.TextChanged
        On Error Resume Next
        Dim tmpRow() As DataRow
        tmpRow = dsAdvances.Tables.Item("Customers").Select("cuscde = " & txtCuscde.Text)

        txtCusnam.Text = ""
        txtCusnam.Text = tmpRow(0).Field(Of Object)("cusnam")
    End Sub
    Private Sub txtChkno_GotFocus(sender As Object, e As EventArgs) Handles txtChkno.GotFocus
        txtChkno.SelectAll()
    End Sub

    Private Sub txtChkbnk_GotFocus(sender As Object, e As EventArgs) Handles txtChkbnk.GotFocus
        txtChkbnk.SelectAll()
    End Sub

    Private Sub txtCusnam_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCusnam.KeyDown
        On Error Resume Next
        If e.KeyCode = Keys.Return And (Not pnlEntries.Enabled) And pnlCRUD.Enabled Then 'New / Edit mode

            Dim tmpCusnam As String = txtCusnam.Text
            With dsAdvances.Tables.Item("Advances")
                viewAdvances(IIf(txtCusnam.Text = "", .Rows, .Select("cusnam Like '%" & tmpCusnam & "%'")), dvAdvances)
            End With
            If Not (dvAdvances.SelectedRows.Count > 0) Then initTxtbox()
        End If

    End Sub

#End Region
#Region "Command Button"
    Private Sub cmdNew_Click(sender As Object, e As EventArgs) Handles cmdNew.Click
        initTxtbox() 'initialize Textboxes

        txtCuscde.Focus() 'Focus customer Code
        cmdSave.Visible = True : cmdSave_VisibleChanged(cmdSave, New EventArgs) 'Enable Save
        cmdNew.Enabled = True
    End Sub

    Private Sub cmdDel_Click(sender As Object, e As EventArgs) Handles cmdDel.Click
        If InputBox(Prompt:="PLEASE TYPE DELETE TO PROCEED",
                    Title:="Delete") = "DELETE" Then
            Dim rsSave As New ADODB.Recordset
            rsSave.Open("Delete top (1) from cusadv where ornum=" & txtOrnum.Text,
                        gcnnBilling, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            cmdRefresh_Click(cmdRefresh, New EventArgs)
        End If
    End Sub

    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        dvAdvances_SelectionChanged(dvAdvances, New EventArgs)
        pnlEntries.Enabled = True
        cmdSave.Visible = True
        cmdEdit.Enabled = True
    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Close()
    End Sub

    Private Sub cmdRefresh_Click(sender As Object, e As EventArgs) Handles cmdRefresh.Click
        loadAdvances()

        viewAdvances(dsAdvances.Tables.Item("Advances").Rows, dvAdvances)
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If MessageBox.Show(text:="Would you like to proceed?",
                           caption:="Save",
                           icon:=MessageBoxIcon.Question,
                           buttons:=MessageBoxButtons.OKCancel) = vbOK Then
            Dim rsSave As New ADODB.Recordset
            rsSave.Open("Select * from Cusadv where ornum=" & txtOrnum.Text, gcnnBilling, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            If cmdEdit.Enabled = False Then
                rsSave.AddNew()
            End If
            rsSave.Fields("ornum").Value = txtOrnum.Text
            rsSave.Fields("cuscde").Value = txtCuscde.Text
            rsSave.Fields("oramt").Value = CDbl(txtOramt.Text)
            rsSave.Fields("orbal").Value = CDbl(txtOrbal.Text)
            rsSave.Fields("ordttm").Value = DateTime.Today
            rsSave.Fields("chkdttm").Value = txtChkdttm.Text
            rsSave.Fields("chkno").Value = txtChkno.Text
            rsSave.Fields("chkbnk").Value = txtChkbnk.Text
            rsSave.Fields("userid").Value = UCase(Environment.UserName)
            rsSave.Update()

            rsSave.Close()
            cmdSave.Visible = False
            cmdRefresh_Click(cmdRefresh, New EventArgs)
        End If
    End Sub

    Private Sub cmdSave_VisibleChanged(sender As Object, e As EventArgs) Handles cmdSave.VisibleChanged
        If cmdSave.Visible = True Then
            dvAdvances.Enabled = False
            pnlEntries.Enabled = True
            cmdNew.Enabled = False
            cmdEdit.Enabled = False
            cmdDel.Enabled = False
            cmdRefresh.Enabled = False
        Else
            dvAdvances.Enabled = True
            pnlEntries.Enabled = False
            cmdNew.Enabled = True
            cmdEdit.Enabled = True
            cmdDel.Enabled = True
            cmdRefresh.Enabled = True
            dvAdvances.Focus()
            dvAdvances_SelectionChanged(dvAdvances, New EventArgs)
        End If
    End Sub
#End Region
#Region "Data View"
    Private Sub dvAdvances_SelectionChanged(sender As Object, e As EventArgs) Handles dvAdvances.SelectionChanged
        On Error Resume Next

        With dsAdvances.Tables.Item("Advances").Select("ornum = " & dvAdvances.SelectedCells(0).Value)(0)

            txtCuscde.Text = .Field(Of Object)("cuscde")

            txtChkno.Text = .Field(Of Object)("chkno")
            txtChkbnk.Text = .Field(Of Object)("chkbnk")
            txtChkdttm.Text = .Field(Of Object)("chkdttm")

            txtOrnum.Text = .Field(Of Object)("ornum")
            txtOramt.Text = .Field(Of Object)("oramt")
            txtOrbal.Text = .Field(Of Object)("orbal")
            txtOrdttm.Text = .Field(Of Object)("ordttm")

            txtUser.Text = .Field(Of Object)("userid")
        End With
    End Sub

    Private Sub txtOrnum_KeyDown(sender As Object, e As KeyEventArgs) Handles txtOrnum.KeyDown
        On Error Resume Next
        If e.KeyCode = Keys.Return And Not pnlEntries.Enabled Then
            Dim tmpOR As Integer = txtOrnum.Text
            viewAdvances(dsAdvances.Tables.Item("Advances").Select("ornum=" & tmpOR), dvAdvances)
        End If
    End Sub

    Private Sub dvAdvances_KeyDown(sender As Object, e As KeyEventArgs) Handles dvAdvances.KeyDown
        If e.KeyCode = Keys.Return Then
            If dvAdvances.SelectedRows.Count > 0 Then
                Dim checkbal As New balTrack(pOrnum:=txtOrnum.Text,
                                             pOramt:=txtOramt.Text,
                                             pOrbal:=txtOrbal.Text,
                                             pSysdttm:=dvAdvances.SelectedCells(4).Value)

                checkbal.ShowDialog()
            End If
            e.SuppressKeyPress = True
        End If

    End Sub

    Private Sub dvAdvances_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dvAdvances.CellContentClick

    End Sub
#End Region

End Class