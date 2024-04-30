<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rechazo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.coRechazo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txBobina = New System.Windows.Forms.TextBox()
        Me.txRodajas = New System.Windows.Forms.TextBox()
        Me.txKGS = New System.Windows.Forms.TextBox()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.OK = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'coRechazo
        '
        Me.coRechazo.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.coRechazo.FormattingEnabled = True
        Me.coRechazo.Location = New System.Drawing.Point(158, 23)
        Me.coRechazo.Name = "coRechazo"
        Me.coRechazo.Size = New System.Drawing.Size(356, 33)
        Me.coRechazo.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cód. Rechazo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Bobina Nº:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Rodajas:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 187)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 25)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "KG Estimados:"
        '
        'txBobina
        '
        Me.txBobina.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.txBobina.Location = New System.Drawing.Point(158, 88)
        Me.txBobina.Name = "txBobina"
        Me.txBobina.Size = New System.Drawing.Size(158, 33)
        Me.txBobina.TabIndex = 5
        '
        'txRodajas
        '
        Me.txRodajas.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.txRodajas.Location = New System.Drawing.Point(158, 133)
        Me.txRodajas.Name = "txRodajas"
        Me.txRodajas.Size = New System.Drawing.Size(158, 33)
        Me.txRodajas.TabIndex = 6
        '
        'txKGS
        '
        Me.txKGS.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.txKGS.Location = New System.Drawing.Point(158, 184)
        Me.txKGS.Name = "txKGS"
        Me.txKGS.Size = New System.Drawing.Size(158, 33)
        Me.txKGS.TabIndex = 7
        '
        'Cancel
        '
        Me.Cancel.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.Location = New System.Drawing.Point(285, 248)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(264, 37)
        Me.Cancel.TabIndex = 12
        Me.Cancel.Text = "Abandonar"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'OK
        '
        Me.OK.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK.Location = New System.Drawing.Point(12, 248)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(246, 37)
        Me.OK.TabIndex = 11
        Me.OK.Text = "OK"
        Me.OK.UseVisualStyleBackColor = True
        '
        'Rechazo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 294)
        Me.ControlBox = False
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.txKGS)
        Me.Controls.Add(Me.txRodajas)
        Me.Controls.Add(Me.txBobina)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.coRechazo)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Rechazo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rechazo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents coRechazo As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txBobina As TextBox
    Friend WithEvents txRodajas As TextBox
    Friend WithEvents txKGS As TextBox
    Friend WithEvents Cancel As Button
    Friend WithEvents OK As Button
End Class
