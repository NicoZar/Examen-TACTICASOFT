Public Class ABM_AltaBaja_Clientes

    Dim Panel_Baja As New Panel
    Dim Panel_Alta As New Panel
    Dim IdClienteBaja As Integer

    '-------------------- Alta

    Private Sub ABM_AltaBaja_Cliente_Alta_Click(sender As Object, e As EventArgs) Handles ABM_Alta_Cliente.Click

        VaciarPanel(Panel_Baja)
        Panel_Alta.Visible = True

        Dim Button_Aceptar As New Button
        Dim ClienteNuevo As New Clientes()

        AgregarPanel(Panel_Alta)
        AgregarCampos_Alta(Panel_Alta, Button_Aceptar, ClienteNuevo)
        AgregarBotones_Alta(Panel_Alta, Button_Aceptar, ClienteNuevo)
    End Sub

    Private Sub AgregarCampos_Alta(Panel_Alta As Panel, Button_Aceptar As Button, ClienteNuevo As Clientes)

        Dim Label_Titulo As New Label
        Dim Label_Nombre As New Label
        Dim Label_Telefono As New Label
        Dim Label_Correo As New Label
        Dim TextBox_Nombre As New TextBox
        Dim TextBox_Telefono As New TextBox
        Dim TextBox_Correo As New TextBox

        '
        'Titulo
        '
        Label_Titulo.Font = New System.Drawing.Font("Sylfaen", 18.0!)
        Label_Titulo.Location = New System.Drawing.Point(37, 32)
        Label_Titulo.Name = "Label_Titulo"
        Label_Titulo.Size = New System.Drawing.Size(334, 30)
        Label_Titulo.TabIndex = 20
        Label_Titulo.Text = "Cliente nuevo"
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
                                                     ClienteNuevo.Cliente = TextBox_Nombre.Text
                                                 Else
                                                     Button_Aceptar.Enabled = False
                                                 End If
                                             End Sub
        '
        'Label_Telefono
        '
        Label_Telefono.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_Telefono.Location = New System.Drawing.Point(33, 135)
        Label_Telefono.Name = "Label_Telefono"
        Label_Telefono.Size = New System.Drawing.Size(133, 30)
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
        AddHandler TextBox_Telefono.LostFocus, Sub()
                                                   ClienteNuevo.Telefono = TextBox_Telefono.Text
                                               End Sub
        '
        'Label_Correo
        '
        Label_Correo.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_Correo.Location = New System.Drawing.Point(33, 175)
        Label_Correo.Name = "Label_Correo"
        Label_Correo.Size = New System.Drawing.Size(133, 30)
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
        AddHandler TextBox_Correo.LostFocus, Sub()
                                                 ClienteNuevo.Correo = TextBox_Correo.Text
                                             End Sub


        Panel_Alta.Controls.Add(Label_Titulo)
        Panel_Alta.Controls.Add(Label_Nombre)
        Panel_Alta.Controls.Add(Label_Telefono)
        Panel_Alta.Controls.Add(Label_Correo)
        Panel_Alta.Controls.Add(TextBox_Nombre)
        Panel_Alta.Controls.Add(TextBox_Telefono)
        Panel_Alta.Controls.Add(TextBox_Correo)
    End Sub

    Private Sub AgregarBotones_Alta(Panel_Alta As Panel, Button_Aceptar As Button, ClienteNuevo As Clientes)

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
                                             Dim result As DialogResult = MessageBox.Show("¿Desea agregar a " & ClienteNuevo.Cliente & "?", "Confirmación", MessageBoxButtons.OKCancel)

                                             If result = DialogResult.OK Then
                                                 ClienteNuevo.CrearCliente()
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

    Private Sub ABM_AltaBaja_Cliente_Baja_Click(sender As Object, e As EventArgs) Handles ABM_Baja_Cliente.Click

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
        Dim Label_Telefono As New Label
        Dim Label_Correo As New Label
        Dim TextBox_ID As New TextBox
        Dim TextBox_Nombre As New TextBox
        Dim TextBox_Telefono As New TextBox
        Dim TextBox_Correo As New TextBox
        Dim ListaDeClientes As List(Of Clientes) = Clientes.Lista_Clientes()

        '
        'Titulo
        '
        Label_Titulo.Font = New System.Drawing.Font("Sylfaen", 18.0!)
        Label_Titulo.Location = New System.Drawing.Point(37, 32)
        Label_Titulo.Name = "Label_Titulo"
        Label_Titulo.Size = New System.Drawing.Size(334, 30)
        Label_Titulo.TabIndex = 20
        Label_Titulo.Text = "Baja de cliente"
        Label_Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter

        '
        'Label_ID
        '
        Label_ID.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_ID.Location = New System.Drawing.Point(33, 95)
        Label_ID.Name = "Label_ID"
        Label_ID.Size = New System.Drawing.Size(133, 30)
        Label_ID.TabIndex = 21
        Label_ID.Text = "(*) Cliente N°"
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
                                               Dim ClienteEncontrado As Clientes = ListaDeClientes.Find(Function(buscar_cliente) buscar_cliente.ID.ToString = TextBox_ID.Text)

                                               If ClienteEncontrado Is Nothing Then
                                                   MessageBox.Show("Cliente N°" & TextBox_ID.Text & " no fue encontrado.")
                                                   Button_Aceptar.Enabled = False
                                                   TextBox_Nombre.Text = ""
                                                   TextBox_Telefono.Text = ""
                                                   TextBox_Correo.Text = ""
                                               Else
                                                   TextBox_Nombre.Text = ClienteEncontrado.Cliente
                                                   TextBox_Telefono.Text = ClienteEncontrado.Telefono
                                                   TextBox_Correo.Text = ClienteEncontrado.Correo
                                                   Button_Aceptar.Enabled = True
                                                   IdClienteBaja = ClienteEncontrado.ID
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
        'Label_Telefono
        '
        Label_Telefono.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_Telefono.Location = New System.Drawing.Point(33, 175)
        Label_Telefono.Name = "Label_Telefono"
        Label_Telefono.Size = New System.Drawing.Size(133, 30)
        Label_Telefono.TabIndex = 23
        Label_Telefono.Text = "Telefono"
        Label_Telefono.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox_Telefono
        '
        TextBox_Telefono.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TextBox_Telefono.Location = New System.Drawing.Point(172, 176)
        TextBox_Telefono.Name = "TextBox_Telefono"
        TextBox_Telefono.Size = New System.Drawing.Size(219, 29)
        TextBox_Telefono.TabIndex = 27
        TextBox_Telefono.Enabled = False
        '
        'Label_Correo
        '
        Label_Correo.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label_Correo.Location = New System.Drawing.Point(33, 215)
        Label_Correo.Name = "Label_Correo"
        Label_Correo.Size = New System.Drawing.Size(133, 30)
        Label_Correo.TabIndex = 24
        Label_Correo.Text = "Correo"
        Label_Correo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox_Correo
        '
        TextBox_Correo.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TextBox_Correo.Location = New System.Drawing.Point(172, 216)
        TextBox_Correo.Name = "TextBox_Correo"
        TextBox_Correo.Size = New System.Drawing.Size(219, 29)
        TextBox_Correo.TabIndex = 28
        TextBox_Correo.Enabled = False

        Panel_Baja.Controls.Add(Label_Titulo)
        Panel_Baja.Controls.Add(Label_ID)
        Panel_Baja.Controls.Add(Label_Nombre)
        Panel_Baja.Controls.Add(Label_Telefono)
        Panel_Baja.Controls.Add(Label_Correo)
        Panel_Baja.Controls.Add(TextBox_ID)
        Panel_Baja.Controls.Add(TextBox_Nombre)
        Panel_Baja.Controls.Add(TextBox_Telefono)
        Panel_Baja.Controls.Add(TextBox_Correo)
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
                                             Dim result As DialogResult = MessageBox.Show("¿Desea dar de baja al cliente N°" & IdClienteBaja & "?", "Confirmación", MessageBoxButtons.OKCancel)

                                             If result = DialogResult.OK Then
                                                 Dim ListaDeVentasDelCliente As List(Of Ventas) = Ventas.Buscar_Ventas_De_Cliente(IdClienteBaja)
                                                 If ListaDeVentasDelCliente.Count > 0 Then
                                                     Dim result2 As DialogResult = MessageBox.Show("El cliente tiene compras realizadas, ¿desea borrarlas tambien?", "Confirmación", MessageBoxButtons.OKCancel)
                                                     If result2 = DialogResult.OK Then
                                                         MessageBox.Show("El cliente y sus compras fueron eliminados")
                                                         For Each venta As Ventas In ListaDeVentasDelCliente
                                                             VentasItems.EliminarVentasItems(venta.ID)
                                                             Ventas.EliminarVenta(venta.ID)
                                                         Next
                                                         Clientes.EliminarCliente(IdClienteBaja)
                                                     Else
                                                         MessageBox.Show("El cliente no fue eliminado")
                                                     End If
                                                 Else
                                                     Clientes.EliminarCliente(IdClienteBaja)
                                                 End If
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