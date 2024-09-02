<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ABM_Modificar_Ventas
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
        Me.Menu_ABM_Ventas = New System.Windows.Forms.MenuStrip()
        Me.ModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox_VentaID = New System.Windows.Forms.TextBox()
        Me.Label_VentaID = New System.Windows.Forms.Label()
        Me.Menu_ABM_Ventas.SuspendLayout()
        Me.SuspendLayout()
        '
        'Menu_ABM_Ventas
        '
        Me.Menu_ABM_Ventas.Font = New System.Drawing.Font("Sylfaen", 12.0!)
        Me.Menu_ABM_Ventas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModificarToolStripMenuItem})
        Me.Menu_ABM_Ventas.Location = New System.Drawing.Point(0, 0)
        Me.Menu_ABM_Ventas.Name = "Menu_ABM_Ventas"
        Me.Menu_ABM_Ventas.Size = New System.Drawing.Size(699, 30)
        Me.Menu_ABM_Ventas.TabIndex = 1
        Me.Menu_ABM_Ventas.Text = "MenuStrip1"
        '
        'ModificarToolStripMenuItem
        '
        Me.ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem"
        Me.ModificarToolStripMenuItem.Size = New System.Drawing.Size(87, 26)
        Me.ModificarToolStripMenuItem.Text = "Modificar"
        '
        'TextBox_VentaID
        '
        Me.TextBox_VentaID.Enabled = False
        Me.TextBox_VentaID.Font = New System.Drawing.Font("Sylfaen", 10.0!)
        Me.TextBox_VentaID.Location = New System.Drawing.Point(109, 55)
        Me.TextBox_VentaID.Name = "TextBox_VentaID"
        Me.TextBox_VentaID.Size = New System.Drawing.Size(100, 25)
        Me.TextBox_VentaID.TabIndex = 3
        '
        'Label_VentaID
        '
        Me.Label_VentaID.AutoSize = True
        Me.Label_VentaID.Font = New System.Drawing.Font("Sylfaen", 10.0!)
        Me.Label_VentaID.Location = New System.Drawing.Point(37, 58)
        Me.Label_VentaID.Name = "Label_VentaID"
        Me.Label_VentaID.Size = New System.Drawing.Size(60, 18)
        Me.Label_VentaID.TabIndex = 4
        Me.Label_VentaID.Text = "Venta N°"
        '
        'ABM_Modificar_Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(699, 545)
        Me.Controls.Add(Me.Label_VentaID)
        Me.Controls.Add(Me.TextBox_VentaID)
        Me.Controls.Add(Me.Menu_ABM_Ventas)
        Me.Name = "ABM_Modificar_Ventas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar venta"
        Me.Menu_ABM_Ventas.ResumeLayout(False)
        Me.Menu_ABM_Ventas.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Menu_ABM_Ventas As MenuStrip
    Friend WithEvents ModificarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBox_VentaID As TextBox
    Friend WithEvents Label_VentaID As Label
    Friend WithEvents ListBox1 As ListBox
End Class
