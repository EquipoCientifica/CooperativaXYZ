<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSolicitudPrestamo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TbDatosOficial = New System.Windows.Forms.TabControl()
        Me.TbDatosSolicitud = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TxtPlazoPago = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtFechaSolicitud = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtCodigoOficial = New System.Windows.Forms.TextBox()
        Me.TxtSumaOtorgada = New System.Windows.Forms.TextBox()
        Me.TxtTipoPrestamo = New System.Windows.Forms.TextBox()
        Me.TxtTasaInteres = New System.Windows.Forms.TextBox()
        Me.TxtEstadoPrestamo = New System.Windows.Forms.TextBox()
        Me.CboFinalidadPrestamo = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtCodSocio = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtNumSolicitud = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.TbListadoSolicitudes = New System.Windows.Forms.TabPage()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ChNumSolicitud = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChFechaSolicitud = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChTipoPrestamo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChCodigoSocio = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChPlazoPago = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChFinalidadPrestamo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChTasaInteres = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChSumaOtorgada = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChCodOficial = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChEstadoPrestamo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TxtBuscarSolicitud = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TbDatosOficial.SuspendLayout()
        Me.TbDatosSolicitud.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TbListadoSolicitudes.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TbDatosOficial
        '
        Me.TbDatosOficial.Controls.Add(Me.TbDatosSolicitud)
        Me.TbDatosOficial.Controls.Add(Me.TbListadoSolicitudes)
        Me.TbDatosOficial.Location = New System.Drawing.Point(4, 106)
        Me.TbDatosOficial.Name = "TbDatosOficial"
        Me.TbDatosOficial.SelectedIndex = 0
        Me.TbDatosOficial.Size = New System.Drawing.Size(830, 344)
        Me.TbDatosOficial.TabIndex = 13
        '
        'TbDatosSolicitud
        '
        Me.TbDatosSolicitud.Controls.Add(Me.Panel2)
        Me.TbDatosSolicitud.Controls.Add(Me.GroupBox1)
        Me.TbDatosSolicitud.Location = New System.Drawing.Point(4, 22)
        Me.TbDatosSolicitud.Name = "TbDatosSolicitud"
        Me.TbDatosSolicitud.Padding = New System.Windows.Forms.Padding(3)
        Me.TbDatosSolicitud.Size = New System.Drawing.Size(822, 318)
        Me.TbDatosSolicitud.TabIndex = 0
        Me.TbDatosSolicitud.Text = "Datos Solicitud"
        Me.TbDatosSolicitud.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel2.Controls.Add(Me.TxtPlazoPago)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.TxtFechaSolicitud)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.TxtCodigoOficial)
        Me.Panel2.Controls.Add(Me.TxtSumaOtorgada)
        Me.Panel2.Controls.Add(Me.TxtTipoPrestamo)
        Me.Panel2.Controls.Add(Me.TxtTasaInteres)
        Me.Panel2.Controls.Add(Me.TxtEstadoPrestamo)
        Me.Panel2.Controls.Add(Me.CboFinalidadPrestamo)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.TxtCodSocio)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.TxtNumSolicitud)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(803, 212)
        Me.Panel2.TabIndex = 15
        '
        'TxtPlazoPago
        '
        Me.TxtPlazoPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPlazoPago.Location = New System.Drawing.Point(587, 89)
        Me.TxtPlazoPago.Multiline = True
        Me.TxtPlazoPago.Name = "TxtPlazoPago"
        Me.TxtPlazoPago.Size = New System.Drawing.Size(145, 22)
        Me.TxtPlazoPago.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(434, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 19)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Plazo de Pago"
        '
        'TxtFechaSolicitud
        '
        Me.TxtFechaSolicitud.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFechaSolicitud.Location = New System.Drawing.Point(176, 126)
        Me.TxtFechaSolicitud.Multiline = True
        Me.TxtFechaSolicitud.Name = "TxtFechaSolicitud"
        Me.TxtFechaSolicitud.Size = New System.Drawing.Size(121, 23)
        Me.TxtFechaSolicitud.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Location = New System.Drawing.Point(14, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 19)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Fecha de Solicitud"
        '
        'TxtCodigoOficial
        '
        Me.TxtCodigoOficial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodigoOficial.Location = New System.Drawing.Point(176, 91)
        Me.TxtCodigoOficial.Multiline = True
        Me.TxtCodigoOficial.Name = "TxtCodigoOficial"
        Me.TxtCodigoOficial.Size = New System.Drawing.Size(121, 20)
        Me.TxtCodigoOficial.TabIndex = 26
        '
        'TxtSumaOtorgada
        '
        Me.TxtSumaOtorgada.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSumaOtorgada.Location = New System.Drawing.Point(587, 50)
        Me.TxtSumaOtorgada.Multiline = True
        Me.TxtSumaOtorgada.Name = "TxtSumaOtorgada"
        Me.TxtSumaOtorgada.Size = New System.Drawing.Size(145, 23)
        Me.TxtSumaOtorgada.TabIndex = 25
        '
        'TxtTipoPrestamo
        '
        Me.TxtTipoPrestamo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTipoPrestamo.Location = New System.Drawing.Point(587, 164)
        Me.TxtTipoPrestamo.Multiline = True
        Me.TxtTipoPrestamo.Name = "TxtTipoPrestamo"
        Me.TxtTipoPrestamo.Size = New System.Drawing.Size(145, 20)
        Me.TxtTipoPrestamo.TabIndex = 24
        '
        'TxtTasaInteres
        '
        Me.TxtTasaInteres.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTasaInteres.Location = New System.Drawing.Point(587, 14)
        Me.TxtTasaInteres.Multiline = True
        Me.TxtTasaInteres.Name = "TxtTasaInteres"
        Me.TxtTasaInteres.Size = New System.Drawing.Size(108, 23)
        Me.TxtTasaInteres.TabIndex = 19
        '
        'TxtEstadoPrestamo
        '
        Me.TxtEstadoPrestamo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEstadoPrestamo.Location = New System.Drawing.Point(587, 129)
        Me.TxtEstadoPrestamo.Multiline = True
        Me.TxtEstadoPrestamo.Name = "TxtEstadoPrestamo"
        Me.TxtEstadoPrestamo.Size = New System.Drawing.Size(145, 20)
        Me.TxtEstadoPrestamo.TabIndex = 23
        '
        'CboFinalidadPrestamo
        '
        Me.CboFinalidadPrestamo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboFinalidadPrestamo.FormattingEnabled = True
        Me.CboFinalidadPrestamo.Location = New System.Drawing.Point(176, 164)
        Me.CboFinalidadPrestamo.Name = "CboFinalidadPrestamo"
        Me.CboFinalidadPrestamo.Size = New System.Drawing.Size(154, 28)
        Me.CboFinalidadPrestamo.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label10.Location = New System.Drawing.Point(428, 132)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(137, 19)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = " Estado Prestamo"
        '
        'TxtCodSocio
        '
        Me.TxtCodSocio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodSocio.Location = New System.Drawing.Point(176, 56)
        Me.TxtCodSocio.Multiline = True
        Me.TxtCodSocio.Name = "TxtCodSocio"
        Me.TxtCodSocio.Size = New System.Drawing.Size(121, 20)
        Me.TxtCodSocio.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label9.Location = New System.Drawing.Point(14, 94)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(114, 19)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Codigo Oficial"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label7.Location = New System.Drawing.Point(434, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(122, 19)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Tasa de Interes"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label11.Location = New System.Drawing.Point(434, 167)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(117, 19)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Tipo Prestamo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label8.Location = New System.Drawing.Point(434, 53)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(126, 19)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Suma Otorgada"
        '
        'TxtNumSolicitud
        '
        Me.TxtNumSolicitud.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNumSolicitud.Location = New System.Drawing.Point(176, 17)
        Me.TxtNumSolicitud.Multiline = True
        Me.TxtNumSolicitud.Name = "TxtNumSolicitud"
        Me.TxtNumSolicitud.Size = New System.Drawing.Size(154, 20)
        Me.TxtNumSolicitud.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label6.Location = New System.Drawing.Point(13, 167)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(151, 19)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Finalidad Prestamo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label4.Location = New System.Drawing.Point(13, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 19)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Codigo Socio"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label12.Location = New System.Drawing.Point(14, 17)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(158, 19)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Numero de solicitud"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnSalir)
        Me.GroupBox1.Controls.Add(Me.BtnCancelar)
        Me.GroupBox1.Controls.Add(Me.BtnModificar)
        Me.GroupBox1.Controls.Add(Me.BtnGuardar)
        Me.GroupBox1.Controls.Add(Me.BtnNuevo)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 218)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(803, 94)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BtnSalir.Location = New System.Drawing.Point(646, 28)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(75, 50)
        Me.BtnSalir.TabIndex = 4
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BtnCancelar.Location = New System.Drawing.Point(495, 28)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(75, 50)
        Me.BtnCancelar.TabIndex = 3
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'BtnModificar
        '
        Me.BtnModificar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BtnModificar.Location = New System.Drawing.Point(346, 28)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(75, 50)
        Me.BtnModificar.TabIndex = 2
        Me.BtnModificar.UseVisualStyleBackColor = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BtnGuardar.Location = New System.Drawing.Point(179, 28)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(75, 50)
        Me.BtnGuardar.TabIndex = 1
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BtnNuevo.Location = New System.Drawing.Point(26, 28)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(75, 50)
        Me.BtnNuevo.TabIndex = 0
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'TbListadoSolicitudes
        '
        Me.TbListadoSolicitudes.Controls.Add(Me.ListView1)
        Me.TbListadoSolicitudes.Controls.Add(Me.TxtBuscarSolicitud)
        Me.TbListadoSolicitudes.Controls.Add(Me.Label5)
        Me.TbListadoSolicitudes.Location = New System.Drawing.Point(4, 22)
        Me.TbListadoSolicitudes.Name = "TbListadoSolicitudes"
        Me.TbListadoSolicitudes.Padding = New System.Windows.Forms.Padding(3)
        Me.TbListadoSolicitudes.Size = New System.Drawing.Size(822, 318)
        Me.TbListadoSolicitudes.TabIndex = 1
        Me.TbListadoSolicitudes.Text = "Listado"
        Me.TbListadoSolicitudes.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ChNumSolicitud, Me.ChFechaSolicitud, Me.ChTipoPrestamo, Me.ChCodigoSocio, Me.ChPlazoPago, Me.ChFinalidadPrestamo, Me.ChTasaInteres, Me.ChSumaOtorgada, Me.ChCodOficial, Me.ChEstadoPrestamo})
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(6, 81)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(806, 214)
        Me.ListView1.TabIndex = 13
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ChNumSolicitud
        '
        Me.ChNumSolicitud.Text = "Numero de Solicitud"
        Me.ChNumSolicitud.Width = 108
        '
        'ChFechaSolicitud
        '
        Me.ChFechaSolicitud.Text = "Fecha de Solicitud"
        Me.ChFechaSolicitud.Width = 100
        '
        'ChTipoPrestamo
        '
        Me.ChTipoPrestamo.Text = "Tipo Prestamo"
        Me.ChTipoPrestamo.Width = 81
        '
        'ChCodigoSocio
        '
        Me.ChCodigoSocio.Text = "Codigo Socio"
        Me.ChCodigoSocio.Width = 77
        '
        'ChPlazoPago
        '
        Me.ChPlazoPago.Text = "Plazo de Pago"
        Me.ChPlazoPago.Width = 86
        '
        'ChFinalidadPrestamo
        '
        Me.ChFinalidadPrestamo.Text = "Finalidad de Prestamo"
        Me.ChFinalidadPrestamo.Width = 118
        '
        'ChTasaInteres
        '
        Me.ChTasaInteres.Text = "Tasa de Interes"
        Me.ChTasaInteres.Width = 89
        '
        'ChSumaOtorgada
        '
        Me.ChSumaOtorgada.Text = "Suma Otorgada"
        Me.ChSumaOtorgada.Width = 95
        '
        'ChCodOficial
        '
        Me.ChCodOficial.Text = "Codigo Oficial"
        Me.ChCodOficial.Width = 80
        '
        'ChEstadoPrestamo
        '
        Me.ChEstadoPrestamo.Text = "Estado Prestamo"
        Me.ChEstadoPrestamo.Width = 103
        '
        'TxtBuscarSolicitud
        '
        Me.TxtBuscarSolicitud.Location = New System.Drawing.Point(279, 30)
        Me.TxtBuscarSolicitud.Name = "TxtBuscarSolicitud"
        Me.TxtBuscarSolicitud.Size = New System.Drawing.Size(272, 20)
        Me.TxtBuscarSolicitud.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(175, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 15)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Buscar"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(-17, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(837, 100)
        Me.Panel1.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Bright", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MintCream
        Me.Label3.Location = New System.Drawing.Point(235, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(345, 40)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Solicitud Prestamo"
        '
        'FrmSolicitudPrestamo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(836, 450)
        Me.Controls.Add(Me.TbDatosOficial)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmSolicitudPrestamo"
        Me.Text = "FrmSolicitudPrestamo"
        Me.TbDatosOficial.ResumeLayout(False)
        Me.TbDatosSolicitud.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.TbListadoSolicitudes.ResumeLayout(False)
        Me.TbListadoSolicitudes.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TbDatosOficial As TabControl
    Friend WithEvents TbDatosSolicitud As TabPage
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TxtPlazoPago As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtFechaSolicitud As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtCodigoOficial As TextBox
    Friend WithEvents TxtSumaOtorgada As TextBox
    Friend WithEvents TxtTipoPrestamo As TextBox
    Friend WithEvents TxtTasaInteres As TextBox
    Friend WithEvents TxtEstadoPrestamo As TextBox
    Friend WithEvents CboFinalidadPrestamo As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtCodSocio As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtNumSolicitud As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents TbListadoSolicitudes As TabPage
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ChNumSolicitud As ColumnHeader
    Friend WithEvents ChFechaSolicitud As ColumnHeader
    Friend WithEvents ChTipoPrestamo As ColumnHeader
    Friend WithEvents ChCodigoSocio As ColumnHeader
    Friend WithEvents ChPlazoPago As ColumnHeader
    Friend WithEvents ChFinalidadPrestamo As ColumnHeader
    Friend WithEvents ChTasaInteres As ColumnHeader
    Friend WithEvents ChSumaOtorgada As ColumnHeader
    Friend WithEvents ChCodOficial As ColumnHeader
    Friend WithEvents ChEstadoPrestamo As ColumnHeader
    Friend WithEvents TxtBuscarSolicitud As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
End Class
