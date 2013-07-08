Imports System.Data.SqlClient
Public Class Server1
    Private sConnection As String = ""
    Private dbQuery As String = ""
    Private dataTable As DataTable = New DataTable()
    Private dataTable1 As DataTable = New DataTable()
    Private dataSet As New DataSet
    Private command As SqlCommand
    Private conn As SqlConnection
    Private dataAdapt As SqlDataAdapter
    Private dataAdapt2 As SqlDataAdapter
    
    Public ReadOnly Property theData() As DataTable
        Get
            Return dataTable
        End Get
    End Property

    Public Sub New(ByVal connect As String)
        sConnection = connect
    End Sub

    Public Function runQuery(ByVal quary As String, ByVal isNew As Boolean) As DataTable
        conn = New SqlConnection(sConnection)
        command = New SqlCommand(quary, conn)
        dataAdapt = New SqlDataAdapter(quary, conn)
        If Not isNew Then
            fillDT(conn, command, dataAdapt, dataTable)
            dataAdapt.Dispose()
            Return dataTable
        Else
            dataAdapt2 = New SqlDataAdapter(quary, conn)
            conn.Open()
            Dim cmdBuilder As New SqlCommandBuilder(dataAdapt2)
            dataAdapt2.Fill(dataSet, "PAPSIZE")
            dbQuery = quary
            conn.Close()
            Return dataSet.Tables("PAPSIZE")
        End If
    End Function

    Private Sub fillDT(ByRef conn As SqlConnection, ByRef command As SqlCommand, ByRef dataAdapt As SqlDataAdapter _
                            , ByRef dt As DataTable)
        dt.Clear()
        conn.Open()
        dataAdapt.Fill(dt)
        command.Dispose()
        conn.Close()
    End Sub

    Public Sub reset()
        dataAdapt2.Dispose()
        command.Dispose()
        dataSet.Tables.Clear()
    End Sub

    Public Sub updateDataBase(ByRef arr As ArrayList, ByRef cus As ArrayList)
        conn.Open()
        Dim int As Integer = 0
        For Each i As Integer In arr
            Dim cmd As New SqlCommand("Update PAPSIZE SET [MIN LEVEL] = '" & i & "' WHERE [CODE] = '" & cus(int) & "' ", conn)
            dataAdapt2.UpdateCommand = cmd
            dataAdapt2.Update(dataSet, "PAPSIZE")
            int += 1
        Next

        conn.Close()
    End Sub

    Public Function getCodeNum() As Int32
        Dim res As Int32
        res = dataSet.Tables("PAPSIZE").Rows(0).Item(0)
        MessageBox.Show(res)
        Return res
    End Function

End Class
