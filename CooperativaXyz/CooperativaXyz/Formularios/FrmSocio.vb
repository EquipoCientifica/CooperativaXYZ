Imports System.Data.SqlClient

Public Class FrmSocio

    Private Sub MostrarSocios()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Using CMd As New SqlCommand
            Cn.Open()
            Try
                With CMd
                    .CommandText = "Sp_MostrarTodoSocios"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn
                End With

                Dim VerSocios As SqlDataReader
                VerSocios = CMd.ExecuteReader()

                LsvSocios.Items.Clear()
                While VerSocios.Read = True
                    With LsvSocios.Items.Add(VerSocios("CodSocio").ToString)
                        .SubItems.Add(VerSocios("Nombres").ToString)
                        .SubItems.Add(VerSocios("Apellidos").ToString)
                        .SubItems.Add(VerSocios("Rtn").ToString)
                        .SubItems.Add(VerSocios("Direccion").ToString)
                        .SubItems.Add(VerSocios("Nacionalidad").ToString)
                        .SubItems.Add(VerSocios("EstadoCivil").ToString)
                        .SubItems.Add(VerSocios("LugarTrabajo").ToString)
                        .SubItems.Add(VerSocios("TelCasa").ToString)
                        .SubItems.Add(VerSocios("TelTrabajo").ToString)
                    End With
                End While
            Catch ex As Exception
                MessageBox.Show("Error al Mostrar los datos socios ", "CooperativaXyz", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Cn.Close()
            End Try
        End Using
    End Sub


    Private Sub GuardarSocios()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_InsertarSocio"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    .Parameters.Add("@CodSocio", SqlDbType.NVarChar, 15).Value = TxtCodigoSocio.Text
                    .Parameters.Add("@Nombres", SqlDbType.NVarChar, 50).Value = TxtNombres.Text
                    .Parameters.Add("@Apellidos", SqlDbType.NVarChar, 50).Value = TxtApellidos.Text
                    .Parameters.Add("@Rtn", SqlDbType.NVarChar, 14).Value = TxtRtn.Text
                    .Parameters.Add("@Direccion", SqlDbType.NVarChar, 300).Value = TxtDireccion.Text
                    .Parameters.Add("@IdNacionalidad", SqlDbType.Int).Value = CInt(CboIdNacionalidad.SelectedValue)
                    .Parameters.Add("@IdEstadoCivil", SqlDbType.Int).Value = CInt(CboIdEstadoCivil.SelectedValue)
                    .Parameters.Add("@IdLugarTrabajo", SqlDbType.Int).Value = CInt(CboIdLugarTrabajo.SelectedValue)
                    .Parameters.Add("@TelCasa", SqlDbType.Char, 9).Value = TxtTelefonoCasa.Text
                    .Parameters.Add("@TelTrabajo", SqlDbType.Char, 9).Value = TxtTelefonoTrabajo.Text
                    .ExecuteNonQuery()

                    MessageBox.Show("Registro realizado Satisfactoriamente", "CooperativaXyz", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End With
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al insertar los datos del Socio" + ex.Message, "CooperativaXyz", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()
        End Try
    End Sub

    Private Sub LlenarComboNacionalidad()
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

                Dim Da As New SqlDataAdapter(CMd)
                Dim Ds As New DataSet

                Da.Fill(Ds, "Nacionalidad")
                CboIdNacionalidad.DataSource = Ds.Tables(0)

                CboIdNacionalidad.DisplayMember = Ds.Tables(0).Columns("Nacionalidad").ToString
                CboIdNacionalidad.ValueMember = Ds.Tables(0).Columns("IdNacionalidad").ToString

            Catch ex As Exception
                MessageBox.Show("Error al Mostrar los datos nacionalidad" + ex.Message, "CooperativaXyz", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Cn.Close()
            End Try
        End Using
    End Sub

    Private Sub LlenarComboEstadoCivil()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Using CMd As New SqlCommand
            Cn.Open()
            Try
                With CMd
                    .CommandText = "Sp_MostrarEstadoCivil"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn
                End With

                Dim Da As New SqlDataAdapter(CMd)
                Dim Ds As New DataSet

                Da.Fill(Ds, "EstadoCivil")
                CboIdEstadoCivil.DataSource = Ds.Tables(0)

                CboIdEstadoCivil.DisplayMember = Ds.Tables(0).Columns("EstadoCivil").ToString
                CboIdEstadoCivil.ValueMember = Ds.Tables(0).Columns("IdEstadoCivil").ToString

            Catch ex As Exception
                MessageBox.Show("Error al Mostrar los datos estado civil", "CooperativaXyz", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Cn.Close()
            End Try
        End Using
    End Sub

    Private Sub LlenarComboLugarTrabajo()
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

                Dim Da As New SqlDataAdapter(CMd)
                Dim Ds As New DataSet

                Da.Fill(Ds, "LugarTrabajo")
                CboIdLugarTrabajo.DataSource = Ds.Tables(0)

                CboIdLugarTrabajo.DisplayMember = Ds.Tables(0).Columns("LugarTrabajo").ToString
                CboIdLugarTrabajo.ValueMember = Ds.Tables(0).Columns("IdLugarTrabajo").ToString

            Catch ex As Exception
                MessageBox.Show("Error al Mostrar los datos lugar trabajo", "CooperativaXyz", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Cn.Close()
            End Try
        End Using
    End Sub

    Private Sub ActualizarSocio()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Using CMd As New SqlCommand
            Cn.Open()
            Try
                With CMd
                    .CommandText = "Sp_ActualizarSocio"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    .Parameters.Add("@CodSocio", SqlDbType.NVarChar, 15).Value = TxtCodigoSocio.Text
                    .Parameters.Add("@Nombres", SqlDbType.NVarChar, 50).Value = TxtNombres.Text
                    .Parameters.Add("@Apellidos", SqlDbType.NVarChar, 50).Value = TxtApellidos.Text
                    .Parameters.Add("@Rtn", SqlDbType.Int, 14).Value = TxtRtn.Text
                    .Parameters.Add("@IdNacionalidad", SqlDbType.Int).Value = CInt(CboIdNacionalidad.SelectedValue)
                    .Parameters.Add("@IdEstadoCivil", SqlDbType.Int).Value = CInt(CboIdEstadoCivil.SelectedValue)
                    .Parameters.Add("@IdLugarTrabajo", SqlDbType.Int).Value = CInt(CboIdLugarTrabajo.SelectedValue)
                    .Parameters.Add("@TelCasa", SqlDbType.Char, 9).Value = TxtTelefonoCasa.Text
                    .Parameters.Add("@TelTrabajo", SqlDbType.Char, 9).Value = TxtTelefonoTrabajo.Text
                    .ExecuteNonQuery()

                    MessageBox.Show("Actualizacion realizada Satisfactoriamente", "CooperativaXyz", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End With

            Catch ex As Exception
                MessageBox.Show("Error al Actualizar los datos", "CooperativaXyz", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Cn.Close()
            End Try
        End Using
    End Sub

    Private Sub EliminarSocio()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_EliminarSocio"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn


                    Dim Id As Integer
                    Id = CInt(LsvSocios.FocusedItem.SubItems(0).Text)
                    .Parameters.Add("@CodSocio", SqlDbType.NVarChar, 15).Value = Id
                    .ExecuteNonQuery()

                    MessageBox.Show("Registro Eliminado Satisfactoriamente", "CooperativaXyz", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End With
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al elimnar el socio ", "CooperativaXyz", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()
        End Try
    End Sub

    Private Sub BuscarSocio()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Using CMd As New SqlCommand
            Cn.Open()
            Try
                With CMd
                    .CommandText = "Sp_BuscarSocio"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    .Parameters.Add("@NombreSocio", SqlDbType.NVarChar, 50).Value = TxtBuscar.Text
                End With

                Dim VerSocios As SqlDataReader
                VerSocios = CMd.ExecuteReader()

                LsvSocios.Items.Clear()
                While VerSocios.Read = True
                    With LsvSocios.Items.Add(VerSocios("CodSocio").ToString)
                        .SubItems.Add(VerSocios("Nombres").ToString)
                        .SubItems.Add(VerSocios("Apellidos").ToString)
                        .SubItems.Add(VerSocios("Rtn").ToString)
                        .SubItems.Add(VerSocios("Direccion").ToString)
                        .SubItems.Add(VerSocios("Nacionalidad").ToString)
                        .SubItems.Add(VerSocios("EstadoCivil").ToString)
                        .SubItems.Add(VerSocios("LugarTrabajo").ToString)
                        .SubItems.Add(VerSocios("TelCasa").ToString)
                        .SubItems.Add(VerSocios("TelTrabajo").ToString)
                    End With
                End While
            Catch ex As Exception
                MessageBox.Show("Error al Mostrar los datos", "CooperativaXyz", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Cn.Close()
            End Try
        End Using
    End Sub

    Private Function ValidarTextBox()
        Dim Estado As Boolean

        If TxtCodigoSocio.Text = Nothing And TxtNombres.Text = Nothing And TxtApellidos.Text = Nothing And TxtDireccion.Text = Nothing And CboIdNacionalidad.SelectedValue = -1 And CboIdEstadoCivil.SelectedValue = -1 And CboIdLugarTrabajo.SelectedValue = -1 And TxtTelefonoCasa.Text = Nothing And TxtTelefonoTrabajo.Text = Nothing Then
            EpMensaje.SetError(TxtCodigoSocio, "Ingrese El Código del Socio")
            EpMensaje.SetError(TxtNombres, "Ingrese el nombre del Socio")
            EpMensaje.SetError(TxtApellidos, "Ingrese los apellidos del Socio")
            EpMensaje.SetError(TxtDireccion, "Ingrese la Direccion en Donde Reside El socio")
            EpMensaje.SetError(CboIdNacionalidad, "Seleccione la Nacionalidad del Socio")
            EpMensaje.SetError(CboIdEstadoCivil, "Seleccione el estado Civil del Socio")
            EpMensaje.SetError(CboIdLugarTrabajo, "Seleccione el lugar de Trabajo del Socio")
            TxtCodigoSocio.BackColor = Color.LightBlue
            TxtCodigoSocio.Focus()
            Estado = False

        ElseIf TxtCodigoSocio.Text = Nothing Then
            EpMensaje.SetError(TxtCodigoSocio, "Ingrese El Código del Socio")
            TxtCodigoSocio.BackColor = Color.LightBlue
            TxtCodigoSocio.Focus()
            Estado = False

        ElseIf TxtNombres.Text = Nothing Then
            EpMensaje.SetError(TxtNombres, "Ingrese el nombre del Socio")
            TxtNombres.BackColor = Color.LightBlue
            TxtNombres.Focus()
            Estado = False

        ElseIf TxtApellidos.Text = Nothing Then
            EpMensaje.SetError(TxtApellidos, "Ingrese los apellidos del Socio")
            TxtApellidos.BackColor = Color.LightBlue
            TxtApellidos.Focus()
            Estado = False

        ElseIf TxtDireccion.Text = Nothing Then
            EpMensaje.SetError(TxtDireccion, "Ingrese la direccion en la que reside el Socio")
            TxtDireccion.BackColor = Color.LightBlue
            TxtDireccion.Focus()
            Estado = False

        ElseIf CboIdNacionalidad.SelectedValue = -1 Then
            EpMensaje.SetError(CboIdNacionalidad, "Seleccione la Nacionalidad del Socio")
            Estado = False
            CboIdNacionalidad.BackColor = Color.LightBlue

        ElseIf CboIdEstadoCivil.SelectedValue = -1 Then
            EpMensaje.SetError(CboIdEstadoCivil, "Seleccione el estado civil del Socio")
            Estado = False
            CboIdEstadoCivil.BackColor = Color.LightBlue

        ElseIf CboIdLugarTrabajo.SelectedValue = -1 Then
            EpMensaje.SetError(CboIdLugarTrabajo, "Seleccione el lugar de trabajo del Socio")
            Estado = False
            CboIdLugarTrabajo.BackColor = Color.LightBlue

        ElseIf TxtTelefonoCasa.Text = Nothing Then
            EpMensaje.SetError(TxtTelefonoCasa, "Ingrese el telefono de casa el Socio")
            TxtTelefonoCasa.BackColor = Color.LightBlue
            TxtTelefonoCasa.Focus()
            Estado = False

        ElseIf TxtTelefonoTrabajo.Text = Nothing Then
            EpMensaje.SetError(TxtTelefonoCasa, "Ingrese el telefono del tranajo el Socio")
            TxtTelefonoTrabajo.BackColor = Color.LightBlue
            TxtTelefonoTrabajo.Focus()
            Estado = False

        Else
            Estado = True
        End If
        Return Estado
    End Function


    Private Sub Limpiar()
        TxtCodigoSocio.Text = Nothing
        TxtNombres.Text = Nothing
        TxtApellidos.Text = Nothing
        TxtDireccion.Text = Nothing
        TxtTelefonoCasa.Text = Nothing
        TxtTelefonoTrabajo.Text = Nothing
    End Sub

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

    Private Sub FrmSocio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarSocios()

    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        HabilitarBotones(False, True, False, True, True)
        MostrarSocios()
        LlenarComboEstadoCivil()
        LlenarComboLugarTrabajo()
        LlenarComboNacionalidad()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If ValidarTextBox() = True Then
            HabilitarBotones(True, False, False, False, True)
            GuardarSocios()
            MostrarSocios()
            Limpiar()
        End If
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        HabilitarBotones(False, False, True, True, True)
        TxtCodigoSocio.Text = LsvSocios.FocusedItem.SubItems(0).Text
        TxtNombres.Text = LsvSocios.FocusedItem.SubItems(1).Text
        TxtApellidos.Text = LsvSocios.FocusedItem.SubItems(2).Text
        TxtDireccion.Text = LsvSocios.FocusedItem.SubItems(3).Text
        CboIdNacionalidad.Text = LsvSocios.FocusedItem.SubItems(4).Text
        CboIdEstadoCivil.Text = LsvSocios.FocusedItem.SubItems(5).Text
        CboIdLugarTrabajo.Text = LsvSocios.FocusedItem.SubItems(6).Text
        TxtTelefonoCasa.Text = LsvSocios.FocusedItem.SubItems(7).Text
        TxtTelefonoTrabajo.Text = LsvSocios.FocusedItem.SubItems(8).Text

        TbMenu.SelectedIndex = 0
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        If ValidarTextBox() = True Then
            HabilitarBotones(True, False, False, True, True)
            ActualizarSocio()
            MostrarSocios()

            TbMenu.SelectedIndex = 1
        End If
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        EliminarSocio()
        MostrarSocios()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        HabilitarBotones(True, False, False, False, True)
        Limpiar()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Close()
    End Sub

    Private Sub Seleccionar_Click(sender As Object, e As EventArgs) Handles Seleccionar.Click
        FrmSolicitudPrestamo.TxtCodSocio.Text = LsvSocios.FocusedItem.SubItems(0).Text
        FrmAvales.TxtAval.Text = LsvSocios.FocusedItem.SubItems(0).Text
        Close()
    End Sub
End Class