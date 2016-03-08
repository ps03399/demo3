Imports System.Data.SqlClient
Imports System.Data
Public Class Class1
    Public Function Loadkhachang() As DataSet
        Dim chuoiketnoi As String = "workstation id=testps03399.mssql.somee.com;packet size=4096;user id=teo0975665809_SQLLogin_1;pwd=7b9qf5c8fx;data source=testps03399.mssql.somee.com;persist security info=False;initial catalog=testps03399"
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim LoadKH As New SqlDataAdapter("select MAKH as 'Mã KH' ,TENKH as 'Tên Khách Hàng', DIACHI as 'Địa chỉ', SDT as 'SĐT', EMAIL from KHACHANG", conn)
        Dim db As New DataSet
        conn.Open()
        LoadKH.Fill(db)
        conn.Close()
        Return db
    End Function
    Public Function Loadsanpham() As DataSet
        Dim chuoiketnoi As String = "workstation id=testps03399.mssql.somee.com;packet size=4096;user id=teo0975665809_SQLLogin_1;pwd=7b9qf5c8fx;data source=testps03399.mssql.somee.com;persist security info=False;initial catalog=testps03399"
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim LoadSP As New SqlDataAdapter("select * from SANPHAM1", conn)
        Dim db As New DataSet
        conn.Open()
        LoadSP.Fill(db)
        conn.Close()
        Return db
    End Function
End Class
