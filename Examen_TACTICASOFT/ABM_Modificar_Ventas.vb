Imports System.ComponentModel
Imports System.Globalization

Public Class ABM_Modificar_Ventas

    Private Panel_Productos As New Panel()

    Public Sub Modificar_Ventas(ID_Venta As String)
        Me.Controls.Add(Panel_Productos)
        Me.Show()

        TextBox_VentaID.Text = ID_Venta
        Dim Posicion_Y As Integer = 50
        Dim Label_Total As New Label()
        Dim TextBox_Total As New TextBox()

        ArmarPanel(Panel_Productos)
        Posicion_Y = PoblarItemsDeVenta(ID_Venta, Posicion_Y, Panel_Productos)
        ArmarSeccionTotal(Posicion_Y, TextBox_Total, Label_Total, Panel_Productos)
        ArmarSeccionBotones(Posicion_Y, TextBox_Total, Label_Total, Panel_Productos, ID_Venta)

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
            NumericUpDown_Cantidad.Enabled = True
            NumericUpDown_Cantidad.Name = "Cantidad_" & Posicion_Y
            NumericUpDown_Cantidad.Font = New System.Drawing.Font("Sylfaen", 10.0!)
            NumericUpDown_Cantidad.Location = New System.Drawing.Point(140, Posicion_Y)
            NumericUpDown_Cantidad.Size = New System.Drawing.Size(60, 25)
            AddHandler NumericUpDown_Cantidad.ValueChanged, Sub()
                                                                TextBox_Subtotal.Text = Format((CInt(NumericUpDown_Cantidad.Value) * CDec(TextBox_ValorUnitario.Text)).ToString(), "currency")
                                                            End Sub

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
    Private Sub ArmarSeccionTotal(Posicion_Y As Integer, TextBox_Total As TextBox, Label_Total As Label, Panel_Productos As Panel)

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
                                    TextBox_Total As TextBox,
                                    Label_Total As Label,
                                    Panel_Productos As Panel,
                                    ID_Venta As String)

        Dim Button_ProductoNuevo As New Button()
        Dim Button_Cancelar As New Button()
        Dim Button_Aceptar As New Button()

        Button_ProductoNuevo.Font = New System.Drawing.Font("Sylfaen", 12.0!)
        Button_ProductoNuevo.Location = New System.Drawing.Point(235, Posicion_Y + 35)
        Button_ProductoNuevo.Size = New System.Drawing.Size(125, 35)
        Button_ProductoNuevo.Text = "Nuevo Producto"
        Button_ProductoNuevo.Name = "Button_ProductoNuevo"

        AddHandler Button_ProductoNuevo.Click, Sub()
                                                   Posicion_Y = CamposNuevos(Posicion_Y, TextBox_Total)

                                                   Label_Total.Location = New System.Drawing.Point(420, Posicion_Y)
                                                   TextBox_Total.Location = New System.Drawing.Point(530, Posicion_Y)
                                                   Button_ProductoNuevo.Location = New System.Drawing.Point(235, Posicion_Y + 35)
                                                   Button_Cancelar.Location = New System.Drawing.Point(370, Posicion_Y + 35)
                                                   Button_Aceptar.Location = New System.Drawing.Point(505, Posicion_Y + 35)
                                               End Sub
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
        Button_Aceptar.Text = "Modificar"
        Button_Aceptar.UseVisualStyleBackColor = True
        AddHandler Button_Aceptar.Click, Sub()
                                             Dim result As DialogResult = MessageBox.Show("¿Quiere modificar la venta numero: " & ID_Venta & "?", "Confirmación", MessageBoxButtons.OKCancel)

                                             If result = DialogResult.OK Then
                                                 ListaProductosParaActualizar(CInt(ID_Venta))
                                                 Me.Close()
                                             End If
                                         End Sub

        Panel_Productos.Controls.Add(Button_ProductoNuevo)
        Panel_Productos.Controls.Add(Button_Cancelar)
        Panel_Productos.Controls.Add(Button_Aceptar)
    End Sub

    '----------- Armado de lista de productos en la venta para agregar a la tabla ventasItems
    '--------------- Hace un barrido por todos los controles armando la lista de los productos 
    '--------------- usa "VentasItems.CrearVentasItems(ListaItemsVenta)" el cual agrega la lista a la tabla
    Private Function CamposNuevos(Posicion_Y As Integer, TextBox_Total As TextBox)

        Dim TextBox_IdProducto As New TextBox()
        Dim Cantidad As New NumericUpDown()
        Dim Producto As New ComboBox()
        Dim ValorUnitario As New TextBox()
        Dim Subtotal As New TextBox()
        Dim ListaDeProductos As List(Of Productos) = Productos.Lista_Productos()

        TextBox_IdProducto.Name = "IdProducto_" & Posicion_Y
        TextBox_IdProducto.Enabled = False
        TextBox_IdProducto.Font = New System.Drawing.Font("Sylfaen", 10.0!)
        TextBox_IdProducto.Location = New System.Drawing.Point(40, Posicion_Y)
        TextBox_IdProducto.Size = New System.Drawing.Size(90, 25)

        Cantidad.Enabled = False
        Cantidad.Name = "Cantidad_" & Posicion_Y
        Cantidad.Value = 0
        Cantidad.Font = New System.Drawing.Font("Sylfaen", 10.0!)
        Cantidad.Location = New System.Drawing.Point(140, Posicion_Y)
        Cantidad.Size = New System.Drawing.Size(60, 25)
        AddHandler Cantidad.ValueChanged, Sub()
                                              Subtotal.Text = Format((CInt(Cantidad.Value) * CDec(ValorUnitario.Text)).ToString(), "currency")
                                          End Sub

        Producto.Enabled = True
        Producto.Name = "NombreProducto_" & Posicion_Y
        Producto.Font = New System.Drawing.Font("Sylfaen", 10.0!)
        Producto.Location = New System.Drawing.Point(210, Posicion_Y)
        Producto.Size = New System.Drawing.Size(200, 25)
        For Each productoEnLista As Productos In ListaDeProductos
            Producto.Items.Add(productoEnLista.Nombre)
        Next
        AddHandler Producto.SelectionChangeCommitted, Sub()
                                                          TextBox_IdProducto.Text = ListaDeProductos.Item(Producto.SelectedIndex).ID.ToString()
                                                          ValorUnitario.Text = Format(ListaDeProductos.Item(Producto.SelectedIndex).Precio, "currency")
                                                          Cantidad.Enabled = True
                                                          Subtotal.Text = Format((CInt(Cantidad.Value) * CDec(ValorUnitario.Text)).ToString(), "currency")
                                                      End Sub

        ValorUnitario.Text = ""
        ValorUnitario.Name = "ValorUnitario_" & Posicion_Y
        ValorUnitario.Enabled = False
        ValorUnitario.Font = New System.Drawing.Font("Sylfaen", 10.0!)
        ValorUnitario.Location = New System.Drawing.Point(420, Posicion_Y)
        ValorUnitario.Size = New System.Drawing.Size(100, 25)

        Subtotal.Text = ""
        Subtotal.Name = "Subtotal_" & Posicion_Y
        Subtotal.Enabled = False
        Subtotal.Font = New System.Drawing.Font("Sylfaen", 10.0!)
        Subtotal.Location = New System.Drawing.Point(530, Posicion_Y)
        Subtotal.Size = New System.Drawing.Size(100, 25)
        AddHandler Subtotal.TextChanged, Sub()
                                             TextBox_Total.Text = Format(Total_Venta(Panel_Productos).ToString(), "currency")
                                         End Sub

        Panel_Productos.Controls.Add(TextBox_IdProducto)
        Panel_Productos.Controls.Add(Cantidad)
        Panel_Productos.Controls.Add(Producto)
        Panel_Productos.Controls.Add(ValorUnitario)
        Panel_Productos.Controls.Add(Subtotal)

        Posicion_Y += 35

        Return Posicion_Y
    End Function

    '----------- Calcula el total
    '--------------- Hace un barrido por todos los controles que se tengan
    '--------------- "Subtotal" en el nombre y los suma.
    Public Function Total_Venta(Panel_Productos As Panel)
        Dim Total As Decimal = 0

        For Each controles As Control In Panel_Productos.Controls
            If TypeOf controles Is TextBox AndAlso controles.Name.Contains("Subtotal") AndAlso controles.Text IsNot "" Then
                Total += Decimal.Parse(controles.Text, NumberStyles.Currency)
            End If
        Next

        Return Total
    End Function

    '----------- Arma la lista de productos y los datos de la venta para modificar
    '--------------- Hace un barrido por todos los controles armando la lista de los productos 
    '--------------- si el campo ID esta vacio saltea y deja pasar los campos de dicha "fila".
    Public Sub ListaProductosParaActualizar(IdVenta As Integer)
        Dim IdProducto As Integer
        Dim Cantidad As Integer = 0
        Dim Producto As String
        Dim Valor As Decimal
        Dim Subtotal As Decimal
        Dim Total As Decimal = 0
        Dim Vacio As Boolean = True
        Dim ListaParaActualizar As New List(Of VentasItems)

        For Each controles As Control In Panel_Productos.Controls
            If TypeOf controles Is TextBox AndAlso controles.Name.Contains("IdProducto") Then
                If controles.Text Is Nothing Or controles.Text = "" Then
                    Vacio = True
                    Continue For
                Else
                    IdProducto = CInt(controles.Text)
                    Vacio = False
                End If
            End If

            If TypeOf controles Is NumericUpDown AndAlso controles.Name.Contains("Cantidad") AndAlso Not Vacio Then
                Cantidad = CDec(controles.Text)
            End If

            If (TypeOf controles Is TextBox Or TypeOf controles Is ComboBox) AndAlso controles.Name.Contains("NombreProducto") AndAlso Not Vacio Then
                Producto = controles.Text
            End If

            If TypeOf controles Is TextBox AndAlso controles.Name.Contains("ValorUnitario") AndAlso Not Vacio Then
                Valor = Decimal.Parse(controles.Text, NumberStyles.Currency)
            End If

            If TypeOf controles Is TextBox AndAlso controles.Name.Contains("Subtotal") AndAlso Not Vacio Then
                Subtotal = Decimal.Parse(controles.Text, NumberStyles.Currency)
                Dim NuevoItemVenta As New VentasItems(IdVenta, IdProducto, Valor, Cantidad, Subtotal)
                ListaParaActualizar.Add(NuevoItemVenta)
            End If

            If TypeOf controles Is TextBox AndAlso controles.Name.Contains("Total") Then
                Total = Decimal.Parse(controles.Text, NumberStyles.Currency)
            End If
        Next

        VentasItems.ActualizarVentasItems(IdVenta, ListaParaActualizar)
        Ventas.ActualizarVenta(IdVenta, Total)
    End Sub

    '----------- Cuando se termina de modificar
    '--------------- Se cierra la ventana y se utiliza "Buscador_Ventas.leer_Ventas()" para 
    '--------------- actualizar los campos en el buscador.
    Private Sub ABM_Modificar_Ventas_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Buscador_Ventas.leer_ventas()
    End Sub

End Class