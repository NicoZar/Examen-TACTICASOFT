<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Formulario
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
        Me.Button_ABM = New System.Windows.Forms.Button()
        Me.Bt_Buscador = New System.Windows.Forms.Button()
        Me.Button_ABMVentas = New System.Windows.Forms.Button()
        Me.Bt_BuscadorVentas = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button_ABM
        '
        Me.Button_ABM.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_ABM.Font = New System.Drawing.Font("Sylfaen", 12.0!)
        Me.Button_ABM.Location = New System.Drawing.Point(16, 17)
        Me.Button_ABM.Name = "Button_ABM"
        Me.Button_ABM.Size = New System.Drawing.Size(189, 80)
        Me.Button_ABM.TabIndex = 0
        Me.Button_ABM.Text = "Clientes y Productos ABM"
        Me.Button_ABM.UseVisualStyleBackColor = True
        '
        'Bt_Buscador
        '
        Me.Bt_Buscador.Font = New System.Drawing.Font("Sylfaen", 12.0!)
        Me.Bt_Buscador.Location = New System.Drawing.Point(229, 17)
        Me.Bt_Buscador.Name = "Bt_Buscador"
        Me.Bt_Buscador.Size = New System.Drawing.Size(189, 80)
        Me.Bt_Buscador.TabIndex = 1
        Me.Bt_Buscador.Text = "Clientes y Productos Buscador"
        Me.Bt_Buscador.UseVisualStyleBackColor = True
        '
        'Button_ABMVentas
        '
        Me.Button_ABMVentas.Font = New System.Drawing.Font("Sylfaen", 12.0!)
        Me.Button_ABMVentas.Location = New System.Drawing.Point(16, 118)
        Me.Button_ABMVentas.Name = "Button_ABMVentas"
        Me.Button_ABMVentas.Size = New System.Drawing.Size(189, 80)
        Me.Button_ABMVentas.TabIndex = 3
        Me.Button_ABMVentas.Text = "Ventas ABM"
        Me.Button_ABMVentas.UseVisualStyleBackColor = True
        '
        'Bt_BuscadorVentas
        '
        Me.Bt_BuscadorVentas.Font = New System.Drawing.Font("Sylfaen", 12.0!)
        Me.Bt_BuscadorVentas.Location = New System.Drawing.Point(229, 118)
        Me.Bt_BuscadorVentas.Name = "Bt_BuscadorVentas"
        Me.Bt_BuscadorVentas.Size = New System.Drawing.Size(189, 80)
        Me.Bt_BuscadorVentas.TabIndex = 4
        Me.Bt_BuscadorVentas.Text = "Ventas Buscador"
        Me.Bt_BuscadorVentas.UseVisualStyleBackColor = True
        '
        'Formulario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 210)
        Me.Controls.Add(Me.Bt_BuscadorVentas)
        Me.Controls.Add(Me.Button_ABMVentas)
        Me.Controls.Add(Me.Bt_Buscador)
        Me.Controls.Add(Me.Button_ABM)
        Me.Name = "Formulario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Opciones"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button_ABM As Button
    Friend WithEvents Bt_Buscador As Button
    Friend WithEvents Button_ABMVentas As Button
    Friend WithEvents Bt_BuscadorVentas As Button
End Class
