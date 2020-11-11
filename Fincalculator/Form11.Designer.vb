<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form11
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form11))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.TxtMENSUAL = New System.Windows.Forms.TextBox
        Me.TxtTMP = New System.Windows.Forms.TextBox
        Me.TxtINT = New System.Windows.Forms.TextBox
        Me.TxtAP = New System.Windows.Forms.TextBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TxtMENSUAL)
        Me.GroupBox1.Controls.Add(Me.TxtTMP)
        Me.GroupBox1.Controls.Add(Me.TxtINT)
        Me.GroupBox1.Controls.Add(Me.TxtAP)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(401, 228)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Calcular  Prestamo Hipoteca"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(25, 169)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 53)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Limpiar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(22, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(363, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "---------------------------------------------------------------------------------" & _
            "--------"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(376, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "(%)"
        '
        'TxtMENSUAL
        '
        Me.TxtMENSUAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMENSUAL.Location = New System.Drawing.Point(150, 120)
        Me.TxtMENSUAL.Name = "TxtMENSUAL"
        Me.TxtMENSUAL.Size = New System.Drawing.Size(220, 20)
        Me.TxtMENSUAL.TabIndex = 7
        Me.TxtMENSUAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtTMP
        '
        Me.TxtTMP.Location = New System.Drawing.Point(150, 81)
        Me.TxtTMP.Name = "TxtTMP"
        Me.TxtTMP.Size = New System.Drawing.Size(220, 20)
        Me.TxtTMP.TabIndex = 6
        Me.TxtTMP.Text = "30"
        Me.TxtTMP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtINT
        '
        Me.TxtINT.Location = New System.Drawing.Point(150, 55)
        Me.TxtINT.Name = "TxtINT"
        Me.TxtINT.Size = New System.Drawing.Size(220, 20)
        Me.TxtINT.TabIndex = 5
        Me.TxtINT.Text = "9"
        Me.TxtINT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtAP
        '
        Me.TxtAP.Location = New System.Drawing.Point(150, 29)
        Me.TxtAP.Name = "TxtAP"
        Me.TxtAP.Size = New System.Drawing.Size(220, 20)
        Me.TxtAP.TabIndex = 4
        Me.TxtAP.Text = "100000"
        Me.TxtAP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(270, 169)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 53)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Calcular"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(54, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Cuota Mensual $:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(52, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tiempo (en años):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tasa de Interés (%):"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Monto del Préstamo $:"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.MediumBlue
        Me.Button1.Location = New System.Drawing.Point(310, 256)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 53)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Regresar Al Menú"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form11
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 321)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form11"
        Me.Text = "Cálculo del Préstamo de Hipoteca"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtMENSUAL As System.Windows.Forms.TextBox
    Friend WithEvents TxtTMP As System.Windows.Forms.TextBox
    Friend WithEvents TxtINT As System.Windows.Forms.TextBox
    Friend WithEvents TxtAP As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
