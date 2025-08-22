Imports MySql.Data.MySqlClient
Imports System.DateTime

Public Class combkdet
    Dim conn As String = "server=localhost;user=root;password=;database=lms;port=3307;Allow Zero Datetime=True;Convert Zero Datetime=True;"
    Dim con As New MySqlConnection(conn)
    Private Sub combkdet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Open()
        Dim Query = "SELECT bid,enrollnmentnum,stud_name,stud_dept,stud_sem,stud_contact,stud_email,book_name,issue_date FROM issuebooks "
        Dim cmd As New MySqlCommand(Query, con)
        Dim adapter As New MySqlDataAdapter(cmd)
        cmd.ExecuteNonQuery()
        Dim ds As New DataSet
        adapter.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        con.Close()


        con.Open()
        Dim Query1 = "SELECT bid,enrollnmentnum,stud_name,stud_dept,stud_sem,stud_contact,stud_email,book_name,return_date FROM issuebooks "
        Dim cmd1 As New MySqlCommand(Query1, con)
        Dim adapter1 As New MySqlDataAdapter(cmd1)
        cmd1.ExecuteNonQuery()
        Dim ds1 As New DataSet
        adapter1.Fill(ds1)
        DataGridView2.DataSource = ds1.Tables(0)
        con.Close()
    End Sub

    Private Sub Guna2PictureBox3_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox3.Click
        If MessageBox.Show("Are You Sure You Want To An Exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then

            Application.Exit()
        End If
    End Sub
End Class