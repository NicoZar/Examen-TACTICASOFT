<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ABM
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
        Me.ButtonABM_AltaBaja_Productos = New System.Windows.Forms.Button()
        Me.ButtonABM_AltaBaja_Clientes = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonABM_AltaBaja_Productos
        '
        Me.ButtonABM_AltaBaja_Productos.Font = New System.Drawing.Font("Sylfaen", 12.0!)
        Me.ButtonABM_AltaBaja_Productos.Location = New System.Drawing.Point(36, 131)
        Me.ButtonABM_AltaBaja_Productos.Name = "ButtonABM_AltaBaja_Productos"
        Me.ButtonABM_AltaBaja_Productos.Size = New System.Drawing.Size(170, 90)
        Me.ButtonABM_AltaBaja_Productos.TabIndex = 3
        Me.ButtonABM_AltaBaja_Productos.Text = "Crear o eliminar productos"
        Me.ButtonABM_AltaBaja_Productos.UseVisualStyleBackColor = True
        '
        'ButtonABM_AltaBaja_Clientes
        '
        Me.ButtonABM_AltaBaja_Clientes.Font = New System.Drawing.Font("Sylfaen", 12.0!)
        Me.ButtonABM_AltaBaja_Clientes.Location = New System.Drawing.Point(36, 21)
        Me.ButtonABM_AltaBaja_Clientes.Name = "ButtonABM_AltaBaja_Clientes"
        Me.ButtonABM_AltaBaja_Clientes.Size = New System.Drawing.Size(170, 90)
        Me.ButtonABM_AltaBaja_Clientes.TabIndex = 2
        Me.ButtonABM_AltaBaja_Clientes.Text = "Crear o eliminar clientes"
        Me.ButtonABM_AltaBaja_Clientes.UseVisualStyleBackColor = True
        '
        'ABM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(246, 240)
        Me.Controls.Add(Me.ButtonABM_AltaBaja_Productos)
        Me.Controls.Add(Me.ButtonABM_AltaBaja_Clientes)
        Me.Name = "ABM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clientes y Productos"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonABM_AltaBaja_Productos As Button
    Friend WithEvents ButtonABM_AltaBaja_Clientes As Button
End Class
