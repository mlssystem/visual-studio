<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Idadade
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
        Me.Txt_Nascimento = New System.Windows.Forms.TextBox()
        Me.Txt_Hoje = New System.Windows.Forms.TextBox()
        Me.Btn_Caucular = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_Limpar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Txt_Nascimento
        '
        Me.Txt_Nascimento.Location = New System.Drawing.Point(72, 75)
        Me.Txt_Nascimento.Name = "Txt_Nascimento"
        Me.Txt_Nascimento.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Nascimento.TabIndex = 0
        '
        'Txt_Hoje
        '
        Me.Txt_Hoje.Location = New System.Drawing.Point(232, 75)
        Me.Txt_Hoje.Name = "Txt_Hoje"
        Me.Txt_Hoje.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Hoje.TabIndex = 1
        '
        'Btn_Caucular
        '
        Me.Btn_Caucular.Location = New System.Drawing.Point(162, 101)
        Me.Btn_Caucular.Name = "Btn_Caucular"
        Me.Btn_Caucular.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Caucular.TabIndex = 2
        Me.Btn_Caucular.Text = "&Caucular"
        Me.Btn_Caucular.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(69, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Ano de nascimento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(229, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Ano atual"
        '
        'btn_Limpar
        '
        Me.btn_Limpar.Location = New System.Drawing.Point(162, 130)
        Me.btn_Limpar.Name = "btn_Limpar"
        Me.btn_Limpar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Limpar.TabIndex = 5
        Me.btn_Limpar.Text = "&Limpar"
        Me.btn_Limpar.UseVisualStyleBackColor = True
        '
        'Idadade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(383, 206)
        Me.Controls.Add(Me.btn_Limpar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btn_Caucular)
        Me.Controls.Add(Me.Txt_Hoje)
        Me.Controls.Add(Me.Txt_Nascimento)
        Me.Name = "Idadade"
        Me.Text = "Idade"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Txt_Nascimento As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Hoje As System.Windows.Forms.TextBox
    Friend WithEvents Btn_Caucular As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_Limpar As System.Windows.Forms.Button

End Class
