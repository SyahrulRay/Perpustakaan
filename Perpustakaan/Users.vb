Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Common
Imports Org.BouncyCastle.Utilities

Public Class Users
    Private TripleDes As New TripleDESCryptoServiceProvider
    Private dataUser As New ArrayList()
    Private Username As String
    Private Pass As String

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlComm As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username_db As String = "root"
    Private password_db As String = ""
    Private database As String = "perpustakaan"

    Public Sub New()
        dataUser.Add({"Admin", EncryptData(1234)})
    End Sub
    Public Function EncryptData(ByVal PlainText As String) As String
        Dim plainTextBytes() As Byte = System.Text.Encoding.Unicode.GetBytes(PlainText)

        Dim ms As New System.IO.MemoryStream

        Dim encStream As New CryptoStream(ms, TripleDes.CreateEncryptor(),
                                          System.Security.Cryptography.CryptoStreamMode.Write)

        encStream.Write(plainTextBytes, 0, plainTextBytes.Length)
        encStream.FlushFinalBlock()

        Return Convert.ToBase64String(ms.ToArray)
    End Function

    'Public Function CheckAuth(username As String, ByVal plainPassword As String) As Boolean
    '    'Dim realPass As String = EncryptData(1234)
    '    'Dim dataUser As ArrayList = New ArrayList()
    '    'dataUser.Add({"Syahrul", EncryptData(1234)})
    '    'dataUser.Add({"Jordi", EncryptData(4321)})
    '    'dataUser.Add({"Dzaky", EncryptData(258)})

    '    For Each user In dataUser
    '        If String.Compare(username, user(0)) = 0 And String.Compare(EncryptData(plainPassword), user(1)) = 0 Then
    '            Return True

    '        End If
    '    Next
    '    Return False
    'End Function


    Public Function EncryptMD5(ByVal Password As String)
        Dim x As New System.Security.Cryptography.MD5CryptoServiceProvider()
        Dim bs As Byte() = System.Text.Encoding.UTF8.GetBytes(Password)
        bs = x.ComputeHash(bs)
        Dim s As New System.Text.StringBuilder()
        For Each b As Byte In bs
            s.Append(b.ToString("x2").ToLower())
        Next
        Return s.ToString()
    End Function

    Public Function AddUserDatabase(username_regist As String, password_regist As String)
        Try
            Dim today = Date.Now()

            dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username_db + ";" + "password = " _
            + password_db + ";" + "database = " + database + ";" + "convert zero datetime=True"
            dbConn.Open()
            sqlComm.Connection = dbConn
            sqlQuery = " INSERT INTO USER(USERNAME, PASSWORD, REGISTERED_AT) VALUES(
                                    '" & username_regist & "',
                                    '" & EncryptMD5(password_regist) & "',
                                    '" & today.ToString("yyyy/MM/dd") & "')"

            Debug.WriteLine(sqlQuery)
            sqlComm = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlComm.ExecuteReader

            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function


    Public Function CheckAuth(username_Login As String, password_Login As String)
        Try
            Dim result As New List(Of String)

            dbConn.ConnectionString = "server = " + server + ";" + "user id = " + username_db + ";" + "password = " _
            + password_db + ";" + "database = " + database + ";" + "convert zero datetime=True"
            dbConn.Open()
            sqlComm.Connection = dbConn
            Dim queryAuth = "SELECT ID_USER, USERNAME FROM USER 
                                    WHERE USERNAME = '" & username_Login & "' AND PASSWORD = '" & EncryptMD5(password_Login) & "'"

            sqlComm.CommandText = queryAuth
            Debug.WriteLine(queryAuth)
            sqlRead = sqlComm.ExecuteReader


            If sqlRead.HasRows Then
                While sqlRead.Read
                    result.Add(sqlRead.GetString(0).ToString())
                    result.Add(sqlRead.GetString(1).ToString())
                End While
            End If
            sqlRead.Close()
            dbConn.Close()
            Return result
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        Finally
            dbConn.Dispose()
        End Try
    End Function
    Public Sub addData(
                           Username As String,
                           Pass As String)
        dataUser.Add({Username,
                     EncryptData(Pass)})

    End Sub
    Public ReadOnly Property GetData As ArrayList
        Get
            Return dataUser
        End Get
    End Property

    Public Property GSUsername As String
        Get
            Return Username
        End Get
        Set(value As String)
            Username = value
        End Set
    End Property

    Public Property GSPass As String
        Get
            Return Pass
        End Get
        Set(value As String)
            Pass = value
        End Set
    End Property
End Class
