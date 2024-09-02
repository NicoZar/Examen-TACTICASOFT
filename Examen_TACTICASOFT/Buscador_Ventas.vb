Imports System.Configuration
Imports System.Data.SqlClient

Public Class Buscador_Ventas
    Private Sub Buscador_Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        leer_ventas()
    End Sub

    Public Sub leer_ventas()
        Dim listaDeVentas As List(Of Ventas) = Ventas.Buscar_Ventas(TextBox_IdCliente, TextBox_FechaVenta, TextBox_TotalVenta, TextBox_IDVenta)
        Dim ListaDeClientes As List(Of Clientes) = Clientes.Lista_Clientes()
        ListView_Ventas.Items.Clear()

        For Each venta As Ventas In listaDeVentas
            Dim clienteEncontrado As Clientes = ListaDeClientes.Find(Function(buscar_cliente) buscar_cliente.ID = venta.ID_Cliente)
            Dim item As New ListViewItem((venta.ID_Cliente).ToString())
            item.SubItems.Add(clienteEncontrado.cliente)
            item.SubItems.Add((venta.Fecha).ToString())
            item.SubItems.Add((venta.ID).ToString())
            item.SubItems.Add(Format((venta.Total).ToString(), "Currency"))

            ListView_Ventas.Items.Add(item)
        Next

    End Sub

    '-----------------------------------------------------  Boton Buscar
    Private Sub Button_Buscar_Click(sender As Object, e As EventArgs) Handles Button_Buscar.Click
        leer_Ventas()
    End Sub

    '-----------------------------------------------------  Boton Modificar
    Private Sub Button_Modificar_Click(sender As Object, e As EventArgs) Handles Button_Modificar.Click
        If ListView_Ventas.SelectedItems.Count = 1 Then

            Dim selectedItem As ListViewItem = ListView_Ventas.SelectedItems(0)

            ABM_Modificar_Ventas.Modificar_Ventas(selectedItem.SubItems(3).Text)
        ElseIf ListView_Ventas.SelectedItems.Count = 0 Then
            MessageBox.Show("Selecciona una venta para poder modificar")
        Else
            MessageBox.Show("Por favor, Seleccione una unica opcion")
        End If
    End Sub

End Class