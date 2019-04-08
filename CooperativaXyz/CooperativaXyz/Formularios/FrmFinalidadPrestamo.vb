Imports System.Data.SqlClient
Public Class FrmFinalidadPrestamo
    Private Sub HabilitarBotones(ByVal Nuevo As Boolean,
                              ByVal Guardar As Boolean,
                              ByVal Modificar As Boolean,
                              ByVal Cancelar As Boolean)
        BtnNuevo.Enabled = Nuevo
        BtnGuardar.Enabled = Guardar
        BtnModificar.Enabled = Modificar
        BtnCancelar.Enabled = Cancelar
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        HabilitarBotones(False, True, False, True)
        InvestigarCorrelativoFinalidadPrestamo()
    End Sub
    Private Sub Limpiar()
        TxtCodFinalidad.Clear()
        TxtFinalidad.Clear()
    End Sub
    Private Sub MostrarTodo()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Using CMd As New SqlCommand
            Cn.Open()
            Try
                With CMd
                    .CommandText = "Sp_MostrarFinalidadPrestamo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn
                End With

                Dim verFinalidadPrestamo As SqlDataReader
                verFinalidadPrestamo = CMd.ExecuteReader()

                LsvFinalidades.Items.Clear()
                While verFinalidadPrestamo.Read = True
                    With LsvFinalidades.Items.Add(verFinalidadPrestamo("IdFinalidadPrestamo").ToString)
                        .SubItems.Add(verFinalidadPrestamo("Finalidad").ToString)
                    End With
                End While
            Catch ex As Exception
                MessageBox.Show("Error al Mostrar la finalidad del prestamo" + ex.Message, "CooperativaXyz", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Cn.Close()
            End Try
        End Using
    End Sub

    Private Sub FrmFinalidadPrestamo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarTodo()
    End Sub
    Private Sub InvestigarCorrelativoFinalidadPrestamo()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Dim ListarGenero As New SqlCommand("Sp_InvestigarCorrelativoFinalidadPrestamo", Cn)
            ListarGenero.CommandType = CommandType.StoredProcedure

            Dim ListarGeneroR As SqlDataReader
            Cn.Open()
            ListarGeneroR = ListarGenero.ExecuteReader()

            If ListarGeneroR.Read = True Then
                If ListarGeneroR("IdFinalidadPrestamo") Is DBNull.Value Then
                    TxtCodFinalidad.Text = 1
                Else
                    TxtCodFinalidad.Text = ListarGeneroR("IdFinalidadPrestamo").ToString
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error al Consultar los Datos en investigar correlativo" + ex.Message, "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            Cn.Close()
        End Try
    End Sub
    Private Sub GuardarFinalidadPrestamo()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_InsertarFinalidadPrestamo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn


                    .Parameters.Add("@Finalidad", SqlDbType.NVarChar, 50).Value = TxtFinalidad.Text
                    .ExecuteNonQuery()

                    MessageBox.Show("Registro realizado Satisfactoriamente", "CooperativaXyz", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End With
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al insertar Finalidad Prestamo" + ex.Message, "CooperativaXyz" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()
        End Try
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If ValidarTextBox() = True Then
            HabilitarBotones(True, False, False, False)
            GuardarFinalidadPrestamo()
            Limpiar()
            MostrarTodo()
        End If


    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        HabilitarBotones(True, False, False, False)
        Limpiar()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Close()
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        TxtCodFinalidad.Text = LsvFinalidades.FocusedItem.SubItems(0).Text
        TxtCodFinalidad.Enabled = False
        TxtFinalidad.Text = LsvFinalidades.FocusedItem.SubItems(1).Text
        HabilitarBotones(False, False, True, True)
        TxtFinalidad.Focus()
        TcFinalidad.SelectedIndex = 0



    End Sub
    Private Sub ActualizarFinalidad()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_ActualizarFinalidadPrestamo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn


                    .Parameters.Add("@Finalidad", SqlDbType.NVarChar, 50).Value = TxtFinalidad.Text
                    .Parameters.Add("@IdFinalidadPrestamo", SqlDbType.Int).Value = TxtCodFinalidad.Text
                    .ExecuteNonQuery()

                    MessageBox.Show("Registro Actualizado Satisfactoriamente", "CooperativaXyz", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End With
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al actualizar la finalidad" + ex.Message, "CooperativaXyz", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()
        End Try
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        ActualizarFinalidad()
        HabilitarBotones(True, False, False, False)
        MostrarTodo()
        Limpiar()
    End Sub
    Private Sub EliminarFinalidad()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_EliminarFinalidadPrestamo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn


                    Dim Id As Integer
                    Id = CInt(LsvFinalidades.FocusedItem.SubItems(0).Text)
                    .Parameters.Add("@IdFinalidadPrestamo", SqlDbType.Int).Value = Id
                    .ExecuteNonQuery()

                    MessageBox.Show("Finalidad prestamo eliminada Satisfactoriamente", "CooperativaXyz", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End With
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al elimnar la Finalidad" + ex.Message, "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()
        End Try
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        EliminarFinalidad()
        MostrarTodo()
    End Sub
    Private Sub BuscaFinalidad()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Using CMd As New SqlCommand
            Cn.Open()

            Try
                With CMd
                    .CommandText = "Sp_MostrarFinalidadPrestamoX"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    .Parameters.Add("@Busqueda", SqlDbType.NVarChar, 50).Value = TxtBuscarFinalidad.Text

                End With

                Dim VerFinalidades As SqlDataReader
                VerFinalidades = CMd.ExecuteReader

                LsvFinalidades.Items.Clear()
                While VerFinalidades.Read = True
                    With LsvFinalidades.Items.Add(VerFinalidades("IdFinalidadPrestamo").ToString)
                        .SubItems.Add(VerFinalidades("Finalidad").ToString)


                    End With
                End While

            Catch ex As Exception

                MessageBox.Show("Error al mostrar la Finalidad" + ex.Message, "CooperativaXyz", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Cn.Close()

            End Try
        End Using
    End Sub

    Private Sub TxtBuscarFinalidad_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscarFinalidad.TextChanged
        BuscaFinalidad()
    End Sub
    Private Function ValidarTextBox() As Boolean
        Dim Estado As Boolean
        If TxtFinalidad.Text = Nothing Then
            EpMensaje.SetError(TxtFinalidad, "Debe ingresar la finalidad del prestamo")
            TxtFinalidad.BackColor = Color.LightBlue
            Estado = False
        Else
            EpMensaje.SetError(TxtFinalidad, "")
            Estado = True


        End If
        Return Estado
    End Function


End Class