<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAlarme
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAlarme))
        Me.Btn_Capturar = New System.Windows.Forms.Button()
        Me.Hora = New System.Windows.Forms.Label()
        Me.MaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Btn_Desl = New System.Windows.Forms.Button()
        Me.Despertador = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Btn_Capturar
        '
        Me.Btn_Capturar.Location = New System.Drawing.Point(57, 119)
        Me.Btn_Capturar.Name = "Btn_Capturar"
        Me.Btn_Capturar.Size = New System.Drawing.Size(100, 33)
        Me.Btn_Capturar.TabIndex = 0
        Me.Btn_Capturar.Text = "Capturar"
        Me.Btn_Capturar.UseVisualStyleBackColor = True
        '
        'Hora
        '
        Me.Hora.AutoSize = True
        Me.Hora.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hora.Location = New System.Drawing.Point(346, 73)
        Me.Hora.Name = "Hora"
        Me.Hora.Size = New System.Drawing.Size(76, 35)
        Me.Hora.TabIndex = 1
        Me.Hora.Text = "Hora"
        '
        'MaskedTextBox
        '
        Me.MaskedTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskedTextBox.Location = New System.Drawing.Point(57, 35)
        Me.MaskedTextBox.Mask = "00:00"
        Me.MaskedTextBox.Name = "MaskedTextBox"
        Me.MaskedTextBox.Size = New System.Drawing.Size(100, 26)
        Me.MaskedTextBox.TabIndex = 2
        Me.MaskedTextBox.ValidatingType = GetType(Date)
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Btn_Desl
        '
        Me.Btn_Desl.Location = New System.Drawing.Point(352, 111)
        Me.Btn_Desl.Name = "Btn_Desl"
        Me.Btn_Desl.Size = New System.Drawing.Size(119, 23)
        Me.Btn_Desl.TabIndex = 3
        Me.Btn_Desl.Text = "Desligar"
        Me.Btn_Desl.UseVisualStyleBackColor = True
        '
        'Despertador
        '
        Me.Despertador.AutoSize = True
        Me.Despertador.Location = New System.Drawing.Point(72, 19)
        Me.Despertador.Name = "Despertador"
        Me.Despertador.Size = New System.Drawing.Size(65, 13)
        Me.Despertador.TabIndex = 4
        Me.Despertador.Text = "Despertador"
        '
        'FrmAlarme
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(523, 222)
        Me.Controls.Add(Me.Despertador)
        Me.Controls.Add(Me.Btn_Desl)
        Me.Controls.Add(Me.MaskedTextBox)
        Me.Controls.Add(Me.Hora)
        Me.Controls.Add(Me.Btn_Capturar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmAlarme"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alarme"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btn_Capturar As System.Windows.Forms.Button
    Friend WithEvents Hora As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Btn_Desl As System.Windows.Forms.Button
    Friend WithEvents Despertador As System.Windows.Forms.Label

End Class
