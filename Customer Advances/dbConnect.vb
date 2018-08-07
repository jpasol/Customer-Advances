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
        ''''''''''''''''''''''''''''''''''''''''''''

        '''''''''''Rename DataTables''''''''''''''''
        dtAdvances.TableName = "Advances"
        dtCustomers.TableName = "Customers"
        ''''''''''''''''''''''''''''''''''''''''''''

        ''''''''''''''Add DataTable'''''''''''''''''
        dsAdvances.Tables.Add(dtAdvances)
        dsAdvances.Tables.Add(dtCustomers)
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

        For Each row As DataRow In drSelection
            dvAdvances.Rows.Add(row("ornum"), row("cusnam"), row("oramt"), row("orbal"), "N/A")
        Next
        dvAdvances.Focus()
    End Sub
End Module
