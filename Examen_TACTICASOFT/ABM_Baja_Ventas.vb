Imports System.Globalization

Public Class ABM_Baja_Ventas

    Private Panel_Productos As New Panel()

    Private Sub ABM_Baja_Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button_Buscar.Enabled = False
        Label_Fecha.Text = "Fecha: "
        Me.Controls.Add(Panel_Productos)
    End Sub


    Public Sub DetallesDeVenta(ID_Venta As String)

        Dim Posicion_Y As Integer = 50
        Dim TextBox_Total As New TextBox()


        ArmarPanel(Panel_Productos)
        Posicion_Y = PoblarItemsDeVenta(ID_Venta, Posicion_Y, Panel_Productos)
        ArmarSeccionTotal(Posicion_Y, TextBox_Total, Panel_Productos)
        ArmarSeccionBotones(Posicion_Y, Panel_Productos, ID_Venta)

    End Sub

    '----------- Armado de Panel
    '--------------- Coloca el panel y sus propiedades en el formulario. 
    '--------------- A su vez coloca los label correspondientes a las propiedades de los items a mostrar 
    Private Sub ArmarPanel(Panel_Productos As Panel)

        Dim Label_ProductoID As New Label()
        Dim Label_Cantidad As New Label()
        Dim Label_ProductoNombre As New Label()
        Dim Label_ValorUnitario As New Label()
        Dim Label_Subtotal As New Label()

        Panel_Productos.AutoScroll = True
        Panel_Productos.AutoSize = True
        Panel_Productos.Controls.Add(Label_ProductoID)
        Panel_Productos.Controls.Add(Label_Cantidad)
        Panel_Productos.Controls.Add(Label_Subtotal)
        Panel_Productos.Controls.Add(Label_ProductoNombre)
        Panel_Productos.Controls.Add(Label_ValorUnitario)
        Panel_Productos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Panel_Productos.Location = New System.Drawing.Point(0, 85)
        Panel_Productos.Name = "Panel_Productos"
        Panel_Productos.Size = New System.Drawing.Size(673, 459)
        Panel_Productos.TabIndex = 12

        'Label_ProductoID
        '
        Label_ProductoID.AutoSize = True
        Label_ProductoID.Font = New System.Drawing.Font("Sylfaen", 12.0!)
        Label_ProductoID.Location = New System.Drawing.Point(36, 20)
        Label_ProductoID.Name = "Label_ProductoID"
        Label_ProductoID.Size = New System.Drawing.Size(27, 22)
        Label_ProductoID.TabIndex = 9
        Label_ProductoID.Text = "ID"
        '
        'Label_Cantidad
        '
        Label_Cantidad.AutoSize = True
        Label_Cantidad.Font = New System.Drawing.Font("Sylfaen", 12.0!)
        Label_Cantidad.Location = New System.Drawing.Point(136, 20)
        Label_Cantidad.Name = "Label_Cantidad"
        Label_Cantidad.Size = New System.Drawing.Size(40, 22)
        Label_Cantidad.TabIndex = 5
        Label_Cantidad.Text = "Cant"
        '
        'Label_ProductoNombre
        '
        Label_ProductoNombre.AutoSize = True
        Label_ProductoNombre.Font = New System.Drawing.Font("Sylfaen", 12.0!)
        Label_ProductoNombre.Location = New System.Drawing.Point(206, 20)
        Label_ProductoNombre.Name = "Label_ProductoNombre"
        Label_ProductoNombre.Size = New System.Drawing.Size(69, 22)
        Label_ProductoNombre.TabIndex = 6
        Label_ProductoNombre.Text = "Producto"
        '
        'Label_ValorUnitario
        '
        Label_ValorUnitario.AutoSize = True
        Label_ValorUnitario.Font = New System.Drawing.Font("Sylfaen", 12.0!)
        Label_ValorUnitario.Location = New System.Drawing.Point(416, 20)
        Label_ValorUnitario.Name = "Label_ValorUnitario"
        Label_ValorUnitario.Size = New System.Drawing.Size(47, 22)
        Label_ValorUnitario.TabIndex = 7
        Label_ValorUnitario.Text = "Valor"
        '
        'Label_Subtotal
        '
        Label_Subtotal.AutoSize = True
        Label_Subtotal.Font = New System.Drawing.Font("Sylfaen", 12.0!)
        Label_Subtotal.Location = New System.Drawing.Point(526, 20)
        Label_Subtotal.Name = "Label_Subtotal"
        Label_Subtotal.Size = New System.Drawing.Size(64, 22)
        Label_Subtotal.TabIndex = 8
        Label_Subtotal.Text = "Subtotal"

        Panel_Productos.Controls.Add(Label_ProductoID)
        Panel_Productos.Controls.Add(Label_Cantidad)
        Panel_Productos.Controls.Add(Label_ProductoNombre)
        Panel_Productos.Controls.Add(Label_ValorUnitario)
        Panel_Productos.Controls.Add(Label_Subtotal)
    End Sub

    '----------- Muestra los propductos de una venta
    '--------------- Busca los productos de una venta por numero de venta
    '--------------- Luego los va colocando en el formulario
    Public Function PoblarItemsDeVenta(ID_Venta As Integer,
                                       Posicion_Y As Integer,
                                       Panel_Productos As Panel)

        Dim ItemsDeVenta As List(Of VentasItems) = VentasItems.ListaDeProductosDeVenta(ID_Venta)
        Dim ListaDeProductos As List(Of Productos) = Productos.Lista_Productos()

        For Each producto_item As VentasItems In ItemsDeVenta

            Dim TextBox_IdProducto As New TextBox()
            Dim NumericUpDown_Cantidad As New NumericUpDown()
            Dim ComboBox_Producto As New ComboBox()
            Dim TextBox_ValorUnitario As New TextBox()
            Dim TextBox_Subtotal As New TextBox()


            TextBox_IdProducto.Text = producto_item.ID_Producto.ToString()
            TextBox_IdProducto.Name = "IdProducto_" & Posicion_Y
            TextBox_IdProducto.Enabled = False
            TextBox_IdProducto.Font = New System.Drawing.Font("Sylfaen", 10.0!)
            TextBox_IdProducto.Location = New System.Drawing.Point(40, Posicion_Y)
            TextBox_IdProducto.Size = New System.Drawing.Size(90, 25)

            NumericUpDown_Cantidad.Value = CDec(producto_item.Cantidad)
            NumericUpDown_Cantidad.Enabled = False
            NumericUpDown_Cantidad.Name = "Cantidad_" & Posicion_Y
            NumericUpDown_Cantidad.Font = New System.Drawing.Font("Sylfaen", 10.0!)
            NumericUpDown_Cantidad.Location = New System.Drawing.Point(140, Posicion_Y)
            NumericUpDown_Cantidad.Size = New System.Drawing.Size(60, 25)

            ComboBox_Producto.Text = ListaDeProductos.Find(Function(buscar_producto_item) buscar_producto_item.ID = producto_item.ID_Producto).Nombre
            ComboBox_Producto.Name = "NombreProducto_" & Posicion_Y
            ComboBox_Producto.Enabled = False
            ComboBox_Producto.Font = New System.Drawing.Font("Sylfaen", 10.0!)
            ComboBox_Producto.Location = New System.Drawing.Point(210, Posicion_Y)
            ComboBox_Producto.Size = New System.Drawing.Size(200, 25)

            TextBox_ValorUnitario.Text = Format(producto_item.PrecioUnitario.ToString(), "currency")
            TextBox_ValorUnitario.Name = "ValorUnitario_" & Posicion_Y
            TextBox_ValorUnitario.Enabled = False
            TextBox_ValorUnitario.Font = New System.Drawing.Font("Sylfaen", 10.0!)
            TextBox_ValorUnitario.Location = New System.Drawing.Point(420, Posicion_Y)
            TextBox_ValorUnitario.Size = New System.Drawing.Size(100, 25)

            TextBox_Subtotal.Text = Format(producto_item.PrecioTotal.ToString(), "currency")
            TextBox_Subtotal.Name = "Subtotal_" & Posicion_Y
            TextBox_Subtotal.Enabled = False
            TextBox_Subtotal.Font = New System.Drawing.Font("Sylfaen", 10.0!)
            TextBox_Subtotal.Location = New System.Drawing.Point(530, Posicion_Y)
            TextBox_Subtotal.Size = New System.Drawing.Size(100, 25)

            Panel_Productos.Controls.Add(TextBox_IdProducto)
            Panel_Productos.Controls.Add(NumericUpDown_Cantidad)
            Panel_Productos.Controls.Add(ComboBox_Producto)
            Panel_Productos.Controls.Add(TextBox_ValorUnitario)
            Panel_Productos.Controls.Add(TextBox_Subtotal)

            Posicion_Y += 35
        Next

        Return Posicion_Y
    End Function

    '----------- Armado de "seccion Total"
    '--------------- La "seccion Total" consiste en el label "Total" y el textbox correspondiente donde 
    '--------------- muestra el total calculado.
    Private Sub ArmarSeccionTotal(Posicion_Y As Integer, TextBox_Total As TextBox, Panel_Productos As Panel)

        Dim Label_Total As New Label()

        Label_Total.Text = "Total"
        Label_Total.Enabled = False
        Label_Total.Font = New System.Drawing.Font("Sylfaen", 10.0!)
        Label_Total.Location = New System.Drawing.Point(420, Posicion_Y)
        Label_Total.Size = New System.Drawing.Size(100, 25)

        TextBox_Total.Text = Format(Total_Venta(Panel_Productos).ToString(), "currency")
        TextBox_Total.Name = "Total"
        TextBox_Total.Enabled = False
        TextBox_Total.Font = New System.Drawing.Font("Sylfaen", 10.0!)
        TextBox_Total.Location = New System.Drawing.Point(530, Posicion_Y)
        TextBox_Total.Size = New System.Drawing.Size(100, 25)

        Panel_Productos.Controls.Add(Label_Total)
        Panel_Productos.Controls.Add(TextBox_Total)
    End Sub

    '----------- Armado de "seccion Botones"
    '--------------- La "seccion Botones" consiste los botones aceptar y cancelar
    '--------------- poniendo todas sus propiedades y ubicandolos por debajo de la "seccion total"
    Private Sub ArmarSeccionBotones(Posicion_Y As Integer,
                                    Panel_Productos As Panel,
                                    ID_Venta As String)

        Dim Button_Cancelar As New Button()
        Dim Button_Aceptar As New Button()
        '
        'Button_Cancelar
        '
        Button_Cancelar.Font = New System.Drawing.Font("Sylfaen", 12.0!)
        Button_Cancelar.Location = New System.Drawing.Point(370, Posicion_Y + 35)
        Button_Cancelar.Name = "Button_Cancelar"
        Button_Cancelar.Size = New System.Drawing.Size(125, 35)
        Button_Cancelar.TabIndex = 16
        Button_Cancelar.Text = "Cancelar"
        Button_Cancelar.UseVisualStyleBackColor = True
        AddHandler Button_Cancelar.Click, Sub()
                                              Me.Close()
                                          End Sub
        '
        'Button_Aceptar
        '
        Button_Aceptar.Font = New System.Drawing.Font("Sylfaen", 12.0!)
        Button_Aceptar.Location = New System.Drawing.Point(505, Posicion_Y + 35)
        Button_Aceptar.Name = "Button_Aceptar"
        Button_Aceptar.Size = New System.Drawing.Size(125, 35)
        Button_Aceptar.TabIndex = 17
        Button_Aceptar.Text = "Eliminar"
        Button_Aceptar.UseVisualStyleBackColor = True
        AddHandler Button_Aceptar.Click, Sub()
                                             Dim result As DialogResult = MessageBox.Show("¿Quiere dar de baja la venta numero: " & ID_Venta, "Confirmación", MessageBoxButtons.OKCancel)

                                             If result = DialogResult.OK Then
                                                 VentasItems.EliminarVentasItems(ID_Venta)
                                                 Ventas.EliminarVenta(ID_Venta)
                                                 MessageBox.Show("Ha sido eliminado existosamente.")
                                                 Me.Close()
                                             End If
                                         End Sub

        Panel_Productos.Controls.Add(Button_Cancelar)
        Panel_Productos.Controls.Add(Button_Aceptar)
    End Sub

    '----------- Calcula Total
    '--------------- Funcion que hace barrido por todos los controles del panel
    '--------------- va sumando todos los controles que tengan en el nombre el texto "subtotal"
    Public Function Total_Venta(Panel_Productos As Panel)
        Dim Total As Decimal = 0

        For Each controles As Control In Panel_Productos.Controls
            If TypeOf controles Is TextBox AndAlso controles.Name.Contains("Subtotal") AndAlso controles.Text IsNot "" Then
                Total += Decimal.Parse(controles.Text, NumberStyles.Currency)
            End If
        Next

        Return Total
    End Function

    '----------- Buscador de venta
    '--------------- Habilita el boton "buscar" por numero de venta solo si hay texto escrito 
    '--------------- 
    Private Sub TextBox_ID_TextChanged(sender As Object, e As EventArgs) Handles TextBox_ID.TextChanged
        If TextBox_ID.Text Is Nothing Or TextBox_ID.Text = "" Then
            Button_Buscar.Enabled = False
        Else
            Button_Buscar.Enabled = True
        End If
    End Sub

    '----------- Buscar venta
    '--------------- Buscar una venta por numero de ID. Si encuentra muestra el detalle de la venta para 
    '--------------- Si no encuentra no muestra nada.
    Private Sub Button_Buscar_Click(sender As Object, e As EventArgs) Handles Button_Buscar.Click

        Dim ListaDeVentas As List(Of Ventas) = Ventas.Buscar_Ventas()
        Dim ListaDeClientes As List(Of Clientes) = Clientes.Lista_Clientes()

        Dim VentaEncontrada As Ventas = ListaDeVentas.Find(Function(buscar_venta) buscar_venta.ID = TextBox_ID.Text)

        If VentaEncontrada IsNot Nothing Then
            If Label_Encontrado.Text = "" Then
                DetallesDeVenta(VentaEncontrada.ID)

            ElseIf Label_Encontrado.Text.Contains("Cliente") Then
                ELiminarDetallesDeVenta(Panel_Productos)
                DetallesDeVenta(VentaEncontrada.ID)
            Else
                DetallesDeVenta(VentaEncontrada.ID)
            End If
            Dim clienteEncontrado As Clientes = ListaDeClientes.Find(Function(buscar_cliente) buscar_cliente.ID = VentaEncontrada.ID_Cliente)
            Label_Encontrado.Text = "Cliente: " & clienteEncontrado.cliente
            Label_Fecha.Text = "Fecha: " & VentaEncontrada.Fecha

        Else
            If Label_Encontrado.Text <> "" And Label_Encontrado.Text.Contains("Cliente") Then
                ELiminarDetallesDeVenta(Panel_Productos)
            End If
            Label_Fecha.Text = "Fecha: "
            Label_Encontrado.Text = "Venta N°: " & TextBox_ID.Text & " no existe"
        End If
    End Sub

    '----------- Borra producto de venta
    '--------------- Eliminar todos los controles del panel.
    '--------------- 
    Private Sub ELiminarDetallesDeVenta(Panel_Productos As Panel)
        Panel_Productos.Controls.Clear()
    End Sub
End Class

