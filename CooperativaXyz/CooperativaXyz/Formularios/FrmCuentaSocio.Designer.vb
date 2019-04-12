<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCuentaSocio
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
        Me.TcListadoCuentaSocio = New System.Windows.Forms.TabControl()
        Me.TbCuentaSocio = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CboTipoCuenta = New System.Windows.Forms.ComboBox()
        Me.BtnFiltrar = New System.Windows.Forms.Button()
        Me.DtpFechaApertura = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtSaldoActual = New System.Windows.Forms.TextBox()
        Me.TxtCodSocio = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtNumCuenta = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.TbListadoOficiales = New System.Windows.Forms.TabPage()
        Me.LsvCuentaSocio = New System.Windows.Forms.ListView()
        Me.CHNumCuenta = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CHCodigoSocio = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CHTipoCuenta = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CHSaldoActual = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CHFecha = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TxtBuscarCuentaSocio = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.EpMensaje = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.CmOpciones = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TcListadoCuentaSocio.SuspendLayout()
        Me.TbCuentaSocio.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TbListadoOficiales.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.EpMensaje, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CmOpciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'TcListadoCuentaSocio
        '
        Me.TcListadoCuentaSocio.Controls.Add(Me.TbCuentaSocio)
        Me.TcListadoCuentaSocio.Controls.Add(Me.TbListadoOficiales)
        Me.TcListadoCuentaSocio.Location = New System.Drawing.Point(-11, 118)
        Me.TcListadoCuentaSocio.Name = "TcListadoCuentaSocio"
        Me.TcListadoCuentaSocio.SelectedIndex = 0
        Me.TcListadoCuentaSocio.Size = New System.Drawing.Size(823, 320)
        Me.TcListadoCuentaSocio.TabIndex = 15
        '
        'TbCuentaSocio
        '
        Me.TbCuentaSocio.Controls.Add(Me.Panel2)
        Me.TbCuentaSocio.Controls.Add(Me.GroupBox1)
        Me.TbCuentaSocio.Location = New System.Drawing.Point(4, 22)
        Me.TbCuentaSocio.Name = "TbCuentaSocio"
        Me.TbCuentaSocio.Padding = New System.Windows.Forms.Padding(3)
        Me.TbCuentaSocio.Size = New System.Drawing.Size(815, 294)
        Me.TbCuentaSocio.TabIndex = 0
        Me.TbCuentaSocio.Text = "Datos Cuenta Socio"
        Me.TbCuentaSocio.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel2.Controls.Add(Me.CboTipoCuenta)
        Me.Panel2.Controls.Add(Me.BtnFiltrar)
        Me.Panel2.Controls.Add(Me.DtpFechaApertura)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.TxtSaldoActual)
        Me.Panel2.Controls.Add(Me.TxtCodSocio)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.TxtNumCuenta)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(6, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(803, 179)
        Me.Panel2.TabIndex = 16
        '
        'CboTipoCuenta
        '
        Me.CboTipoCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboTipoCuenta.FormattingEnabled = True
        Me.CboTipoCuenta.Location = New System.Drawing.Point(176, 102)
        Me.CboTipoCuenta.Name = "CboTipoCuenta"
        Me.CboTipoCuenta.Size = New System.Drawing.Size(185, 26)
        Me.CboTipoCuenta.TabIndex = 28
        '
        'BtnFiltrar
        '
        Me.BtnFiltrar.Location = New System.Drawing.Point(327, 54)
        Me.BtnFiltrar.Name = "BtnFiltrar"
        Me.BtnFiltrar.Size = New System.Drawing.Size(34, 23)
        Me.BtnFiltrar.TabIndex = 27
        Me.BtnFiltrar.Text = "..."
        Me.BtnFiltrar.UseVisualStyleBackColor = True
        '
        'DtpFechaApertura
        '
        Me.DtpFechaApertura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaApertura.Location = New System.Drawing.Point(529, 57)
        Me.DtpFechaApertura.Name = "DtpFechaApertura"
        Me.DtpFechaApertura.Size = New System.Drawing.Size(121, 20)
        Me.DtpFechaApertura.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Location = New System.Drawing.Point(525, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 19)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Fecha Apertura"
        '
        'TxtSaldoActual
        '
        Me.TxtSaldoActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSaldoActual.Location = New System.Drawing.Point(176, 145)
        Me.TxtSaldoActual.Multiline = True
        Me.TxtSaldoActual.Name = "TxtSaldoActual"
        Me.TxtSaldoActual.Size = New System.Drawing.Size(185, 23)
        Me.TxtSaldoActual.TabIndex = 19
        '
        'TxtCodSocio
        '
        Me.TxtCodSocio.Enabled = False
        Me.TxtCodSocio.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodSocio.Location = New System.Drawing.Point(176, 56)
        Me.TxtCodSocio.Multiline = True
        Me.TxtCodSocio.Name = "TxtCodSocio"
        Me.TxtCodSocio.Size = New System.Drawing.Size(155, 20)
        Me.TxtCodSocio.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label7.Location = New System.Drawing.Point(26, 149)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 19)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Saldo Actual"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label11.Location = New System.Drawing.Point(25, 104)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(102, 19)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Tipo Cuenta"
        '
        'TxtNumCuenta
        '
        Me.TxtNumCuenta.Enabled = False
        Me.TxtNumCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNumCuenta.Location = New System.Drawing.Point(176, 17)
        Me.TxtNumCuenta.Multiline = True
        Me.TxtNumCuenta.Name = "TxtNumCuenta"
        Me.TxtNumCuenta.Size = New System.Drawing.Size(185, 23)
        Me.TxtNumCuenta.TabIndex = 15
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(14, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Numero Cuenta"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnSalir)
        Me.GroupBox1.Controls.Add(Me.BtnCancelar)
        Me.GroupBox1.Controls.Add(Me.BtnModificar)
        Me.GroupBox1.Controls.Add(Me.BtnGuardar)
        Me.GroupBox1.Controls.Add(Me.BtnNuevo)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 178)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(803, 110)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BtnSalir.Location = New System.Drawing.Point(655, 28)
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
        'TbListadoOficiales
        '
        Me.TbListadoOficiales.Controls.Add(Me.LsvCuentaSocio)
        Me.TbListadoOficiales.Controls.Add(Me.TxtBuscarCuentaSocio)
        Me.TbListadoOficiales.Controls.Add(Me.Label5)
        Me.TbListadoOficiales.Location = New System.Drawing.Point(4, 22)
        Me.TbListadoOficiales.Name = "TbListadoOficiales"
        Me.TbListadoOficiales.Padding = New System.Windows.Forms.Padding(3)
        Me.TbListadoOficiales.Size = New System.Drawing.Size(815, 294)
        Me.TbListadoOficiales.TabIndex = 1
        Me.TbListadoOficiales.Text = "Listado"
        Me.TbListadoOficiales.UseVisualStyleBackColor = True
        '
        'LsvCuentaSocio
        '
        Me.LsvCuentaSocio.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CHNumCuenta, Me.CHCodigoSocio, Me.CHTipoCuenta, Me.CHSaldoActual, Me.CHFecha})
        Me.LsvCuentaSocio.FullRowSelect = True
        Me.LsvCuentaSocio.GridLines = True
        Me.LsvCuentaSocio.Location = New System.Drawing.Point(12, 56)
        Me.LsvCuentaSocio.Name = "LsvCuentaSocio"
        Me.LsvCuentaSocio.Size = New System.Drawing.Size(795, 225)
        Me.LsvCuentaSocio.TabIndex = 17
        Me.LsvCuentaSocio.UseCompatibleStateImageBehavior = False
        Me.LsvCuentaSocio.View = System.Windows.Forms.View.Details
        '
        'CHNumCuenta
        '
        Me.CHNumCuenta.Text = "Numero Cuenta"
        Me.CHNumCuenta.Width = 150
        '
        'CHCodigoSocio
        '
        Me.CHCodigoSocio.Text = "Codigo Socio"
        Me.CHCodigoSocio.Width = 150
        '
        'CHTipoCuenta
        '
        Me.CHTipoCuenta.Text = "TipoCuenta"
        Me.CHTipoCuenta.Width = 150
        '
        'CHSaldoActual
        '
        Me.CHSaldoActual.Text = "Saldo Actual"
        Me.CHSaldoActual.Width = 150
        '
        'CHFecha
        '
        Me.CHFecha.Text = "Fecha Apertura"
        Me.CHFecha.Width = 150
        '
        'TxtBuscarCuentaSocio
        '
        Me.TxtBuscarCuentaSocio.Location = New System.Drawing.Point(279, 30)
        Me.TxtBuscarCuentaSocio.Name = "TxtBuscarCuentaSocio"
        Me.TxtBuscarCuentaSocio.Size = New System.Drawing.Size(272, 20)
        Me.TxtBuscarCuentaSocio.TabIndex = 12
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
        Me.Panel1.Location = New System.Drawing.Point(-11, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(819, 100)
        Me.Panel1.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Bright", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MintCream
        Me.Label3.Location = New System.Drawing.Point(235, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(246, 40)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Cuenta Socio"
        '
        'EpMensaje
        '
        Me.EpMensaje.ContainerControl = Me
        '
        'CmOpciones
        '
        Me.CmOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.CmOpciones.Name = "CmOpciones"
        Me.CmOpciones.Size = New System.Drawing.Size(118, 48)
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
        'FrmCuentaSocio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ContextMenuStrip = Me.CmOpciones
        Me.Controls.Add(Me.TcListadoCuentaSocio)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmCuentaSocio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmCuentaSocio"
        Me.TcListadoCuentaSocio.ResumeLayout(False)
        Me.TbCuentaSocio.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.TbListadoOficiales.ResumeLayout(False)
        Me.TbListadoOficiales.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.EpMensaje, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CmOpciones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TcListadoCuentaSocio As TabControl
    Friend WithEvents TbCuentaSocio As TabPage
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DtpFechaApertura As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtSaldoActual As TextBox
    Friend WithEvents TxtCodSocio As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtNumCuenta As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents TbListadoOficiales As TabPage
    Friend WithEvents LsvCuentaSocio As ListView
    Friend WithEvents CHNumCuenta As ColumnHeader
    Friend WithEvents CHCodigoSocio As ColumnHeader
    Friend WithEvents CHTipoCuenta As ColumnHeader
    Friend WithEvents CHSaldoActual As ColumnHeader
    Friend WithEvents CHFecha As ColumnHeader
    Friend WithEvents TxtBuscarCuentaSocio As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents CboTipoCuenta As ComboBox
    Friend WithEvents BtnFiltrar As Button
    Friend WithEvents EpMensaje As ErrorProvider
    Friend WithEvents CmOpciones As ContextMenuStrip
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
End Class
