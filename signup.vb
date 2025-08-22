
Imports System.Data.SqlClient
Imports System.Net.Http
Imports Newtonsoft.Json
Imports MySql.Data.MySqlClient

Imports System.Security.Policy
Imports System.Linq.Expressions
Imports System.Security.Cryptography.X509Certificates


Public Class signup
    Public conn As String = "server=localhost;user=root;password=;database=lms;port=3307"
    Dim con As New MySqlConnection(conn)

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click

        Dim username As String = txtuser.Text
        Dim password As String = txtpass.Text
        Dim con_password As String = txtconpass.Text

        If String.IsNullOrWhiteSpace(txtuser.Text) OrElse
            String.IsNullOrWhiteSpace(txtpass.Text) Or
            String.IsNullOrWhiteSpace(txtconpass.Text) Then

            MsgBox("Enter the Required Information")
        ElseIf txtpass.Text <> txtconpass.Text Then
            MsgBox("Password  Doesn't Match!! ")

        Else
            con.Open()
            Dim Query As String = "INSERT INTO signupp(user_name,user_password) VALUES (@username,@password)"
            Dim cmd As New MySqlCommand(Query, con)
            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@password", password)
            cmd.ExecuteNonQuery()
            MsgBox("Account Created Successfully")
            Reset()
            con.Close()




        End If

    End Sub

    Public Sub Reset()
        txtuser.Text = ""
        txtpass.Text = ""
        txtconpass.Text = ""
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim s As New login()
        s.Show()
        Me.Hide()
    End Sub
End Class