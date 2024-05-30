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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Rechazo))
        Me.coRechazo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Bobina = New System.Windows.Forms.TextBox()
        Me.KGS = New System.Windows.Forms.TextBox()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.OK = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.OP = New System.Windows.Forms.TextBox()
        Me.BobinaMas = New System.Windows.Forms.Button()
        Me.BobinaMenos = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'coRechazo
        '
        Me.coRechazo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.coRechazo.FormattingEnabled = True
        Me.coRechazo.Location = New System.Drawing.Point(158, 125)
        Me.coRechazo.Name = "coRechazo"
        Me.coRechazo.Size = New System.Drawing.Size(356, 29)
        Me.coRechazo.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cód. Rechazo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Bobina Nº:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 183)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 25)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "KG Estimados:"
        '
        'Bobina
        '
        Me.Bobina.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.Bobina.Location = New System.Drawing.Point(158, 69)
        Me.Bobina.Name = "Bobina"
        Me.Bobina.Size = New System.Drawing.Size(158, 33)
        Me.Bobina.TabIndex = 5
        '
        'KGS
        '
        Me.KGS.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.KGS.Location = New System.Drawing.Point(158, 180)
        Me.KGS.Name = "KGS"
        Me.KGS.Size = New System.Drawing.Size(158, 33)
        Me.KGS.TabIndex = 7
        '
        'Cancel
        '
        Me.Cancel.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.Location = New System.Drawing.Point(285, 255)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(264, 37)
        Me.Cancel.TabIndex = 12
        Me.Cancel.Text = "Abandonar"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'OK
        '
        Me.OK.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK.Location = New System.Drawing.Point(12, 255)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(246, 37)
        Me.OK.TabIndex = 11
        Me.OK.Text = "OK"
        Me.OK.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(138, 25)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Orden Fabrica.:"
        '
        'OP
        '
        Me.OP.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.OP.Location = New System.Drawing.Point(156, 27)
        Me.OP.Name = "OP"
        Me.OP.Size = New System.Drawing.Size(158, 33)
        Me.OP.TabIndex = 14
        '
        'BobinaMas
        '
        Me.BobinaMas.BackgroundImage = CType(resources.GetObject("BobinaMas.BackgroundImage"), System.Drawing.Image)
        Me.BobinaMas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BobinaMas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BobinaMas.Location = New System.Drawing.Point(322, 69)
        Me.BobinaMas.Name = "BobinaMas"
        Me.BobinaMas.Size = New System.Drawing.Size(36, 35)
        Me.BobinaMas.TabIndex = 24
        Me.BobinaMas.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BobinaMas.UseVisualStyleBackColor = True
        '
        'BobinaMenos
        '
        Me.BobinaMenos.BackgroundImage = CType(resources.GetObject("BobinaMenos.BackgroundImage"), System.Drawing.Image)
        Me.BobinaMenos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BobinaMenos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BobinaMenos.Location = New System.Drawing.Point(364, 69)
        Me.BobinaMenos.Name = "BobinaMenos"
        Me.BobinaMenos.Size = New System.Drawing.Size(35, 35)
        Me.BobinaMenos.TabIndex = 25
        Me.BobinaMenos.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BobinaMenos.UseVisualStyleBackColor = True
        '
        'Rechazo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 296)
        Me.ControlBox = False
        Me.Controls.Add(Me.BobinaMenos)
        Me.Controls.Add(Me.BobinaMas)
        Me.Controls.Add(Me.OP)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.KGS)
        Me.Controls.Add(Me.Bobina)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.coRechazo)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(6)
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
    Friend WithEvents Label4 As Label
    Friend WithEvents Bobina As TextBox
    Friend WithEvents KGS As TextBox
    Friend WithEvents Cancel As Button
    Friend WithEvents OK As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents OP As TextBox
    Friend WithEvents BobinaMas As Button
    Friend WithEvents BobinaMenos As Button
End Class
