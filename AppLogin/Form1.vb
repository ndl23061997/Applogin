Imports System.IO

Public Class Form1
    Dim db As New ADODB.Connection
    Dim rs As New ADODB.Recordset
    Dim dbEngine As DAO.DBEngine
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        rs = db.Execute("select * from tb_user")
        rs.MoveFirst()
        Dim rsuser As String
        Dim rspassword As String
        Dim usr As String
        Dim pass As String
        usr = Me.txtusername.Text.ToString
        pass = Me.txtpassword.Text.ToString
        Do While rs.EOF = False
            rsuser = rs.Fields("username").Value.ToString
            rspassword = rs.Fields("password").Value.ToString
            If rsuser = usr And rspassword = pass Then
                GoTo ctn
            End If
            rs.MoveNext()
        Loop
ctn:    If rs.EOF = True Then
            MsgBox("Tài khoản hoặc mật khẩu không đúng")
            Exit Sub
        Else
            MsgBox("Đăng nhập thành công")
        End If
        db.Close()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim path As String
        path = Directory.GetCurrentDirectory()
        With db
            .Provider = "Microsoft.ACE.OLEDB.12.0;"
            .ConnectionTimeout = 30
            .Mode = ADODB.ConnectModeEnum.adModeReadWrite
            .Open("data source=" & path & "\QLKTX_database.accde;Jet OLEDB:Database Password=ndl23061997")
        End With
    End Sub
End Class