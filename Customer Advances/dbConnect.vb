Module dbConnect
    Public gcnnBilling As New ADODB.Connection
    Public rsCusadv As New ADODB.Recordset
    Public cmdCusadv As New ADODB.Command
    Public dataAdap As New OleDb.OleDbDataAdapter
    Public dsAdvances As New DataSet

    Public Sub iniData()
        '''''''''''Create DataTables''''''''''''''''
        Dim dtAdvances As New DataTable
        Dim dtCustomers As New DataTable
        Dim dtPayments As New DataTable
        ''''''''''''''''''''''''''''''''''''''''''''

        '''''''''''Rename DataTables''''''''''''''''
        dtAdvances.TableName = "Advances"
        dtCustomers.TableName = "Customers"
        dtPayments.TableName = "Payments"
        ''''''''''''''''''''''''''''''''''''''''''''

        ''''''''''''''Add DataTable'''''''''''''''''
        dsAdvances.Tables.Add(dtAdvances)
        dsAdvances.Tables.Add(dtCustomers)
        dsAdvances.Tables.Add(dtPayments)
        ''''''''''''''''''''''''''''''''''''''''''''

    End Sub


    Public Sub dbConnect()
        Dim strConnect As String
        On Error Resume Next
        If gcnnBilling.State = ConnectionState.Open Then gcnnBilling.Close() : gcnnBilling = Nothing
        On Error GoTo 0

        strConnect = "Provider=sqloledb" &
                    ";Data Source=" & "SBITC-DEV" &
                    ";Initial Catalog=" & "SBITCBILLING" &
                    ";Integrated Security=SSPI;"

        gcnnBilling.Open(strConnect)
    End Sub

    Public Sub loadAdvances()
        dsAdvances.Tables.Item("Advances").Clear()

        cmdCusadv.CommandText = "
SELECT [ornum]
      ,adv.[cuscde]
      ,[cusnam]
      ,[oramt]
      ,[orbal]
      ,[ordttm]
      ,[chkdttm]
      ,[chkno]
      ,[chkbnk]
      ,adv.[userid]
  FROM [Cusadv] as adv left join [Customer] as cus on adv.cuscde = cus.cuscde  "
        cmdCusadv.ActiveConnection = gcnnBilling
        rsCusadv.Open(cmdCusadv)
        dataAdap.Fill(dsAdvances.Tables.Item("Advances"), rsCusadv)

        rsCusadv.Close()
    End Sub
    Public Sub loadCustomer()
        dsAdvances.Tables.Item("Customers").Clear()

        cmdCusadv.CommandText = "
SELECT [cuscde]
      ,[cusnam]
  FROM [sbitcbilling].[dbo].[Customer]
"
        cmdCusadv.ActiveConnection = gcnnBilling
        rsCusadv.Open(cmdCusadv)
        dataAdap.Fill(dsAdvances.Tables.Item("Customers"), rsCusadv)

        rsCusadv.Close()
    End Sub

    Public Sub viewAdvances(ByRef drSelection As Object, ByRef dvAdvances As DataGridView)
        dvAdvances.Rows.Clear()
        dvAdvances.ClearSelection()

        For Each row As DataRow In drSelection
            Dim sysdttm As String
            Try
                sysdttm = dsAdvances.Tables.Item("Payments").Select("adrnum=" & row("ornum"))(0).Field(Of Object)("sysdttm")
            Catch
                sysdttm = "N/A"
            End Try
            dvAdvances.Rows.Add(row("ornum"),
                                row("cusnam"),
                                row("oramt"),
                                row("orbal"),
                                sysdttm)
        Next
        dvAdvances.Focus()
    End Sub

    Public Sub viewBalance(ByRef drSelection As Object, ByRef dvBalances As DataGridView)
        dvBalances.Rows.Clear()

        For Each drPay As DataRow In drSelection
            dvBalances.Rows.Add(drPay("Reference No."), drPay("adramt"), drPay("sysdttm"))
        Next
    End Sub

    Public Sub loadadrPay()
        dsAdvances.Tables.Item("Payments").Clear()

        cmdCusadv.CommandText = "
select [refnum] as 'Reference No.'
,[adramt]
,[adrnum]
,pay.[sysdttm]
from cympay pay 
where adramt > 0
union
select [refnum] as 'Reference No.'
,[adramt2]
,[adrnum2]
,pay.[sysdttm]
from cympay pay 
where adramt2 > 0
union
select [refnum] as 'Reference No.'
,[adramt3]
,[adrnum3]
,pay.[sysdttm]
from cympay pay 
where adramt3 > 0

union

select refnum as 'Reference No.'
,[adramt]
,[adrnum]
,pay.[sysdttm]
from ccrpay pay 
where adramt > 0
union
select refnum as 'Reference No.'
,[adramt2]
,[adrnum2]
,pay.[sysdttm]
from ccrpay pay 
where adramt2 > 0
union
select refnum as 'Reference No.'
,[adramt3]
,[adrnum3]
,pay.[sysdttm]
from ccrpay pay 
where adramt3 > 0


ORDER BY SYSDTTM DESC
"

        cmdCusadv.ActiveConnection = gcnnBilling
        rsCusadv.Open(cmdCusadv)
        dataAdap.Fill(dsAdvances.Tables.Item("Payments"), rsCusadv)

        rsCusadv.Close()
    End Sub
End Module
