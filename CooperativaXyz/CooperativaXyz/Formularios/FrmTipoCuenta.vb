Imports System.Data.SqlClient
Public Class FrmTipoCuenta
    Private Sub HabilitarBotones(ByVal Nuevo As Boolean, ByVal Guardar As Boolean, ByVal Modificar As Boolean, ByVal Cancelar As Boolean)
        BtnNuevo.Enabled = Nuevo
        BtnGuardar.Enabled = Guardar
        BtnModificar.Enabled = Modificar
        BtnCancelar.Enabled = Cancelar

    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        HabilitarBotones(False, True, False, True)
        InvestigarCorrelativoTipoCuenta()
    End Sub
    Private Sub Limpiar()
        TxtTipoCuenta.Clear()
        TxtIdTipoCuenta.Clear()
    End Sub
    Public Sub InvestigarCorrelativoTipoCuenta()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If


        Try
            Dim ListaTipoCuenta As New SqlCommand("Sp_InvestigarCorrelativoTipoCuenta", Cn)
            ListaTipoCuenta.CommandType = CommandType.StoredProcedure

            Dim ListarTipoCuenta1 As SqlDataReader
            Cn.Open()

            ListarTipoCuenta1 = ListaTipoCuenta.ExecuteReader
            If ListarTipoCuenta1.Read = True Then
                If ListarTipoCuenta1("IdTipoCuenta") Is DBNull.Value Then
                    TxtIdTipoCuenta.Text = 1

                Else
                    TxtIdTipoCuenta.Text = ListarTipoCuenta1("IdTipoCuenta").ToString

                End If

            End If

        Catch ex As Exception
            MessageBox.Show("Error de conexión a la base de datos" + ex.Message, "CooperativaXYZ", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            Cn.Close()
        End Try

    End Sub
    Private Sub MostrarTodo()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Using CMd As New SqlCommand
            Cn.Open()


            Try
                With CMd
                    .CommandText = "Sp_MostrarTipoCuenta"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                End With
                Dim VerTipoCuenta As SqlDataReader
                VerTipoCuenta = CMd.ExecuteReader()

                LsvTipoCuenta.Items.Clear()
                While VerTipoCuenta.Read = True
                    With LsvTipoCuenta.Items.Add(VerTipoCuenta("IdTipoCuenta").ToString)
                        .SubItems.Add(VerTipoCuenta("TipoCuenta").ToString)

                    End With

                End While

            Catch ex As Exception
                MessageBox.Show("Error al consultar los datos." + ex.Message, "CooperativaXYZ", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Finally
                Cn.Close()
            End Try
        End Using

    End Sub
    Private Sub GuardarTipoCuenta()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_InsertarTipoCuenta"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    .Parameters.Add("@TipoCuenta", SqlDbType.NVarChar, 20).Value = TxtTipoCuenta.Text
                    .ExecuteNonQuery()

                    MessageBox.Show("Registro realizado satisfactoriamente.", "CooperativaXYZ", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End With
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al insertar el Tipo Cuenta.", "CooperativaXYZ", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            Cn.Close()
        End Try

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If ValidarTextBox() = True Then
            GuardarTipoCuenta()
            MostrarTodo()
            Limpiar()
            HabilitarBotones(True, False, False, False)
        End If

    End Sub

    Private Sub FrmTipoCuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarTodo()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        HabilitarBotones(True, False, False, False)
        Limpiar()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Close()
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        TxtIdTipoCuenta.Text = LsvTipoCuenta.FocusedItem.SubItems(0).Text
        TxtTipoCuenta.Text = LsvTipoCuenta.FocusedItem.SubItems(1).Text

        TcTipoCuenta.SelectedIndex = 0
        HabilitarBotones(False, False, True, True)


    End Sub
    Private Sub BuscarTipoCuentaX()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Using CMd As New SqlCommand
            Cn.Open()

            Try
                With CMd
                    .CommandText = "Sp_MostrarTipoCuentaX"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    .Parameters.Add("@Busqueda", SqlDbType.NVarChar, 50).Value = TxtBuscar.Text

                End With

                Dim VerTipoCuentas As SqlDataReader
                VerTipoCuentas = CMd.ExecuteReader

                LsvTipoCuenta.Items.Clear()
                While VerTipoCuentas.Read = True
                    With LsvTipoCuenta.Items.Add(VerTipoCuentas("IdTipoCuenta").ToString)
                        .SubItems.Add(VerTipoCuentas("TipoCuenta").ToString)

                    End With
                End While

            Catch ex As Exception

                MessageBox.Show("Error al mostrar Tipos de cuenta" + ex.Message, "CooperativaXYZ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Cn.Close()

            End Try
        End Using
    End Sub
    Private Sub ActualizarTipoCuenta()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_ActualizarTipoCuenta"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    .Parameters.Add("@IdTipoCuenta", SqlDbType.Int).Value = CInt(TxtIdTipoCuenta.Text)
                    .Parameters.Add("@TipoCuenta", SqlDbType.NVarChar, 20).Value = TxtTipoCuenta.Text
                    .ExecuteNonQuery()

                    MessageBox.Show("Registro actualizado satisfactoriamente.", "CooperativaXYZ", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End With
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al actualizar el Tipo Cuenta.", "CooperativaXYZ", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            Cn.Close()
        End Try

    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        ActualizarTipoCuenta()
        MostrarTodo()
        Limpiar()
        HabilitarBotones(True, False, False, False)
    End Sub
    Private Sub EliminarTipoPrestamo()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_EliminarTipoCuenta"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    Dim Id As Integer
                    Id = CInt(LsvTipoCuenta.FocusedItem.SubItems(0).Text)

                    .Parameters.Add("@IdTipoCuenta", SqlDbType.Int).Value = Id
                    .ExecuteNonQuery()

                    MessageBox.Show("Registro eliminado satisfactoriamente.", "CooperativaXYZ", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End With
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al eliminar el Tipo Cuenta.", "CooperativaXYZ", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            Cn.Close()
        End Try


    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        EliminarTipoPrestamo()
        MostrarTodo()
    End Sub

    Private Function ValidarTextBox() As Boolean
        Dim Estado As Boolean
        If TxtTipoCuenta.Text = Nothing Then
            EpMensaje.SetError(TxtTipoCuenta, "Debe ingresar un tipo de cuenta")
            Estado = False
        Else
            EpMensaje.SetError(TxtTipoCuenta, "")
            Estado = True
        End If
        Return Estado
    End Function

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged
        BuscarTipoCuentaX()
    End Sub
End Class