<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ABM_Alta_Ventas
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
        Me.AltaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label_ID = New System.Windows.Forms.Label()
        Me.TextBox_ID = New System.Windows.Forms.TextBox()
        Me.Button_Buscar = New System.Windows.Forms.Button()
        Me.Label_Encontrado = New System.Windows.Forms.Label()
        Me.Menu_ABM_Ventas.SuspendLayout()
        Me.SuspendLayout()
        '
        'Menu_ABM_Ventas
        '
        Me.Menu_ABM_Ventas.Font = New System.Drawing.Font("Sylfaen", 12.0!)
        Me.Menu_ABM_Ventas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaToolStripMenuItem})
        Me.Menu_ABM_Ventas.Location = New System.Drawing.Point(0, 0)
        Me.Menu_ABM_Ventas.Name = "Menu_ABM_Ventas"
        Me.Menu_ABM_Ventas.Size = New System.Drawing.Size(699, 30)
        Me.Menu_ABM_Ventas.TabIndex = 2
        Me.Menu_ABM_Ventas.Text = "MenuStrip1"
        '
        'AltaToolStripMenuItem
        '
        Me.AltaToolStripMenuItem.Name = "AltaToolStripMenuItem"
        Me.AltaToolStripMenuItem.Size = New System.Drawing.Size(50, 26)
        Me.AltaToolStripMenuItem.Text = "Alta"
        '
        'Label_ID
        '
        Me.Label_ID.AutoSize = True
        Me.Label_ID.Font = New System.Drawing.Font("Sylfaen", 10.0!)
        Me.Label_ID.Location = New System.Drawing.Point(37, 58)
        Me.Label_ID.Name = "Label_ID"
        Me.Label_ID.Size = New System.Drawing.Size(65, 18)
        Me.Label_ID.TabIndex = 11
        Me.Label_ID.Text = "Cliente N°"
        '
        'TextBox_ID
        '
        Me.TextBox_ID.Font = New System.Drawing.Font("Sylfaen", 10.0!)
        Me.TextBox_ID.Location = New System.Drawing.Point(109, 55)
        Me.TextBox_ID.Name = "TextBox_ID"
        Me.TextBox_ID.Size = New System.Drawing.Size(100, 25)
        Me.TextBox_ID.TabIndex = 10
        '
        'Button_Buscar
        '
        Me.Button_Buscar.Location = New System.Drawing.Point(223, 55)
        Me.Button_Buscar.Name = "Button_Buscar"
        Me.Button_Buscar.Size = New System.Drawing.Size(100, 25)
        Me.Button_Buscar.TabIndex = 13
        Me.Button_Buscar.Text = "Buscar"
        Me.Button_Buscar.UseVisualStyleBackColor = True
        '
        'Label_Encontrado
        '
        Me.Label_Encontrado.AutoSize = True
        Me.Label_Encontrado.Font = New System.Drawing.Font("Sylfaen", 10.0!)
        Me.Label_Encontrado.Location = New System.Drawing.Point(338, 58)
        Me.Label_Encontrado.Name = "Label_Encontrado"
        Me.Label_Encontrado.Size = New System.Drawing.Size(0, 18)
        Me.Label_Encontrado.TabIndex = 14
        '
        'ABM_Alta_Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(699, 545)
        Me.Controls.Add(Me.Label_Encontrado)
        Me.Controls.Add(Me.Button_Buscar)
        Me.Controls.Add(Me.Label_ID)
        Me.Controls.Add(Me.TextBox_ID)
        Me.Controls.Add(Me.Menu_ABM_Ventas)
        Me.Name = "ABM_Alta_Ventas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alta/ Baja de venta"
        Me.Menu_ABM_Ventas.ResumeLayout(False)
        Me.Menu_ABM_Ventas.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Menu_ABM_Ventas As MenuStrip
    Friend WithEvents AltaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label_ID As Label
    Friend WithEvents TextBox_ID As TextBox
    Friend WithEvents Button_Buscar As Button
    Friend WithEvents Label_Encontrado As Label
End Class
