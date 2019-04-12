Imports System.Data.SqlClient
Public Class FrmBuscarSocio
    Private Sub BtnSeleccionar1_Click(sender As Object, e As EventArgs) Handles BtnSeleccionar1.Click
        FrmCuentaSocio.TxtCodSocio.Text = LsvSocios1.FocusedItem.SubItems(0).Text
        Close()
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

                    .Parameters.Add("@NombreSocio", SqlDbType.NVarChar, 50).Value = TxtBuscar1.Text
                End With

                Dim VerSocios As SqlDataReader
                VerSocios = CMd.ExecuteReader()

                LsvSocios1.Items.Clear()
                While VerSocios.Read = True
                    With LsvSocios1.Items.Add(VerSocios("CodSocio").ToString)
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
                MessageBox.Show("Error al Mostrar los datos" + ex.Message, "CooperativaXyz", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Cn.Close()
            End Try
        End Using
    End Sub
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

                LsvSocios1.Items.Clear()
                While VerSocios.Read = True
                    With LsvSocios1.Items.Add(VerSocios("CodSocio").ToString)
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
                MessageBox.Show("Error al Mostrar los datos socios " + ex.Message, "CooperativaXyz", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Cn.Close()
            End Try
        End Using
    End Sub

    Private Sub FrmBuscarSocio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarSocios()
    End Sub

    Private Sub TxtBuscar1_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar1.TextChanged
        BuscarSocio()
    End Sub
End Class