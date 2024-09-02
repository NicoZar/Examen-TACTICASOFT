<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Buscador_Ventas
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
        Me.TextBox_IdCliente = New System.Windows.Forms.TextBox()
        Me.TextBox_FechaVenta = New System.Windows.Forms.TextBox()
        Me.TextBox_TotalVenta = New System.Windows.Forms.TextBox()
        Me.TextBox_IDVenta = New System.Windows.Forms.TextBox()
        Me.Button_Buscar = New System.Windows.Forms.Button()
        Me.Button_Modificar = New System.Windows.Forms.Button()
        Me.ListView_Ventas = New System.Windows.Forms.ListView()
        Me.Column_IdCliente = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Column_NombreCliente = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Column_Fecha = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Column_IdVenta = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Column_TotalVenta = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label_IdCliente = New System.Windows.Forms.Label()
        Me.Label_FechaVenta = New System.Windows.Forms.Label()
        Me.Label_TotalVenta = New System.Windows.Forms.Label()
        Me.Label_IDVenta = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBox_IdCliente
        '
        Me.TextBox_IdCliente.Font = New System.Drawing.Font("Sylfaen", 12.0!)
        Me.TextBox_IdCliente.Location = New System.Drawing.Point(175, 29)
        Me.TextBox_IdCliente.Name = "TextBox_IdCliente"
        Me.TextBox_IdCliente.Size = New System.Drawing.Size(148, 29)
        Me.TextBox_IdCliente.TabIndex = 3
        '
        'TextBox_FechaVenta
        '
        Me.TextBox_FechaVenta.Font = New System.Drawing.Font("Sylfaen", 12.0!)
        Me.TextBox_FechaVenta.Location = New System.Drawing.Point(175, 64)
        Me.TextBox_FechaVenta.Name = "TextBox_FechaVenta"
        Me.TextBox_FechaVenta.Size = New System.Drawing.Size(148, 29)
        Me.TextBox_FechaVenta.TabIndex = 5
        '
        'TextBox_TotalVenta
        '
        Me.TextBox_TotalVenta.Font = New System.Drawing.Font("Sylfaen", 12.0!)
        Me.TextBox_TotalVenta.Location = New System.Drawing.Point(488, 29)
        Me.TextBox_TotalVenta.Name = "TextBox_TotalVenta"
        Me.TextBox_TotalVenta.Size = New System.Drawing.Size(148, 29)
        Me.TextBox_TotalVenta.TabIndex = 7
        '
        'TextBox_IDVenta
        '
        Me.TextBox_IDVenta.Font = New System.Drawing.Font("Sylfaen", 12.0!)
        Me.TextBox_IDVenta.Location = New System.Drawing.Point(488, 64)
        Me.TextBox_IDVenta.Name = "TextBox_IDVenta"
        Me.TextBox_IDVenta.Size = New System.Drawing.Size(148, 29)
        Me.TextBox_IDVenta.TabIndex = 9
        '
        'Button_Buscar
        '
        Me.Button_Buscar.Font = New System.Drawing.Font("Sylfaen", 12.0!)
        Me.Button_Buscar.Location = New System.Drawing.Point(651, 29)
        Me.Button_Buscar.Name = "Button_Buscar"
        Me.Button_Buscar.Size = New System.Drawing.Size(76, 64)
        Me.Button_Buscar.TabIndex = 11
        Me.Button_Buscar.Text = "Buscar"
        Me.Button_Buscar.UseVisualStyleBackColor = True
        '
        'Button_Modificar
        '
        Me.Button_Modificar.Font = New System.Drawing.Font("Sylfaen", 12.0!)
        Me.Button_Modificar.Location = New System.Drawing.Point(579, 446)
        Me.Button_Modificar.Name = "Button_Modificar"
        Me.Button_Modificar.Size = New System.Drawing.Size(148, 39)
        Me.Button_Modificar.TabIndex = 12
        Me.Button_Modificar.Text = "Modificar venta"
        Me.Button_Modificar.UseVisualStyleBackColor = True
        '
        'ListView_Ventas
        '
        Me.ListView_Ventas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Column_IdCliente, Me.Column_NombreCliente, Me.Column_Fecha, Me.Column_IdVenta, Me.Column_TotalVenta})
        Me.ListView_Ventas.Font = New System.Drawing.Font("Sylfaen", 12.0!)
        Me.ListView_Ventas.FullRowSelect = True
        Me.ListView_Ventas.HideSelection = False
        Me.ListView_Ventas.Location = New System.Drawing.Point(10, 99)
        Me.ListView_Ventas.Name = "ListView_Ventas"
        Me.ListView_Ventas.Size = New System.Drawing.Size(716, 327)
        Me.ListView_Ventas.TabIndex = 13
        Me.ListView_Ventas.UseCompatibleStateImageBehavior = False
        Me.ListView_Ventas.View = System.Windows.Forms.View.Details
        '
        'Column_IdCliente
        '
        Me.Column_IdCliente.Text = "Cliente N°"
        Me.Column_IdCliente.Width = 89
        '
        'Column_NombreCliente
        '
        Me.Column_NombreCliente.Text = "Nombre del cliente"
        Me.Column_NombreCliente.Width = 224
        '
        'Column_Fecha
        '
        Me.Column_Fecha.Text = "Fecha"
        Me.Column_Fecha.Width = 151
        '
        'Column_IdVenta
        '
        Me.Column_IdVenta.Text = "Venta N°"
        Me.Column_IdVenta.Width = 113
        '
        'Column_TotalVenta
        '
        Me.Column_TotalVenta.Text = "Total"
        Me.Column_TotalVenta.Width = 135
        '
        'Label_IdCliente
        '
        Me.Label_IdCliente.AutoSize = True
        Me.Label_IdCliente.Font = New System.Drawing.Font("Sylfaen", 12.0!)
        Me.Label_IdCliente.Location = New System.Drawing.Point(21, 32)
        Me.Label_IdCliente.Name = "Label_IdCliente"
        Me.Label_IdCliente.Size = New System.Drawing.Size(131, 22)
        Me.Label_IdCliente.TabIndex = 14
        Me.Label_IdCliente.Text = "Numero de cliente"
        '
        'Label_FechaVenta
        '
        Me.Label_FechaVenta.AutoSize = True
        Me.Label_FechaVenta.Font = New System.Drawing.Font("Sylfaen", 12.0!)
        Me.Label_FechaVenta.Location = New System.Drawing.Point(21, 67)
        Me.Label_FechaVenta.Name = "Label_FechaVenta"
        Me.Label_FechaVenta.Size = New System.Drawing.Size(106, 22)
        Me.Label_FechaVenta.TabIndex = 15
        Me.Label_FechaVenta.Text = "Fecha de venta"
        '
        'Label_TotalVenta
        '
        Me.Label_TotalVenta.AutoSize = True
        Me.Label_TotalVenta.Font = New System.Drawing.Font("Sylfaen", 12.0!)
        Me.Label_TotalVenta.Location = New System.Drawing.Point(347, 32)
        Me.Label_TotalVenta.Name = "Label_TotalVenta"
        Me.Label_TotalVenta.Size = New System.Drawing.Size(107, 22)
        Me.Label_TotalVenta.TabIndex = 16
        Me.Label_TotalVenta.Text = "Total de venta "
        '
        'Label_IDVenta
        '
        Me.Label_IDVenta.AutoSize = True
        Me.Label_IDVenta.Font = New System.Drawing.Font("Sylfaen", 12.0!)
        Me.Label_IDVenta.Location = New System.Drawing.Point(347, 67)
        Me.Label_IDVenta.Name = "Label_IDVenta"
        Me.Label_IDVenta.Size = New System.Drawing.Size(122, 22)
        Me.Label_IDVenta.TabIndex = 17
        Me.Label_IDVenta.Text = "Numero de venta"
        '
        'Buscador_Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(738, 496)
        Me.Controls.Add(Me.Label_IDVenta)
        Me.Controls.Add(Me.Label_TotalVenta)
        Me.Controls.Add(Me.Label_FechaVenta)
        Me.Controls.Add(Me.Label_IdCliente)
        Me.Controls.Add(Me.ListView_Ventas)
        Me.Controls.Add(Me.Button_Modificar)
        Me.Controls.Add(Me.Button_Buscar)
        Me.Controls.Add(Me.TextBox_IDVenta)
        Me.Controls.Add(Me.TextBox_TotalVenta)
        Me.Controls.Add(Me.TextBox_FechaVenta)
        Me.Controls.Add(Me.TextBox_IdCliente)
        Me.Name = "Buscador_Ventas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscador_Ventas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox_IdCliente As TextBox
    Friend WithEvents TextBox_FechaVenta As TextBox
    Friend WithEvents TextBox_TotalVenta As TextBox
    Friend WithEvents TextBox_IDVenta As TextBox
    Friend WithEvents Button_Buscar As Button
    Friend WithEvents Button_Modificar As Button
    Friend WithEvents ListView_Ventas As ListView
    Friend WithEvents Column_IdCliente As ColumnHeader
    Friend WithEvents Column_Fecha As ColumnHeader
    Friend WithEvents Column_IdVenta As ColumnHeader
    Friend WithEvents Column_TotalVenta As ColumnHeader
    Friend WithEvents Label_IdCliente As Label
    Friend WithEvents Label_FechaVenta As Label
    Friend WithEvents Label_TotalVenta As Label
    Friend WithEvents Label_IDVenta As Label
    Friend WithEvents Column_NombreCliente As ColumnHeader
End Class
