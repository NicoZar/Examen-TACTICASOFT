Imports System.Configuration
Imports System.Data.SqlClient

Public Class Productos
    Public Property ID As Integer
    Public Property Nombre As String
    Public Property Precio As Decimal
    Public Property Categoria As String

    Public Sub New(ID As Integer, Nombre As String, Precio As Decimal, Categoria As String)
        Me.ID = ID
        Me.Nombre = Nombre
        Me.Precio = Precio
        Me.Categoria = Categoria
    End Sub

    Public Sub New(Nombre As String, Precio As Decimal, Categoria As String)
        Me.Nombre = Nombre
        Me.Precio = Precio
        Me.Categoria = Categoria
    End Sub

    Public Sub New(Nombre As String)
        Me.Nombre = Nombre
        Me.Precio = 0
        Me.Categoria = ""
    End Sub

    Public Sub New()
        Me.Nombre = ""
        Me.Precio = 0
        Me.Categoria = ""
    End Sub

    '-----------------------------------------------------  Alta
    Public Sub CrearProductos()

        Dim query As String = "INSERT INTO productos (Nombre, Precio, Categoria) VALUES (@Nombre, @Precio, @Categoria)"
        Dim Conexion_pruebademo As String = ConfigurationManager.ConnectionStrings("pruebademo").ConnectionString

        Using Conexion As New SqlConnection(Conexion_pruebademo)
            Using ABM_Query As New SqlCommand(query, Conexion)

                'falta verificaciones de campos
                ABM_Query.Parameters.AddWithValue("@Nombre", Me.Nombre)
                ABM_Query.Parameters.AddWithValue("@Precio", Me.Precio)
                ABM_Query.Parameters.AddWithValue("@Categoria", Me.Categoria)

                Conexion.Open()
                Dim filasAfectadas As Integer = ABM_Query.ExecuteNonQuery()

                If filasAfectadas > 0 Then
                    Console.WriteLine("Producto agregado exitosamente.")
                Else
                    Console.WriteLine("No se pudo agregar el producto especificado.")
                End If
            End Using
        End Using
    End Sub

    '-----------------------------------------------------  Baja
    Public Shared Sub EliminarProductos(IdProducto As Integer)

        Dim query As String = "DELETE FROM productos WHERE ID = @IdProducto"
        Dim Conexion_pruebademo As String = ConfigurationManager.ConnectionStrings("pruebademo").ConnectionString

        Using Conexion As New SqlConnection(Conexion_pruebademo)
            Using ABM_Query As New SqlCommand(query, Conexion)

                ABM_Query.Parameters.AddWithValue("@IdProducto", IdProducto)

                Conexion.Open()
                Dim filasAfectadas As Integer = ABM_Query.ExecuteNonQuery()

                If filasAfectadas > 0 Then
                    Console.WriteLine("Producto eliminado exitosamente.")
                Else
                    Console.WriteLine("No se encontró ningún producto con el nombre especificado.")
                End If

            End Using
        End Using
    End Sub

    '-----------------------------------------------------  Modificar
    Public Sub ModificarProductos()

        Dim query As String = "UPDATE productos SET Nombre = @Nombre, Precio = @Precio, Categoria = @Categoria WHERE ID = @IdProducto"
        Dim Conexion_pruebademo As String = ConfigurationManager.ConnectionStrings("pruebademo").ConnectionString

        Using Conexion As New SqlConnection(Conexion_pruebademo)
            Using Ejec_Query As New SqlCommand(query, Conexion)

                Ejec_Query.Parameters.AddWithValue("@IdProducto", Me.ID)
                Ejec_Query.Parameters.AddWithValue("@Nombre", Me.Nombre)
                Ejec_Query.Parameters.AddWithValue("@Precio", Me.Precio)
                Ejec_Query.Parameters.AddWithValue("@Categoria", Me.Categoria)

                Conexion.Open()
                Dim filasAfectadas As Integer = Ejec_Query.ExecuteNonQuery()

                If filasAfectadas > 0 Then
                    Console.WriteLine("Producto modificado exitosamente.")
                Else
                    Console.WriteLine("No se pudo modificar el producto especificado.")
                End If
            End Using
        End Using
    End Sub

    '-----------------------------------------------------  Lista completa de productos disponibles
    Public Shared Function Lista_Productos()
        Dim Conexion_pruebademo As String = ConfigurationManager.ConnectionStrings("pruebademo").ConnectionString
        Dim query As String = "select p.ID, p.Nombre , p.Precio, p.Categoria from productos p"
        Dim lista As New List(Of Productos)
        Using Conexion As New SqlConnection(Conexion_pruebademo)
            Using Busc_Query As New SqlCommand(query, Conexion)
                Conexion.Open()
                Using reader As SqlDataReader = Busc_Query.ExecuteReader()
                    While reader.Read()
                        Dim producto As New Productos(reader(0), reader(1), reader(2), reader(3))
                        lista.Add(producto)
                    End While
                End Using
            End Using
        End Using

        Return lista

    End Function

    Public Shared Function ListaConFiltros_Productos(TextBox_IdProducto As TextBox,
                                                     TextBox_NombreProducto As TextBox,
                                                     TextBox_PrecioProducto As TextBox,
                                                     TextBox_CategoriaProducto As TextBox)
        Dim Conexion_pruebademo As String = ConfigurationManager.ConnectionStrings("pruebademo").ConnectionString
        Dim query As String = "SELECT p.ID, p.Nombre , p.Precio, p.Categoria FROM productos p WHERE 1=1 "

        If TextBox_IdProducto.Text <> "" Then
            query &= " AND p.ID LIKE @IdProducto "
        End If

        If TextBox_NombreProducto.Text <> "" Then
            query &= " AND p.Nombre LIKE @NombreProducto "
        End If

        If TextBox_PrecioProducto.Text <> "" Then
            query &= " AND p.Precio LIKE @PrecioProducto "
        End If

        If TextBox_CategoriaProducto.Text <> "" Then
            query &= " AND p.Categoria LIKE @CategoriaProducto "
        End If

        Dim ListaDeProductos As New List(Of Productos)
        Using Conexion As New SqlConnection(Conexion_pruebademo)
            Using Busc_Query As New SqlCommand(query, Conexion)
                Conexion.Open()

                If TextBox_IdProducto.Text <> "" Then
                    Busc_Query.Parameters.AddWithValue("@IdProducto", "%" & TextBox_IdProducto.Text & "%")
                End If

                If TextBox_NombreProducto.Text <> "" Then
                    Busc_Query.Parameters.AddWithValue("@NombreProducto", "%" & TextBox_NombreProducto.Text & "%")
                End If

                If TextBox_PrecioProducto.Text <> "" Then
                    Busc_Query.Parameters.AddWithValue("@PrecioProducto", "%" & TextBox_PrecioProducto.Text & "%")
                End If

                If TextBox_CategoriaProducto.Text <> "" Then
                    Busc_Query.Parameters.AddWithValue("@CategoriaProducto", "%" & TextBox_CategoriaProducto.Text & "%")
                End If

                Using reader As SqlDataReader = Busc_Query.ExecuteReader()
                    While reader.Read()
                        Dim producto As New Productos(reader(0), reader(1), reader(2), reader(3))
                        ListaDeProductos.Add(producto)
                    End While
                End Using
            End Using
        End Using

        Return ListaDeProductos

    End Function

End Class
