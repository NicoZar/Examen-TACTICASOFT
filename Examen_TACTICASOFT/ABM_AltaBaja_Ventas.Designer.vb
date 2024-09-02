<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ABM_AltaBaja_Ventas
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
        Me.Button_Alta = New System.Windows.Forms.Button()
        Me.Button_Baja = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button_Alta
        '
        Me.Button_Alta.Font = New System.Drawing.Font("Sylfaen", 12.0!)
        Me.Button_Alta.Location = New System.Drawing.Point(28, 30)
        Me.Button_Alta.Name = "Button_Alta"
        Me.Button_Alta.Size = New System.Drawing.Size(170, 90)
        Me.Button_Alta.TabIndex = 0
        Me.Button_Alta.Text = "Crear venta"
        Me.Button_Alta.UseVisualStyleBackColor = True
        '
        'Button_Baja
        '
        Me.Button_Baja.Font = New System.Drawing.Font("Sylfaen", 12.0!)
        Me.Button_Baja.Location = New System.Drawing.Point(28, 140)
        Me.Button_Baja.Name = "Button_Baja"
        Me.Button_Baja.Size = New System.Drawing.Size(170, 90)
        Me.Button_Baja.TabIndex = 1
        Me.Button_Baja.Text = "Eliminar venta"
        Me.Button_Baja.UseVisualStyleBackColor = True
        '
        'ABM_Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(227, 255)
        Me.Controls.Add(Me.Button_Baja)
        Me.Controls.Add(Me.Button_Alta)
        Me.Name = "ABM_Ventas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Opciones"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button_Alta As Button
    Friend WithEvents Button_Baja As Button
End Class
