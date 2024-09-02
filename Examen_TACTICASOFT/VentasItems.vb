Imports System.Configuration
Imports System.Data.SqlClient

Public Class VentasItems
    Public Property ID_Venta As Integer
    Public Property ID_Producto As Integer
    Public Property PrecioUnitario As Decimal
    Public Property Cantidad As Decimal
    Public Property PrecioTotal As Decimal

    Public Sub New()
    End Sub

    Public Sub New(ID_Venta As Integer, ID_Producto As Integer, PrecioUnitario As Decimal, Cantidad As Decimal, PrecioTotal As Decimal)
        Me.ID_Venta = ID_Venta
        Me.ID_Producto = ID_Producto
        Me.PrecioUnitario = PrecioUnitario
        Me.Cantidad = Cantidad
        Me.PrecioTotal = PrecioTotal
    End Sub

    '----------- Lista de productos de una venta
    '--------------- Selecciona todos las ventas donde el ID de la venta sea igual a "IdVenta"
    '--------------- Los retorna en forma de "List(Of VentasItems)"

    Public Shared Function ListaDeProductosDeVenta(IdVenta As Integer)
        Dim Conexion_pruebademo As String = ConfigurationManager.ConnectionStrings("pruebademo").ConnectionString
        Dim query As String = "SELECT IDProducto, PrecioUnitario, Cantidad, PrecioTotal FROM VentasItems WHERE IDVenta = @IDVenta"
        Dim Lista As New List(Of VentasItems)

        Using Conexion As New SqlConnection(Conexion_pruebademo)
            Using Ejec_Query As New SqlCommand(query, Conexion)
                Conexion.Open()
                Ejec_Query.Parameters.AddWithValue("@IDVenta", IdVenta)
                Using reader As SqlDataReader = Ejec_Query.ExecuteReader()
                    While reader.Read()
                        Dim items As New VentasItems(IdVenta, reader(0), reader(1), reader(2), reader(3))
                        Lista.Add(items)
                    End While
                End Using
            End Using
        End Using

        Return Lista
    End Function

    '----------- Actualiza una venta
    '--------------- eliminar los productos de una venta para luego insertar 
    '--------------- los productos modificados de dicha venta

    Public Shared Sub ActualizarVentasItems(IdVenta As Integer, Lista As List(Of VentasItems))
        Dim Conexion_pruebademo As String = ConfigurationManager.ConnectionStrings("pruebademo").ConnectionString
        Dim query1 As String = "DELETE FROM ventasitems WHERE IDVenta = @IdVenta"
        Dim query2 As String = "INSERT INTO ventasitems (IDVenta, IDProducto, PrecioUnitario, Cantidad, PrecioTotal) VALUES (@IDVenta, @IDProducto, @PrecioUnitario, @Cantidad, @PrecioTotal)"

        Using Conexion As New SqlConnection(Conexion_pruebademo)
            Conexion.Open()

            Using Ejec_Query1 As New SqlCommand(query1, Conexion)
                Ejec_Query1.Parameters.AddWithValue("@IdVenta", IdVenta)
                Ejec_Query1.ExecuteNonQuery()
            End Using

            Using Ejec_Query2 As New SqlCommand(query2, Conexion)
                For Each Item As VentasItems In Lista
                    Ejec_Query2.Parameters.Clear()

                    Ejec_Query2.Parameters.AddWithValue("@IDVenta", Item.ID_Venta)
                    Ejec_Query2.Parameters.AddWithValue("@IDProducto", Item.ID_Producto)
                    Ejec_Query2.Parameters.AddWithValue("@PrecioUnitario", Item.PrecioUnitario)
                    Ejec_Query2.Parameters.AddWithValue("@Cantidad", Item.Cantidad)
                    Ejec_Query2.Parameters.AddWithValue("@PrecioTotal", Item.PrecioTotal)


                    Ejec_Query2.ExecuteNonQuery()
                Next
            End Using
        End Using
    End Sub

    '----------- Ingresa los productos de una venta
    '--------------- Inserta una lista de VentasItems en la tabla de ventasitems
    '--------------- 

    Public Shared Sub CrearVentasItems(Lista As List(Of VentasItems))
        Dim Conexion_pruebademo As String = ConfigurationManager.ConnectionStrings("pruebademo").ConnectionString
        Dim query As String = "INSERT INTO ventasitems (IDVenta, IDProducto, PrecioUnitario, Cantidad, PrecioTotal) VALUES (@IDVenta, @IDProducto, @PrecioUnitario, @Cantidad, @PrecioTotal)"

        Using Conexion As New SqlConnection(Conexion_pruebademo)
            Conexion.Open()

            Using Ejec_Query As New SqlCommand(query, Conexion)
                For Each Item As VentasItems In Lista
                    Ejec_Query.Parameters.Clear()

                    Ejec_Query.Parameters.AddWithValue("@IDVenta", Item.ID_Venta)
                    Ejec_Query.Parameters.AddWithValue("@IDProducto", Item.ID_Producto)
                    Ejec_Query.Parameters.AddWithValue("@PrecioUnitario", Item.PrecioUnitario)
                    Ejec_Query.Parameters.AddWithValue("@Cantidad", Item.Cantidad)
                    Ejec_Query.Parameters.AddWithValue("@PrecioTotal", Item.PrecioTotal)


                    Ejec_Query.ExecuteNonQuery()
                Next
            End Using
        End Using
    End Sub

    Public Shared Sub EliminarVentasItems(IdVenta As Integer)
        Dim Conexion_pruebademo As String = ConfigurationManager.ConnectionStrings("pruebademo").ConnectionString
        Dim query As String = "DELETE FROM ventasitems WHERE IDVenta = @IdVenta"

        Using Conexion As New SqlConnection(Conexion_pruebademo)
            Using Ejec_Query As New SqlCommand(query, Conexion)
                Ejec_Query.Parameters.AddWithValue("@IdVenta", IdVenta)

                Conexion.Open()
                Ejec_Query.ExecuteNonQuery()
            End Using
        End Using
    End Sub
End Class