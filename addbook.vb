
Imports MySql.Data.MySqlClient

Public Class addbook
    Public conn As String = "server=localhost;user=root;password=;database=lms;port=3307"
    Dim con As New MySqlConnection(conn)
    Private Sub Guna2PictureBox3_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox3.Click
        If MessageBox.Show("Are You Sure You Want To An Exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then

            Application.Exit()
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim bookname As String = txtname.Text
        Dim authorname As String = txtauthorname.Text
        Dim publicationname As String = txtpublication.Text
        'Dim purchasedate = txtdate.Value.ToString(" yyyy-MM-dd")
        Dim purchasedate As Date = txtdate.Value
        Dim bookprice As String = txtprice.Text
        Dim bookquantity As String = txtquantity.Text
        If Not txtdate.Checked Then
            MsgBox("Please select a valid purchase date", MsgBoxStyle.Exclamation, "Missing DAte")
            Exit Sub
        End If


        If String.IsNullOrWhiteSpace(bookname) OrElse
           String.IsNullOrWhiteSpace(authorname) OrElse
           String.IsNullOrWhiteSpace(publicationname) OrElse
           Not IsNumeric(bookprice) OrElse
           Not IsNumeric(bookquantity) Then
            MsgBox("Enter the Required Info!!!")
        Else
            Try
                con.Open()
                Dim Query As String = "INSERT INTO addbookss(`bookname`,`authorname`,`publicationname`,`purchasedate`,`bookprice`,`bookquantity`) " &
                      "VALUES (@namebook,@authorname,@publication,@purchasedate,@bookprice,@bookquantity)"
                Dim cmd As New MySqlCommand(Query, con)

                cmd.Parameters.AddWithValue("@namebook", bookname)
                cmd.Parameters.AddWithValue("@authorname", authorname)
                cmd.Parameters.AddWithValue("@publication", publicationname)
                cmd.Parameters.AddWithValue("@purchasedate", purchasedate) 'No need to convert to string
                cmd.Parameters.AddWithValue("@bookprice", Convert.ToDecimal(bookprice))
                cmd.Parameters.AddWithValue("@bookquantity", Convert.ToInt32(bookquantity))
                cmd.ExecuteNonQuery()

                MsgBox("Book Added Successfully", MsgBoxStyle.Information, "Success")

                con.Close()
            Catch ex As Exception
                MsgBox("Error:" & ex.message)
            End Try

        End If
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Me.Close()
    End Sub

    Private Sub Guna2Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel2.Paint

    End Sub
End Class