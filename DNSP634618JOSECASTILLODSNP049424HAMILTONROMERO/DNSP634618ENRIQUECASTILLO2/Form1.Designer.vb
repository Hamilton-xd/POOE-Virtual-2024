<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.ComboTipounidad = New System.Windows.Forms.ComboBox()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.comboUnidadEntrada = New System.Windows.Forms.ComboBox()
        Me.comboUnidadSalida = New System.Windows.Forms.ComboBox()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnConvertir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ComboTipounidad
        '
        Me.ComboTipounidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboTipounidad.FormattingEnabled = True
        Me.ComboTipounidad.Items.AddRange(New Object() {"Longitud", "Masa", "Tiempo", "Almacenamiento"})
        Me.ComboTipounidad.Location = New System.Drawing.Point(336, 30)
        Me.ComboTipounidad.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboTipounidad.Name = "ComboTipounidad"
        Me.ComboTipounidad.Size = New System.Drawing.Size(177, 24)
        Me.ComboTipounidad.TabIndex = 0
        '
        'lblResultado
        '
        Me.lblResultado.AutoSize = True
        Me.lblResultado.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultado.Location = New System.Drawing.Point(100, 266)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(130, 24)
        Me.lblResultado.TabIndex = 1
        Me.lblResultado.Text = "RESULTADO"
        '
        'comboUnidadEntrada
        '
        Me.comboUnidadEntrada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboUnidadEntrada.FormattingEnabled = True
        Me.comboUnidadEntrada.Items.AddRange(New Object() {"Kilómetros", "", "Centímetros ", "", "Milímetros", "", "Pulgadas", "", "Metros ", "Kilogramos", "", "Gramos", "Miligramos", "", "Libras", "Horas", "", "Minutos", "", "Segundos ", "", "Milisegundos", "Kilobytes", "", "Megabytes", "", "Gigabytes", "", "Bytes"})
        Me.comboUnidadEntrada.Location = New System.Drawing.Point(336, 110)
        Me.comboUnidadEntrada.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.comboUnidadEntrada.Name = "comboUnidadEntrada"
        Me.comboUnidadEntrada.Size = New System.Drawing.Size(177, 24)
        Me.comboUnidadEntrada.TabIndex = 2
        '
        'comboUnidadSalida
        '
        Me.comboUnidadSalida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboUnidadSalida.FormattingEnabled = True
        Me.comboUnidadSalida.Items.AddRange(New Object() {"Kilómetros", "", "Centímetros ", "", "Milímetros", "", "Pulgadas", "", "Metros ", "Kilogramos", "", "Gramos", "Miligramos", "", "Libras", "Horas", "", "Minutos", "", "Segundos ", "", "Milisegundos", "Kilobytes", "", "Megabytes", "", "Gigabytes", "", "Bytes"})
        Me.comboUnidadSalida.Location = New System.Drawing.Point(336, 183)
        Me.comboUnidadSalida.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.comboUnidadSalida.Name = "comboUnidadSalida"
        Me.comboUnidadSalida.Size = New System.Drawing.Size(177, 24)
        Me.comboUnidadSalida.TabIndex = 3
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(504, 266)
        Me.txtValor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(147, 22)
        Me.txtValor.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(100, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 24)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "TIPO:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(100, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 24)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "UNIDAD INICIAL"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(100, 183)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 24)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "UNIDAD FINAL"
        '
        'btnConvertir
        '
        Me.btnConvertir.Location = New System.Drawing.Point(267, 324)
        Me.btnConvertir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnConvertir.Name = "btnConvertir"
        Me.btnConvertir.Size = New System.Drawing.Size(135, 38)
        Me.btnConvertir.TabIndex = 8
        Me.btnConvertir.Text = "CONVERTIR"
        Me.btnConvertir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(729, 382)
        Me.Controls.Add(Me.btnConvertir)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.comboUnidadSalida)
        Me.Controls.Add(Me.comboUnidadEntrada)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.ComboTipounidad)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboTipounidad As ComboBox
    Friend WithEvents lblResultado As Label
    Friend WithEvents comboUnidadEntrada As ComboBox
    Friend WithEvents comboUnidadSalida As ComboBox
    Friend WithEvents txtValor As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnConvertir As Button
End Class
