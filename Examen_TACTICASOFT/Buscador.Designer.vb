<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Buscador
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Buscador_Clientes = New System.Windows.Forms.ToolStripMenuItem()
        Me.Buscador_Productos = New System.Windows.Forms.ToolStripMenuItem()
        Me.Column_IdCliente = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Column_NombreCliente = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Column_Telefono = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Column_Correo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Buscador_Clientes, Me.Buscador_Productos})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(738, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Buscador_Clientes
        '
        Me.Buscador_Clientes.Name = "Buscador_Clientes"
        Me.Buscador_Clientes.Size = New System.Drawing.Size(61, 20)
        Me.Buscador_Clientes.Text = "Clientes"
        '
        'Buscador_Productos
        '
        Me.Buscador_Productos.Name = "Buscador_Productos"
        Me.Buscador_Productos.Size = New System.Drawing.Size(73, 20)
        Me.Buscador_Productos.Text = "Productos"
        '
        'Column_IdCliente
        '
        Me.Column_IdCliente.DisplayIndex = 0
        Me.Column_IdCliente.Text = "Cliente N°"
        Me.Column_IdCliente.Width = 89
        '
        'Column_NombreCliente
        '
        Me.Column_NombreCliente.DisplayIndex = 1
        Me.Column_NombreCliente.Text = "Nombre del cliente"
        Me.Column_NombreCliente.Width = 213
        '
        'Column_Telefono
        '
        Me.Column_Telefono.DisplayIndex = 2
        Me.Column_Telefono.Text = "Telefono"
        Me.Column_Telefono.Width = 151
        '
        'Column_Correo
        '
        Me.Column_Correo.DisplayIndex = 3
        Me.Column_Correo.Text = "Correo"
        Me.Column_Correo.Width = 228
        '
        'Buscador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(738, 520)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Buscador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscadores"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Buscador_Clientes As ToolStripMenuItem
    Friend WithEvents Buscador_Productos As ToolStripMenuItem
    Friend WithEvents Column_IdCliente As ColumnHeader
    Friend WithEvents Column_NombreCliente As ColumnHeader
    Friend WithEvents Column_Telefono As ColumnHeader
    Friend WithEvents Column_Correo As ColumnHeader
End Class
