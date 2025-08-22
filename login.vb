Imports System.Net.Http
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI
Public Class login

    Public conn As String = "server=localhost;user=root;password=;database=lms;port=3307"
    Dim con As New MySqlConnection(conn)


    Private Async Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim username As String = txtuser1.Text
        Dim password As String = txtpass1.Text

        If String.IsNullOrWhiteSpace(txtuser1.Text) Or
            String.IsNullOrWhiteSpace(txtpass1.Text) Then
            MsgBox("Enter the required information")
        Else
            Dim url As String = "http://localhost/lms/sign_up.php"
            Using client As New HttpClient()
                Dim values = New Dictionary(Of String, String) From {
                {"username", username},
                {"userpassword", password}
                }

                Dim content = New FormUrlEncodedContent(values)
                Dim response = Await client.PostAsync(url, content)
                Dim result = Await response.Content.ReadAsStringAsync()


                If result = 1 Then
                    MsgBox("Login successful")
                    Dim s As New Dashboard
                    s.Show()
                    'Me.Hide()


                ElseIf result.Trim() = "2" Then
                    MsgBox("Invalid ")


                End If


            End Using


        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim ds As New signup
        ds.Show()
        Me.Hide()
    End Sub
End Class


