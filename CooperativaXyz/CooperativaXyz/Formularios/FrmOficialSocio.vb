Imports System.Data.SqlClient
Public Class FrmOficialSocio
    Private Sub HabilitarBotones(ByVal Nuevo As Boolean,
                              ByVal Guardar As Boolean,
                              ByVal Modificar As Boolean,
                              ByVal Cancelar As Boolean)
        BtnNuevo.Enabled = Nuevo
        BtnGuardar.Enabled = Guardar
        BtnModificar.Enabled = Modificar
        BtnCancelar.Enabled = Cancelar
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Close()
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        HabilitarBotones(False, True, False, True)
        TxtCodigoOficialCredito.Focus()

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If ValidarTextBox() = True Then
            HabilitarBotones(True, False, False, False)
            GuardarOficialCredito()
            Limpiar()
            MostrarTodo()
        End If
    End Sub

    Private Sub Limpiar()
        TxtNombre.Clear()
        TxtCodigoOficialCredito.Clear()
        TxtApellido.Clear()
    End Sub

    Private Sub GuardarOficialCredito()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_InsertarOficialCredito"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn


                    ' Enviar el parametro de los datos del oficial credito
                    .Parameters.Add("@CodOficial", SqlDbType.NVarChar, 11).Value = TxtCodigoOficialCredito.Text
                    .Parameters.Add("@Nombres", SqlDbType.NVarChar, 50).Value = TxtNombre.Text
                    .Parameters.Add("@Apellidos", SqlDbType.NVarChar, 50).Value = TxtApellido.Text
                    .ExecuteNonQuery()

                    MessageBox.Show("Registro realizado Satisfactoriamente", "Cooperativa", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End With
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al insertar Oficial Credito" + ex.Message, "Cooperativa", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()
        End Try
    End Sub
    Private Sub ActualizarOficialCredito()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_ActualizarOficalCredito"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn


                    ' Enviar el parametro de los datos del Oficial Credito
                    .Parameters.Add("@Nombres", SqlDbType.NVarChar, 30).Value = TxtNombre.Text
                    .Parameters.Add("@Apellidos", SqlDbType.NVarChar, 30).Value = TxtApellido.Text
                    .Parameters.Add("@CodOficial", SqlDbType.NVarChar, 11).Value = TxtCodigoOficialCredito.Text
                    .ExecuteNonQuery()

                    MessageBox.Show("Registro Actualizado Satisfactoriamente", "Cooperativa", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End With
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al actualizar la Ofical Credito" + ex.Message, "Cooperativa", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
                    .CommandText = "Sp_MostrarOficialCredito"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn
                End With

                Dim verOficial As SqlDataReader
                verOficial = CMd.ExecuteReader()

                LsvOficiales.Items.Clear()
                While verOficial.Read = True
                    With LsvOficiales.Items.Add(verOficial("CodOficial").ToString)
                        .SubItems.Add(verOficial("Nombres").ToString)
                        .SubItems.Add(verOficial("Apellidos").ToString)
                    End With
                End While
            Catch ex As Exception
                MessageBox.Show("Error al Mostrar los oficiales Creditos " + ex.Message, "Cooperativa", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Cn.Close()
            End Try
        End Using
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        HabilitarBotones(True, False, False, False)
        Limpiar()
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        HabilitarBotones(True, False, False, False)
        ActualizarOficialCredito()
        Limpiar()
        MostrarTodo()
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        TxtCodigoOficialCredito.Text = LsvOficiales.FocusedItem.SubItems(0).Text
        TxtNombre.Text = LsvOficiales.FocusedItem.SubItems(1).Text
        TxtApellido.Text = LsvOficiales.FocusedItem.SubItems(2).Text
        TxtNombre.Focus()
        HabilitarBotones(False, False, True, True)

        TbDatosOficial.SelectedIndex = 0
    End Sub

    Private Sub FrmOficialSocio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarTodo()
        HabilitarBotones(True, False, False, False)
    End Sub
    Private Sub EliminarOficialCredito()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_EliminarOficialCredito"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn


                    Dim Id As Integer
                    Id = CInt(LsvOficiales.FocusedItem.SubItems(0).Text)
                    .Parameters.Add("@CodOficial", SqlDbType.NVarChar, 11).Value = Id
                    .ExecuteNonQuery()

                    MessageBox.Show("Oficail Credito Eliminada Satisfactoriamente", "Cooperativa", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End With

            End Using
        Catch ex As Exception
            MessageBox.Show("Error al elimnar el Ofical Credito" + ex.Message, "Cooperativa", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()
        End Try
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        EliminarOficialCredito()
        MostrarTodo()
    End Sub

    Private Function ValidarTextBox()
        Dim Estado As Boolean
        If TxtCodigoOficialCredito.Text = Nothing And TxtNombre.Text = Nothing And TxtApellido.Text = Nothing Then
            EpMensaje.SetError(TxtCodigoOficialCredito, "Ingrese los datos")
            TxtCodigoOficialCredito.Focus()
            TxtCodigoOficialCredito.BackColor = Color.LightBlue
            TxtNombre.BackColor = Color.LightBlue
            TxtApellido.BackColor = Color.LightBlue
            Estado = False


        ElseIf TxtCodigoOficialCredito.Text = Nothing Then
            EpMensaje.SetError(TxtCodigoOficialCredito, "Ingrese el Código del oficial")
            TxtCodigoOficialCredito.Focus()
            Estado = False

        ElseIf TxtNombre.Text = Nothing Then
            EpMensaje.SetError(TxtNombre, "Ingrese el nombre del Ofical Credito")
            TxtNombre.Focus()
            Estado = False
        ElseIf TxtApellido.Text = Nothing Then
            EpMensaje.SetError(TxtApellido, "Ingrese el apellido del Ofical Credito")
            TxtApellido.Focus()
            Estado = False
        Else
            Estado = True
            EpMensaje.SetError(TxtCodigoOficialCredito, "")

        End If
        Return Estado
    End Function




    Private Sub TxtNombre_TextChanged(sender As Object, e As EventArgs) Handles TxtNombre.TextChanged
        If TxtNombre.Text <> Nothing Then
            EpMensaje.SetError(TxtNombre, "")
            TxtNombre.BackColor = Color.White
        End If
    End Sub

    Private Sub TxtApellido_TextChanged(sender As Object, e As EventArgs) Handles TxtApellido.TextChanged
        If TxtApellido.Text <> Nothing Then
            EpMensaje.SetError(TxtApellido, "")
            TxtApellido.BackColor = Color.White
        End If
    End Sub
    Private Sub BuscarOficialCreditoPorNombre()

        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Using CMd As New SqlCommand
            Cn.Open()

            Try
                With CMd
                    .CommandText = "Sp_MostrarOficialCreditoX"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    .Parameters.Add("@Busqueda", SqlDbType.NVarChar, 50).Value = TxtBuscarOficiales.Text

                End With

                Dim VerOficial As SqlDataReader
                VerOficial = CMd.ExecuteReader

                LsvOficiales.Items.Clear()
                While VerOficial.Read = True
                    With LsvOficiales.Items.Add(VerOficial("CodOficial").ToString)
                        .SubItems.Add(VerOficial("Nombres").ToString)
                        .SubItems.Add(VerOficial("Apellidos").ToString)


                    End With
                End While

            Catch ex As Exception

                MessageBox.Show("Error al mostrar OficialCredito " + ex.Message, "Cooperativa", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Cn.Close()

            End Try
        End Using
    End Sub

    Private Sub TxtBuscarOficiales_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscarOficiales.TextChanged
        BuscarOficialCreditoPorNombre()
    End Sub

    Private Sub TxtCodigoOficialCredito_TextChanged(sender As Object, e As EventArgs) Handles TxtCodigoOficialCredito.TextChanged
        If TxtCodigoOficialCredito.Text <> Nothing Then
            EpMensaje.SetError(TxtCodigoOficialCredito, "")
            TxtCodigoOficialCredito.BackColor = Color.White
        End If
    End Sub
End Class