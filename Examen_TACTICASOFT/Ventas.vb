Imports System.Configuration
Imports System.Data.SqlClient

Public Class Ventas
    Public Property ID As Integer
    Public Property ID_Cliente As Integer
    Public Property Fecha As Date
    Public Property Total As Decimal

    Public Sub New(ID As Integer, ID_Cliente As Integer, Fecha As Date, Total As Decimal)
        Me.ID = ID
        Me.ID_Cliente = ID_Cliente
        Me.Fecha = Fecha
        Me.Total = Total
    End Sub

    Public Sub New(ID_Cliente As Integer, Fecha As Date, Total As Decimal)
        Me.ID_Cliente = ID_Cliente
        Me.Fecha = Fecha
        Me.Total = Total
    End Sub

    Public Shared Sub ActualizarVenta(IdVenta As Integer, Total As Decimal)
        Dim Conexion_pruebademo As String = ConfigurationManager.ConnectionStrings("pruebademo").ConnectionString
        Dim query As String = "UPDATE ventas SET Total = @Total WHERE ID = @IdVenta"

        Using Conexion As New SqlConnection(Conexion_pruebademo)
            Using Ejec_Query As New SqlCommand(query, Conexion)
                Ejec_Query.Parameters.AddWithValue("@IdVenta", IdVenta)
                Ejec_Query.Parameters.AddWithValue("@Total", Total)

                Conexion.Open()
                Ejec_Query.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Shared Function CrearVenta(Venta As Ventas)
        Dim Conexion_pruebademo As String = ConfigurationManager.ConnectionStrings("pruebademo").ConnectionString
        Dim query1 As String = "INSERT INTO ventas (IDCliente, Fecha, Total) OUTPUT INSERTED.ID VALUES (@IDCliente, @Fecha, @Total)"
        Dim ID_Ventas As Integer

        Using Conexion As New SqlConnection(Conexion_pruebademo)
            Conexion.Open()

            Using Ejec_Query As New SqlCommand(query1, Conexion)

                Ejec_Query.Parameters.AddWithValue("@IDCliente", Venta.ID_Cliente)
                Ejec_Query.Parameters.AddWithValue("@Fecha", Venta.Fecha)
                Ejec_Query.Parameters.AddWithValue("@Total", Venta.Total)
                ID_Ventas = CInt(Ejec_Query.ExecuteScalar())
            End Using
        End Using

        Return ID_Ventas
    End Function

    Public Shared Sub EliminarVenta(IdVenta As Integer)
        Dim Conexion_pruebademo As String = ConfigurationManager.ConnectionStrings("pruebademo").ConnectionString
        Dim query As String = "DELETE FROM ventas WHERE ID = @IdVenta"

        Using Conexion As New SqlConnection(Conexion_pruebademo)
            Using Ejec_Query As New SqlCommand(query, Conexion)
                Ejec_Query.Parameters.AddWithValue("@IdVenta", IdVenta)

                Conexion.Open()
                Ejec_Query.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    '-----------------------------------------------------  Buscador de ventas aplicando filtros
    Public Shared Function Buscar_Ventas(TextBox_IDCliente As TextBox,
                                  TextBox_FechaVenta As TextBox,
                                  TextBox_TotalVenta As TextBox,
                                  TextBox_IDVenta As TextBox)

        Dim ListaVentas As New List(Of Ventas)
        Dim Conexion_pruebademo As String = ConfigurationManager.ConnectionStrings("pruebademo").ConnectionString
        Dim query As String = " SELECT ID, IDCliente, fecha, Total FROM ventas WHERE 1=1 "

        If TextBox_IDCliente.Text <> "" Then
            query &= " AND IDCliente LIKE @IDCliente "
            'condiciones.Add(TextBox_NombreCliente.Text())
        End If

        If TextBox_FechaVenta.Text <> "" Then
            query &= " AND fecha LIKE @FechaVenta "
            'condiciones.Add(TextBox_FechaVenta.Text())
        End If

        If TextBox_TotalVenta.Text <> "" Then
            query &= " AND Total LIKE @TotalVenta "
            'condiciones.Add(TextBox_TotalVenta.Text())
        End If

        If TextBox_IDVenta.Text <> "" Then
            query &= " AND ID LIKE @IDVenta "
            'condiciones.Add(TextBox_IDVenta.Text())
        End If

        query &= " GROUP BY IDCliente, fecha, ID, Total"

        Using Conexion As New SqlConnection(Conexion_pruebademo)
            Using Busc_Query As New SqlCommand(query, Conexion)
                Conexion.Open()

                If TextBox_IDCliente.Text <> "" Then
                    Dim filtro_IDCliente As String = "%" & TextBox_IDCliente.Text() & "%"
                    Busc_Query.Parameters.AddWithValue("@IDCliente", filtro_IDCliente)
                End If

                If TextBox_FechaVenta.Text <> "" Then
                    Dim filtro_FechaVenta As String = "%" & TextBox_FechaVenta.Text() & "%"
                    Busc_Query.Parameters.AddWithValue("@FechaVenta", filtro_FechaVenta)
                End If

                If TextBox_TotalVenta.Text <> "" Then
                    Dim filtro_TotalVenta As String = "%" & TextBox_TotalVenta.Text() & "%"
                    Busc_Query.Parameters.AddWithValue("@TotalVenta", filtro_TotalVenta)
                End If

                If TextBox_IDVenta.Text <> "" Then
                    Dim filtro_IDVenta As String = "%" & TextBox_IDVenta.Text() & "%"
                    Busc_Query.Parameters.AddWithValue("@IDVenta", filtro_IDVenta)
                End If

                Using reader As SqlDataReader = Busc_Query.ExecuteReader()

                    While reader.Read()
                        Dim Venta As New Ventas(reader(0), reader(1), reader(2), reader(3))
                        ListaVentas.Add(Venta)
                    End While
                End Using
            End Using
        End Using

        Return ListaVentas
    End Function

    Public Shared Function Buscar_Ventas()

        Dim ListaVentas As New List(Of Ventas)
        Dim Conexion_pruebademo As String = ConfigurationManager.ConnectionStrings("pruebademo").ConnectionString
        Dim query As String = " SELECT ID, IDCliente, fecha, Total FROM ventas WHERE 1=1 "

        Using Conexion As New SqlConnection(Conexion_pruebademo)
            Using Busc_Query As New SqlCommand(query, Conexion)
                Conexion.Open()
                Using reader As SqlDataReader = Busc_Query.ExecuteReader()
                    While reader.Read()
                        Dim Venta As New Ventas(reader(0), reader(1), reader(2), reader(3))
                        ListaVentas.Add(Venta)
                    End While
                End Using
            End Using
        End Using

        Return ListaVentas
    End Function

    Public Shared Function Buscar_Ventas_De_Cliente(IdCliente As Integer)

        Dim ListaVentas As New List(Of Ventas)
        Dim Conexion_pruebademo As String = ConfigurationManager.ConnectionStrings("pruebademo").ConnectionString
        Dim query As String = " SELECT ID, IDCliente, fecha, Total FROM ventas WHERE IDCliente = @IDCliente"

        Using Conexion As New SqlConnection(Conexion_pruebademo)
            Using Ejec_Query As New SqlCommand(query, Conexion)
                Conexion.Open()
                Ejec_Query.Parameters.AddWithValue("@IDCliente", IdCliente)

                Using reader As SqlDataReader = Ejec_Query.ExecuteReader()
                    While reader.Read()
                        Dim Venta As New Ventas(reader(0), reader(1), reader(2), reader(3))
                        ListaVentas.Add(Venta)
                    End While
                End Using
            End Using
        End Using

        Return ListaVentas
    End Function

End Class
