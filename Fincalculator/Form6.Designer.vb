﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.TxtDEP = New System.Windows.Forms.TextBox
        Me.TxtUTIL = New System.Windows.Forms.TextBox
        Me.TxtDES = New System.Windows.Forms.TextBox
        Me.TxtACT = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TxtDEP)
        Me.GroupBox1.Controls.Add(Me.TxtUTIL)
        Me.GroupBox1.Controls.Add(Me.TxtDES)
        Me.GroupBox1.Controls.Add(Me.TxtACT)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(302, 205)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Calcular Depreciacion (Metodo Linea Recta)"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(208, 154)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 44)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Calcular"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(295, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "------------------------------------------------------------------------"
        '
        'TxtDEP
        '
        Me.TxtDEP.Location = New System.Drawing.Point(183, 128)
        Me.TxtDEP.Name = "TxtDEP"
        Me.TxtDEP.Size = New System.Drawing.Size(100, 20)
        Me.TxtDEP.TabIndex = 7
        Me.TxtDEP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtUTIL
        '
        Me.TxtUTIL.Location = New System.Drawing.Point(183, 90)
        Me.TxtUTIL.Name = "TxtUTIL"
        Me.TxtUTIL.Size = New System.Drawing.Size(100, 20)
        Me.TxtUTIL.TabIndex = 6
        Me.TxtUTIL.Text = "7"
        Me.TxtUTIL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtDES
        '
        Me.TxtDES.Location = New System.Drawing.Point(183, 63)
        Me.TxtDES.Name = "TxtDES"
        Me.TxtDES.Size = New System.Drawing.Size(100, 20)
        Me.TxtDES.TabIndex = 5
        Me.TxtDES.Text = "34000"
        Me.TxtDES.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtACT
        '
        Me.TxtACT.Location = New System.Drawing.Point(183, 33)
        Me.TxtACT.Name = "TxtACT"
        Me.TxtACT.Size = New System.Drawing.Size(100, 20)
        Me.TxtACT.TabIndex = 4
        Me.TxtACT.Text = "160000"
        Me.TxtACT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(4, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(175, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Alícuota por Depreciacion Anual $:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(81, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Vida Útil (en años):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(68, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Valor del Desecho. $:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(78, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Costo del Activo. $:"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.MediumBlue
        Me.Button1.Location = New System.Drawing.Point(221, 224)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 44)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Regresar al Menú"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(17, 224)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 44)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Limpiar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 274)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form6"
        Me.Text = "Depreciacion (Linea Recta)"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtDEP As System.Windows.Forms.TextBox
    Friend WithEvents TxtUTIL As System.Windows.Forms.TextBox
    Friend WithEvents TxtDES As System.Windows.Forms.TextBox
    Friend WithEvents TxtACT As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
