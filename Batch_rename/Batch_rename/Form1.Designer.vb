<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.FolderBrowser = New System.Windows.Forms.FolderBrowserDialog()
        Me.txtText2Replace = New System.Windows.Forms.TextBox()
        Me.lbl2Replace = New System.Windows.Forms.Label()
        Me.lblReplaceWith = New System.Windows.Forms.Label()
        Me.txtReplaceWith = New System.Windows.Forms.TextBox()
        Me.btnMakeItSo = New System.Windows.Forms.Button()
        Me.DirectorySearch = New System.DirectoryServices.DirectorySearcher()
        Me.OpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(197, 227)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'FolderBrowser
        '
        Me.FolderBrowser.RootFolder = System.Environment.SpecialFolder.DesktopDirectory
        Me.FolderBrowser.ShowNewFolderButton = False
        '
        'txtText2Replace
        '
        Me.txtText2Replace.Location = New System.Drawing.Point(12, 33)
        Me.txtText2Replace.Name = "txtText2Replace"
        Me.txtText2Replace.Size = New System.Drawing.Size(260, 20)
        Me.txtText2Replace.TabIndex = 1
        '
        'lbl2Replace
        '
        Me.lbl2Replace.AutoSize = True
        Me.lbl2Replace.Location = New System.Drawing.Point(12, 17)
        Me.lbl2Replace.Name = "lbl2Replace"
        Me.lbl2Replace.Size = New System.Drawing.Size(87, 13)
        Me.lbl2Replace.TabIndex = 2
        Me.lbl2Replace.Text = "Text To Replace"
        '
        'lblReplaceWith
        '
        Me.lblReplaceWith.AutoSize = True
        Me.lblReplaceWith.Location = New System.Drawing.Point(12, 71)
        Me.lblReplaceWith.Name = "lblReplaceWith"
        Me.lblReplaceWith.Size = New System.Drawing.Size(72, 13)
        Me.lblReplaceWith.TabIndex = 4
        Me.lblReplaceWith.Text = "Replace With"
        '
        'txtReplaceWith
        '
        Me.txtReplaceWith.Location = New System.Drawing.Point(12, 87)
        Me.txtReplaceWith.Name = "txtReplaceWith"
        Me.txtReplaceWith.Size = New System.Drawing.Size(260, 20)
        Me.txtReplaceWith.TabIndex = 3
        '
        'btnMakeItSo
        '
        Me.btnMakeItSo.Location = New System.Drawing.Point(182, 112)
        Me.btnMakeItSo.Name = "btnMakeItSo"
        Me.btnMakeItSo.Size = New System.Drawing.Size(75, 23)
        Me.btnMakeItSo.TabIndex = 5
        Me.btnMakeItSo.Text = "Change Text"
        Me.btnMakeItSo.UseVisualStyleBackColor = True
        '
        'DirectorySearch
        '
        Me.DirectorySearch.ClientTimeout = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearch.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearch.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01")
        '
        'OpenFile
        '
        Me.OpenFile.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnMakeItSo)
        Me.Controls.Add(Me.lblReplaceWith)
        Me.Controls.Add(Me.txtReplaceWith)
        Me.Controls.Add(Me.lbl2Replace)
        Me.Controls.Add(Me.txtText2Replace)
        Me.Controls.Add(Me.btnExit)
        Me.Name = "Form1"
        Me.Text = "Batch File Renamer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents FolderBrowser As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents txtText2Replace As System.Windows.Forms.TextBox
    Friend WithEvents lbl2Replace As System.Windows.Forms.Label
    Friend WithEvents lblReplaceWith As System.Windows.Forms.Label
    Friend WithEvents txtReplaceWith As System.Windows.Forms.TextBox
    Friend WithEvents btnMakeItSo As System.Windows.Forms.Button
    Friend WithEvents DirectorySearch As System.DirectoryServices.DirectorySearcher
    Friend WithEvents OpenFile As System.Windows.Forms.OpenFileDialog

End Class
