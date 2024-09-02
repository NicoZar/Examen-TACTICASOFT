Public Class ABM_AltaBaja_Productos

    Dim Panel_Baja As New Panel
    Dim Panel_Alta As New Panel
    Dim IdProductoBaja As Integer

    '-------------------- Alta

    Private Sub ABM_AltaBaja_Productoo_Alta_Click(sender As Object, e As EventArgs) Handles ABM_Alta_Producto.Click

        VaciarPanel(Panel_Baja)
        Panel_Alta.Visible = True

        Dim Button_Aceptar As New Button
        Dim ProductoNuevo As New Productos()

        AgregarPanel(Panel_Alta)
        AgregarCampos_Alta(Panel_Alta, Button_Aceptar, ProductoNuevo)
        AgregarBotones_Alta(Panel_Alta, Button_Aceptar, ProductoNuevo)
    End Sub

    Private Sub AgregarCampos_Alta(Panel_Alta As Panel, Button_Aceptar As Button, ProductoNuevo As Productos)

        Dim Label_Titulo As New Label
        Dim Label_Nombre As New Label
        Dim Label_Precio As New Label
        Dim Label_Categoria As New Label
        Dim TextBox_Nombre As New TextBox
        Dim TextBox_Precio As New TextBox
        Dim TextBox_Categoria As New TextBox

        '
        'Titulo
        '
        Label_Titulo.Font = New System.Drawing.Font("Sylfaen", 18.0!)
        Label_Titulo.Location = New System.Drawing.Point(37, 32)
        Label_Titulo.Name = "Label_Titulo"
        Label_Titulo.Size = New System.Drawing.Size(334, 30)
        Label_Titulo.TabIndex = 20
        Label_Titulo.Text = "Producto nuevo"
        Label_Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter

        '
        'Label_Nombre
        '
        Label_Nombre.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_Nombre.Location = New System.Drawing.Point(33, 95)
        Label_Nombre.Name = "Label_Nombre"
        Label_Nombre.Size = New System.Drawing.Size(133, 30)
        Label_Nombre.TabIndex = 22
        Label_Nombre.Text = "(*) Nombre"
        Label_Nombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight

        '
        'TextBox_Nombre
        '
        TextBox_Nombre.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TextBox_Nombre.Location = New System.Drawing.Point(172, 96)
        TextBox_Nombre.Name = "TextBox_Nombre"
        TextBox_Nombre.Size = New System.Drawing.Size(219, 29)
        TextBox_Nombre.TabIndex = 26
        AddHandler TextBox_Nombre.LostFocus, Sub()
                                                 If TextBox_Nombre.Text <> "" Then
                                                     Button_Aceptar.Enabled = True
                                                     ProductoNuevo.Nombre = TextBox_Nombre.Text
                                                 Else
                                                     Button_Aceptar.Enabled = False
                                                 End If
                                             End Sub
        '
        'Label_Precio
        '
        Label_Precio.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_Precio.Location = New System.Drawing.Point(33, 135)
        Label_Precio.Name = "Label_Precio"
        Label_Precio.Size = New System.Drawing.Size(133, 30)
        Label_Precio.TabIndex = 23
        Label_Precio.Text = "Precio unitario"
        Label_Precio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox_Precio
        '
        TextBox_Precio.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TextBox_Precio.Location = New System.Drawing.Point(172, 136)
        TextBox_Precio.Name = "TextBox_Precio"
        TextBox_Precio.Size = New System.Drawing.Size(219, 29)
        TextBox_Precio.TabIndex = 27
        AddHandler TextBox_Precio.LostFocus, Sub()
                                                 If IsNumeric(TextBox_Precio.Text) Then
                                                     ProductoNuevo.Precio = TextBox_Precio.Text
                                                 Else
                                                     MessageBox.Show("El precio debe ser un valor numerico")
                                                     TextBox_Precio.Select()
                                                 End If

                                             End Sub
        '
        'Label_Categoria
        '
        Label_Categoria.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_Categoria.Location = New System.Drawing.Point(33, 175)
        Label_Categoria.Name = "Label_Categoria"
        Label_Categoria.Size = New System.Drawing.Size(133, 30)
        Label_Categoria.TabIndex = 24
        Label_Categoria.Text = "Categoria"
        Label_Categoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox_Categoria
        '
        TextBox_Categoria.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TextBox_Categoria.Location = New System.Drawing.Point(172, 176)
        TextBox_Categoria.Name = "TextBox_Categoria"
        TextBox_Categoria.Size = New System.Drawing.Size(219, 29)
        TextBox_Categoria.TabIndex = 28
        AddHandler TextBox_Categoria.LostFocus, Sub()
                                                    ProductoNuevo.Categoria = TextBox_Categoria.Text
                                                End Sub


        Panel_Alta.Controls.Add(Label_Titulo)
        Panel_Alta.Controls.Add(Label_Nombre)
        Panel_Alta.Controls.Add(Label_Precio)
        Panel_Alta.Controls.Add(Label_Categoria)
        Panel_Alta.Controls.Add(TextBox_Nombre)
        Panel_Alta.Controls.Add(TextBox_Precio)
        Panel_Alta.Controls.Add(TextBox_Categoria)
    End Sub

    Private Sub AgregarBotones_Alta(Panel_Alta As Panel, Button_Aceptar As Button, ProductoNuevo As Productos)

        Dim Button_Cancelar As New Button
        '
        'Button_Aceptar
        '
        Button_Aceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Button_Aceptar.Font = New System.Drawing.Font("Sylfaen", 12.0!)
        Button_Aceptar.Location = New System.Drawing.Point(241, 320)
        Button_Aceptar.Name = "Button_Aceptar"
        Button_Aceptar.Size = New System.Drawing.Size(150, 38)
        Button_Aceptar.TabIndex = 31
        Button_Aceptar.Text = "Agregar"
        Button_Aceptar.UseVisualStyleBackColor = True
        Button_Aceptar.Enabled = False
        AddHandler Button_Aceptar.Click, Sub()

                                             Dim result As DialogResult = MessageBox.Show("¿Desea agregar " & ProductoNuevo.Nombre & "?", "Confirmación", MessageBoxButtons.OKCancel)

                                             If result = DialogResult.OK Then
                                                 ProductoNuevo.CrearProductos()
                                                 Me.Close()
                                             End If
                                         End Sub

        '
        'Button_Cancelar
        '
        Button_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Button_Cancelar.Font = New System.Drawing.Font("Sylfaen", 12.0!)
        Button_Cancelar.Location = New System.Drawing.Point(74, 320)
        Button_Cancelar.Name = "Button_Cancelar"
        Button_Cancelar.Size = New System.Drawing.Size(150, 38)
        Button_Cancelar.TabIndex = 30
        Button_Cancelar.Text = "Cancelar"
        Button_Cancelar.UseVisualStyleBackColor = True
        AddHandler Button_Cancelar.Click, Sub()
                                              Me.Close()
                                          End Sub

        Panel_Alta.Controls.Add(Button_Aceptar)
        Panel_Alta.Controls.Add(Button_Cancelar)
    End Sub

    '-------------------- Baja

    Private Sub ABM_AltaBaja_Producto_Baja_Click(sender As Object, e As EventArgs) Handles ABM_Baja_Producto.Click

        VaciarPanel(Panel_Alta)
        Panel_Baja.Visible = True

        Dim Button_Aceptar As New Button

        AgregarPanel(Panel_Baja)
        AgregarCampos_Baja(Panel_Baja, Button_Aceptar)
        AgregarBotones_Baja(Panel_Baja, Button_Aceptar)
    End Sub

    Private Sub AgregarCampos_Baja(Panel_Baja As Panel, Button_Aceptar As Button)

        Dim Label_Titulo As New Label
        Dim Label_ID As New Label
        Dim Label_Nombre As New Label
        Dim Label_Precio As New Label
        Dim Label_Categoria As New Label
        Dim TextBox_ID As New TextBox
        Dim TextBox_Nombre As New TextBox
        Dim TextBox_Precio As New TextBox
        Dim TextBox_Categoria As New TextBox
        Dim ListaDeProductos As List(Of Productos) = Productos.Lista_Productos()

        '
        'Titulo
        '
        Label_Titulo.Font = New System.Drawing.Font("Sylfaen", 18.0!)
        Label_Titulo.Location = New System.Drawing.Point(37, 32)
        Label_Titulo.Name = "Label_Titulo"
        Label_Titulo.Size = New System.Drawing.Size(334, 30)
        Label_Titulo.TabIndex = 20
        Label_Titulo.Text = "Baja de Producto"
        Label_Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter

        '
        'Label_ID
        '
        Label_ID.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_ID.Location = New System.Drawing.Point(33, 95)
        Label_ID.Name = "Label_ID"
        Label_ID.Size = New System.Drawing.Size(133, 30)
        Label_ID.TabIndex = 21
        Label_ID.Text = "Producto N°"
        Label_ID.TextAlign = System.Drawing.ContentAlignment.MiddleRight

        '
        'TextBox_ID
        '
        TextBox_ID.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TextBox_ID.Location = New System.Drawing.Point(172, 96)
        TextBox_ID.Name = "TextBox_ID"
        TextBox_ID.Size = New System.Drawing.Size(219, 29)
        TextBox_ID.TabIndex = 25
        AddHandler TextBox_ID.KeyDown, Sub(sender As Object, e As KeyEventArgs)
                                           If e.KeyCode = Keys.Enter Then
                                               Dim ProductoEncontrado As Productos = ListaDeProductos.Find(Function(buscar_producto) buscar_producto.ID.ToString = TextBox_ID.Text)

                                               If ProductoEncontrado Is Nothing Then
                                                   MessageBox.Show("Cliente N°" & TextBox_ID.Text & " no fue encontrado.")
                                                   Button_Aceptar.Enabled = False
                                                   TextBox_Nombre.Text = ""
                                                   TextBox_Precio.Text = ""
                                                   TextBox_Categoria.Text = ""
                                               Else
                                                   TextBox_Nombre.Text = ProductoEncontrado.Nombre
                                                   TextBox_Precio.Text = ProductoEncontrado.Precio
                                                   TextBox_Categoria.Text = ProductoEncontrado.Categoria
                                                   Button_Aceptar.Enabled = True
                                                   IdProductoBaja = ProductoEncontrado.ID
                                               End If

                                               e.Handled = True
                                               e.SuppressKeyPress = True
                                           End If
                                       End Sub

        '
        'Label_Nombre
        '
        Label_Nombre.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_Nombre.Location = New System.Drawing.Point(33, 135)
        Label_Nombre.Name = "Label_Nombre"
        Label_Nombre.Size = New System.Drawing.Size(133, 30)
        Label_Nombre.TabIndex = 22
        Label_Nombre.Text = "Nombre"
        Label_Nombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight

        '
        'TextBox_Nombre
        '
        TextBox_Nombre.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TextBox_Nombre.Location = New System.Drawing.Point(172, 136)
        TextBox_Nombre.Name = "TextBox_Nombre"
        TextBox_Nombre.Size = New System.Drawing.Size(219, 29)
        TextBox_Nombre.TabIndex = 26
        TextBox_Nombre.Enabled = False
        '
        'Label_Precio
        '
        Label_Precio.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_Precio.Location = New System.Drawing.Point(33, 175)
        Label_Precio.Name = "Label_Precio"
        Label_Precio.Size = New System.Drawing.Size(133, 30)
        Label_Precio.TabIndex = 23
        Label_Precio.Text = "Telefono"
        Label_Precio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox_Precio
        '
        TextBox_Precio.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TextBox_Precio.Location = New System.Drawing.Point(172, 176)
        TextBox_Precio.Name = "TextBox_Precio"
        TextBox_Precio.Size = New System.Drawing.Size(219, 29)
        TextBox_Precio.TabIndex = 27
        TextBox_Precio.Enabled = False
        '
        'Label_Categoria
        '
        Label_Categoria.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_Categoria.Location = New System.Drawing.Point(33, 215)
        Label_Categoria.Name = "Label_Categoria"
        Label_Categoria.Size = New System.Drawing.Size(133, 30)
        Label_Categoria.TabIndex = 24
        Label_Categoria.Text = "Correo"
        Label_Categoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox_Categoria
        '
        TextBox_Categoria.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TextBox_Categoria.Location = New System.Drawing.Point(172, 216)
        TextBox_Categoria.Name = "TextBox_Categoria"
        TextBox_Categoria.Size = New System.Drawing.Size(219, 29)
        TextBox_Categoria.TabIndex = 28
        TextBox_Categoria.Enabled = False

        Panel_Baja.Controls.Add(Label_Titulo)
        Panel_Baja.Controls.Add(Label_ID)
        Panel_Baja.Controls.Add(Label_Nombre)
        Panel_Baja.Controls.Add(Label_Precio)
        Panel_Baja.Controls.Add(Label_Categoria)
        Panel_Baja.Controls.Add(TextBox_ID)
        Panel_Baja.Controls.Add(TextBox_Nombre)
        Panel_Baja.Controls.Add(TextBox_Precio)
        Panel_Baja.Controls.Add(TextBox_Categoria)
    End Sub

    Private Sub AgregarBotones_Baja(Panel_Baja As Panel, Button_Aceptar As Button)

        Dim Button_Cancelar As New Button
        '
        'Button_Aceptar
        '
        Button_Aceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Button_Aceptar.Font = New System.Drawing.Font("Sylfaen", 12.0!)
        Button_Aceptar.Location = New System.Drawing.Point(241, 320)
        Button_Aceptar.Name = "Button_Aceptar"
        Button_Aceptar.Size = New System.Drawing.Size(150, 38)
        Button_Aceptar.TabIndex = 31
        Button_Aceptar.Text = "Eliminar"
        Button_Aceptar.UseVisualStyleBackColor = True
        Button_Aceptar.Enabled = False
        AddHandler Button_Aceptar.Click, Sub()
                                             Dim result As DialogResult = MessageBox.Show("¿Desea dar de baja al producto N°" & IdProductoBaja & "?", "Confirmación", MessageBoxButtons.OKCancel)

                                             If result = DialogResult.OK Then
                                                 'Dim ListaDeVentasDelCliente As List(Of Ventas) = Ventas.Buscar_Ventas_De_Cliente(IdClienteBaja)
                                                 'If ListaDeVentasDelCliente.Count > 0 Then
                                                 '    Dim result2 As DialogResult = MessageBox.Show("El cliente tiene compras realizadas, ¿desea borrarlas tambien?", "Confirmación", MessageBoxButtons.OKCancel)
                                                 '    If result2 = DialogResult.OK Then
                                                 '        MessageBox.Show("El cliente y sus compras fueron eliminados")
                                                 '        For Each venta As Ventas In ListaDeVentasDelCliente
                                                 '            VentasItems.EliminarVentasItems(venta.ID)
                                                 '            Ventas.EliminarVenta(venta.ID)
                                                 '        Next
                                                 '        Clientes.EliminarCliente(IdClienteBaja)
                                                 '    Else
                                                 '        MessageBox.Show("El cliente no fue eliminado")
                                                 '    End If
                                                 'Else
                                                 '    Clientes.EliminarCliente(IdClienteBaja)
                                                 'End If
                                                 Productos.EliminarProductos(IdProductoBaja)
                                                 Me.Close()
                                             End If
                                         End Sub

        '
        'Button_Cancelar
        '
        Button_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Button_Cancelar.Font = New System.Drawing.Font("Sylfaen", 12.0!)
        Button_Cancelar.Location = New System.Drawing.Point(74, 320)
        Button_Cancelar.Name = "Button_Cancelar"
        Button_Cancelar.Size = New System.Drawing.Size(150, 38)
        Button_Cancelar.TabIndex = 30
        Button_Cancelar.Text = "Cancelar"
        Button_Cancelar.UseVisualStyleBackColor = True
        AddHandler Button_Cancelar.Click, Sub()
                                              Me.Close()
                                          End Sub

        Panel_Baja.Controls.Add(Button_Aceptar)
        Panel_Baja.Controls.Add(Button_Cancelar)
    End Sub

    '-------------------- Comun
    Private Sub AgregarPanel(Panel As Panel)
        Panel.Location = New System.Drawing.Point(0, 24)
        Panel.Name = "Panel"
        Panel.Size = New System.Drawing.Size(425, 407)
        Panel.TabIndex = 1
        Panel.AutoSize = False

        Panel.Visible = True
    End Sub

    Private Sub VaciarPanel(Panel)
        Panel.Controls.Clear()
        Panel.Visible = False
    End Sub

    Private Sub ABM_AltaBaja_Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Controls.Add(Panel_Baja)
        Me.Controls.Add(Panel_Alta)
        Panel_Baja.Visible = False
        Panel_Alta.Visible = False
    End Sub

End Class