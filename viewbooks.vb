Imports System.Security.Cryptography
Imports Confluent.Kafka
Imports System.Globalization
Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient
Imports MySql.Data.Types
Imports System.Data.SqlClient

Public Class viewbooks
    Dim conn As String = "server=localhost;user=root;password=;database=lms;port=3307;Allow Zero Datetime=True;Convert Zero Datetime=True;"
    Dim con As New MySqlConnection(conn)
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim bookname As String = txtname.Text
        Dim authorname As String = txtauthorname.Text
        Dim publicationname As String = txtpublicationname.Text
        '       Dim purchasedate As DateTime = Guna2ComboBox.Value
        ' Dim datetime As String = Guna2ComboBox.
        Dim bookprice As String = txtbookprice.Text
        Dim bookquantity As String = txtquantity.Text
        Dim purchasedate As DateTime = DateTimePicker1.Value
        Dim format As String = "yyyy-MM-dd HH:mm:ss"
        If purchasedate = DateTime.Today Then
            MsgBox("Please select a valid purchase date", MsgBoxStyle.Exclamation, "Missing Date")
            Exit Sub
        End If
        If purchasedate = DateTime.Today Then ' or any logic to check valid date
            MsgBox("Please select a valid purchase date", MsgBoxStyle.Exclamation, "Missing Date")
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(txtname.Text) OrElse
                    String.IsNullOrWhiteSpace(txtauthorname.Text) OrElse
                    String.IsNullOrWhiteSpace(txtpublicationname.Text) OrElse ' DateTimePicker1.Value = defaultDate OrElse
               Not IsNumeric(txtbookprice.Text) OrElse
                  Not IsNumeric(txtquantity.Text) Then
            MsgBox("Please Filled the required Informatiion")

        Else
            con.Open()
            Dim Query = "UPDATE addbookss SET `bookname`=@bookname,`authorname`=@authorname,`publicationname`=@publicationname,`bookprice`=@bookprice,`bookquantity`=@bookquantity WHERE id=@id"  '`purchasedate`=@purchasedate,
            Dim cmd As New MySqlCommand(Query, con)
            cmd.Parameters.AddWithValue("@id", id)
            cmd.Parameters.AddWithValue("@bookname", txtname.Text)
            cmd.Parameters.AddWithValue("@authorname", txtauthorname.Text)
            cmd.Parameters.AddWithValue("@publicationname", txtpublicationname.Text)
            'cmd.Parameters.AddWithValue("@purchasedate", publicationdate.ToString("yyyy-MM-dd HH:mm:ss"))
            cmd.Parameters.AddWithValue("@bookprice", txtbookprice.Text)
            cmd.Parameters.AddWithValue("@bookquantity", txtquantity.Text)
            cmd.ExecuteNonQuery()
            MsgBox("Update Data Successfully")

            con.Close()


        End If
    End Sub

    Private Sub viewbooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Guna2Panel3.Visible = False
        con.Open()
        Dim query As String = "SELECT * FROM addbookss"
        Dim adapter As New MySqlDataAdapter(query, con)
        Dim ds As New DataSet()
        adapter.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        con.Close()
    End Sub
    Dim id As Integer
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    ' Private Sub Guna2Button3_Click(sender As Object, e As EventArgs)

    ' End Sub

    Private Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Guna2PictureBox3_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox3.Click
        If MessageBox.Show("Are You Sure You Want To An Exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then

            Application.Exit()
        End If
    End Sub

    Private Sub DataGridView1_CellClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        ' Make sure a valid row is clicked (not the header)
        If e.RowIndex >= 0 Then
            Dim cellValue = DataGridView1.Rows(e.RowIndex).Cells(0).Value

            If cellValue IsNot Nothing AndAlso Not IsDBNull(cellValue) Then
                ' Convert the cell value to Integer and assign to studentid
                id = Integer.Parse(cellValue.ToString())

                ' Optional: show the value to user
                MessageBox.Show("Selected Student ID: " & id.ToString())

                ' Show the panel
                Guna2Panel1.Visible = True

                ' Example: display related book data (if you want to show 1 book based on ID)
                con.Open()
                Dim query As String = "SELECT * FROM addbookss WHERE id = @id"
                Dim cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@id", id)

                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                'If Not IsDBNull(reader("purchasedate")) Then
                '    Guna2ComboBox.Value = Convert.ToDateTime(reader("purchasedate"))
                'Else
                '    Guna2ComboBox.Value = DateTime.Today ' or any default value
                'End If

                If reader.Read() Then
                    txtname.Text = reader("bookname").ToString()
                    txtauthorname.Text = reader("authorname").ToString
                    txtpublicationname.Text = reader("publicationname").ToString
                    '  DateTimePicker1.Value = Convert.ToDateTime(reader("purchasedate")).ToString("yyyy-MM-dd HH:mm:ss")
                    txtbookprice.Text = Convert.ToInt32(reader("bookprice")).ToString
                    txtquantity.Text = Convert.ToInt32(reader("bookquantity")).ToString
                Else
                    MessageBox.Show("No book found with this ID.")
                End If

                con.Close()
            End If
        End If
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged



        con.Open()
        Dim query = "SELECT * FROM addbookss WHERE bookname LIKE '" + txtsearch.Text + "%'"
        Dim cmd As New MySqlCommand(query, con)
            Dim adpater As New MySqlDataAdapter(cmd)
            cmd.ExecuteNonQuery()
            Dim ds As New DataSet
            adpater.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
            con.Close()

    End Sub

    Private Sub Guna2Button3_Click_1(sender As Object, e As EventArgs) Handles Guna2Button3.Click

    End Sub
    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Try
            If DataGridView1.SelectedRows.Count > 0 Then

                Dim student_id As Integer = Convert.ToInt32(DataGridView1.SelectedRows(0).Cells("id").Value)

                con.Open()
                Dim Query As String = "DELETE FROM addbookss WHERE id=@id"
                Dim cmd As New MySqlCommand(Query, con)
                cmd.Parameters.AddWithValue("@id", id)

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

            LoadData()
        End Try
    End Sub

    Private Sub LoadData()
        Dim Query As String = "SELECT * FROM addbookss"
        Dim adapter As New MySqlDataAdapter(Query, con)
        Dim dt As New DataTable
        adapter.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Me.Hide()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        txtsearch.Text = ""
    End Sub
End Class