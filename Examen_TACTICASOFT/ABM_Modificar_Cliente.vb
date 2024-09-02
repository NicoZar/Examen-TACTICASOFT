Public Class ABM_Modificar_Cliente

    Dim Panel_Modificar As New Panel

    Dim Label_Titulo As New Label
    Dim Label_Nombre As New Label
    Dim Label_Telefono As New Label
    Dim Label_Correo As New Label

    Dim TextBox_Nombre As New TextBox
    Dim TextBox_Telefono As New TextBox
    Dim TextBox_Correo As New TextBox

    Dim TextBox_Nombre_Nuevo As New TextBox
    Dim TextBox_Telefono_Nuevo As New TextBox
    Dim TextBox_Correo_Nuevo As New TextBox

    Dim Button_Aceptar As New Button
    Dim Button_Cancelar As New Button

    Private Sub ABM_Modificar_Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Controls.Add(Panel_Modificar)

    End Sub

    Public Sub ABM_Modificar_Clientes(Cliente As Clientes)
        Me.Show()

        AgregarPanel(Panel_Modificar)
        AgregarCampos_Modificar(Panel_Modificar, Cliente)
        AgregarBotones_Modificar(Panel_Modificar, Cliente)

    End Sub

    Private Sub AgregarPanel(Panel As Panel)
        Panel.Location = New System.Drawing.Point(0, 24)
        Panel.Name = "Panel"
        Panel.Size = New System.Drawing.Size(630, 407)
        Panel.TabIndex = 1
        Panel.Visible = True
    End Sub

    Private Sub AgregarCampos_Modificar(Panel_Alta As Panel, Cliente As Clientes)

        '
        'Titulo
        '
        Label_Titulo.Font = New System.Drawing.Font("Sylfaen", 18.0!)
        Label_Titulo.Location = New System.Drawing.Point(37, 32)
        Label_Titulo.Name = "Label_Titulo"
        Label_Titulo.Size = New System.Drawing.Size(579, 30)
        Label_Titulo.TabIndex = 20
        Label_Titulo.Text = "Cliente a modificar"
        Label_Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter

        '
        'Label_Nombre
        '
        Label_Nombre.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_Nombre.Location = New System.Drawing.Point(30, 95)
        Label_Nombre.Name = "Label_Nombre"
        Label_Nombre.Size = New System.Drawing.Size(136, 30)
        Label_Nombre.TabIndex = 22
        Label_Nombre.Text = "Nombre"
        Label_Nombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight

        '
        'TextBox_Nombre
        '
        TextBox_Nombre.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TextBox_Nombre.Location = New System.Drawing.Point(172, 96)
        TextBox_Nombre.Name = "TextBox_Nombre"
        TextBox_Nombre.Size = New System.Drawing.Size(219, 29)
        TextBox_Nombre.TabIndex = 26
        TextBox_Nombre.Text = Cliente.Cliente
        TextBox_Nombre.Enabled = False
        '
        'TextBox_Nombre_Nuevo
        '
        TextBox_Nombre_Nuevo.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TextBox_Nombre_Nuevo.Location = New System.Drawing.Point(397, 96)
        TextBox_Nombre_Nuevo.Name = "TextBox_Nombre"
        TextBox_Nombre_Nuevo.Size = New System.Drawing.Size(219, 29)
        TextBox_Nombre_Nuevo.TabIndex = 26
        AddHandler TextBox_Nombre_Nuevo.LostFocus, Sub()
                                                       Button_Aceptar.Enabled = VerificarCampos()
                                                   End Sub
        '
        'Label_Telefono
        '
        Label_Telefono.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_Telefono.Location = New System.Drawing.Point(30, 135)
        Label_Telefono.Name = "Label_Telefono"
        Label_Telefono.Size = New System.Drawing.Size(136, 30)
        Label_Telefono.TabIndex = 23
        Label_Telefono.Text = "Telefono"
        Label_Telefono.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox_Telefono
        '
        TextBox_Telefono.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TextBox_Telefono.Location = New System.Drawing.Point(172, 136)
        TextBox_Telefono.Name = "TextBox_Telefono"
        TextBox_Telefono.Size = New System.Drawing.Size(219, 29)
        TextBox_Telefono.TabIndex = 27
        TextBox_Telefono.Text = Cliente.Telefono
        TextBox_Telefono.Enabled = False
        '
        'TextBox_Nombre_Nuevo
        '
        TextBox_Telefono_Nuevo.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TextBox_Telefono_Nuevo.Location = New System.Drawing.Point(397, 136)
        TextBox_Telefono_Nuevo.Name = "TextBox_Telefono"
        TextBox_Telefono_Nuevo.Size = New System.Drawing.Size(219, 29)
        TextBox_Telefono_Nuevo.TabIndex = 27
        AddHandler TextBox_Telefono_Nuevo.LostFocus, Sub()
                                                         Button_Aceptar.Enabled = VerificarCampos()
                                                     End Sub
        '
        'Label_Correo
        '
        Label_Correo.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_Correo.Location = New System.Drawing.Point(30, 175)
        Label_Correo.Name = "Label_Correo"
        Label_Correo.Size = New System.Drawing.Size(136, 30)
        Label_Correo.TabIndex = 24
        Label_Correo.Text = "Correo"
        Label_Correo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox_Correo
        '
        TextBox_Correo.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TextBox_Correo.Location = New System.Drawing.Point(172, 176)
        TextBox_Correo.Name = "TextBox_Correo"
        TextBox_Correo.Size = New System.Drawing.Size(219, 29)
        TextBox_Correo.TabIndex = 28
        TextBox_Correo.Text = Cliente.Correo
        TextBox_Correo.Enabled = False
        '
        'TextBox_Correo_Nuevo
        '
        TextBox_Correo_Nuevo.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TextBox_Correo_Nuevo.Location = New System.Drawing.Point(397, 176)
        TextBox_Correo_Nuevo.Name = "TextBox_Telefono"
        TextBox_Correo_Nuevo.Size = New System.Drawing.Size(219, 29)
        TextBox_Correo_Nuevo.TabIndex = 27
        AddHandler TextBox_Correo_Nuevo.LostFocus, Sub()
                                                       Button_Aceptar.Enabled = VerificarCampos()
                                                   End Sub

        Panel_Alta.Controls.Add(Label_Titulo)

        Panel_Alta.Controls.Add(Label_Nombre)
        Panel_Alta.Controls.Add(Label_Telefono)
        Panel_Alta.Controls.Add(Label_Correo)

        Panel_Alta.Controls.Add(TextBox_Nombre)
        Panel_Alta.Controls.Add(TextBox_Telefono)
        Panel_Alta.Controls.Add(TextBox_Correo)

        Panel_Alta.Controls.Add(TextBox_Nombre_Nuevo)
        Panel_Alta.Controls.Add(TextBox_Telefono_Nuevo)
        Panel_Alta.Controls.Add(TextBox_Correo_Nuevo)
    End Sub

    Private Sub AgregarBotones_Modificar(Panel_Modificar As Panel, Cliente As Clientes)

        '
        'Button_Aceptar
        '
        Button_Aceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Button_Aceptar.Font = New System.Drawing.Font("Sylfaen", 12.0!)
        Button_Aceptar.Location = New System.Drawing.Point(466, 320)
        Button_Aceptar.Name = "Button_Aceptar"
        Button_Aceptar.Size = New System.Drawing.Size(150, 38)
        Button_Aceptar.TabIndex = 31
        Button_Aceptar.Text = "Modificar"
        Button_Aceptar.UseVisualStyleBackColor = True
        Button_Aceptar.Enabled = False
        AddHandler Button_Aceptar.Click, Sub()
                                             Cliente = ClienteModificado(Cliente)
                                             Dim result As DialogResult = MessageBox.Show("¿Desea modificar a " & Cliente.Cliente & "?", "Confirmación", MessageBoxButtons.OKCancel)

                                             If result = DialogResult.OK Then
                                                 Cliente.ModificarCliente()
                                                 Me.Close()
                                             End If
                                             Buscador.PoblarListView_Clientes()
                                         End Sub

        '
        'Button_Cancelar
        '
        Button_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Button_Cancelar.Font = New System.Drawing.Font("Sylfaen", 12.0!)
        Button_Cancelar.Location = New System.Drawing.Point(299, 320)
        Button_Cancelar.Name = "Button_Cancelar"
        Button_Cancelar.Size = New System.Drawing.Size(150, 38)
        Button_Cancelar.TabIndex = 30
        Button_Cancelar.Text = "Cancelar"
        Button_Cancelar.UseVisualStyleBackColor = True
        AddHandler Button_Cancelar.Click, Sub()
                                              Me.Close()
                                          End Sub

        Panel_Modificar.Controls.Add(Button_Aceptar)
        Panel_Modificar.Controls.Add(Button_Cancelar)
    End Sub

    Private Function VerificarCampos()
        If TextBox_Nombre_Nuevo.Text <> "" OrElse TextBox_Telefono_Nuevo.Text <> "" OrElse TextBox_Correo_Nuevo.Text <> "" Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function ClienteModificado(Cliente As Clientes)

        If TextBox_Nombre_Nuevo.Text <> "" Then
            Cliente.Cliente = TextBox_Nombre_Nuevo.Text
        End If

        If TextBox_Telefono_Nuevo.Text <> "" Then
            Cliente.Telefono = TextBox_Telefono_Nuevo.Text
        End If

        If TextBox_Correo_Nuevo.Text <> "" Then
            Cliente.Correo = TextBox_Correo_Nuevo.Text
        End If

        Return Cliente
    End Function
End Class