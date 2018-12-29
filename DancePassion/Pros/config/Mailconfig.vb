﻿Imports System.Net.Mail
Imports MySql.Data.MySqlClient
Imports DancePassion.MYSQLSERVER

Namespace MailConfig

#Region "DTO"
    Public Class DTO
        Private _server As String

        Private _port As Integer

        Private _user As String

        Private _pwd As String

        Private _ssl As Boolean
        Public Property server As String
            Get
                Return _server
            End Get
            Set(ByVal value As String)
                _server = value
            End Set
        End Property

        Public Property port As Integer
            Get
                Return _port
            End Get
            Set(ByVal value As Integer)
                _port = value
            End Set
        End Property

        Public Property user As String
            Get
                Return _user
            End Get
            Set(ByVal value As String)
                _user = value
            End Set
        End Property

        Public Property pwd As String
            Get
                Return _pwd
            End Get
            Set(ByVal value As String)
                _pwd = value
            End Set
        End Property

        Public Property ssl As Boolean
            Get
                Return _ssl
            End Get
            Set(ByVal value As Boolean)
                _ssl = value
            End Set
        End Property
        Public Sub New()
        End Sub

        Public Sub New(ByVal server As String, ByVal port As Integer, ByVal user As String, ByVal pwd As String, ssl As Boolean)
            Me.server = server
            Me.port = port
            Me.user = server
            Me.pwd = pwd
            Me.ssl = ssl
        End Sub
    End Class
#End Region
#Region "DAL"
    Public Class DAL
        Private fn As New MYSQLSERVER

        Public Function _Get() As DataTable

            Dim dt As New DataTable

            Try
                fn.conn.Open()
                Dim da As New MySqlDataAdapter("select * from mailConfig", fn.conn)
                da.Fill(dt)
                fn.conn.Close()
            Catch e As Exception
                MessageBox.Show(e.Message)
            Finally

            End Try

            Return dt
        End Function

        Public Function _Add(ByVal mailconfig As DTO) As Boolean
            fn.conn.Open()
            Dim da As New MySqlDataAdapter("select * from mailConfig", fn.conn)
            Dim dt As New DataTable
            da.Fill(dt)
            Dim cb As New MySqlCommandBuilder(da)
            Dim cbi = cb.GetInsertCommand
            Dim tr As MySqlTransaction = fn.conn.BeginTransaction
            cbi.Transaction = tr
            Try
                Dim r As DataRow = dt.NewRow
                r("server") = mailconfig.server
                r("port") = mailconfig.port
                r("user") = mailconfig.user
                r("pwd") = mailconfig.pwd
                r("ssl") = mailconfig.ssl
                dt.Rows.Add(r)
                da.Update(dt)
                tr.Commit()

                Return True
            Catch e As Exception
                MessageBox.Show(e.Message)
                tr.Rollback()
                Return False
            Finally
                fn.conn.Close()
            End Try

        End Function

    End Class
#End Region
#Region "BUS"
    Public Class BUS
        Private dal As DAL = New DAL()

        Public Function _get() As DataTable
            Return dal._Get()
        End Function

        Public Function _add(ByVal mailConfig As DTO) As Boolean
            Return dal._Add(mailConfig)
        End Function

    End Class
#End Region
End Namespace