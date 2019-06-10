﻿Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient

#Region "DTO-Users"
'table users
Public Class UsersDTO
    Private _user_id As Integer
    Private _user_name As String
    Private _user_first_name As String
    Private _user_last_name As String
    Private _user_email As String
    Private _user_password As String
    Private _user_status As Integer
    Private _user_created_at As Date
    Private _user_updated_at As Date

    Public Property User_name As String
        Get
            Return _user_name
        End Get
        Set(value As String)
            _user_name = value
        End Set
    End Property

    Public Property User_first_name As String
        Get
            Return _user_first_name
        End Get
        Set(value As String)
            _user_first_name = value
        End Set
    End Property

    Public Property User_last_name As String
        Get
            Return _user_last_name
        End Get
        Set(value As String)
            _user_last_name = value
        End Set
    End Property

    Public Property User_email As String
        Get
            Return _user_email
        End Get
        Set(value As String)
            _user_email = value
        End Set
    End Property

    Public Property User_password As String
        Get
            Return _user_password
        End Get
        Set(value As String)
            _user_password = value
        End Set
    End Property

    Public Property User_status As Integer
        Get
            Return _user_status
        End Get
        Set(value As Integer)
            _user_status = value
        End Set
    End Property

    Public Property User_created_at As Date
        Get
            Return _user_created_at
        End Get
        Set(value As Date)
            _user_created_at = value
        End Set
    End Property

    Public Property User_updated_at As Date
        Get
            Return _user_updated_at
        End Get
        Set(value As Date)
            _user_updated_at = value
        End Set
    End Property

    Public Property User_id As Integer
        Get
            Return _user_id
        End Get
        Set(value As Integer)
            _user_id = value
        End Set
    End Property
End Class
#End Region
#Region "CurrentUser"
Public Class Users
    Private Shared m_CurrentUser As UsersDTO
    Public Shared Property CurrentUser As UsersDTO
        Get
            Return m_CurrentUser
        End Get
        Set(ByVal value As UsersDTO)
            m_CurrentUser = value
        End Set
    End Property
End Class
#End Region
#Region "UserCollection"
Public Class UserCollection
    Inherits List(Of UsersDTO)
End Class
#End Region
#Region "User Status"
Public Enum User_status
    OK = 1
    Locked = 2
    NotExists = 3
End Enum
#End Region
#Region "DAL"
Public Class UsersDAL
    Private Shared Singleton As UsersDAL
    Public Shared Function GetInstance() As UsersDAL
        If Singleton Is Nothing Then
            Singleton = New UsersDAL()
        End If
        Return Singleton
    End Function
    Public Function GetUsers() As DataTable
        Dim dtUsers As DataTable = DBHelper.GetInstance.GetDataTable("select * from tblUsers")
        Return dtUsers
    End Function
    Public Function GetListUsers() As UserCollection
        Dim UserList As New UserCollection
        Dim Reader As MySqlDataReader = DBHelper.GetInstance.ExecuteReader("select * from tblUsers")

        While Reader.Read()
            Dim objUser As New UsersDTO With {
                .User_id = Reader("User_id").ToString(),
                .User_name = Reader("User_name").ToString(),
                .User_first_name = Reader("User_first_name").ToString(),
                .User_last_name = Reader("User_last_name").ToString(),
                .User_email = Reader("User_email").ToString(),
                .User_password = Reader("User_password").ToString(),
                .User_status = CInt(Reader("User_password")),
                .User_created_at = CDate(Reader("User_created_at")),
                .User_updated_at = CDate(Reader("User_updated_at"))
            }
            UserList.Add(objUser)
        End While

        Reader.Close()
        Return UserList

    End Function

    Public Function GetUserByID(user_id As Integer) As UsersDTO
        Dim ObjectUser As New UsersDTO
        Dim Reader As Object = DBHelper.GetInstance.ExecuteReader("select * from tblUsers where User_id = @User_id", New Object() {user_id})

        If Reader.Read() Then
            With ObjectUser
                .User_id = Reader("User_id").ToString()
                .User_name = Reader("User_name").ToString()
                .User_first_name = Reader("User_first_name").ToString()
                .User_last_name = Reader("User_last_name").ToString()
                .User_email = Reader("User_email").ToString()
                .User_password = Reader("User_password").ToString()
                .User_status = CInt(Reader("User_password"))
                .User_created_at = CDate(Reader("User_created_at"))
                .User_updated_at = CDate(Reader("User_updated_at"))
            End With
        End If

        Reader.Close()
        Return objectUser

    End Function

    Public Function GetUserByUserName(user_name As String) As UsersDTO
        Dim ObjectUser As New UsersDTO
        Dim Reader As Object = DBHelper.GetInstance.ExecuteReader("select * from tblUsers where User_name = @user_name", New Object() {user_name})

        If Reader.Read() Then
            With ObjectUser
                .User_id = Reader("User_id").ToString()
                .User_name = Reader("User_name").ToString()
                .User_first_name = Reader("User_first_name").ToString()
                .User_last_name = Reader("User_last_name").ToString()
                .User_email = Reader("User_email").ToString()
                .User_password = Reader("User_password").ToString()
                .User_status = CInt(Reader("User_status"))
                .User_created_at = CDate(Reader("User_created_at"))
                .User_updated_at = CDate(Reader("User_updated_at"))

            End With
        End If

        Reader.Close()
        Return ObjectUser

    End Function
    Public Function InsertUsers(Users As UsersDTO) As Boolean
        Dim SQL As String = String.Format("INSERT INTO tblUsers
	        (user_name, user_first_name, user_last_name, user_email, user_password, user_status, user_created_at, user_updated_at)
	        VALUES (@user_name, @user_first_name, @user_last_name, @user_email, @user_password, @user_status, @user_created_at, @user_updated_at)")
        Dim para As Object = New Object() {Users.User_name, Users.User_first_name, Users.User_last_name, Users.User_email, Users.User_password, Users.User_status, Users.User_created_at, Users.User_updated_at}
        Dim result As Integer = DBHelper.GetInstance.ExecuteNonQuery(SQL, para)
        Return result > 0
    End Function
    Public Function UpdateUsers(Users As UsersDTO) As Boolean
        Dim SQL As String = String.Format("UPDATE tblUsers
                                           SET user_name = @user_name,
                                               user_first_name = @user_first_name,
                                               user_last_name = @user_last_name,
                                               user_password = @user_password,
                                               user_email = @user_email,
                                               user_status = @user_status,
                                               user_updated_at = @user_updated_at,
                                               user_created_at = @user_created_at
                                           WHERE user_id = @user_id")
        Dim para As Object = {Users.User_name, Users.User_first_name, Users.User_last_name, Users.User_email, Users.User_password, Users.User_status, Users.User_created_at, Users.User_updated_at}
        Dim result As Integer = DBHelper.GetInstance.ExecuteNonQuery(SQL, para)
        Return result > 0
    End Function
    Public Function Login(ByVal userName As String, ByVal passWord As String, ByRef status As User_status) As UsersDTO
        'Dim query As String = "Select * from tblUsers where user_name = @userName AND user_password = @passWord"
        Dim objUser As UsersDTO = GetUserByUserName(userName)
        If objUser IsNot Nothing Then
            If objUser.User_password = passWord Then
                If objUser.User_status = 1 Then
                    status = User_status.OK
                Else
                    status = User_status.Locked
                End If
            Else
                status = User_status.NotExists
            End If
        Else
            status = User_status.NotExists
        End If

        Return objUser
    End Function
End Class
#End Region

#Region "User-BUS"
Public Class UsersBUS

    Private Shared Singleton As UsersBUS
    Public Shared Function GetInstance() As UsersBUS
        If (Singleton Is Nothing) Then
            Singleton = New UsersBUS()
        End If
        Return Singleton
    End Function

End Class
#End Region