<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReportV
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.Etiquetas_SalidaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportingNAVDataSet = New EtBobina.ReportingNAVDataSet()
        Me.Etiquetas_SalidaTableAdapter = New EtBobina.ReportingNAVDataSetTableAdapters.Etiquetas_SalidaTableAdapter()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ReportingNAVDataSet1 = New EtBobina.ReportingNAVDataSet1()
        Me.ReportingNAVDataSet2 = New EtBobina.ReportingNAVDataSet2()
        CType(Me.Etiquetas_SalidaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportingNAVDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportingNAVDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportingNAVDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Etiquetas_SalidaBindingSource
        '
        Me.Etiquetas_SalidaBindingSource.DataMember = "Etiquetas Salida"
        Me.Etiquetas_SalidaBindingSource.DataSource = Me.ReportingNAVDataSet
        '
        'ReportingNAVDataSet
        '
        Me.ReportingNAVDataSet.DataSetName = "ReportingNAVDataSet"
        Me.ReportingNAVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Etiquetas_SalidaTableAdapter
        '
        Me.Etiquetas_SalidaTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.Etiquetas_SalidaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.EnableHyperlinks = True
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "EtBobina.Report9.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1016, 399)
        Me.ReportViewer1.TabIndex = 0
        '
        'ReportingNAVDataSet1
        '
        Me.ReportingNAVDataSet1.DataSetName = "ReportingNAVDataSet1"
        Me.ReportingNAVDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportingNAVDataSet2
        '
        Me.ReportingNAVDataSet2.DataSetName = "ReportingNAVDataSet2"
        Me.ReportingNAVDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 399)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "ReportV"
        Me.Text = "ReportV"
        CType(Me.Etiquetas_SalidaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportingNAVDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportingNAVDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportingNAVDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Etiquetas_SalidaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReportingNAVDataSet As EtBobina.ReportingNAVDataSet
    Friend WithEvents Etiquetas_SalidaTableAdapter As EtBobina.ReportingNAVDataSetTableAdapters.Etiquetas_SalidaTableAdapter
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ReportingNAVDataSet1 As ReportingNAVDataSet1
    Friend WithEvents ReportingNAVDataSet2 As ReportingNAVDataSet2
End Class
