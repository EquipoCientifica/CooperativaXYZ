Imports System.Data.SqlClient
Public Class FrmCuentaSocio
    Private Sub BtnFiltrar_Click(sender As Object, e As EventArgs) Handles BtnFiltrar.Click
        FrmBuscarSocio.ShowDialog()

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Close()
    End Sub
    Private Sub HabilitarBotones(ByVal Nuevo As Boolean, ByVal Guardar As Boolean, ByVal Modificar As Boolean, ByVal Cancelar As Boolean)
        BtnNuevo.Enabled = Nuevo
        BtnGuardar.Enabled = Guardar
        BtnModificar.Enabled = Modificar
        BtnCancelar.Enabled = Cancelar

    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        HabilitarBotones(False, True, False, True)
        InvestigarCorrelativoTipoCuentaSocio()
        LlenarComboTipoCuenta()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        If ValidarTextBox() = True Then

            HabilitarBotones(True, False, False, False)
            GuardarCuentaSocio()
            MostrarTodo()
            Limpiar()
        End If
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        HabilitarBotones(True, False, False, False)
        ActualizarCuentaSocio()
        Limpiar()
        MostrarTodo()

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        HabilitarBotones(True, False, False, False)
        MostrarTodo()
        Limpiar()

    End Sub
    Public Sub InvestigarCorrelativoTipoCuentaSocio()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If


        Try
            Dim ListaTipoCuentasocio As New SqlCommand("Sp_InvestigarCorrelativoCuentaSocio", Cn)
            ListaTipoCuentasocio.CommandType = CommandType.StoredProcedure

            Dim ListarTipoCuentaSocio1 As SqlDataReader
            Cn.Open()

            ListarTipoCuentaSocio1 = ListaTipoCuentasocio.ExecuteReader
            If ListarTipoCuentaSocio1.Read = True Then
                If ListarTipoCuentaSocio1("NumCuenta") Is DBNull.Value Then
                    TxtNumCuenta.Text = 1

                Else
                    TxtNumCuenta.Text = ListarTipoCuentaSocio1("NumCuenta").ToString

                End If

            End If

        Catch ex As Exception
            MessageBox.Show("Error de conexión a la base de datos" + ex.Message, "CooperativaXYZ", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            Cn.Close()
        End Try

    End Sub
    Private Sub LlenarComboTipoCuenta()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Using CMd As New SqlCommand
            Cn.Open()
            Try
                With CMd
                    .CommandText = "Sp_MostraTipoCuenta"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn
                End With

                Dim Da As New SqlDataAdapter(CMd)
                Dim Ds As New DataSet

                Da.Fill(Ds, "TipoCuenta")
                CboTipoCuenta.DataSource = Ds.Tables(0)

                CboTipoCuenta.DisplayMember = Ds.Tables(0).Columns("TipoCuenta").ToString
                CboTipoCuenta.ValueMember = Ds.Tables(0).Columns("IdTipoCuenta").ToString

            Catch ex As Exception
                MessageBox.Show("Error al Mostrar los datos de tipo cuenta" + ex.Message, "CooperativaXyz", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
                    .CommandText = "Sp_MostrarcuentaSocio"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                End With
                Dim VerTipoCuentaSocio As SqlDataReader
                VerTipoCuentaSocio = CMd.ExecuteReader()

                LsvCuentaSocio.Items.Clear()
                While VerTipoCuentaSocio.Read = True
                    With LsvCuentaSocio.Items.Add(VerTipoCuentaSocio("NumCuenta").ToString)
                        .SubItems.Add(VerTipoCuentaSocio("CodSocio").ToString)
                        .SubItems.Add(VerTipoCuentaSocio("TipoCuenta").ToString)
                        .SubItems.Add(VerTipoCuentaSocio("SaldoActual").ToString)
                        .SubItems.Add(VerTipoCuentaSocio("FechaApertura").ToString)

                    End With

                End While

            Catch ex As Exception
                MessageBox.Show("Error al consultar los datos." + ex.Message, "CooperativaXYZ", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Finally
                Cn.Close()
            End Try
        End Using

    End Sub
    Private Sub GuardarCuentaSocio()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_InsertarCuentaSocio"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    .Parameters.Add("@CodSocio", SqlDbType.VarChar, 15).Value = TxtCodSocio.Text
                    .Parameters.Add("@IdTipoCuenta ", SqlDbType.Int).Value = CInt(CboTipoCuenta.SelectedValue)
                    .Parameters.Add("@SaldoActual ", SqlDbType.NVarChar, 10).Value = TxtSaldoActual.Text
                    .Parameters.Add("@FechaApertura ", SqlDbType.Date).Value = DtpFechaApertura.Value.ToShortDateString

                    .ExecuteNonQuery()

                    MessageBox.Show("Registro realizado satisfactoriamente.", "CooperativaXYZ", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End With
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al insertar cuenta socio." + ex.Message, "CooperativaXYZ", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            Cn.Close()
        End Try

    End Sub

    Private Sub FrmCuentaSocio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarTodo()
    End Sub
    Private Sub Limpiar()
        TxtNumCuenta.Clear()
        TxtCodSocio.Clear()
        TxtSaldoActual.Clear()
        CboTipoCuenta.Text = Nothing
        EpMensaje.SetError(BtnFiltrar, "")
        EpMensaje.SetError(TxtSaldoActual, "")
    End Sub
    Private Sub ActualizarCuentaSocio()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Using CMd As New SqlCommand
            Cn.Open()
            Try
                With CMd
                    .CommandText = "Sp_ActualizarCuentaSocio"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    .Parameters.Add("@NumCuenta", SqlDbType.NVarChar, 15).Value = TxtNumCuenta.Text
                    .Parameters.Add("@CodSocio", SqlDbType.VarChar, 15).Value = TxtCodSocio.Text
                    .Parameters.Add("@IdTipoCuenta", SqlDbType.Int).Value = CInt(CboTipoCuenta.SelectedValue)
                    .Parameters.Add("@SaldoActual", SqlDbType.NVarChar, 10).Value = TxtSaldoActual.Text
                    .Parameters.Add("@FechaApertura", SqlDbType.Date).Value = DtpFechaApertura.Value.ToShortDateString
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

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        TxtNumCuenta.Text = LsvCuentaSocio.FocusedItem.SubItems(0).Text
        TxtCodSocio.Text = LsvCuentaSocio.FocusedItem.SubItems(1).Text
        CboTipoCuenta.Text = LsvCuentaSocio.FocusedItem.SubItems(2).Text
        TxtSaldoActual.Text = LsvCuentaSocio.FocusedItem.SubItems(3).Text
        DtpFechaApertura.Value = LsvCuentaSocio.FocusedItem.SubItems(4).Text
        HabilitarBotones(False, False, True, True)
        LlenarComboTipoCuenta()
        TcListadoCuentaSocio.SelectedIndex = 0
    End Sub

    Private Sub EliminarCuentaSocio()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_EliminarCuentaSocio"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn


                    Dim Id As Integer
                    Id = CInt(LsvCuentaSocio.FocusedItem.SubItems(0).Text)
                    .Parameters.Add("@NumCuenta", SqlDbType.Int).Value = Id
                    .ExecuteNonQuery()

                    MessageBox.Show("Registro Eliminado Satisfactoriamente", "CooperativaXyz", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End With
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al elimnar la cuenta socio" + ex.Message, "CooperativaXyz", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()
        End Try
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        EliminarCuentaSocio()
        MostrarTodo()
    End Sub
    Private Sub BuscarCuentaSocio()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Using CMd As New SqlCommand
            Cn.Open()
            Try
                With CMd
                    .CommandText = "SP_MostrarCuentaSociox"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    .Parameters.Add("@Busqueda", SqlDbType.NVarChar, 50).Value = TxtBuscarCuentaSocio.Text
                End With

                Dim VerCuentaSocio As SqlDataReader
                VerCuentaSocio = CMd.ExecuteReader()

                LsvCuentaSocio.Items.Clear()
                While VerCuentaSocio.Read = True
                    With LsvCuentaSocio.Items.Add(VerCuentaSocio("NumCuenta").ToString)
                        .SubItems.Add(VerCuentaSocio("CodSocio").ToString)
                        .SubItems.Add(VerCuentaSocio("TipoCuenta").ToString)
                        .SubItems.Add(VerCuentaSocio("SaldoActual").ToString)
                        .SubItems.Add(VerCuentaSocio("FechaApertura").ToString)
                    End With
                End While
            Catch ex As Exception
                MessageBox.Show("Error al Mostrar los datos" + ex.Message, "Cooperativa", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Cn.Close()
            End Try
        End Using
    End Sub

    Private Sub TxtBuscarCuentaSocio_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscarCuentaSocio.TextChanged
        BuscarCuentaSocio()
    End Sub
    Private Function ValidarTextBox()
        Dim estado As Boolean

        If TxtCodSocio.Text = Nothing And TxtSaldoActual.Text = Nothing Then
            EpMensaje.SetError(BtnFiltrar, "Debe seleccionar un codigo de socio")
            EpMensaje.SetError(TxtSaldoActual, "Debe ingresar el saldo actual")
            estado = False
        ElseIf TxtCodSocio.Text = Nothing Then

            EpMensaje.SetError(BtnFiltrar, "Debe seleccionar un codigo de socio")
            estado = False
        ElseIf TxtSaldoActual.Text = Nothing Then
            EpMensaje.SetError(TxtSaldoActual, "Debe ingresar el saldo actual")
            estado = False
        Else
            estado = True
            EpMensaje.SetError(BtnFiltrar, "")
            EpMensaje.SetError(TxtSaldoActual, "")
        End If


        Return estado
    End Function
End Class