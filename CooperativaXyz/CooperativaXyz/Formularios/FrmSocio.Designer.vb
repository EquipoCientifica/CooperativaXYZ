<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSocio
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TpSocio = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TxtTelefonoTrabajo = New System.Windows.Forms.TextBox()
        Me.TxtTelefonoCasa = New System.Windows.Forms.TextBox()
        Me.TxtIdLugarTrabajo = New System.Windows.Forms.ComboBox()
        Me.CboIdEstadoCivil = New System.Windows.Forms.ComboBox()
        Me.CboIdNacionalidad = New System.Windows.Forms.ComboBox()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtApellidos = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtRtn = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtNombres = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtCodigoSocio = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TpListado = New System.Windows.Forms.TabPage()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.LsvLugarTrabajo = New System.Windows.Forms.ListView()
        Me.ChCodSocio = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChNombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChApellidos = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChRTN = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChDireccion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChNacionalidad = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChEstadoCivil = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChLugarTrabajo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChTelefonoCasa = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChTelefonoTrabajo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TpSocio.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TpListado.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TpSocio)
        Me.TabControl1.Controls.Add(Me.TpListado)
        Me.TabControl1.Location = New System.Drawing.Point(4, 132)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1096, 512)
        Me.TabControl1.TabIndex = 14
        '
        'TpSocio
        '
        Me.TpSocio.Controls.Add(Me.GroupBox1)
        Me.TpSocio.Controls.Add(Me.Panel2)
        Me.TpSocio.Location = New System.Drawing.Point(4, 25)
        Me.TpSocio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TpSocio.Name = "TpSocio"
        Me.TpSocio.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TpSocio.Size = New System.Drawing.Size(1088, 483)
        Me.TpSocio.TabIndex = 0
        Me.TpSocio.Text = "Socio"
        Me.TpSocio.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Silver
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.BtnSalir)
        Me.GroupBox1.Controls.Add(Me.BtnCancelar)
        Me.GroupBox1.Controls.Add(Me.BtnModificar)
        Me.GroupBox1.Controls.Add(Me.BtnGuardar)
        Me.GroupBox1.Controls.Add(Me.BtnNuevo)
        Me.GroupBox1.Location = New System.Drawing.Point(35, 383)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(953, 86)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Azure
        Me.Button1.Location = New System.Drawing.Point(835, 17)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 62)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Mostrar Socios"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BtnSalir.Location = New System.Drawing.Point(697, 17)
        Me.BtnSalir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(100, 62)
        Me.BtnSalir.TabIndex = 4
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BtnCancelar.Location = New System.Drawing.Point(552, 17)
        Me.BtnCancelar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(100, 62)
        Me.BtnCancelar.TabIndex = 3
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'BtnModificar
        '
        Me.BtnModificar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BtnModificar.Location = New System.Drawing.Point(389, 17)
        Me.BtnModificar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(100, 62)
        Me.BtnModificar.TabIndex = 2
        Me.BtnModificar.UseVisualStyleBackColor = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BtnGuardar.Location = New System.Drawing.Point(213, 17)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(100, 62)
        Me.BtnGuardar.TabIndex = 1
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BtnNuevo.Location = New System.Drawing.Point(44, 17)
        Me.BtnNuevo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(100, 62)
        Me.BtnNuevo.TabIndex = 0
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel2.Controls.Add(Me.TxtTelefonoTrabajo)
        Me.Panel2.Controls.Add(Me.TxtTelefonoCasa)
        Me.Panel2.Controls.Add(Me.TxtIdLugarTrabajo)
        Me.Panel2.Controls.Add(Me.CboIdEstadoCivil)
        Me.Panel2.Controls.Add(Me.CboIdNacionalidad)
        Me.Panel2.Controls.Add(Me.TxtDireccion)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.TxtApellidos)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.TxtRtn)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.TxtNombres)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.TxtCodigoSocio)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(0, 30)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1071, 343)
        Me.Panel2.TabIndex = 14
        '
        'TxtTelefonoTrabajo
        '
        Me.TxtTelefonoTrabajo.Location = New System.Drawing.Point(779, 242)
        Me.TxtTelefonoTrabajo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTelefonoTrabajo.Multiline = True
        Me.TxtTelefonoTrabajo.Name = "TxtTelefonoTrabajo"
        Me.TxtTelefonoTrabajo.Size = New System.Drawing.Size(268, 24)
        Me.TxtTelefonoTrabajo.TabIndex = 24
        '
        'TxtTelefonoCasa
        '
        Me.TxtTelefonoCasa.Location = New System.Drawing.Point(779, 190)
        Me.TxtTelefonoCasa.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTelefonoCasa.Multiline = True
        Me.TxtTelefonoCasa.Name = "TxtTelefonoCasa"
        Me.TxtTelefonoCasa.Size = New System.Drawing.Size(268, 24)
        Me.TxtTelefonoCasa.TabIndex = 23
        '
        'TxtIdLugarTrabajo
        '
        Me.TxtIdLugarTrabajo.FormattingEnabled = True
        Me.TxtIdLugarTrabajo.Location = New System.Drawing.Point(779, 135)
        Me.TxtIdLugarTrabajo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtIdLugarTrabajo.Name = "TxtIdLugarTrabajo"
        Me.TxtIdLugarTrabajo.Size = New System.Drawing.Size(268, 24)
        Me.TxtIdLugarTrabajo.TabIndex = 22
        '
        'CboIdEstadoCivil
        '
        Me.CboIdEstadoCivil.FormattingEnabled = True
        Me.CboIdEstadoCivil.Location = New System.Drawing.Point(779, 71)
        Me.CboIdEstadoCivil.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CboIdEstadoCivil.Name = "CboIdEstadoCivil"
        Me.CboIdEstadoCivil.Size = New System.Drawing.Size(268, 24)
        Me.CboIdEstadoCivil.TabIndex = 21
        '
        'CboIdNacionalidad
        '
        Me.CboIdNacionalidad.FormattingEnabled = True
        Me.CboIdNacionalidad.Location = New System.Drawing.Point(779, 25)
        Me.CboIdNacionalidad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CboIdNacionalidad.Name = "CboIdNacionalidad"
        Me.CboIdNacionalidad.Size = New System.Drawing.Size(268, 24)
        Me.CboIdNacionalidad.TabIndex = 20
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Location = New System.Drawing.Point(176, 287)
        Me.TxtDireccion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtDireccion.Multiline = True
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(871, 24)
        Me.TxtDireccion.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label10.Location = New System.Drawing.Point(596, 190)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(146, 23)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Telefono Casa"
        '
        'TxtApellidos
        '
        Me.TxtApellidos.Location = New System.Drawing.Point(176, 133)
        Me.TxtApellidos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtApellidos.Multiline = True
        Me.TxtApellidos.Name = "TxtApellidos"
        Me.TxtApellidos.Size = New System.Drawing.Size(269, 24)
        Me.TxtApellidos.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label9.Location = New System.Drawing.Point(519, 133)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(222, 23)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Codigo Lugar Trabajo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label7.Location = New System.Drawing.Point(524, 22)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(209, 23)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Codigo Nacionalidad"
        '
        'TxtRtn
        '
        Me.TxtRtn.Location = New System.Drawing.Point(176, 210)
        Me.TxtRtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtRtn.Multiline = True
        Me.TxtRtn.Name = "TxtRtn"
        Me.TxtRtn.Size = New System.Drawing.Size(269, 26)
        Me.TxtRtn.TabIndex = 17
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label11.Location = New System.Drawing.Point(565, 242)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(176, 23)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Telefono Trabajo"
        '
        'TxtNombres
        '
        Me.TxtNombres.Location = New System.Drawing.Point(176, 71)
        Me.TxtNombres.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtNombres.Multiline = True
        Me.TxtNombres.Name = "TxtNombres"
        Me.TxtNombres.Size = New System.Drawing.Size(269, 26)
        Me.TxtNombres.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label8.Location = New System.Drawing.Point(541, 69)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(193, 23)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Codigo Estado Civil"
        '
        'TxtCodigoSocio
        '
        Me.TxtCodigoSocio.Location = New System.Drawing.Point(176, 18)
        Me.TxtCodigoSocio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtCodigoSocio.Multiline = True
        Me.TxtCodigoSocio.Name = "TxtCodigoSocio"
        Me.TxtCodigoSocio.Size = New System.Drawing.Size(117, 26)
        Me.TxtCodigoSocio.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label6.Location = New System.Drawing.Point(40, 286)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 23)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Direccion"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label5.Location = New System.Drawing.Point(75, 213)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 23)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "RTN"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label4.Location = New System.Drawing.Point(48, 133)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 23)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Apellidos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Location = New System.Drawing.Point(57, 69)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nombres"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(17, 21)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Codigo Socio"
        '
        'TpListado
        '
        Me.TpListado.Controls.Add(Me.Label12)
        Me.TpListado.Controls.Add(Me.TxtBuscar)
        Me.TpListado.Controls.Add(Me.LsvLugarTrabajo)
        Me.TpListado.Location = New System.Drawing.Point(4, 25)
        Me.TpListado.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TpListado.Name = "TpListado"
        Me.TpListado.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TpListado.Size = New System.Drawing.Size(1087, 483)
        Me.TpListado.TabIndex = 1
        Me.TpListado.Text = "Listado"
        Me.TpListado.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(169, 44)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 17)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Buscar:"
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Location = New System.Drawing.Point(291, 41)
        Me.TxtBuscar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(287, 22)
        Me.TxtBuscar.TabIndex = 2
        '
        'LsvLugarTrabajo
        '
        Me.LsvLugarTrabajo.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ChCodSocio, Me.ChNombre, Me.ChApellidos, Me.ChRTN, Me.ChDireccion, Me.ChNacionalidad, Me.ChEstadoCivil, Me.ChLugarTrabajo, Me.ChTelefonoCasa, Me.ChTelefonoTrabajo})
        Me.LsvLugarTrabajo.GridLines = True
        Me.LsvLugarTrabajo.Location = New System.Drawing.Point(13, 95)
        Me.LsvLugarTrabajo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LsvLugarTrabajo.Name = "LsvLugarTrabajo"
        Me.LsvLugarTrabajo.Size = New System.Drawing.Size(1053, 341)
        Me.LsvLugarTrabajo.TabIndex = 1
        Me.LsvLugarTrabajo.UseCompatibleStateImageBehavior = False
        Me.LsvLugarTrabajo.View = System.Windows.Forms.View.Details
        '
        'ChCodSocio
        '
        Me.ChCodSocio.Text = "Código Socio"
        Me.ChCodSocio.Width = 80
        '
        'ChNombre
        '
        Me.ChNombre.Text = "Nombre"
        Me.ChNombre.Width = 100
        '
        'ChApellidos
        '
        Me.ChApellidos.Text = "Apellidos"
        Me.ChApellidos.Width = 100
        '
        'ChRTN
        '
        Me.ChRTN.Text = "RTN"
        Me.ChRTN.Width = 80
        '
        'ChDireccion
        '
        Me.ChDireccion.Text = "Direccion"
        Me.ChDireccion.Width = 120
        '
        'ChNacionalidad
        '
        Me.ChNacionalidad.Text = "Nacionalidad"
        Me.ChNacionalidad.Width = 100
        '
        'ChEstadoCivil
        '
        Me.ChEstadoCivil.Text = "Estado Civil"
        Me.ChEstadoCivil.Width = 80
        '
        'ChLugarTrabajo
        '
        Me.ChLugarTrabajo.Text = "Lugar Trabajo"
        Me.ChLugarTrabajo.Width = 80
        '
        'ChTelefonoCasa
        '
        Me.ChTelefonoCasa.Text = "Teléfono Casa"
        Me.ChTelefonoCasa.Width = 80
        '
        'ChTelefonoTrabajo
        '
        Me.ChTelefonoTrabajo.Text = "Teléfono Trabajo"
        Me.ChTelefonoTrabajo.Width = 80
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(4, 1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1092, 123)
        Me.Panel1.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Bright", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MintCream
        Me.Label3.Location = New System.Drawing.Point(345, 44)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(315, 51)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Gestion Socio"
        '
        'FrmSocio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1102, 643)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmSocio"
        Me.Text = "FrmSocio"
        Me.TabControl1.ResumeLayout(False)
        Me.TpSocio.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TpListado.ResumeLayout(False)
        Me.TpListado.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TpSocio As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TxtTelefonoTrabajo As TextBox
    Friend WithEvents TxtTelefonoCasa As TextBox
    Friend WithEvents TxtIdLugarTrabajo As ComboBox
    Friend WithEvents CboIdEstadoCivil As ComboBox
    Friend WithEvents CboIdNacionalidad As ComboBox
    Friend WithEvents TxtDireccion As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtApellidos As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtRtn As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtNombres As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtCodigoSocio As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TpListado As TabPage
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents LsvLugarTrabajo As ListView
    Friend WithEvents ChCodSocio As ColumnHeader
    Friend WithEvents ChNombre As ColumnHeader
    Friend WithEvents ChApellidos As ColumnHeader
    Friend WithEvents ChRTN As ColumnHeader
    Friend WithEvents ChDireccion As ColumnHeader
    Friend WithEvents ChNacionalidad As ColumnHeader
    Friend WithEvents ChEstadoCivil As ColumnHeader
    Friend WithEvents ChLugarTrabajo As ColumnHeader
    Friend WithEvents ChTelefonoCasa As ColumnHeader
    Friend WithEvents ChTelefonoTrabajo As ColumnHeader
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
End Class
