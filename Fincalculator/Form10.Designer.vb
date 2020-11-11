<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form10
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form10))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.TxtCAPI = New System.Windows.Forms.TextBox
        Me.TxtTIME = New System.Windows.Forms.TextBox
        Me.TxtINT = New System.Windows.Forms.TextBox
        Me.TxtCAP = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
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
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.TxtCAPI)
        Me.GroupBox1.Controls.Add(Me.TxtTIME)
        Me.GroupBox1.Controls.Add(Me.TxtINT)
        Me.GroupBox1.Controls.Add(Me.TxtCAP)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(299, 242)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Amortizacion Simple"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(272, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "(%)"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(19, 179)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(99, 48)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "Limpiar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(177, 179)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(99, 48)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Calcular"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TxtCAPI
        '
        Me.TxtCAPI.Location = New System.Drawing.Point(111, 138)
        Me.TxtCAPI.Name = "TxtCAPI"
        Me.TxtCAPI.Size = New System.Drawing.Size(155, 20)
        Me.TxtCAPI.TabIndex = 13
        Me.TxtCAPI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtTIME
        '
        Me.TxtTIME.Location = New System.Drawing.Point(111, 86)
        Me.TxtTIME.Name = "TxtTIME"
        Me.TxtTIME.Size = New System.Drawing.Size(155, 20)
        Me.TxtTIME.TabIndex = 12
        Me.TxtTIME.Text = "2"
        Me.TxtTIME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtINT
        '
        Me.TxtINT.Location = New System.Drawing.Point(112, 60)
        Me.TxtINT.Name = "TxtINT"
        Me.TxtINT.Size = New System.Drawing.Size(154, 20)
        Me.TxtINT.TabIndex = 11
        Me.TxtINT.Text = "10"
        Me.TxtINT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtCAP
        '
        Me.TxtCAP.Location = New System.Drawing.Point(112, 33)
        Me.TxtCAP.Name = "TxtCAP"
        Me.TxtCAP.Size = New System.Drawing.Size(154, 20)
        Me.TxtCAP.TabIndex = 10
        Me.TxtCAP.Text = "200"
        Me.TxtCAP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(283, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "---------------------------------------------------------------------"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Capital Inicial $:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tiempo (en años):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tasa de Interés (%):"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(66, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Capital:"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.MediumBlue
        Me.Button1.Location = New System.Drawing.Point(213, 271)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 48)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Regresar al Menú"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(318, 331)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form10"
        Me.Text = "Amortizacion Simple"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtTIME As System.Windows.Forms.TextBox
    Friend WithEvents TxtINT As System.Windows.Forms.TextBox
    Friend WithEvents TxtCAP As System.Windows.Forms.TextBox
    Friend WithEvents TxtCAPI As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
