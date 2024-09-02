Imports System.Configuration
Imports System.Data.SqlClient

Public Class Clientes
    Public Property ID As Integer
    Public Property Cliente As String
    Public Property Telefono As String
    Public Property Correo As String

    Public Sub New(ID As Integer, nombre As String, Telefono As String, Correo As String)
        Me.ID = ID
        cliente = nombre
        Me.Telefono = Telefono
        Me.Correo = Correo
    End Sub

    Public Sub New(nombre As String, Telefono As String, Correo As String)
        Me.Cliente = nombre
        Me.Telefono = Telefono
        Me.Correo = Correo
    End Sub

    Public Sub New(nombre As String)
        Me.Cliente = nombre
        Me.Telefono = ""
        Me.Correo = ""
    End Sub

    Public Sub New()
        Me.Cliente = ""
        Me.Telefono = ""
        Me.Correo = ""
    End Sub
    '----------- 
    '--------------- 
    '--------------- 

    Public Sub CrearCliente()
        Dim query As String = "INSERT INTO Clientes (Cliente, Telefono, Correo) VALUES (@Nombre, @Telefono, @Correo)"
        Dim Conexion_pruebademo As String = ConfigurationManager.ConnectionStrings("pruebademo").ConnectionString

        Using Conexion As New SqlConnection(Conexion_pruebademo)
            Using ABM_Query As New SqlCommand(query, Conexion)

                'falta verificaciones de campos
                ABM_Query.Parameters.AddWithValue("@Nombre", Me.cliente)
                ABM_Query.Parameters.AddWithValue("@Telefono", Me.Telefono)
                ABM_Query.Parameters.AddWithValue("@Correo", Me.Correo)

                Conexion.Open()
                Dim filasAfectadas As Integer = ABM_Query.ExecuteNonQuery()

                If filasAfectadas > 0 Then
                    Console.WriteLine("Cliente agregado exitosamente.")
                Else
                    Console.WriteLine("No se pudo agregar el cliente especificado.")
                End If

            End Using
        End Using
    End Sub

    '----------- 
    '--------------- 
    '--------------- 

    Public Shared Sub EliminarCliente(IdCliente As Integer)

        Dim query As String = "DELETE FROM clientes WHERE ID = @IdCliente"
        Dim Conexion_pruebademo As String = ConfigurationManager.ConnectionStrings("pruebademo").ConnectionString

        Using Conexion As New SqlConnection(Conexion_pruebademo)
            Using QueryEjec As New SqlCommand(query, Conexion)

                QueryEjec.Parameters.AddWithValue("@IdCliente", IdCliente)

                Conexion.Open()
                Dim filasAfectadas As Integer = QueryEjec.ExecuteNonQuery()

                If filasAfectadas > 0 Then
                    Console.WriteLine("Cliente eliminado exitosamente.")
                Else
                    Console.WriteLine("No se pudo realizar la baja del cliente.")
                End If

            End Using
        End Using
    End Sub

    '----------- 
    '--------------- 
    '--------------- 

    Public Sub ModificarCliente()

        Dim query As String = "UPDATE Clientes SET cliente = @Nombre, Telefono = @Telefono, Correo = @Correo WHERE ID = @IdCliente"
        Dim Conexion_pruebademo As String = ConfigurationManager.ConnectionStrings("pruebademo").ConnectionString

        Using Conexion As New SqlConnection(Conexion_pruebademo)
            Using Ejec_Query As New SqlCommand(query, Conexion)

                Ejec_Query.Parameters.AddWithValue("@IdCliente", Me.ID)
                Ejec_Query.Parameters.AddWithValue("@Nombre", Me.Cliente)
                Ejec_Query.Parameters.AddWithValue("@Telefono", Me.Telefono)
                Ejec_Query.Parameters.AddWithValue("@Correo", Me.Correo)

                Conexion.Open()
                Dim filasAfectadas As Integer = Ejec_Query.ExecuteNonQuery()

                If filasAfectadas > 0 Then
                    Console.WriteLine("Cliente modificado exitosamente.")
                Else
                    Console.WriteLine("No se pudo modificar el cliente especificado.")
                End If
            End Using
        End Using
    End Sub

    '----------- 
    '--------------- 
    '--------------- 

    Public Shared Function Lista_Clientes()
        Dim Conexion_pruebademo As String = ConfigurationManager.ConnectionStrings("pruebademo").ConnectionString
        Dim query As String = "select ID, Cliente , Telefono, Correo from clientes"
        Dim lista As New List(Of Clientes)
        Using Conexion As New SqlConnection(Conexion_pruebademo)
            Using Busc_Query As New SqlCommand(query, Conexion)
                Conexion.Open()
                Using reader As SqlDataReader = Busc_Query.ExecuteReader()
                    While reader.Read()
                        Dim Client As New Clientes(reader(0), reader(1), reader(2), reader(3))
                        lista.Add(Client)
                    End While
                End Using
            End Using
        End Using

        Return lista

    End Function

    Public Shared Function ListaConFiltros_Clientes(TextBox_IdCliente As TextBox,
                                                     TextBox_NombreCliente As TextBox,
                                                     TextBox_TelefonoCliente As TextBox,
                                                     TextBox_CorreoCliente As TextBox)
        Dim Conexion_pruebademo As String = ConfigurationManager.ConnectionStrings("pruebademo").ConnectionString
        Dim query As String = "SELECT c.ID, c.Cliente , c.Telefono, c.Correo FROM clientes c WHERE 1=1 "

        If TextBox_IdCliente.Text <> "" Then
            query &= " AND p.ID LIKE @IdCliente "
        End If

        If TextBox_NombreCliente.Text <> "" Then
            query &= " AND p.Cliente LIKE @NombreCliente "
        End If

        If TextBox_TelefonoCliente.Text <> "" Then
            query &= " AND p.Telefono LIKE @TelefonoCliente "
        End If

        If TextBox_CorreoCliente.Text <> "" Then
            query &= " AND p.Correo LIKE @CorreoCliente "
        End If

        Dim ListaDeClientes As New List(Of Clientes)
        Using Conexion As New SqlConnection(Conexion_pruebademo)
            Using Busc_Query As New SqlCommand(query, Conexion)
                Conexion.Open()

                If TextBox_IdCliente.Text <> "" Then
                    Busc_Query.Parameters.AddWithValue("@IdCliente", "%" & TextBox_IdCliente.Text & "%")
                End If

                If TextBox_NombreCliente.Text <> "" Then
                    Busc_Query.Parameters.AddWithValue("@NombreCliente", "%" & TextBox_NombreCliente.Text & "%")
                End If

                If TextBox_TelefonoCliente.Text <> "" Then
                    Busc_Query.Parameters.AddWithValue("@TelefonoCliente", "%" & TextBox_TelefonoCliente.Text & "%")
                End If

                If TextBox_CorreoCliente.Text <> "" Then
                    Busc_Query.Parameters.AddWithValue("@CorreoCliente", "%" & TextBox_CorreoCliente.Text & "%")
                End If

                Using reader As SqlDataReader = Busc_Query.ExecuteReader()
                    While reader.Read()
                        Dim cliente As New Clientes(reader(0), reader(1), reader(2), reader(3))
                        ListaDeClientes.Add(Cliente)
                    End While
                End Using
            End Using
        End Using

        Return ListaDeClientes

    End Function
End Class
