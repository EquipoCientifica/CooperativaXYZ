Imports System.Data.SqlClient

Public Class FrmTipoPrestamo

    Private Sub HabilitarBotones(ByVal Nuevo As Boolean, ByVal Guardar As Boolean, ByVal Modificar As Boolean, ByVal Cancelar As Boolean)
        BtnNuevo.Enabled = Nuevo
        BtnGuardar.Enabled = Guardar
        BtnModificar.Enabled = Modificar
        BtnCancelar.Enabled = Cancelar

    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        HabilitarBotones(False, True, False, True)
        InvestigarCorrelativoTipoPrestamo()
        TxtTipoPrestamo.Focus()
    End Sub

    Public Sub InvestigarCorrelativoTipoPrestamo()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If


        Try
            Dim ListaTipoPrestamo As New SqlCommand("Sp_InvestigarCorrelativoTipoPrestamo", Cn)
            ListaTipoPrestamo.CommandType = CommandType.StoredProcedure

            Dim ListarTipoPrestamo As SqlDataReader
            Cn.Open()

            ListarTipoPrestamo = ListaTipoPrestamo.ExecuteReader
            If ListarTipoPrestamo.Read = True Then
                If ListarTipoPrestamo("IdTipoPrestamo") Is DBNull.Value Then
                    TxtCodTipoPrestamo.Text = 1

                Else
                    TxtCodTipoPrestamo.Text = ListarTipoPrestamo("IdTipoPrestamo").ToString

                End If

            End If

        Catch ex As Exception
            MessageBox.Show("Error de conexión a la base de datos" + ex.Message, "CooperativaXYZ", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            Cn.Close()
        End Try

    End Sub

    ' Guardar
    Private Sub GuardarTipoPrestamo()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_InsertarTipoPrestamo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    ' Enviar el parámetro del nombre del Género musical
                    .Parameters.Add("@TipoPrestamo", SqlDbType.NVarChar, 30).Value = TxtTipoPrestamo.Text
                    .ExecuteNonQuery()

                    MessageBox.Show("Registro realizado satisfactoriamente.", "CooperativaXYZ", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End With
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al insertar el Tipo Préstamo.", "CooperativaXYZ", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            Cn.Close()
        End Try

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If ValidarTextBox() = True Then
            GuardarTipoPrestamo()
            HabilitarBotones(True, False, False, False)
            Limpiar()
            MostrarTodo()

        End If
    End Sub


    Private Function ValidarTextBox()
        Dim Estado As Boolean
        If TxtTipoPrestamo.Text = Nothing Then
            EpMensaje.SetError(TxtTipoPrestamo, "Ingrese el Tipo Préstamo")
            Estado = False
            TxtTipoPrestamo.Focus()

        Else
            Estado = True
        End If

        Return Estado
    End Function

    Private Sub Limpiar()
        TxtCodTipoPrestamo.Text = Nothing
        TxtTipoPrestamo.Text = Nothing
    End Sub


    Private Sub MostrarTodo()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Using CMd As New SqlCommand
            Cn.Open()


            Try
                With CMd
                    .CommandText = "Sp_MostrarTipoPrestamo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                End With
                Dim VerTipoPrestamo As SqlDataReader
                VerTipoPrestamo = CMd.ExecuteReader()

                LsvTipoPrestamo.Items.Clear()
                While VerTipoPrestamo.Read = True
                    With LsvTipoPrestamo.Items.Add(VerTipoPrestamo("IdTipoPrestamo").ToString)
                        .SubItems.Add(VerTipoPrestamo("TipoPrestamo").ToString)

                    End With

                End While

            Catch ex As Exception
                MessageBox.Show("Error al consultar los datos." + ex.Message, "CooperativaXYZ", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Finally
                Cn.Close()
            End Try
        End Using

    End Sub


    'Actualizar

    Private Sub ActualizarTipoPrestamo()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_ActualizarTipoPrestamo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    ' Enviar el parámetro del nombre del Género musical
                    .Parameters.Add("@IdTipoPrestamo", SqlDbType.Int).Value = CInt(TxtCodTipoPrestamo.Text)
                    .Parameters.Add("@TipoPrestamo", SqlDbType.NVarChar, 30).Value = TxtTipoPrestamo.Text
                    .ExecuteNonQuery()

                    MessageBox.Show("Registro actualizado satisfactoriamente.", "CooperativaXYZ", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End With
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al actualizar el Tipo Préstamo.", "CooperativaXYZ", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            Cn.Close()
        End Try

    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        If ValidarTextBox() = True Then
            HabilitarBotones(True, False, False, True)
            ActualizarTipoPrestamo()
            Limpiar()
            MostrarTodo()
        End If
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Close()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        HabilitarBotones(True, False, False, False)
        Limpiar()
    End Sub

    'Eliminar

    Private Sub EliminarTipoPrestamo()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_EliminarTipoPrestamo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    ' Enviar el parámetro del nombre de ciudad
                    Dim Id As Integer
                    Id = CInt(LsvTipoPrestamo.FocusedItem.SubItems(0).Text)

                    .Parameters.Add("@IdTipoPrestamo", SqlDbType.Int).Value = Id
                    .ExecuteNonQuery()

                    MessageBox.Show("Registro eliminado satisfactoriamente.", "CooperativaXYZ", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End With
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al eliminar el Tipo Préstamo.", "CooperativaXYZ", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            Cn.Close()
        End Try


    End Sub


    Private Sub BuscarPorTipoPrestamo()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Using CMd As New SqlCommand
            Cn.Open()


            Try
                With CMd
                    .CommandText = "Sp_BuscarPorTipoPrestamo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    .Parameters.Add("@TipoPrestamo", SqlDbType.NVarChar, 30).Value = TxtBuscarTipoPrestamo.Text


                End With
                Dim VerTipoPrestamo As SqlDataReader
                VerTipoPrestamo = CMd.ExecuteReader()

                LsvTipoPrestamo.Items.Clear()
                While VerTipoPrestamo.Read = True
                    With LsvTipoPrestamo.Items.Add(VerTipoPrestamo("IdTipoPrestamo").ToString)
                        .SubItems.Add(VerTipoPrestamo("TipoPrestamo").ToString)

                    End With

                End While

            Catch ex As Exception
                MessageBox.Show("Error al consultar los datos." + ex.Message, "CooperativaXYZ", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Finally
                Cn.Close()
            End Try
        End Using
    End Sub




    Private Sub EliminarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem1.Click
        EliminarTipoPrestamo()
        MostrarTodo()
        HabilitarBotones(True, False, False, False)
    End Sub

    Private Sub TxtBuscarTipoPrestamo_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscarTipoPrestamo.TextChanged
        BuscarPorTipoPrestamo()
    End Sub

    Private Sub FrmTipoPrestamo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarTodo()
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        TxtCodTipoPrestamo.Text = LsvTipoPrestamo.FocusedItem.SubItems(0).Text
        TxtTipoPrestamo.Text = LsvTipoPrestamo.FocusedItem.SubItems(1).Text

        TcTipoPrestamo.SelectedIndex = 0
        TxtTipoPrestamo.Focus()

        HabilitarBotones(False, False, True, True)
    End Sub
End Class