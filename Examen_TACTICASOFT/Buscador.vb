Imports System.Configuration
Imports System.Data.SqlClient

Public Class Buscador

    '--------------------------- Panel Clientes
    Dim Panel_Clientes As New Panel

    Dim Label_IdCliente As New Label
    Dim Label_NombreCliente As New Label
    Dim Label_TelefonoCliente As New Label
    Dim Label_CorreoCliente As New Label

    Dim TextBox_IdCliente As New TextBox
    Dim TextBox_NombreCliente As New TextBox
    Dim TextBox_TelefonoCliente As New TextBox
    Dim TextBox_CorreoCliente As New TextBox

    Dim ListView_Clientes As New ListView

    Dim Button_ModificarClientes As New Button
    Dim Button_BuscarClientes As New Button

    Private Sub ArmardoFiltros_Clientes(Panel As Panel)
        '
        'Label_IdCliente
        '
        Label_IdCliente.AutoSize = True
        Label_IdCliente.Font = New System.Drawing.Font("Sylfaen", 12.0!)
        Label_IdCliente.Location = New System.Drawing.Point(21, 23)
        Label_IdCliente.Name = "Label_IdCliente"
        Label_IdCliente.Size = New System.Drawing.Size(131, 22)
        Label_IdCliente.TabIndex = 25
        Label_IdCliente.Text = "N° de cliente"
        '
        'Label_NombreCliente
        '
        Label_NombreCliente.AutoSize = True
        Label_NombreCliente.Font = New System.Drawing.Font("Sylfaen", 12.0!)
        Label_NombreCliente.Location = New System.Drawing.Point(21, 58)
        Label_NombreCliente.Name = "Label_NombreCliente"
        Label_NombreCliente.Size = New System.Drawing.Size(64, 22)
        Label_NombreCliente.TabIndex = 26
        Label_NombreCliente.Text = "Nombre"
        '
        'Label_TelefonoCliente
        '
        Label_TelefonoCliente.AutoSize = True
        Label_TelefonoCliente.Font = New System.Drawing.Font("Sylfaen", 12.0!)
        Label_TelefonoCliente.Location = New System.Drawing.Point(347, 23)
        Label_TelefonoCliente.Name = "Label_TelefonoCliente"
        Label_TelefonoCliente.Size = New System.Drawing.Size(68, 22)
        Label_TelefonoCliente.TabIndex = 27
        Label_TelefonoCliente.Text = "Telefono"
        '
        'Label_CorreoCliente
        '
        Label_CorreoCliente.AutoSize = True
        Label_CorreoCliente.Font = New System.Drawing.Font("Sylfaen", 12.0!)
        Label_CorreoCliente.Location = New System.Drawing.Point(347, 58)
        Label_CorreoCliente.Name = "Label_CorreoCliente"
        Label_CorreoCliente.Size = New System.Drawing.Size(55, 22)
        Label_CorreoCliente.TabIndex = 28
        Label_CorreoCliente.Text = "Correo"
        '
        'TextBox_IdCliente
        '
        TextBox_IdCliente.Font = New System.Drawing.Font("Sylfaen", 12.0!)
        TextBox_IdCliente.Location = New System.Drawing.Point(175, 20)
        TextBox_IdCliente.Name = "TextBox_IdCliente"
        TextBox_IdCliente.Size = New System.Drawing.Size(148, 29)
        TextBox_IdCliente.TabIndex = 18
        AddHandler TextBox_IdCliente.KeyDown, Sub(sender As Object, e As KeyEventArgs)
                                                  If e.KeyCode = Keys.Enter Then
                                                      PoblarListView_Productos()
                                                      e.Handled = True
                                                      e.SuppressKeyPress = True
                                                  End If
                                              End Sub
        '
        'TextBox_NombreCliente
        '
        TextBox_NombreCliente.Font = New System.Drawing.Font("Sylfaen", 12.0!)
        TextBox_NombreCliente.Location = New System.Drawing.Point(175, 55)
        TextBox_NombreCliente.Name = "TextBox_NombreCliente"
        TextBox_NombreCliente.Size = New System.Drawing.Size(148, 29)
        TextBox_NombreCliente.TabIndex = 19
        AddHandler TextBox_NombreCliente.KeyDown, Sub(sender As Object, e As KeyEventArgs)
                                                      If e.KeyCode = Keys.Enter Then
                                                          PoblarListView_Productos()
                                                          e.Handled = True
                                                          e.SuppressKeyPress = True
                                                      End If
                                                  End Sub
        '
        'TextBox_TelefonoCliente
        '
        TextBox_TelefonoCliente.Font = New System.Drawing.Font("Sylfaen", 12.0!)
        TextBox_TelefonoCliente.Location = New System.Drawing.Point(488, 20)
        TextBox_TelefonoCliente.Name = "TextBox_TelefonoCliente"
        TextBox_TelefonoCliente.Size = New System.Drawing.Size(148, 29)
        TextBox_TelefonoCliente.TabIndex = 20
        AddHandler TextBox_TelefonoCliente.KeyDown, Sub(sender As Object, e As KeyEventArgs)
                                                        If e.KeyCode = Keys.Enter Then
                                                            PoblarListView_Productos()
                                                            e.Handled = True
                                                            e.SuppressKeyPress = True
                                                        End If
                                                    End Sub
        '
        'TextBox_CorreoCliente
        '
        TextBox_CorreoCliente.Font = New System.Drawing.Font("Sylfaen", 12.0!)
        TextBox_CorreoCliente.Location = New System.Drawing.Point(488, 55)
        TextBox_CorreoCliente.Name = "TextBox_CorreoCliente"
        TextBox_CorreoCliente.Size = New System.Drawing.Size(148, 29)
        TextBox_CorreoCliente.TabIndex = 21
        AddHandler TextBox_CorreoCliente.KeyDown, Sub(sender As Object, e As KeyEventArgs)
                                                      If e.KeyCode = Keys.Enter Then
                                                          PoblarListView_Productos()
                                                          e.Handled = True
                                                          e.SuppressKeyPress = True
                                                      End If
                                                  End Sub
        '
        'Button_Buscar
        '
        Button_BuscarClientes.Font = New System.Drawing.Font("Sylfaen", 12.0!)
        Button_BuscarClientes.Location = New System.Drawing.Point(651, 20)
        Button_BuscarClientes.Name = "Button_Buscar"
        Button_BuscarClientes.Size = New System.Drawing.Size(76, 64)
        Button_BuscarClientes.TabIndex = 22
        Button_BuscarClientes.Text = "Buscar"
        Button_BuscarClientes.UseVisualStyleBackColor = True
        AddHandler Button_BuscarClientes.Click, Sub()
                                                    PoblarListView_Clientes()
                                                End Sub

        Panel.Controls.Add(Label_IdCliente)
        Panel.Controls.Add(Label_NombreCliente)
        Panel.Controls.Add(Label_TelefonoCliente)
        Panel.Controls.Add(Label_CorreoCliente)

        Panel.Controls.Add(TextBox_IdCliente)
        Panel.Controls.Add(TextBox_NombreCliente)
        Panel.Controls.Add(TextBox_TelefonoCliente)
        Panel.Controls.Add(TextBox_CorreoCliente)
        Panel.Controls.Add(Button_BuscarClientes)
    End Sub
    Private Sub ArmadoListView_Clientes(Panel As Panel)

        Dim Column_IdCliente As New ColumnHeader
        Dim Column_NombreCliente As New ColumnHeader
        Dim Column_Telefono As New ColumnHeader
        Dim Column_Correo As New ColumnHeader

        '
        'Column_IdCliente
        '
        Column_IdCliente.Text = "Cliente N°"
        Column_IdCliente.Width = 89
        '
        'Column_NombreCliente
        '
        Column_NombreCliente.Text = "Nombre"
        Column_NombreCliente.Width = 213
        '
        'Column_Telefono
        '
        Column_Telefono.Text = "Telefono"
        Column_Telefono.Width = 151
        '
        'Column_Correo
        '
        Column_Correo.Text = "Correo"
        Column_Correo.Width = 228

        '
        'ListView_Clientes
        '
        ListView_Clientes.Columns.Clear()
        ListView_Clientes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Column_IdCliente, Column_NombreCliente, Column_Telefono, Column_Correo})
        ListView_Clientes.Font = New System.Drawing.Font("Sylfaen", 12.0!)
        ListView_Clientes.FullRowSelect = True
        ListView_Clientes.HideSelection = False
        ListView_Clientes.Location = New System.Drawing.Point(10, 90)
        ListView_Clientes.Name = "ListView_Clientes"
        ListView_Clientes.Size = New System.Drawing.Size(716, 327)
        ListView_Clientes.TabIndex = 24
        ListView_Clientes.UseCompatibleStateImageBehavior = False
        ListView_Clientes.View = System.Windows.Forms.View.Details

        Panel.Controls.Add(ListView_Clientes)
    End Sub
    Private Sub ArmadoBotones_Cliente(panel As Panel)
        '
        'Button_Modificar
        '
        Button_ModificarClientes.Font = New System.Drawing.Font("Sylfaen", 12.0!)
        Button_ModificarClientes.Location = New System.Drawing.Point(579, 437)
        Button_ModificarClientes.Name = "Button_ModificarClientes"
        Button_ModificarClientes.Size = New System.Drawing.Size(148, 39)
        Button_ModificarClientes.TabIndex = 23
        Button_ModificarClientes.Text = "Modificar Cliente"
        Button_ModificarClientes.UseVisualStyleBackColor = True
        AddHandler Button_ModificarClientes.Click, Sub()
                                                       If ListView_Clientes.SelectedItems.Count = 1 Then
                                                           Dim selectedItem As ListViewItem = ListView_Clientes.SelectedItems(0)
                                                           Dim ClienteSeleccionado As New Clientes(CInt(selectedItem.SubItems(0).Text),
                                                                                                      selectedItem.SubItems(1).Text,
                                                                                                      selectedItem.SubItems(2).Text,
                                                                                                      selectedItem.SubItems(3).Text)

                                                           ABM_Modificar_Cliente.ABM_Modificar_Clientes(ClienteSeleccionado)
                                                       ElseIf ListView_Clientes.SelectedItems.Count = 0 Then
                                                           MessageBox.Show("Selecciona un cliente para poder modificar")
                                                       Else
                                                           MessageBox.Show("Por favor, Seleccione una unica opcion")
                                                       End If
                                                   End Sub

        panel.Controls.Add(Button_ModificarClientes)
    End Sub
    Private Sub CargarPanel_Clientes(Panel_Clientes As Panel)
        ArmarPanel(Panel_Clientes)
        ArmardoFiltros_Clientes(Panel_Clientes)
        ArmadoListView_Clientes(Panel_Clientes)
        ArmadoBotones_Cliente(Panel_Clientes)
    End Sub
    Public Sub PoblarListView_Clientes()
        ListView_Clientes.Items.Clear()

        Dim ListaDeClientes As List(Of Clientes) = Clientes.ListaConFiltros_Clientes(TextBox_IdCliente,
                                                                                         TextBox_NombreCliente,
                                                                                         TextBox_TelefonoCliente,
                                                                                         TextBox_CorreoCliente)

        For Each cliente As Clientes In ListaDeClientes
            Dim item As New ListViewItem((cliente.ID).ToString())
            item.SubItems.Add(cliente.Cliente)
            item.SubItems.Add(cliente.Telefono)
            item.SubItems.Add(cliente.Correo)

            ListView_Clientes.Items.Add(item)
        Next
    End Sub

    '--------------------------- Panel Productos
    Dim Panel_Productos As New Panel

    Dim Label_IdProducto As New Label
    Dim Label_NombreProducto As New Label
    Dim Label_PrecioProducto As New Label
    Dim Label_CategoriaProducto As New Label

    Dim TextBox_IdProducto As New TextBox
    Dim TextBox_NombreProducto As New TextBox
    Dim TextBox_PrecioProducto As New TextBox
    Dim TextBox_CategoriaProducto As New TextBox

    Dim ListView_Productos As New ListView

    Dim Button_ModificarProductos As New Button
    Dim Button_BuscarProductos As New Button

    Private Sub ArmardoFiltros_Productos(Panel As Panel)
        '
        'Label_IdCliente
        '
        Label_IdProducto.AutoSize = True
        Label_IdProducto.Font = New System.Drawing.Font("Sylfaen", 12.0!)
        Label_IdProducto.Location = New System.Drawing.Point(21, 23)
        Label_IdProducto.Name = "Label_IdCliente"
        Label_IdProducto.Size = New System.Drawing.Size(131, 22)
        Label_IdProducto.TabIndex = 25
        Label_IdProducto.Text = "N° de producto"
        '
        'Label_NombreProducto
        '
        Label_NombreProducto.AutoSize = True
        Label_NombreProducto.Font = New System.Drawing.Font("Sylfaen", 12.0!)
        Label_NombreProducto.Location = New System.Drawing.Point(21, 58)
        Label_NombreProducto.Name = "Label_NombreCliente"
        Label_NombreProducto.Size = New System.Drawing.Size(64, 22)
        Label_NombreProducto.TabIndex = 26
        Label_NombreProducto.Text = "Nombre"
        '
        'Label_PrecioProducto
        '
        Label_PrecioProducto.AutoSize = True
        Label_PrecioProducto.Font = New System.Drawing.Font("Sylfaen", 12.0!)
        Label_PrecioProducto.Location = New System.Drawing.Point(347, 23)
        Label_PrecioProducto.Name = "Label_TelefonoCliente"
        Label_PrecioProducto.Size = New System.Drawing.Size(68, 22)
        Label_PrecioProducto.TabIndex = 27
        Label_PrecioProducto.Text = "Precio"
        '
        'Label_CategoriaProducto
        '
        Label_CategoriaProducto.AutoSize = True
        Label_CategoriaProducto.Font = New System.Drawing.Font("Sylfaen", 12.0!)
        Label_CategoriaProducto.Location = New System.Drawing.Point(347, 58)
        Label_CategoriaProducto.Name = "Label_CorreoCliente"
        Label_CategoriaProducto.Size = New System.Drawing.Size(55, 22)
        Label_CategoriaProducto.TabIndex = 28
        Label_CategoriaProducto.Text = "Categoria"
        '
        'TextBox_IdProducto
        '
        TextBox_IdProducto.Font = New System.Drawing.Font("Sylfaen", 12.0!)
        TextBox_IdProducto.Location = New System.Drawing.Point(175, 20)
        TextBox_IdProducto.Name = "TextBox_IdCliente"
        TextBox_IdProducto.Size = New System.Drawing.Size(148, 29)
        TextBox_IdProducto.TabIndex = 18
        AddHandler TextBox_IdProducto.KeyDown, Sub(sender As Object, e As KeyEventArgs)
                                                   If e.KeyCode = Keys.Enter Then
                                                       PoblarListView_Productos()
                                                       e.Handled = True
                                                       e.SuppressKeyPress = True
                                                   End If
                                               End Sub
        '
        'TextBox_NombreProducto
        '
        TextBox_NombreProducto.Font = New System.Drawing.Font("Sylfaen", 12.0!)
        TextBox_NombreProducto.Location = New System.Drawing.Point(175, 55)
        TextBox_NombreProducto.Name = "TextBox_NombreCliente"
        TextBox_NombreProducto.Size = New System.Drawing.Size(148, 29)
        TextBox_NombreProducto.TabIndex = 19
        AddHandler TextBox_NombreProducto.KeyDown, Sub(sender As Object, e As KeyEventArgs)
                                                       If e.KeyCode = Keys.Enter Then
                                                           PoblarListView_Productos()
                                                           e.Handled = True
                                                           e.SuppressKeyPress = True
                                                       End If
                                                   End Sub
        '
        'TextBox_PrecioProducto
        '
        TextBox_PrecioProducto.Font = New System.Drawing.Font("Sylfaen", 12.0!)
        TextBox_PrecioProducto.Location = New System.Drawing.Point(488, 20)
        TextBox_PrecioProducto.Name = "TextBox_TelefonoCliente"
        TextBox_PrecioProducto.Size = New System.Drawing.Size(148, 29)
        TextBox_PrecioProducto.TabIndex = 20
        AddHandler TextBox_PrecioProducto.KeyDown, Sub(sender As Object, e As KeyEventArgs)
                                                       If e.KeyCode = Keys.Enter Then
                                                           PoblarListView_Productos()
                                                           e.Handled = True
                                                           e.SuppressKeyPress = True
                                                       End If
                                                   End Sub
        '
        'TextBox_CategoriaProducto
        '
        TextBox_CategoriaProducto.Font = New System.Drawing.Font("Sylfaen", 12.0!)
        TextBox_CategoriaProducto.Location = New System.Drawing.Point(488, 55)
        TextBox_CategoriaProducto.Name = "TextBox_CorreoCliente"
        TextBox_CategoriaProducto.Size = New System.Drawing.Size(148, 29)
        TextBox_CategoriaProducto.TabIndex = 21
        AddHandler TextBox_CategoriaProducto.KeyDown, Sub(sender As Object, e As KeyEventArgs)
                                                          If e.KeyCode = Keys.Enter Then
                                                              PoblarListView_Productos()
                                                              e.Handled = True
                                                              e.SuppressKeyPress = True
                                                          End If
                                                      End Sub
        '
        'Button_Buscar
        '
        Button_BuscarProductos.Font = New System.Drawing.Font("Sylfaen", 12.0!)
        Button_BuscarProductos.Location = New System.Drawing.Point(651, 20)
        Button_BuscarProductos.Name = "Button_Buscar"
        Button_BuscarProductos.Size = New System.Drawing.Size(76, 64)
        Button_BuscarProductos.TabIndex = 22
        Button_BuscarProductos.Text = "Buscar"
        Button_BuscarProductos.UseVisualStyleBackColor = True
        AddHandler Button_BuscarProductos.Click, Sub()
                                                     PoblarListView_Productos()
                                                 End Sub

        Panel.Controls.Add(Label_IdProducto)
        Panel.Controls.Add(Label_NombreProducto)
        Panel.Controls.Add(Label_PrecioProducto)
        Panel.Controls.Add(Label_CategoriaProducto)

        Panel.Controls.Add(TextBox_IdProducto)
        Panel.Controls.Add(TextBox_NombreProducto)
        Panel.Controls.Add(TextBox_PrecioProducto)
        Panel.Controls.Add(TextBox_CategoriaProducto)
        Panel.Controls.Add(Button_BuscarProductos)
    End Sub
    Private Sub ArmadoListView_Productos(Panel As Panel)

        Dim Column_IdProducto As New ColumnHeader
        Dim Column_NombreProducto As New ColumnHeader
        Dim Column_PrecioProducto As New ColumnHeader
        Dim Column_CategoriaProducto As New ColumnHeader

        '
        'Column_IdProducto
        '
        Column_IdProducto.Text = "Producto N°"
        Column_IdProducto.Width = 89
        '
        'Column_NombreProducto
        '
        Column_NombreProducto.Text = "Nombre"
        Column_NombreProducto.Width = 213
        '
        'Column_PrecioProducto
        '
        Column_PrecioProducto.Text = "Precio"
        Column_PrecioProducto.Width = 151
        '
        'Column_CategoriaProducto
        '
        Column_CategoriaProducto.Text = "Categoria"
        Column_CategoriaProducto.Width = 228

        '
        'ListView_Productos
        '
        ListView_Productos.Columns.Clear()
        ListView_Productos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Column_IdProducto, Column_NombreProducto, Column_PrecioProducto, Column_CategoriaProducto})
        ListView_Productos.Font = New System.Drawing.Font("Sylfaen", 12.0!)
        ListView_Productos.FullRowSelect = True
        ListView_Productos.HideSelection = False
        ListView_Productos.Location = New System.Drawing.Point(10, 90)
        ListView_Productos.Name = "ListView_Clientes"
        ListView_Productos.Size = New System.Drawing.Size(716, 327)
        ListView_Productos.TabIndex = 24
        ListView_Productos.UseCompatibleStateImageBehavior = False
        ListView_Productos.View = System.Windows.Forms.View.Details

        Panel.Controls.Add(ListView_Productos)
    End Sub
    Private Sub ArmadoBotones_Productos(panel As Panel)
        '
        'Button_Modificar
        '
        Button_ModificarProductos.Font = New System.Drawing.Font("Sylfaen", 12.0!)
        Button_ModificarProductos.Location = New System.Drawing.Point(579, 437)
        Button_ModificarProductos.Name = "Button_ModificarProductos"
        Button_ModificarProductos.Size = New System.Drawing.Size(148, 39)
        Button_ModificarProductos.TabIndex = 23
        Button_ModificarProductos.Text = "Modificar Producto"
        Button_ModificarProductos.UseVisualStyleBackColor = True
        AddHandler Button_ModificarProductos.Click, Sub()
                                                        If ListView_Productos.SelectedItems.Count = 1 Then

                                                            Dim selectedItem As ListViewItem = ListView_Productos.SelectedItems(0)
                                                            Dim ProductoSeleccionado As New Productos(CInt(selectedItem.SubItems(0).Text),
                                                                                                      selectedItem.SubItems(1).Text,
                                                                                                      CDec(selectedItem.SubItems(2).Text),
                                                                                                      selectedItem.SubItems(3).Text)

                                                            ABM_Modificar_Productos.ABM_Modificar_Producto(ProductoSeleccionado)
                                                        ElseIf ListView_Productos.SelectedItems.Count = 0 Then
                                                            MessageBox.Show("Selecciona un producto para poder modificar")
                                                        Else
                                                            MessageBox.Show("Por favor, Seleccione una unica opcion")
                                                        End If
                                                    End Sub

        panel.Controls.Add(Button_ModificarProductos)
    End Sub
    Private Sub CargarPanel_Productos(Panel_Productos As Panel)
        ArmarPanel(Panel_Productos)
        ArmardoFiltros_Productos(Panel_Productos)
        ArmadoListView_Productos(Panel_Productos)
        ArmadoBotones_Productos(Panel_Productos)
    End Sub
    Public Sub PoblarListView_Productos()
        ListView_Productos.Items.Clear()

        Dim ListaDeProductos As List(Of Productos) = Productos.ListaConFiltros_Productos(TextBox_IdProducto,
                                                                                         TextBox_NombreProducto,
                                                                                         TextBox_PrecioProducto,
                                                                                         TextBox_CategoriaProducto)

        For Each Producto As Productos In ListaDeProductos
            Dim item As New ListViewItem((Producto.ID).ToString())
            item.SubItems.Add(Producto.Nombre)
            item.SubItems.Add(Format((Producto.Precio).ToString(), "Currency"))
            item.SubItems.Add(Producto.Categoria)

            ListView_Productos.Items.Add(item)
        Next
    End Sub

    '--------------------------- Comun

    Private Sub ArmarPanel(Panel As Panel)
        '
        'Panel
        '
        Panel.Location = New System.Drawing.Point(0, 24)
        Panel.Name = "Panel"
        Panel.Size = New System.Drawing.Size(738, 496)
        Panel.TabIndex = 3
        Panel.Visible = True

        Me.Controls.Add(Panel)
    End Sub
    Private Sub Buscador_Productos_Click(sender As Object, e As EventArgs) Handles Buscador_Productos.Click

        TextBox_IdCliente.Text = ""
        TextBox_NombreCliente.Text = ""
        TextBox_TelefonoCliente.Text = ""
        TextBox_CorreoCliente.Text = ""

        VaciarPanel(Panel_Clientes)
        CargarPanel_Productos(Panel_Productos)
        PoblarListView_Productos()
    End Sub
    Private Sub Buscador_Clientes_Click(sender As Object, e As EventArgs) Handles Buscador_Clientes.Click

        TextBox_IdProducto.Text = ""
        TextBox_NombreProducto.Text = ""
        TextBox_PrecioProducto.Text = ""
        TextBox_CategoriaProducto.Text = ""

        VaciarPanel(Panel_Productos)
        CargarPanel_Clientes(Panel_Clientes)
        PoblarListView_Clientes()
    End Sub
    Private Sub VaciarPanel(Panel As Panel)
        Panel.Controls.Clear()
        Panel.Visible = False
    End Sub



    'Private Sub Buscador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    leer_Productos("Select * From productos")
    'End Sub



    ''Sin filtro
    'Private Sub leer_Productos(query As String)
    '    Dim Conexion_pruebademo As String = ConfigurationManager.ConnectionStrings("pruebademo").ConnectionString

    '    Using Conexion As New SqlConnection(Conexion_pruebademo)
    '        Using Busc_Query As New SqlCommand(query, Conexion)
    '            Conexion.Open()
    '            Using reader As SqlDataReader = Busc_Query.ExecuteReader()

    '                While reader.Read()
    '                    Dim item As New ListViewItem(reader("Nombre").ToString())
    '                    item.SubItems.Add(reader("Precio").ToString())
    '                    item.SubItems.Add(reader("Categoria").ToString())

    '                    List_Productos.Items.Add(item)

    '                End While
    '            End Using
    '        End Using
    '    End Using
    'End Sub

    'Private Sub leer_Productos(query As String, filtro As String)
    '    Dim Conexion_pruebademo As String = ConfigurationManager.ConnectionStrings("pruebademo").ConnectionString

    '    Using Conexion As New SqlConnection(Conexion_pruebademo)
    '        Using Busc_Query As New SqlCommand(query, Conexion)
    '            Busc_Query.Parameters.AddWithValue("@termino", "%" & filtro & "%")
    '            Conexion.Open()
    '            Using reader As SqlDataReader = Busc_Query.ExecuteReader()

    '                While reader.Read()
    '                    Dim item As New ListViewItem(reader("Nombre").ToString())
    '                    item.SubItems.Add(reader("Precio").ToString())
    '                    item.SubItems.Add(reader("Categoria").ToString())

    '                    List_Productos.Items.Add(item)

    '                End While
    '            End Using
    '        End Using
    '    End Using
    'End Sub

    'Private Sub leer_clientes(query As String, filtro As String)
    '    Dim Conexion_pruebademo As String = ConfigurationManager.ConnectionStrings("pruebademo").ConnectionString

    '    Using Conexion As New SqlConnection(Conexion_pruebademo)
    '        Using Busc_Query As New SqlCommand(query, Conexion)
    '            Busc_Query.Parameters.AddWithValue("@termino", "%" & filtro & "%")
    '            Conexion.Open()
    '            Using reader As SqlDataReader = Busc_Query.ExecuteReader()

    '                While reader.Read()
    '                    Dim item As New ListViewItem(reader("ID").ToString())
    '                    item.SubItems.Add(reader("Cliente").ToString())
    '                    item.SubItems.Add(reader("Telefono").ToString())
    '                    item.SubItems.Add(reader("Correo").ToString())

    '                    List_Clientes.Items.Add(item) ' Cambiado de List_Productos a List_Clientes

    '                End While
    '            End Using
    '        End Using
    '    End Using
    'End Sub

    'Private Sub Button_Buscar_Click(sender As Object, e As EventArgs) Handles Button_Buscar.Click
    '    List_Productos.Items.Clear()
    '    Dim query As String = "SELECT * FROM Productos WHERE 1=1"
    '    Dim filtro As String = Text_Buscar.Text()
    '    Dim Atributo As String = Combo_Buscar.SelectedItem.ToString()

    '    If Atributo = "Nombre" Then
    '        query &= " AND Nombre LIKE @Termino"
    '    ElseIf Atributo = "Categoria" Then
    '        query &= " AND Categoria LIKE @Termino"
    '    Else
    '        query &= " AND (Nombre LIKE @Termino OR Categoria LIKE @Termino)"
    '    End If

    '    leer_Productos(query, filtro)

    'End Sub

    'Private Sub Button_Clientes_Buscar_Click(sender As Object, e As EventArgs) Handles Button_Clientes_Buscar.Click
    '    List_Clientes.Items.Clear()
    '    Dim query As String = "SELECT * FROM clientes WHERE 1=1"
    '    Dim filtro As String = Text_Clientes_Buscar.Text()
    '    Dim Atributo As String = Combo_Clientes_Buscar.SelectedItem.ToString()

    '    If Atributo = "Nombre" Then
    '        query &= " AND Cliente LIKE @Termino"
    '    ElseIf Atributo = "Telefono" Then
    '        query &= " AND Telefono LIKE @Termino"
    '    ElseIf Atributo = "Correo" Then
    '        query &= " AND Correo LIKE @Termino"
    '    Else
    '        query &= " AND (Cliente LIKE @Termino OR Telefono LIKE @Termino OR Correo LIKE @Termino)"
    '    End If

    '    leer_clientes(query, filtro)
    'End Sub

    'Private Sub ButtonModificar_Click(sender As Object, e As EventArgs) Handles ButtonModificar.Click
    '    If List_Clientes.SelectedItems.Count = 1 Then

    '        Dim selectedItem As ListViewItem = List_Clientes.SelectedItems(0)
    '        Dim cliente As New Clientes(selectedItem.SubItems(0).Text,
    '                                selectedItem.SubItems(1).Text,
    '                                selectedItem.SubItems(2).Text,
    '                                selectedItem.SubItems(3).Text)

    '        Buscador_Clientes.ABM_Modificar_Clientes(cliente)
    '    ElseIf List_Clientes.SelectedItems.Count = 0 Then
    '        MessageBox.Show("Selecciona un cliente para poder modificar")
    '    Else
    '        MessageBox.Show("Por favor, Seleccione una unica opcion")
    '    End If
    'End Sub

End Class