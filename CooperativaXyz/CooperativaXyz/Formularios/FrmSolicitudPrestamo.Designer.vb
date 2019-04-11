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
        Me.TxtTasaInteres = New System.Windows.Forms.TextBox()
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
        Me.CboEstadoPrestamo = New System.Windows.Forms.ComboBox()
        Me.CboTipoPrestamo = New System.Windows.Forms.ComboBox()
        Me.CboFinalidadPrestamo = New System.Windows.Forms.ComboBox()
        Me.BtnAvales = New System.Windows.Forms.Button()
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
        Me.TbDatosOficial.Location = New System.Drawing.Point(5, 130)
        Me.TbDatosOficial.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TbDatosOficial.Name = "TbDatosOficial"
        Me.TbDatosOficial.SelectedIndex = 0
        Me.TbDatosOficial.Size = New System.Drawing.Size(1107, 423)
        Me.TbDatosOficial.TabIndex = 13
        '
        'TbDatosSolicitud
        '
        Me.TbDatosSolicitud.Controls.Add(Me.Panel2)
        Me.TbDatosSolicitud.Controls.Add(Me.GroupBox1)
        Me.TbDatosSolicitud.Location = New System.Drawing.Point(4, 25)
        Me.TbDatosSolicitud.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TbDatosSolicitud.Name = "TbDatosSolicitud"
        Me.TbDatosSolicitud.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TbDatosSolicitud.Size = New System.Drawing.Size(1099, 394)
        Me.TbDatosSolicitud.TabIndex = 0
        Me.TbDatosSolicitud.Text = "Datos Solicitud"
        Me.TbDatosSolicitud.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel2.Controls.Add(Me.BtnAvales)
        Me.Panel2.Controls.Add(Me.CboFinalidadPrestamo)
        Me.Panel2.Controls.Add(Me.CboTipoPrestamo)
        Me.Panel2.Controls.Add(Me.CboEstadoPrestamo)
        Me.Panel2.Controls.Add(Me.TxtPlazoPago)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.TxtFechaSolicitud)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.TxtCodigoOficial)
        Me.Panel2.Controls.Add(Me.TxtSumaOtorgada)
        Me.Panel2.Controls.Add(Me.TxtTasaInteres)
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
        Me.Panel2.Location = New System.Drawing.Point(12, 4)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1071, 289)
        Me.Panel2.TabIndex = 15
        '
        'TxtPlazoPago
        '
        Me.TxtPlazoPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPlazoPago.Location = New System.Drawing.Point(799, 61)
        Me.TxtPlazoPago.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtPlazoPago.Multiline = True
        Me.TxtPlazoPago.Name = "TxtPlazoPago"
        Me.TxtPlazoPago.Size = New System.Drawing.Size(144, 24)
        Me.TxtPlazoPago.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(595, 61)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 23)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Plazo de Pago"
        '
        'TxtFechaSolicitud
        '
        Me.TxtFechaSolicitud.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFechaSolicitud.Location = New System.Drawing.Point(239, 148)
        Me.TxtFechaSolicitud.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtFechaSolicitud.Multiline = True
        Me.TxtFechaSolicitud.Name = "TxtFechaSolicitud"
        Me.TxtFechaSolicitud.Size = New System.Drawing.Size(160, 27)
        Me.TxtFechaSolicitud.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Location = New System.Drawing.Point(23, 152)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(181, 23)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Fecha de Solicitud"
        '
        'TxtCodigoOficial
        '
        Me.TxtCodigoOficial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodigoOficial.Location = New System.Drawing.Point(239, 105)
        Me.TxtCodigoOficial.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtCodigoOficial.Multiline = True
        Me.TxtCodigoOficial.Name = "TxtCodigoOficial"
        Me.TxtCodigoOficial.Size = New System.Drawing.Size(160, 24)
        Me.TxtCodigoOficial.TabIndex = 26
        '
        'TxtSumaOtorgada
        '
        Me.TxtSumaOtorgada.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSumaOtorgada.Location = New System.Drawing.Point(799, 14)
        Me.TxtSumaOtorgada.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtSumaOtorgada.Multiline = True
        Me.TxtSumaOtorgada.Name = "TxtSumaOtorgada"
        Me.TxtSumaOtorgada.Size = New System.Drawing.Size(144, 24)
        Me.TxtSumaOtorgada.TabIndex = 25
        '
        'TxtTasaInteres
        '
        Me.TxtTasaInteres.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTasaInteres.Location = New System.Drawing.Point(239, 236)
        Me.TxtTasaInteres.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTasaInteres.Multiline = True
        Me.TxtTasaInteres.Name = "TxtTasaInteres"
        Me.TxtTasaInteres.Size = New System.Drawing.Size(144, 23)
        Me.TxtTasaInteres.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label10.Location = New System.Drawing.Point(587, 111)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(171, 23)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = " Estado Préstamo"
        '
        'TxtCodSocio
        '
        Me.TxtCodSocio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodSocio.Location = New System.Drawing.Point(239, 62)
        Me.TxtCodSocio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtCodSocio.Multiline = True
        Me.TxtCodSocio.Name = "TxtCodSocio"
        Me.TxtCodSocio.Size = New System.Drawing.Size(160, 24)
        Me.TxtCodSocio.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label9.Location = New System.Drawing.Point(23, 109)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(146, 23)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Código Oficial"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label7.Location = New System.Drawing.Point(48, 240)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(156, 23)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Tasa de Interes"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label11.Location = New System.Drawing.Point(595, 155)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(146, 23)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Tipo Préstamo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label8.Location = New System.Drawing.Point(595, 14)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(160, 23)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Suma Otorgada"
        '
        'TxtNumSolicitud
        '
        Me.TxtNumSolicitud.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNumSolicitud.Location = New System.Drawing.Point(239, 14)
        Me.TxtNumSolicitud.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtNumSolicitud.Multiline = True
        Me.TxtNumSolicitud.Name = "TxtNumSolicitud"
        Me.TxtNumSolicitud.Size = New System.Drawing.Size(160, 24)
        Me.TxtNumSolicitud.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label6.Location = New System.Drawing.Point(21, 199)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(193, 23)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Finalidad Préstamo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label4.Location = New System.Drawing.Point(21, 62)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 23)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Código Socio"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label12.Location = New System.Drawing.Point(23, 14)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(199, 23)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Número de solicitud"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnSalir)
        Me.GroupBox1.Controls.Add(Me.BtnCancelar)
        Me.GroupBox1.Controls.Add(Me.BtnModificar)
        Me.GroupBox1.Controls.Add(Me.BtnGuardar)
        Me.GroupBox1.Controls.Add(Me.BtnNuevo)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 292)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(1071, 92)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BtnSalir.Location = New System.Drawing.Point(882, 22)
        Me.BtnSalir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(100, 62)
        Me.BtnSalir.TabIndex = 4
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BtnCancelar.Location = New System.Drawing.Point(681, 22)
        Me.BtnCancelar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(100, 62)
        Me.BtnCancelar.TabIndex = 3
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'BtnModificar
        '
        Me.BtnModificar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BtnModificar.Location = New System.Drawing.Point(482, 22)
        Me.BtnModificar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(100, 62)
        Me.BtnModificar.TabIndex = 2
        Me.BtnModificar.UseVisualStyleBackColor = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BtnGuardar.Location = New System.Drawing.Point(260, 22)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(100, 62)
        Me.BtnGuardar.TabIndex = 1
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BtnNuevo.Location = New System.Drawing.Point(56, 22)
        Me.BtnNuevo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(100, 62)
        Me.BtnNuevo.TabIndex = 0
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'TbListadoSolicitudes
        '
        Me.TbListadoSolicitudes.Controls.Add(Me.ListView1)
        Me.TbListadoSolicitudes.Controls.Add(Me.TxtBuscarSolicitud)
        Me.TbListadoSolicitudes.Controls.Add(Me.Label5)
        Me.TbListadoSolicitudes.Location = New System.Drawing.Point(4, 25)
        Me.TbListadoSolicitudes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TbListadoSolicitudes.Name = "TbListadoSolicitudes"
        Me.TbListadoSolicitudes.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TbListadoSolicitudes.Size = New System.Drawing.Size(1099, 394)
        Me.TbListadoSolicitudes.TabIndex = 1
        Me.TbListadoSolicitudes.Text = "Listado"
        Me.TbListadoSolicitudes.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ChNumSolicitud, Me.ChFechaSolicitud, Me.ChTipoPrestamo, Me.ChCodigoSocio, Me.ChPlazoPago, Me.ChFinalidadPrestamo, Me.ChTasaInteres, Me.ChSumaOtorgada, Me.ChCodOficial, Me.ChEstadoPrestamo})
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(8, 100)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1073, 262)
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
        Me.TxtBuscarSolicitud.Location = New System.Drawing.Point(372, 37)
        Me.TxtBuscarSolicitud.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtBuscarSolicitud.Name = "TxtBuscarSolicitud"
        Me.TxtBuscarSolicitud.Size = New System.Drawing.Size(361, 22)
        Me.TxtBuscarSolicitud.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(233, 43)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 19)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Buscar"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(-4, -1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1116, 123)
        Me.Panel1.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Bright", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MintCream
        Me.Label3.Location = New System.Drawing.Point(353, 31)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(431, 51)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Solicitud Préstamo"
        '
        'CboEstadoPrestamo
        '
        Me.CboEstadoPrestamo.FormattingEnabled = True
        Me.CboEstadoPrestamo.Location = New System.Drawing.Point(799, 104)
        Me.CboEstadoPrestamo.Name = "CboEstadoPrestamo"
        Me.CboEstadoPrestamo.Size = New System.Drawing.Size(121, 24)
        Me.CboEstadoPrestamo.TabIndex = 31
        '
        'CboTipoPrestamo
        '
        Me.CboTipoPrestamo.FormattingEnabled = True
        Me.CboTipoPrestamo.Location = New System.Drawing.Point(799, 151)
        Me.CboTipoPrestamo.Name = "CboTipoPrestamo"
        Me.CboTipoPrestamo.Size = New System.Drawing.Size(170, 24)
        Me.CboTipoPrestamo.TabIndex = 32
        '
        'CboFinalidadPrestamo
        '
        Me.CboFinalidadPrestamo.FormattingEnabled = True
        Me.CboFinalidadPrestamo.Location = New System.Drawing.Point(239, 195)
        Me.CboFinalidadPrestamo.Name = "CboFinalidadPrestamo"
        Me.CboFinalidadPrestamo.Size = New System.Drawing.Size(160, 24)
        Me.CboFinalidadPrestamo.TabIndex = 33
        '
        'BtnAvales
        '
        Me.BtnAvales.BackColor = System.Drawing.Color.Teal
        Me.BtnAvales.Font = New System.Drawing.Font("Lucida Bright", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAvales.Location = New System.Drawing.Point(799, 212)
        Me.BtnAvales.Name = "BtnAvales"
        Me.BtnAvales.Size = New System.Drawing.Size(152, 47)
        Me.BtnAvales.TabIndex = 34
        Me.BtnAvales.Text = "Avales"
        Me.BtnAvales.UseVisualStyleBackColor = False
        '
        'FrmSolicitudPrestamo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1115, 554)
        Me.Controls.Add(Me.TbDatosOficial)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
    Friend WithEvents TxtTasaInteres As TextBox
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
    Friend WithEvents CboTipoPrestamo As ComboBox
    Friend WithEvents CboEstadoPrestamo As ComboBox
    Friend WithEvents CboFinalidadPrestamo As ComboBox
    Friend WithEvents BtnAvales As Button
End Class
