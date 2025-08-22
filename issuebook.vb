
Imports System.Data
Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient
Imports Mysqlx.Crud

Public Class issuebook
    Dim conn As String = "server=localhost;user=root;password=;database=lms;port=3307"
    Dim con As New MySqlConnection(conn)


    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim bid As String = txtenroll.Text
        Try
            con.Open()

            Dim Query = "SELECT * FROM addstudentss WHERE enrollnmentnum = @enroll"
            Dim cmd As New MySqlCommand(Query, con)
            cmd.Parameters.AddWithValue("@enroll", bid)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim ds As New DataSet()
            adapter.Fill(ds)

            ''
            Dim Query1 = "SELECT count(enrollnmentnum) FROM issuebooks WHERE enrollnmentnum = @enrollnmentnum AND return_date is null"
            Dim cmd1 As New MySqlCommand(Query1, con)
            cmd.Parameters.AddWithValue("@enrollnmentnum", txtenroll.Text)
            cmd.ExecuteNonQuery()
            ''
            Dim row As DataRow = ds.Tables(0).Rows(0)
            txtname.Text = Row("studentname").ToString()
            txtdept.Text = Row("department").ToString()
            txtsem.Text = Row("semester").ToString()
            txtcontact.Text = row("contact_num").ToString()
            txtemail.Text = row("student_email").ToString()
            ' txtbook.Text = Row("bookname").ToString()
            '     txtdate.Text = Convert.ToDateTime(Row("issuedate")).ToString("yyyy-MM-dd")

            ' If ds.Tables(0).Rows..Count Is Nothing Then

            '

            'count = Int.Parse()

            '



            'End If
            con.Close()
        Catch ex As Exception
            MessageBox.Show("no student found with this enrollnment number.", CStr(MessageBoxIcon.Error))

        End Try

    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        ' MsgBox("hii")
        If txtenroll.Text IsNot "" Then     'Not String.IsNullOrEmpty(txtenroll.Text.Trim())


            '    ElseIf ComboBox1.SelectedItem <> -1 And count >= 0 Then
            Dim Name As String = txtname.Text
            Dim dept As String = txtdept.Text
            Dim sem As String = txtsem.Text
            Dim contact As String = txtcontact.Text
            Dim email As String = txtemail.Text
            Dim bookname As String = ComboBox1.Text
            Dim bookdate As String = txtdate.Text
            Dim enroll As String = txtenroll.Text
            con.Open()
            Dim Query As String = "INSERT INTO issuebooks (`enrollnmentnum`,`stud_name`,`stud_dept`,`stud_sem`,`stud_contact`,`stud_email`,`book_name`,`issue_date`) 
VALUES(@enrollnmentnum,@stud_name,@stud_dept,@stud_sem,@stud_contact,@stud_email,@book_name,@issue_date)"

            Using cmd As New MySqlCommand(Query, con)
                cmd.Parameters.AddWithValue("@enrollnmentnum", txtenroll.Text) ' student enrollment number textbox
                cmd.Parameters.AddWithValue("@stud_name", Name)            ' not just "Name"
                cmd.Parameters.AddWithValue("@stud_dept", dept)
                cmd.Parameters.AddWithValue("@stud_sem", sem)
                cmd.Parameters.AddWithValue("@stud_contact", contact)
                cmd.Parameters.AddWithValue("@stud_email", email)
                cmd.Parameters.AddWithValue("@book_name", bookname)            ' fixed spelling
                cmd.Parameters.AddWithValue("@issue_date", bookdate)

                cmd.ExecuteNonQuery()
                MessageBox.Show("Data Successfully Created")
            End Using

            con.Close()

        Else
            MessageBox.Show("Invalid Credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)


        End If

    End Sub

    Private Sub Guna2PictureBox3_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox3.Click
        If MessageBox.Show("Are You Sure You Want To An Exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then

            Application.Exit()
        End If
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        txtenroll.Text = ""
        txtname.Text = ""
        txtdept.Text = ""
        txtcontact.Text = ""  ' clear ComboBox
        txtsem.Text = ""  ' clear ComboBox
        txtemail.Text = ""
        ComboBox1.SelectedIndex = -1
        txtdate.Value = DateTime.Now
    End Sub



    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        MessageBox.Show("Are you sure want to exit?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        Me.Close()
    End Sub

    Private Sub issuebook_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class