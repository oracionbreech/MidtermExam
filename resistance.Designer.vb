<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class resistance
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.clear_voltage = New System.Windows.Forms.Button()
        Me.compute_voltage = New System.Windows.Forms.Button()
        Me.voltage_label = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.current_value = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.resistance_value = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Resistance Computation"
        '
        'clear_voltage
        '
        Me.clear_voltage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear_voltage.Location = New System.Drawing.Point(120, 253)
        Me.clear_voltage.Name = "clear_voltage"
        Me.clear_voltage.Size = New System.Drawing.Size(95, 31)
        Me.clear_voltage.TabIndex = 16
        Me.clear_voltage.Text = "Clear"
        Me.clear_voltage.UseVisualStyleBackColor = True
        '
        'compute_voltage
        '
        Me.compute_voltage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.compute_voltage.Location = New System.Drawing.Point(19, 253)
        Me.compute_voltage.Name = "compute_voltage"
        Me.compute_voltage.Size = New System.Drawing.Size(95, 31)
        Me.compute_voltage.TabIndex = 15
        Me.compute_voltage.Text = "Compute"
        Me.compute_voltage.UseVisualStyleBackColor = True
        '
        'voltage_label
        '
        Me.voltage_label.AutoSize = True
        Me.voltage_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.voltage_label.Location = New System.Drawing.Point(201, 174)
        Me.voltage_label.Name = "voltage_label"
        Me.voltage_label.Size = New System.Drawing.Size(45, 24)
        Me.voltage_label.TabIndex = 14
        Me.voltage_label.Text = "0.00"
        Me.voltage_label.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(175, 24)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Resistance value is:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'current_value
        '
        Me.current_value.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.current_value.Location = New System.Drawing.Point(205, 100)
        Me.current_value.Name = "current_value"
        Me.current_value.Size = New System.Drawing.Size(100, 29)
        Me.current_value.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 24)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Value for current:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'resistance_value
        '
        Me.resistance_value.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.resistance_value.Location = New System.Drawing.Point(205, 53)
        Me.resistance_value.Name = "resistance_value"
        Me.resistance_value.Size = New System.Drawing.Size(100, 29)
        Me.resistance_value.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 24)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Value for voltage"
        '
        'resistance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.clear_voltage)
        Me.Controls.Add(Me.compute_voltage)
        Me.Controls.Add(Me.voltage_label)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.current_value)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.resistance_value)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "resistance"
        Me.Size = New System.Drawing.Size(321, 336)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents clear_voltage As Button
    Friend WithEvents compute_voltage As Button
    Friend WithEvents voltage_label As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents current_value As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents resistance_value As TextBox
    Friend WithEvents Label2 As Label
End Class
