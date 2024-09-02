Imports System.Globalization

Public Class ABM_Alta_Ventas

    Private Panel_Productos As New Panel()

    Private Sub ABM_Alta_Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Controls.Add(Panel_Productos)
    End Sub

    '----------- Buscador de cliente
    '--------------- Habilita el boton "buscar" por numero de cliente solo si hay texto escrito 
    '--------------- 
    Private Sub TextBox_ID_TextChanged(sender As Object, e As EventArgs) Handles TextBox_ID.TextChanged
        If TextBox_ID.Text Is Nothing Or TextBox_ID.Text = "" Then
            Button_Buscar.Enabled = False
        Else
            Button_Buscar.Enabled = True
        End If
    End Sub

    '----------- Buscar
    '--------------- Buscar un cliente por numero de ID. Si encuentra habilita a agregar productos 
    '--------------- a una nueva venta y el boton aceptar. 
    Private Sub Button_Buscar_Click(sender As Object, e As EventArgs) Handles Button_Buscar.Click
        Dim ListaDeClientes As List(Of Clientes) = Clientes.Lista_Clientes()
        Dim clienteEncontrado As Clientes = ListaDeClientes.Find(Function(buscar_cliente) buscar_cliente.ID = TextBox_ID.Text)

        If Label_Encontrado.Text = "" Then
            ArmadoDePantallaAlta()
        End If

        If clienteEncontrado Is Nothing Then
            Label_Encontrado.Text = "Cliente no encontrado"
        Else
            Label_Encontrado.Text = "Cliente:" & clienteEncontrado.cliente
        End If

    End Sub

    '----------- 
    '--------------- 
    '--------------- 
    Public Sub ArmadoDePantallaAlta()

        Dim Posicion_Y As Integer = 50

        Dim Label_Total As New Label()
        Dim TextBox_Total As New TextBox()
        Dim ListaDeProductos As List(Of Productos) = Productos.Lista_Productos()

        ArmarPanel(Panel_Productos)
        Posicion_Y = CamposNuevos(Posicion_Y, TextBox_Total)
        ArmarSeccionTotal(Posicion_Y, TextBox_Total, Label_Total, Panel_Productos)
        ArmarSeccionBotones(Posicion_Y, TextBox_Total, Label_Total, Panel_Productos)


    End Sub

    '----------- Armado de venta para agregar a la tabla ventas
    '--------------- Hace un barrido por todos los controles buscando los camponentes necesarios para armar una venta
    '--------------- usa "Ventas.CrearVenta(NuevaVenta)" el cual agrega la venta a la tabla ventas
    Public Sub CrearVenta(IdCliente As Integer)
        Dim Total As Decimal
        Dim IdVenta As String

        For Each controles As Control In Panel_Productos.Controls
            If TypeOf controles Is TextBox AndAlso controles.Name.Contains("Total") Then
                Total = Decimal.Parse(controles.Text, NumberStyles.Currency)
            End If
        Next

        Dim NuevaVenta As New Ventas(IdCliente, Now(), Total)
        IdVenta = Ventas.CrearVenta(NuevaVenta)
        ListaProductosParaAgregar(IdVenta)
    End Sub

    '----------- 
    '--------------- Hace un barrido por todos los controles armando la lista de los productos 
    '--------------- usa "VentasItems.CrearVentasItems(ListaItemsVenta)" el cual agrega la lista a la tabla
    Private Sub ListaProductosParaAgregar(IdVenta As Integer)
        Dim IdProducto As Integer
        Dim Cantidad As Integer = 0
        Dim Producto As String
        Dim Valor As Decimal
        Dim Subtotal As Decimal
        Dim Vacio As Boolean = True
        Dim ListaItemsVenta As New List(Of VentasItems)

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
                ListaItemsVenta.Add(NuevoItemVenta)
            End If

        Next

        VentasItems.CrearVentasItems(ListaItemsVenta)

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
                                             TextBox_Total.Text = Format(Total_Venta().ToString(), "currency")
                                         End Sub

        Panel_Productos.Controls.Add(TextBox_IdProducto)
        Panel_Productos.Controls.Add(Cantidad)
        Panel_Productos.Controls.Add(Producto)
        Panel_Productos.Controls.Add(ValorUnitario)
        Panel_Productos.Controls.Add(Subtotal)

        Posicion_Y += 35

        Return Posicion_Y
    End Function

    '----------- 
    '--------------- 
    '--------------- 
    Public Function Total_Venta()
        Dim Total As Decimal = 0

        For Each controles As Control In Panel_Productos.Controls
            If TypeOf controles Is TextBox AndAlso controles.Name.Contains("Subtotal") AndAlso controles.Text IsNot "" Then
                Total += Decimal.Parse(controles.Text, NumberStyles.Currency)
            End If
        Next

        Return Total
    End Function

    '----------- 
    '--------------- 
    '--------------- 
    Private Sub Button_Cancelar_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    '----------- 
    '--------------- 
    '--------------- 
    Private Sub ArmarSeccionTotal(Posicion_Y As Integer, TextBox_Total As TextBox, Label_Total As Label, Panel_Productos As Panel)

        Label_Total.Text = "Total"
        Label_Total.Enabled = False
        Label_Total.Font = New System.Drawing.Font("Sylfaen", 10.0!)
        Label_Total.Location = New System.Drawing.Point(420, Posicion_Y)
        Label_Total.Size = New System.Drawing.Size(100, 25)

        TextBox_Total.Text = 0
        TextBox_Total.Name = "Total"
        TextBox_Total.Enabled = False
        TextBox_Total.Font = New System.Drawing.Font("Sylfaen", 10.0!)
        TextBox_Total.Location = New System.Drawing.Point(530, Posicion_Y)
        TextBox_Total.Size = New System.Drawing.Size(100, 25)

        Panel_Productos.Controls.Add(Label_Total)
        Panel_Productos.Controls.Add(TextBox_Total)
    End Sub

    '----------- 
    '--------------- 
    '--------------- 
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

    Private Sub ArmarSeccionBotones(Posicion_Y As Integer,
                                    TextBox_Total As TextBox,
                                    Label_Total As Label,
                                    Panel_Productos As Panel)

        Dim Button_ProductoNuevo As New Button()
        Dim Button_Cancelar As New Button()
        Dim Button_Aceptar As New Button()

        '
        'Button_ProductoNuevo
        '
        Button_ProductoNuevo.Font = New System.Drawing.Font("Sylfaen", 12.0!)
        Button_ProductoNuevo.Location = New System.Drawing.Point(235, Posicion_Y + 35)
        Button_ProductoNuevo.Name = "Button_ProductoNuevo"
        Button_ProductoNuevo.Size = New System.Drawing.Size(125, 35)
        Button_ProductoNuevo.TabIndex = 15
        Button_ProductoNuevo.Text = "Nuevo Producto"
        Button_ProductoNuevo.UseVisualStyleBackColor = True
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
        Button_Aceptar.Text = "Agregar"
        Button_Aceptar.UseVisualStyleBackColor = True
        AddHandler Button_Aceptar.Click, Sub()

                                             If Label_Encontrado.Text <> "Cliente no encontrado" Then
                                                 Dim result As DialogResult = MessageBox.Show("¿Quiere dar de alta la venta?", "Confirmación", MessageBoxButtons.OKCancel)

                                                 If result = DialogResult.OK Then
                                                     CrearVenta(TextBox_ID.Text)
                                                     Me.Close()
                                                 End If
                                             End If
                                         End Sub

        Panel_Productos.Controls.Add(Button_ProductoNuevo)
        Panel_Productos.Controls.Add(Button_Cancelar)
        Panel_Productos.Controls.Add(Button_Aceptar)

    End Sub
End Class

