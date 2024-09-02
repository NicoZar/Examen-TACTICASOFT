Public Class ABM_Modificar_Productos

    Dim Panel_Modificar As New Panel

    Dim Label_Titulo As New Label
    Dim Label_Nombre As New Label
    Dim Label_Precio As New Label
    Dim Label_Categoria As New Label

    Dim TextBox_Nombre As New TextBox
    Dim TextBox_Precio As New TextBox
    Dim TextBox_Categoria As New TextBox

    Dim TextBox_Nombre_Nuevo As New TextBox
    Dim TextBox_Precio_Nuevo As New TextBox
    Dim TextBox_Categoria_Nuevo As New TextBox

    Dim Button_Aceptar As New Button
    Dim Button_Cancelar As New Button

    Private Sub ABM_Modificar_Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Controls.Add(Panel_Modificar)
    End Sub

    Public Sub ABM_Modificar_Producto(Producto As Productos)
        Me.Show()

        AgregarPanel(Panel_Modificar)
        AgregarCampos_Modificar(Panel_Modificar, Producto)
        AgregarBotones_Modificar(Panel_Modificar, Producto)

    End Sub

    Private Sub AgregarPanel(Panel As Panel)
        Panel.Location = New System.Drawing.Point(0, 24)
        Panel.Name = "Panel"
        Panel.Size = New System.Drawing.Size(630, 407)
        Panel.TabIndex = 1
        Panel.Visible = True
    End Sub

    Private Sub AgregarCampos_Modificar(Panel_Alta As Panel, Producto As Productos)

        '
        'Titulo
        '
        Label_Titulo.Font = New System.Drawing.Font("Sylfaen", 18.0!)
        Label_Titulo.Location = New System.Drawing.Point(37, 32)
        Label_Titulo.Name = "Label_Titulo"
        Label_Titulo.Size = New System.Drawing.Size(579, 30)
        Label_Titulo.TabIndex = 20
        Label_Titulo.Text = "Producto a modificar"
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
        TextBox_Nombre.Text = Producto.Nombre
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
        'Label_Precio
        '
        Label_Precio.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_Precio.Location = New System.Drawing.Point(30, 135)
        Label_Precio.Name = "Label_Precio"
        Label_Precio.Size = New System.Drawing.Size(136, 30)
        Label_Precio.TabIndex = 23
        Label_Precio.Text = "Telefono"
        Label_Precio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox_Precio
        '
        TextBox_Precio.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TextBox_Precio.Location = New System.Drawing.Point(172, 136)
        TextBox_Precio.Name = "TextBox_Precio"
        TextBox_Precio.Size = New System.Drawing.Size(219, 29)
        TextBox_Precio.TabIndex = 27
        TextBox_Precio.Text = Producto.Precio
        TextBox_Precio.Enabled = False
        '
        'TextBox_Nombre_Nuevo
        '
        TextBox_Precio_Nuevo.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TextBox_Precio_Nuevo.Location = New System.Drawing.Point(397, 136)
        TextBox_Precio_Nuevo.Name = "TextBox_Precio"
        TextBox_Precio_Nuevo.Size = New System.Drawing.Size(219, 29)
        TextBox_Precio_Nuevo.TabIndex = 27
        AddHandler TextBox_Precio_Nuevo.LostFocus, Sub()
                                                       Button_Aceptar.Enabled = VerificarCampos()
                                                   End Sub
        '
        'Label_Categoria
        '
        Label_Categoria.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_Categoria.Location = New System.Drawing.Point(30, 175)
        Label_Categoria.Name = "Label_Categoria"
        Label_Categoria.Size = New System.Drawing.Size(136, 30)
        Label_Categoria.TabIndex = 24
        Label_Categoria.Text = "Correo"
        Label_Categoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox_Categoria
        '
        TextBox_Categoria.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TextBox_Categoria.Location = New System.Drawing.Point(172, 176)
        TextBox_Categoria.Name = "TextBox_Categoria"
        TextBox_Categoria.Size = New System.Drawing.Size(219, 29)
        TextBox_Categoria.TabIndex = 28
        TextBox_Categoria.Text = Producto.Categoria
        TextBox_Categoria.Enabled = False
        '
        'TextBox_Categoria_Nuevo
        '
        TextBox_Categoria_Nuevo.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TextBox_Categoria_Nuevo.Location = New System.Drawing.Point(397, 176)
        TextBox_Categoria_Nuevo.Name = "TextBox_Precio"
        TextBox_Categoria_Nuevo.Size = New System.Drawing.Size(219, 29)
        TextBox_Categoria_Nuevo.TabIndex = 27
        AddHandler TextBox_Categoria_Nuevo.LostFocus, Sub()
                                                          Button_Aceptar.Enabled = VerificarCampos()
                                                      End Sub

        Panel_Alta.Controls.Add(Label_Titulo)
        Panel_Alta.Controls.Add(Label_Nombre)
        Panel_Alta.Controls.Add(Label_Precio)
        Panel_Alta.Controls.Add(Label_Categoria)

        Panel_Alta.Controls.Add(TextBox_Nombre)
        Panel_Alta.Controls.Add(TextBox_Precio)
        Panel_Alta.Controls.Add(TextBox_Categoria)

        Panel_Alta.Controls.Add(TextBox_Nombre_Nuevo)
        Panel_Alta.Controls.Add(TextBox_Precio_Nuevo)
        Panel_Alta.Controls.Add(TextBox_Categoria_Nuevo)
    End Sub

    Private Sub AgregarBotones_Modificar(Panel_Modificar As Panel, Producto As Productos)

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
                                             Producto = ProductoModificado(Producto)
                                             Dim result As DialogResult = MessageBox.Show("¿Desea modificar " & Producto.Nombre & "?", "Confirmación", MessageBoxButtons.OKCancel)

                                             If result = DialogResult.OK Then
                                                 Producto.ModificarProductos()
                                                 Me.Close()
                                             End If
                                             Buscador.PoblarListView_Productos()
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
        If TextBox_Nombre_Nuevo.Text <> "" OrElse TextBox_Precio_Nuevo.Text <> "" OrElse TextBox_Categoria_Nuevo.Text <> "" Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function ProductoModificado(Producto As Productos)

        If TextBox_Nombre_Nuevo.Text <> "" Then
            Producto.Nombre = TextBox_Nombre_Nuevo.Text
        End If

        If TextBox_Precio_Nuevo.Text <> "" Then
            Producto.Precio = TextBox_Precio_Nuevo.Text
        End If

        If TextBox_Categoria_Nuevo.Text <> "" Then
            Producto.Categoria = TextBox_Categoria_Nuevo.Text
        End If

        Return Producto
    End Function
End Class