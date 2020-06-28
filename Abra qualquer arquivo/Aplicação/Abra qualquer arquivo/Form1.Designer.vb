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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Filepathlabel = New System.Windows.Forms.Label()
        Me.BrowserBtn = New System.Windows.Forms.Button()
        Me.ExcelBtn = New System.Windows.Forms.Button()
        Me.NotepadBtn = New System.Windows.Forms.Button()
        Me.NotepadplusplusBtn = New System.Windows.Forms.Button()
        Me.WorldBtn = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(203, 181)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Open Whit"
        '
        'Filepathlabel
        '
        Me.Filepathlabel.AutoSize = True
        Me.Filepathlabel.Location = New System.Drawing.Point(6, 28)
        Me.Filepathlabel.Name = "Filepathlabel"
        Me.Filepathlabel.Size = New System.Drawing.Size(295, 19)
        Me.Filepathlabel.TabIndex = 1
        Me.Filepathlabel.Text = "Click the browser button to locate the file"
        '
        'BrowserBtn
        '
        Me.BrowserBtn.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrowserBtn.Location = New System.Drawing.Point(12, 118)
        Me.BrowserBtn.Name = "BrowserBtn"
        Me.BrowserBtn.Size = New System.Drawing.Size(112, 48)
        Me.BrowserBtn.TabIndex = 2
        Me.BrowserBtn.Text = "Browser"
        Me.BrowserBtn.UseVisualStyleBackColor = True
        '
        'ExcelBtn
        '
        Me.ExcelBtn.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExcelBtn.Location = New System.Drawing.Point(12, 212)
        Me.ExcelBtn.Name = "ExcelBtn"
        Me.ExcelBtn.Size = New System.Drawing.Size(112, 77)
        Me.ExcelBtn.TabIndex = 3
        Me.ExcelBtn.Text = "Excel"
        Me.ExcelBtn.UseVisualStyleBackColor = True
        '
        'NotepadBtn
        '
        Me.NotepadBtn.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NotepadBtn.Location = New System.Drawing.Point(130, 212)
        Me.NotepadBtn.Name = "NotepadBtn"
        Me.NotepadBtn.Size = New System.Drawing.Size(112, 77)
        Me.NotepadBtn.TabIndex = 4
        Me.NotepadBtn.Text = "Notepad"
        Me.NotepadBtn.UseVisualStyleBackColor = True
        '
        'NotepadplusplusBtn
        '
        Me.NotepadplusplusBtn.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NotepadplusplusBtn.Location = New System.Drawing.Point(248, 212)
        Me.NotepadplusplusBtn.Name = "NotepadplusplusBtn"
        Me.NotepadplusplusBtn.Size = New System.Drawing.Size(112, 77)
        Me.NotepadplusplusBtn.TabIndex = 5
        Me.NotepadplusplusBtn.Text = "Notepad++"
        Me.NotepadplusplusBtn.UseVisualStyleBackColor = True
        '
        'WorldBtn
        '
        Me.WorldBtn.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WorldBtn.Location = New System.Drawing.Point(366, 212)
        Me.WorldBtn.Name = "WorldBtn"
        Me.WorldBtn.Size = New System.Drawing.Size(112, 77)
        Me.WorldBtn.TabIndex = 6
        Me.WorldBtn.Text = "World"
        Me.WorldBtn.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Filepathlabel)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(466, 100)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Local disk path"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 307)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.WorldBtn)
        Me.Controls.Add(Me.NotepadplusplusBtn)
        Me.Controls.Add(Me.NotepadBtn)
        Me.Controls.Add(Me.ExcelBtn)
        Me.Controls.Add(Me.BrowserBtn)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Open Any file "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Filepathlabel As System.Windows.Forms.Label
    Friend WithEvents BrowserBtn As System.Windows.Forms.Button
    Friend WithEvents ExcelBtn As System.Windows.Forms.Button
    Friend WithEvents NotepadBtn As System.Windows.Forms.Button
    Friend WithEvents NotepadplusplusBtn As System.Windows.Forms.Button
    Friend WithEvents WorldBtn As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog

End Class
