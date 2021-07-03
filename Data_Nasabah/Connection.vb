Imports System.Data.Odbc
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Module Connection
    Public conn As OdbcConnection
    Public cmd As New OdbcCommand
    Public dr As OdbcDataReader
    Public da As OdbcDataAdapter
    Public ds As New DataSet
    Public dt As DataTable
    Public str As String

    'Crystal Report'
    Public tli As TableLogOnInfo
    Public tlis As TableLogOnInfos
    Public ci As ConnectionInfo

    Public Sub Koneksi()
        Try
            Dim str As String
            str = "Dsn=DSN_PeminjamanDana;server=localhost;uid=root;database=peminjaman_dana;port=3306"
            conn = New OdbcConnection(str)
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub

    'Koneksi Laporan Crystal Report'
    Sub laporan()
        With ci
            .ServerName = "Dsn=DSN_PeminjamanDana;server=localhost;uid=root;database=peminjaman_dana;port=3306"
            .DatabaseName = "Peminjaman_Dana"
            .UserID = "root"
            .Password = ""
        End With
    End Sub

End Module
