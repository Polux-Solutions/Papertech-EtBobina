<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Panel
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Panel))
        Me.grTurno = New System.Windows.Forms.GroupBox()
        Me.turnoE = New System.Windows.Forms.RadioButton()
        Me.turnoD = New System.Windows.Forms.RadioButton()
        Me.turnoC = New System.Windows.Forms.RadioButton()
        Me.turnoB = New System.Windows.Forms.RadioButton()
        Me.turnoA = New System.Windows.Forms.RadioButton()
        Me.grOF = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.OK = New System.Windows.Forms.Button()
        Me.txOF = New System.Windows.Forms.TextBox()
        Me.Manual = New System.Windows.Forms.Button()
        Me.OF_6 = New System.Windows.Forms.Button()
        Me.OF_5 = New System.Windows.Forms.Button()
        Me.OF_4 = New System.Windows.Forms.Button()
        Me.OF_3 = New System.Windows.Forms.Button()
        Me.OF_2 = New System.Windows.Forms.Button()
        Me.OF_1 = New System.Windows.Forms.Button()
        Me.grDatos = New System.Windows.Forms.GroupBox()
        Me.txMetrosPalet = New System.Windows.Forms.TextBox()
        Me.EtMetrosPalet = New System.Windows.Forms.Label()
        Me.SoloImprimir = New System.Windows.Forms.Button()
        Me.txPalet = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txParcial = New System.Windows.Forms.TextBox()
        Me.chkTerminar = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txMetrosRodaja = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txPesoPalet = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DatosSalir = New System.Windows.Forms.Button()
        Me.DatosOK = New System.Windows.Forms.Button()
        Me.txPesoNeto = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txRodajas = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Salir = New System.Windows.Forms.Button()
        Me.etMenos = New System.Windows.Forms.Button()
        Me.EtMas = New System.Windows.Forms.Button()
        Me.grHora = New System.Windows.Forms.GroupBox()
        Me.Hora3 = New System.Windows.Forms.RadioButton()
        Me.Hora2 = New System.Windows.Forms.RadioButton()
        Me.Hora1 = New System.Windows.Forms.RadioButton()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuModoTest = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuConexDatos = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuConexNAV = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuAbrir = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuSinPalet = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuCambioTurno = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuRechazo = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnviarOPTESTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResumenDia = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResumenPorOFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResumenTurnoLote = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.PesosPorOF = New System.Windows.Forms.ToolStripMenuItem()
        Me.PesoPorBobina = New System.Windows.Forms.ToolStripMenuItem()
        Me.PesosPorOFyBobina = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.RepetirEtiquetaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.ImprimirQRPruebasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MODOToolStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.grCopias = New System.Windows.Forms.GroupBox()
        Me.etMenosCopias = New System.Windows.Forms.Button()
        Me.etMasCopias = New System.Windows.Forms.Button()
        Me.txNoCopias = New System.Windows.Forms.TextBox()
        Me.grEtPalet = New System.Windows.Forms.GroupBox()
        Me.txEtiqPalet = New System.Windows.Forms.TextBox()
        Me.GrFecha = New System.Windows.Forms.GroupBox()
        Me.etMenosFecha = New System.Windows.Forms.Button()
        Me.etMasFecha = New System.Windows.Forms.Button()
        Me.txFechaTrabajo = New System.Windows.Forms.TextBox()
        Me.grRepetir = New System.Windows.Forms.GroupBox()
        Me.Scrap = New System.Windows.Forms.Button()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.grOpciones = New System.Windows.Forms.GroupBox()
        Me.chCalibre = New System.Windows.Forms.CheckBox()
        Me.ChGramaje = New System.Windows.Forms.CheckBox()
        Me.grBobina = New System.Windows.Forms.GroupBox()
        Me.BobinaMas = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txBobina = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.grTurno.SuspendLayout()
        Me.grOF.SuspendLayout()
        Me.grDatos.SuspendLayout()
        Me.grHora.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.grCopias.SuspendLayout()
        Me.grEtPalet.SuspendLayout()
        Me.GrFecha.SuspendLayout()
        Me.grRepetir.SuspendLayout()
        Me.grOpciones.SuspendLayout()
        Me.grBobina.SuspendLayout()
        Me.SuspendLayout()
        '
        'grTurno
        '
        Me.grTurno.Controls.Add(Me.turnoE)
        Me.grTurno.Controls.Add(Me.turnoD)
        Me.grTurno.Controls.Add(Me.turnoC)
        Me.grTurno.Controls.Add(Me.turnoB)
        Me.grTurno.Controls.Add(Me.turnoA)
        Me.grTurno.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grTurno.Location = New System.Drawing.Point(9, 27)
        Me.grTurno.Name = "grTurno"
        Me.grTurno.Size = New System.Drawing.Size(303, 59)
        Me.grTurno.TabIndex = 13
        Me.grTurno.TabStop = False
        Me.grTurno.Text = "Turno"
        '
        'turnoE
        '
        Me.turnoE.AutoSize = True
        Me.turnoE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.turnoE.Location = New System.Drawing.Point(236, 23)
        Me.turnoE.Name = "turnoE"
        Me.turnoE.Size = New System.Drawing.Size(39, 24)
        Me.turnoE.TabIndex = 14
        Me.turnoE.Text = "E"
        Me.turnoE.UseVisualStyleBackColor = True
        '
        'turnoD
        '
        Me.turnoD.AutoSize = True
        Me.turnoD.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.turnoD.Location = New System.Drawing.Point(179, 23)
        Me.turnoD.Name = "turnoD"
        Me.turnoD.Size = New System.Drawing.Size(40, 24)
        Me.turnoD.TabIndex = 13
        Me.turnoD.Text = "D"
        Me.turnoD.UseVisualStyleBackColor = True
        '
        'turnoC
        '
        Me.turnoC.AutoSize = True
        Me.turnoC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.turnoC.Location = New System.Drawing.Point(120, 23)
        Me.turnoC.Name = "turnoC"
        Me.turnoC.Size = New System.Drawing.Size(39, 24)
        Me.turnoC.TabIndex = 12
        Me.turnoC.Text = "C"
        Me.turnoC.UseVisualStyleBackColor = True
        '
        'turnoB
        '
        Me.turnoB.AutoSize = True
        Me.turnoB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.turnoB.Location = New System.Drawing.Point(62, 23)
        Me.turnoB.Name = "turnoB"
        Me.turnoB.Size = New System.Drawing.Size(39, 24)
        Me.turnoB.TabIndex = 11
        Me.turnoB.Text = "B"
        Me.turnoB.UseVisualStyleBackColor = True
        '
        'turnoA
        '
        Me.turnoA.AutoSize = True
        Me.turnoA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.turnoA.Location = New System.Drawing.Point(11, 23)
        Me.turnoA.Name = "turnoA"
        Me.turnoA.Size = New System.Drawing.Size(39, 24)
        Me.turnoA.TabIndex = 10
        Me.turnoA.Text = "A"
        Me.turnoA.UseVisualStyleBackColor = True
        '
        'grOF
        '
        Me.grOF.Controls.Add(Me.Scrap)
        Me.grOF.Controls.Add(Me.DateTimePicker1)
        Me.grOF.Controls.Add(Me.OK)
        Me.grOF.Controls.Add(Me.txOF)
        Me.grOF.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grOF.Location = New System.Drawing.Point(149, 92)
        Me.grOF.Name = "grOF"
        Me.grOF.Size = New System.Drawing.Size(319, 66)
        Me.grOF.TabIndex = 4
        Me.grOF.TabStop = False
        Me.grOF.Text = "Orden de Fabricación"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(54, -26)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 24)
        Me.DateTimePicker1.TabIndex = 21
        '
        'OK
        '
        Me.OK.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK.Location = New System.Drawing.Point(195, 25)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(71, 37)
        Me.OK.TabIndex = 8
        Me.OK.Text = "OK"
        Me.OK.UseVisualStyleBackColor = True
        '
        'txOF
        '
        Me.txOF.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txOF.Location = New System.Drawing.Point(7, 26)
        Me.txOF.Name = "txOF"
        Me.txOF.Size = New System.Drawing.Size(181, 35)
        Me.txOF.TabIndex = 3
        '
        'Manual
        '
        Me.Manual.BackgroundImage = CType(resources.GetObject("Manual.BackgroundImage"), System.Drawing.Image)
        Me.Manual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Manual.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Manual.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.Manual.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Manual.Location = New System.Drawing.Point(6, 15)
        Me.Manual.Name = "Manual"
        Me.Manual.Size = New System.Drawing.Size(57, 79)
        Me.Manual.TabIndex = 11
        Me.Manual.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Manual.UseVisualStyleBackColor = True
        '
        'OF_6
        '
        Me.OF_6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OF_6.Location = New System.Drawing.Point(190, 68)
        Me.OF_6.Name = "OF_6"
        Me.OF_6.Size = New System.Drawing.Size(123, 27)
        Me.OF_6.TabIndex = 10
        Me.OF_6.Text = "OF012695"
        Me.OF_6.UseVisualStyleBackColor = True
        '
        'OF_5
        '
        Me.OF_5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OF_5.Location = New System.Drawing.Point(69, 67)
        Me.OF_5.Name = "OF_5"
        Me.OF_5.Size = New System.Drawing.Size(115, 27)
        Me.OF_5.TabIndex = 9
        Me.OF_5.Text = "OF012695"
        Me.OF_5.UseVisualStyleBackColor = True
        '
        'OF_4
        '
        Me.OF_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OF_4.Location = New System.Drawing.Point(190, 41)
        Me.OF_4.Name = "OF_4"
        Me.OF_4.Size = New System.Drawing.Size(123, 26)
        Me.OF_4.TabIndex = 7
        Me.OF_4.Text = "OF012695"
        Me.OF_4.UseVisualStyleBackColor = True
        '
        'OF_3
        '
        Me.OF_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OF_3.Location = New System.Drawing.Point(69, 40)
        Me.OF_3.Name = "OF_3"
        Me.OF_3.Size = New System.Drawing.Size(115, 26)
        Me.OF_3.TabIndex = 6
        Me.OF_3.Text = "OF012695"
        Me.OF_3.UseVisualStyleBackColor = True
        '
        'OF_2
        '
        Me.OF_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OF_2.Location = New System.Drawing.Point(190, 16)
        Me.OF_2.Name = "OF_2"
        Me.OF_2.Size = New System.Drawing.Size(123, 24)
        Me.OF_2.TabIndex = 5
        Me.OF_2.Text = "OF012695"
        Me.OF_2.UseVisualStyleBackColor = True
        '
        'OF_1
        '
        Me.OF_1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.OF_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OF_1.Location = New System.Drawing.Point(69, 15)
        Me.OF_1.Name = "OF_1"
        Me.OF_1.Size = New System.Drawing.Size(115, 24)
        Me.OF_1.TabIndex = 4
        Me.OF_1.Text = "OF012695"
        Me.OF_1.UseVisualStyleBackColor = True
        '
        'grDatos
        '
        Me.grDatos.Controls.Add(Me.txMetrosPalet)
        Me.grDatos.Controls.Add(Me.EtMetrosPalet)
        Me.grDatos.Controls.Add(Me.SoloImprimir)
        Me.grDatos.Controls.Add(Me.txPalet)
        Me.grDatos.Controls.Add(Me.Label2)
        Me.grDatos.Controls.Add(Me.Label1)
        Me.grDatos.Controls.Add(Me.txParcial)
        Me.grDatos.Controls.Add(Me.chkTerminar)
        Me.grDatos.Controls.Add(Me.Label9)
        Me.grDatos.Controls.Add(Me.txMetrosRodaja)
        Me.grDatos.Controls.Add(Me.Label7)
        Me.grDatos.Controls.Add(Me.txPesoPalet)
        Me.grDatos.Controls.Add(Me.Label6)
        Me.grDatos.Controls.Add(Me.DatosSalir)
        Me.grDatos.Controls.Add(Me.DatosOK)
        Me.grDatos.Controls.Add(Me.txPesoNeto)
        Me.grDatos.Controls.Add(Me.Label5)
        Me.grDatos.Controls.Add(Me.txRodajas)
        Me.grDatos.Controls.Add(Me.Label3)
        Me.grDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grDatos.Location = New System.Drawing.Point(12, 356)
        Me.grDatos.Name = "grDatos"
        Me.grDatos.Size = New System.Drawing.Size(456, 323)
        Me.grDatos.TabIndex = 5
        Me.grDatos.TabStop = False
        Me.grDatos.Text = "Orden de Fabricación"
        '
        'txMetrosPalet
        '
        Me.txMetrosPalet.Enabled = False
        Me.txMetrosPalet.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txMetrosPalet.Location = New System.Drawing.Point(254, 219)
        Me.txMetrosPalet.MaxLength = 4
        Me.txMetrosPalet.Name = "txMetrosPalet"
        Me.txMetrosPalet.Size = New System.Drawing.Size(148, 26)
        Me.txMetrosPalet.TabIndex = 23
        '
        'EtMetrosPalet
        '
        Me.EtMetrosPalet.AutoSize = True
        Me.EtMetrosPalet.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EtMetrosPalet.Location = New System.Drawing.Point(14, 217)
        Me.EtMetrosPalet.Name = "EtMetrosPalet"
        Me.EtMetrosPalet.Size = New System.Drawing.Size(125, 24)
        Me.EtMetrosPalet.TabIndex = 24
        Me.EtMetrosPalet.Text = "Metros Palet"
        '
        'SoloImprimir
        '
        Me.SoloImprimir.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SoloImprimir.Location = New System.Drawing.Point(233, 282)
        Me.SoloImprimir.Name = "SoloImprimir"
        Me.SoloImprimir.Size = New System.Drawing.Size(92, 35)
        Me.SoloImprimir.TabIndex = 22
        Me.SoloImprimir.Text = "Imprimir"
        Me.SoloImprimir.UseVisualStyleBackColor = True
        '
        'txPalet
        '
        Me.txPalet.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txPalet.Location = New System.Drawing.Point(255, 51)
        Me.txPalet.MaxLength = 6
        Me.txPalet.Name = "txPalet"
        Me.txPalet.Size = New System.Drawing.Size(148, 26)
        Me.txPalet.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 24)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Nº Palet"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(219, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 24)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Etiqueta"
        '
        'txParcial
        '
        Me.txParcial.Enabled = False
        Me.txParcial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txParcial.Location = New System.Drawing.Point(344, 17)
        Me.txParcial.MaxLength = 4
        Me.txParcial.Name = "txParcial"
        Me.txParcial.Size = New System.Drawing.Size(59, 26)
        Me.txParcial.TabIndex = 18
        '
        'chkTerminar
        '
        Me.chkTerminar.AutoSize = True
        Me.chkTerminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTerminar.Location = New System.Drawing.Point(384, 256)
        Me.chkTerminar.Name = "chkTerminar"
        Me.chkTerminar.Size = New System.Drawing.Size(15, 14)
        Me.chkTerminar.TabIndex = 17
        Me.chkTerminar.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(13, 249)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(159, 24)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Terminar Orden"
        '
        'txMetrosRodaja
        '
        Me.txMetrosRodaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txMetrosRodaja.Location = New System.Drawing.Point(253, 184)
        Me.txMetrosRodaja.MaxLength = 4
        Me.txMetrosRodaja.Name = "txMetrosRodaja"
        Me.txMetrosRodaja.Size = New System.Drawing.Size(148, 26)
        Me.txMetrosRodaja.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(13, 182)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(144, 24)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Metros Rodaja"
        '
        'txPesoPalet
        '
        Me.txPesoPalet.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txPesoPalet.Location = New System.Drawing.Point(255, 86)
        Me.txPesoPalet.MaxLength = 4
        Me.txPesoPalet.Name = "txPesoPalet"
        Me.txPesoPalet.Size = New System.Drawing.Size(148, 26)
        Me.txPesoPalet.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(11, 86)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 24)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Peso Palet"
        '
        'DatosSalir
        '
        Me.DatosSalir.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DatosSalir.Location = New System.Drawing.Point(343, 282)
        Me.DatosSalir.Name = "DatosSalir"
        Me.DatosSalir.Size = New System.Drawing.Size(101, 35)
        Me.DatosSalir.TabIndex = 11
        Me.DatosSalir.Text = "Cancelar"
        Me.DatosSalir.UseVisualStyleBackColor = True
        '
        'DatosOK
        '
        Me.DatosOK.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DatosOK.Location = New System.Drawing.Point(15, 282)
        Me.DatosOK.Name = "DatosOK"
        Me.DatosOK.Size = New System.Drawing.Size(206, 35)
        Me.DatosOK.TabIndex = 10
        Me.DatosOK.Text = "Registrar + Imprimir"
        Me.DatosOK.UseVisualStyleBackColor = True
        '
        'txPesoNeto
        '
        Me.txPesoNeto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txPesoNeto.Location = New System.Drawing.Point(253, 152)
        Me.txPesoNeto.MaxLength = 4
        Me.txPesoNeto.Name = "txPesoNeto"
        Me.txPesoNeto.Size = New System.Drawing.Size(148, 26)
        Me.txPesoNeto.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Peso Neto"
        '
        'txRodajas
        '
        Me.txRodajas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txRodajas.Location = New System.Drawing.Point(344, 119)
        Me.txRodajas.MaxLength = 2
        Me.txRodajas.Name = "txRodajas"
        Me.txRodajas.Size = New System.Drawing.Size(59, 26)
        Me.txRodajas.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Rodajas"
        '
        'Salir
        '
        Me.Salir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Salir.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salir.Location = New System.Drawing.Point(12, 685)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(456, 34)
        Me.Salir.TabIndex = 9
        Me.Salir.Text = "SALIR"
        Me.Salir.UseVisualStyleBackColor = True
        '
        'etMenos
        '
        Me.etMenos.BackgroundImage = CType(resources.GetObject("etMenos.BackgroundImage"), System.Drawing.Image)
        Me.etMenos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.etMenos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etMenos.Location = New System.Drawing.Point(90, 32)
        Me.etMenos.Name = "etMenos"
        Me.etMenos.Size = New System.Drawing.Size(36, 35)
        Me.etMenos.TabIndex = 16
        Me.etMenos.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.etMenos.UseVisualStyleBackColor = True
        '
        'EtMas
        '
        Me.EtMas.BackgroundImage = CType(resources.GetObject("EtMas.BackgroundImage"), System.Drawing.Image)
        Me.EtMas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EtMas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EtMas.Location = New System.Drawing.Point(52, 32)
        Me.EtMas.Name = "EtMas"
        Me.EtMas.Size = New System.Drawing.Size(36, 35)
        Me.EtMas.TabIndex = 15
        Me.EtMas.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.EtMas.UseVisualStyleBackColor = True
        '
        'grHora
        '
        Me.grHora.Controls.Add(Me.Hora3)
        Me.grHora.Controls.Add(Me.Hora2)
        Me.grHora.Controls.Add(Me.Hora1)
        Me.grHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grHora.Location = New System.Drawing.Point(318, 28)
        Me.grHora.Name = "grHora"
        Me.grHora.Size = New System.Drawing.Size(150, 58)
        Me.grHora.TabIndex = 16
        Me.grHora.TabStop = False
        Me.grHora.Text = "Hora"
        '
        'Hora3
        '
        Me.Hora3.AutoSize = True
        Me.Hora3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hora3.Location = New System.Drawing.Point(112, 22)
        Me.Hora3.Name = "Hora3"
        Me.Hora3.Size = New System.Drawing.Size(37, 24)
        Me.Hora3.TabIndex = 16
        Me.Hora3.Text = "3"
        Me.Hora3.UseVisualStyleBackColor = True
        '
        'Hora2
        '
        Me.Hora2.AutoSize = True
        Me.Hora2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hora2.Location = New System.Drawing.Point(57, 22)
        Me.Hora2.Name = "Hora2"
        Me.Hora2.Size = New System.Drawing.Size(37, 24)
        Me.Hora2.TabIndex = 15
        Me.Hora2.Text = "2"
        Me.Hora2.UseVisualStyleBackColor = True
        '
        'Hora1
        '
        Me.Hora1.AutoSize = True
        Me.Hora1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hora1.Location = New System.Drawing.Point(14, 23)
        Me.Hora1.Name = "Hora1"
        Me.Hora1.Size = New System.Drawing.Size(37, 24)
        Me.Hora1.TabIndex = 14
        Me.Hora1.Text = "1"
        Me.Hora1.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.MODOToolStrip})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(473, 28)
        Me.MenuStrip1.TabIndex = 17
        Me.MenuStrip1.Text = "Acciones"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuModoTest, Me.ToolStripSeparator8, Me.MenuConexDatos, Me.MenuConexNAV, Me.ToolStripSeparator2, Me.MenuAbrir, Me.ToolStripSeparator1, Me.MenuSinPalet, Me.ToolStripSeparator4, Me.MenuCambioTurno, Me.ToolStripSeparator7, Me.MenuRechazo, Me.ToolStripSeparator3, Me.ToolStripMenuItem4, Me.MenuSalir, Me.EnviarOPTESTToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(67, 24)
        Me.ToolStripMenuItem1.Text = "Acciones"
        '
        'MenuModoTest
        '
        Me.MenuModoTest.Name = "MenuModoTest"
        Me.MenuModoTest.Size = New System.Drawing.Size(196, 22)
        Me.MenuModoTest.Text = "Modo Test"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(193, 6)
        '
        'MenuConexDatos
        '
        Me.MenuConexDatos.Name = "MenuConexDatos"
        Me.MenuConexDatos.Size = New System.Drawing.Size(196, 22)
        Me.MenuConexDatos.Text = "Probar Conexión Datos"
        '
        'MenuConexNAV
        '
        Me.MenuConexNAV.Name = "MenuConexNAV"
        Me.MenuConexNAV.Size = New System.Drawing.Size(196, 22)
        Me.MenuConexNAV.Text = "Probar Conexión NAV"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(193, 6)
        '
        'MenuAbrir
        '
        Me.MenuAbrir.Name = "MenuAbrir"
        Me.MenuAbrir.Size = New System.Drawing.Size(196, 22)
        Me.MenuAbrir.Text = "Abrir Orden Terminada"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(193, 6)
        '
        'MenuSinPalet
        '
        Me.MenuSinPalet.Name = "MenuSinPalet"
        Me.MenuSinPalet.Size = New System.Drawing.Size(196, 22)
        Me.MenuSinPalet.Text = "No Actualizar Nº Palet"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(193, 6)
        '
        'MenuCambioTurno
        '
        Me.MenuCambioTurno.Name = "MenuCambioTurno"
        Me.MenuCambioTurno.Size = New System.Drawing.Size(196, 22)
        Me.MenuCambioTurno.Text = "Cambiar Turno"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(193, 6)
        '
        'MenuRechazo
        '
        Me.MenuRechazo.Name = "MenuRechazo"
        Me.MenuRechazo.Size = New System.Drawing.Size(196, 22)
        Me.MenuRechazo.Text = "Rechazo"
        Me.MenuRechazo.Visible = False
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(193, 6)
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(196, 22)
        Me.ToolStripMenuItem4.Text = "¿Quién Soy?"
        '
        'MenuSalir
        '
        Me.MenuSalir.Name = "MenuSalir"
        Me.MenuSalir.Size = New System.Drawing.Size(196, 22)
        Me.MenuSalir.Text = "Salir"
        '
        'EnviarOPTESTToolStripMenuItem
        '
        Me.EnviarOPTESTToolStripMenuItem.Name = "EnviarOPTESTToolStripMenuItem"
        Me.EnviarOPTESTToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.EnviarOPTESTToolStripMenuItem.Text = "Enviar OP TEST"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResumenDia, Me.ResumenPorOFToolStripMenuItem, Me.ResumenTurnoLote, Me.ToolStripSeparator6, Me.PesosPorOF, Me.PesoPorBobina, Me.PesosPorOFyBobina, Me.ToolStripSeparator5, Me.RepetirEtiquetaToolStripMenuItem, Me.ToolStripSeparator9, Me.ImprimirQRPruebasToolStripMenuItem})
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(66, 24)
        Me.ToolStripMenuItem2.Text = "Informes"
        '
        'ResumenDia
        '
        Me.ResumenDia.Name = "ResumenDia"
        Me.ResumenDia.Size = New System.Drawing.Size(214, 22)
        Me.ResumenDia.Text = "Resumen por Turno/OF"
        '
        'ResumenPorOFToolStripMenuItem
        '
        Me.ResumenPorOFToolStripMenuItem.Name = "ResumenPorOFToolStripMenuItem"
        Me.ResumenPorOFToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.ResumenPorOFToolStripMenuItem.Text = "Resumen por OF/Turno"
        '
        'ResumenTurnoLote
        '
        Me.ResumenTurnoLote.Name = "ResumenTurnoLote"
        Me.ResumenTurnoLote.Size = New System.Drawing.Size(214, 22)
        Me.ResumenTurnoLote.Text = "Resumen por Turno/Lote"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(211, 6)
        '
        'PesosPorOF
        '
        Me.PesosPorOF.Name = "PesosPorOF"
        Me.PesosPorOF.Size = New System.Drawing.Size(214, 22)
        Me.PesosPorOF.Text = "Detalle Pesos por OF"
        '
        'PesoPorBobina
        '
        Me.PesoPorBobina.Name = "PesoPorBobina"
        Me.PesoPorBobina.Size = New System.Drawing.Size(214, 22)
        Me.PesoPorBobina.Text = "Detalle Pesos por Rollo"
        '
        'PesosPorOFyBobina
        '
        Me.PesosPorOFyBobina.Name = "PesosPorOFyBobina"
        Me.PesosPorOFyBobina.Size = New System.Drawing.Size(214, 22)
        Me.PesosPorOFyBobina.Text = "Detalle Pesos por OF/Rollo"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(211, 6)
        '
        'RepetirEtiquetaToolStripMenuItem
        '
        Me.RepetirEtiquetaToolStripMenuItem.Name = "RepetirEtiquetaToolStripMenuItem"
        Me.RepetirEtiquetaToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.RepetirEtiquetaToolStripMenuItem.Text = "Repetir Etiqueta"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(211, 6)
        '
        'ImprimirQRPruebasToolStripMenuItem
        '
        Me.ImprimirQRPruebasToolStripMenuItem.Name = "ImprimirQRPruebasToolStripMenuItem"
        Me.ImprimirQRPruebasToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.ImprimirQRPruebasToolStripMenuItem.Text = "Imprimir QR Pruebas"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(53, 24)
        Me.ToolStripMenuItem3.Text = "Ayuda"
        '
        'MODOToolStrip
        '
        Me.MODOToolStrip.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MODOToolStrip.Name = "MODOToolStrip"
        Me.MODOToolStrip.Size = New System.Drawing.Size(68, 24)
        Me.MODOToolStrip.Text = "MODO"
        '
        'grCopias
        '
        Me.grCopias.Controls.Add(Me.etMenosCopias)
        Me.grCopias.Controls.Add(Me.etMasCopias)
        Me.grCopias.Controls.Add(Me.txNoCopias)
        Me.grCopias.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grCopias.Location = New System.Drawing.Point(9, 160)
        Me.grCopias.Name = "grCopias"
        Me.grCopias.Size = New System.Drawing.Size(132, 67)
        Me.grCopias.TabIndex = 17
        Me.grCopias.TabStop = False
        Me.grCopias.Text = "Nº Copias"
        '
        'etMenosCopias
        '
        Me.etMenosCopias.BackgroundImage = CType(resources.GetObject("etMenosCopias.BackgroundImage"), System.Drawing.Image)
        Me.etMenosCopias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.etMenosCopias.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etMenosCopias.Location = New System.Drawing.Point(90, 26)
        Me.etMenosCopias.Name = "etMenosCopias"
        Me.etMenosCopias.Size = New System.Drawing.Size(36, 35)
        Me.etMenosCopias.TabIndex = 21
        Me.etMenosCopias.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.etMenosCopias.UseVisualStyleBackColor = True
        '
        'etMasCopias
        '
        Me.etMasCopias.BackgroundImage = CType(resources.GetObject("etMasCopias.BackgroundImage"), System.Drawing.Image)
        Me.etMasCopias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.etMasCopias.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etMasCopias.Location = New System.Drawing.Point(51, 25)
        Me.etMasCopias.Name = "etMasCopias"
        Me.etMasCopias.Size = New System.Drawing.Size(36, 35)
        Me.etMasCopias.TabIndex = 20
        Me.etMasCopias.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.etMasCopias.UseVisualStyleBackColor = True
        '
        'txNoCopias
        '
        Me.txNoCopias.Enabled = False
        Me.txNoCopias.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txNoCopias.Location = New System.Drawing.Point(9, 31)
        Me.txNoCopias.MaxLength = 2
        Me.txNoCopias.Name = "txNoCopias"
        Me.txNoCopias.Size = New System.Drawing.Size(36, 26)
        Me.txNoCopias.TabIndex = 19
        Me.txNoCopias.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'grEtPalet
        '
        Me.grEtPalet.Controls.Add(Me.etMenos)
        Me.grEtPalet.Controls.Add(Me.txEtiqPalet)
        Me.grEtPalet.Controls.Add(Me.EtMas)
        Me.grEtPalet.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grEtPalet.Location = New System.Drawing.Point(9, 232)
        Me.grEtPalet.Name = "grEtPalet"
        Me.grEtPalet.Size = New System.Drawing.Size(131, 73)
        Me.grEtPalet.TabIndex = 20
        Me.grEtPalet.TabStop = False
        Me.grEtPalet.Text = "Etiq. X Palet"
        '
        'txEtiqPalet
        '
        Me.txEtiqPalet.Enabled = False
        Me.txEtiqPalet.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txEtiqPalet.Location = New System.Drawing.Point(9, 33)
        Me.txEtiqPalet.MaxLength = 2
        Me.txEtiqPalet.Name = "txEtiqPalet"
        Me.txEtiqPalet.Size = New System.Drawing.Size(33, 26)
        Me.txEtiqPalet.TabIndex = 19
        Me.txEtiqPalet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GrFecha
        '
        Me.GrFecha.Controls.Add(Me.etMenosFecha)
        Me.GrFecha.Controls.Add(Me.etMasFecha)
        Me.GrFecha.Controls.Add(Me.txFechaTrabajo)
        Me.GrFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.GrFecha.Location = New System.Drawing.Point(9, 92)
        Me.GrFecha.Name = "GrFecha"
        Me.GrFecha.Size = New System.Drawing.Size(131, 62)
        Me.GrFecha.TabIndex = 22
        Me.GrFecha.TabStop = False
        Me.GrFecha.Text = "Fecha Trabajo"
        '
        'etMenosFecha
        '
        Me.etMenosFecha.BackgroundImage = CType(resources.GetObject("etMenosFecha.BackgroundImage"), System.Drawing.Image)
        Me.etMenosFecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.etMenosFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etMenosFecha.Location = New System.Drawing.Point(90, 21)
        Me.etMenosFecha.Name = "etMenosFecha"
        Me.etMenosFecha.Size = New System.Drawing.Size(36, 35)
        Me.etMenosFecha.TabIndex = 23
        Me.etMenosFecha.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.etMenosFecha.UseVisualStyleBackColor = True
        '
        'etMasFecha
        '
        Me.etMasFecha.BackgroundImage = CType(resources.GetObject("etMasFecha.BackgroundImage"), System.Drawing.Image)
        Me.etMasFecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.etMasFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etMasFecha.Location = New System.Drawing.Point(51, 21)
        Me.etMasFecha.Name = "etMasFecha"
        Me.etMasFecha.Size = New System.Drawing.Size(36, 35)
        Me.etMasFecha.TabIndex = 22
        Me.etMasFecha.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.etMasFecha.UseVisualStyleBackColor = True
        '
        'txFechaTrabajo
        '
        Me.txFechaTrabajo.Enabled = False
        Me.txFechaTrabajo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txFechaTrabajo.Location = New System.Drawing.Point(3, 26)
        Me.txFechaTrabajo.Name = "txFechaTrabajo"
        Me.txFechaTrabajo.Size = New System.Drawing.Size(47, 24)
        Me.txFechaTrabajo.TabIndex = 0
        Me.txFechaTrabajo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grRepetir
        '
        Me.grRepetir.Controls.Add(Me.DateTimePicker2)
        Me.grRepetir.Controls.Add(Me.Manual)
        Me.grRepetir.Controls.Add(Me.OF_2)
        Me.grRepetir.Controls.Add(Me.OF_5)
        Me.grRepetir.Controls.Add(Me.OF_3)
        Me.grRepetir.Controls.Add(Me.OF_6)
        Me.grRepetir.Controls.Add(Me.OF_1)
        Me.grRepetir.Controls.Add(Me.OF_4)
        Me.grRepetir.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grRepetir.Location = New System.Drawing.Point(149, 160)
        Me.grRepetir.Name = "grRepetir"
        Me.grRepetir.Size = New System.Drawing.Size(319, 100)
        Me.grRepetir.TabIndex = 22
        Me.grRepetir.TabStop = False
        '
        'Scrap
        '
        Me.Scrap.BackgroundImage = CType(resources.GetObject("Scrap.BackgroundImage"), System.Drawing.Image)
        Me.Scrap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Scrap.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Scrap.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.Scrap.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Scrap.Location = New System.Drawing.Point(261, 21)
        Me.Scrap.Name = "Scrap"
        Me.Scrap.Size = New System.Drawing.Size(46, 40)
        Me.Scrap.TabIndex = 22
        Me.Scrap.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Scrap.UseVisualStyleBackColor = True
        Me.Scrap.Visible = False
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(54, -26)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 24)
        Me.DateTimePicker2.TabIndex = 21
        '
        'grOpciones
        '
        Me.grOpciones.Controls.Add(Me.chCalibre)
        Me.grOpciones.Controls.Add(Me.ChGramaje)
        Me.grOpciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.grOpciones.Location = New System.Drawing.Point(149, 260)
        Me.grOpciones.Name = "grOpciones"
        Me.grOpciones.Size = New System.Drawing.Size(319, 45)
        Me.grOpciones.TabIndex = 25
        Me.grOpciones.TabStop = False
        Me.grOpciones.Text = "Opciones"
        '
        'chCalibre
        '
        Me.chCalibre.AutoSize = True
        Me.chCalibre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chCalibre.Location = New System.Drawing.Point(207, 17)
        Me.chCalibre.Name = "chCalibre"
        Me.chCalibre.Size = New System.Drawing.Size(80, 22)
        Me.chCalibre.TabIndex = 26
        Me.chCalibre.Text = "Calibre"
        Me.chCalibre.UseVisualStyleBackColor = True
        '
        'ChGramaje
        '
        Me.ChGramaje.AutoSize = True
        Me.ChGramaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChGramaje.Location = New System.Drawing.Point(95, 17)
        Me.ChGramaje.Name = "ChGramaje"
        Me.ChGramaje.Size = New System.Drawing.Size(91, 22)
        Me.ChGramaje.TabIndex = 25
        Me.ChGramaje.Text = "Gramaje"
        Me.ChGramaje.UseVisualStyleBackColor = True
        '
        'grBobina
        '
        Me.grBobina.Controls.Add(Me.BobinaMas)
        Me.grBobina.Controls.Add(Me.Label4)
        Me.grBobina.Controls.Add(Me.txBobina)
        Me.grBobina.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.grBobina.Location = New System.Drawing.Point(149, 305)
        Me.grBobina.Name = "grBobina"
        Me.grBobina.Size = New System.Drawing.Size(319, 50)
        Me.grBobina.TabIndex = 27
        Me.grBobina.TabStop = False
        '
        'BobinaMas
        '
        Me.BobinaMas.BackgroundImage = CType(resources.GetObject("BobinaMas.BackgroundImage"), System.Drawing.Image)
        Me.BobinaMas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BobinaMas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BobinaMas.Location = New System.Drawing.Point(276, 10)
        Me.BobinaMas.Name = "BobinaMas"
        Me.BobinaMas.Size = New System.Drawing.Size(36, 35)
        Me.BobinaMas.TabIndex = 23
        Me.BobinaMas.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BobinaMas.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 24)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Nº Rollo"
        '
        'txBobina
        '
        Me.txBobina.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txBobina.Location = New System.Drawing.Point(96, 15)
        Me.txBobina.MaxLength = 6
        Me.txBobina.Name = "txBobina"
        Me.txBobina.Size = New System.Drawing.Size(166, 26)
        Me.txBobina.TabIndex = 21
        '
        'Timer1
        '
        '
        'Panel
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.Salir
        Me.ClientSize = New System.Drawing.Size(473, 720)
        Me.Controls.Add(Me.grBobina)
        Me.Controls.Add(Me.grOpciones)
        Me.Controls.Add(Me.grRepetir)
        Me.Controls.Add(Me.GrFecha)
        Me.Controls.Add(Me.grEtPalet)
        Me.Controls.Add(Me.grCopias)
        Me.Controls.Add(Me.grHora)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.grTurno)
        Me.Controls.Add(Me.grDatos)
        Me.Controls.Add(Me.grOF)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Panel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Etiqueta "
        Me.grTurno.ResumeLayout(False)
        Me.grTurno.PerformLayout()
        Me.grOF.ResumeLayout(False)
        Me.grOF.PerformLayout()
        Me.grDatos.ResumeLayout(False)
        Me.grDatos.PerformLayout()
        Me.grHora.ResumeLayout(False)
        Me.grHora.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.grCopias.ResumeLayout(False)
        Me.grCopias.PerformLayout()
        Me.grEtPalet.ResumeLayout(False)
        Me.grEtPalet.PerformLayout()
        Me.GrFecha.ResumeLayout(False)
        Me.GrFecha.PerformLayout()
        Me.grRepetir.ResumeLayout(False)
        Me.grOpciones.ResumeLayout(False)
        Me.grOpciones.PerformLayout()
        Me.grBobina.ResumeLayout(False)
        Me.grBobina.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grOF As System.Windows.Forms.GroupBox
    Friend WithEvents txOF As System.Windows.Forms.TextBox
    Friend WithEvents OF_4 As System.Windows.Forms.Button
    Friend WithEvents OF_3 As System.Windows.Forms.Button
    Friend WithEvents OF_2 As System.Windows.Forms.Button
    Friend WithEvents OF_1 As System.Windows.Forms.Button
    Friend WithEvents grDatos As System.Windows.Forms.GroupBox
    Friend WithEvents txPesoNeto As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txRodajas As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents grTurno As System.Windows.Forms.GroupBox
    Friend WithEvents turnoE As System.Windows.Forms.RadioButton
    Friend WithEvents turnoD As System.Windows.Forms.RadioButton
    Friend WithEvents turnoC As System.Windows.Forms.RadioButton
    Friend WithEvents turnoB As System.Windows.Forms.RadioButton
    Friend WithEvents turnoA As System.Windows.Forms.RadioButton
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents Salir As System.Windows.Forms.Button
    Friend WithEvents DatosOK As System.Windows.Forms.Button
    Friend WithEvents DatosSalir As System.Windows.Forms.Button
    Friend WithEvents txPesoPalet As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents OF_6 As System.Windows.Forms.Button
    Friend WithEvents OF_5 As System.Windows.Forms.Button
    Friend WithEvents Manual As System.Windows.Forms.Button
    Friend WithEvents etMenos As System.Windows.Forms.Button
    Friend WithEvents EtMas As System.Windows.Forms.Button
    Friend WithEvents grHora As System.Windows.Forms.GroupBox
    Friend WithEvents Hora3 As System.Windows.Forms.RadioButton
    Friend WithEvents Hora2 As System.Windows.Forms.RadioButton
    Friend WithEvents Hora1 As System.Windows.Forms.RadioButton
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuConexDatos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuSalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuConexNAV As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResumenDia As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResumenPorOFToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txMetrosRodaja As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents chkTerminar As System.Windows.Forms.CheckBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents MenuAbrir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents grCopias As System.Windows.Forms.GroupBox
    Friend WithEvents txNoCopias As System.Windows.Forms.TextBox
    Friend WithEvents grEtPalet As System.Windows.Forms.GroupBox
    Friend WithEvents txEtiqPalet As System.Windows.Forms.TextBox
    Friend WithEvents etMenosCopias As System.Windows.Forms.Button
    Friend WithEvents etMasCopias As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txParcial As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents GrFecha As System.Windows.Forms.GroupBox
    Friend WithEvents MenuSinPalet As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txPalet As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents grRepetir As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ResumenTurnoLote As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuCambioTurno As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents etMenosFecha As System.Windows.Forms.Button
    Friend WithEvents etMasFecha As System.Windows.Forms.Button
    Friend WithEvents txFechaTrabajo As System.Windows.Forms.TextBox
    Friend WithEvents SoloImprimir As System.Windows.Forms.Button
    Friend WithEvents grOpciones As System.Windows.Forms.GroupBox
    Friend WithEvents chCalibre As System.Windows.Forms.CheckBox
    Friend WithEvents ChGramaje As System.Windows.Forms.CheckBox
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txMetrosPalet As System.Windows.Forms.TextBox
    Friend WithEvents EtMetrosPalet As System.Windows.Forms.Label
    Friend WithEvents EnviarOPTESTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grBobina As GroupBox
    Friend WithEvents BobinaMas As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txBobina As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents PesosPorOF As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents PesosPorOFyBobina As ToolStripMenuItem
    Friend WithEvents PesoPorBobina As ToolStripMenuItem
    Friend WithEvents RepetirEtiquetaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuModoTest As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents MODOToolStrip As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
    Friend WithEvents ImprimirQRPruebasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents MenuRechazo As ToolStripMenuItem
    Friend WithEvents Scrap As Button
End Class
