Imports System.Drawing
Imports Confluent.Kafka
Imports MySql.Data.MySqlClient

Public Class viewstudent
    Dim conn As String = "server=localhost;user=root;password=;database=lms;port=3307"
    Dim con As New MySqlConnection(conn)
    Private Sub displaystudent()
        '  con.Open()
        Dim Query = "SELECT * FROM addstudentss WHERE 1"
        Dim cmd As New MySqlCommand(Query, con)
        '    Dim adapter As MySqlDataAdapter
        '    adapter = New MySqlDataAdapter(cmd)
        '    Dim ds As DataSet
        '    ds = New DataSet
        '    adapter.Fill(ds)
        cmd.ExecuteNonQuery()
        '    Guna2DataGridView1.DataSource = ds.Tables(0)
        '    '  cmd.Parameters.AddWithValue("@id", student_id)


        con.Close()
    End Sub
    Private Sub viewstudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Open()
        Dim query As String = "SELECT * FROM addstudentss"
        Dim adapter As New MySqlDataAdapter(query, con)
        Dim ds As New DataSet()
        adapter.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        con.Close()


    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        'con.Open()
        If String.IsNullOrWhiteSpace(txtname.Text) OrElse
                String.IsNullOrWhiteSpace(txtenroll.Text) OrElse
                String.IsNullOrWhiteSpace(txtdept.Text) OrElse
                String.IsNullOrWhiteSpace(txtsem.Text) OrElse
                String.IsNullOrWhiteSpace(txtcontact.Text) OrElse
                String.IsNullOrWhiteSpace(txtemail.Text) Then
            MsgBox("please fill required deatils")

        Else
            con.Open()
            Dim Query = "UPDATE addstudentss SET studentname=@studentname,enrollnmentnum=@enrollnmentnum,department=@department,semester=@semester,contact_num=@contact_num,student_email=@student_email WHERE student_id=@student_id"
            Dim cmd As New MySqlCommand(Query, con)
            cmd.Parameters.AddWithValue("@student_id", student_id)
            cmd.Parameters.AddWithValue("@studentname", txtname.Text)
            cmd.Parameters.AddWithValue("@enrollnmentnum", txtenroll.Text)
            cmd.Parameters.AddWithValue("@department", txtdept.Text)
            cmd.Parameters.AddWithValue("@semester", txtsem.Text)
            cmd.Parameters.AddWithValue("@contact_num", txtcontact.Text)
            cmd.Parameters.AddWithValue("@student_email", txtemail.Text)
            cmd.ExecuteNonQuery()
            MsgBox("Update Dta successfully")
            displaystudent()
            con.Close()


        End If

        con.Close()
    End Sub

    Private Sub txtsearch_MouseClick(sender As Object, e As MouseEventArgs) Handles txtsearch.MouseClick

    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        Dim searchtext = txtsearch.Text

        If txtsearch.Text = "" Then
            Dim myimage As Image
            myimage = Image.FromFile("C:/Users/Admin.GATEWAYLAP04/Pictures/CMS/search.gif")
            PictureBox1.Image = myimage



        Else
            Dim myimage As Image
            myimage = Image.FromFile("C:/Users/Admin.GATEWAYLAP04/Pictures/CMS/search1.gif")
            PictureBox1.Image = myimage
            con.Open()

            Dim Query = "SELECT * FROM addstudentss WHERE enrollnmentnum LIKE '" + txtsearch.Text + "%'"
            Dim cmd As New MySqlCommand(Query, con)
            Dim adapter As MySqlDataAdapter
            adapter = New MySqlDataAdapter(cmd)
            cmd.ExecuteNonQuery()
            Dim ds As DataSet
            ds = New DataSet
            adapter.Fill(ds)

            DataGridView1.DataSource = ds.Tables(0)
            con.Close()
        End If

    End Sub
    'Dim int As Integer
    'Dim rowid As Int64
    ' Dim Bid As String
    'Private Sub Guna2DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellClick
    '    If Guna2DataGridView1.Rows(e.RowIndex).Cells(0).Value IsNot Nothing Then
    '        Dim Bid As String = Guna2DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString()

    '        If e.RowIndex >= 0 AndAlso Guna2DataGridView1.Rows.Count > 0 Then
    '            Dim enrollnmentnum As String = Guna2DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
    '            ' If (e.RowIndex >= 0) Then


    '            con.Open()
    '            Dim Query = "SELECT * FROM addstudentss where enrollnmentnum=@enroll "
    '            Dim cmd As New MySqlCommand(Query, con)
    '            cmd.Parameters.AddWithValue("@enroll", Bid)
    '            Dim adapter As MySqlDataAdapter
    '            adapter = New MySqlDataAdapter(cmd)
    '            cmd.ExecuteNonQuery()
    '            Dim ds As DataSet
    '            ds = New DataSet
    '            adapter.Fill(ds)
    '            ' Guna2DataGridView1.DataSource = ds.Tables(0)
    '            Dim rowid = Int64.Parse(ds.Tables(0).Rows(0)(0).ToString())
    '            txtname.Text = ds.Tables(0).Rows(0)(1).ToString()



    '            con.Close()
    '        End If
    '    End If
    'End Sub
    Dim student_id As Integer
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Guna2PictureBox3_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox3.Click
        If MessageBox.Show("Are You Sure You Want To An Exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then

            Application.Exit()
        End If
    End Sub

    'Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
    '    con.Open()
    '    Dim Query = "DELETE FROM addstudentss WHERE student_id=@bid"
    '    Dim cmd As New MySqlCommand(Query, con)
    '    cmd.Parameters.AddWithValue("@bid", student_id)
    '    Dim adapter1 As New MySqlDataAdapter(cmd)
    '    cmd.ExecuteNonQuery()
    '    Dim dt As New DataSet
    '    adapter1.Fill(dt)
    '    DataGridView1.DataSource = dt.Tables(0)
    '    con.Close()
    'End Sub
    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Try
            If DataGridView1.SelectedRows.Count > 0 Then
                ' DataGridView me se student_id le lo
                Dim student_id As Integer = Convert.ToInt32(DataGridView1.SelectedRows(0).Cells("student_id").Value)

                con.Open()
                Dim Query As String = "DELETE FROM addstudentss WHERE student_id=@id"
                Dim cmd As New MySqlCommand(Query, con)
                cmd.Parameters.AddWithValue("@id", student_id)

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Row deleted successfully.")
                Else
                    MessageBox.Show("No row deleted.")
                End If
            Else
                MessageBox.Show("Please select a row to delete.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            con.Close()
            ' DataGridView refresh karna (taaki delete hone ke baad record gayab ho jaye)
            LoadData()
        End Try
    End Sub
    Public Sub loaddata()
        Dim Query As String = "SELECT * FROM addstudentss"
        Dim adapter As New MySqlDataAdapter(Query, con)
        Dim dt As New DataTable
        adapter.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub




    Private Sub DataGridView1_CellClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim cellValue = DataGridView1.Rows(e.RowIndex).Cells(0).Value

            If cellValue IsNot Nothing AndAlso Not IsDBNull(cellValue) Then
                ' Convert the cell value to Integer and assign to studentid
                student_id = Integer.Parse(cellValue.ToString())

                ' Optional: show the value to user
                MessageBox.Show("Selected Student ID: " & student_id.ToString())

                ' Show the panel
                Guna2Panel1.Visible = True

                ' Example: display related book data (if you want to show 1 book based on ID)
                con.Open()
                Dim query As String = "SELECT * FROM addstudentss WHERE student_id = @id"
                Dim cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@id", student_id)

                Dim reader As MySqlDataReader = cmd.ExecuteReader()


                If reader.Read() Then
                    txtname.Text = reader("studentname").ToString()
                    txtenroll.Text = reader("enrollnmentnum").ToString
                    txtdept.Text = reader("department").ToString
                    '  DateTimePicker1.Value = Convert.ToDateTime(reader("purchasedate")).ToString("yyyy-MM-dd HH:mm:ss")
                    txtsem.Text = reader("semester").ToString
                    txtcontact.Text = reader("contact_num").ToString
                    txtemail.Text = reader("student_email").ToString
                Else
                    MessageBox.Show("No book found with this ID.")
                End If

                con.Close()
            End If
        End If
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        If MessageBox.Show("Are You Sure You Want To An Exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then

            Application.Exit()
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        txtsearch.Text = ""
    End Sub
End Class
