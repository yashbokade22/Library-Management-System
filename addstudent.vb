

Imports MySql.Data.MySqlClient

Public Class addstudent
    Dim conn As String = "server=localhost;user=root;password=;database=lms;port=3307"
    Dim con As New MySqlConnection(conn)
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim studentname = txtstudentname.Text
        Dim enrollnmentnum = txtenrolnmentnumber.Text
        Dim dept = txtdept.SelectedItem?.ToString()
        Dim sem = txtsem.SelectedItem?.ToString()
        Dim contact = txtcontactnum.Text
        Dim email = txtemail.Text


        If String.IsNullOrWhiteSpace(studentname) OrElse
            String.IsNullOrWhiteSpace(enrollnmentnum) OrElse
            txtdept.SelectedItem Is Nothing OrElse
            txtsem.SelectedItem Is Nothing OrElse
            String.IsNullOrWhiteSpace(contact) OrElse
            String.IsNullOrWhiteSpace(email) Then

            MessageBox.Show("Please Fill Empty Fields!!!", "Suggest", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            Try
                con.Open()
                Dim Query = "INSERT INTO addstudentss(`studentname`,`enrollnmentnum`,`department`,`semester`,`contact_num`,`student_email`)VALUES (@studentname ,@enrollnmentnum ,@dept,@sem ,@contact, @email)"
                Dim cmd As New MySqlCommand(Query, con)
                cmd.Parameters.AddWithValue("@studentname", studentname)
                cmd.Parameters.AddWithValue("@enrollnmentnum", enrollnmentnum)
                cmd.Parameters.AddWithValue("@dept", dept)
                cmd.Parameters.AddWithValue("@sem", sem)
                cmd.Parameters.AddWithValue("@contact", contact)
                cmd.Parameters.AddWithValue("@email", email)
                cmd.ExecuteNonQuery()
                MsgBox("Student Data Stored Successfully")
                Refresh()
                con.Close()
            Catch ex As Exception
                MsgBox("Error :" & ex.Message)
            End Try
        End If

    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Refresh()
        '      txtdept.Text = "" OrElse
        'txtsem.Text = "" OrElse



    End Sub

    Public Sub Refresh()
        txtstudentname.Text = ""
        txtenrolnmentnumber.Text = ""
        txtdept.SelectedIndex = -1    ' clear ComboBox
        txtsem.SelectedIndex = -1     ' clear ComboBox
        txtcontactnum.Text = ""
        txtemail.Text = ""
    End Sub


    Private Sub Guna2Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel2.Paint

    End Sub

    Private Sub addstudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Guna2PictureBox3_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox3.Click
        If MessageBox.Show("Are You Sure You Want To An Exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then

            Me.Hide()
        End If
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        If MessageBox.Show("Are You Sure You Want To An Exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then

            Me.Close()
        End If
    End Sub
End Class