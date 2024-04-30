<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListaVerde
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListaVerde))
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.txTurno = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txHorario = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txTotal = New System.Windows.Forms.TextBox()
        Me.txOF = New System.Windows.Forms.TextBox()
        Me.txPalet = New System.Windows.Forms.TextBox()
        Me.Manual = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Ordenar1 = New System.Windows.Forms.Button()
        Me.Ordenar2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(12, 55)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(766, 624)
        Me.ListView1.TabIndex = 1
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'ListView2
        '
        Me.ListView2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView2.HideSelection = False
        Me.ListView2.Location = New System.Drawing.Point(784, 55)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(428, 412)
        Me.ListView2.TabIndex = 2
        Me.ListView2.UseCompatibleStateImageBehavior = False
        '
        'txTurno
        '
        Me.txTurno.Enabled = False
        Me.txTurno.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txTurno.Location = New System.Drawing.Point(86, 16)
        Me.txTurno.MaxLength = 6
        Me.txTurno.Name = "txTurno"
        Me.txTurno.Size = New System.Drawing.Size(75, 33)
        Me.txTurno.TabIndex = 22
        Me.txTurno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 23)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Turno"
        '
        'txHorario
        '
        Me.txHorario.Enabled = False
        Me.txHorario.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txHorario.Location = New System.Drawing.Point(295, 16)
        Me.txHorario.MaxLength = 6
        Me.txHorario.Name = "txHorario"
        Me.txHorario.Size = New System.Drawing.Size(75, 33)
        Me.txHorario.TabIndex = 24
        Me.txHorario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(198, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 23)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Horario"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(983, 483)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 23)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Total"
        '
        'txTotal
        '
        Me.txTotal.Enabled = False
        Me.txTotal.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txTotal.Location = New System.Drawing.Point(1063, 473)
        Me.txTotal.MaxLength = 6
        Me.txTotal.Name = "txTotal"
        Me.txTotal.Size = New System.Drawing.Size(149, 41)
        Me.txTotal.TabIndex = 27
        Me.txTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txOF
        '
        Me.txOF.Enabled = False
        Me.txOF.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txOF.Location = New System.Drawing.Point(987, 544)
        Me.txOF.MaxLength = 6
        Me.txOF.Name = "txOF"
        Me.txOF.Size = New System.Drawing.Size(95, 27)
        Me.txOF.TabIndex = 28
        Me.txOF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txPalet
        '
        Me.txPalet.Enabled = False
        Me.txPalet.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txPalet.Location = New System.Drawing.Point(987, 577)
        Me.txPalet.MaxLength = 6
        Me.txPalet.Name = "txPalet"
        Me.txPalet.Size = New System.Drawing.Size(95, 27)
        Me.txPalet.TabIndex = 29
        Me.txPalet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Manual
        '
        Me.Manual.BackgroundImage = CType(resources.GetObject("Manual.BackgroundImage"), System.Drawing.Image)
        Me.Manual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Manual.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Manual.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.Manual.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Manual.Location = New System.Drawing.Point(1088, 544)
        Me.Manual.Name = "Manual"
        Me.Manual.Size = New System.Drawing.Size(124, 79)
        Me.Manual.TabIndex = 30
        Me.Manual.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Manual.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1084, 626)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 17)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Plan de Verificación"
        '
        'Ordenar1
        '
        Me.Ordenar1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ordenar1.Location = New System.Drawing.Point(461, 20)
        Me.Ordenar1.Name = "Ordenar1"
        Me.Ordenar1.Size = New System.Drawing.Size(147, 23)
        Me.Ordenar1.TabIndex = 32
        Me.Ordenar1.Text = "Ordenar por OF"
        Me.Ordenar1.UseVisualStyleBackColor = True
        '
        'Ordenar2
        '
        Me.Ordenar2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ordenar2.Location = New System.Drawing.Point(631, 20)
        Me.Ordenar2.Name = "Ordenar2"
        Me.Ordenar2.Size = New System.Drawing.Size(147, 23)
        Me.Ordenar2.TabIndex = 33
        Me.Ordenar2.Text = "Ordenar por Palet"
        Me.Ordenar2.UseVisualStyleBackColor = True
        '
        'ListaVerde
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1224, 691)
        Me.Controls.Add(Me.Ordenar2)
        Me.Controls.Add(Me.Ordenar1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Manual)
        Me.Controls.Add(Me.txPalet)
        Me.Controls.Add(Me.txOF)
        Me.Controls.Add(Me.txTotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txHorario)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txTurno)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListView2)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "ListaVerde"
        Me.Text = "ListaVerde"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents ListView2 As ListView
    Friend WithEvents txTurno As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txHorario As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txTotal As TextBox
    Friend WithEvents txOF As TextBox
    Friend WithEvents txPalet As TextBox
    Friend WithEvents Manual As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Ordenar1 As Button
    Friend WithEvents Ordenar2 As Button
End Class
