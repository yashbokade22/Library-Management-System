Imports System.Linq.Expressions

Public Class Dashboard
    Private Sub CompleteBooksDetailDetailToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompleteBooksDetailDetailToolStripMenuItem.Click
        Dim ds As New returnbook
        ds.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        If MessageBox.Show("Are You Sure You Want To An Exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then

            Application.Exit()
        End If

    End Sub

    Private Sub AddNewBookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewBookToolStripMenuItem.Click
        Dim s As New addbook
        s.Show()
    End Sub

    Private Sub AddNewStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewStudentToolStripMenuItem.Click
        Dim s As New addstudent
        s.Show()
    End Sub

    Private Sub ViewBooksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewBooksToolStripMenuItem.Click
        Dim s As New viewbooks
        s.Show()
    End Sub

    Private Sub ViewStudentInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewStudentInfoToolStripMenuItem.Click
        Dim vc As New viewstudent
        vc.Show()
    End Sub

    Private Sub IssueBooksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IssueBooksToolStripMenuItem.Click
        Dim ds As New issuebook
        ds.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim ds As New combkdet
        ds.Show()
    End Sub
End Class