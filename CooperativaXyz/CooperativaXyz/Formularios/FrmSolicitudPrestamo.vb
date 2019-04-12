Imports System.Data.SqlClient

Public Class FrmSolicitudPrestamo

    Private Sub InvestigarCorrelativoSolicitudPrestamo()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Dim ListarSolicitud As New SqlCommand("Sp_InvestigarCorrelativoSolicitudPrestamo", Cn)
            ListarSolicitud.CommandType = CommandType.StoredProcedure

            Dim ListarSolicitudesR As SqlDataReader
            Cn.Open()
            ListarSolicitudesR = ListarSolicitud.ExecuteReader()

            If ListarSolicitudesR.Read = True Then
                If ListarSolicitudesR("NumSolicitud") Is DBNull.Value Then
                    TxtNumSolicitud.Text = 1
                Else
                    TxtNumSolicitud.Text = ListarSolicitudesR("NumSolicitud").ToString
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error al Consultar los Datos", "CooperativaXyz", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            Cn.Close()
        End Try
    End Sub

    Private Sub MostrarSolicitudes()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Using CMd As New SqlCommand
            Cn.Open()
            Try
                With CMd
                    .CommandText = "Sp_MostrarTodoSolicitud"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn
                End With

                Dim VerSolicitudes As SqlDataReader
                VerSolicitudes = CMd.ExecuteReader()

                LsvSolicitudes.Items.Clear()
                While VerSolicitudes.Read = True
                    With LsvSolicitudes.Items.Add(VerSolicitudes("NumSolicitud").ToString)
                        .SubItems.Add(VerSolicitudes("FechaSolicitud").ToString)
                        .SubItems.Add(VerSolicitudes("TipoPrestamo").ToString)
                        .SubItems.Add(VerSolicitudes("CodSocio").ToString)
                        .SubItems.Add(VerSolicitudes("PlazoPago").ToString)
                        .SubItems.Add(VerSolicitudes("Finalidad").ToString)
                        .SubItems.Add(VerSolicitudes("TasaInteres").ToString)
                        .SubItems.Add(VerSolicitudes("SumaOtorgada").ToString)
                        .SubItems.Add(VerSolicitudes("CodOficial").ToString)
                        .SubItems.Add(VerSolicitudes("EstadoPrestamo").ToString)
                    End With
                End While
            Catch ex As Exception
                MessageBox.Show("Error al Mostrar las Solicitudes" + ex.Message, "CooperativaXyz", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Cn.Close()
            End Try
        End Using
    End Sub

    Private Sub GuardarSolicitud()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_InsertarSolicitudPrestamo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    .Parameters.Add("@FechaSolicitud", SqlDbType.Date).Value = DtpFechaSolicitud.Value.Date.ToShortDateString()
                    .Parameters.Add("@IdTipoPrestamo", SqlDbType.Int).Value = CInt(CboTipoPrestamo.SelectedValue)
                    .Parameters.Add("@CodSocio", SqlDbType.VarChar, 15).Value = TxtCodSocio.Text
                    .Parameters.Add("@PlazoPago", SqlDbType.Int).Value = TxtPlazoPago.Text
                    .Parameters.Add("@IdFinalidadPrestamo", SqlDbType.Int).Value = CInt(CboFinalidadPrestamo.SelectedValue)
                    .Parameters.Add("@TasaInteres", SqlDbType.NVarChar, 7).Value = TxtTasaInteres.Text
                    .Parameters.Add("@SumaOtorgada", SqlDbType.NVarChar, 10).Value = TxtSumaOtorgada.Text
                    .Parameters.Add("@CodOficial", SqlDbType.NVarChar, 11).Value = TxtCodigoOficial.Text
                    .Parameters.Add("@IdEstadoPrestamo", SqlDbType.Int).Value = CInt(CboEstadoPrestamo.SelectedValue)
                    .ExecuteNonQuery()

                    MessageBox.Show("Registro realizado Satisfactoriamente", "CooperativaXyz", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End With
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al insertar los datos de la Solicitud" + ex.Message, "CooperativaXyz", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()
        End Try
    End Sub

    Private Sub LlenarComboTipoPrestamo()
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

                Dim Da As New SqlDataAdapter(CMd)
                Dim Ds As New DataSet

                Da.Fill(Ds, "TipoPrestamo")
                CboTipoPrestamo.DataSource = Ds.Tables(0)

                CboTipoPrestamo.DisplayMember = Ds.Tables(0).Columns("TipoPrestamo").ToString
                CboTipoPrestamo.ValueMember = Ds.Tables(0).Columns("IdTipoPrestamo").ToString

            Catch ex As Exception
                MessageBox.Show("Error al Mostrar los datos del tipo de prestamo" + ex.Message, "CooperativaXyz", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Cn.Close()
            End Try
        End Using
    End Sub

    Private Sub LlenarComboFinalidadaPrestamo()
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

                Dim Da As New SqlDataAdapter(CMd)
                Dim Ds As New DataSet

                Da.Fill(Ds, "FinalidadPrestamo")
                CboFinalidadPrestamo.DataSource = Ds.Tables(0)

                CboFinalidadPrestamo.DisplayMember = Ds.Tables(0).Columns("Finalidad").ToString
                CboFinalidadPrestamo.ValueMember = Ds.Tables(0).Columns("IdFinalidadPrestamo").ToString

            Catch ex As Exception
                MessageBox.Show("Error al Mostrar los datos de la Finalidad del prestamo" + ex.Message, "CooperativaXyz", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Cn.Close()
            End Try
        End Using
    End Sub

    Private Sub LlenarComboEstadoPrestamo()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Using CMd As New SqlCommand
            Cn.Open()
            Try
                With CMd
                    .CommandText = "Sp_MostrarEstadoSolicitudPrestamo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn
                End With

                Dim Da As New SqlDataAdapter(CMd)
                Dim Ds As New DataSet

                Da.Fill(Ds, "EstadoSolicitudPrestamo")
                CboEstadoPrestamo.DataSource = Ds.Tables(0)

                CboEstadoPrestamo.DisplayMember = Ds.Tables(0).Columns("EstadoPrestamo").ToString
                CboEstadoPrestamo.ValueMember = Ds.Tables(0).Columns("IdEstadoPrestamo").ToString

            Catch ex As Exception
                MessageBox.Show("Error al Mostrar los datos del estado del prestamo" + ex.Message, "CooperativaXyz", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Cn.Close()
            End Try
        End Using
    End Sub

    Private Sub ActualizarSolicitud()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Using CMd As New SqlCommand
            Cn.Open()
            Try
                With CMd
                    .CommandText = "Sp_ActualizarSolicitudPrestamo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    .Parameters.Add("@NumSolicitud", SqlDbType.Int).Value = TxtNumSolicitud.Text
                    .Parameters.Add("@FechaSolicitud", SqlDbType.Date).Value = DtpFechaSolicitud.Value.Date.ToShortDateString()
                    .Parameters.Add("@IdTipoPrestamo", SqlDbType.Int).Value = CInt(CboTipoPrestamo.SelectedValue)
                    .Parameters.Add("@CodSocio", SqlDbType.VarChar, 15).Value = TxtCodSocio.Text
                    .Parameters.Add("@PlazoPago", SqlDbType.Int).Value = TxtPlazoPago.Text
                    .Parameters.Add("@IdFinalidadPrestamo", SqlDbType.Int).Value = CInt(CboFinalidadPrestamo.SelectedValue)
                    .Parameters.Add("@TasaInteres", SqlDbType.NVarChar, 7).Value = TxtTasaInteres.Text
                    .Parameters.Add("@SumaOtorgada", SqlDbType.NVarChar, 10).Value = TxtSumaOtorgada.Text
                    .Parameters.Add("@CodOficial", SqlDbType.NVarChar, 11).Value = TxtCodigoOficial.Text
                    .Parameters.Add("@IdEstadoPrestamo", SqlDbType.Int).Value = CInt(CboEstadoPrestamo.SelectedValue)
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

    Private Sub EliminarSolicitud()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_EliminarSolicitudPrestamo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn


                    Dim Id As Integer
                    Id = CInt(LsvSolicitudes.FocusedItem.SubItems(0).Text)
                    .Parameters.Add("@NumSolicitud", SqlDbType.Int).Value = Id
                    .ExecuteNonQuery()

                    MessageBox.Show("Registro Eliminado Satisfactoriamente", "CooperativaXyz", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End With
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al elimnar el Artista", "CooperativaXyz", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()
        End Try
    End Sub

    Private Sub BuscarSolicitudPorCodigoOficial()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Using CMd As New SqlCommand
            Cn.Open()
            Try
                With CMd
                    .CommandText = "Sp_BuscarSolicitudPorCodigoOficial"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    .Parameters.Add("@CodOficial", SqlDbType.NVarChar, 11).Value = TxtBuscarporCodOficial.Text
                End With

                Dim VerSolicitudes As SqlDataReader
                VerSolicitudes = CMd.ExecuteReader()

                LsvSolicitudes.Items.Clear()
                While VerSolicitudes.Read = True
                    With LsvSolicitudes.Items.Add(VerSolicitudes("NumSolicitud").ToString)
                        .SubItems.Add(VerSolicitudes("FechaSolicitud").ToString)
                        .SubItems.Add(VerSolicitudes("TipoPrestamo").ToString)
                        .SubItems.Add(VerSolicitudes("CodSocio").ToString)
                        .SubItems.Add(VerSolicitudes("PlazoPago").ToString)
                        .SubItems.Add(VerSolicitudes("Finalidad").ToString)
                        .SubItems.Add(VerSolicitudes("TasaInteres").ToString)
                        .SubItems.Add(VerSolicitudes("SumaOtorgada").ToString)
                        .SubItems.Add(VerSolicitudes("CodOficial").ToString)
                        .SubItems.Add(VerSolicitudes("EstadoPrestamo").ToString)
                    End With
                End While

            Catch ex As Exception
                MessageBox.Show("Error al Mostrar los datos", "CooperativaXyz", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Cn.Close()
            End Try
        End Using
    End Sub

    Private Sub BuscarSolicitudPorCodigoSocio()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Using CMd As New SqlCommand
            Cn.Open()
            Try
                With CMd
                    .CommandText = "Sp_BuscarSolicitudPorCodigoSocio"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    .Parameters.Add("@CodSocio", SqlDbType.NVarChar, 15).Value = TxtBuscarporSocio.Text
                End With

                Dim VerSolicitudes As SqlDataReader
                VerSolicitudes = CMd.ExecuteReader()

                LsvSolicitudes.Items.Clear()
                While VerSolicitudes.Read = True
                    With LsvSolicitudes.Items.Add(VerSolicitudes("NumSolicitud").ToString)
                        .SubItems.Add(VerSolicitudes("FechaSolicitud").ToString)
                        .SubItems.Add(VerSolicitudes("TipoPrestamo").ToString)
                        .SubItems.Add(VerSolicitudes("CodSocio").ToString)
                        .SubItems.Add(VerSolicitudes("PlazoPago").ToString)
                        .SubItems.Add(VerSolicitudes("Finalidad").ToString)
                        .SubItems.Add(VerSolicitudes("TasaInteres").ToString)
                        .SubItems.Add(VerSolicitudes("SumaOtorgada").ToString)
                        .SubItems.Add(VerSolicitudes("CodOficial").ToString)
                        .SubItems.Add(VerSolicitudes("EstadoPrestamo").ToString)
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

        If TxtCodSocio.Text = Nothing And TxtCodigoOficial.Text = Nothing And CboFinalidadPrestamo.SelectedValue = -1 And TxtTasaInteres.Text = Nothing And TxtSumaOtorgada.Text = Nothing And TxtPlazoPago.Text = Nothing And CboEstadoPrestamo.SelectedValue = -1 And CboTipoPrestamo.SelectedValue = -1 Then
            EpMensaje.SetError(TxtCodSocio, "Ingre el Codigo del Socio")
            EpMensaje.SetError(TxtCodigoOficial, "Ingre el Codigo del Oficial de Credito")
            EpMensaje.SetError(CboFinalidadPrestamo, "Seleccione la Finalidad del Prestamo")
            EpMensaje.SetError(TxtTasaInteres, "Ingrese la Tasa de Interes")
            EpMensaje.SetError(TxtSumaOtorgada, "Ingrese la suma a Otorgar")
            EpMensaje.SetError(TxtPlazoPago, "Ingrese el plazo de pago")
            EpMensaje.SetError(CboEstadoPrestamo, "Seleccione el Estado de Prestamo")
            EpMensaje.SetError(CboTipoPrestamo, "Seleccione el Tipo de Prestamo")
            TxtCodSocio.BackColor = Color.LightBlue
            TxtCodigoOficial.BackColor = Color.LightBlue
            TxtTasaInteres.BackColor = Color.LightBlue
            TxtSumaOtorgada.BackColor = Color.LightBlue
            TxtPlazoPago.BackColor = Color.LightBlue
            CboFinalidadPrestamo.BackColor = Color.LightBlue
            CboEstadoPrestamo.BackColor = Color.LightBlue
            CboTipoPrestamo.BackColor = Color.LightBlue
            TxtCodSocio.Focus()
            Estado = False

        ElseIf TxtCodSocio.Text = Nothing Then
            EpMensaje.SetError(TxtCodSocio, "Ingre el Codigo del Socio")
            TxtCodSocio.BackColor = Color.LightBlue
            TxtCodSocio.Focus()
            Estado = False

        ElseIf TxtCodigoOficial.Text = Nothing Then
            EpMensaje.SetError(TxtCodigoOficial, "Ingre el Codigo del Oficial de Credito")
            TxtCodigoOficial.BackColor = Color.LightBlue
            TxtCodigoOficial.Focus()
            Estado = False

        ElseIf CboFinalidadPrestamo.SelectedValue = -1 Then
            EpMensaje.SetError(CboFinalidadPrestamo, "Seleccione la Finalidad del Prestamo")
            CboFinalidadPrestamo.BackColor = Color.LightBlue
            Estado = False

        ElseIf CboEstadoPrestamo.SelectedValue = -1 Then
            EpMensaje.SetError(CboEstadoPrestamo, "Seleccione el estado del prestamo")
            CboEstadoPrestamo.BackColor = Color.LightBlue
            Estado = False

        ElseIf CboTipoPrestamo.SelectedValue = -1 Then
            EpMensaje.SetError(CboTipoPrestamo, "Seleccione el tipo de prestamo")
            CboEstadoPrestamo.BackColor = Color.LightBlue
            Estado = False

        ElseIf TxtTasaInteres.Text = Nothing Then
            EpMensaje.SetError(TxtTasaInteres, "Ingrese la Tasa de Interes")
            TxtTasaInteres.BackColor = Color.LightBlue
            TxtTasaInteres.Focus()
            Estado = False

        ElseIf TxtSumaOtorgada.Text = Nothing Then
            EpMensaje.SetError(TxtSumaOtorgada, "Ingrese la suma a Otorgar")
            TxtSumaOtorgada.BackColor = Color.LightBlue
            TxtSumaOtorgada.Focus()
            Estado = False

        ElseIf TxtPlazoPago.Text = Nothing Then
            EpMensaje.SetError(TxtPlazoPago, "Ingrese el plazo de pago")
            TxtPlazoPago.BackColor = Color.LightBlue
            TxtPlazoPago.Focus()
            Estado = False

        Else
            Estado = True
        End If
        Return Estado
    End Function

    Private Sub RdbBuscarporCodOficial_CheckedChanged(sender As Object, e As EventArgs) Handles RdbBuscarporCodOficial.CheckedChanged
        BtnBuscarPorSocio.Visible = False
        TxtBuscarporSocio.Visible = False
        TxtBuscarporCodOficial.Visible = True
    End Sub

    Private Sub BtnBuscar_Click_1(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        BuscarSolicitudPorCodigoOficial()
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscarPorSocio.Click
        BuscarSolicitudPorCodigoSocio()
    End Sub

    Private Sub RdbBuscarporCodSocio_CheckedChanged(sender As Object, e As EventArgs) Handles RdbBuscarporCodSocio.CheckedChanged
        BtnBuscar.Visible = False
        TxtBuscarporSocio.Visible = True
        TxtBuscarporCodOficial.Visible = False
    End Sub


    Private Sub Limpiar()
        TxtNumSolicitud.Text = Nothing
        TxtPlazoPago.Text = Nothing
        TxtSumaOtorgada.Text = Nothing
        TxtCodigoOficial.Text = Nothing
        TxtTasaInteres.Text = Nothing
        TxtCodSocio.Text = Nothing
        CboEstadoPrestamo.Text = "--Seleccione--"
        CboFinalidadPrestamo.Text = "--Seleccione--"
        CboTipoPrestamo.Text = "--Seleccione--"
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

    Private Sub FrmSolicitudPrestamo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarSolicitudes()
        LlenarComboEstadoPrestamo()
        LlenarComboFinalidadaPrestamo()
        LlenarComboTipoPrestamo()
        BtnAvales.Visible = False
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        HabilitarBotones(False, True, False, True, True)
        InvestigarCorrelativoSolicitudPrestamo()
        MostrarSolicitudes()
        LlenarComboEstadoPrestamo()
        LlenarComboFinalidadaPrestamo()
        LlenarComboTipoPrestamo()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If ValidarTextBox() = True Then
            HabilitarBotones(True, False, False, False, True)
            GuardarSolicitud()
            MostrarSolicitudes()
            Limpiar()
            BtnAvales.Visible = True
        End If
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        HabilitarBotones(False, False, True, True, True)
        TxtNumSolicitud.Text = LsvSolicitudes.FocusedItem.SubItems(0).Text
        DtpFechaSolicitud.Text = LsvSolicitudes.FocusedItem.SubItems(1).Text
        CboTipoPrestamo.Text = LsvSolicitudes.FocusedItem.SubItems(2).Text
        TxtCodSocio.Text = LsvSolicitudes.FocusedItem.SubItems(3).Text
        TxtPlazoPago.Text = LsvSolicitudes.FocusedItem.SubItems(4).Text
        CboFinalidadPrestamo.Text = LsvSolicitudes.FocusedItem.SubItems(5).Text
        TxtTasaInteres.Text = LsvSolicitudes.FocusedItem.SubItems(6).Text
        TxtSumaOtorgada.Text = LsvSolicitudes.FocusedItem.SubItems(7).Text
        TxtCodigoOficial.Text = LsvSolicitudes.FocusedItem.SubItems(8).Text
        CboEstadoPrestamo.Text = LsvSolicitudes.FocusedItem.SubItems(9).Text

        TbMenu.SelectedIndex = 0
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        If ValidarTextBox() = True Then
            HabilitarBotones(True, False, False, True, True)
            ActualizarSolicitud()
            MostrarSolicitudes()
            BtnAvales.Visible = True


            TbMenu.SelectedIndex = 1
        End If
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        EliminarSolicitud()
        MostrarSolicitudes()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        HabilitarBotones(True, False, False, False, True)
        Limpiar()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Close()
    End Sub

    Private Sub BtnSeleccionarSocio_Click(sender As Object, e As EventArgs) Handles BtnSeleccionarSocio.Click
        FrmSocio.ShowDialog()
    End Sub

    Private Sub BtnSeleccionarOficial_Click(sender As Object, e As EventArgs) Handles BtnSeleccionarOficial.Click
        FrmOficialSocio.ShowDialog()
    End Sub

    Private Sub BtnAvales_Click(sender As Object, e As EventArgs) Handles BtnAvales.Click

        FrmAvales.TxtNumSolicitus.Text = LsvSolicitudes.FocusedItem.SubItems(0).Text
        FrmAvales.TxtMostrarPrestamo.Text = LsvSolicitudes.FocusedItem.SubItems(2).Text

        FrmAvales.ShowDialog()


    End Sub
End Class