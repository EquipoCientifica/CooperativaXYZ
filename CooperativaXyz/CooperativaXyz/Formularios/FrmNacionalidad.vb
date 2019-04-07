Imports System.Data.SqlClient

Public Class FrmNacionalidad

    Private Sub HabilitarBotones(ByVal Nuevo As Boolean,
                                 ByVal Guardar As Boolean,
                                 ByVal Modificar As Boolean,
                                 ByVal Cancelar As Boolean,
                                 ByVal Salir As Boolean)
        BtnNuevo.Enabled = Nuevo
        BtnGuardar.Enabled = Guardar
        BtnModificar.Enabled = Modificar
        BtnCancelar.Enabled = Cancelar
        BtnSalir.Enabled = Salir
    End Sub

    Private Sub InvestigarCorrelativoNacionalidad()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Dim ListarNacionalidad As New SqlCommand("Sp_InvestigarCorrelativoNacionalidad", Cn)
            ListarNacionalidad.CommandType = CommandType.StoredProcedure

            Dim ListarNacionalidadR As SqlDataReader
            Cn.Open()
            ListarNacionalidadR = ListarNacionalidad.ExecuteReader()

            If ListarNacionalidadR.Read = True Then
                If ListarNacionalidadR("IdNacionalidad") Is DBNull.Value Then
                    TxtCodNacionalidad.Text = 1
                Else
                    TxtCodNacionalidad.Text = ListarNacionalidadR("IdNacionalidad").ToString
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error al Consultar los Datos", "CooperativaXyz", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            Cn.Close()
        End Try
    End Sub

    Private Sub GuardarNacionalidad()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_InsertarNacionalidad"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    .Parameters.Add("@Nacionalidad", SqlDbType.NVarChar, 50).Value = TxtNacionalidad.Text
                    .ExecuteNonQuery()

                    MessageBox.Show("Registro realizado Satisfactoriamente", "CooperativaXyz", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End With
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al insertar la Nacionalidad", "CooperativaXyz", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()
        End Try
    End Sub

    Private Sub ActualizarNacionalidad()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_ActualizarNacionalidad"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    .Parameters.Add("@Nacionalidad", SqlDbType.NVarChar, 50).Value = TxtNacionalidad.Text
                    .Parameters.Add("@IdNacionalidad", SqlDbType.Int).Value = TxtCodNacionalidad.Text
                    .ExecuteNonQuery()

                    MessageBox.Show("Registro Actualizado Satisfactoriamente", "CooperativaXyz", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End With
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al actualizar la Nacionalidad", "CooperativaXyz", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()
        End Try
    End Sub

    Private Sub MostrarNacionalidad()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Using CMd As New SqlCommand
            Cn.Open()
            Try
                With CMd
                    .CommandText = "Sp_MostrarNacionalidad"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn
                End With

                Dim VerNacionalidad As SqlDataReader
                VerNacionalidad = CMd.ExecuteReader()

                LsvNacionalidades.Items.Clear()
                While VerNacionalidad.Read = True
                    With LsvNacionalidades.Items.Add(VerNacionalidad("IdNacionalidad").ToString)
                        .SubItems.Add(VerNacionalidad("Nacionalidad").ToString)
                    End With
                End While
            Catch ex As Exception
                MessageBox.Show("Error al Mostrar la Nacionalidad", "CooperativaXyz", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Cn.Close()
            End Try
        End Using
    End Sub

    Private Sub EliminarNacionalidad()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_EliminarNacionalidad"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    Dim Id As Integer
                    Id = CInt(LsvNacionalidades.FocusedItem.SubItems(0).Text)
                    .Parameters.Add("@IdNacionalidad", SqlDbType.Int).Value = Id
                    .ExecuteNonQuery()

                    MessageBox.Show("Registro Eliminado Satisfactoriamente", "CooperativaXyz", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End With
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al elimnar el genero musical", "CooperativaXyz", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()
        End Try
    End Sub


    Private Sub BuscarNacionalidad()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Using CMd As New SqlCommand
            Cn.Open()
            Try
                With CMd
                    .CommandText = "Sp_BuscarNacionalidad"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    .Parameters.Add("@Nacionalidad", SqlDbType.NVarChar, 50).Value = TxtBuscarNacionalidades.Text
                End With

                Dim VerNacionalidad As SqlDataReader
                VerNacionalidad = CMd.ExecuteReader()

                LsvNacionalidades.Items.Clear()
                While VerNacionalidad.Read = True
                    With LsvNacionalidades.Items.Add(VerNacionalidad("IdNacionalidad").ToString)
                        .SubItems.Add(VerNacionalidad("Nacionalidad").ToString)
                    End With
                End While
            Catch ex As Exception
                MessageBox.Show("Error al Mostrar los datos", "Cooperativa", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Cn.Close()
            End Try
        End Using
    End Sub

    Private Function ValidarTextBox()
        Dim Estado As Boolean
        If TxtNacionalidad.Text = Nothing Then
            EpMensajeNacionalidad.SetError(TxtNacionalidad, "Tiene que ingresar la Nacionalidad")
            TxtNacionalidad.Focus()
            TxtNacionalidad.BackColor = Color.LightBlue
            Estado = False
        Else
            Estado = True
            EpMensajeNacionalidad.SetError(TxtNacionalidad, "")
        End If
        Return Estado
    End Function

    Private Sub Limpiar()
        TxtNacionalidad.Text = Nothing
        TxtCodNacionalidad.Text = Nothing
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        HabilitarBotones(False, True, False, True, True)
        InvestigarCorrelativoNacionalidad()
        TxtNacionalidad.Focus()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If ValidarTextBox() = True Then
            GuardarNacionalidad()
            Limpiar()
            HabilitarBotones(True, False, False, False, True)
            MostrarNacionalidad()
        End If
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        If ValidarTextBox() = True Then
            HabilitarBotones(True, False, False, True, True)
            ActualizarNacionalidad()
            Limpiar()
            MostrarNacionalidad()
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        HabilitarBotones(True, False, False, False, True)
        Limpiar()
    End Sub

    Private Sub TxtNacionalidad_TextChanged(sender As Object, e As EventArgs) Handles TxtNacionalidad.TextChanged
        If TxtNacionalidad.Text <> Nothing Then
            EpMensajeNacionalidad.SetError(TxtNacionalidad, "")
            TxtNacionalidad.BackColor = Color.White
        End If
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Close()
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        TxtCodNacionalidad.Text = LsvNacionalidades.FocusedItem.SubItems(0).Text
        TxtNacionalidad.Text = LsvNacionalidades.FocusedItem.SubItems(1).Text

        HabilitarBotones(False, False, True, True, True)
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        EliminarNacionalidad()
        MostrarNacionalidad()
        HabilitarBotones(True, False, False, False, True)
    End Sub

    Private Sub TxtBuscarNacionalidades_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscarNacionalidades.TextChanged
        BuscarNacionalidad()
    End Sub

    Private Sub FrmNacionalidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarNacionalidad()
    End Sub
End Class