Imports System.Data.SqlClient


Public Class FrmAvales


    Private Sub BtnBuscarSocioAval_Click(sender As Object, e As EventArgs) Handles BtnBuscarSocioAval.Click
        FrmSocio.ShowDialog()
    End Sub


    Private Sub HabilitarBotones(ByVal Nuevo As Boolean, ByVal Guardar As Boolean, ByVal Modificar As Boolean, ByVal Cancelar As Boolean)
        BtnNuevo.Enabled = Nuevo
        BtnGuardar.Enabled = Guardar
        BtnModificar.Enabled = Modificar
        BtnCancelar.Enabled = Cancelar
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        HabilitarBotones(False, True, False, True)
        MostrarTodo()


    End Sub

    Private Function Validar()
        Dim Estado As Boolean

        If TxtNumSolicitus.Text = Nothing And TxtMostrarPrestamo.Text = Nothing And TxtAval.Text = Nothing Then
            EpMensaje.SetError(TxtNumSolicitus, "Ingrese el número de solicitud.")
            EpMensaje.SetError(TxtMostrarPrestamo, "Ingrese el tipo de préstamo.")
            EpMensaje.SetError(TxtAval, "Seleccione el aval.")

            Estado = False

        ElseIf TxtMostrarPrestamo.Text = Nothing And TxtAval.Text = Nothing Then

            EpMensaje.SetError(TxtMostrarPrestamo, "Ingrese el tipo de préstamo.")
            EpMensaje.SetError(TxtAval, "Seleccione el aval.")

            Estado = False


        ElseIf TxtNumSolicitus.Text = Nothing And TxtAval.Text = Nothing Then
            EpMensaje.SetError(TxtNumSolicitus, "Ingrese el número de solicitud.")
            EpMensaje.SetError(TxtAval, "Seleccione el aval.")

            Estado = False

        ElseIf TxtNumSolicitus.Text = Nothing And TxtMostrarPrestamo.Text = Nothing Then
            EpMensaje.SetError(TxtNumSolicitus, "Ingrese el número de solicitud.")
            EpMensaje.SetError(TxtMostrarPrestamo, "Ingrese el tipo de préstamo.")


            Estado = False


        ElseIf TxtNumSolicitus.Text = Nothing Then
            EpMensaje.SetError(TxtNumSolicitus, "Ingrese el número de solicitud.")

            Estado = False

        ElseIf TxtMostrarPrestamo.Text = Nothing Then
            EpMensaje.SetError(TxtMostrarPrestamo, "Ingrese el tipo de préstamo.")

            Estado = False

        ElseIf TxtAval.Text = Nothing Then
            EpMensaje.SetError(TxtAval, "Seleccione el aval.")

            Estado = False

        Else
            Estado = True
        End If
        Return Estado
    End Function

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If Validar() = True Then
            GuardarAvales()
            MostrarTodo()
            Limpiar()

        End If
    End Sub

    Private Sub GuardarAvales()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_InsertarAvales"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    .Parameters.Add("@NumSolicitud", SqlDbType.Int).Value = CInt(TxtNumSolicitus.Text)
                    .Parameters.Add("@CodSocio ", SqlDbType.VarChar, 15).Value = TxtAval.Text

                    .ExecuteNonQuery()

                    MessageBox.Show("Registro realizado satisfactoriamente.", "CooperativaXYZ", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End With
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al insertar Aval." + ex.Message, "CooperativaXYZ", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            Cn.Close()
        End Try

    End Sub

    Private Sub Limpiar()
        TxtAval.Text = ""
        TxtNumSolicitus.Text = ""
        TxtMostrarPrestamo.Text = ""
    End Sub


    Private Sub ActualizarAvales()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Using CMd As New SqlCommand
            Cn.Open()
            Try
                With CMd
                    .CommandText = "Sp_ActualizarAvales"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    .Parameters.Add("@NumSolicitud", SqlDbType.Int).Value = CInt(TxtNumSolicitus.Text)
                    .Parameters.Add("@CodSocio ", SqlDbType.VarChar, 15).Value = TxtAval.Text
                    .ExecuteNonQuery()

                    MessageBox.Show("Actualizacion realizada Satisfactoriamente", "CooperativaXyz", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End With

            Catch ex As Exception
                MessageBox.Show("Error al Actualizar los datos" + ex.Message, "CooperativaXyz", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Cn.Close()
            End Try
        End Using
    End Sub

    Private Sub MostrarTodo()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Using CMd As New SqlCommand
            Cn.Open()


            Try
                With CMd
                    .CommandText = "Sp_MostrarAvales"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                End With
                Dim VerAvales As SqlDataReader
                VerAvales = CMd.ExecuteReader()

                LsvAvales.Items.Clear()
                While VerAvales.Read = True
                    With LsvAvales.Items.Add(VerAvales("CodSocio").ToString)
                        .SubItems.Add(VerAvales("NumSolicitud").ToString)

                    End With

                End While

            Catch ex As Exception
                MessageBox.Show("Error al consultar los datos." + ex.Message, "CooperativaXYZ", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Finally
                Cn.Close()
            End Try
        End Using

    End Sub


    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        TxtNumSolicitus.Text = LsvAvales.FocusedItem.SubItems(0).Text
        TxtAval.Text = LsvAvales.FocusedItem.SubItems(1).Text

        HabilitarBotones(False, False, True, True)
        TbDatosAvales.Show()
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        If Validar() = True Then
            ActualizarAvales()
            MostrarTodo()
            Limpiar()
        End If
    End Sub


    Private Sub EliminarAvales()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_EliminarAvales"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    ' Enviar el parámetro 
                    Dim Id As Integer
                    Id = CInt(LsvAvales.FocusedItem.SubItems(0).Text)

                    .Parameters.Add("@NumSolicitud", SqlDbType.Int).Value = Id
                    .ExecuteNonQuery()

                    MessageBox.Show("Registro eliminado satisfactoriamente.", "CooperativaXYZ", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End With
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al eliminar el aval.", "CooperativaXYZ", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            Cn.Close()
        End Try

    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        EliminarAvales()
        Limpiar()
        MostrarTodo()
    End Sub

    Private Sub BuscarAval()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Using CMd As New SqlCommand
            Cn.Open()


            Try
                With CMd
                    .CommandText = "Sp_BuscarPorAval"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    .Parameters.Add("@CodSocio", SqlDbType.VarChar, 15).Value = TxtBuscarNumSolicitud.Text

                End With
                Dim VerAvales As SqlDataReader
                VerAvales = CMd.ExecuteReader()

                LsvAvales.Items.Clear()
                While VerAvales.Read = True
                    With LsvAvales.Items.Add(VerAvales("NumSolicitud").ToString)
                        .SubItems.Add(VerAvales("CodSocio").ToString)

                    End With

                End While

            Catch ex As Exception
                MessageBox.Show("Error al consultar los datos." + ex.Message, "CooperativaXYZ", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Finally
                Cn.Close()
            End Try
        End Using
    End Sub

    Private Sub TxtBuscarNumSolicitud_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscarNumSolicitud.TextChanged
        BuscarAval()
    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        Close()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Limpiar()
    End Sub
End Class

