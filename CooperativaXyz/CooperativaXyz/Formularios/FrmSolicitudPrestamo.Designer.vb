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
        Me.components = New System.ComponentModel.Container()
        Me.TbMenu = New System.Windows.Forms.TabControl()
        Me.TbDatosSolicitud = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnSeleccionarOficial = New System.Windows.Forms.Button()
        Me.BtnSeleccionarSocio = New System.Windows.Forms.Button()
        Me.DtpFechaSolicitud = New System.Windows.Forms.DateTimePicker()
        Me.BtnAvales = New System.Windows.Forms.Button()
        Me.CboFinalidadPrestamo = New System.Windows.Forms.ComboBox()
        Me.CboTipoPrestamo = New System.Windows.Forms.ComboBox()
        Me.CboEstadoPrestamo = New System.Windows.Forms.ComboBox()
        Me.TxtPlazoPago = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.BtnBuscarPorSocio = New System.Windows.Forms.Button()
        Me.TxtBuscarporSocio = New System.Windows.Forms.TextBox()
        Me.TxtBuscarporCodOficial = New System.Windows.Forms.TextBox()
        Me.RdbBuscarporCodSocio = New System.Windows.Forms.RadioButton()
        Me.RdbBuscarporCodOficial = New System.Windows.Forms.RadioButton()
        Me.LsvSolicitudes = New System.Windows.Forms.ListView()
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
        Me.CmsOpciones = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.EpMensaje = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TbMenu.SuspendLayout()
        Me.TbDatosSolicitud.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TbListadoSolicitudes.SuspendLayout()
        Me.CmsOpciones.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.EpMensaje, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TbMenu
        '
        Me.TbMenu.Controls.Add(Me.TbDatosSolicitud)
        Me.TbMenu.Controls.Add(Me.TbListadoSolicitudes)
        Me.TbMenu.Location = New System.Drawing.Point(4, 106)
        Me.TbMenu.Name = "TbMenu"
        Me.TbMenu.SelectedIndex = 0
        Me.TbMenu.Size = New System.Drawing.Size(830, 344)
        Me.TbMenu.TabIndex = 13
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
        Me.Panel2.Controls.Add(Me.BtnSeleccionarOficial)
        Me.Panel2.Controls.Add(Me.BtnSeleccionarSocio)
        Me.Panel2.Controls.Add(Me.DtpFechaSolicitud)
        Me.Panel2.Controls.Add(Me.BtnAvales)
        Me.Panel2.Controls.Add(Me.CboFinalidadPrestamo)
        Me.Panel2.Controls.Add(Me.CboTipoPrestamo)
        Me.Panel2.Controls.Add(Me.CboEstadoPrestamo)
        Me.Panel2.Controls.Add(Me.TxtPlazoPago)
        Me.Panel2.Controls.Add(Me.Label1)
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
        Me.Panel2.Location = New System.Drawing.Point(9, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(803, 235)
        Me.Panel2.TabIndex = 15
        '
        'BtnSeleccionarOficial
        '
        Me.BtnSeleccionarOficial.Location = New System.Drawing.Point(323, 84)
        Me.BtnSeleccionarOficial.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSeleccionarOficial.Name = "BtnSeleccionarOficial"
        Me.BtnSeleccionarOficial.Size = New System.Drawing.Size(32, 23)
        Me.BtnSeleccionarOficial.TabIndex = 37
        Me.BtnSeleccionarOficial.Text = "..."
        Me.BtnSeleccionarOficial.UseVisualStyleBackColor = True
        '
        'BtnSeleccionarSocio
        '
        Me.BtnSeleccionarSocio.Location = New System.Drawing.Point(323, 50)
        Me.BtnSeleccionarSocio.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSeleccionarSocio.Name = "BtnSeleccionarSocio"
        Me.BtnSeleccionarSocio.Size = New System.Drawing.Size(32, 22)
        Me.BtnSeleccionarSocio.TabIndex = 36
        Me.BtnSeleccionarSocio.Text = "..."
        Me.BtnSeleccionarSocio.UseVisualStyleBackColor = True
        '
        'DtpFechaSolicitud
        '
        Me.DtpFechaSolicitud.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaSolicitud.Location = New System.Drawing.Point(179, 127)
        Me.DtpFechaSolicitud.Margin = New System.Windows.Forms.Padding(2)
        Me.DtpFechaSolicitud.Name = "DtpFechaSolicitud"
        Me.DtpFechaSolicitud.Size = New System.Drawing.Size(121, 20)
        Me.DtpFechaSolicitud.TabIndex = 35
        '
        'BtnAvales
        '
        Me.BtnAvales.BackColor = System.Drawing.Color.Teal
        Me.BtnAvales.Font = New System.Drawing.Font("Lucida Bright", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAvales.Location = New System.Drawing.Point(599, 172)
        Me.BtnAvales.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnAvales.Name = "BtnAvales"
        Me.BtnAvales.Size = New System.Drawing.Size(114, 38)
        Me.BtnAvales.TabIndex = 34
        Me.BtnAvales.Text = "Avales"
        Me.BtnAvales.UseVisualStyleBackColor = False
        '
        'CboFinalidadPrestamo
        '
        Me.CboFinalidadPrestamo.FormattingEnabled = True
        Me.CboFinalidadPrestamo.Location = New System.Drawing.Point(179, 158)
        Me.CboFinalidadPrestamo.Margin = New System.Windows.Forms.Padding(2)
        Me.CboFinalidadPrestamo.Name = "CboFinalidadPrestamo"
        Me.CboFinalidadPrestamo.Size = New System.Drawing.Size(121, 21)
        Me.CboFinalidadPrestamo.TabIndex = 33
        '
        'CboTipoPrestamo
        '
        Me.CboTipoPrestamo.FormattingEnabled = True
        Me.CboTipoPrestamo.Location = New System.Drawing.Point(599, 123)
        Me.CboTipoPrestamo.Margin = New System.Windows.Forms.Padding(2)
        Me.CboTipoPrestamo.Name = "CboTipoPrestamo"
        Me.CboTipoPrestamo.Size = New System.Drawing.Size(128, 21)
        Me.CboTipoPrestamo.TabIndex = 32
        '
        'CboEstadoPrestamo
        '
        Me.CboEstadoPrestamo.FormattingEnabled = True
        Me.CboEstadoPrestamo.Location = New System.Drawing.Point(599, 84)
        Me.CboEstadoPrestamo.Margin = New System.Windows.Forms.Padding(2)
        Me.CboEstadoPrestamo.Name = "CboEstadoPrestamo"
        Me.CboEstadoPrestamo.Size = New System.Drawing.Size(92, 21)
        Me.CboEstadoPrestamo.TabIndex = 31
        '
        'TxtPlazoPago
        '
        Me.TxtPlazoPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPlazoPago.Location = New System.Drawing.Point(599, 50)
        Me.TxtPlazoPago.Multiline = True
        Me.TxtPlazoPago.Name = "TxtPlazoPago"
        Me.TxtPlazoPago.Size = New System.Drawing.Size(109, 20)
        Me.TxtPlazoPago.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(446, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 19)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Plazo de Pago"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Location = New System.Drawing.Point(17, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 19)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Fecha de Solicitud"
        '
        'TxtCodigoOficial
        '
        Me.TxtCodigoOficial.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodigoOficial.Location = New System.Drawing.Point(179, 85)
        Me.TxtCodigoOficial.Multiline = True
        Me.TxtCodigoOficial.Name = "TxtCodigoOficial"
        Me.TxtCodigoOficial.Size = New System.Drawing.Size(140, 20)
        Me.TxtCodigoOficial.TabIndex = 26
        '
        'TxtSumaOtorgada
        '
        Me.TxtSumaOtorgada.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSumaOtorgada.Location = New System.Drawing.Point(599, 11)
        Me.TxtSumaOtorgada.Multiline = True
        Me.TxtSumaOtorgada.Name = "TxtSumaOtorgada"
        Me.TxtSumaOtorgada.Size = New System.Drawing.Size(109, 20)
        Me.TxtSumaOtorgada.TabIndex = 25
        '
        'TxtTasaInteres
        '
        Me.TxtTasaInteres.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTasaInteres.Location = New System.Drawing.Point(179, 192)
        Me.TxtTasaInteres.Multiline = True
        Me.TxtTasaInteres.Name = "TxtTasaInteres"
        Me.TxtTasaInteres.Size = New System.Drawing.Size(109, 19)
        Me.TxtTasaInteres.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label10.Location = New System.Drawing.Point(440, 90)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(137, 19)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = " Estado Préstamo"
        '
        'TxtCodSocio
        '
        Me.TxtCodSocio.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodSocio.Location = New System.Drawing.Point(179, 50)
        Me.TxtCodSocio.Multiline = True
        Me.TxtCodSocio.Name = "TxtCodSocio"
        Me.TxtCodSocio.Size = New System.Drawing.Size(140, 20)
        Me.TxtCodSocio.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label9.Location = New System.Drawing.Point(17, 89)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(114, 19)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Código Oficial"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label7.Location = New System.Drawing.Point(36, 195)
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
        Me.Label11.Location = New System.Drawing.Point(446, 126)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(117, 19)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Tipo Préstamo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label8.Location = New System.Drawing.Point(446, 11)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(126, 19)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Suma Otorgada"
        '
        'TxtNumSolicitud
        '
        Me.TxtNumSolicitud.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNumSolicitud.Location = New System.Drawing.Point(179, 11)
        Me.TxtNumSolicitud.Multiline = True
        Me.TxtNumSolicitud.Name = "TxtNumSolicitud"
        Me.TxtNumSolicitud.Size = New System.Drawing.Size(121, 20)
        Me.TxtNumSolicitud.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label6.Location = New System.Drawing.Point(16, 162)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(151, 19)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Finalidad Préstamo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label4.Location = New System.Drawing.Point(16, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 19)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Código Socio"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label12.Location = New System.Drawing.Point(17, 11)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(158, 19)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Número de solicitud"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnCancelar)
        Me.GroupBox1.Controls.Add(Me.BtnModificar)
        Me.GroupBox1.Controls.Add(Me.BtnGuardar)
        Me.GroupBox1.Controls.Add(Me.BtnNuevo)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 237)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(803, 75)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BtnSalir.Location = New System.Drawing.Point(758, 47)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(75, 50)
        Me.BtnSalir.TabIndex = 4
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BtnCancelar.Location = New System.Drawing.Point(511, 18)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(75, 50)
        Me.BtnCancelar.TabIndex = 3
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'BtnModificar
        '
        Me.BtnModificar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BtnModificar.Location = New System.Drawing.Point(362, 18)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(75, 50)
        Me.BtnModificar.TabIndex = 2
        Me.BtnModificar.UseVisualStyleBackColor = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BtnGuardar.Location = New System.Drawing.Point(195, 18)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(75, 50)
        Me.BtnGuardar.TabIndex = 1
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BtnNuevo.Location = New System.Drawing.Point(42, 18)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(75, 50)
        Me.BtnNuevo.TabIndex = 0
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'TbListadoSolicitudes
        '
        Me.TbListadoSolicitudes.Controls.Add(Me.BtnBuscar)
        Me.TbListadoSolicitudes.Controls.Add(Me.BtnBuscarPorSocio)
        Me.TbListadoSolicitudes.Controls.Add(Me.TxtBuscarporSocio)
        Me.TbListadoSolicitudes.Controls.Add(Me.TxtBuscarporCodOficial)
        Me.TbListadoSolicitudes.Controls.Add(Me.RdbBuscarporCodSocio)
        Me.TbListadoSolicitudes.Controls.Add(Me.RdbBuscarporCodOficial)
        Me.TbListadoSolicitudes.Controls.Add(Me.LsvSolicitudes)
        Me.TbListadoSolicitudes.Controls.Add(Me.Label5)
        Me.TbListadoSolicitudes.Location = New System.Drawing.Point(4, 22)
        Me.TbListadoSolicitudes.Name = "TbListadoSolicitudes"
        Me.TbListadoSolicitudes.Padding = New System.Windows.Forms.Padding(3)
        Me.TbListadoSolicitudes.Size = New System.Drawing.Size(822, 318)
        Me.TbListadoSolicitudes.TabIndex = 1
        Me.TbListadoSolicitudes.Text = "Listado"
        Me.TbListadoSolicitudes.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(452, 34)
        Me.BtnBuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(56, 19)
        Me.BtnBuscar.TabIndex = 20
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'BtnBuscarPorSocio
        '
        Me.BtnBuscarPorSocio.Location = New System.Drawing.Point(452, 34)
        Me.BtnBuscarPorSocio.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnBuscarPorSocio.Name = "BtnBuscarPorSocio"
        Me.BtnBuscarPorSocio.Size = New System.Drawing.Size(56, 19)
        Me.BtnBuscarPorSocio.TabIndex = 19
        Me.BtnBuscarPorSocio.Text = "Buscar"
        Me.BtnBuscarPorSocio.UseVisualStyleBackColor = True
        '
        'TxtBuscarporSocio
        '
        Me.TxtBuscarporSocio.Location = New System.Drawing.Point(176, 35)
        Me.TxtBuscarporSocio.Name = "TxtBuscarporSocio"
        Me.TxtBuscarporSocio.Size = New System.Drawing.Size(272, 20)
        Me.TxtBuscarporSocio.TabIndex = 18
        '
        'TxtBuscarporCodOficial
        '
        Me.TxtBuscarporCodOficial.Location = New System.Drawing.Point(176, 35)
        Me.TxtBuscarporCodOficial.Name = "TxtBuscarporCodOficial"
        Me.TxtBuscarporCodOficial.Size = New System.Drawing.Size(272, 20)
        Me.TxtBuscarporCodOficial.TabIndex = 17
        '
        'RdbBuscarporCodSocio
        '
        Me.RdbBuscarporCodSocio.AutoSize = True
        Me.RdbBuscarporCodSocio.Location = New System.Drawing.Point(534, 20)
        Me.RdbBuscarporCodSocio.Margin = New System.Windows.Forms.Padding(2)
        Me.RdbBuscarporCodSocio.Name = "RdbBuscarporCodSocio"
        Me.RdbBuscarporCodSocio.Size = New System.Drawing.Size(88, 17)
        Me.RdbBuscarporCodSocio.TabIndex = 16
        Me.RdbBuscarporCodSocio.TabStop = True
        Me.RdbBuscarporCodSocio.Text = "Código Socio"
        Me.RdbBuscarporCodSocio.UseVisualStyleBackColor = True
        '
        'RdbBuscarporCodOficial
        '
        Me.RdbBuscarporCodOficial.AutoSize = True
        Me.RdbBuscarporCodOficial.Location = New System.Drawing.Point(534, 41)
        Me.RdbBuscarporCodOficial.Margin = New System.Windows.Forms.Padding(2)
        Me.RdbBuscarporCodOficial.Name = "RdbBuscarporCodOficial"
        Me.RdbBuscarporCodOficial.Size = New System.Drawing.Size(107, 17)
        Me.RdbBuscarporCodOficial.TabIndex = 15
        Me.RdbBuscarporCodOficial.TabStop = True
        Me.RdbBuscarporCodOficial.Text = "Código del Oficial"
        Me.RdbBuscarporCodOficial.UseVisualStyleBackColor = True
        '
        'LsvSolicitudes
        '
        Me.LsvSolicitudes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ChNumSolicitud, Me.ChFechaSolicitud, Me.ChTipoPrestamo, Me.ChCodigoSocio, Me.ChPlazoPago, Me.ChFinalidadPrestamo, Me.ChTasaInteres, Me.ChSumaOtorgada, Me.ChCodOficial, Me.ChEstadoPrestamo})
        Me.LsvSolicitudes.ContextMenuStrip = Me.CmsOpciones
        Me.LsvSolicitudes.FullRowSelect = True
        Me.LsvSolicitudes.GridLines = True
        Me.LsvSolicitudes.Location = New System.Drawing.Point(6, 81)
        Me.LsvSolicitudes.Name = "LsvSolicitudes"
        Me.LsvSolicitudes.Size = New System.Drawing.Size(806, 214)
        Me.LsvSolicitudes.TabIndex = 13
        Me.LsvSolicitudes.UseCompatibleStateImageBehavior = False
        Me.LsvSolicitudes.View = System.Windows.Forms.View.Details
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
        'CmsOpciones
        '
        Me.CmsOpciones.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.CmsOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.CmsOpciones.Name = "CmsOpciones"
        Me.CmsOpciones.Size = New System.Drawing.Size(118, 48)
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(122, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 15)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Buscar"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel1.Controls.Add(Me.BtnSalir)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(-3, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(837, 100)
        Me.Panel1.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Bright", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MintCream
        Me.Label3.Location = New System.Drawing.Point(265, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(345, 40)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Solicitud Préstamo"
        '
        'EpMensaje
        '
        Me.EpMensaje.ContainerControl = Me
        '
        'FrmSolicitudPrestamo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(836, 450)
        Me.Controls.Add(Me.TbMenu)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmSolicitudPrestamo"
        Me.Text = "FrmSolicitudPrestamo"
        Me.TbMenu.ResumeLayout(False)
        Me.TbDatosSolicitud.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.TbListadoSolicitudes.ResumeLayout(False)
        Me.TbListadoSolicitudes.PerformLayout()
        Me.CmsOpciones.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.EpMensaje, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TbMenu As TabControl
    Friend WithEvents TbDatosSolicitud As TabPage
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TxtPlazoPago As TextBox
    Friend WithEvents Label1 As Label
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
    Friend WithEvents LsvSolicitudes As ListView
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
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents CboTipoPrestamo As ComboBox
    Friend WithEvents CboEstadoPrestamo As ComboBox
    Friend WithEvents CboFinalidadPrestamo As ComboBox
    Friend WithEvents BtnAvales As Button
    Friend WithEvents DtpFechaSolicitud As DateTimePicker
    Friend WithEvents RdbBuscarporCodSocio As RadioButton
    Friend WithEvents RdbBuscarporCodOficial As RadioButton
    Friend WithEvents TxtBuscarporCodOficial As TextBox
    Friend WithEvents TxtBuscarporSocio As TextBox
    Friend WithEvents EpMensaje As ErrorProvider
    Friend WithEvents CmsOpciones As ContextMenuStrip
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BtnBuscarPorSocio As Button
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents BtnSeleccionarSocio As Button
    Friend WithEvents BtnSeleccionarOficial As Button
End Class
