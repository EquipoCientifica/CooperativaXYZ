Imports System.Data.SqlClient
Public Class FrmLugarTrabajo
    Private Sub HabilitarBotones(ByVal Nuevo As Boolean, ByVal Guardar As Boolean, ByVal Modificar As Boolean, ByVal Cancelar As Boolean)
        BtnNuevo.Enabled = Nuevo
        BtnGuardar.Enabled = Guardar
        BtnModificar.Enabled = Modificar
        BtnCancelar.Enabled = Cancelar

    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        HabilitarBotones(False, True, False, True)
        InvestigarCorrelativoLugarTrabajo()

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        HabilitarBotones(True, False, False, False)
        Limpiar()
    End Sub
    Private Sub Limpiar()
        TxtCodigoLugar.Clear()
        TxtLugar.Clear()
    End Sub
    Public Sub InvestigarCorrelativoLugarTrabajo()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If


        Try
            Dim ListaLugarTrabajo As New SqlCommand("Sp_InvestigarCorrelativoLugarTrabajo", Cn)
            ListaLugarTrabajo.CommandType = CommandType.StoredProcedure

            Dim ListarLgarTrabajo1 As SqlDataReader
            Cn.Open()

            ListarLgarTrabajo1 = ListaLugarTrabajo.ExecuteReader
            If ListarLgarTrabajo1.Read = True Then
                If ListarLgarTrabajo1("IdLugarTrabajo") Is DBNull.Value Then
                    TxtCodigoLugar.Text = 1

                Else
                    TxtCodigoLugar.Text = ListarLgarTrabajo1("IdLugarTrabajo").ToString

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
                    .CommandText = "Sp_MostrarLugarTrabajo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                End With
                Dim VerLugarTrabajo As SqlDataReader
                VerLugarTrabajo = CMd.ExecuteReader()

                LsvLugarTrabajo.Items.Clear()
                While VerLugarTrabajo.Read = True
                    With LsvLugarTrabajo.Items.Add(VerLugarTrabajo("IdLugarTrabajo").ToString)
                        .SubItems.Add(VerLugarTrabajo("LugarTrabajo").ToString)

                    End With

                End While

            Catch ex As Exception
                MessageBox.Show("Error al consultar los datos." + ex.Message, "CooperativaXYZ", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Finally
                Cn.Close()
            End Try
        End Using

    End Sub
    Private Sub GuardarLugarTrabajo()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_InsertarLugarTrabajo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    .Parameters.Add("@LugarTrabajo", SqlDbType.NVarChar, 50).Value = TxtLugar.Text
                    .ExecuteNonQuery()

                    MessageBox.Show("Registro realizado satisfactoriamente.", "CooperativaXYZ", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End With
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al insertar el Lugar de trabajo.", "CooperativaXYZ", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            Cn.Close()
        End Try

    End Sub

    Private Sub FrmLugarTrabajo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarTodo()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If ValidarTextBox() = True Then
            HabilitarBotones(True, False, False, False)
            GuardarLugarTrabajo()
            MostrarTodo()
            Limpiar()
        End If

    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        TxtCodigoLugar.Text = LsvLugarTrabajo.FocusedItem.SubItems(0).Text
        TxtLugar.Text = LsvLugarTrabajo.FocusedItem.SubItems(1).Text

        TcLugarTrabajo.SelectedIndex = 0
        HabilitarBotones(False, False, True, True)

    End Sub
    Private Sub ActualizarLugarTrabajo()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_ActualizarLugarTrabajo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    .Parameters.Add("@IdLugarTrabajo", SqlDbType.Int).Value = CInt(TxtCodigoLugar.Text)
                    .Parameters.Add("@LugarTrabajo", SqlDbType.NVarChar, 20).Value = TxtLugar.Text
                    .ExecuteNonQuery()

                    MessageBox.Show("Registro actualizado satisfactoriamente.", "CooperativaXYZ", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End With
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al actualizar el lugar de trabajo.", "CooperativaXYZ", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            Cn.Close()
        End Try

    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        ActualizarLugarTrabajo()
        HabilitarBotones(True, False, False, False)
        Limpiar()
        MostrarTodo()

    End Sub
    Private Sub EliminarLugarTrabajo()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_EliminarLugarTrabajo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    Dim Id As Integer
                    Id = CInt(LsvLugarTrabajo.FocusedItem.SubItems(0).Text)

                    .Parameters.Add("@IdLugarTrabajo", SqlDbType.Int).Value = Id
                    .ExecuteNonQuery()

                    MessageBox.Show("Registro eliminado satisfactoriamente.", "CooperativaXYZ", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End With
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al eliminar el lugar de trabajo.", "CooperativaXYZ", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            Cn.Close()
        End Try


    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Close()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        EliminarLugarTrabajo()
        MostrarTodo()
    End Sub
    Private Sub BuscarLugarTrabajoX()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Using CMd As New SqlCommand
            Cn.Open()

            Try
                With CMd
                    .CommandText = "Sp_MostrarLugarTrabajoX"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    .Parameters.Add("@Busqueda", SqlDbType.NVarChar, 20).Value = TxtBuscar.Text

                End With

                Dim VerLugarTrabajo As SqlDataReader
                VerLugarTrabajo = CMd.ExecuteReader

                LsvLugarTrabajo.Items.Clear()
                While VerLugarTrabajo.Read = True
                    With LsvLugarTrabajo.Items.Add(VerLugarTrabajo("IdLugarTrabajo").ToString)
                        .SubItems.Add(VerLugarTrabajo("LugarTrabajo").ToString)

                    End With
                End While

            Catch ex As Exception

                MessageBox.Show("Error al mostrar los lugares de trabajo" + ex.Message, "CooperativaXYZ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Cn.Close()

            End Try
        End Using
    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged
        BuscarLugarTrabajoX()
    End Sub
    Private Function ValidarTextBox() As Boolean
        Dim Estado As Boolean
        If TxtLugar.Text = Nothing Then
            EpMensaje.SetError(TxtLugar, "Debe ingresar un lugar de trabajo")
            Estado = False
        Else
            EpMensaje.SetError(TxtLugar, "")
            Estado = True
        End If
        Return Estado
    End Function
End Class