<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewBookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewBooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewStudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewStudentInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IssueBooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompleteBooksDetailDetailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Guna2ContextMenuStrip1 = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.DashboardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IssuebookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.Guna2ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Wheat
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.StudentToolStripMenuItem, Me.IssueBooksToolStripMenuItem, Me.CompleteBooksDetailDetailToolStripMenuItem, Me.ExitToolStripMenuItem, Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ExitToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(842, 58)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewBookToolStripMenuItem, Me.ViewBooksToolStripMenuItem})
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem1.Image = Global.LMS.My.Resources.Resources.icons8_books_501
        Me.ToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(101, 54)
        Me.ToolStripMenuItem1.Text = "Books"
        '
        'AddNewBookToolStripMenuItem
        '
        Me.AddNewBookToolStripMenuItem.Image = Global.LMS.My.Resources.Resources.icons8_add_book_48
        Me.AddNewBookToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AddNewBookToolStripMenuItem.Name = "AddNewBookToolStripMenuItem"
        Me.AddNewBookToolStripMenuItem.Size = New System.Drawing.Size(187, 56)
        Me.AddNewBookToolStripMenuItem.Text = "Add New Book"
        '
        'ViewBooksToolStripMenuItem
        '
        Me.ViewBooksToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewBooksToolStripMenuItem.Image = Global.LMS.My.Resources.Resources.icons8_view_501
        Me.ViewBooksToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ViewBooksToolStripMenuItem.Name = "ViewBooksToolStripMenuItem"
        Me.ViewBooksToolStripMenuItem.Size = New System.Drawing.Size(187, 56)
        Me.ViewBooksToolStripMenuItem.Text = "View Books"
        '
        'StudentToolStripMenuItem
        '
        Me.StudentToolStripMenuItem.BackColor = System.Drawing.Color.Linen
        Me.StudentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewStudentToolStripMenuItem, Me.ViewStudentInfoToolStripMenuItem})
        Me.StudentToolStripMenuItem.Image = Global.LMS.My.Resources.Resources.icons8_student_male_50
        Me.StudentToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.StudentToolStripMenuItem.Name = "StudentToolStripMenuItem"
        Me.StudentToolStripMenuItem.Size = New System.Drawing.Size(110, 54)
        Me.StudentToolStripMenuItem.Text = "Student"
        '
        'AddNewStudentToolStripMenuItem
        '
        Me.AddNewStudentToolStripMenuItem.Image = Global.LMS.My.Resources.Resources.icons8_add_user_male_50
        Me.AddNewStudentToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AddNewStudentToolStripMenuItem.Name = "AddNewStudentToolStripMenuItem"
        Me.AddNewStudentToolStripMenuItem.Size = New System.Drawing.Size(201, 56)
        Me.AddNewStudentToolStripMenuItem.Text = "Add New Student"
        '
        'ViewStudentInfoToolStripMenuItem
        '
        Me.ViewStudentInfoToolStripMenuItem.Image = Global.LMS.My.Resources.Resources.icons8_view_502
        Me.ViewStudentInfoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ViewStudentInfoToolStripMenuItem.Name = "ViewStudentInfoToolStripMenuItem"
        Me.ViewStudentInfoToolStripMenuItem.Size = New System.Drawing.Size(201, 56)
        Me.ViewStudentInfoToolStripMenuItem.Text = "View Student Info"
        '
        'IssueBooksToolStripMenuItem
        '
        Me.IssueBooksToolStripMenuItem.BackColor = System.Drawing.Color.Wheat
        Me.IssueBooksToolStripMenuItem.Image = Global.LMS.My.Resources.Resources.icons8_book_philosophy_50
        Me.IssueBooksToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.IssueBooksToolStripMenuItem.Name = "IssueBooksToolStripMenuItem"
        Me.IssueBooksToolStripMenuItem.Size = New System.Drawing.Size(130, 54)
        Me.IssueBooksToolStripMenuItem.Text = "Issue Books"
        '
        'CompleteBooksDetailDetailToolStripMenuItem
        '
        Me.CompleteBooksDetailDetailToolStripMenuItem.BackColor = System.Drawing.Color.Linen
        Me.CompleteBooksDetailDetailToolStripMenuItem.Image = Global.LMS.My.Resources.Resources.icons8_return_book_50
        Me.CompleteBooksDetailDetailToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CompleteBooksDetailDetailToolStripMenuItem.Name = "CompleteBooksDetailDetailToolStripMenuItem"
        Me.CompleteBooksDetailDetailToolStripMenuItem.Size = New System.Drawing.Size(139, 54)
        Me.CompleteBooksDetailDetailToolStripMenuItem.Text = "Return Books"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.BackColor = System.Drawing.Color.Wheat
        Me.ExitToolStripMenuItem.Image = Global.LMS.My.Resources.Resources.icons8_books_502
        Me.ExitToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(189, 54)
        Me.ExitToolStripMenuItem.Text = "Complete Books Detail"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(12, 54)
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(12, 54)
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.BackColor = System.Drawing.Color.Linen
        Me.ExitToolStripMenuItem1.Image = Global.LMS.My.Resources.Resources.icons8_exit_sign_501
        Me.ExitToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(88, 54)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'Guna2ContextMenuStrip1
        '
        Me.Guna2ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DashboardToolStripMenuItem})
        Me.Guna2ContextMenuStrip1.Name = "Guna2ContextMenuStrip1"
        Me.Guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro
        Me.Guna2ContextMenuStrip1.RenderStyle.ColorTable = Nothing
        Me.Guna2ContextMenuStrip1.RenderStyle.RoundedEdges = True
        Me.Guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White
        Me.Guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.Guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro
        Me.Guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.Guna2ContextMenuStrip1.Size = New System.Drawing.Size(131, 26)
        '
        'DashboardToolStripMenuItem
        '
        Me.DashboardToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IssuebookToolStripMenuItem})
        Me.DashboardToolStripMenuItem.Name = "DashboardToolStripMenuItem"
        Me.DashboardToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.DashboardToolStripMenuItem.Text = "dashboard"
        '
        'IssuebookToolStripMenuItem
        '
        Me.IssuebookToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BookToolStripMenuItem})
        Me.IssuebookToolStripMenuItem.Name = "IssuebookToolStripMenuItem"
        Me.IssuebookToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.IssuebookToolStripMenuItem.Text = "issuebook"
        '
        'BookToolStripMenuItem
        '
        Me.BookToolStripMenuItem.Name = "BookToolStripMenuItem"
        Me.BookToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.BookToolStripMenuItem.Text = "book"
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.BackgroundImage = Global.LMS.My.Resources.Resources.books_library_shelves_138556_1920x1080
        Me.ClientSize = New System.Drawing.Size(842, 475)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Guna2ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AddNewBookToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewBooksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StudentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddNewStudentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewStudentInfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IssueBooksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CompleteBooksDetailDetailToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Guna2ContextMenuStrip1 As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents DashboardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IssuebookToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BookToolStripMenuItem As ToolStripMenuItem
End Class
