<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABM_AltaBaja_Clientes
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ABM_Alta_Cliente = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABM_Baja_Cliente = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ABM_Alta_Cliente, Me.ABM_Baja_Cliente})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(449, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ABM_Alta_Cliente
        '
        Me.ABM_Alta_Cliente.Name = "ABM_Alta_Cliente"
        Me.ABM_Alta_Cliente.Size = New System.Drawing.Size(40, 20)
        Me.ABM_Alta_Cliente.Text = "Alta"
        '
        'ABM_Baja_Cliente
        '
        Me.ABM_Baja_Cliente.Name = "ABM_Baja_Cliente"
        Me.ABM_Baja_Cliente.Size = New System.Drawing.Size(41, 20)
        Me.ABM_Baja_Cliente.Text = "Baja"
        '
        'ABM_AltaBaja_Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 431)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "ABM_AltaBaja_Clientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ABM_AltaBaja_Clientes"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ABM_Alta_Cliente As ToolStripMenuItem
    Friend WithEvents ABM_Baja_Cliente As ToolStripMenuItem
End Class
