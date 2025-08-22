Imports Confluent.Kafka
Imports MySql.Data.MySqlClient

Public Class returnbook
    Dim conn As String = "server=localhost;user=root;password=;database=lms;port=3307"
    Dim con As New MySqlConnection(conn)
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        con.Open()
        If txtenroll.Text = "" Then
            MessageBox.Show("Invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim Query = "SELECT * FROM issuebooks WHERE enrollnmentnum='" + txtenroll.Text + "'"
            Dim cmd As New MySqlCommand(Query, con)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim ds As DataSet
            ds = New DataSet
            adapter.Fill(ds)
            cmd.ExecuteNonQuery()
            DataGridView1.DataSource = ds.Tables(0)
            Dim row As DataRow = ds.Tables(0).Rows(0)

        End If
        con.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Application.Exit()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        txtenroll.Text = ""
    End Sub

    Private Sub txtenroll_TextChanged(sender As Object, e As EventArgs) Handles txtenroll.TextChanged

    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
    Dim rowid As Int32
    Dim bdate As DateTime
    Dim bkname As String
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            rowid = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
            bkname = DataGridView1.Rows(e.RowIndex).Cells(7).Value.ToString
            bdate = DataGridView1.Rows(e.RowIndex).Cells(8).Value.ToString
            txtname.Text = bkname
            Guna2DateTimePicker1.Text = bdate
        End If
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Try
            ' Null ya empty checks
            If String.IsNullOrWhiteSpace(txtenroll.Text) Then
                MessageBox.Show("Please select a student first.")
                Exit Sub
            End If

            If rowid = 0 Then
                MessageBox.Show("Please select a record from the table.")
                Exit Sub
            End If

            If Guna2DateTimePicker1 Is Nothing Then
                MessageBox.Show("Date picker not initialized.")
                Exit Sub
            End If

            con.Open()
            Dim query As String = "UPDATE issuebooks SET return_date=@return_date WHERE enrollnmentnum=@enrollnmentnum AND bid=@bid"
            Dim cmd As New MySqlCommand(query, con)

            cmd.Parameters.AddWithValue("@return_date", Guna2DateTimePicker1.Value)
            cmd.Parameters.AddWithValue("@enrollnmentnum", txtenroll.Text)
            cmd.Parameters.AddWithValue("@bid", rowid)

            Dim rows As Integer = cmd.ExecuteNonQuery()

            If rows > 0 Then
                MessageBox.Show("Return date updated successfully!")
            Else
                MessageBox.Show("No record found to update.")
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Guna2PictureBox3_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox3.Click
        If MessageBox.Show("Are You Sure You Want To An Exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then

            Application.Exit()
        End If
    End Sub
End Class