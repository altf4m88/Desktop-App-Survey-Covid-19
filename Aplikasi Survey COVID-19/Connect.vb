
Imports System.Data.OleDb
Module Connect
    Public conn As OleDbConnection
    Public CMD As OleDbCommand
    Public DS As New DataSet
    Public DA As OleDbDataAdapter
    Public RD As OleDbDataReader
    Public datalocation As String


    Public Sub konek()
        datalocation = "provider=microsoft.jet.oledb.4.0;data source=Survey.mdb"
        conn = New OleDbConnection(datalocation)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        Else
            MsgBox("Koneksi Gagal")
        End If
    End Sub
    

End Module

