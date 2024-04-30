<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Lienzo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Lienzo))
        Me.txCalidad = New System.Windows.Forms.TextBox()
        Me.txCliente = New System.Windows.Forms.TextBox()
        Me.txFecha = New System.Windows.Forms.TextBox()
        Me.txAncho = New System.Windows.Forms.TextBox()
        Me.txRodajas = New System.Windows.Forms.TextBox()
        Me.txGramaje = New System.Windows.Forms.TextBox()
        Me.txCalibre = New System.Windows.Forms.TextBox()
        Me.txPalet = New System.Windows.Forms.TextBox()
        Me.txBruto = New System.Windows.Forms.TextBox()
        Me.txNeto = New System.Windows.Forms.TextBox()
        Me.txDummy = New System.Windows.Forms.TextBox()
        Me.txObservaciones01 = New System.Windows.Forms.TextBox()
        Me.txOF = New System.Windows.Forms.TextBox()
        Me.txObservaciones02 = New System.Windows.Forms.TextBox()
        Me.BarcodeLeiza = New System.Windows.Forms.PictureBox()
        Me.PrintDoc = New System.Drawing.Printing.PrintDocument()
        Me.txMostrarMetros = New System.Windows.Forms.TextBox()
        Me.txBobina = New System.Windows.Forms.TextBox()
        Me.Barcode1 = New TECIT.TBarCode.Windows.BarcodeControl()
        Me.Barcode3 = New TECIT.TBarCode.Windows.BarcodeControl()
        Me.Barcode2 = New TECIT.TBarCode.Windows.BarcodeControl()
        Me.Barcode1B = New TECIT.TBarCode.Windows.BarcodeControl()
        Me.BarcodeQR = New System.Windows.Forms.PictureBox()
        Me.PrintQR = New System.Drawing.Printing.PrintDocument()
        Me.PrintCZZ = New System.Drawing.Printing.PrintDocument()
        CType(Me.BarcodeLeiza, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarcodeQR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txCalidad
        '
        Me.txCalidad.Font = New System.Drawing.Font("Courier New", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txCalidad.Location = New System.Drawing.Point(14, 127)
        Me.txCalidad.Name = "txCalidad"
        Me.txCalidad.Size = New System.Drawing.Size(538, 49)
        Me.txCalidad.TabIndex = 0
        '
        'txCliente
        '
        Me.txCliente.Font = New System.Drawing.Font("Lucida Console", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txCliente.Location = New System.Drawing.Point(558, 148)
        Me.txCliente.Name = "txCliente"
        Me.txCliente.Size = New System.Drawing.Size(111, 31)
        Me.txCliente.TabIndex = 1
        '
        'txFecha
        '
        Me.txFecha.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txFecha.Location = New System.Drawing.Point(558, 127)
        Me.txFecha.Name = "txFecha"
        Me.txFecha.Size = New System.Drawing.Size(111, 23)
        Me.txFecha.TabIndex = 2
        '
        'txAncho
        '
        Me.txAncho.Font = New System.Drawing.Font("Courier New", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txAncho.Location = New System.Drawing.Point(12, 231)
        Me.txAncho.Name = "txAncho"
        Me.txAncho.Size = New System.Drawing.Size(107, 47)
        Me.txAncho.TabIndex = 3
        Me.txAncho.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txRodajas
        '
        Me.txRodajas.Enabled = False
        Me.txRodajas.Font = New System.Drawing.Font("Courier New", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txRodajas.Location = New System.Drawing.Point(154, 231)
        Me.txRodajas.Name = "txRodajas"
        Me.txRodajas.Size = New System.Drawing.Size(47, 47)
        Me.txRodajas.TabIndex = 4
        Me.txRodajas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txGramaje
        '
        Me.txGramaje.Font = New System.Drawing.Font("Courier New", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txGramaje.Location = New System.Drawing.Point(255, 231)
        Me.txGramaje.Name = "txGramaje"
        Me.txGramaje.Size = New System.Drawing.Size(191, 47)
        Me.txGramaje.TabIndex = 5
        Me.txGramaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txCalibre
        '
        Me.txCalibre.Font = New System.Drawing.Font("Courier New", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txCalibre.Location = New System.Drawing.Point(488, 231)
        Me.txCalibre.Name = "txCalibre"
        Me.txCalibre.Size = New System.Drawing.Size(182, 47)
        Me.txCalibre.TabIndex = 6
        Me.txCalibre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txPalet
        '
        Me.txPalet.Enabled = False
        Me.txPalet.Font = New System.Drawing.Font("Courier New", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txPalet.Location = New System.Drawing.Point(12, 317)
        Me.txPalet.Name = "txPalet"
        Me.txPalet.Size = New System.Drawing.Size(187, 47)
        Me.txPalet.TabIndex = 7
        Me.txPalet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txBruto
        '
        Me.txBruto.Enabled = False
        Me.txBruto.Font = New System.Drawing.Font("Courier New", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txBruto.Location = New System.Drawing.Point(255, 317)
        Me.txBruto.Name = "txBruto"
        Me.txBruto.Size = New System.Drawing.Size(167, 47)
        Me.txBruto.TabIndex = 8
        Me.txBruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txNeto
        '
        Me.txNeto.Enabled = False
        Me.txNeto.Font = New System.Drawing.Font("Courier New", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txNeto.Location = New System.Drawing.Point(488, 317)
        Me.txNeto.Name = "txNeto"
        Me.txNeto.Size = New System.Drawing.Size(156, 47)
        Me.txNeto.TabIndex = 9
        Me.txNeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txDummy
        '
        Me.txDummy.Font = New System.Drawing.Font("Courier New", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txDummy.Location = New System.Drawing.Point(127, 231)
        Me.txDummy.Name = "txDummy"
        Me.txDummy.Size = New System.Drawing.Size(21, 47)
        Me.txDummy.TabIndex = 10
        Me.txDummy.Text = "/"
        Me.txDummy.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txObservaciones01
        '
        Me.txObservaciones01.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txObservaciones01.Location = New System.Drawing.Point(376, 418)
        Me.txObservaciones01.MaxLength = 30
        Me.txObservaciones01.Name = "txObservaciones01"
        Me.txObservaciones01.Size = New System.Drawing.Size(292, 21)
        Me.txObservaciones01.TabIndex = 14
        '
        'txOF
        '
        Me.txOF.Enabled = False
        Me.txOF.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txOF.Location = New System.Drawing.Point(376, 436)
        Me.txOF.Name = "txOF"
        Me.txOF.Size = New System.Drawing.Size(84, 22)
        Me.txOF.TabIndex = 15
        '
        'txObservaciones02
        '
        Me.txObservaciones02.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txObservaciones02.Location = New System.Drawing.Point(376, 382)
        Me.txObservaciones02.MaxLength = 30
        Me.txObservaciones02.Name = "txObservaciones02"
        Me.txObservaciones02.Size = New System.Drawing.Size(160, 21)
        Me.txObservaciones02.TabIndex = 18
        '
        'BarcodeLeiza
        '
        Me.BarcodeLeiza.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BarcodeLeiza.Location = New System.Drawing.Point(376, 382)
        Me.BarcodeLeiza.Name = "BarcodeLeiza"
        Me.BarcodeLeiza.Size = New System.Drawing.Size(268, 45)
        Me.BarcodeLeiza.TabIndex = 19
        Me.BarcodeLeiza.TabStop = False
        Me.BarcodeLeiza.Visible = False
        '
        'PrintDoc
        '
        '
        'txMostrarMetros
        '
        Me.txMostrarMetros.Enabled = False
        Me.txMostrarMetros.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txMostrarMetros.Location = New System.Drawing.Point(470, 436)
        Me.txMostrarMetros.Name = "txMostrarMetros"
        Me.txMostrarMetros.Size = New System.Drawing.Size(140, 22)
        Me.txMostrarMetros.TabIndex = 20
        '
        'txBobina
        '
        Me.txBobina.Enabled = False
        Me.txBobina.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txBobina.Location = New System.Drawing.Point(154, 360)
        Me.txBobina.Name = "txBobina"
        Me.txBobina.Size = New System.Drawing.Size(74, 20)
        Me.txBobina.TabIndex = 21
        '
        'Barcode1
        '
        Me.Barcode1.Barcode.CharacterSpacing = 0R
        Me.Barcode1.Barcode.Data = "BarcodeControl2"
        Me.Barcode1.Barcode.Dpi = -1.0R
        Me.Barcode1.Barcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Barcode1.Barcode.FontHeight = 8
        Me.Barcode1.Barcode.FontName = "Microsoft Sans Serif"
        Me.Barcode1.Barcode.ModuleWidth = -1.0R
        Me.Barcode1.Barcode.QuietZones.Bottom.Size = 0R
        Me.Barcode1.Barcode.QuietZones.Left.Size = 0R
        Me.Barcode1.Barcode.QuietZones.Right.Size = 0R
        Me.Barcode1.Barcode.QuietZones.Top.Size = 0R
        Me.Barcode1.Barcode.TextClipping = False
        Me.Barcode1.Barcode.WordWrapping = False
        Me.Barcode1.Location = New System.Drawing.Point(14, 395)
        Me.Barcode1.Name = "Barcode1"
        Me.Barcode1.Size = New System.Drawing.Size(173, 58)
        Me.Barcode1.TabIndex = 24
        '
        'Barcode3
        '
        Me.Barcode3.Barcode.CharacterSpacing = 0R
        Me.Barcode3.Barcode.Data = "BarcodeControl2"
        Me.Barcode3.Barcode.Dpi = -1.0R
        Me.Barcode3.Barcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Barcode3.Barcode.FontHeight = 8
        Me.Barcode3.Barcode.FontName = "Microsoft Sans Serif"
        Me.Barcode3.Barcode.ModuleWidth = -1.0R
        Me.Barcode3.Barcode.QuietZones.Bottom.Size = 0R
        Me.Barcode3.Barcode.QuietZones.Left.Size = 0R
        Me.Barcode3.Barcode.QuietZones.Right.Size = 0R
        Me.Barcode3.Barcode.QuietZones.Top.Size = 0R
        Me.Barcode3.Barcode.TextClipping = False
        Me.Barcode3.Barcode.WordWrapping = False
        Me.Barcode3.Location = New System.Drawing.Point(219, 499)
        Me.Barcode3.Name = "Barcode3"
        Me.Barcode3.Size = New System.Drawing.Size(339, 58)
        Me.Barcode3.TabIndex = 26
        '
        'Barcode2
        '
        Me.Barcode2.Barcode.CharacterSpacing = 0R
        Me.Barcode2.Barcode.Data = "BarcodeControl2"
        Me.Barcode2.Barcode.Dpi = -1.0R
        Me.Barcode2.Barcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Barcode2.Barcode.FontHeight = 8
        Me.Barcode2.Barcode.FontName = "Microsoft Sans Serif"
        Me.Barcode2.Barcode.ModuleWidth = -1.0R
        Me.Barcode2.Barcode.QuietZones.Bottom.Size = 0R
        Me.Barcode2.Barcode.QuietZones.Left.Size = 0R
        Me.Barcode2.Barcode.QuietZones.Right.Size = 0R
        Me.Barcode2.Barcode.QuietZones.Top.Size = 0R
        Me.Barcode2.Barcode.TextClipping = False
        Me.Barcode2.Barcode.WordWrapping = False
        Me.Barcode2.Location = New System.Drawing.Point(12, 499)
        Me.Barcode2.Name = "Barcode2"
        Me.Barcode2.Size = New System.Drawing.Size(187, 58)
        Me.Barcode2.TabIndex = 25
        '
        'Barcode1B
        '
        Me.Barcode1B.Barcode.CharacterSpacing = 0R
        Me.Barcode1B.Barcode.Data = "BarcodeControl2"
        Me.Barcode1B.Barcode.Dpi = -1.0R
        Me.Barcode1B.Barcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Barcode1B.Barcode.FontHeight = 8
        Me.Barcode1B.Barcode.FontName = "Microsoft Sans Serif"
        Me.Barcode1B.Barcode.ModuleWidth = -1.0R
        Me.Barcode1B.Barcode.QuietZones.Bottom.Size = 0R
        Me.Barcode1B.Barcode.QuietZones.Left.Size = 0R
        Me.Barcode1B.Barcode.QuietZones.Right.Size = 0R
        Me.Barcode1B.Barcode.QuietZones.Top.Size = 0R
        Me.Barcode1B.Barcode.TextClipping = False
        Me.Barcode1B.Barcode.WordWrapping = False
        Me.Barcode1B.Location = New System.Drawing.Point(219, 395)
        Me.Barcode1B.Name = "Barcode1B"
        Me.Barcode1B.Size = New System.Drawing.Size(142, 58)
        Me.Barcode1B.TabIndex = 27
        '
        'BarcodeQR
        '
        Me.BarcodeQR.Location = New System.Drawing.Point(582, 487)
        Me.BarcodeQR.Name = "BarcodeQR"
        Me.BarcodeQR.Size = New System.Drawing.Size(87, 64)
        Me.BarcodeQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.BarcodeQR.TabIndex = 28
        Me.BarcodeQR.TabStop = False
        '
        'PrintQR
        '
        '
        'PrintCZZ
        '
        '
        'Lienzo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(681, 557)
        Me.Controls.Add(Me.BarcodeQR)
        Me.Controls.Add(Me.Barcode1B)
        Me.Controls.Add(Me.Barcode3)
        Me.Controls.Add(Me.Barcode2)
        Me.Controls.Add(Me.Barcode1)
        Me.Controls.Add(Me.txBobina)
        Me.Controls.Add(Me.txMostrarMetros)
        Me.Controls.Add(Me.BarcodeLeiza)
        Me.Controls.Add(Me.txObservaciones02)
        Me.Controls.Add(Me.txOF)
        Me.Controls.Add(Me.txObservaciones01)
        Me.Controls.Add(Me.txDummy)
        Me.Controls.Add(Me.txNeto)
        Me.Controls.Add(Me.txBruto)
        Me.Controls.Add(Me.txPalet)
        Me.Controls.Add(Me.txCalibre)
        Me.Controls.Add(Me.txGramaje)
        Me.Controls.Add(Me.txRodajas)
        Me.Controls.Add(Me.txAncho)
        Me.Controls.Add(Me.txFecha)
        Me.Controls.Add(Me.txCliente)
        Me.Controls.Add(Me.txCalidad)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Lienzo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Papel"
        CType(Me.BarcodeLeiza, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarcodeQR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txCalidad As System.Windows.Forms.TextBox
    Friend WithEvents txCliente As System.Windows.Forms.TextBox
    Friend WithEvents txFecha As System.Windows.Forms.TextBox
    Friend WithEvents txAncho As System.Windows.Forms.TextBox
    Friend WithEvents txRodajas As System.Windows.Forms.TextBox
    Friend WithEvents txGramaje As System.Windows.Forms.TextBox
    Friend WithEvents txCalibre As System.Windows.Forms.TextBox
    Friend WithEvents txPalet As System.Windows.Forms.TextBox
    Friend WithEvents txBruto As System.Windows.Forms.TextBox
    Friend WithEvents txNeto As System.Windows.Forms.TextBox
    Friend WithEvents txDummy As System.Windows.Forms.TextBox
    Friend WithEvents txObservaciones01 As System.Windows.Forms.TextBox
    Friend WithEvents txOF As System.Windows.Forms.TextBox
    Friend WithEvents txObservaciones02 As System.Windows.Forms.TextBox
    Friend WithEvents BarcodeLeiza As System.Windows.Forms.PictureBox
    Friend WithEvents PrintDoc As System.Drawing.Printing.PrintDocument
    Friend WithEvents txMostrarMetros As System.Windows.Forms.TextBox
    Friend WithEvents txBobina As TextBox
    Friend WithEvents Barcode1 As TECIT.TBarCode.Windows.BarcodeControl
    Friend WithEvents Barcode3 As TECIT.TBarCode.Windows.BarcodeControl
    Friend WithEvents Barcode2 As TECIT.TBarCode.Windows.BarcodeControl
    Friend WithEvents Barcode1B As TECIT.TBarCode.Windows.BarcodeControl
    Friend WithEvents BarcodeQR As PictureBox
    Friend WithEvents PrintQR As Printing.PrintDocument
    Friend WithEvents PrintCZZ As Printing.PrintDocument
End Class
