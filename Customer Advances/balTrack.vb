Public Class balTrack
    Public ornum As Long
    Public oramt As Double
    Public orbal As Double
    Public sysdttm As String

    Public Sub New(ByVal pOrnum As Long, ByVal pOramt As Double, ByVal pOrbal As Double, pSysdttm As String)
        ' This call is required by the designer.
        ornum = pOrnum
        oramt = pOramt
        orbal = pOrbal
        sysdttm = pSysdttm

        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Private Sub balTrack_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtOrdttm.Text = Date.FromOADate(0)
        With dsAdvances.Tables
            loadadrPay()

            viewBalance(.Item("Payments").Select("adrnum=" & ornum), dvBalances)

            txtOrnum.Text = ornum
            txtOramt.Text = oramt
            txtOrbal.Text = orbal
            txtOrdttm.Text = sysdttm

            dvBalances.Sort(dvBalances.Columns("ccrdte"), ComponentModel.ListSortDirection.Descending)
        End With

    End Sub

End Class